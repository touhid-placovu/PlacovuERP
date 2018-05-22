namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVItemMovementType")]
    public partial class INVItemMovementType
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessUnitID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MovementTypeID { get; set; }

        [StringLength(150)]
        public string MovementTypeName { get; set; }

        public int? AccountCode { get; set; }

        public bool? AccountCodeIsRequired { get; set; }

        public bool? UserCanModify { get; set; }

        public int? AddedBy { get; set; }

        public DateTime? AddedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }
    }
}
