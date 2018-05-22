namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSMfgInstruction")]
    public partial class SLSMfgInstruction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SLSMfgInstruction()
        {
            SLSMfgInstructionDetails = new HashSet<SLSMfgInstructionDetail>();
        }

        [Key]
        public long MIID { get; set; }

        public DateTime? MIDate { get; set; }

        public long? SalesOrderID { get; set; }

        [StringLength(500)]
        public string SpecialInstruction { get; set; }

        [StringLength(200)]
        public string Survey { get; set; }

        [StringLength(50)]
        public string NatureOfWinding { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaxOilContent { get; set; }

        [StringLength(50)]
        public string SpoolSize { get; set; }

        [StringLength(50)]
        public string TPI_TPM { get; set; }

        [StringLength(50)]
        public string MoistureRegain { get; set; }

        [StringLength(50)]
        public string BreakingStrength { get; set; }

        [StringLength(50)]
        public string QualityRatio { get; set; }

        [StringLength(50)]
        public string CoV { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? BusinessPartyID { get; set; }

        [StringLength(150)]
        public string ContractLCNo { get; set; }

        public DateTime? MaxShipmentDate { get; set; }

        [StringLength(150)]
        public string PortofDestination { get; set; }

        [StringLength(500)]
        public string ShippingMarks { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public int? ProductionStatusID { get; set; }

        [StringLength(100)]
        public string DocumentNumber { get; set; }

        public int? MIStatus { get; set; }

        public int? ApprovedBy { get; set; }

        public DateTime? ApproveDate { get; set; }

        public int? RejectedBy { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual SLSMfgInstructionStatu SLSMfgInstructionStatu { get; set; }

        public virtual SLSSalesOrder SLSSalesOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSMfgInstructionDetail> SLSMfgInstructionDetails { get; set; }
    }
}
