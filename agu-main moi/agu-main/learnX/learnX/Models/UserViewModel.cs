using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace learnX.Models
{
    public class UserViewModel
    {
        public UserViewModel()
        {
        }

        [DisplayName("ID")]
        public int uID { get; set; }

        [DisplayName("Họ và tên")]
        [MaxLength(125, ErrorMessage = "Họ và tên không quá 125 ký tự.")]
        public string uFullName { get; set; }

        [DisplayName("Giới tính")]
        public bool uSex { get; set; }

        [DisplayName("Thông tin tài khoản")]
        [MaxLength(1000, ErrorMessage = "Thông tin tài khoản không quá 1000 ký tự.")]
        public string uInformation { get; set; }

        [DisplayName("Điện thoại")]
        [MaxLength(32, ErrorMessage = "Điện thoại không quá 32 ký tự.")]
        public string uMobile { get; set; }

        [DisplayName("Email")]
        [MaxLength(125, ErrorMessage = "Email không quá 125 ký tự.")]
        public string uEmail { get; set; }

        public DateTime CreatedDate { get; set; }

        [DisplayName("Trạng thái")]
        public bool isActived { get; set; }
    }
}
