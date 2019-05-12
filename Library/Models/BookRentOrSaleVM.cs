using Library.Entities;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
