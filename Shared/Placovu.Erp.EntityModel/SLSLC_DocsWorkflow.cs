namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SLSLC_DocsWorkflow
    {
        public long ID { get; set; }

        public long? LCID { get; set; }

        public DateTime? DocsSubmissionPartyDate { get; set; }

        [StringLength(200)]
        public string DocsSubmissionPartyNote { get; set; }

        public int? EnteredBy1 { get; set; }

        public DateTime? EnteredByDate1 { get; set; }

        public DateTime? DocsAcceptancePartyDate { get; set; }

        [StringLength(200)]
        public string DocsAcceptancePartyNote { get; set; }

        public int? EnteredBy2 { get; set; }

        public DateTime? EnteredByDate2 { get; set; }

        public DateTime? DocsSubmissionBankDate { get; set; }

        [StringLength(200)]
        public string DocsSubmissionBankNote { get; set; }

        public int? EnteredBy3 { get; set; }

        public DateTime? EnteredByDate3 { get; set; }

        public DateTime? DocsAcceptanceBankDate { get; set; }

        [StringLength(200)]
        public string DocsAcceptanceBankNote { get; set; }

        public int? EnteredBy4 { get; set; }

        public DateTime? EnteredByDate4 { get; set; }

        public virtual SLSLC SLSLC { get; set; }
    }
}
