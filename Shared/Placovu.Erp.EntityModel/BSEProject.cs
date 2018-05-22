namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEProject")]
    public partial class BSEProject
    {
        public int BusinessunitID { get; set; }

        [Key]
        public int ProjectID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ClosedDate { get; set; }

        public int? AccountCash { get; set; }

        public int? AccountExp { get; set; }

        public bool? IsActive { get; set; }

        public long? FarmerID { get; set; }

        public int SeasonID { get; set; }

        public long? ProductionJournalID { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual FACChartOfAccount FACChartOfAccount { get; set; }

        public virtual FACChartOfAccount FACChartOfAccount1 { get; set; }
    }
}
