using System;
using System.Windows;
using VideoOS.Platform.UI.Controls;

namespace VideoFileViewer
{
    public partial class PasswordWindow : VideoOSWindow
    {
        string password;
        public PasswordWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public string Password
        {
            get { return password; }
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }
    }
}
