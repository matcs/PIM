﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PIM.Data;

namespace API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201029025713_InitialCreated")]
    partial class InitialCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PIM.Models.Address", b =>
                {
                    b.Property<long>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("PublicArea")
                        .IsRequired()
                        .HasColumnType("VARCHAR(25)");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("VARCHAR(25)");

                    b.HasKey("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            AddressId = 1L,
                            City = "São Paulo",
                            Neighborhood = "Republica",
                            PublicArea = "Rua His",
                            StreetNumber = "105B",
                            UserId = "2922c21c-5325-4856-b270-50b5aa9ab1ea",
                            ZipCode = "01045001"
                        },
                        new
                        {
                            AddressId = 2L,
                            City = "São Paulo",
                            Neighborhood = "Pinheiros",
                            PublicArea = "Avenida Dotovisk",
                            StreetNumber = "125",
                            UserId = "2922c21c-5325-4856-b270-50b5aa9ab1ea",
                            ZipCode = "39100000"
                        },
                        new
                        {
                            AddressId = 3L,
                            City = "Osasco",
                            Neighborhood = "Vila Yara",
                            PublicArea = "Rua Pinheiros",
                            StreetNumber = "463",
                            UserId = "2922c21c-5325-4856-b270-50b5aa9ab1ea",
                            ZipCode = "06026050"
                        });
                });

            modelBuilder.Entity("PIM.Models.Administrator", b =>
                {
                    b.Property<long>("AdministratorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR(40)");

                    b.HasKey("AdministratorId");

                    b.HasIndex("UserId");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("PIM.Models.Contract", b =>
                {
                    b.Property<long>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("ContractTerms")
                        .IsRequired()
                        .HasColumnType("VARBINARY(MAX)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("NVARCHAR(40)");

                    b.HasKey("ContractId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("PIM.Models.CryptoCurrency", b =>
                {
                    b.Property<long>("CryptoCurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Value")
                        .HasColumnType("FLOAT");

                    b.Property<DateTime>("ValueDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CryptoCurrencyId");

                    b.ToTable("CryptoCurrencies");
                });

            modelBuilder.Entity("PIM.Models.Customer", b =>
                {
                    b.Property<string>("CustumerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<bool>("AccountStatus")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR(40)");

                    b.HasKey("CustumerId");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustumerId = "1",
                            AccountStatus = false
                        },
                        new
                        {
                            CustumerId = "2",
                            AccountStatus = true
                        },
                        new
                        {
                            CustumerId = "3",
                            AccountStatus = true
                        });
                });

            modelBuilder.Entity("PIM.Models.IdentityCard", b =>
                {
                    b.Property<string>("IdentityCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<string>("IndividualTaxpayerRegistration")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(12)");

                    b.Property<string>("IssuingBody")
                        .IsRequired()
                        .HasColumnType("VARCHAR(5)");

                    b.Property<DateTime>("ShippingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR(40)");

                    b.HasKey("IdentityCardId");

                    b.HasIndex("IndividualTaxpayerRegistration")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("IdentityCards");

                    b.HasData(
                        new
                        {
                            IdentityCardId = "abc",
                            Identification = "190471001",
                            IndividualTaxpayerRegistration = "53925227008",
                            IssuingBody = "SSP",
                            ShippingDate = new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdentityCardId = "abc1",
                            Identification = "362932888",
                            IndividualTaxpayerRegistration = "62472128010",
                            IssuingBody = "SSP",
                            ShippingDate = new DateTime(1995, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdentityCardId = "abc2",
                            Identification = "362932888",
                            IndividualTaxpayerRegistration = "06810592067",
                            IssuingBody = "SSP",
                            ShippingDate = new DateTime(2006, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("PIM.Models.PaymentReceipt", b =>
                {
                    b.Property<string>("PaymentReceiptsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<double>("Amount")
                        .HasColumnType("FLOAT");

                    b.Property<string>("CustomerId")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PaymentReceiptsId");

                    b.HasIndex("CustomerId");

                    b.ToTable("PaymentReceipts");

                    b.HasData(
                        new
                        {
                            PaymentReceiptsId = "1askov",
                            Amount = 100.55,
                            Description = "Sei Lá",
                            TransactionDate = new DateTime(2020, 10, 29, 2, 57, 12, 645, DateTimeKind.Utc).AddTicks(8413)
                        });
                });

            modelBuilder.Entity("PIM.Models.State", b =>
                {
                    b.Property<long>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.HasKey("StateId");

                    b.HasIndex("AddressId");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            StateId = 1L,
                            AddressId = 1L,
                            StateName = "São Paulo"
                        },
                        new
                        {
                            StateId = 2L,
                            AddressId = 2L,
                            StateName = "São Paulo"
                        },
                        new
                        {
                            StateId = 3L,
                            AddressId = 3L,
                            StateName = "São Paulo"
                        });
                });

            modelBuilder.Entity("PIM.Models.Telephone", b =>
                {
                    b.Property<long>("TelephoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasColumnType("VARCHAR(5)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("VARCHAR(11)");

                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR(40)");

                    b.HasKey("TelephoneId");

                    b.HasIndex("UserId");

                    b.ToTable("Telephones");

                    b.HasData(
                        new
                        {
                            TelephoneId = 1L,
                            DDD = "011",
                            PhoneNumber = "99507-9350"
                        },
                        new
                        {
                            TelephoneId = 2L,
                            DDD = "011",
                            PhoneNumber = "98732-0893"
                        },
                        new
                        {
                            TelephoneId = 3L,
                            DDD = "011",
                            PhoneNumber = "99970-7434"
                        });
                });

            modelBuilder.Entity("PIM.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("FirstName")
                        .HasColumnType("VARCHAR(70)");

                    b.Property<string>("LastName")
                        .HasColumnType("VARCHAR(70)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Role")
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("SocialName")
                        .HasColumnType("VARCHAR(25)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "2922c21c-5325-4856-b270-50b5aa9ab1ea",
                            BirthDay = new DateTime(1999, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ezratmp+lath6@gmail.com",
                            FirstName = "Mike",
                            LastName = "Watzolski",
                            Password = "pass",
                            Role = "USER",
                            SocialName = "null"
                        },
                        new
                        {
                            Id = "672999b3-ca32-4a8d-bafe-189a3e090093",
                            BirthDay = new DateTime(1985, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lengtmp+lue5n@gmail.com",
                            FirstName = "Mackenzie",
                            LastName = "Kyle",
                            Password = "passWORLD",
                            Role = "USER",
                            SocialName = "null"
                        },
                        new
                        {
                            Id = "e0eb6d51-5f43-42cb-ad91-d6c404d2aaac",
                            BirthDay = new DateTime(2000, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "banetmp+nqzlb@gmail.com",
                            FirstName = "Alexia",
                            LastName = "Joseph",
                            Password = "p4ssw0rld",
                            Role = "USER",
                            SocialName = "null"
                        });
                });

            modelBuilder.Entity("PIM.Models.Wallet", b =>
                {
                    b.Property<long>("WalletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<double>("WalletBalance")
                        .HasColumnType("float");

                    b.HasKey("WalletId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("PIM.Models.WorkRecordBooklet", b =>
                {
                    b.Property<long>("WorkRecordBookletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AdministratorId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BirthPlace")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(30)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<string>("Serial")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(12)");

                    b.Property<DateTime>("ShippingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("WorkRecordBookletId");

                    b.HasIndex("AdministratorId");

                    b.ToTable("WorkRecordBooklets");
                });

            modelBuilder.Entity("PIM.Models.Address", b =>
                {
                    b.HasOne("PIM.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PIM.Models.Administrator", b =>
                {
                    b.HasOne("PIM.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PIM.Models.Contract", b =>
                {
                    b.HasOne("PIM.Models.Customer", "Customer")
                        .WithMany("Contracts")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("PIM.Models.Customer", b =>
                {
                    b.HasOne("PIM.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PIM.Models.IdentityCard", b =>
                {
                    b.HasOne("PIM.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PIM.Models.PaymentReceipt", b =>
                {
                    b.HasOne("PIM.Models.Customer", "Customer")
                        .WithMany("PaymentReceipts")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("PIM.Models.State", b =>
                {
                    b.HasOne("PIM.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PIM.Models.Telephone", b =>
                {
                    b.HasOne("PIM.Models.User", "User")
                        .WithMany("Telephones")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PIM.Models.Wallet", b =>
                {
                    b.HasOne("PIM.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("PIM.Models.WorkRecordBooklet", b =>
                {
                    b.HasOne("PIM.Models.Administrator", "Administrator")
                        .WithMany()
                        .HasForeignKey("AdministratorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
