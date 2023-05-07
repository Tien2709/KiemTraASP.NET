using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities
{
    [Table("wsUser")]
    public class User
    {
        [Key]
        public int uID { get; set; }
        public string uFullName { get; set; }
        public bool uSex { get; set; }
        public string uInformation { get; set; }
        public string uMobile { get; set; }
        public string uEmail { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool isActived { get; set; }
    }
}
