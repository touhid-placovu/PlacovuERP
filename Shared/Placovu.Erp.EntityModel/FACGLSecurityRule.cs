namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACGLSecurityRule")]
    public partial class FACGLSecurityRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACGLSecurityRule()
        {
            FACGLSecurityRuleAndCOAs = new HashSet<FACGLSecurityRuleAndCOA>();
            FACUserAndGLSecurityRules = new HashSet<FACUserAndGLSecurityRule>();
        }

        [Key]
        public int RuleId { get; set; }

        [StringLength(150)]
        public string RuleName { get; set; }

        [StringLength(250)]
        public string RuleDescription { get; set; }

        public bool? isActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACGLSecurityRuleAndCOA> FACGLSecurityRuleAndCOAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACUserAndGLSecurityRule> FACUserAndGLSecurityRules { get; set; }
    }
}
