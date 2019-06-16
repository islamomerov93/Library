using Library.DataAccess.EF_CodeFirst;
using Library.Domain;
using Library.Domain.Abstractions;
using Library.Domain.Entities;
using Library.Helper;
using Ninject;
using Ninject.Modules;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace Library
{
    public partial class App : Application
    {
        public App()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            UnitOfWork = new UnitOfWork();
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            using (LibraryDBContext db = new LibraryDBContext())
            {
                if (db.Users.AsQueryable().FirstOrDefault(x => x.Username == "Islam") == null)
                {
                    db.Users.Add(new User("Islam", De_En_Crypter.Encrypt("123", "Encrypt"), true));
                    db.SaveChanges();
                }
            }
        }
        public static User CurrentUser { get; set; }
        public static IUnitOfWork UnitOfWork { get; set; }
    }
    public class Inject : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
