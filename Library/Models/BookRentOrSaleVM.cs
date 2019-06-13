using Library.Models;
using System.Collections.ObjectModel;

namespace Library.ViewModels
{
    class BookRentOrSaleVM : BaseVM
    {
        public BookRentOrSaleVM()
        {
        }

        ObservableCollection<Book_StatusModel> books;
        public ObservableCollection<Book_StatusModel> AllBooks {
            get { return books; }
            set { books = value; OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(AllBooks))); }
        }
    }
}
