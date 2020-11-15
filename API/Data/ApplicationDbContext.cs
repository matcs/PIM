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
                    UserId = "2922c21c-5325-4856-b270-50b5aa9ab1ea"
                },
                new IdentityCard
                {
                    IdentityCardId = "abc1",
                    IndividualTaxpayerRegistration = "62472128010",
                    Identification = "362932888",
                    IssuingBody = "SSP",
                    ShippingDate = DateTime.Parse("Jan 10, 1995"),
                    UserId = "672999b3-ca32-4a8d-bafe-189a3e090093",
                },
                new IdentityCard
                {
                    IdentityCardId = "abc2",
                    IndividualTaxpayerRegistration = "06810592067",
                    Identification = "362932888",
                    IssuingBody = "SSP",
                    ShippingDate = DateTime.Parse("Oct 2, 2006"),
                    UserId = "e0eb6d51-5f43-42cb-ad91-d6c404d2aaac",
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
                    UserId = "2922c21c-5325-4856-b270-50b5aa9ab1ea",
                    CustomerId = "e0eb6d51-gtdS-36cb-ad91-d6c404d2aaac",
                    TotalOfPayments = 3,
                    AccountStatus = true,

                },
                new Customer
                {
                    UserId = "672999b3-ca32-4a8d-bafe-189a3e090093",
                    CustomerId = "e0456d51-5f43-42cb-ad91-d6c404d2aaac",
                    TotalOfPayments = 2,
                    AccountStatus = true,
                },
                new Customer
                {
                    UserId = "e0eb6d51-5f43-42cb-ad91-d6c404d2aaac",
                    CustomerId = "e0456d51-jdfi-42cb-4658-d6c40sd2aaac",
                    TotalOfPayments = 1,
                    AccountStatus = true,
                });

            modelBuilder.Entity<PaymentReceipt>().HasData(
                new PaymentReceipt
                {
                    PaymentReceiptsId = "esoijf1-5f43-42cb-ad91-d6cdgjiorsjgorc",
                    Amount = 100.55,
                    Description = "Compra feita em : " + DateTime.UtcNow,
                    TransactionDate = DateTime.UtcNow,
                    CustomerId = "e0eb6d51-gtdS-36cb-ad91-d6c404d2aaac"
                },
                new PaymentReceipt
                {
                    PaymentReceiptsId = "esoijf1-5f43-sadf-ad91-d6cdgjiorsjgorc",
                    Amount = 100.55,
                    Description = "Compra feita em : " + DateTime.UtcNow,
                    TransactionDate = DateTime.UtcNow,
                    CustomerId = "e0eb6d51-gtdS-36cb-ad91-d6c404d2aaac"
                },
                new PaymentReceipt
                {
                    PaymentReceiptsId = "esoijf1-fghj-42cb-ad91-d6cdgjiorsjgorc",
                    Amount = 100.55,
                    Description = "Compra feita em : " + DateTime.UtcNow,
                    TransactionDate = DateTime.UtcNow,
                    CustomerId = "e0eb6d51-gtdS-36cb-ad91-d6c404d2aaac"
                },
                //Customer 2
                new PaymentReceipt
                {
                    PaymentReceiptsId = "esoijf1-çpol-42cb-ad91-d6cdgjiorsjgorc",
                    Amount = 100.55,
                    Description = "Compra feita em : " + DateTime.UtcNow,
                    TransactionDate = DateTime.UtcNow,
                    CustomerId = "e0456d51-5f43-42cb-ad91-d6c404d2aaac"
                },
                new PaymentReceipt
                {
                    PaymentReceiptsId = "esoijf1-bgrt-42cb-ad91-d6cdgjiorsjgorc",
                    Amount = 100.55,
                    Description = "Compra feita em : " + DateTime.UtcNow,
                    TransactionDate = DateTime.UtcNow,
                    CustomerId = "e0456d51-5f43-42cb-ad91-d6c404d2aaac"
                },
                //Customer 3
                new PaymentReceipt
                {
                    PaymentReceiptsId = "esoijf1-mjy-42cb-ad91-d6cdgjiorsjgorc",
                    Amount = 100.55,
                    Description = "Compra feita em : " + DateTime.UtcNow,
                    TransactionDate = DateTime.UtcNow,
                    CustomerId = "e0456d51-jdfi-42cb-4658-d6c40sd2aaac"
                }
                );

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
                    UserId = "672999b3-ca32-4a8d-bafe-189a3e090093"
                },
                new Address
                {
                    AddressId = 3,
                    PublicArea = "Rua Pinheiros",
                    StreetNumber = "463",
                    City = "Osasco",
                    Neighborhood = "Vila Yara",
                    ZipCode = "06026050",
                    UserId = "e0eb6d51-5f43-42cb-ad91-d6c404d2aaac"
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

