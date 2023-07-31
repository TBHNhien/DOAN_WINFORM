using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaiLon.BaoCaoLuong
{
    public partial class LLuongDB : DbContext
    {
        public LLuongDB()
            : base("name=LLuongDB")
        {
        }

        public virtual DbSet<luongthang> luongthangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
