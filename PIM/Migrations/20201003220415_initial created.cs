using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PIM.Migrations
{
    public partial class initialcreated : Migration
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    PersonId = table.Column<long>(nullable: false),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
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
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDay", "CPF", "ConcurrencyStamp", "Email", "EmailConfirmed", "First_Name", "Last_Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "SocialName", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "12ae27c4-2849-483e-9f36-914230bf850f", 0, new DateTime(2000, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "58113438092", "ab10e3ef-e9cb-498d-9db2-690d5c76306c", "banetmp+nqzlb@gmail.com", false, "Alexia", null, false, null, null, null, "p4ssw0rld", null, 3L, null, false, "USER", "8161f49c-6f66-447e-8ada-ec6d899312c3", "null", false, null },
                    { "97c4a192-9425-49a0-8fc7-9cac141ccfc4", 0, new DateTime(1985, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "82124778005", "1ce573b4-440b-4e01-a168-82386e2a55f2", "lengtmp+lue5n@gmail.com", false, "Mackenzie", null, false, null, null, null, "passWORLD", null, 2L, null, false, "USER", "f9b23451-3b38-4ec3-a906-36d3b565d468", "null", false, null },
                    { "20151c97-45fc-4750-a869-3e5129818551", 0, new DateTime(1999, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "65519709076", "f98598c5-4fc8-4000-be43-4f05754a8eb1", "ezratmp+lath6@gmail.com", false, "Mike", null, false, null, null, null, "pass", null, 1L, null, false, "USER", "ce8c0871-0d21-48f5-a381-6757ab905241", "null", false, null }
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
                    { 3L, new DateTime(2006, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "SSP", 3L, "362932888" },
                    { 2L, new DateTime(1995, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "SSP", 2L, "362932888" },
                    { 1L, new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "SSP", 1L, "190471001" }
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
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
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
                name: "CarteiraDeTrabalhos");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Identities");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Telephones");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
