using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class LinkUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.Certification_DEV.WEB.AVC.Dispatcher_Dispatchermatricule",
                table: "DEV.WEB.AVC.Certification");

            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.Client_DEV.WEB.AVC.User_matricule",
                table: "DEV.WEB.AVC.Client");

            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.Dispatcher_DEV.WEB.AVC.User_matricule",
                table: "DEV.WEB.AVC.Dispatcher");

            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.Driver_DEV.WEB.AVC.User_matricule",
                table: "DEV.WEB.AVC.Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.License_DEV.WEB.AVC.Driver_Drivermatricule",
                table: "DEV.WEB.AVC.License");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DEV.WEB.AVC.User",
                table: "DEV.WEB.AVC.User");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "DEV.WEB.AVC.User");

            migrationBuilder.RenameColumn(
                name: "Drivermatricule",
                table: "DEV.WEB.AVC.License",
                newName: "DriverId");

            migrationBuilder.RenameIndex(
                name: "IX_DEV.WEB.AVC.License_Drivermatricule",
                table: "DEV.WEB.AVC.License",
                newName: "IX_DEV.WEB.AVC.License_DriverId");

            migrationBuilder.RenameColumn(
                name: "matricule",
                table: "DEV.WEB.AVC.Driver",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "matricule",
                table: "DEV.WEB.AVC.Dispatcher",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "matricule",
                table: "DEV.WEB.AVC.Client",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Dispatchermatricule",
                table: "DEV.WEB.AVC.Certification",
                newName: "DispatcherId");

            migrationBuilder.RenameIndex(
                name: "IX_DEV.WEB.AVC.Certification_Dispatchermatricule",
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

            migrationBuilder.AddForeignKey(
                name: "FK_DEV.WEB.AVC.Certification_DEV.WEB.AVC.Dispatcher_DispatcherId",
                table: "DEV.WEB.AVC.Certification",
                column: "DispatcherId",
                principalTable: "DEV.WEB.AVC.Dispatcher",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DEV.WEB.AVC.Client_DEV.WEB.AVC.User_Id",
                table: "DEV.WEB.AVC.Client",
                column: "Id",
                principalTable: "DEV.WEB.AVC.User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DEV.WEB.AVC.Dispatcher_DEV.WEB.AVC.User_Id",
                table: "DEV.WEB.AVC.Dispatcher",
                column: "Id",
                principalTable: "DEV.WEB.AVC.User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DEV.WEB.AVC.Driver_DEV.WEB.AVC.User_Id",
                table: "DEV.WEB.AVC.Driver",
                column: "Id",
                principalTable: "DEV.WEB.AVC.User",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.Certification_DEV.WEB.AVC.Dispatcher_DispatcherId",
                table: "DEV.WEB.AVC.Certification");

            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.Client_DEV.WEB.AVC.User_Id",
                table: "DEV.WEB.AVC.Client");

            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.Dispatcher_DEV.WEB.AVC.User_Id",
                table: "DEV.WEB.AVC.Dispatcher");

            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.Driver_DEV.WEB.AVC.User_Id",
                table: "DEV.WEB.AVC.Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.License_DEV.WEB.AVC.Driver_DriverId",
                table: "DEV.WEB.AVC.License");

            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.User_AspNetUsers_Id",
                table: "DEV.WEB.AVC.User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DEV.WEB.AVC.User",
                table: "DEV.WEB.AVC.User");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DEV.WEB.AVC.User");

            migrationBuilder.RenameColumn(
                name: "DriverId",
                table: "DEV.WEB.AVC.License",
                newName: "Drivermatricule");

            migrationBuilder.RenameIndex(
                name: "IX_DEV.WEB.AVC.License_DriverId",
                table: "DEV.WEB.AVC.License",
                newName: "IX_DEV.WEB.AVC.License_Drivermatricule");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DEV.WEB.AVC.Driver",
                newName: "matricule");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DEV.WEB.AVC.Dispatcher",
                newName: "matricule");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DEV.WEB.AVC.Client",
                newName: "matricule");

            migrationBuilder.RenameColumn(
                name: "DispatcherId",
                table: "DEV.WEB.AVC.Certification",
                newName: "Dispatchermatricule");

            migrationBuilder.RenameIndex(
                name: "IX_DEV.WEB.AVC.Certification_DispatcherId",
                table: "DEV.WEB.AVC.Certification",
                newName: "IX_DEV.WEB.AVC.Certification_Dispatchermatricule");

            migrationBuilder.AlterColumn<string>(
                name: "matricule",
                table: "DEV.WEB.AVC.User",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "DEV.WEB.AVC.User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DEV.WEB.AVC.User",
                table: "DEV.WEB.AVC.User",
                column: "matricule");

            migrationBuilder.AddForeignKey(
                name: "FK_DEV.WEB.AVC.Certification_DEV.WEB.AVC.Dispatcher_Dispatchermatricule",
                table: "DEV.WEB.AVC.Certification",
                column: "Dispatchermatricule",
                principalTable: "DEV.WEB.AVC.Dispatcher",
                principalColumn: "matricule");

            migrationBuilder.AddForeignKey(
                name: "FK_DEV.WEB.AVC.Client_DEV.WEB.AVC.User_matricule",
                table: "DEV.WEB.AVC.Client",
                column: "matricule",
                principalTable: "DEV.WEB.AVC.User",
                principalColumn: "matricule");

            migrationBuilder.AddForeignKey(
                name: "FK_DEV.WEB.AVC.Dispatcher_DEV.WEB.AVC.User_matricule",
                table: "DEV.WEB.AVC.Dispatcher",
                column: "matricule",
                principalTable: "DEV.WEB.AVC.User",
                principalColumn: "matricule");

            migrationBuilder.AddForeignKey(
                name: "FK_DEV.WEB.AVC.Driver_DEV.WEB.AVC.User_matricule",
                table: "DEV.WEB.AVC.Driver",
                column: "matricule",
                principalTable: "DEV.WEB.AVC.User",
                principalColumn: "matricule");

            migrationBuilder.AddForeignKey(
                name: "FK_DEV.WEB.AVC.License_DEV.WEB.AVC.Driver_Drivermatricule",
                table: "DEV.WEB.AVC.License",
                column: "Drivermatricule",
                principalTable: "DEV.WEB.AVC.Driver",
                principalColumn: "matricule");
        }
    }
}
