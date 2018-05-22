namespace Placovu.Erp.Core.EntityModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ApplicationSetting")]
    public partial class ApplicationSetting
    {
        [Key]
        [StringLength(50)]
        public string ApplicationId { get; set; }

        [Required]
        [StringLength(50)]
        public string HostAddress { get; set; }

        [StringLength(128)]
        public string DefaultUtcTimeZone { get; set; }

        [StringLength(10)]
        public string DefaultUtcTimeZoneOffset { get; set; }

        public bool? IsMobileDevice { get; set; }
    }
}
