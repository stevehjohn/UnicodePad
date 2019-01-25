﻿using System;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UnicodePad
{
    public partial class MainForm : Form
    {
        private bool _dragging;
        private Point _position;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMouseDown(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var dataObject = new DataObject(DataFormats.StringFormat);
            dataObject.SetText(button.Text);
            Clipboard.SetDataObject(dataObject);
            DoDragDrop(dataObject, DragDropEffects.All);
        }

        private void MainFormMouseDown(object sender, EventArgs e)
        {
            _dragging = true;

            _position = Cursor.Position;
        }

        private void MainFormMouseMove(object sender, EventArgs e)
        {
            if (_dragging)
            {
                var position = Cursor.Position;

                Top += position.Y - _position.Y;
                Left += position.X - _position.X;

                _position = position;
            }
        }

        private void ResizeButtonMouseUp(object sender, EventArgs e)
        {
            _dragging = false;

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["width"].Value = Width.ToString();
            config.AppSettings.Settings["height"].Value = Height.ToString();
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void ResizeButtonMouseDown(object sender, EventArgs e)
        {
            _dragging = true;

            _position = Cursor.Position;
        }

        private void ResizeButtonMouseMove(object sender, EventArgs e)
        {
            if (_dragging)
            {
                var position = Cursor.Position;

                var newHeight = Height + position.Y - _position.Y;
                var newWidth = Width + position.X - _position.X;

                if (newWidth < 100)
                {
                    Width = 100;
                }
                else
                {
                    Width = newWidth;
                }

                if (newHeight < 200)
                {
                    Height = 200;
                }
                else
                {
                    Height = newHeight;
                }

                _position = position;
            }
        }

        private void MainFormMouseUp(object sender, EventArgs e)
        {
            _dragging = false;
        }

        private void MainFormResize(object sender, EventArgs e)
        {
            buttonPanel.Width = Width;
            buttonPanel.Height = Height - 36;

            resizeButton.Top = Height - resizeButton.Height;
            resizeButton.Left = Width - resizeButton.Width;
            resizeButton.Visible = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var newCharacters = Microsoft.VisualBasic.Interaction.InputBox("Enter character(s) to add").Trim();

            if (string.IsNullOrWhiteSpace(newCharacters))
            {
                return;
            }

            var characters = ConfigurationManager.AppSettings["characters"];

            characters = $"{characters},{newCharacters}";

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["characters"].Value = characters;
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");

            PopulateButtons();
        }

        public void ButtonMouseEnter(object sender, EventArgs e)
        {
            var button = (Button) sender;
            buttonDelete.Top = buttonPanel.Top + button.Top;
            buttonDelete.Left = button.Left + button.Width - buttonDelete.Width;
            buttonDelete.Visible = true;
            buttonDelete.Tag = button.Text;
        }

        public void ButtonMouseLeave(object sender, EventArgs e)
        {
            buttonDelete.Visible = false;
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            var characters = ConfigurationManager.AppSettings["characters"].Split(',');

            var button = (Button) sender;
            characters = characters.Where(c => c != (string) button.Tag).ToArray();

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["characters"].Value = string.Join(",", characters);
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}