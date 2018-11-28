namespace HW8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bid
    {
        public int BidID { get; set; }

        public int? Item { get; set; }

        public int? Bider { get; set; }

        [Column(TypeName = "date")]
        public DateTime TimeStamps { get; set; }

        [Required]
        [StringLength(255)]
        public string Prices { get; set; }

        public virtual Buyer Buyer { get; set; }

        public virtual Item Item1 { get; set; }
    }
}
