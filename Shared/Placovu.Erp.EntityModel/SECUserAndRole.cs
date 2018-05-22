namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SECUserAndRole")]
    public partial class SECUserAndRole
    {
        public long ID { get; set; }

        public int UserID { get; set; }

        public int RoleID { get; set; }

        public bool? IsActive { get; set; }

        public virtual SECRole SECRole { get; set; }

        public virtual SECUser SECUser { get; set; }
    }
}
