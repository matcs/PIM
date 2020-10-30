using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using API.Models;
using System;

namespace API.Data
{
    public class ApplicationDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
               .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PIM_DB;Trusted_Connection=True;",
               providerOptions => providerOptions.CommandTimeout(60));
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<CryptoCurrency> CryptoCurrencies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<IdentityCard> IdentityCards { get; set; }
        public DbSet<PaymentReceipt> PaymentReceipts { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<WorkRecordBooklet> WorkRecordBooklets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Ignore<IdentityRole>();
            modelBuilder.Ignore<IdentityUserToken<string>>();
            modelBuilder.Ignore<IdentityUserRole<string>>();
            modelBuilder.Ignore<IdentityUserLogin<string>>();
            modelBuilder.Ignore<IdentityUserClaim<string>>();
            modelBuilder.Ignore<IdentityRoleClaim<string>>();

            modelBuilder.Entity<IdentityCard>()
                .HasIndex(index => index.IndividualTaxpayerRegistration)
                .IsUnique();

            modelBuilder.Entity<User>().HasData(
                        new User
                        {
                            Id = "2922c21c-5325-4856-b270-50b5aa9ab1ea",
                            FirstName = "Mike",
                            LastName = "Watzolski",
                            SocialName = "null",
                            Email = "ezratmp+lath6@gmail.com",
                            Password = "pass",
                            BirthDay = DateTime.Parse("Nov 1, 1999"),
                            Role = "USER"
                        },
                        new User
                        {
                            Id = "672999b3-ca32-4a8d-bafe-189a3e090093",
                            FirstName = "Mackenzie",
                            LastName = "Kyle",
                            SocialName = "null",
                            Email = "lengtmp+lue5n@gmail.com",
                            Password = "passWORLD",
                            BirthDay = DateTime.Parse("Jan 6, 1985"),
                            Role = "USER"
                        },
                        new User
                        {
                            Id = "e0eb6d51-5f43-42cb-ad91-d6c404d2aaac",
                            FirstName = "Alexia",
                            LastName = "Joseph",
                            SocialName = "null",
                            Email = "banetmp+nqzlb@gmail.com",
                            Password = "p4ssw0rld",
                            BirthDay = DateTime.Parse("Dez 30, 2000"),
                            Role = "USER"
                        });


            modelBuilder.Entity<IdentityCard>()
                .HasData(
                new IdentityCard
                {
                    IdentityCardId = "abc",
                    IndividualTaxpayerRegistration = "53925227008",
                    Identification = "190471001",
                    IssuingBody = "SSP",
                    ShippingDate = DateTime.Parse("Dez 15, 2000"),
                },
                new IdentityCard
                {
                    IdentityCardId = "abc1",
                    IndividualTaxpayerRegistration = "62472128010",
                    Identification = "362932888",
                    IssuingBody = "SSP",
                    ShippingDate = DateTime.Parse("Jan 10, 1995"),
                },
                new IdentityCard
                {
                    IdentityCardId = "abc2",
                    IndividualTaxpayerRegistration = "06810592067",
                    Identification = "362932888",
                    IssuingBody = "SSP",
                    ShippingDate = DateTime.Parse("Oct 2, 2006"),
                });

            modelBuilder.Entity<Telephone>().HasData(
                new Telephone
                {
                    TelephoneId = 1,
                    DDD = "011",
                    PhoneNumber = "99507-9350",
                },
                new Telephone
                {
                    TelephoneId = 2,
                    DDD = "011",
                    PhoneNumber = "98732-0893",
                },
                new Telephone
                {
                    TelephoneId = 3,
                    DDD = "011",
                    PhoneNumber = "99970-7434",
                });

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustumerId = 1.ToString(),
                    AccountStatus = false,

                },
                new Customer
                {
                    CustumerId = 2.ToString(),
                    AccountStatus = true,
                },
                new Customer
                {
                    CustumerId = 3.ToString(),
                    AccountStatus = true,
                });
            modelBuilder.Entity<PaymentReceipt>().HasData(
                new PaymentReceipt
                {
                    PaymentReceiptsId = "1askov",
                    Amount = 100.55,
                    Description = "Sei Lá",
                    TransactionDate = DateTime.UtcNow,
                });
            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    AddressId = 1,
                    PublicArea = "Rua His",
                    StreetNumber = "105B",
                    City = "São Paulo",
                    Neighborhood = "Republica",
                    ZipCode = "01045001",
                    UserId = "2922c21c-5325-4856-b270-50b5aa9ab1ea"
                },
                new Address
                {
                    AddressId = 2,
                    PublicArea = "Avenida Dotovisk",
                    StreetNumber = "125",
                    City = "São Paulo",
                    Neighborhood = "Pinheiros",
                    ZipCode = "39100000",
                    UserId = "2922c21c-5325-4856-b270-50b5aa9ab1ea"
                },
                new Address
                {
                    AddressId = 3,
                    PublicArea = "Rua Pinheiros",
                    StreetNumber = "463",
                    City = "Osasco",
                    Neighborhood = "Vila Yara",
                    ZipCode = "06026050",
                    UserId = "2922c21c-5325-4856-b270-50b5aa9ab1ea"
                });

            modelBuilder.Entity<State>().HasData(
                new State
                {
                    StateId = 1,
                    StateName = "São Paulo",
                    AddressId = 1
                },
                new State
                {
                    StateId = 2,
                    StateName = "São Paulo",
                    AddressId = 2
                },
                new State
                {
                    StateId = 3,
                    StateName = "São Paulo",
                    AddressId = 3
                });

        }
    }
}

