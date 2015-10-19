namespace SmartphoneSystemMSSQLDatabase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SmartphoneSystemMSSQLDatabase.Data;

    public sealed class Configuration : DbMigrationsConfiguration<SmartphoneSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SmartphoneSystemMSSQLDatabase.Data.SmartphoneSystemContext context)
        {
            
        }
    }
}
