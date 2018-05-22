namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSSalesOrderSpecConfig")]
    public partial class SLSSalesOrderSpecConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SLSSalesOrderSpecConfig()
        {
            SLSSalesOrderDetailSpecs = new HashSet<SLSSalesOrderDetailSpec>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecConfigID { get; set; }

        [StringLength(150)]
        public string SpecConfigName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesOrderDetailSpec> SLSSalesOrderDetailSpecs { get; set; }
    }
}
