using System.Windows;

namespace Library.Helper
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CustomMessageBox : Window
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }
        private void CloseMessageBox(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void Show(string msg)
        {
            MessageLbl.Content = msg;
            this.ShowDialog();
        }
    }
}
