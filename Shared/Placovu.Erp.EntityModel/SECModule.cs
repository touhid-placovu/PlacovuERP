namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SECModule")]
    public partial class SECModule
    {
        public int ApplicationID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModuleID { get; set; }

        [StringLength(100)]
        public string ModuleName { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsParentModule { get; set; }

        public int? ParentModuleID { get; set; }

        public bool? HasChildModule { get; set; }

        public virtual SECApplication SECApplication { get; set; }
    }
}
