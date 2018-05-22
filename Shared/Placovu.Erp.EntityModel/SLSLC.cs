namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSLC")]
    public partial class SLSLC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SLSLC()
        {
            SLSLC_Details = new HashSet<SLSLC_Details>();
            SLSLC_DocsWorkflow = new HashSet<SLSLC_DocsWorkflow>();
            SLSSalesInvoices = new HashSet<SLSSalesInvoice>();
        }

        [Key]
        public long LCID { get; set; }

        [StringLength(100)]
        public string LCNumber { get; set; }

        public DateTime? LCDate { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? BusinessPartyID { get; set; }

        [StringLength(200)]
        public string LCNotes { get; set; }

        [StringLength(10)]
        public string LCMapStatus { get; set; }

        public int? LCTypeID { get; set; }

        [Column(TypeName = "money")]
        public decimal? LCAmount { get; set; }

        public int? CurrencyID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LCExpiryDate { get; set; }

        public int? LCExpiryCountryID { get; set; }

        [StringLength(100)]
        public string FileNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LCShipByDate { get; set; }

        public int? DaysOfSight { get; set; }

        public int? DocSubmissionDays { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? InterestRate { get; set; }

        public bool? PartialShipmentAllow { get; set; }

        public bool? TranshipmentAllow { get; set; }

        public int? BankID { get; set; }

        public int? BranchID { get; set; }

        public int? BusinessPartyBankID { get; set; }

        [StringLength(100)]
        public string ExportLCNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExportLCDate { get; set; }

        [StringLength(500)]
        public string ExportLCNotes { get; set; }

        public int? LCInvoiceStatusID { get; set; }

        public int? LCDocsStatusID { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? PostedBy { get; set; }

        public DateTime? PostedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSLC_Details> SLSLC_Details { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSLC_DocsWorkflow> SLSLC_DocsWorkflow { get; set; }

        public virtual SLSLCDocsStatu SLSLCDocsStatu { get; set; }

        public virtual SLSLCInvoiceStatu SLSLCInvoiceStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesInvoice> SLSSalesInvoices { get; set; }
    }
}
