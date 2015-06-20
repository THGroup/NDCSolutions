using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contract.Models
{
    [Table("QuickBook", Schema = "dbo")]
    class QuickBook
    {
        [Key]
        public long CoseCode { get; set; }
        public decimal? AmountPaid { get; set; }
        public string ImportedBy { get; set; }
        public DateTime? ImportedOn { get; set; }
    }   
}       
