using LoadTest.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LoadTest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Original entities (43 + 1 extra = 44)
        public virtual DbSet<AdminMoneyCollection> AdminMoneyCollection { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountDeposit> AccountDeposit { get; set; }
        public virtual DbSet<AccountWithdraw> AccountWithdraw { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerPhone> CustomerPhone { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<ExpenseFixed> ExpenseFixed { get; set; }
        public virtual DbSet<ExpenseTransportation> ExpenseTransportation { get; set; }
        public virtual DbSet<ExpenseTransportationList> ExpenseTransportationList { get; set; }
        public virtual DbSet<ExpenseCategory> ExpenseCategory { get; set; }
        public virtual DbSet<Institution> Institution { get; set; }
        public virtual DbSet<PageLink> PageLink { get; set; }
        public virtual DbSet<PageLinkAssign> PageLinkAssign { get; set; }
        public virtual DbSet<PageLinkCategory> PageLinkCategory { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCatalog> ProductCatalog { get; set; }
        public virtual DbSet<ProductCatalogType> ProductCatalogType { get; set; }
        public virtual DbSet<ProductDamaged> ProductDamaged { get; set; }
        public virtual DbSet<ProductLog> ProductLog { get; set; }
        public virtual DbSet<ProductStock> ProductStock { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<PurchaseList> PurchaseList { get; set; }
        public virtual DbSet<PurchasePayment> PurchasePayment { get; set; }
        public virtual DbSet<PurchasePaymentList> PurchasePaymentList { get; set; }
        public virtual DbSet<PurchasePaymentReturnRecord> PurchasePaymentReturnRecord { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Selling> Selling { get; set; }
        public virtual DbSet<SellingExpense> SellingExpense { get; set; }
        public virtual DbSet<SellingAdjustment> SellingAdjustment { get; set; }
        public virtual DbSet<SellingList> SellingList { get; set; }
        public virtual DbSet<SellingPayment> SellingPayment { get; set; }
        public virtual DbSet<SellingPaymentList> SellingPaymentList { get; set; }
        public virtual DbSet<SellingPaymentReturnRecord> SellingPaymentReturnRecord { get; set; }
        public virtual DbSet<SellingPromiseDateMiss> SellingPromiseDateMiss { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceDevice> ServiceDevice { get; set; }
        public virtual DbSet<ServiceList> ServiceList { get; set; }
        public virtual DbSet<ServicePaymentList> ServicePaymentList { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<Warranty> Warranty { get; set; }
        public virtual DbSet<VW_ExpenseWithTransportation> VW_ExpenseWithTransportation { get; set; }
        public virtual DbSet<VW_CapitalProfitReport> VW_CapitalProfitReport { get; set; }
        public virtual DbSet<ExtraEntity1> ExtraEntity1 { get; set; }

        // B variant entities (43 + 1 extra = 44)
        public virtual DbSet<AdminMoneyCollectionB> AdminMoneyCollectionB { get; set; }
        public virtual DbSet<AccountB> AccountB { get; set; }
        public virtual DbSet<AccountDepositB> AccountDepositB { get; set; }
        public virtual DbSet<AccountWithdrawB> AccountWithdrawB { get; set; }
        public virtual DbSet<CustomerB> CustomerB { get; set; }
        public virtual DbSet<CustomerPhoneB> CustomerPhoneB { get; set; }
        public virtual DbSet<ExpenseB> ExpenseB { get; set; }
        public virtual DbSet<ExpenseFixedB> ExpenseFixedB { get; set; }
        public virtual DbSet<ExpenseTransportationB> ExpenseTransportationB { get; set; }
        public virtual DbSet<ExpenseTransportationListB> ExpenseTransportationListB { get; set; }
        public virtual DbSet<ExpenseCategoryB> ExpenseCategoryB { get; set; }
        public virtual DbSet<InstitutionB> InstitutionB { get; set; }
        public virtual DbSet<PageLinkB> PageLinkB { get; set; }
        public virtual DbSet<PageLinkAssignB> PageLinkAssignB { get; set; }
        public virtual DbSet<PageLinkCategoryB> PageLinkCategoryB { get; set; }
        public virtual DbSet<ProductB> ProductB { get; set; }
        public virtual DbSet<ProductCatalogB> ProductCatalogB { get; set; }
        public virtual DbSet<ProductCatalogTypeB> ProductCatalogTypeB { get; set; }
        public virtual DbSet<ProductDamagedB> ProductDamagedB { get; set; }
        public virtual DbSet<ProductLogB> ProductLogB { get; set; }
        public virtual DbSet<ProductStockB> ProductStockB { get; set; }
        public virtual DbSet<PurchaseB> PurchaseB { get; set; }
        public virtual DbSet<PurchaseListB> PurchaseListB { get; set; }
        public virtual DbSet<PurchasePaymentB> PurchasePaymentB { get; set; }
        public virtual DbSet<PurchasePaymentListB> PurchasePaymentListB { get; set; }
        public virtual DbSet<PurchasePaymentReturnRecordB> PurchasePaymentReturnRecordB { get; set; }
        public virtual DbSet<RegistrationB> RegistrationB { get; set; }
        public virtual DbSet<SellingB> SellingB { get; set; }
        public virtual DbSet<SellingExpenseB> SellingExpenseB { get; set; }
        public virtual DbSet<SellingAdjustmentB> SellingAdjustmentB { get; set; }
        public virtual DbSet<SellingListB> SellingListB { get; set; }
        public virtual DbSet<SellingPaymentB> SellingPaymentB { get; set; }
        public virtual DbSet<SellingPaymentListB> SellingPaymentListB { get; set; }
        public virtual DbSet<SellingPaymentReturnRecordB> SellingPaymentReturnRecordB { get; set; }
        public virtual DbSet<SellingPromiseDateMissB> SellingPromiseDateMissB { get; set; }
        public virtual DbSet<ServiceB> ServiceB { get; set; }
        public virtual DbSet<ServiceDeviceB> ServiceDeviceB { get; set; }
        public virtual DbSet<ServiceListB> ServiceListB { get; set; }
        public virtual DbSet<ServicePaymentListB> ServicePaymentListB { get; set; }
        public virtual DbSet<VendorB> VendorB { get; set; }
        public virtual DbSet<WarrantyB> WarrantyB { get; set; }
        public virtual DbSet<VW_ExpenseWithTransportationB> VW_ExpenseWithTransportationB { get; set; }
        public virtual DbSet<VW_CapitalProfitReportB> VW_CapitalProfitReportB { get; set; }
        public virtual DbSet<ExtraEntity1B> ExtraEntity1B { get; set; }

        // C variant entities (43 + 1 extra = 44)
        public virtual DbSet<AdminMoneyCollectionC> AdminMoneyCollectionC { get; set; }
        public virtual DbSet<AccountC> AccountC { get; set; }
        public virtual DbSet<AccountDepositC> AccountDepositC { get; set; }
        public virtual DbSet<AccountWithdrawC> AccountWithdrawC { get; set; }
        public virtual DbSet<CustomerC> CustomerC { get; set; }
        public virtual DbSet<CustomerPhoneC> CustomerPhoneC { get; set; }
        public virtual DbSet<ExpenseC> ExpenseC { get; set; }
        public virtual DbSet<ExpenseFixedC> ExpenseFixedC { get; set; }
        public virtual DbSet<ExpenseTransportationC> ExpenseTransportationC { get; set; }
        public virtual DbSet<ExpenseTransportationListC> ExpenseTransportationListC { get; set; }
        public virtual DbSet<ExpenseCategoryC> ExpenseCategoryC { get; set; }
        public virtual DbSet<InstitutionC> InstitutionC { get; set; }
        public virtual DbSet<PageLinkC> PageLinkC { get; set; }
        public virtual DbSet<PageLinkAssignC> PageLinkAssignC { get; set; }
        public virtual DbSet<PageLinkCategoryC> PageLinkCategoryC { get; set; }
        public virtual DbSet<ProductC> ProductC { get; set; }
        public virtual DbSet<ProductCatalogC> ProductCatalogC { get; set; }
        public virtual DbSet<ProductCatalogTypeC> ProductCatalogTypeC { get; set; }
        public virtual DbSet<ProductDamagedC> ProductDamagedC { get; set; }
        public virtual DbSet<ProductLogC> ProductLogC { get; set; }
        public virtual DbSet<ProductStockC> ProductStockC { get; set; }
        public virtual DbSet<PurchaseC> PurchaseC { get; set; }
        public virtual DbSet<PurchaseListC> PurchaseListC { get; set; }
        public virtual DbSet<PurchasePaymentC> PurchasePaymentC { get; set; }
        public virtual DbSet<PurchasePaymentListC> PurchasePaymentListC { get; set; }
        public virtual DbSet<PurchasePaymentReturnRecordC> PurchasePaymentReturnRecordC { get; set; }
        public virtual DbSet<RegistrationC> RegistrationC { get; set; }
        public virtual DbSet<SellingC> SellingC { get; set; }
        public virtual DbSet<SellingExpenseC> SellingExpenseC { get; set; }
        public virtual DbSet<SellingAdjustmentC> SellingAdjustmentC { get; set; }
        public virtual DbSet<SellingListC> SellingListC { get; set; }
        public virtual DbSet<SellingPaymentC> SellingPaymentC { get; set; }
        public virtual DbSet<SellingPaymentListC> SellingPaymentListC { get; set; }
        public virtual DbSet<SellingPaymentReturnRecordC> SellingPaymentReturnRecordC { get; set; }
        public virtual DbSet<SellingPromiseDateMissC> SellingPromiseDateMissC { get; set; }
        public virtual DbSet<ServiceC> ServiceC { get; set; }
        public virtual DbSet<ServiceDeviceC> ServiceDeviceC { get; set; }
        public virtual DbSet<ServiceListC> ServiceListC { get; set; }
        public virtual DbSet<ServicePaymentListC> ServicePaymentListC { get; set; }
        public virtual DbSet<VendorC> VendorC { get; set; }
        public virtual DbSet<WarrantyC> WarrantyC { get; set; }
        public virtual DbSet<VW_ExpenseWithTransportationC> VW_ExpenseWithTransportationC { get; set; }
        public virtual DbSet<VW_CapitalProfitReportC> VW_CapitalProfitReportC { get; set; }
        public virtual DbSet<ExtraEntity1C> ExtraEntity1C { get; set; }

        // D variant entities (43 + 1 extra = 44)
        public virtual DbSet<AdminMoneyCollectionD> AdminMoneyCollectionD { get; set; }
        public virtual DbSet<AccountD> AccountD { get; set; }
        public virtual DbSet<AccountDepositD> AccountDepositD { get; set; }
        public virtual DbSet<AccountWithdrawD> AccountWithdrawD { get; set; }
        public virtual DbSet<CustomerD> CustomerD { get; set; }
        public virtual DbSet<CustomerPhoneD> CustomerPhoneD { get; set; }
        public virtual DbSet<ExpenseD> ExpenseD { get; set; }
        public virtual DbSet<ExpenseTransportationD> ExpenseTransportationD { get; set; }
        public virtual DbSet<ExpenseTransportationListD> ExpenseTransportationListD { get; set; }
        public virtual DbSet<ExpenseCategoryD> ExpenseCategoryD { get; set; }
        public virtual DbSet<InstitutionD> InstitutionD { get; set; }
        public virtual DbSet<PageLinkD> PageLinkD { get; set; }
        public virtual DbSet<PageLinkAssignD> PageLinkAssignD { get; set; }
        public virtual DbSet<PageLinkCategoryD> PageLinkCategoryD { get; set; }
        public virtual DbSet<ProductD> ProductD { get; set; }
        public virtual DbSet<ProductCatalogD> ProductCatalogD { get; set; }
        public virtual DbSet<ProductCatalogTypeD> ProductCatalogTypeD { get; set; }
        public virtual DbSet<ProductLogD> ProductLogD { get; set; }
        public virtual DbSet<ProductStockD> ProductStockD { get; set; }
        public virtual DbSet<PurchaseD> PurchaseD { get; set; }
        public virtual DbSet<PurchaseListD> PurchaseListD { get; set; }
        public virtual DbSet<PurchasePaymentD> PurchasePaymentD { get; set; }
        public virtual DbSet<PurchasePaymentListD> PurchasePaymentListD { get; set; }
        public virtual DbSet<RegistrationD> RegistrationD { get; set; }
        public virtual DbSet<SellingD> SellingD { get; set; }
        public virtual DbSet<SellingExpenseD> SellingExpenseD { get; set; }
        public virtual DbSet<SellingAdjustmentD> SellingAdjustmentD { get; set; }
        public virtual DbSet<SellingListD> SellingListD { get; set; }
        public virtual DbSet<SellingPaymentD> SellingPaymentD { get; set; }
        public virtual DbSet<SellingPaymentListD> SellingPaymentListD { get; set; }
        public virtual DbSet<SellingPromiseDateMissD> SellingPromiseDateMissD { get; set; }
        public virtual DbSet<ServiceD> ServiceD { get; set; }
        public virtual DbSet<ServiceDeviceD> ServiceDeviceD { get; set; }
        public virtual DbSet<ServiceListD> ServiceListD { get; set; }
        public virtual DbSet<ServicePaymentListD> ServicePaymentListD { get; set; }
        public virtual DbSet<VendorD> VendorD { get; set; }
        public virtual DbSet<WarrantyD> WarrantyD { get; set; }
        public virtual DbSet<VW_ExpenseWithTransportationD> VW_ExpenseWithTransportationD { get; set; }
        public virtual DbSet<VW_CapitalProfitReportD> VW_CapitalProfitReportD { get; set; }
        public virtual DbSet<ExtraEntity1D> ExtraEntity1D { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships and constraints
            ConfigureRelationships(modelBuilder);
            
            // Configure views as keyless entities
            modelBuilder.Entity<VW_ExpenseWithTransportation>().HasNoKey().ToView("VW_ExpenseWithTransportation");
            modelBuilder.Entity<VW_CapitalProfitReport>().HasNoKey().ToView("VW_CapitalProfitReport");
            modelBuilder.Entity<VW_ExpenseWithTransportationB>().HasNoKey().ToView("VW_ExpenseWithTransportationB");
            modelBuilder.Entity<VW_CapitalProfitReportB>().HasNoKey().ToView("VW_CapitalProfitReportB");
            modelBuilder.Entity<VW_ExpenseWithTransportationC>().HasNoKey().ToView("VW_ExpenseWithTransportationC");
            modelBuilder.Entity<VW_CapitalProfitReportC>().HasNoKey().ToView("VW_CapitalProfitReportC");
            modelBuilder.Entity<VW_ExpenseWithTransportationD>().HasNoKey().ToView("VW_ExpenseWithTransportationD");
            modelBuilder.Entity<VW_CapitalProfitReportD>().HasNoKey().ToView("VW_CapitalProfitReportD");
        }

        private void ConfigureRelationships(ModelBuilder modelBuilder)
        {
            // Disable cascade delete globally to avoid circular references
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            // Configure decimal precision for all decimal properties
            ConfigureDecimalPrecision(modelBuilder);
        }

        private void ConfigureDecimalPrecision(ModelBuilder modelBuilder)
        {
            // Original entities
            modelBuilder.Entity<Product>().Property(p => p.SellingPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Customer>().Property(c => c.TotalAmount).HasPrecision(18, 2);
            modelBuilder.Entity<Purchase>().Property(p => p.PurchaseTotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Selling>().Property(s => s.SellingTotalPrice).HasPrecision(18, 2);

            // B variant entities
            modelBuilder.Entity<ProductB>().Property(p => p.SellingPrice).HasPrecision(18, 2);
            modelBuilder.Entity<CustomerB>().Property(c => c.TotalAmount).HasPrecision(18, 2);
            modelBuilder.Entity<PurchaseB>().Property(p => p.PurchaseTotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<SellingB>().Property(s => s.SellingTotalPrice).HasPrecision(18, 2);

            // C variant entities
            modelBuilder.Entity<ProductC>().Property(p => p.SellingPrice).HasPrecision(18, 2);
            modelBuilder.Entity<CustomerC>().Property(c => c.TotalAmount).HasPrecision(18, 2);
            modelBuilder.Entity<PurchaseC>().Property(p => p.PurchaseTotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<SellingC>().Property(s => s.SellingTotalPrice).HasPrecision(18, 2);

            // D variant entities
            modelBuilder.Entity<ProductD>().Property(p => p.SellingPrice).HasPrecision(18, 2);
            modelBuilder.Entity<CustomerD>().Property(c => c.TotalAmount).HasPrecision(18, 2);
            modelBuilder.Entity<PurchaseD>().Property(p => p.PurchaseTotalPrice).HasPrecision(18, 2);
            modelBuilder.Entity<SellingD>().Property(s => s.SellingTotalPrice).HasPrecision(18, 2);
        }
    }
}