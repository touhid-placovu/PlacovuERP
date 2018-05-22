namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSAdditionalExpConfig")]
    public partial class SLSAdditionalExpConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdditionalExpConfigID { get; set; }

        [StringLength(250)]
        public string AdditionalExpConfigName { get; set; }

        public int? ItemID { get; set; }

        public bool? IsActive { get; set; }

        public int? BusinessUnitID { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual INVItemInfo INVItemInfo { get; set; }
    }
}
