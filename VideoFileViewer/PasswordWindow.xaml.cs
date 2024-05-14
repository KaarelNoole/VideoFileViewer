using System.Windows;
using VideoOS.Platform.UI.Controls;

namespace VideoFileViewer
{
    public partial class PasswordWindow : VideoOSWindow
    {
        public string Password => _passwordTextBox.Password;

        public PasswordWindow()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}