using Microsoft.EntityFrameworkCore;
using PIM.Models;
using PIM.Models.Administrator;
using PIM.Models.PersonModel;
using PIM.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Data
{
    public class PIMContext : DbContext
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
        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
    }
}
