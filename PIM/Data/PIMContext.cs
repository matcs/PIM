using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PIM.Models;
using PIM.Models.Administrator;
using PIM.Models.Person;
using PIM.Models.RG;
using PIM.Models.Telephone;
using PIM.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Data
{
    public class PIMContext : IdentityDbContext<Person>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
               .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PIM_DB;Trusted_Connection=True;",
               providerOptions => providerOptions.CommandTimeout(60));
        }

        public PIMContext(DbContextOptions<PIMContext> options)
            : base(options)
        { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<CarteiraDeTrabalho> CarteiraDeTrabalhos { get; set; }
        public DbSet<Identity> Identities { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        //public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    PersonId = 1,
                    First_Name = "Mike",
                    SocialName = "null",
                    Email = "ezratmp+lath6@gmail.com",
                    Password = "pass",
                    CPF = "65519709076",
                    BirthDay = DateTime.Parse("Nov 1, 1999"),
                    Role = "USER"
                },
                new Person
                {
                    PersonId = 2,
                    First_Name = "Mackenzie",
                    SocialName = "null",
                    Email = "lengtmp+lue5n@gmail.com",
                    Password = "passWORLD",
                    CPF = "82124778005",
                    BirthDay = DateTime.Parse("Jan 6, 1985"),
                    Role = "USER"
                },
                new Person
                {
                    PersonId = 3,
                    First_Name = "Alexia",
                    SocialName = "null",
                    Email = "banetmp+nqzlb@gmail.com",
                    Password = "p4ssw0rld",
                    CPF = "58113438092",
                    BirthDay = DateTime.Parse("Dez 30, 2000"),
                    Role = "USER"
                });

            modelBuilder.Entity<Identity>().HasData(
                new Identity
                {
                    IdentityId = 1,
                    RegistroGeral = "190471001",
                    OrgaoExpedidor = "SSP",
                    DataExpedicao = DateTime.Parse("Dez 15, 2000"),
                    PersonId = 1
                },
                new Identity
                {
                    IdentityId = 2,
                    RegistroGeral = "362932888",
                    OrgaoExpedidor = "SSP",
                    DataExpedicao = DateTime.Parse("Jan 10, 1995"),
                    PersonId = 2
                },
                new Identity
                {
                    IdentityId = 3,
                    RegistroGeral = "362932888",
                    OrgaoExpedidor = "SSP",
                    DataExpedicao = DateTime.Parse("Oct 2, 2006"),
                    PersonId = 3
                });

            modelBuilder.Entity<Telephone>().HasData(
                new Telephone
                {
                    TelephoneId = 1,
                    DDD = "011",
                    TelephoneNumber = "99507-9350",
                    PersonId = 1
                },
                new Telephone
                {
                    TelephoneId = 2,
                    DDD = "011",
                    TelephoneNumber = "98732-0893",
                    PersonId = 2
                },
                new Telephone
                {
                    TelephoneId = 3,
                    DDD = "011",
                    TelephoneNumber = "99970-7434",
                    PersonId = 3
                });

            /*modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    AccountStatus = false,
                    PersonId = 1L
                },
                new User
                {
                    UserId = 2,
                    AccountStatus = true,
                    PersonId = 2L
                },
                new User
                {
                    UserId = 3,
                    AccountStatus = true,
                    PersonId = 3L
                });
            */
            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    AddressId = 1,
                    AddrType = "Rua",
                    AddrNumber = "105B",
                    AddrCity = "São Paulo",
                    AddrNeighbohood = "Republica",
                    ZipCode = "01045001",
                    PersonId = 1
                },
                new Address
                {
                    AddressId = 2,
                    AddrType = "Avenida",
                    AddrNumber = "125",
                    AddrCity = "São Paulo",
                    AddrNeighbohood = "Pinheiros",
                    ZipCode = "39100000",
                    PersonId = 2
                },
                new Address
                {
                    AddressId = 3,
                    AddrType = "Rua",
                    AddrNumber = "463",
                    AddrCity = "Osasco",
                    AddrNeighbohood = "Vila Yara",
                    ZipCode = "06026050",
                    PersonId = 3
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
            base.OnModelCreating(modelBuilder);
        }
    }
}
