using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharterSampleApp.CharterRestApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAddress",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddress", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "UserBillingStatement",
                columns: table => new
                {
                    BillingStatementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    BillingMonth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountDue = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    NewCharges = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBillingStatement", x => x.BillingStatementId);
                });

            migrationBuilder.CreateTable(
                name: "CharterUserAccount",
                columns: table => new
                {
                    AccountNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceAddressAddressId = table.Column<int>(type: "int", nullable: false),
                    BillingAddressAddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharterUserAccount", x => x.AccountNumber);
                    table.ForeignKey(
                        name: "FK_CharterUserAccount_UserAddress_BillingAddressAddressId",
                        column: x => x.BillingAddressAddressId,
                        principalTable: "UserAddress",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CharterUserAccount_UserAddress_ServiceAddressAddressId",
                        column: x => x.ServiceAddressAddressId,
                        principalTable: "UserAddress",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharterUserAccount_BillingAddressAddressId",
                table: "CharterUserAccount",
                column: "BillingAddressAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CharterUserAccount_ServiceAddressAddressId",
                table: "CharterUserAccount",
                column: "ServiceAddressAddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharterUserAccount");

            migrationBuilder.DropTable(
                name: "UserBillingStatement");

            migrationBuilder.DropTable(
                name: "UserAddress");
        }
    }
}
