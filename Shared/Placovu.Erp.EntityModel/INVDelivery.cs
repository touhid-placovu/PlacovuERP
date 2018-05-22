namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVDelivery")]
    public partial class INVDelivery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVDelivery()
        {
            INVDeliveryDetails = new HashSet<INVDeliveryDetail>();
        }

        [Key]
        public long DeliveryID { get; set; }

        public int? DeliveredBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DeleveryDate { get; set; }

        public long? SalesOrderID { get; set; }

        public int? BusinessUnitID { get; set; }

        [StringLength(50)]
        public string ChallanNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChallanDate { get; set; }

        [StringLength(200)]
        public string Comments { get; set; }

        public int? BusinessPartyID { get; set; }

        public int? ProjectID { get; set; }

        public long? SalesInvoiceID { get; set; }

        [StringLength(10)]
        public string DeliveryInvoiceStatus { get; set; }

        [StringLength(10)]
        public string DeliveryStatus { get; set; }

        [StringLength(10)]
        public string DeliveryReturnStatus { get; set; }

        public int? DeliverySource { get; set; }

        public int? AddedBy { get; set; }

        public DateTime? AddedDate { get; set; }

        public int? PostedBy { get; set; }

        public DateTime? PostedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(10)]
        public string DeliveryMode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVDeliveryDetail> INVDeliveryDetails { get; set; }
    }
}
