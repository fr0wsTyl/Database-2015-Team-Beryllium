namespace SmartphoneSystemMSSQLDatabase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Smartphone
    {
        public Smartphone()
        {
            this.SmartphoneId = Guid.NewGuid();
        }

        public Guid SmartphoneId { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        public Guid? VendorId { get; set; }

        public virtual Vendor Vendor { get; set; }

        public virtual Display Display { get; set; }
    }
}
