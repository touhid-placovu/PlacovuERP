namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACChartOfAccount")]
    public partial class FACChartOfAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACChartOfAccount()
        {
            BSEProjects = new HashSet<BSEProject>();
            BSEProjects1 = new HashSet<BSEProject>();
            FACAccountConfigurations = new HashSet<FACAccountConfiguration>();
            FACGLedgers = new HashSet<FACGLedger>();
            FACGLSecurityRuleAndCOAs = new HashSet<FACGLSecurityRuleAndCOA>();
            FACInitialBalances = new HashSet<FACInitialBalance>();
            FACJournalDetails = new HashSet<FACJournalDetail>();
            INVAdjustments = new HashSet<INVAdjustment>();
            INVInventoryTypes = new HashSet<INVInventoryType>();
            INVItemInfoes = new HashSet<INVItemInfo>();
            INVItemInfoes1 = new HashSet<INVItemInfo>();
            INVItemInfoes2 = new HashSet<INVItemInfo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountCode { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountName { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? ParentAccountCode { get; set; }

        public int? OppositParentAccountCode { get; set; }

        public int? AccountMasterTypeID { get; set; }

        public int AccountTypeID { get; set; }

        public int? AccountSubTypeID { get; set; }

        public int? ContraAccountOf { get; set; }

        public bool? IsGLAccount { get; set; }

        public bool? IsActive { get; set; }

        [Column(TypeName = "money")]
        public decimal? CurrentBalance { get; set; }

        public DateTime? CurrentBalanceUpdateDate { get; set; }

        public bool? IsCashAccount { get; set; }

        public bool? IsBankAccount { get; set; }

        public bool? IsInterUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSEProject> BSEProjects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSEProject> BSEProjects1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACAccountConfiguration> FACAccountConfigurations { get; set; }

        public virtual FACAccountSubType FACAccountSubType { get; set; }

        public virtual FACChartOfAccountsStat FACChartOfAccountsStat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACGLedger> FACGLedgers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACGLSecurityRuleAndCOA> FACGLSecurityRuleAndCOAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACInitialBalance> FACInitialBalances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACJournalDetail> FACJournalDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVAdjustment> INVAdjustments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVInventoryType> INVInventoryTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVItemInfo> INVItemInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVItemInfo> INVItemInfoes1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVItemInfo> INVItemInfoes2 { get; set; }
    }
}
