namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SECUserAndBusinessUnit")]
    public partial class SECUserAndBusinessUnit
    {
        public long ID { get; set; }

        public int? UserID { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? OperatingUnitID { get; set; }

        public bool? IsActive { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual SECUser SECUser { get; set; }
    }
}
