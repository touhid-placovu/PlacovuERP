namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSSalesOrderDetail")]
    public partial class SLSSalesOrderDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SLSSalesOrderDetail()
        {
            SLSSalesOrderDetailSpecs = new HashSet<SLSSalesOrderDetailSpec>();
        }

        public int? BusinessUnitID { get; set; }

        [Key]
        public long SalesOrderDetailsID { get; set; }

        public long? SalesOrderID { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SalesOrderQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrevInvoicedQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalLCQty { get; set; }

        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineTotal { get; set; }

        public int? MeasurementUnitID { get; set; }

        [StringLength(50)]
        public string MeasurementUnitText { get; set; }

        [StringLength(500)]
        public string Specification { get; set; }

        [Column(TypeName = "money")]
        public decimal? AdvancePayment { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrevDeliveredQty { get; set; }

        [StringLength(100)]
        public string ItemDisplayName { get; set; }

        public virtual INVItemInfo INVItemInfo { get; set; }

        public virtual SLSSalesOrder SLSSalesOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesOrderDetailSpec> SLSSalesOrderDetailSpecs { get; set; }
    }
}
