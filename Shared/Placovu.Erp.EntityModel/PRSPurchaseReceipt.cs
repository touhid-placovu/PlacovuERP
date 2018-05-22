namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRSPurchaseReceipt")]
    public partial class PRSPurchaseReceipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRSPurchaseReceipt()
        {
            PRSPurchaseReceiptDetails = new HashSet<PRSPurchaseReceiptDetail>();
        }

        [Key]
        public long PurchasereceiptID { get; set; }

        public int? SupplyerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReceiptDate { get; set; }

        public long? PurchaseOrderID { get; set; }

        public int? BusinessUnitID { get; set; }

        [StringLength(50)]
        public string ChallanNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChallanDate { get; set; }

        [StringLength(200)]
        public string Comments { get; set; }

        public int? RecieptStatusID { get; set; }

        public int? ReceiptInvStatusID { get; set; }

        public long? InvoiceID { get; set; }

        public int? ReceivedBy { get; set; }

        public long? JournalID { get; set; }

        public DateTime? AccountingDate { get; set; }

        public int? AddedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AddedDate { get; set; }

        public int? UpdatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdatedDate { get; set; }

        public int? PostedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PostedDate { get; set; }

        [StringLength(10)]
        public string ReceiptReturnStatus { get; set; }

        public virtual BSEBusinessParty BSEBusinessParty { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual PRSPurchaseOrder PRSPurchaseOrder { get; set; }

        public virtual PRSPurchaseRecieptStatu PRSPurchaseRecieptStatu { get; set; }

        public virtual PRSReceipt_Inv_Status PRSReceipt_Inv_Status { get; set; }

        public virtual SECUser SECUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseReceiptDetail> PRSPurchaseReceiptDetails { get; set; }
    }
}
