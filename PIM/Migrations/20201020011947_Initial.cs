using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PIM.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CryptoCurrencies",
                columns: table => new
                {
                    CryptoCurrencyId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "FLOAT", nullable: false),
                    ValueDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CryptoCurrencies", x => x.CryptoCurrencyId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(type: "VARCHAR(70)", nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(70)", nullable: true),
                    SocialName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(30)", maxLength: 256, nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    Role = table.Column<string>(type: "VARCHAR(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicArea = table.Column<string>(type: "VARCHAR(25)", nullable: false),
                    StreetNumber = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    City = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    Neighborhood = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    ZipCode = table.Column<string>(type: "VARCHAR(25)", nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Administrators",
                columns: table => new
                {
                    AdministratorId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.AdministratorId);
                    table.ForeignKey(
                        name: "FK_Administrators_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustumerId = table.Column<string>(type: "NVARCHAR(40)", nullable: false),
                    AccountStatus = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustumerId);
                    table.ForeignKey(
                        name: "FK_Customers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IdentityCards",
                columns: table => new
                {
                    IdentityCardId = table.Column<string>(type: "NVARCHAR(40)", nullable: false),
                    Identification = table.Column<string>(type: "NVARCHAR(10)", nullable: false),
                    IndividualTaxpayerRegistration = table.Column<string>(type: "NVARCHAR(12)", nullable: false),
                    IssuingBody = table.Column<string>(type: "VARCHAR(5)", nullable: false),
                    ShippingDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityCards", x => x.IdentityCardId);
                    table.ForeignKey(
                        name: "FK_IdentityCards_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Telephones",
                columns: table => new
                {
                    TelephoneId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DDD = table.Column<string>(type: "VARCHAR(5)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(11)", nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telephones", x => x.TelephoneId);
                    table.ForeignKey(
                        name: "FK_Telephones_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "VARCHAR(35)", nullable: false),
                    AddressId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_Countries_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    AddressId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_States_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkRecordBooklets",
                columns: table => new
                {
                    WorkRecordBookletId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "NVARCHAR(10)", nullable: false),
                    Serial = table.Column<string>(type: "NVARCHAR(12)", nullable: false),
                    BirthPlace = table.Column<string>(type: "NVARCHAR(30)", nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    FatherName = table.Column<string>(nullable: false),
                    MotherName = table.Column<string>(nullable: false),
                    ShippingDate = table.Column<DateTime>(nullable: false),
                    AdministratorId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkRecordBooklets", x => x.WorkRecordBookletId);
                    table.ForeignKey(
                        name: "FK_WorkRecordBooklets_Administrators_AdministratorId",
                        column: x => x.AdministratorId,
                        principalTable: "Administrators",
                        principalColumn: "AdministratorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ContractId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractTerms = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: false),
                    CustomerCustumerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ContractId);
                    table.ForeignKey(
                        name: "FK_Contracts_Customers_CustomerCustumerId",
                        column: x => x.CustomerCustumerId,
                        principalTable: "Customers",
                        principalColumn: "CustumerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentReceipts",
                columns: table => new
                {
                    PaymentReceiptsId = table.Column<string>(type: "NVARCHAR(40)", nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(type: "FLOAT", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    CustomerIdCustumerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentReceipts", x => x.PaymentReceiptsId);
                    table.ForeignKey(
                        name: "FK_PaymentReceipts_Customers_CustomerIdCustumerId",
                        column: x => x.CustomerIdCustumerId,
                        principalTable: "Customers",
                        principalColumn: "CustumerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    WalletId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WalletBalance = table.Column<double>(nullable: false),
                    CustomerCustumerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.WalletId);
                    table.ForeignKey(
                        name: "FK_Wallets_Customers_CustomerCustumerId",
                        column: x => x.CustomerCustumerId,
                        principalTable: "Customers",
                        principalColumn: "CustumerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "Neighborhood", "PublicArea", "StreetNumber", "UserId", "ZipCode" },
                values: new object[,]
                {
                    { 1L, "São Paulo", "Republica", "Rua", "105B", null, "01045001" },
                    { 2L, "São Paulo", "Pinheiros", "Avenida", "125", null, "39100000" },
                    { 3L, "Osasco", "Vila Yara", "Rua", "463", null, "06026050" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "AddressId", "CountryName" },
                values: new object[,]
                {
                    { 1L, null, "Brasil" },
                    { 2L, null, "Brasil" },
                    { 3L, null, "Brasil" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustumerId", "AccountStatus", "UserId" },
                values: new object[,]
                {
                    { "1", false, null },
                    { "2", true, null },
                    { "3", true, null }
                });

            migrationBuilder.InsertData(
                table: "IdentityCards",
                columns: new[] { "IdentityCardId", "Identification", "IndividualTaxpayerRegistration", "IssuingBody", "ShippingDate", "UserId" },
                values: new object[,]
                {
                    { "abc2", "362932888", "06810592067", "SSP", new DateTime(2006, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "abc1", "362932888", "62472128010", "SSP", new DateTime(1995, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "abc", "190471001", "53925227008", "SSP", new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "PaymentReceipts",
                columns: new[] { "PaymentReceiptsId", "Amount", "CustomerIdCustumerId", "Description", "TransactionDate" },
                values: new object[] { "1askov", 100.55, null, "Sei Lá", new DateTime(2020, 10, 20, 1, 19, 46, 606, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "StateId", "AddressId", "StateName" },
                values: new object[,]
                {
                    { 1L, null, "São Paulo" },
                    { 2L, null, "São Paulo" },
                    { 3L, null, "São Paulo" }
                });

            migrationBuilder.InsertData(
                table: "Telephones",
                columns: new[] { "TelephoneId", "DDD", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { 1L, "011", "99507-9350", null },
                    { 2L, "011", "98732-0893", null },
                    { 3L, "011", "99970-7434", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDay", "Email", "FirstName", "LastName", "Password", "Role", "SocialName" },
                values: new object[,]
                {
                    { "2922c21c-5325-4856-b270-50b5aa9ab1ea", new DateTime(1999, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ezratmp+lath6@gmail.com", "Mike", "Watzolski", "pass", "USER", "null" },
                    { "672999b3-ca32-4a8d-bafe-189a3e090093", new DateTime(1985, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "lengtmp+lue5n@gmail.com", "Mackenzie", "Kyle", "passWORLD", "USER", "null" },
                    { "e0eb6d51-5f43-42cb-ad91-d6c404d2aaac", new DateTime(2000, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "banetmp+nqzlb@gmail.com", "Alexia", "Joseph", "p4ssw0rld", "USER", "null" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Administrators_UserId",
                table: "Administrators",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CustomerCustumerId",
                table: "Contracts",
                column: "CustomerCustumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_AddressId",
                table: "Countries",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityCards_IndividualTaxpayerRegistration",
                table: "IdentityCards",
                column: "IndividualTaxpayerRegistration",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IdentityCards_UserId",
                table: "IdentityCards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentReceipts_CustomerIdCustumerId",
                table: "PaymentReceipts",
                column: "CustomerIdCustumerId");

            migrationBuilder.CreateIndex(
                name: "IX_States_AddressId",
                table: "States",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Telephones_UserId",
                table: "Telephones",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_CustomerCustumerId",
                table: "Wallets",
                column: "CustomerCustumerId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkRecordBooklets_AdministratorId",
                table: "WorkRecordBooklets",
                column: "AdministratorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CryptoCurrencies");

            migrationBuilder.DropTable(
                name: "IdentityCards");

            migrationBuilder.DropTable(
                name: "PaymentReceipts");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Telephones");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "WorkRecordBooklets");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Administrators");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
