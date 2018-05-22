namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSCashSalesConfiguration")]
    public partial class SLSCashSalesConfiguration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConfigurationID { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? DefaultCustomerID { get; set; }

        public int? GLCashAccountCode { get; set; }

        public int? VATPayableAccountCode { get; set; }

        public int? GDiscountAccountCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? DefaultVatPercent { get; set; }
    }
}
