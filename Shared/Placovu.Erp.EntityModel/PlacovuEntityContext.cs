namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PlacovuEntityContext : DbContext
    {
        public PlacovuEntityContext()
            : base("name=PacovuEntityContext")
        {
        }

        public virtual DbSet<BSEAutoNumberSetup> BSEAutoNumberSetups { get; set; }
        public virtual DbSet<BSEBankAccount> BSEBankAccounts { get; set; }
        public virtual DbSet<BSEBankInfo> BSEBankInfoes { get; set; }
        public virtual DbSet<BSEBillType> BSEBillTypes { get; set; }
        public virtual DbSet<BSEBranchInfo> BSEBranchInfoes { get; set; }
        public virtual DbSet<BSEBusinessParty> BSEBusinessParties { get; set; }
        public virtual DbSet<BSEBusinessPartyBankInfo> BSEBusinessPartyBankInfoes { get; set; }
        public virtual DbSet<BSEBusinessUnit> BSEBusinessUnits { get; set; }
        public virtual DbSet<BSEBusinessWorkingDay> BSEBusinessWorkingDays { get; set; }
        public virtual DbSet<BSECompany> BSECompanies { get; set; }
        public virtual DbSet<BSECountry> BSECountries { get; set; }
        public virtual DbSet<BSECurrency> BSECurrencies { get; set; }
        public virtual DbSet<BSECustomer> BSECustomers { get; set; }
        public virtual DbSet<BSEDepartment> BSEDepartments { get; set; }
        public virtual DbSet<BSEDistrictName> BSEDistrictNames { get; set; }
        public virtual DbSet<BSELocation> BSELocations { get; set; }
        public virtual DbSet<BSEMeasurementUnit> BSEMeasurementUnits { get; set; }
        public virtual DbSet<BSEOperatingUnit> BSEOperatingUnits { get; set; }
        public virtual DbSet<BSEPaymentMode> BSEPaymentModes { get; set; }
        public virtual DbSet<BSEPaymentStatu> BSEPaymentStatus { get; set; }
        public virtual DbSet<BSEPaymentTerm> BSEPaymentTerms { get; set; }
        public virtual DbSet<BSEPaymentType> BSEPaymentTypes { get; set; }
        public virtual DbSet<BSEProject> BSEProjects { get; set; }
        public virtual DbSet<BSEReportParam> BSEReportParams { get; set; }
        public virtual DbSet<BSESupplier> BSESuppliers { get; set; }
        public virtual DbSet<FACAccountConfiguration> FACAccountConfigurations { get; set; }
        public virtual DbSet<FACAccountingPeriod> FACAccountingPeriods { get; set; }
        public virtual DbSet<FACAccountingPeriodTest> FACAccountingPeriodTests { get; set; }
        public virtual DbSet<FACAccountingReportType> FACAccountingReportTypes { get; set; }
        public virtual DbSet<FACAccountMasterType> FACAccountMasterTypes { get; set; }
        public virtual DbSet<FACAccountSubType> FACAccountSubTypes { get; set; }
        public virtual DbSet<FACAccountType> FACAccountTypes { get; set; }
        public virtual DbSet<FACApplyPrepayment> FACApplyPrepayments { get; set; }
        public virtual DbSet<FACBilling> FACBillings { get; set; }
        public virtual DbSet<FACBillingDetail> FACBillingDetails { get; set; }
        public virtual DbSet<FACChartOfAccount> FACChartOfAccounts { get; set; }
        public virtual DbSet<FACChartOfAccountsStat> FACChartOfAccountsStats { get; set; }
        public virtual DbSet<FACCreditMemo> FACCreditMemoes { get; set; }
        public virtual DbSet<FACCreditMemoStatu> FACCreditMemoStatus { get; set; }
        public virtual DbSet<FACDebitMemo> FACDebitMemoes { get; set; }
        public virtual DbSet<FACDebitMemoStatu> FACDebitMemoStatus { get; set; }
        public virtual DbSet<FACFinSecurityRule> FACFinSecurityRules { get; set; }
        public virtual DbSet<FACFiscalYear> FACFiscalYears { get; set; }
        public virtual DbSet<FACFiscalYearTest> FACFiscalYearTests { get; set; }
        public virtual DbSet<FACGLedger> FACGLedgers { get; set; }
        public virtual DbSet<FACGLSecurityRule> FACGLSecurityRules { get; set; }
        public virtual DbSet<FACGLSecurityRuleAndCOA> FACGLSecurityRuleAndCOAs { get; set; }
        public virtual DbSet<FACInitialBalance> FACInitialBalances { get; set; }
        public virtual DbSet<FACInterUnitTranType> FACInterUnitTranTypes { get; set; }
        public virtual DbSet<FACJournal> FACJournals { get; set; }
        public virtual DbSet<FACJournalDetail> FACJournalDetails { get; set; }
        public virtual DbSet<FACJournalType> FACJournalTypes { get; set; }
        public virtual DbSet<FACPayment> FACPayments { get; set; }
        public virtual DbSet<FACPaymentDetail> FACPaymentDetails { get; set; }
        public virtual DbSet<FACPrepayment> FACPrepayments { get; set; }
        public virtual DbSet<FACPrepaymentInvoice> FACPrepaymentInvoices { get; set; }
        public virtual DbSet<FACPrepaymentInvoiceStatu> FACPrepaymentInvoiceStatus { get; set; }
        public virtual DbSet<FACSourceProcess> FACSourceProcesses { get; set; }
        public virtual DbSet<FACTemporaryFund> FACTemporaryFunds { get; set; }
        public virtual DbSet<FACUserAndGLSecurityRule> FACUserAndGLSecurityRules { get; set; }
        public virtual DbSet<INVAdjustment> INVAdjustments { get; set; }
        public virtual DbSet<INVDelivery> INVDeliveries { get; set; }
        public virtual DbSet<INVDeliveryDetail> INVDeliveryDetails { get; set; }
        public virtual DbSet<INVDeliveryLCDetail> INVDeliveryLCDetails { get; set; }
        public virtual DbSet<INVInventoryRule> INVInventoryRules { get; set; }
        public virtual DbSet<INVInventoryType> INVInventoryTypes { get; set; }
        public virtual DbSet<INVItemBalance> INVItemBalances { get; set; }
        public virtual DbSet<INVItemGroup> INVItemGroups { get; set; }
        public virtual DbSet<INVItemInfo> INVItemInfoes { get; set; }
        public virtual DbSet<INVItemInitialBalance> INVItemInitialBalances { get; set; }
        public virtual DbSet<INVItemMovement> INVItemMovements { get; set; }
        public virtual DbSet<INVItemMovementDetail> INVItemMovementDetails { get; set; }
        public virtual DbSet<INVItemMovementType> INVItemMovementTypes { get; set; }
        public virtual DbSet<INVItemPriceHistory> INVItemPriceHistories { get; set; }
        public virtual DbSet<INVItemType> INVItemTypes { get; set; }
        public virtual DbSet<INVPrimaryItemBalance> INVPrimaryItemBalances { get; set; }
        public virtual DbSet<INVPutaway> INVPutaways { get; set; }
        public virtual DbSet<INVPutawayDetail> INVPutawayDetails { get; set; }
        public virtual DbSet<INVSOLCDOItemDetailMap> INVSOLCDOItemDetailMaps { get; set; }
        public virtual DbSet<INVStorageLocation> INVStorageLocations { get; set; }
        public virtual DbSet<INVUserAndIssuer> INVUserAndIssuers { get; set; }
        public virtual DbSet<INVUserAndIssuerDetail> INVUserAndIssuerDetails { get; set; }
        public virtual DbSet<PRSPurchaseHistory> PRSPurchaseHistories { get; set; }
        public virtual DbSet<PRSPurchaseInvoice> PRSPurchaseInvoices { get; set; }
        public virtual DbSet<PRSPurchaseInvoiceDetail> PRSPurchaseInvoiceDetails { get; set; }
        public virtual DbSet<PRSPurchaseInvoiceType> PRSPurchaseInvoiceTypes { get; set; }
        public virtual DbSet<PRSPurchaseOrder> PRSPurchaseOrders { get; set; }
        public virtual DbSet<PRSPurchaseOrderDetail> PRSPurchaseOrderDetails { get; set; }
        public virtual DbSet<PRSPurchaseOrderReceiptStatu> PRSPurchaseOrderReceiptStatus { get; set; }
        public virtual DbSet<PRSPurchaseOrderStatu> PRSPurchaseOrderStatus { get; set; }
        public virtual DbSet<PRSPurchasePayment> PRSPurchasePayments { get; set; }
        public virtual DbSet<PRSPurchaseReceipt> PRSPurchaseReceipts { get; set; }
        public virtual DbSet<PRSPurchaseReceiptDetail> PRSPurchaseReceiptDetails { get; set; }
        public virtual DbSet<PRSPurchaseRecieptStatu> PRSPurchaseRecieptStatus { get; set; }
        public virtual DbSet<PRSPurchaseRequisition> PRSPurchaseRequisitions { get; set; }
        public virtual DbSet<PRSPurchaseRequisitionDetail> PRSPurchaseRequisitionDetails { get; set; }
        public virtual DbSet<PRSPurchaseRequisitionStatu> PRSPurchaseRequisitionStatus { get; set; }
        public virtual DbSet<PRSPurchaseReturn> PRSPurchaseReturns { get; set; }
        public virtual DbSet<PRSPurchaseReturnDetail> PRSPurchaseReturnDetails { get; set; }
        public virtual DbSet<PRSPurchaseReturnStatu> PRSPurchaseReturnStatus { get; set; }
        public virtual DbSet<PRSReceipt_Inv_Status> PRSReceipt_Inv_Status { get; set; }
        public virtual DbSet<PRSUserAndReceiver> PRSUserAndReceivers { get; set; }
        public virtual DbSet<PRSUserAndReceiverDetail> PRSUserAndReceiverDetails { get; set; }
        public virtual DbSet<SECApplication> SECApplications { get; set; }
        public virtual DbSet<SECComponent> SECComponents { get; set; }
        public virtual DbSet<SECModule> SECModules { get; set; }
        public virtual DbSet<SECPermissionList> SECPermissionLists { get; set; }
        public virtual DbSet<SECPermissionListDetail> SECPermissionListDetails { get; set; }
        public virtual DbSet<SECRole> SECRoles { get; set; }
        public virtual DbSet<SECRoleAndPermission> SECRoleAndPermissions { get; set; }
        public virtual DbSet<SECUser> SECUsers { get; set; }
        public virtual DbSet<SECUserAndBusinessUnit> SECUserAndBusinessUnits { get; set; }
        public virtual DbSet<SECUserAndRole> SECUserAndRoles { get; set; }
        public virtual DbSet<SLSAdditionalExpConfig> SLSAdditionalExpConfigs { get; set; }
        public virtual DbSet<SLSAddlExpDetail> SLSAddlExpDetails { get; set; }
        public virtual DbSet<SLSCashSalesConfiguration> SLSCashSalesConfigurations { get; set; }
        public virtual DbSet<SLSDeliveryStatu> SLSDeliveryStatus { get; set; }
        public virtual DbSet<SLSInvoiceStatu> SLSInvoiceStatus { get; set; }
        public virtual DbSet<SLSLC> SLSLCs { get; set; }
        public virtual DbSet<SLSLC_Details> SLSLC_Details { get; set; }
        public virtual DbSet<SLSLC_DocsWorkflow> SLSLC_DocsWorkflow { get; set; }
        public virtual DbSet<SLSLCDocsStatu> SLSLCDocsStatus { get; set; }
        public virtual DbSet<SLSLCInvoiceStatu> SLSLCInvoiceStatus { get; set; }
        public virtual DbSet<SLSMfgInstruction> SLSMfgInstructions { get; set; }
        public virtual DbSet<SLSMfgInstructionDetail> SLSMfgInstructionDetails { get; set; }
        public virtual DbSet<SLSMfgInstructionStatu> SLSMfgInstructionStatus { get; set; }
        public virtual DbSet<SLSSalesInvoice> SLSSalesInvoices { get; set; }
        public virtual DbSet<SLSSalesInvoiceDetail> SLSSalesInvoiceDetails { get; set; }
        public virtual DbSet<SLSSalesOrder> SLSSalesOrders { get; set; }
        public virtual DbSet<SLSSalesOrderAmendment> SLSSalesOrderAmendments { get; set; }
        public virtual DbSet<SLSSalesOrderAmendmentDetail> SLSSalesOrderAmendmentDetails { get; set; }
        public virtual DbSet<SLSSalesOrderDetail> SLSSalesOrderDetails { get; set; }
        public virtual DbSet<SLSSalesOrderDetailForDO> SLSSalesOrderDetailForDOes { get; set; }
        public virtual DbSet<SLSSalesOrderDetailSpec> SLSSalesOrderDetailSpecs { get; set; }
        public virtual DbSet<SLSSalesOrderSpecConfig> SLSSalesOrderSpecConfigs { get; set; }
        public virtual DbSet<SLSSalesOrderStatu> SLSSalesOrderStatus { get; set; }
        public virtual DbSet<SLSSalesOrderTerm> SLSSalesOrderTerms { get; set; }
        public virtual DbSet<SLSSalesOrderTermsConfig> SLSSalesOrderTermsConfigs { get; set; }
        public virtual DbSet<SLSSalesPayment> SLSSalesPayments { get; set; }
        public virtual DbSet<SLSSalesReturn> SLSSalesReturns { get; set; }
        public virtual DbSet<SLSSalesReturnDetail> SLSSalesReturnDetails { get; set; }
        public virtual DbSet<SLSSOChange_hdr> SLSSOChange_hdr { get; set; }
        public virtual DbSet<SLSSOChange_line> SLSSOChange_line { get; set; }
        public virtual DbSet<SLSSOPaymentMode> SLSSOPaymentModes { get; set; }
        public virtual DbSet<FACVoucher> FACVouchers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BSEAutoNumberSetup>()
                .Property(e => e.Separator)
                .IsFixedLength();

            modelBuilder.Entity<BSEBankAccount>()
                .HasMany(e => e.PRSPurchasePayments)
                .WithOptional(e => e.BSEBankAccount)
                .HasForeignKey(e => e.RecBankAccountID);

            modelBuilder.Entity<BSEBankAccount>()
                .HasMany(e => e.SLSSalesPayments)
                .WithOptional(e => e.BSEBankAccount)
                .HasForeignKey(e => e.RecBankAccountID);

            modelBuilder.Entity<BSEBankInfo>()
                .HasMany(e => e.PRSPurchasePayments)
                .WithOptional(e => e.BSEBankInfo)
                .HasForeignKey(e => e.ReceivingBank);

            modelBuilder.Entity<BSEBankInfo>()
                .HasMany(e => e.SLSSalesPayments)
                .WithOptional(e => e.BSEBankInfo)
                .HasForeignKey(e => e.ReceivingBank);

            modelBuilder.Entity<BSEBusinessParty>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<BSEBusinessParty>()
                .HasMany(e => e.FACPrepayments)
                .WithOptional(e => e.BSEBusinessParty)
                .HasForeignKey(e => e.SupplierID);

            modelBuilder.Entity<BSEBusinessParty>()
                .HasMany(e => e.PRSPurchaseReceipts)
                .WithOptional(e => e.BSEBusinessParty)
                .HasForeignKey(e => e.SupplyerID);

            modelBuilder.Entity<BSEBusinessUnit>()
                .HasMany(e => e.BSEProjects)
                .WithRequired(e => e.BSEBusinessUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BSEBusinessUnit>()
                .HasMany(e => e.FACJournals)
                .WithOptional(e => e.BSEBusinessUnit)
                .HasForeignKey(e => e.InterUnitBUID);

            modelBuilder.Entity<BSEBusinessUnit>()
                .HasMany(e => e.FACJournals1)
                .WithOptional(e => e.BSEBusinessUnit1)
                .HasForeignKey(e => e.BusinessUnitID);

            modelBuilder.Entity<BSEBusinessUnit>()
                .HasMany(e => e.INVInventoryRules)
                .WithRequired(e => e.BSEBusinessUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BSEBusinessUnit>()
                .HasMany(e => e.INVItemInitialBalances)
                .WithRequired(e => e.BSEBusinessUnit)
                .HasForeignKey(e => e.ItemBusinessUnitID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BSEBusinessUnit>()
                .HasMany(e => e.INVItemMovements)
                .WithRequired(e => e.BSEBusinessUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BSEBusinessUnit>()
                .HasMany(e => e.INVItemMovementTypes)
                .WithRequired(e => e.BSEBusinessUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BSEBusinessUnit>()
                .HasMany(e => e.INVStorageLocations)
                .WithRequired(e => e.BSEBusinessUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BSEBusinessUnit>()
                .HasMany(e => e.INVUserAndIssuers)
                .WithRequired(e => e.BSEBusinessUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BSEBusinessUnit>()
                .HasMany(e => e.PRSUserAndReceivers)
                .WithRequired(e => e.BSEBusinessUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BSECountry>()
                .Property(e => e.ISO)
                .IsUnicode(false);

            modelBuilder.Entity<BSECountry>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<BSECountry>()
                .Property(e => e.ISO3)
                .IsUnicode(false);

            modelBuilder.Entity<BSECountry>()
                .Property(e => e.NumCode)
                .IsUnicode(false);

            modelBuilder.Entity<BSECurrency>()
                .Property(e => e.Rate)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BSEDistrictName>()
                .Property(e => e.DivisionID)
                .IsFixedLength();

            modelBuilder.Entity<BSELocation>()
                .HasMany(e => e.PRSPurchaseOrders)
                .WithOptional(e => e.BSELocation)
                .HasForeignKey(e => e.ShipToLocationID);

            modelBuilder.Entity<BSEMeasurementUnit>()
                .HasMany(e => e.FACBillingDetails)
                .WithOptional(e => e.BSEMeasurementUnit)
                .HasForeignKey(e => e.MeasurementUnitID);

            modelBuilder.Entity<BSEMeasurementUnit>()
                .HasMany(e => e.INVItemInfoes)
                .WithOptional(e => e.BSEMeasurementUnit)
                .HasForeignKey(e => e.MeasurementUnitID);

            modelBuilder.Entity<BSEMeasurementUnit>()
                .HasMany(e => e.INVItemInitialBalances)
                .WithOptional(e => e.BSEMeasurementUnit)
                .HasForeignKey(e => e.MeasurementUnitID);

            modelBuilder.Entity<BSEMeasurementUnit>()
                .HasMany(e => e.INVPutawayDetails)
                .WithOptional(e => e.BSEMeasurementUnit)
                .HasForeignKey(e => e.MeasurementUnitID);

            modelBuilder.Entity<BSEPaymentMode>()
                .Property(e => e.PayModeName)
                .IsUnicode(false);

            modelBuilder.Entity<BSEPaymentMode>()
                .Property(e => e.PayModeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BSEPaymentMode>()
                .HasMany(e => e.FACPayments)
                .WithOptional(e => e.BSEPaymentMode)
                .HasForeignKey(e => e.PaymentModeID);

            modelBuilder.Entity<BSEPaymentTerm>()
                .Property(e => e.TermName)
                .IsUnicode(false);

            modelBuilder.Entity<BSEPaymentTerm>()
                .Property(e => e.TermDescription)
                .IsUnicode(false);

            modelBuilder.Entity<FACAccountingPeriod>()
                .Property(e => e.AccountingPeriodName)
                .IsFixedLength();

            modelBuilder.Entity<FACAccountingPeriodTest>()
                .Property(e => e.AccountingPeriodName)
                .IsFixedLength();

            modelBuilder.Entity<FACAccountingReportType>()
                .Property(e => e.AccountTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<FACAccountingReportType>()
                .Property(e => e.TypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<FACAccountMasterType>()
                .Property(e => e.MasterTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<FACAccountMasterType>()
                .Property(e => e.MasterTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<FACAccountMasterType>()
                .Property(e => e.DrCr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FACAccountMasterType>()
                .HasMany(e => e.FACAccountTypes)
                .WithRequired(e => e.FACAccountMasterType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACAccountSubType>()
                .Property(e => e.AccountSubTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<FACAccountSubType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FACAccountSubType>()
                .Property(e => e.NatureDrCr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FACAccountType>()
                .Property(e => e.AccountTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<FACAccountType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FACAccountType>()
                .Property(e => e.NatureDrCr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FACAccountType>()
                .HasOptional(e => e.FACAccountingReportType)
                .WithRequired(e => e.FACAccountType);

            modelBuilder.Entity<FACAccountType>()
                .HasMany(e => e.FACAccountSubTypes)
                .WithRequired(e => e.FACAccountType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACApplyPrepayment>()
                .Property(e => e.AppliedPaymentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACBilling>()
                .Property(e => e.DueAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACBilling>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACBillingDetail>()
                .Property(e => e.ItemAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACBillingDetail>()
                .Property(e => e.ItemUnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACChartOfAccount>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<FACChartOfAccount>()
                .Property(e => e.CurrentBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACChartOfAccount>()
                .HasMany(e => e.BSEProjects)
                .WithOptional(e => e.FACChartOfAccount)
                .HasForeignKey(e => e.AccountExp);

            modelBuilder.Entity<FACChartOfAccount>()
                .HasMany(e => e.BSEProjects1)
                .WithOptional(e => e.FACChartOfAccount1)
                .HasForeignKey(e => e.AccountCash);

            modelBuilder.Entity<FACChartOfAccount>()
                .HasOptional(e => e.FACChartOfAccountsStat)
                .WithRequired(e => e.FACChartOfAccount);

            modelBuilder.Entity<FACChartOfAccount>()
                .HasMany(e => e.FACGLedgers)
                .WithRequired(e => e.FACChartOfAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACChartOfAccount>()
                .HasMany(e => e.FACGLSecurityRuleAndCOAs)
                .WithRequired(e => e.FACChartOfAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACChartOfAccount>()
                .HasMany(e => e.FACInitialBalances)
                .WithRequired(e => e.FACChartOfAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACChartOfAccount>()
                .HasMany(e => e.FACJournalDetails)
                .WithRequired(e => e.FACChartOfAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACChartOfAccount>()
                .HasMany(e => e.INVInventoryTypes)
                .WithOptional(e => e.FACChartOfAccount)
                .HasForeignKey(e => e.AccountCodeDr);

            modelBuilder.Entity<FACChartOfAccount>()
                .HasMany(e => e.INVItemInfoes)
                .WithOptional(e => e.FACChartOfAccount)
                .HasForeignKey(e => e.COGSAccountCode);

            modelBuilder.Entity<FACChartOfAccount>()
                .HasMany(e => e.INVItemInfoes1)
                .WithOptional(e => e.FACChartOfAccount1)
                .HasForeignKey(e => e.IncomeAccCode);

            modelBuilder.Entity<FACChartOfAccount>()
                .HasMany(e => e.INVItemInfoes2)
                .WithOptional(e => e.FACChartOfAccount2)
                .HasForeignKey(e => e.AssetAccCode);

            modelBuilder.Entity<FACChartOfAccountsStat>()
                .Property(e => e.TotalDebitAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACChartOfAccountsStat>()
                .Property(e => e.TotalCreditAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACChartOfAccountsStat>()
                .Property(e => e.TotalBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACCreditMemo>()
                .Property(e => e.CreditAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACDebitMemo>()
                .Property(e => e.DebitAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACFinSecurityRule>()
                .Property(e => e.MaxValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACGLedger>()
                .Property(e => e.PostedDrAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACGLedger>()
                .Property(e => e.PostedCrAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACGLedger>()
                .Property(e => e.PostedTotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACGLedger>()
                .Property(e => e.TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<FACGLSecurityRule>()
                .HasMany(e => e.FACGLSecurityRuleAndCOAs)
                .WithRequired(e => e.FACGLSecurityRule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACGLSecurityRule>()
                .HasMany(e => e.FACUserAndGLSecurityRules)
                .WithRequired(e => e.FACGLSecurityRule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACGLSecurityRuleAndCOA>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<FACInitialBalance>()
                .Property(e => e.PostedDrAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACInitialBalance>()
                .Property(e => e.PostedCrAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACInitialBalance>()
                .Property(e => e.PostedTotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACInitialBalance>()
                .Property(e => e.TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<FACJournal>()
                .Property(e => e.TotalDrAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACJournal>()
                .Property(e => e.TotalCrAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACJournal>()
                .Property(e => e.RowState)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FACJournal>()
                .Property(e => e.SourcesProcessID)
                .IsUnicode(false);

            modelBuilder.Entity<FACJournal>()
                .Property(e => e.SourcesProcessDesc)
                .IsUnicode(false);

            modelBuilder.Entity<FACJournal>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<FACJournal>()
                .HasMany(e => e.FACJournalDetails)
                .WithRequired(e => e.FACJournal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACJournalDetail>()
                .Property(e => e.DrAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACJournalDetail>()
                .Property(e => e.CrAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACJournalDetail>()
                .Property(e => e.DrCrFactor)
                .IsUnicode(false);

            modelBuilder.Entity<FACJournalDetail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FACJournalDetail>()
                .Property(e => e.ForeignDrAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACJournalDetail>()
                .Property(e => e.ForeignCrAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACJournalDetail>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<FACJournalType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<FACJournalType>()
                .Property(e => e.TypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<FACJournalType>()
                .HasMany(e => e.FACJournals)
                .WithRequired(e => e.FACJournalType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FACPayment>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACPaymentDetail>()
                .Property(e => e.BillPaymentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACPrepayment>()
                .Property(e => e.PayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACPrepayment>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<FACPrepaymentInvoice>()
                .Property(e => e.InvoiceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACPrepaymentInvoice>()
                .Property(e => e.InvoiceNote)
                .IsUnicode(false);

            modelBuilder.Entity<FACPrepaymentInvoice>()
                .Property(e => e.ConversionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACPrepaymentInvoice>()
                .Property(e => e.AvailableAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACPrepaymentInvoiceStatu>()
                .HasMany(e => e.FACPrepaymentInvoices)
                .WithOptional(e => e.FACPrepaymentInvoiceStatu)
                .HasForeignKey(e => e.InvoiceStatusID);

            modelBuilder.Entity<FACSourceProcess>()
                .Property(e => e.ProcessID)
                .IsUnicode(false);

            modelBuilder.Entity<FACSourceProcess>()
                .Property(e => e.ProcessDescription)
                .IsUnicode(false);

            modelBuilder.Entity<FACTemporaryFund>()
                .Property(e => e.TotalIssuedAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACTemporaryFund>()
                .Property(e => e.TotalReveivedAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACTemporaryFund>()
                .Property(e => e.IssueNote)
                .IsUnicode(false);

            modelBuilder.Entity<FACTemporaryFund>()
                .Property(e => e.CloseNote)
                .IsUnicode(false);

            modelBuilder.Entity<FACUserAndGLSecurityRule>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<INVInventoryRule>()
                .Property(e => e.TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<INVItemBalance>()
                .Property(e => e.AvgPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVItemBalance>()
                .Property(e => e.AvgPricePurchase)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVItemBalance>()
                .Property(e => e.AvgPriceProduction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVItemBalance>()
                .Property(e => e.OpeningCogmAP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVItemGroup>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<INVItemInfo>()
                .Property(e => e.CostPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVItemInfo>()
                .Property(e => e.MinimumSellingPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVItemInfo>()
                .Property(e => e.MaximumSellingPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVItemInfo>()
                .HasMany(e => e.INVPutawayDetails)
                .WithRequired(e => e.INVItemInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INVItemMovement>()
                .Property(e => e.timestamp)
                .IsFixedLength();

            modelBuilder.Entity<INVItemMovementDetail>()
                .Property(e => e.AvgIssuePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVItemPriceHistory>()
                .Property(e => e.OldPurchasePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVItemPriceHistory>()
                .Property(e => e.NewPurchasePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVItemPriceHistory>()
                .Property(e => e.OldSellingPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVItemPriceHistory>()
                .Property(e => e.NewSellingPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVItemType>()
                .HasMany(e => e.INVItemGroups)
                .WithRequired(e => e.INVItemType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INVItemType>()
                .HasMany(e => e.INVUserAndIssuerDetails)
                .WithRequired(e => e.INVItemType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INVItemType>()
                .HasMany(e => e.PRSUserAndReceiverDetails)
                .WithRequired(e => e.INVItemType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INVPutaway>()
                .HasMany(e => e.INVPutawayDetails)
                .WithRequired(e => e.INVPutaway)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INVPutawayDetail>()
                .Property(e => e.LineTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVPutawayDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<INVSOLCDOItemDetailMap>()
                .Property(e => e.SalesOrderQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVSOLCDOItemDetailMap>()
                .Property(e => e.LCQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVSOLCDOItemDetailMap>()
                .Property(e => e.DeliveryQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INVUserAndIssuer>()
                .HasMany(e => e.INVUserAndIssuerDetails)
                .WithRequired(e => e.INVUserAndIssuer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRSPurchaseHistory>()
                .Property(e => e.ItemUnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseHistory>()
                .Property(e => e.ConversionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseHistory>()
                .Property(e => e.OrderUnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseInvoice>()
                .Property(e => e.InvoiceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseInvoice>()
                .Property(e => e.MerchandiseAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseInvoice>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseInvoice>()
                .Property(e => e.DebitMemoAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseInvoice>()
                .Property(e => e.PaymentedAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseInvoice>()
                .Property(e => e.ConversionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseInvoice>()
                .HasMany(e => e.PRSPurchaseInvoiceDetails)
                .WithRequired(e => e.PRSPurchaseInvoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRSPurchaseInvoiceDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRSPurchaseInvoiceDetail>()
                .Property(e => e.LineTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseOrder>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseOrder>()
                .Property(e => e.ConversionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseOrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRSPurchaseOrderDetail>()
                .Property(e => e.LineTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseOrderDetail>()
                .Property(e => e.Specification)
                .IsUnicode(false);

            modelBuilder.Entity<PRSPurchasePayment>()
                .Property(e => e.PayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchasePayment>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<PRSPurchasePayment>()
                .Property(e => e.FxConversionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchasePayment>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchasePayment>()
                .Property(e => e.AdjPrepaymentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseReceiptDetail>()
                .Property(e => e.LineTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseReceiptDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRSPurchaseRequisition>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseRequisitionDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseRequisitionDetail>()
                .Property(e => e.LineTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRSPurchaseRequisitionDetail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PRSReceipt_Inv_Status>()
                .HasMany(e => e.PRSPurchaseReceipts)
                .WithOptional(e => e.PRSReceipt_Inv_Status)
                .HasForeignKey(e => e.ReceiptInvStatusID);

            modelBuilder.Entity<PRSUserAndReceiver>()
                .HasMany(e => e.PRSUserAndReceiverDetails)
                .WithRequired(e => e.PRSUserAndReceiver)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SECApplication>()
                .HasMany(e => e.SECModules)
                .WithRequired(e => e.SECApplication)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SECComponent>()
                .HasMany(e => e.SECPermissionListDetails)
                .WithRequired(e => e.SECComponent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SECPermissionList>()
                .HasMany(e => e.SECPermissionListDetails)
                .WithRequired(e => e.SECPermissionList)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SECPermissionList>()
                .HasMany(e => e.SECRoleAndPermissions)
                .WithRequired(e => e.SECPermissionList)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SECRole>()
                .HasMany(e => e.SECRoleAndPermissions)
                .WithRequired(e => e.SECRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SECRole>()
                .HasMany(e => e.SECUserAndRoles)
                .WithRequired(e => e.SECRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SECRoleAndPermission>()
                .Property(e => e.TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<SECUser>()
                .Property(e => e.RowState)
                .IsUnicode(false);

            modelBuilder.Entity<SECUser>()
                .Property(e => e.timestamp)
                .IsFixedLength();

            modelBuilder.Entity<SECUser>()
                .HasMany(e => e.FACAccountingPeriods)
                .WithOptional(e => e.SECUser)
                .HasForeignKey(e => e.ClosedBy);

            modelBuilder.Entity<SECUser>()
                .HasMany(e => e.FACAccountingPeriods1)
                .WithOptional(e => e.SECUser1)
                .HasForeignKey(e => e.ReOpenBy);

            modelBuilder.Entity<SECUser>()
                .HasMany(e => e.FACUserAndGLSecurityRules)
                .WithRequired(e => e.SECUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SECUser>()
                .HasMany(e => e.PRSPurchaseReceipts)
                .WithOptional(e => e.SECUser)
                .HasForeignKey(e => e.ReceivedBy);

            modelBuilder.Entity<SECUser>()
                .HasMany(e => e.PRSPurchaseRequisitions)
                .WithOptional(e => e.SECUser)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<SECUser>()
                .HasMany(e => e.PRSPurchaseRequisitions1)
                .WithOptional(e => e.SECUser1)
                .HasForeignKey(e => e.ModifiedBy);

            modelBuilder.Entity<SECUser>()
                .HasMany(e => e.PRSPurchaseRequisitions2)
                .WithOptional(e => e.SECUser2)
                .HasForeignKey(e => e.DeletedBy);

            modelBuilder.Entity<SECUser>()
                .HasMany(e => e.PRSPurchaseRequisitions3)
                .WithOptional(e => e.SECUser3)
                .HasForeignKey(e => e.ClosedBy);

            modelBuilder.Entity<SECUser>()
                .HasMany(e => e.PRSPurchaseRequisitions4)
                .WithOptional(e => e.SECUser4)
                .HasForeignKey(e => e.RejectedBy);

            modelBuilder.Entity<SECUser>()
                .HasMany(e => e.PRSPurchaseRequisitions5)
                .WithOptional(e => e.SECUser5)
                .HasForeignKey(e => e.ApprovedBy);

            modelBuilder.Entity<SECUser>()
                .HasMany(e => e.SECUserAndRoles)
                .WithRequired(e => e.SECUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SLSCashSalesConfiguration>()
                .Property(e => e.DefaultVatPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSInvoiceStatu>()
                .HasMany(e => e.PRSPurchaseInvoices)
                .WithOptional(e => e.SLSInvoiceStatu)
                .HasForeignKey(e => e.InvoiceStatusID);

            modelBuilder.Entity<SLSInvoiceStatu>()
                .HasMany(e => e.SLSSalesInvoices)
                .WithOptional(e => e.SLSInvoiceStatu)
                .HasForeignKey(e => e.InvoiceStatusID);

            modelBuilder.Entity<SLSLC>()
                .Property(e => e.LCAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSMfgInstructionStatu>()
                .HasMany(e => e.SLSMfgInstructions)
                .WithOptional(e => e.SLSMfgInstructionStatu)
                .HasForeignKey(e => e.MIStatus);

            modelBuilder.Entity<SLSSalesInvoice>()
                .Property(e => e.InvoiceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesInvoice>()
                .Property(e => e.MerchandiseAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesInvoice>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesInvoice>()
                .Property(e => e.CreditMemoAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesInvoice>()
                .Property(e => e.InvoiceNote)
                .IsUnicode(false);

            modelBuilder.Entity<SLSSalesInvoice>()
                .Property(e => e.PaymentedAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesInvoice>()
                .Property(e => e.ConversionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesInvoice>()
                .Property(e => e.VATPercentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesInvoice>()
                .Property(e => e.VATAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesInvoice>()
                .HasOptional(e => e.SLSAddlExpDetail)
                .WithRequired(e => e.SLSSalesInvoice);

            modelBuilder.Entity<SLSSalesInvoice>()
                .HasMany(e => e.SLSSalesInvoiceDetails)
                .WithRequired(e => e.SLSSalesInvoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SLSSalesInvoiceDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<SLSSalesInvoiceDetail>()
                .Property(e => e.LineTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesInvoiceDetail>()
                .Property(e => e.AdvancePayment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesInvoiceDetail>()
                .Property(e => e.AdjustedTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesInvoiceDetail>()
                .Property(e => e.LineDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesInvoiceDetail>()
                .Property(e => e.LineDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesInvoiceDetail>()
                .Property(e => e.LineVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesInvoiceDetail>()
                .Property(e => e.LineVATAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesOrder>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesOrder>()
                .Property(e => e.ConversionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesOrder>()
                .Property(e => e.AdvancePayment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesOrderAmendmentDetail>()
                .Property(e => e.PrevRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesOrderAmendmentDetail>()
                .Property(e => e.NewRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesOrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 6);

            modelBuilder.Entity<SLSSalesOrderDetail>()
                .Property(e => e.LineTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesOrderDetail>()
                .Property(e => e.AdvancePayment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesOrderDetail>()
                .HasMany(e => e.SLSSalesOrderDetailSpecs)
                .WithRequired(e => e.SLSSalesOrderDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SLSSalesOrderSpecConfig>()
                .HasMany(e => e.SLSSalesOrderDetailSpecs)
                .WithRequired(e => e.SLSSalesOrderSpecConfig)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SLSSalesPayment>()
                .Property(e => e.PayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesPayment>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesPayment>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<SLSSalesPayment>()
                .Property(e => e.FxConversionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesPayment>()
                .Property(e => e.BankChargeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SLSSalesPayment>()
                .Property(e => e.AdjPrepaymentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACVoucher>()
                .Property(e => e.InvoiceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACVoucher>()
                .Property(e => e.MerchandiseAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACVoucher>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACVoucher>()
                .Property(e => e.DebitMemoAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACVoucher>()
                .Property(e => e.PaymentedAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FACVoucher>()
                .Property(e => e.ConversionRate)
                .HasPrecision(19, 4);
        }
    }
}
