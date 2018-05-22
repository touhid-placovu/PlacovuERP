namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEBusinessPartyBankInfo")]
    public partial class BSEBusinessPartyBankInfo
    {
        [Key]
        public int BusinessPartyBankInfoID { get; set; }

        public int? BusinessPartyID { get; set; }

        [StringLength(100)]
        public string BankName { get; set; }

        [StringLength(100)]
        public string BranchName { get; set; }

        [StringLength(50)]
        public string BranchCode { get; set; }

        [StringLength(50)]
        public string AccountNumber { get; set; }

        [StringLength(50)]
        public string SWIFTCode { get; set; }

        [StringLength(50)]
        public string ABANumber { get; set; }

        [StringLength(250)]
        public string AddressLine1 { get; set; }

        [StringLength(250)]
        public string AddressLine2 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [StringLength(50)]
        public string ZipCode { get; set; }

        public int? CountryID { get; set; }

        [StringLength(250)]
        public string Contact1 { get; set; }

        [StringLength(250)]
        public string Contact2 { get; set; }

        [StringLength(250)]
        public string Contact3 { get; set; }

        public virtual BSEBusinessParty BSEBusinessParty { get; set; }

        public virtual BSECountry BSECountry { get; set; }
    }
}
