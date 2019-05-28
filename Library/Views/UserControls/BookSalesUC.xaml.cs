using Library.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Library.Views.UserControls
{
    /// <summary>
    /// Interaction logic for BookSalesUC.xaml
    /// </summary>
    public partial class BookSalesUC : UserControl
    {
        public BookSalesUC()
        {
            InitializeComponent();
        }
        void closeButton_Click(object sender, RoutedEventArgs e)
        {
            LibraryVM.Grid.Children.Remove(this);
        }
    }
}
