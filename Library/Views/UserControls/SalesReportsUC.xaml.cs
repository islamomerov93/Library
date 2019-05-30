using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library.Views.UserControls
{
    /// <summary>
    /// Interaction logic for SalesReportsUC.xaml
    /// </summary>
    public partial class SalesReportsUC : UserControl
    {
        public SalesReportsUC()
        {
            InitializeComponent();
        }
        void closeButton_Click(object sender, RoutedEventArgs e)
        {
            LibraryVM.Grid.Children.Remove(this);
        }
    }
}
