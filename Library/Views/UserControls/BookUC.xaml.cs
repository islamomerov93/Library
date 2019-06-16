using Library.Domain.Entities;
using Library.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Library.Views.UserControls
{
    /// <summary>
    /// Interaction logic for BookUC.xaml
    /// </summary>
    public partial class BookUC : UserControl
    {
        public BookVM BookVM;
        public BookUC()
        {
            InitializeComponent();
            BookVM = new BookVM();
            BookVM.Books = new ObservableCollection<Book>(App.UnitOfWork.Books.GetAll());
            BookVM.Branches = new ObservableCollection<Branch>(App.UnitOfWork.Branches.GetAll());
            BookVM.btnAddBook = btnAddBook;
            DataContext = BookVM;
        }
        void closeButton_Click(object sender, RoutedEventArgs e)
        {
            LibraryVM.Grid.Children.Remove(this);
        }
    }
}
