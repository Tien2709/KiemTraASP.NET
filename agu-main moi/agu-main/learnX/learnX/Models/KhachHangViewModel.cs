using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace learnX.Models
{
    public class KhachHangViewModel
    {
        public KhachHangViewModel()
        {
        }

        [DisplayName("MaKH")]
        public int MaKH { get; set; }

        [DisplayName("Họ và tên")]
        [MaxLength(30, ErrorMessage = "Họ và tên không quá 30 ký tự.")]
        public string Ten { get; set; }

        [DisplayName("Điện thoại")]
        [MaxLength(20, ErrorMessage = "Điện thoại không quá 20 ký tự.")]
        public string SDT { get; set; }
    }
}
