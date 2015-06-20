using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contract.Models
{
    [Table("UserInfo", Schema = "dbo")]
    class UserInfo
    {
        [Key]
        public Guid UserId { get; set; }
        public string EmailAddress { get; set; }
        public string HashedPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsAdmin { get; set; }
        public string PwdResetToken { get; set; }
        public string PwdResetOn { get; set; }
    }
}
