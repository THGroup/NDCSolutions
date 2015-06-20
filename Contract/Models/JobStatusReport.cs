using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contract.Models
{
    [Table("JobStatusReport", Schema = "dbo")]
    class JobStatusReport
    {
        [Key]
        public long CostCode { get; set; }
        public string Description {get;set;}
        public decimal? SubContract { get; set; }
        public decimal? PurchaseOrder { get; set; }
        public decimal? Labor { get; set; }
        public decimal? Material { get; set; }
        public decimal? Equipment { get; set; }
        public decimal? TotalBudget { get; set; }
        public decimal? OriginalAgreement { get; set; }
        public decimal? ChangeOrder { get; set; }
        public decimal? TotalCommitted { get; set; }
        public decimal? PaidToDate { get; set; }
        public decimal? RemainToPaid { get; set; }
        public decimal? EstimateToComplete { get; set; }
        public decimal? TotalProjectedFinal { get; set; }
        public decimal? ProjectedVariant { get; set; }
        public string CreatedBy { get; set; }
        public decimal CreatedOn { get; set; }
        public decimal LastRunOn { get; set; }
        public string LastRunBy { get; set; }
    }
}
