using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DEV.WEB.AVC.Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Locality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalityCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEV.WEB.AVC.Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DEV.WEB.AVC.User",
                columns: table => new
                {
                    matricule = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEV.WEB.AVC.User", x => x.matricule);
                });

            migrationBuilder.CreateTable(
                name: "DEV.WEB.AVC.Client",
                columns: table => new
                {
                    matricule = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAdressId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEV.WEB.AVC.Client", x => x.matricule);
                    table.ForeignKey(
                        name: "FK_DEV.WEB.AVC.Client_DEV.WEB.AVC.Address_CompanyAdressId",
                        column: x => x.CompanyAdressId,
                        principalTable: "DEV.WEB.AVC.Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DEV.WEB.AVC.Client_DEV.WEB.AVC.User_matricule",
                        column: x => x.matricule,
                        principalTable: "DEV.WEB.AVC.User",
                        principalColumn: "matricule");
                });

            migrationBuilder.CreateTable(
                name: "DEV.WEB.AVC.Dispatcher",
                columns: table => new
                {
                    matricule = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEV.WEB.AVC.Dispatcher", x => x.matricule);
                    table.ForeignKey(
                        name: "FK_DEV.WEB.AVC.Dispatcher_DEV.WEB.AVC.User_matricule",
                        column: x => x.matricule,
                        principalTable: "DEV.WEB.AVC.User",
                        principalColumn: "matricule");
                });

            migrationBuilder.CreateTable(
                name: "DEV.WEB.AVC.Driver",
                columns: table => new
                {
                    matricule = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEV.WEB.AVC.Driver", x => x.matricule);
                    table.ForeignKey(
                        name: "FK_DEV.WEB.AVC.Driver_DEV.WEB.AVC.User_matricule",
                        column: x => x.matricule,
                        principalTable: "DEV.WEB.AVC.User",
                        principalColumn: "matricule");
                });

            migrationBuilder.CreateTable(
                name: "DEV.WEB.AVC.Certification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dispatchermatricule = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEV.WEB.AVC.Certification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DEV.WEB.AVC.Certification_DEV.WEB.AVC.Dispatcher_Dispatchermatricule",
                        column: x => x.Dispatchermatricule,
                        principalTable: "DEV.WEB.AVC.Dispatcher",
                        principalColumn: "matricule");
                });

            migrationBuilder.CreateTable(
                name: "DEV.WEB.AVC.License",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Drivermatricule = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEV.WEB.AVC.License", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DEV.WEB.AVC.License_DEV.WEB.AVC.Driver_Drivermatricule",
                        column: x => x.Drivermatricule,
                        principalTable: "DEV.WEB.AVC.Driver",
                        principalColumn: "matricule");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DEV.WEB.AVC.Certification_Dispatchermatricule",
                table: "DEV.WEB.AVC.Certification",
                column: "Dispatchermatricule");

            migrationBuilder.CreateIndex(
                name: "IX_DEV.WEB.AVC.Client_CompanyAdressId",
                table: "DEV.WEB.AVC.Client",
                column: "CompanyAdressId");

            migrationBuilder.CreateIndex(
                name: "IX_DEV.WEB.AVC.License_Drivermatricule",
                table: "DEV.WEB.AVC.License",
                column: "Drivermatricule");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DEV.WEB.AVC.Certification");

            migrationBuilder.DropTable(
                name: "DEV.WEB.AVC.Client");

            migrationBuilder.DropTable(
                name: "DEV.WEB.AVC.License");

            migrationBuilder.DropTable(
                name: "DEV.WEB.AVC.Dispatcher");

            migrationBuilder.DropTable(
                name: "DEV.WEB.AVC.Address");

            migrationBuilder.DropTable(
                name: "DEV.WEB.AVC.Driver");

            migrationBuilder.DropTable(
                name: "DEV.WEB.AVC.User");
        }
    }
}
