namespace SmartphoneSystemMSSQLDatabase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Vendor
    {
        private ICollection<Smartphone> smartphones;

        public Vendor()
        {
            this.VendorId = Guid.NewGuid();
            this.smartphones = new HashSet<Smartphone>();
        }

        public Guid VendorId { get; set; }

        public string Country { get; set; }

        public DateTime FoundedOn { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        public virtual ICollection<Smartphone> Smartphones
        {
            get
            {
                return this.smartphones;
            }
            set
            {
                this.smartphones = value;
            }
        }
    }
}
