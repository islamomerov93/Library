using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain
{
    public sealed class Configuration : DbMigrationsConfiguration<LibraryDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "LibraryDbContext";
        }
        protected override void Seed(LibraryDBContext context)
        {
            base.Seed(context);
        }
    }
}
