namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVItemMovement")]
    public partial class INVItemMovement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVItemMovement()
        {
            INVItemMovementDetails = new HashSet<INVItemMovementDetail>();
        }

        [Key]
        public long MovementID { get; set; }

        public int BusinessUnitID { get; set; }

        public int? IssuedStorageLocationID { get; set; }

        public DateTime? IssuedDate { get; set; }

        public int? IssuedBy { get; set; }

        public int? ReceivedStorageLocationID { get; set; }

        public int? ReceivedBy { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public int? IssuedHrSectionID { get; set; }

        public int IssueType { get; set; }

        public int? MovementTypeID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp { get; set; }

        public bool IsCancelled { get; set; }

        public int? CancelledBy { get; set; }

        public DateTime? CancelledDate { get; set; }

        public long? JournalID { get; set; }

        public int? MovementStausID { get; set; }

        public int? PostedBy { get; set; }

        public DateTime? PostedDate { get; set; }

        public int? AddedBy { get; set; }

        public DateTime? AddedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVItemMovementDetail> INVItemMovementDetails { get; set; }
    }
}
