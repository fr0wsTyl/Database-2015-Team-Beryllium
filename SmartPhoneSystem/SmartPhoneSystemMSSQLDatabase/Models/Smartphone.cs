﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneSystemMSSQLDatabase.Models
{
    public class Smartphone
    {
        public Smartphone()
        {
            this.SmartphoneId = Guid.NewGuid();
        }
        public Guid SmartphoneId { get; set; }

        public string Name { get; set; }

        //public double? Cpu { get; set; }

        //public double? Camera { get; set; }

        public Guid? VendorId { get; set; }

        public virtual Vendor vendor { get; set; }

        //public int? DisplayId { get; set; }

        //public virtual Display Display { get; set; }

        //public int? BatteryId { get; set; }

        //public virtual Battery Battery { get; set; }
    }
}
