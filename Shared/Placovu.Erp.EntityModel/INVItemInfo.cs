namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVItemInfo")]
    public partial class INVItemInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVItemInfo()
        {
            FACBillingDetails = new HashSet<FACBillingDetail>();
            INVDeliveryDetails = new HashSet<INVDeliveryDetail>();
            INVPrimaryItemBalances = new HashSet<INVPrimaryItemBalance>();
            INVPutawayDetails = new HashSet<INVPutawayDetail>();
            PRSPurchaseOrderDetails = new HashSet<PRSPurchaseOrderDetail>();
            PRSPurchaseReceiptDetails = new HashSet<PRSPurchaseReceiptDetail>();
            PRSPurchaseRequisitionDetails = new HashSet<PRSPurchaseRequisitionDetail>();
            PRSPurchaseReturnDetails = new HashSet<PRSPurchaseReturnDetail>();
            SLSAdditionalExpConfigs = new HashSet<SLSAdditionalExpConfig>();
            SLSMfgInstructionDetails = new HashSet<SLSMfgInstructionDetail>();
            SLSSalesOrderDetails = new HashSet<SLSSalesOrderDetail>();
        }

        [Key]
        public int ItemID { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? ParentItemID { get; set; }

        public int? ItemGroupID { get; set; }

        public int? ItemTypeID { get; set; }

        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }

        [StringLength(200)]
        public string ItemDescription { get; set; }

        [StringLength(200)]
        public string PurchaseDescription { get; set; }

        [StringLength(200)]
        public string SalesDescription { get; set; }

        public int? MeasurementUnitID { get; set; }

        [Column(TypeName = "money")]
        public decimal? CostPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinimumSellingPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaximumSellingPrice { get; set; }

        public int? VATPlanID { get; set; }

        public int? DiscountPlanID { get; set; }

        public int? ReorderLevel { get; set; }

        public int? PreferredSupplierID { get; set; }

        public int? PurchaseLeadTime { get; set; }

        public int? SalesLeadTime { get; set; }

        public bool? IsActive { get; set; }

        public int? COGSAccountCode { get; set; }

        public int? IncomeAccCode { get; set; }

        public int? AssetAccCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Balance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QtyPerPack { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual BSEMeasurementUnit BSEMeasurementUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACBillingDetail> FACBillingDetails { get; set; }

        public virtual FACChartOfAccount FACChartOfAccount { get; set; }

        public virtual FACChartOfAccount FACChartOfAccount1 { get; set; }

        public virtual FACChartOfAccount FACChartOfAccount2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVDeliveryDetail> INVDeliveryDetails { get; set; }

        public virtual INVItemGroup INVItemGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVPrimaryItemBalance> INVPrimaryItemBalances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVPutawayDetail> INVPutawayDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseOrderDetail> PRSPurchaseOrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseReceiptDetail> PRSPurchaseReceiptDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseRequisitionDetail> PRSPurchaseRequisitionDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseReturnDetail> PRSPurchaseReturnDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSAdditionalExpConfig> SLSAdditionalExpConfigs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSMfgInstructionDetail> SLSMfgInstructionDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesOrderDetail> SLSSalesOrderDetails { get; set; }
    }
}
