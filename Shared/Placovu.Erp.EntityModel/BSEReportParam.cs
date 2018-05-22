namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BSEReportParam
    {
        public int ID { get; set; }

        public int? BusinessUnitID { get; set; }

        [StringLength(500)]
        public string FooterLine1 { get; set; }

        [StringLength(500)]
        public string FooterLine2 { get; set; }

        [StringLength(500)]
        public string FooterLine3 { get; set; }

        [StringLength(500)]
        public string FooterLine4 { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }
    }
}
