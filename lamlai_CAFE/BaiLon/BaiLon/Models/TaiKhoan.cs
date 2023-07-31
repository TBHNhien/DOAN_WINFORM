namespace BaiLon.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(10)]
        public string MaTaiKhoan { get; set; }

        [StringLength(10)]
        public string Ten { get; set; }

        [StringLength(10)]
        public string MatKhau { get; set; }

        public int? MaChucVu { get; set; }

        public virtual ChucVu ChucVu { get; set; }
    }
}
