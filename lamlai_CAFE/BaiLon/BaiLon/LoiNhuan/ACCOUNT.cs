namespace BaiLon.LoiNhuan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACCOUNT()
        {
            BILLINFOes = new HashSet<BILLINFO>();
            salaries = new HashSet<salary>();
            Stores = new HashSet<Store>();
        }

        [Key]
        [StringLength(100)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string DISPLAYNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string PASSWORDACCOUNT { get; set; }

        public int TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILLINFO> BILLINFOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<salary> salaries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store> Stores { get; set; }
    }
}
