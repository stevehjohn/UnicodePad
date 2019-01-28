using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Reflection;

namespace UnicodePad
{
    public class Configuration
    {
        [Category("Colours")]
        [DisplayName("Main window background colour")]
        public Color FormBackColor { get; set; }

        [Category("Colours")]
        [DisplayName("Add button background colour")]
        public Color AddButtonBackColor { get; set; }

        [Category("Colours")]
        [DisplayName("Add button foreground colour")]
        public Color AddButtonForeColor { get; set; }

        [Category("Colours")]
        [DisplayName("Add button background colour when mouse is over it")]
        public Color AddButtonHoverColor { get; set; }

        [Category("Colours")]
        [DisplayName("Add button background colour when clicked")]
        public Color AddButtonClickColor { get; set; }

        [Category("Colours")]
        [DisplayName("Delete zone background colour")]
        public Color DeleteButtonBackColor { get; set; }

        [Category("Colours")]
        [DisplayName("Delete zone foreground colour")]
        public Color DeleteButtonForeColor { get; set; }

        [Category("Colours")]
        [DisplayName("Resize handle foreground colour")]
        public Color ResizerForeColor { get; set; }

        [Category("Colours")]
        [DisplayName("Minimise button background colour")]
        public Color MinimiseButtonBackColor { get; set; }

        [Category("Colours")]
        [DisplayName("Minimise button foreground colour")]
        public Color MinimiseButtonForeColor { get; set; }

        [Category("Colours")]
        [DisplayName("Minimise button background colour when mouse is over it")]
        public Color MinimiseButtonHoverColor { get; set; }

        [Category("Colours")]
        [DisplayName("Minimise button background colour when clicked")]
        public Color MinimiseButtonClickColor { get; set; }

        [Category("Colours")]
        [DisplayName("Close button background colour")]
        public Color CloseButtonBackColor { get; set; }

        [Category("Colours")]
        [DisplayName("Close button foreground colour")]
        public Color CloseButtonForeColor { get; set; }

        [Category("Colours")]
        [DisplayName("Close button background colour when mouse is over it")]
        public Color CloseButtonHoverColor { get; set; }

        [Category("Colours")]
        [DisplayName("Close button background colour when clicked")]
        public Color CloseButtonClickColor { get; set; }

        [Category("Colours")]
        [DisplayName("Symbol button background colour")]
        public Color ButtonBackColor { get; set; }

        [Category("Colours")]
        [DisplayName("Symbol  button foreground colour")]
        public Color ButtonForeColor { get; set; }

        [Category("Colours")]
        [DisplayName("Symbol  button background colour when mouse is over it")]
        public Color ButtonHoverColor { get; set; }

        [Category("Colours")]
        [DisplayName("Symbol  button background colour when clicked")]
        public Color ButtonClickColor { get; set; }

        [Category("General")]
        [DisplayName("Keep Unicode Pad window on top of others")]
        public bool AlwaysOnTop { get; set; }

        public void LoadSettings()
        {
            var properties = GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

            foreach (var property in properties)
            {
                var setting = ConfigurationManager.AppSettings[property.Name];

                switch (property.PropertyType.Name)
                {
                    case "Color":
                        try
                        {
                            var parts = setting.Split(',');

                            var color = Color.FromArgb(
                                int.Parse(parts[0]),
                                int.Parse(parts[1]),
                                int.Parse(parts[2]),
                                int.Parse(parts[3]));

                            property.SetValue(this, color);
                        }
                        catch
                        {
                            //
                        }
                        break;
                    case "Boolean":
                        try
                        {
                            property.SetValue(this, bool.Parse(setting));
                        }
                        catch
                        {
                            //
                        }

                        break;
                    default:
                        property.SetValue(this, setting);
                        break;
                }
            }
        }

        public void SaveSettings()
        {
            var properties = GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            foreach (var property in properties)
            {
                switch (property.PropertyType.Name)
                {
                    case "Color":
                        var value = (Color) property.GetValue(this);
                        config.AppSettings.Settings[property.Name].Value = $"{value.A},{value.R},{value.G},{value.B}";
                        break;
                    case "Boolean":
                        config.AppSettings.Settings[property.Name].Value = ((bool) property.GetValue(this)).ToString();
                        break;
                    default:
                        config.AppSettings.Settings[property.Name].Value = (string) property.GetValue(this);
                        break;
                }
            }

            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}