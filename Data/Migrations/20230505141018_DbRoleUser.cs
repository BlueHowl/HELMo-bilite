using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DbRoleUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.Certification_DEV.WEB.AVC.Dispatcher_DispatcherId",
                table: "DEV.WEB.AVC.Certification");

            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.License_DEV.WEB.AVC.Driver_DriverId",
                table: "DEV.WEB.AVC.License");

            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.User_AspNetUsers_Id",
                table: "DEV.WEB.AVC.User");

            migrationBuilder.DropTable(
                name: "DEV.WEB.AVC.Client");

            migrationBuilder.DropTable(
                name: "DEV.WEB.AVC.Dispatcher");

            migrationBuilder.DropTable(
                name: "DEV.WEB.AVC.Driver");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DEV.WEB.AVC.User",
                table: "DEV.WEB.AVC.User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DEV.WEB.AVC.License",
                table: "DEV.WEB.AVC.License");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DEV.WEB.AVC.Certification",
                table: "DEV.WEB.AVC.Certification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DEV.WEB.AVC.Address",
                table: "DEV.WEB.AVC.Address");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DEV.WEB.AVC.User");

            migrationBuilder.RenameTable(
                name: "DEV.WEB.AVC.User",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "DEV.WEB.AVC.License",
                newName: "License");

            migrationBuilder.RenameTable(
                name: "DEV.WEB.AVC.Certification",
                newName: "Certification");

            migrationBuilder.RenameTable(
                name: "DEV.WEB.AVC.Address",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "DriverId",
                table: "License",
                newName: "Drivermatricule");

            migrationBuilder.RenameIndex(
                name: "IX_DEV.WEB.AVC.License_DriverId",
                table: "License",
                newName: "IX_License_Drivermatricule");

            migrationBuilder.RenameColumn(
                name: "DispatcherId",
                table: "Certification",
                newName: "Dispatchermatricule");

            migrationBuilder.RenameIndex(
                name: "IX_DEV.WEB.AVC.Certification_DispatcherId",
                table: "Certification",
                newName: "IX_Certification_Dispatchermatricule");

            migrationBuilder.AlterColumn<string>(
                name: "matricule",
                table: "User",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CompanyAdressId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "matricule");

            migrationBuilder.AddPrimaryKey(
                name: "PK_License",
                table: "License",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certification",
                table: "Certification",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_CompanyAdressId",
                table: "User",
                column: "CompanyAdressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Certification_User_Dispatchermatricule",
                table: "Certification",
                column: "Dispatchermatricule",
                principalTable: "User",
                principalColumn: "matricule");

            migrationBuilder.AddForeignKey(
                name: "FK_License_User_Drivermatricule",
                table: "License",
                column: "Drivermatricule",
                principalTable: "User",
                principalColumn: "matricule");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_CompanyAdressId",
                table: "User",
                column: "CompanyAdressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certification_User_Dispatchermatricule",
                table: "Certification");

            migrationBuilder.DropForeignKey(
                name: "FK_License_User_Drivermatricule",
                table: "License");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_CompanyAdressId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_CompanyAdressId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_License",
                table: "License");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Certification",
                table: "Certification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "CompanyAdressId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "DEV.WEB.AVC.User");

            migrationBuilder.RenameTable(
                name: "License",
                newName: "DEV.WEB.AVC.License");

            migrationBuilder.RenameTable(
                name: "Certification",
                newName: "DEV.WEB.AVC.Certification");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "DEV.WEB.AVC.Address");

            migrationBuilder.RenameColumn(
                name: "Drivermatricule",
                table: "DEV.WEB.AVC.License",
                newName: "DriverId");

            migrationBuilder.RenameIndex(
                name: "IX_License_Drivermatricule",
                table: "DEV.WEB.AVC.License",
                newName: "IX_DEV.WEB.AVC.License_DriverId");

            migrationBuilder.RenameColumn(
                name: "Dispatchermatricule",
                table: "DEV.WEB.AVC.Certification",
                newName: "DispatcherId");

            migrationBuilder.RenameIndex(
                name: "IX_Certification_Dispatchermatricule",
                table: "DEV.WEB.AVC.Certification",
                newName: "IX_DEV.WEB.AVC.Certification_DispatcherId");

            migrationBuilder.AlterColumn<string>(
                name: "matricule",
                table: "DEV.WEB.AVC.User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "DEV.WEB.AVC.User",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DEV.WEB.AVC.User",
                table: "DEV.WEB.AVC.User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DEV.WEB.AVC.License",
                table: "DEV.WEB.AVC.License",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DEV.WEB.AVC.Certification",
                table: "DEV.WEB.AVC.Certification",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DEV.WEB.AVC.Address",
                table: "DEV.WEB.AVC.Address",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DEV.WEB.AVC.Client",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyAdressId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEV.WEB.AVC.Client", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DEV.WEB.AVC.Client_DEV.WEB.AVC.Address_CompanyAdressId",
                        column: x => x.CompanyAdressId,
                        principalTable: "DEV.WEB.AVC.Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DEV.WEB.AVC.Client_DEV.WEB.AVC.User_Id",
                        column: x => x.Id,
                        principalTable: "DEV.WEB.AVC.User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DEV.WEB.AVC.Dispatcher",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEV.WEB.AVC.Dispatcher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DEV.WEB.AVC.Dispatcher_DEV.WEB.AVC.User_Id",
                        column: x => x.Id,
                        principalTable: "DEV.WEB.AVC.User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DEV.WEB.AVC.Driver",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEV.WEB.AVC.Driver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DEV.WEB.AVC.Driver_DEV.WEB.AVC.User_Id",
                        column: x => x.Id,
                        principalTable: "DEV.WEB.AVC.User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DEV.WEB.AVC.Client_CompanyAdressId",
                table: "DEV.WEB.AVC.Client",
                column: "CompanyAdressId");

            migrationBuilder.AddForeignKey(
                name: "FK_DEV.WEB.AVC.Certification_DEV.WEB.AVC.Dispatcher_DispatcherId",
                table: "DEV.WEB.AVC.Certification",
                column: "DispatcherId",
                principalTable: "DEV.WEB.AVC.Dispatcher",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DEV.WEB.AVC.License_DEV.WEB.AVC.Driver_DriverId",
                table: "DEV.WEB.AVC.License",
                column: "DriverId",
                principalTable: "DEV.WEB.AVC.Driver",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DEV.WEB.AVC.User_AspNetUsers_Id",
                table: "DEV.WEB.AVC.User",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
