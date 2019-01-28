using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace UnicodePad
{
    public partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.resizeButton = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonMinimise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 36);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(800, 414);
            this.buttonPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(764, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(36, 36);
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Text = "r";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(36, 36);
            this.addButton.TabIndex = 2;
            this.addButton.TabStop = false;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // resizeButton
            // 
            this.resizeButton.BackColor = System.Drawing.Color.Transparent;
            this.resizeButton.FlatAppearance.BorderSize = 0;
            this.resizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resizeButton.Font = new System.Drawing.Font("Marlett", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.resizeButton.ForeColor = System.Drawing.Color.White;
            this.resizeButton.Location = new System.Drawing.Point(382, 0);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.resizeButton.Size = new System.Drawing.Size(36, 36);
            this.resizeButton.TabIndex = 3;
            this.resizeButton.TabStop = false;
            this.resizeButton.Text = "o";
            this.resizeButton.UseVisualStyleBackColor = false;
            this.resizeButton.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.AllowDrop = true;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(36, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(36, 36);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Text = "-";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonMinimise
            // 
            this.buttonMinimise.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimise.FlatAppearance.BorderSize = 0;
            this.buttonMinimise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonMinimise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimise.Font = new System.Drawing.Font("Marlett", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMinimise.ForeColor = System.Drawing.Color.White;
            this.buttonMinimise.Location = new System.Drawing.Point(728, 0);
            this.buttonMinimise.Name = "buttonMinimise";
            this.buttonMinimise.Size = new System.Drawing.Size(36, 36);
            this.buttonMinimise.TabIndex = 5;
            this.buttonMinimise.TabStop = false;
            this.buttonMinimise.Text = "q";
            this.buttonMinimise.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonMinimise);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.resizeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.buttonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Unicode Pad";
            this.ResumeLayout(false);

        }

        #endregion

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            MouseDown += MainFormMouseDown;
            MouseUp += MainFormMouseUp;
            MouseMove += MainFormMouseMove;
            Resize += MainFormResize;

            resizeButton.MouseDown += ResizeButtonMouseDown;
            resizeButton.MouseUp += ResizeButtonMouseUp;
            resizeButton.MouseMove += ResizeButtonMouseMove;

            if (int.TryParse(ConfigurationManager.AppSettings["width"], out var width) && width > 0)
            {
                Width = width;
            }
            if (int.TryParse(ConfigurationManager.AppSettings["height"], out var height) && height > 0)
            {
                Height = height;
            }

            PopulateButtons();

            MainFormResize(null, null);

            buttonDelete.DragDrop += ButtonDeleteOnDragDrop;
            buttonDelete.DragOver += ButtonDeleteOnDragOver;

            buttonMinimise.Click += (sender, args) => { WindowState = FormWindowState.Minimized; };

            TopMost = true;
        }

        private void PopulateButtons()
        {
            buttonPanel.Controls.Clear();

            var symbols = ConfigurationManager.AppSettings["characters"].Split(',');

            foreach (var symbol in symbols)
            {
                var button = new Button()
                {
                    Text = symbol,
                    TabStop = false,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(30, 30, 30),
                    ForeColor = Color.White,
                    Width = 60,
                    Height = 60
                };
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
                button.MouseDown += ButtonMouseDown;
                button.Font = new Font("Consolas", 16);
                buttonPanel.Controls.Add(button);
            }
        }

        private FlowLayoutPanel buttonPanel;
        private Button closeButton;
        private Button addButton;
        private Button resizeButton;
        private Button buttonDelete;
        private Button buttonMinimise;
    }
}

