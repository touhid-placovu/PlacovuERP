namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACJournal")]
    public partial class FACJournal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACJournal()
        {
            FACJournalDetails = new HashSet<FACJournalDetail>();
        }

        [Key]
        public long JournalID { get; set; }

        [StringLength(100)]
        public string JournalCode { get; set; }

        public int? BusinessUnitID { get; set; }

        public int JournalTypeID { get; set; }

        public DateTime JournalDate { get; set; }

        [StringLength(100)]
        public string ReferenceNo { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDrAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCrAmount { get; set; }

        public bool? IsAdjustment { get; set; }

        public bool IsVerified { get; set; }

        public int? VerifiedBy { get; set; }

        public DateTime? VerifiedDate { get; set; }

        [StringLength(5)]
        public string JournalStatus { get; set; }

        [StringLength(1)]
        public string RowState { get; set; }

        [StringLength(10)]
        public string SourcesProcessID { get; set; }

        [StringLength(200)]
        public string SourcesProcessDesc { get; set; }

        public long? SourcesProcessRecordID { get; set; }

        public int? FiscaleYear { get; set; }

        public int? AccountingPeriod { get; set; }

        public int? OpeningPeriodID { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? PostedBy { get; set; }

        public DateTime? PostedDate { get; set; }

        public int? CancelledBy { get; set; }

        public DateTime? CancelledDate { get; set; }

        public int? ProjectID { get; set; }

        public short? InterUnitTranTypeID { get; set; }

        public int? InterUnitBUID { get; set; }

        public Guid? RowID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Timestamp { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit1 { get; set; }

        public virtual FACInterUnitTranType FACInterUnitTranType { get; set; }

        public virtual FACJournalType FACJournalType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACJournalDetail> FACJournalDetails { get; set; }
    }
}
