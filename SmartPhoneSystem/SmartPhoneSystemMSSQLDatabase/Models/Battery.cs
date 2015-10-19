namespace SmartphoneSystemMSSQLDatabase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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

        [Required]
        [Key]
        [ForeignKey("Smartphone")]
        public Guid SmartphoneId { get; set; }

        public virtual Smartphone Smartphone { get; set; }
    }
}
