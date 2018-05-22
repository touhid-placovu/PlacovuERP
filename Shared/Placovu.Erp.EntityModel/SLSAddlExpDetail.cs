namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSAddlExpDetail")]
    public partial class SLSAddlExpDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SalesInvoiceID { get; set; }

        [Required]
        [StringLength(250)]
        public string BillLadingNo { get; set; }

        public DateTime BillLadingDate { get; set; }

        [Required]
        [StringLength(250)]
        public string Vassel { get; set; }

        public DateTime? DateNegotiation { get; set; }

        public DateTime? DateRealization { get; set; }

        [StringLength(150)]
        public string BankReference { get; set; }

        [StringLength(50)]
        public string Subsidy { get; set; }

        [StringLength(250)]
        public string Remarks { get; set; }

        public virtual SLSSalesInvoice SLSSalesInvoice { get; set; }
    }
}
