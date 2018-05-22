namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSSOPaymentMode")]
    public partial class SLSSOPaymentMode
    {
        [Key]
        public short SO_PayModeID { get; set; }

        [StringLength(50)]
        public string SO_PaymodeName { get; set; }

        [StringLength(200)]
        public string SO_PaymodeDescription { get; set; }

        public bool? isActive { get; set; }
    }
}
