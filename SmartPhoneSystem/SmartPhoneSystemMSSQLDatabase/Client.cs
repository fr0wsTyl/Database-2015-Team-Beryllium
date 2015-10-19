using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SmartphoneSystemMSSQLDatabase.Data;
using SmartphoneSystemMSSQLDatabase.Models;
using SmartphoneSystemMSSQLDatabase.Migrations;
namespace SmartphoneSystemMSSQLDatabase
{
    public class Client
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SmartphoneSystemContext, Configuration>());
            var db = new SmartphoneSystemContext();
            db.Smartphones.Add(new Smartphone
            {
                Name = "asdasd"
                
            });
            db.SaveChanges();
        }
    }
}
