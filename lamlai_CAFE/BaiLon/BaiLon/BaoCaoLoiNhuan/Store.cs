namespace BaiLon.BaoCaoLoiNhuan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Material { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime DateIn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Dateexpired { get; set; }

        public double priceIn { get; set; }

        public int amount { get; set; }

        [StringLength(100)]
        public string category { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }
    }
}
