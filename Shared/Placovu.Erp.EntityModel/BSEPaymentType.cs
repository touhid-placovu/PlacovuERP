namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEPaymentType")]
    public partial class BSEPaymentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BSEPaymentType()
        {
            PRSPurchasePayments = new HashSet<PRSPurchasePayment>();
            SLSSalesPayments = new HashSet<SLSSalesPayment>();
        }

        [Key]
        public int PaymentTypeID { get; set; }

        [StringLength(50)]
        public string PaymentTypeName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchasePayment> PRSPurchasePayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesPayment> SLSSalesPayments { get; set; }
    }
}
