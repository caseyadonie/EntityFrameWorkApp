using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkApp
{
    internal class MyDBContext: DbContext
    {

        public MyDBContext() : base("name=sqliteConnString")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Disable pluralization
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<employeeInfoTbl> employeeInfo { get; set; }
    }
}
