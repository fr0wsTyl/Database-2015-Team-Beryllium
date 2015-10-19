using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneSystemMSSQLDatabase.Models
{
    public class Display
    {
        public int DisplayId { get; set; }

        public string Type { get; set; }

        public bool? MultiTouch { get; set; }

        public int SmartphoneId { get; set; }

        public virtual Smartphone Smartphone { get; set; }
    }
}
