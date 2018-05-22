namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACPaymentDetail")]
    public partial class FACPaymentDetail
    {
        [Key]
        public int PaymentDetailsID { get; set; }

        public int? PaymentID { get; set; }

        public int? BillID { get; set; }

        [Column(TypeName = "money")]
        public decimal? BillPaymentAmount { get; set; }

        public int? BusinessPartyID { get; set; }

        public virtual BSEBusinessParty BSEBusinessParty { get; set; }

        public virtual FACBilling FACBilling { get; set; }

        public virtual FACPayment FACPayment { get; set; }
    }
}
