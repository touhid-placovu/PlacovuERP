namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRSPurchaseOrder")]
    public partial class PRSPurchaseOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRSPurchaseOrder()
        {
            PRSPurchaseInvoices = new HashSet<PRSPurchaseInvoice>();
            PRSPurchaseOrderDetails = new HashSet<PRSPurchaseOrderDetail>();
            PRSPurchaseReceipts = new HashSet<PRSPurchaseReceipt>();
        }

        [Key]
        public long PurchaseOrderID { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? BusinessPartyID { get; set; }

        [StringLength(150)]
        public string ContractLCNo { get; set; }

        public DateTime? PurchaseOrderDate { get; set; }

        public int? ShipToLocationID { get; set; }

        [StringLength(150)]
        public string PartialShipment { get; set; }

        [StringLength(500)]
        public string ShippingAddress { get; set; }

        [StringLength(500)]
        public string PaymentTerms { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalOrderQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount { get; set; }

        public int? CurrencyID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ConversionRate { get; set; }

        public int? BankBranchID { get; set; }

        public int? OrderStatusID { get; set; }

        public int? POReceiptStatusID { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public int? ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public int? RejectedBy { get; set; }

        public DateTime? RejectedDate { get; set; }

        public virtual BSEBusinessParty BSEBusinessParty { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual BSECurrency BSECurrency { get; set; }

        public virtual BSELocation BSELocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseInvoice> PRSPurchaseInvoices { get; set; }

        public virtual PRSPurchaseOrderReceiptStatu PRSPurchaseOrderReceiptStatu { get; set; }

        public virtual PRSPurchaseOrderStatu PRSPurchaseOrderStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseOrderDetail> PRSPurchaseOrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseReceipt> PRSPurchaseReceipts { get; set; }
    }
}
