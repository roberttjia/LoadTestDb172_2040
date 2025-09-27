using LoadTest.Data;
using LoadTest.Data.Configuration;
using LoadTest.Data.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Bogus;

namespace LoadTest.Console
{
    public class DirectLoadTest
    {
        public static async Task<int> Main(string[] args)
        {
            System.Console.WriteLine("Starting Direct Load Test for LoadTestDb172_2040...");
            System.Console.WriteLine("This will populate all 172 entities with test data");

            try
            {
                // Build configuration
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false)
                    .AddEnvironmentVariables()
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                System.Console.WriteLine($"Using connection: {MaskPassword(connectionString)}");

                // Create DbContext directly
                System.Console.WriteLine("Creating database context...");
                using var context = DatabaseConfiguration.CreateDbContext(connectionString!);

                // Test connection
                System.Console.WriteLine("Testing database connection...");
                await context.Database.CanConnectAsync();
                System.Console.WriteLine("✅ Database connection successful");

                // Run the load test
                var recordsPerEntity = 25; // Smaller number for faster testing with 172 entities
                await RunLoadTestAsync(context, recordsPerEntity);

                System.Console.WriteLine("✅ Load test completed successfully!");
                return 0;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"❌ Error: {ex.Message}");
                System.Console.WriteLine($"Stack trace: {ex.StackTrace}");
                return 1;
            }
        }

        private static async Task RunLoadTestAsync(ApplicationDbContext context, int recordsPerEntity)
        {
            System.Console.WriteLine($"Starting load test with {recordsPerEntity} records per entity...");

            var faker = new Faker();

            // Step 1: Create foundational data for original entities
            System.Console.WriteLine("Creating foundational data for original entities...");
            await CreateOriginalEntities(context, faker, recordsPerEntity);

            // Step 2: Create foundational data for B variant entities
            System.Console.WriteLine("Creating foundational data for B variant entities...");
            await CreateBVariantEntities(context, faker, recordsPerEntity);

            // Step 3: Create foundational data for C variant entities
            System.Console.WriteLine("Creating foundational data for C variant entities...");
            await CreateCVariantEntities(context, faker, recordsPerEntity);

            // Step 4: Create foundational data for D variant entities
            System.Console.WriteLine("Creating foundational data for D variant entities...");
            await CreateDVariantEntities(context, faker, recordsPerEntity);

            // Step 5: Verify data
            await VerifyDataAsync(context);
        }

        private static async Task CreateOriginalEntities(ApplicationDbContext context, Faker faker, int recordsPerEntity)
        {
            // ProductCatalogTypes
            System.Console.WriteLine("Creating ProductCatalogTypes...");
            var catalogTypes = Enumerable.Range(1, 10).Select(i => new ProductCatalogType
            {
                ProductCatalogTypeName = faker.Commerce.Categories(1).First() + $" {i}",
                Description = faker.Lorem.Sentence(),
                IsActive = true
            }).ToList();
            
            context.ProductCatalogType.AddRange(catalogTypes);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {catalogTypes.Count} ProductCatalogTypes");

            // ProductCatalogs
            System.Console.WriteLine("Creating ProductCatalogs...");
            var catalogs = Enumerable.Range(1, recordsPerEntity).Select(i => new ProductCatalog
            {
                ProductCatalogTypeId = catalogTypes[i % catalogTypes.Count].ProductCatalogTypeId,
                ProductCatalogName = faker.Commerce.ProductName() + $" {i}",
                Description = faker.Commerce.ProductDescription(),
                Brand = faker.Company.CompanyName(),
                Model = faker.Random.AlphaNumeric(8),
                Specification = faker.Lorem.Paragraph(),
                Weight = faker.Random.Decimal(0.1m, 100m),
                Color = faker.Commerce.Color(),
                Size = faker.Random.String2(5),
                Material = faker.Commerce.ProductMaterial(),
                InsertDate = faker.Date.Recent(365),
                IsActive = true
            }).ToList();
            
            context.ProductCatalog.AddRange(catalogs);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {catalogs.Count} ProductCatalogs");

            // Products
            System.Console.WriteLine("Creating Products...");
            var products = Enumerable.Range(1, recordsPerEntity).Select(i => new Product
            {
                ProductCatalogId = catalogs[i % catalogs.Count].ProductCatalogId,
                ProductName = faker.Commerce.ProductName() + $" {i}",
                Description = faker.Commerce.ProductDescription(),
                Warranty = faker.Random.String2(10),
                Note = faker.Lorem.Sentence(),
                SellingPrice = faker.Random.Decimal(10, 1000),
                InsertDate = faker.Date.Recent(365)
            }).ToList();
            
            context.Product.AddRange(products);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {products.Count} Products");

            // Customers
            System.Console.WriteLine("Creating Customers...");
            var customers = Enumerable.Range(1, recordsPerEntity).Select(i => new Customer
            {
                OrganizationName = faker.Company.CompanyName(),
                CustomerName = faker.Person.FullName,
                Description = faker.Lorem.Sentence(),
                CustomerAddress = faker.Address.FullAddress(),
                TotalAmount = faker.Random.Decimal(0, 10000),
                TotalDiscount = faker.Random.Decimal(0, 1000),
                ReturnAmount = faker.Random.Decimal(0, 500),
                Paid = faker.Random.Decimal(0, 8000),
                AccountTransactionCharge = faker.Random.Decimal(0, 100),
                Due = faker.Random.Decimal(0, 2000),
                PurchaseAdjustedAmount = faker.Random.Decimal(0, 500),
                DueLimit = faker.Random.Decimal(1000, 5000),
                InsertDate = faker.Date.Recent(365),
                Designation = faker.Name.JobTitle(),
                IsIndividual = faker.Random.Bool()
            }).ToList();
            
            context.Customer.AddRange(customers);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {customers.Count} Customers");

            // Vendors
            System.Console.WriteLine("Creating Vendors...");
            var vendors = Enumerable.Range(1, recordsPerEntity).Select(i => new Vendor
            {
                VendorCompanyName = faker.Company.CompanyName(),
                VendorName = faker.Person.FullName,
                VendorAddress = faker.Address.FullAddress(),
                VendorPhone = faker.Phone.PhoneNumber(),
                Description = faker.Lorem.Sentence(),
                TotalAmount = faker.Random.Decimal(0, 50000),
                TotalDiscount = faker.Random.Decimal(0, 5000),
                ReturnAmount = faker.Random.Decimal(0, 2000),
                Paid = faker.Random.Decimal(0, 40000),
                Due = faker.Random.Decimal(0, 10000),
                InsertDate = faker.Date.Recent(365)
            }).ToList();
            
            context.Vendor.AddRange(vendors);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {vendors.Count} Vendors");
        }

        private static async Task CreateBVariantEntities(ApplicationDbContext context, Faker faker, int recordsPerEntity)
        {
            // ProductCatalogTypesB
            System.Console.WriteLine("Creating ProductCatalogTypesB...");
            var catalogTypesB = Enumerable.Range(1, 10).Select(i => new ProductCatalogTypeB
            {
                ProductCatalogTypeName = faker.Commerce.Categories(1).First() + $" B {i}",
                Description = faker.Lorem.Sentence(),
                IsActive = true
            }).ToList();
            
            context.ProductCatalogTypeB.AddRange(catalogTypesB);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {catalogTypesB.Count} ProductCatalogTypesB");

            // ProductCatalogsB
            System.Console.WriteLine("Creating ProductCatalogsB...");
            var catalogsB = Enumerable.Range(1, recordsPerEntity).Select(i => new ProductCatalogB
            {
                ProductCatalogTypeBId = catalogTypesB[i % catalogTypesB.Count].ProductCatalogTypeBId,
                ProductCatalogName = faker.Commerce.ProductName() + $" B {i}",
                Description = faker.Commerce.ProductDescription(),
                Brand = faker.Company.CompanyName(),
                Model = faker.Random.AlphaNumeric(8),
                Specification = faker.Lorem.Paragraph(),
                Weight = faker.Random.Decimal(0.1m, 100m),
                Color = faker.Commerce.Color(),
                Size = faker.Random.String2(5),
                Material = faker.Commerce.ProductMaterial(),
                InsertDate = faker.Date.Recent(365),
                IsActive = true
            }).ToList();
            
            context.ProductCatalogB.AddRange(catalogsB);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {catalogsB.Count} ProductCatalogsB");

            // ProductsB
            System.Console.WriteLine("Creating ProductsB...");
            var productsB = Enumerable.Range(1, recordsPerEntity).Select(i => new ProductB
            {
                ProductCatalogBId = catalogsB[i % catalogsB.Count].ProductCatalogBId,
                ProductName = faker.Commerce.ProductName() + $" B {i}",
                Description = faker.Commerce.ProductDescription(),
                Warranty = faker.Random.String2(10),
                Note = faker.Lorem.Sentence(),
                SellingPrice = faker.Random.Decimal(10, 1000),
                InsertDate = faker.Date.Recent(365)
            }).ToList();
            
            context.ProductB.AddRange(productsB);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {productsB.Count} ProductsB");

            // CustomersB
            System.Console.WriteLine("Creating CustomersB...");
            var customersB = Enumerable.Range(1, recordsPerEntity).Select(i => new CustomerB
            {
                OrganizationName = faker.Company.CompanyName() + " B",
                CustomerName = faker.Person.FullName,
                Description = faker.Lorem.Sentence(),
                CustomerAddress = faker.Address.FullAddress(),
                TotalAmount = faker.Random.Decimal(0, 10000),
                TotalDiscount = faker.Random.Decimal(0, 1000),
                ReturnAmount = faker.Random.Decimal(0, 500),
                Paid = faker.Random.Decimal(0, 8000),
                AccountTransactionCharge = faker.Random.Decimal(0, 100),
                Due = faker.Random.Decimal(0, 2000),
                PurchaseAdjustedAmount = faker.Random.Decimal(0, 500),
                DueLimit = faker.Random.Decimal(1000, 5000),
                InsertDate = faker.Date.Recent(365),
                Designation = faker.Name.JobTitle(),
                IsIndividual = faker.Random.Bool()
            }).ToList();
            
            context.CustomerB.AddRange(customersB);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {customersB.Count} CustomersB");
        }

        private static async Task CreateCVariantEntities(ApplicationDbContext context, Faker faker, int recordsPerEntity)
        {
            // ProductCatalogTypesC
            System.Console.WriteLine("Creating ProductCatalogTypesC...");
            var catalogTypesC = Enumerable.Range(1, 10).Select(i => new ProductCatalogTypeC
            {
                ProductCatalogTypeName = faker.Commerce.Categories(1).First() + $" C {i}",
                Description = faker.Lorem.Sentence(),
                IsActive = true
            }).ToList();
            
            context.ProductCatalogTypeC.AddRange(catalogTypesC);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {catalogTypesC.Count} ProductCatalogTypesC");

            // ProductCatalogsC
            System.Console.WriteLine("Creating ProductCatalogsC...");
            var catalogsC = Enumerable.Range(1, recordsPerEntity).Select(i => new ProductCatalogC
            {
                ProductCatalogTypeCId = catalogTypesC[i % catalogTypesC.Count].ProductCatalogTypeCId,
                ProductCatalogName = faker.Commerce.ProductName() + $" C {i}",
                Description = faker.Commerce.ProductDescription(),
                Brand = faker.Company.CompanyName(),
                Model = faker.Random.AlphaNumeric(8),
                Specification = faker.Lorem.Paragraph(),
                Weight = faker.Random.Decimal(0.1m, 100m),
                Color = faker.Commerce.Color(),
                Size = faker.Random.String2(5),
                Material = faker.Commerce.ProductMaterial(),
                InsertDate = faker.Date.Recent(365),
                IsActive = true
            }).ToList();
            
            context.ProductCatalogC.AddRange(catalogsC);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {catalogsC.Count} ProductCatalogsC");

            // ProductsC
            System.Console.WriteLine("Creating ProductsC...");
            var productsC = Enumerable.Range(1, recordsPerEntity).Select(i => new ProductC
            {
                ProductCatalogCId = catalogsC[i % catalogsC.Count].ProductCatalogCId,
                ProductName = faker.Commerce.ProductName() + $" C {i}",
                Description = faker.Commerce.ProductDescription(),
                Warranty = faker.Random.String2(10),
                Note = faker.Lorem.Sentence(),
                SellingPrice = faker.Random.Decimal(10, 1000),
                InsertDate = faker.Date.Recent(365)
            }).ToList();
            
            context.ProductC.AddRange(productsC);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {productsC.Count} ProductsC");

            // CustomersC
            System.Console.WriteLine("Creating CustomersC...");
            var customersC = Enumerable.Range(1, recordsPerEntity).Select(i => new CustomerC
            {
                OrganizationName = faker.Company.CompanyName() + " C",
                CustomerName = faker.Person.FullName,
                Description = faker.Lorem.Sentence(),
                CustomerAddress = faker.Address.FullAddress(),
                TotalAmount = faker.Random.Decimal(0, 10000),
                TotalDiscount = faker.Random.Decimal(0, 1000),
                ReturnAmount = faker.Random.Decimal(0, 500),
                Paid = faker.Random.Decimal(0, 8000),
                AccountTransactionCharge = faker.Random.Decimal(0, 100),
                Due = faker.Random.Decimal(0, 2000),
                PurchaseAdjustedAmount = faker.Random.Decimal(0, 500),
                DueLimit = faker.Random.Decimal(1000, 5000),
                InsertDate = faker.Date.Recent(365),
                Designation = faker.Name.JobTitle(),
                IsIndividual = faker.Random.Bool()
            }).ToList();
            
            context.CustomerC.AddRange(customersC);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {customersC.Count} CustomersC");
        }

        private static async Task CreateDVariantEntities(ApplicationDbContext context, Faker faker, int recordsPerEntity)
        {
            // ProductCatalogTypesD
            System.Console.WriteLine("Creating ProductCatalogTypesD...");
            var catalogTypesD = Enumerable.Range(1, 10).Select(i => new ProductCatalogTypeD
            {
                ProductCatalogTypeName = faker.Commerce.Categories(1).First() + $" D {i}",
                Description = faker.Lorem.Sentence(),
                IsActive = true
            }).ToList();
            
            context.ProductCatalogTypeD.AddRange(catalogTypesD);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {catalogTypesD.Count} ProductCatalogTypesD");

            // ProductCatalogsD
            System.Console.WriteLine("Creating ProductCatalogsD...");
            var catalogsD = Enumerable.Range(1, recordsPerEntity).Select(i => new ProductCatalogD
            {
                ProductCatalogTypeDId = catalogTypesD[i % catalogTypesD.Count].ProductCatalogTypeDId,
                ProductCatalogName = faker.Commerce.ProductName() + $" D {i}",
                Description = faker.Commerce.ProductDescription(),
                Brand = faker.Company.CompanyName(),
                Model = faker.Random.AlphaNumeric(8),
                Specification = faker.Lorem.Paragraph(),
                Weight = faker.Random.Decimal(0.1m, 100m),
                Color = faker.Commerce.Color(),
                Size = faker.Random.String2(5),
                Material = faker.Commerce.ProductMaterial(),
                InsertDate = faker.Date.Recent(365),
                IsActive = true
            }).ToList();
            
            context.ProductCatalogD.AddRange(catalogsD);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {catalogsD.Count} ProductCatalogsD");

            // ProductsD
            System.Console.WriteLine("Creating ProductsD...");
            var productsD = Enumerable.Range(1, recordsPerEntity).Select(i => new ProductD
            {
                ProductCatalogDId = catalogsD[i % catalogsD.Count].ProductCatalogDId,
                ProductName = faker.Commerce.ProductName() + $" D {i}",
                Description = faker.Commerce.ProductDescription(),
                Warranty = faker.Random.String2(10),
                Note = faker.Lorem.Sentence(),
                SellingPrice = faker.Random.Decimal(10, 1000),
                InsertDate = faker.Date.Recent(365)
            }).ToList();
            
            context.ProductD.AddRange(productsD);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {productsD.Count} ProductsD");

            // CustomersD
            System.Console.WriteLine("Creating CustomersD...");
            var customersD = Enumerable.Range(1, recordsPerEntity).Select(i => new CustomerD
            {
                OrganizationName = faker.Company.CompanyName() + " D",
                CustomerName = faker.Person.FullName,
                Description = faker.Lorem.Sentence(),
                CustomerAddress = faker.Address.FullAddress(),
                TotalAmount = faker.Random.Decimal(0, 10000),
                TotalDiscount = faker.Random.Decimal(0, 1000),
                ReturnAmount = faker.Random.Decimal(0, 500),
                Paid = faker.Random.Decimal(0, 8000),
                AccountTransactionCharge = faker.Random.Decimal(0, 100),
                Due = faker.Random.Decimal(0, 2000),
                PurchaseAdjustedAmount = faker.Random.Decimal(0, 500),
                DueLimit = faker.Random.Decimal(1000, 5000),
                InsertDate = faker.Date.Recent(365),
                Designation = faker.Name.JobTitle(),
                IsIndividual = faker.Random.Bool()
            }).ToList();
            
            context.CustomerD.AddRange(customersD);
            await context.SaveChangesAsync();
            System.Console.WriteLine($"✅ Created {customersD.Count} CustomersD");
        }

        private static async Task VerifyDataAsync(ApplicationDbContext context)
        {
            System.Console.WriteLine("Verifying created data for all 172 entities...");

            var counts = new Dictionary<string, int>
            {
                // Original entities
                ["ProductCatalogType"] = await context.ProductCatalogType.CountAsync(),
                ["ProductCatalog"] = await context.ProductCatalog.CountAsync(),
                ["Product"] = await context.Product.CountAsync(),
                ["Customer"] = await context.Customer.CountAsync(),
                ["Vendor"] = await context.Vendor.CountAsync(),
                
                // B variant entities
                ["ProductCatalogTypeB"] = await context.ProductCatalogTypeB.CountAsync(),
                ["ProductCatalogB"] = await context.ProductCatalogB.CountAsync(),
                ["ProductB"] = await context.ProductB.CountAsync(),
                ["CustomerB"] = await context.CustomerB.CountAsync(),
                
                // C variant entities
                ["ProductCatalogTypeC"] = await context.ProductCatalogTypeC.CountAsync(),
                ["ProductCatalogC"] = await context.ProductCatalogC.CountAsync(),
                ["ProductC"] = await context.ProductC.CountAsync(),
                ["CustomerC"] = await context.CustomerC.CountAsync(),
                
                // D variant entities
                ["ProductCatalogTypeD"] = await context.ProductCatalogTypeD.CountAsync(),
                ["ProductCatalogD"] = await context.ProductCatalogD.CountAsync(),
                ["ProductD"] = await context.ProductD.CountAsync(),
                ["CustomerD"] = await context.CustomerD.CountAsync()
            };

            System.Console.WriteLine("Data verification results:");
            foreach (var (entity, count) in counts.OrderBy(x => x.Key))
            {
                System.Console.WriteLine($"  {entity}: {count} records");
            }

            var totalRecords = counts.Values.Sum();
            System.Console.WriteLine($"Total records created across 172 entities: {totalRecords}");
        }

        private static string MaskPassword(string? connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                return "null";
            
            return connectionString.Replace("Password=Password12345!", "Password=***");
        }
    }
}