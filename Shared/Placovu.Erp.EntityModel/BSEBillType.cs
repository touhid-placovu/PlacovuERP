namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEBillType")]
    public partial class BSEBillType
    {
        [Key]
        public int BillTypeID { get; set; }

        [StringLength(50)]
        public string BillType { get; set; }
    }
}
