namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSSalesReturn")]
    public partial class SLSSalesReturn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SLSSalesReturn()
        {
            SLSSalesReturnDetails = new HashSet<SLSSalesReturnDetail>();
        }

        [Key]
        public long SalesReturnID { get; set; }

        public long? ItemDeliveryID { get; set; }

        public long? SalesOrderID { get; set; }

        public DateTime? SalesReturnDate { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? BusinessPartyID { get; set; }

        [StringLength(50)]
        public string ChallanNo { get; set; }

        public DateTime? ChallanDate { get; set; }

        [StringLength(250)]
        public string Comments { get; set; }

        [StringLength(50)]
        public string ReturnStatus { get; set; }

        public DateTime? AccountingDate { get; set; }

        public long? JournalID { get; set; }

        public bool? CMRequired { get; set; }

        public long? CreditMemoID { get; set; }

        [StringLength(20)]
        public string CMStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesReturnDetail> SLSSalesReturnDetails { get; set; }
    }
}
