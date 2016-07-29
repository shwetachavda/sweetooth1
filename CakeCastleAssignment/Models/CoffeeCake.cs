namespace CakeCastleAssignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CoffeeCake
    {
        [Key]
        public int CakeID { get; set; }

        [Required]
        [StringLength(50)]
        public string CakeName { get; set; }

        [Required]
        [StringLength(150)]
        public string CakesDesc { get; set; }

        public decimal Rate { get; set; }
    }
}
