namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SECApplication")]
    public partial class SECApplication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SECApplication()
        {
            SECModules = new HashSet<SECModule>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApplicationID { get; set; }

        [StringLength(50)]
        public string ApplicationName { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(50)]
        public string TileCssClass { get; set; }

        [StringLength(250)]
        public string IconImageUrl { get; set; }

        public bool? IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECModule> SECModules { get; set; }
    }
}
