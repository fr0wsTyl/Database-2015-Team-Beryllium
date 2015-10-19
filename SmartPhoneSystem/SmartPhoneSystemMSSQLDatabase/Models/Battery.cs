using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneSystemMSSQLDatabase.Models
{
    public class Battery
    {
        public Battery()
        {
            this.BatteryId = Guid.NewGuid();
        }

        public Guid BatteryId { get; set; }

        public double? Capacity { get; set; }

        public double? TalkTime { get; set; }

        public bool? Removable { get; set; }

        public Guid SmartphoneId { get; set; }

        public virtual Smartphone Smartphone { get; set; }
    }
}
