namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVUserAndIssuerDetail")]
    public partial class INVUserAndIssuerDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IssuerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemTypeID { get; set; }

        public bool? IsActive { get; set; }

        public virtual INVItemType INVItemType { get; set; }

        public virtual INVUserAndIssuer INVUserAndIssuer { get; set; }
    }
}
