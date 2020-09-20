using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PIM.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddrType = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    AddrNumber = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    AddrCity = table.Column<string>(type: "VARCHAR(40)", nullable: true),
                    AddrNeighbohood = table.Column<string>(type: "VARCHAR(40)", nullable: true),
                    ZipCode = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    PersonId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Administrators",
                columns: table => new
                {
                    AdministratorId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.AdministratorId);
                });

            migrationBuilder.CreateTable(
                name: "CarteiraDeTrabalhos",
                columns: table => new
                {
                    CarteiraDeTrabalhoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdministratorId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarteiraDeTrabalhos", x => x.CarteiraDeTrabalhoId);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ContractId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractTerms = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ContractId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "VARCHAR(35)", nullable: true),
                    AddressId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Identities",
                columns: table => new
                {
                    IdentityId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistroGeral = table.Column<string>(type: "CHAR(10)", nullable: true),
                    OrgaoExpedidor = table.Column<string>(type: "VARCHAR(7)", nullable: true),
                    DataExpedicao = table.Column<DateTime>(nullable: false),
                    PersonId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identities", x => x.IdentityId);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "VARCHAR(70)", nullable: true),
                    SocialName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    Password = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    CPF = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    Role = table.Column<string>(type: "VARCHAR(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    AddressId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "Telephones",
                columns: table => new
                {
                    TelephoneId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DDD = table.Column<string>(type: "VARCHAR(5)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "VARCHAR(11)", nullable: true),
                    PersonId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telephones", x => x.TelephoneId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountStatus = table.Column<bool>(nullable: false),
                    PersonId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    WalletId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WalletBalance = table.Column<double>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.WalletId);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "AddrCity", "AddrNeighbohood", "AddrNumber", "AddrType", "PersonId", "ZipCode" },
                values: new object[,]
                {
                    { 1L, "São Paulo", "Republica", "105B", "Rua", 1L, "01045001" },
                    { 2L, "São Paulo", "Pinheiros", "125", "Avenida", 2L, "39100000" },
                    { 3L, "Osasco", "Vila Yara", "463", "Rua", 3L, "06026050" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "AddressId", "CountryName" },
                values: new object[,]
                {
                    { 1L, 1L, "Brasil" },
                    { 2L, 2L, "Brasil" },
                    { 3L, 3L, "Brasil" }
                });

            migrationBuilder.InsertData(
                table: "Identities",
                columns: new[] { "IdentityId", "DataExpedicao", "OrgaoExpedidor", "PersonId", "RegistroGeral" },
                values: new object[,]
                {
                    { 1L, new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "SSP", 1L, "190471001" },
                    { 2L, new DateTime(1995, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "SSP", 2L, "362932888" },
                    { 3L, new DateTime(2006, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "SSP", 3L, "362932888" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "BirthDay", "CPF", "Email", "Password", "PersonName", "Role", "SocialName" },
                values: new object[,]
                {
                    { 3L, new DateTime(2000, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "58113438092", "banetmp+nqzlb@gmail.com", "p4ssw0rld", "Alexia Calvert", "USER", "null" },
                    { 2L, new DateTime(1985, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "82124778005", "lengtmp+lue5n@gmail.com", "passWORLD", "Mackenzie Mathis", "USER", "null" },
                    { 1L, new DateTime(1999, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "65519709076", "ezratmp+lath6@gmail.com", "pass", "Mike Wazowski", "USER", "null" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "StateId", "AddressId", "StateName" },
                values: new object[,]
                {
                    { 1L, 1L, "São Paulo" },
                    { 2L, 2L, "São Paulo" },
                    { 3L, 3L, "São Paulo" }
                });

            migrationBuilder.InsertData(
                table: "Telephones",
                columns: new[] { "TelephoneId", "DDD", "PersonId", "TelephoneNumber" },
                values: new object[,]
                {
                    { 1L, "011", 1L, "99507-9350" },
                    { 2L, "011", 2L, "98732-0893" },
                    { 3L, "011", 3L, "99970-7434" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AccountStatus", "PersonId" },
                values: new object[,]
                {
                    { 1L, false, 1L },
                    { 2L, true, 2L },
                    { 3L, true, 3L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Administrators");

            migrationBuilder.DropTable(
                name: "CarteiraDeTrabalhos");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Identities");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Telephones");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Wallets");
        }
    }
}
