using System.Data.Common;
using Abp.Zero.EntityFramework;
using EWeb.Authorization.Roles;
using EWeb.Authorization.Users;
using EWeb.MultiTenancy;

namespace EWeb.EntityFramework
{
    public class EWebDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Add-Migration InitialCreate
        //TODO: Update-Database
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public EWebDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in EWebDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of EWebDbContext since ABP automatically handles it.
         */
        public EWebDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public EWebDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public EWebDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
