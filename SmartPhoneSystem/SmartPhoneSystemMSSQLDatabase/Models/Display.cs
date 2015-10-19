namespace SmartphoneSystemMSSQLDatabase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Display
    {
        public Display()
        {
            this.DisplayId = Guid.NewGuid();
        }

        public Guid DisplayId { get; set; }

        [MaxLength(20)]
        public string Type { get; set; }

        public bool? MultiTouch { get; set; }

        [Key]
        [ForeignKey("Smartphone")]
        public Guid SmartphoneId { get; set; }

        public virtual Smartphone Smartphone { get; set; }
    }
}
