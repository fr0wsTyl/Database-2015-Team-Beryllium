using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneSystemMSSQLDatabase.Models
{
    public class Display
    {
        public Display()
        {
            this.DisplayId = Guid.NewGuid();
        }
        public Guid DisplayId { get; set; }

        public string Type { get; set; }

        public bool? MultiTouch { get; set; }

        public Guid SmartphoneId { get; set; }

        public virtual Smartphone Smartphone { get; set; }
    }
}
