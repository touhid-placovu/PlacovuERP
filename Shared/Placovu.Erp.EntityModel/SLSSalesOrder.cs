namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSSalesOrder")]
    public partial class SLSSalesOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SLSSalesOrder()
        {
            SLSMfgInstructions = new HashSet<SLSMfgInstruction>();
            SLSSalesInvoices = new HashSet<SLSSalesInvoice>();
            SLSSalesOrderDetails = new HashSet<SLSSalesOrderDetail>();
        }

        [Key]
        public long SalesOrderID { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? BusinessPartyID { get; set; }

        [StringLength(150)]
        public string ContractLCNo { get; set; }

        public DateTime? SalesOrderDate { get; set; }

        public DateTime? MaxShipmentDate { get; set; }

        [StringLength(150)]
        public string PortofDestination { get; set; }

        [StringLength(150)]
        public string PartialShipment { get; set; }

        [StringLength(500)]
        public string ShippingMarks { get; set; }

        [StringLength(500)]
        public string PaymentTerms { get; set; }

        public short? SOPaymentMode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalOrderQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount { get; set; }

        public int? CurrencyID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ConversionRate { get; set; }

        public int? BankBranchID { get; set; }

        public int? OrderStatusID { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public long? MIID { get; set; }

        [Column(TypeName = "money")]
        public decimal? AdvancePayment { get; set; }

        public int? SODeliveryStatusID { get; set; }

        public int? ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public int? RejectedBy { get; set; }

        public DateTime? RejectedDate { get; set; }

        public int? AddedBy { get; set; }

        public DateTime? DateAdded { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? DateUpdated { get; set; }

        [StringLength(100)]
        public string DocumentNumber { get; set; }

        public long? ChangeOrder { get; set; }

        public virtual BSEBusinessParty BSEBusinessParty { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual BSECurrency BSECurrency { get; set; }

        public virtual SLSDeliveryStatu SLSDeliveryStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSMfgInstruction> SLSMfgInstructions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesInvoice> SLSSalesInvoices { get; set; }

        public virtual SLSSalesOrderStatu SLSSalesOrderStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesOrderDetail> SLSSalesOrderDetails { get; set; }
    }
}
