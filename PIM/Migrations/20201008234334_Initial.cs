using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PIM.Migrations
{
    public partial class Initial : Migration
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
                    UserId = table.Column<long>(nullable: false)
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
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.AdministratorId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
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
                name: "CryptoCurrencies",
                columns: table => new
                {
                    CryptoCurrencyId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(nullable: false),
                    ValueDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CryptoCurrencies", x => x.CryptoCurrencyId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustumersId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountStatus = table.Column<bool>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustumersId);
                });

            migrationBuilder.CreateTable(
                name: "IdentityCards",
                columns: table => new
                {
                    IdentityCardId = table.Column<string>(type: "NVARCHAR(40)", nullable: false),
                    Identification = table.Column<string>(type: "NVARCHAR(10)", nullable: true),
                    IndividualTaxpayerRegistration = table.Column<string>(type: "NVARCHAR(12)", nullable: true),
                    IssuingBody = table.Column<string>(nullable: true),
                    ShippingDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityCards", x => x.IdentityCardId);
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
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telephones", x => x.TelephoneId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    First_Name = table.Column<string>(type: "VARCHAR(70)", nullable: true),
                    Last_Name = table.Column<string>(type: "VARCHAR(70)", nullable: true),
                    SocialName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(30)", maxLength: 256, nullable: true),
                    Password = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    CPF = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    Role = table.Column<string>(type: "VARCHAR(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    WalletId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WalletBalance = table.Column<double>(nullable: false),
                    CustomersId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.WalletId);
                });

            migrationBuilder.CreateTable(
                name: "WorkRecordBooklets",
                columns: table => new
                {
                    WorkRecordBookletId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "NVARCHAR(10)", nullable: true),
                    Serial = table.Column<string>(type: "NVARCHAR(12)", nullable: true),
                    BirthPlace = table.Column<string>(type: "NVARCHAR(10)", nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    FatherName = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    ShippingDate = table.Column<DateTime>(nullable: false),
                    AdministratorId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkRecordBooklets", x => x.WorkRecordBookletId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentReceipts",
                columns: table => new
                {
                    PaymentReceiptsId = table.Column<string>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CustomerCustumersId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentReceipts", x => x.PaymentReceiptsId);
                    table.ForeignKey(
                        name: "FK_PaymentReceipts_Customers_CustomerCustumersId",
                        column: x => x.CustomerCustumersId,
                        principalTable: "Customers",
                        principalColumn: "CustumersId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "AddrCity", "AddrNeighbohood", "AddrNumber", "AddrType", "UserId", "ZipCode" },
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
                table: "Customers",
                columns: new[] { "CustumersId", "AccountStatus", "UserId" },
                values: new object[,]
                {
                    { 1L, false, 1L },
                    { 2L, true, 2L },
                    { 3L, true, 3L }
                });

            migrationBuilder.InsertData(
                table: "IdentityCards",
                columns: new[] { "IdentityCardId", "Identification", "IndividualTaxpayerRegistration", "IssuingBody", "ShippingDate", "UserId" },
                values: new object[,]
                {
                    { "abc2", "362932888", "06810592067", "SSP", new DateTime(2006, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L },
                    { "abc1", "362932888", "62472128010", "SSP", new DateTime(1995, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L },
                    { "abc", "190471001", "53925227008", "SSP", new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L }
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
                columns: new[] { "TelephoneId", "DDD", "TelephoneNumber", "UserId" },
                values: new object[,]
                {
                    { 1L, "011", "99507-9350", 1L },
                    { 2L, "011", "98732-0893", 2L },
                    { 3L, "011", "99970-7434", 3L }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDay", "CPF", "ConcurrencyStamp", "Email", "EmailConfirmed", "First_Name", "Last_Name", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumberConfirmed", "Role", "SocialName", "UserName" },
                values: new object[,]
                {
                    { "ae6154b5-183b-4177-9cc7-e09cb1a09300", new DateTime(1999, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "65519709076", "25873d55-201a-43f7-98e5-b5868a4fdd7c", "ezratmp+lath6@gmail.com", false, "Mike", null, null, null, null, "pass", null, false, "USER", "null", null },
                    { "fc9f69b8-f2b2-471d-9754-25d29efb57f1", new DateTime(1985, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "82124778005", "f88d6fce-d993-4291-90fd-638c23fc0673", "lengtmp+lue5n@gmail.com", false, "Mackenzie", null, null, null, null, "passWORLD", null, false, "USER", "null", null },
                    { "7b322217-7585-46b5-ab8a-f865ba7039a7", new DateTime(2000, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "58113438092", "d79c5d77-8c0a-4129-838e-7f3a62a95912", "banetmp+nqzlb@gmail.com", false, "Alexia", null, null, null, null, "p4ssw0rld", null, false, "USER", "null", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityCards_IndividualTaxpayerRegistration",
                table: "IdentityCards",
                column: "IndividualTaxpayerRegistration",
                unique: true,
                filter: "[IndividualTaxpayerRegistration] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentReceipts_CustomerCustumersId",
                table: "PaymentReceipts",
                column: "CustomerCustumersId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Administrators");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
