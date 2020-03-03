using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppBoFv2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Org_name = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    INN = table.Column<decimal>(nullable: false),
                    KPP = table.Column<decimal>(nullable: false),
                    OGRN = table.Column<decimal>(nullable: false),
                    Account_number = table.Column<decimal>(nullable: false),
                    Org_phone = table.Column<string>(nullable: true),
                    Org_email = table.Column<string>(nullable: true),
                    Info = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Patronymic = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(nullable: true),    // Поменять на false 
                    Password = table.Column<string>(nullable: true), // Поменять на false
                    EmailReg = table.Column<string>(nullable: true)  // Поменять на false
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
