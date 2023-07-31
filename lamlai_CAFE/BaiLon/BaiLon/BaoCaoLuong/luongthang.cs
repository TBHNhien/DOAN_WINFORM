namespace BaiLon.BaoCaoLuong
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("luongthang")]
    public partial class luongthang
    {
        [Key]
        [StringLength(50)]
        public string MANV { get; set; }

        [Required]
        [StringLength(100)]
        public string TENNV { get; set; }

        public int SOCA { get; set; }

        public double TONGTHOIGIAN { get; set; }

        [StringLength(100)]
        public string PHAT { get; set; }

        public int TONGLUONGSO { get; set; }

        [Required]
        [StringLength(100)]
        public string TONGLUONGCHU { get; set; }
    }
}
