namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRSPurchaseReturn")]
    public partial class PRSPurchaseReturn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRSPurchaseReturn()
        {
            PRSPurchaseReturnDetails = new HashSet<PRSPurchaseReturnDetail>();
        }

        [Key]
        public long PurchaseReturnID { get; set; }

        public long? PurchaseRecieptID { get; set; }

        public long? PurchaseOrderID { get; set; }

        public DateTime? PurchaseReturnDate { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? BusinessPartyID { get; set; }

        [StringLength(50)]
        public string ChallanNo { get; set; }

        public DateTime? ChallanDate { get; set; }

        [StringLength(250)]
        public string Comments { get; set; }

        public int? ReturnStatusID { get; set; }

        public bool? CMRequired { get; set; }

        public long? CreditMemoID { get; set; }

        [StringLength(20)]
        public string CMStatus { get; set; }

        public DateTime? AccountingDate { get; set; }

        public long? JournalID { get; set; }

        public virtual PRSPurchaseReturnStatu PRSPurchaseReturnStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseReturnDetail> PRSPurchaseReturnDetails { get; set; }
    }
}
