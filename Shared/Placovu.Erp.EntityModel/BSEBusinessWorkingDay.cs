namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEBusinessWorkingDay")]
    public partial class BSEBusinessWorkingDay
    {
        [Key]
        public int WoringDayID { get; set; }

        [StringLength(50)]
        public string DayName { get; set; }

        public bool? IsWorkingDay { get; set; }

        public bool? IsStartingDay { get; set; }

        public int? DayValue { get; set; }

        public int? BusinessUnitID { get; set; }
    }
}
