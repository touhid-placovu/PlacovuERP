namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSSalesOrderDetailSpec")]
    public partial class SLSSalesOrderDetailSpec
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SalesOrderDetailsID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecConfigID { get; set; }

        [StringLength(250)]
        public string SpecConfigValue { get; set; }

        public long? SalesOrderID { get; set; }

        public virtual SLSSalesOrderDetail SLSSalesOrderDetail { get; set; }

        public virtual SLSSalesOrderSpecConfig SLSSalesOrderSpecConfig { get; set; }
    }
}
