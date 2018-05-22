namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SLSSOChange_line
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessUnitID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SO_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SO_Detail_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Chng_Ord_Seq { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string FieldName { get; set; }

        public int? Chng_Ord_Batch { get; set; }

        [StringLength(500)]
        public string Chng_Value { get; set; }

        public int? ChangedBy { get; set; }

        public DateTime? ChangedDate { get; set; }
    }
}
