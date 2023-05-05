using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class AddDriver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certification_User_Dispatchermatricule",
                table: "Certification");

            migrationBuilder.DropForeignKey(
                name: "FK_License_User_Drivermatricule",
                table: "License");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "matricule",
                table: "User",
                newName: "Matricule");

            migrationBuilder.RenameColumn(
                name: "Drivermatricule",
                table: "License",
                newName: "DriverMatricule");

            migrationBuilder.RenameIndex(
                name: "IX_License_Drivermatricule",
                table: "License",
                newName: "IX_License_DriverMatricule");

            migrationBuilder.RenameColumn(
                name: "Dispatchermatricule",
                table: "Certification",
                newName: "DispatcherMatricule");

            migrationBuilder.RenameIndex(
                name: "IX_Certification_Dispatchermatricule",
                table: "Certification",
                newName: "IX_Certification_DispatcherMatricule");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "10", "Chester36@gmail.com", "Shanny", "O'Conner", "v47Yv6P259", "Driver" },
                    { "11", "Alysha.Braun29@hotmail.com", "Sydnee", "Funk", "8XBjbjvf3Y", "Driver" },
                    { "12", "Baylee66@gmail.com", "Elmer", "Kuvalis", "boDbUKqupV", "Driver" },
                    { "13", "Carissa.Thompson69@yahoo.com", "Bennie", "Wuckert", "sJxajXb9WZ", "Driver" },
                    { "14", "Brielle49@yahoo.com", "Chaz", "Aufderhar", "mTsDZjQh55", "Driver" },
                    { "15", "Mckayla94@hotmail.com", "Dorthy", "Haag", "K1xb9VYJYD", "Driver" },
                    { "16", "Brandt28@yahoo.com", "Lyla", "Heathcote", "ooHPUeIZoo", "Driver" },
                    { "17", "Veronica_Olson79@hotmail.com", "Una", "Jerde", "6pRhoKn7dV", "Driver" },
                    { "18", "Jon.Renner@gmail.com", "Zachary", "Williamson", "95pGjn968V", "Driver" },
                    { "19", "Ana_Cormier92@hotmail.com", "Andres", "Legros", "a1GAG2unbd", "Driver" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Certification_User_DispatcherMatricule",
                table: "Certification",
                column: "DispatcherMatricule",
                principalTable: "User",
                principalColumn: "Matricule");

            migrationBuilder.AddForeignKey(
                name: "FK_License_User_DriverMatricule",
                table: "License",
                column: "DriverMatricule",
                principalTable: "User",
                principalColumn: "Matricule");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certification_User_DispatcherMatricule",
                table: "Certification");

            migrationBuilder.DropForeignKey(
                name: "FK_License_User_DriverMatricule",
                table: "License");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "19");

            migrationBuilder.RenameColumn(
                name: "Matricule",
                table: "User",
                newName: "matricule");

            migrationBuilder.RenameColumn(
                name: "DriverMatricule",
                table: "License",
                newName: "Drivermatricule");

            migrationBuilder.RenameIndex(
                name: "IX_License_DriverMatricule",
                table: "License",
                newName: "IX_License_Drivermatricule");

            migrationBuilder.RenameColumn(
                name: "DispatcherMatricule",
                table: "Certification",
                newName: "Dispatchermatricule");

            migrationBuilder.RenameIndex(
                name: "IX_Certification_DispatcherMatricule",
                table: "Certification",
                newName: "IX_Certification_Dispatchermatricule");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
