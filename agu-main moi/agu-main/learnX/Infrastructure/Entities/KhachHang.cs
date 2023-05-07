using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public int MaKH { get; set; }
        public string Ten { get; set; }
        public string SDT{ get; set; }
        
    }
}
