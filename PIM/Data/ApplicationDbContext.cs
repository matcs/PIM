using Microsoft.AspNetCore.Identity;
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

            modelBuilder.Ignore<IdentityRole>();
            modelBuilder.Ignore<IdentityUserToken<string>>();
            modelBuilder.Ignore<IdentityUserRole<string>>();
            modelBuilder.Ignore<IdentityUserLogin<string>>();
            modelBuilder.Ignore<IdentityUserClaim<string>>();
            modelBuilder.Ignore<IdentityRoleClaim<string>>();

            modelBuilder.Entity<IdentityCard>()
                .HasIndex(index => index.IndividualTaxpayerRegistration)
                .IsUnique();

            modelBuilder.Entity<User>
                (entity =>
                {
                    entity
                           .Ignore(c => c.LockoutEnabled)
                           .Ignore(c => c.ConcurrencyStamp)
                           .Ignore(c => c.LockoutEnd)
                           .Ignore(c => c.EmailConfirmed)
                           .Ignore(c => c.TwoFactorEnabled)
                           .Ignore(c => c.AccessFailedCount)
                           .Ignore(c => c.PhoneNumberConfirmed)
                           .Ignore(c => c.NormalizedEmail)
                           .Ignore(c => c.PhoneNumber)
                           .Ignore(c => c.PasswordHash)
                           .Ignore(c => c.UserName)
                           .Ignore(c => c.SecurityStamp)
                           .Ignore(c => c.NormalizedUserName)
                           .ToTable("Users");
                });

            modelBuilder.Entity<User>().HasData(
                        new User
                        {
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
            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    AddressId = 1,
                    PublicArea = "Rua",
                    StreetNumber = "105B",
                    City = "São Paulo",
                    Neighborhood = "Republica",
                    ZipCode = "01045001",
                },
                new Address
                {
                    AddressId = 2,
                    PublicArea = "Avenida",
                    StreetNumber = "125",
                    City = "São Paulo",
                    Neighborhood = "Pinheiros",
                    ZipCode = "39100000",
                },
                new Address
                {
                    AddressId = 3,
                    PublicArea = "Rua",
                    StreetNumber = "463",
                    City = "Osasco",
                    Neighborhood = "Vila Yara",
                    ZipCode = "06026050",
                });

            modelBuilder.Entity<State>().HasData(
                new State
                {
                    StateId = 1,
                    StateName = "São Paulo",
                },
                new State
                {
                    StateId = 2,
                    StateName = "São Paulo",
                },
                new State
                {
                    StateId = 3,
                    StateName = "São Paulo",
                });

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    CountryName = "Brasil",
                },
                new Country
                {
                    CountryId = 2,
                    CountryName = "Brasil",
                },
                new Country
                {
                    CountryId = 3,
                    CountryName = "Brasil",
                });

        }
    }
}

