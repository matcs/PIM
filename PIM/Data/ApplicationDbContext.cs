using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PIM.Models;
using System;

namespace PIM.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
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
        public DbSet<Country> Countries { get; set; }
        public DbSet<CryptoCurrency> CryptoCurrencies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<IdentityCard> IdentityCards { get; set; }
        public DbSet<PaymentReceipt> PaymentReceipts { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public override DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<WorkRecordBooklet> WorkRecordBooklets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityCard>()
                .HasIndex(index => index.IndividualTaxpayerRegistration)
                .IsUnique();
            
            modelBuilder.Entity<User>
                (entity =>
                {
                    entity
                           .Ignore(c => c.AccessFailedCount)
                           .Ignore(c => c.LockoutEnabled)
                           .Ignore(c => c.PhoneNumber)
                           .Ignore(c => c.SecurityStamp)
                           .Ignore(c => c.TwoFactorEnabled)
                           .ToTable("Users");
                });

            modelBuilder.Entity<User>().HasData(
                        new User
                        {
                            First_Name = "Mike",
                            SocialName = "null",
                            Email = "ezratmp+lath6@gmail.com",
                            Password = "pass",
                            CPF = "65519709076",
                            BirthDay = DateTime.Parse("Nov 1, 1999"),
                            Role = "USER"
                        },
                        new User
                        {
                            First_Name = "Mackenzie",
                            SocialName = "null",
                            Email = "lengtmp+lue5n@gmail.com",
                            Password = "passWORLD",
                            CPF = "82124778005",
                            BirthDay = DateTime.Parse("Jan 6, 1985"),
                            Role = "USER"
                        },
                        new User
                        {
                            First_Name = "Alexia",
                            SocialName = "null",
                            Email = "banetmp+nqzlb@gmail.com",
                            Password = "p4ssw0rld",
                            CPF = "58113438092",
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
                    UserId = 1
                },
                new IdentityCard
                {
                    IdentityCardId = "abc1",
                    IndividualTaxpayerRegistration = "62472128010",
                    Identification = "362932888",
                    IssuingBody = "SSP",
                    ShippingDate = DateTime.Parse("Jan 10, 1995"),
                    UserId = 2
                },
                new IdentityCard
                {
                    IdentityCardId = "abc2",
                    IndividualTaxpayerRegistration = "06810592067",
                    Identification = "362932888",
                    IssuingBody = "SSP",
                    ShippingDate = DateTime.Parse("Oct 2, 2006"),
                    UserId = 3
                });

            modelBuilder.Entity<Telephone>().HasData(
                new Telephone
                {
                    TelephoneId = 1,
                    DDD = "011",
                    TelephoneNumber = "99507-9350",
                    UserId = 1
                },
                new Telephone
                {
                    TelephoneId = 2,
                    DDD = "011",
                    TelephoneNumber = "98732-0893",
                    UserId = 2
                },
                new Telephone
                {
                    TelephoneId = 3,
                    DDD = "011",
                    TelephoneNumber = "99970-7434",
                    UserId = 3
                });

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustumersId = 1,
                    AccountStatus = false,
                    UserId = 1L
                },
                new Customer
                {
                    CustumersId = 2,
                    AccountStatus = true,
                    UserId = 2L
                },
                new Customer
                {
                    CustumersId = 3,
                    AccountStatus = true,
                    UserId = 3L
                });
            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    AddressId = 1,
                    AddrType = "Rua",
                    AddrNumber = "105B",
                    AddrCity = "São Paulo",
                    AddrNeighbohood = "Republica",
                    ZipCode = "01045001",
                    UserId = 1
                },
                new Address
                {
                    AddressId = 2,
                    AddrType = "Avenida",
                    AddrNumber = "125",
                    AddrCity = "São Paulo",
                    AddrNeighbohood = "Pinheiros",
                    ZipCode = "39100000",
                    UserId = 2
                },
                new Address
                {
                    AddressId = 3,
                    AddrType = "Rua",
                    AddrNumber = "463",
                    AddrCity = "Osasco",
                    AddrNeighbohood = "Vila Yara",
                    ZipCode = "06026050",
                    UserId = 3
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

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    CountryName = "Brasil",
                    AddressId = 1
                },
                new Country
                {
                    CountryId = 2,
                    CountryName = "Brasil",
                    AddressId = 2
                },
                new Country
                {
                    CountryId = 3,
                    CountryName = "Brasil",
                    AddressId = 3
                });

        }
    }
}

