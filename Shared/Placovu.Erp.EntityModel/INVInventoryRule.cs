namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVInventoryRule")]
    public partial class INVInventoryRule
    {
        [Key]
        public int InvetoryRulesID { get; set; }

        public int BusinessUnitID { get; set; }

        public bool AllowNegativeBalance { get; set; }

        public bool CrearteRealTimeAccounting { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? DateUpdated { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TimeStamp { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }
    }
}
