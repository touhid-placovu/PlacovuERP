namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEBusinessUnit")]
    public partial class BSEBusinessUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BSEBusinessUnit()
        {
            BSEDepartments = new HashSet<BSEDepartment>();
            BSELocations = new HashSet<BSELocation>();
            BSEProjects = new HashSet<BSEProject>();
            BSEReportParams = new HashSet<BSEReportParam>();
            FACAccountingPeriods = new HashSet<FACAccountingPeriod>();
            FACBillings = new HashSet<FACBilling>();
            FACCreditMemoes = new HashSet<FACCreditMemo>();
            FACDebitMemoes = new HashSet<FACDebitMemo>();
            FACFiscalYears = new HashSet<FACFiscalYear>();
            FACJournals = new HashSet<FACJournal>();
            FACJournals1 = new HashSet<FACJournal>();
            FACPayments = new HashSet<FACPayment>();
            FACPrepayments = new HashSet<FACPrepayment>();
            FACPrepaymentInvoices = new HashSet<FACPrepaymentInvoice>();
            INVAdjustments = new HashSet<INVAdjustment>();
            INVDeliveryDetails = new HashSet<INVDeliveryDetail>();
            INVInventoryRules = new HashSet<INVInventoryRule>();
            INVItemGroups = new HashSet<INVItemGroup>();
            INVItemInfoes = new HashSet<INVItemInfo>();
            INVItemInitialBalances = new HashSet<INVItemInitialBalance>();
            INVItemMovements = new HashSet<INVItemMovement>();
            INVItemMovementTypes = new HashSet<INVItemMovementType>();
            INVPutaways = new HashSet<INVPutaway>();
            INVStorageLocations = new HashSet<INVStorageLocation>();
            INVUserAndIssuers = new HashSet<INVUserAndIssuer>();
            PRSPurchaseInvoices = new HashSet<PRSPurchaseInvoice>();
            PRSPurchaseOrders = new HashSet<PRSPurchaseOrder>();
            PRSPurchasePayments = new HashSet<PRSPurchasePayment>();
            PRSPurchaseReceipts = new HashSet<PRSPurchaseReceipt>();
            PRSPurchaseRequisitions = new HashSet<PRSPurchaseRequisition>();
            PRSUserAndReceivers = new HashSet<PRSUserAndReceiver>();
            SECUserAndBusinessUnits = new HashSet<SECUserAndBusinessUnit>();
            SLSAdditionalExpConfigs = new HashSet<SLSAdditionalExpConfig>();
            SLSMfgInstructions = new HashSet<SLSMfgInstruction>();
            SLSSalesInvoices = new HashSet<SLSSalesInvoice>();
            SLSSalesOrders = new HashSet<SLSSalesOrder>();
            SLSSalesPayments = new HashSet<SLSSalesPayment>();
        }

        [Key]
        public int BusinessUnitID { get; set; }

        [StringLength(10)]
        public string BusinessUnitCode { get; set; }

        [StringLength(50)]
        public string BusinessUnitName { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? CompanyID { get; set; }

        public int? WeekStartingDay { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        public int? DecimalRounding { get; set; }

        [StringLength(5)]
        public string CostCalMethod { get; set; }

        [StringLength(250)]
        public string FactoryAddress { get; set; }

        public virtual BSECompany BSECompany { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSEDepartment> BSEDepartments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSELocation> BSELocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSEProject> BSEProjects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSEReportParam> BSEReportParams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACAccountingPeriod> FACAccountingPeriods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACBilling> FACBillings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACCreditMemo> FACCreditMemoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACDebitMemo> FACDebitMemoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACFiscalYear> FACFiscalYears { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACJournal> FACJournals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACJournal> FACJournals1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPayment> FACPayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPrepayment> FACPrepayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPrepaymentInvoice> FACPrepaymentInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVAdjustment> INVAdjustments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVDeliveryDetail> INVDeliveryDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVInventoryRule> INVInventoryRules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVItemGroup> INVItemGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVItemInfo> INVItemInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVItemInitialBalance> INVItemInitialBalances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVItemMovement> INVItemMovements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVItemMovementType> INVItemMovementTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVPutaway> INVPutaways { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVStorageLocation> INVStorageLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVUserAndIssuer> INVUserAndIssuers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseInvoice> PRSPurchaseInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseOrder> PRSPurchaseOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchasePayment> PRSPurchasePayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseReceipt> PRSPurchaseReceipts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseRequisition> PRSPurchaseRequisitions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSUserAndReceiver> PRSUserAndReceivers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECUserAndBusinessUnit> SECUserAndBusinessUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSAdditionalExpConfig> SLSAdditionalExpConfigs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSMfgInstruction> SLSMfgInstructions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesInvoice> SLSSalesInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesOrder> SLSSalesOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesPayment> SLSSalesPayments { get; set; }
    }
}
