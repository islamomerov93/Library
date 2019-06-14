using Library.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Library
{
    public partial class MainWindow : Window
    {
        LibraryVM LibraryVM;
        DispatcherTimer _timer;
        TimeSpan _time;
        DispatcherTimer _timer2;
        TimeSpan _time2;

        object objectNew;
        public MainWindow()
        {
            InitializeComponent();
            _time2 = TimeSpan.FromSeconds(3);

            _timer2 = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                if (_time2.Seconds == 3) btnTopMenuShow_Click(objectNew, new RoutedEventArgs()); 
                if (_time2 == TimeSpan.Zero) _timer2.Stop();
                _time2 = _time2.Add(TimeSpan.FromSeconds(-1));
                if (_time2.Seconds == 0) btnTopMenuHide_Click(objectNew, new RoutedEventArgs());
            }, Application.Current.Dispatcher);
            _timer2.Start();

            this.LibraryVM = new LibraryVM();
            LibraryVM.Grid = MainGrid;
            DataContext = LibraryVM;
        }

        protected void DragWindow(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        bool maximized;
        protected void Double_Click(object sender, MouseButtonEventArgs e)
        {
            if (maximized) this.WindowState = WindowState.Normal;
            else this.WindowState = WindowState.Maximized;
            maximized = !maximized;
        }

        private void btnLeftMenuShow_Click(object sender, RoutedEventArgs e)
        {
            ShowHideMenu("sbShowLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        }


        private void btnTopMenuHide_Click(object sender, RoutedEventArgs e)
        {
            ShowHideMenu("sbHideTopMenu", btnTopMenuHide, btnTopMenuShow, pnlTopMenu);

        }

        private void btnTopMenuShow_Click(object sender, RoutedEventArgs e)
        {
            ShowHideMenu("sbShowTopMenu", btnTopMenuHide, btnTopMenuShow, pnlTopMenu);
        }


        private void btnRightMenuHide_Click(object sender, RoutedEventArgs e)
        {
            tbTime.Text = "00:00:03";
            _timer.Stop();
            ShowHideMenu("sbHideRightMenu", btnRightMenuHide, btnRightMenuShow, pnlRightMenu);
        }

        private void btnRightMenuShow_Click(object sender, RoutedEventArgs e)
        {
            _time = TimeSpan.FromSeconds(2);
            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(-1));
                if (tbTime.Text == "00:00:00")
                {
                    System.Environment.Exit(1);
                }
            }, Application.Current.Dispatcher);
            _timer.Start();

            ShowHideMenu("sbShowRightMenu", btnRightMenuHide, btnRightMenuShow, pnlRightMenu);
        }

        private void ShowHideMenu(string Storyboard, Button btnHide, Button btnShow, StackPanel pnl)
        {
            Storyboard sb = Resources[Storyboard] as Storyboard;
            sb.Begin(pnl);

            if (Storyboard.Contains("Show"))
            {
                btnHide.Visibility = System.Windows.Visibility.Visible;
                btnShow.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (Storyboard.Contains("Hide"))
            {
                btnHide.Visibility = System.Windows.Visibility.Hidden;
                btnShow.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void Border_LostFocus(object sender, RoutedEventArgs e)
        {
            ShowHideMenu("sbHideLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        }
    }
}
