using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SmartphoneSystemMSSQLDatabase.Models;

namespace SmartphoneSystemMSSQLDatabase.Data
{
    public class SmartphoneSystemContext : DbContext
    {
        public SmartphoneSystemContext()
            : base("SmartphoneSystem")
        {

        }

        public IDbSet<Smartphone> Smartphones { get; set; }

        public IDbSet<Vendor> Vendors { get; set; }

        public IDbSet<Display> Displays { get; set; }

        public IDbSet<Battery> Batteries { get; set; }
    }
}
