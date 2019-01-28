using System.Windows.Forms;

namespace UnicodePad
{
    public partial class Settings : Form
    {
        private readonly Configuration _configuration;

        public Settings()
        {
            InitializeComponent();

            closeButton.Click += (sender, args) =>
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };
            buttonOK.Click += (sender, args) =>
            {
                _configuration.SaveSettings();
                DialogResult = DialogResult.OK;
                Close();
            };
            _configuration = new Configuration();
            _configuration.LoadSettings();

            properties.SelectedObject = _configuration;
        }
    }
}
