using System.Threading;
using System.Windows;

namespace Library
{
    public partial class App : Application
    {
        public App()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("");
        }
    }
}
