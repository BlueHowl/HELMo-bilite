using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.Certification_DEV.WEB.AVC.Dispatcher_Dispatchermatricule",
                table: "DEV.WEB.AVC.Certification");

            migrationBuilder.DropForeignKey(
                name: "FK_DEV.WEB.AVC.License_DEV.WEB.AVC.Driver_Drivermatricule",
                table: "DEV.WEB.AVC.License");

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

            migrationBuilder.DropIndex(
                name: "IX_DEV.WEB.AVC.License_Drivermatricule",
                table: "DEV.WEB.AVC.License");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DEV.WEB.AVC.Certification",
                table: "DEV.WEB.AVC.Certification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DEV.WEB.AVC.Address",
                table: "DEV.WEB.AVC.Address");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "DEV.WEB.AVC.User");

            migrationBuilder.DropColumn(
                name: "Drivermatricule",
                table: "DEV.WEB.AVC.License");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DEV.WEB.AVC.Address");

            migrationBuilder.RenameTable(
                name: "DEV.WEB.AVC.User",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "DEV.WEB.AVC.License",
                newName: "Licenses");

            migrationBuilder.RenameTable(
                name: "DEV.WEB.AVC.Certification",
                newName: "Certifications");

            migrationBuilder.RenameTable(
                name: "DEV.WEB.AVC.Address",
                newName: "Addresses");

            migrationBuilder.RenameColumn(
                name: "matricule",
                table: "User",
                newName: "Matricule");

            migrationBuilder.RenameColumn(
                name: "Dispatchermatricule",
                table: "Certifications",
                newName: "DispatcherMatricule");

            migrationBuilder.RenameIndex(
                name: "IX_DEV.WEB.AVC.Certification_Dispatchermatricule",
                table: "Certifications",
                newName: "IX_Certifications_DispatcherMatricule");

            migrationBuilder.AddColumn<string>(
                name: "CompanyAddressId",
                table: "User",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.AlterColumn<string>(
                name: "LocalityCode",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "IdAddress",
                table: "Addresses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Matricule");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Licenses",
                table: "Licenses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certifications",
                table: "Certifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "IdAddress");

            migrationBuilder.CreateTable(
                name: "DriverLicense",
                columns: table => new
                {
                    DriversMatricule = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LicensesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverLicense", x => new { x.DriversMatricule, x.LicensesId });
                    table.ForeignKey(
                        name: "FK_DriverLicense_Licenses_LicensesId",
                        column: x => x.LicensesId,
                        principalTable: "Licenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DriverLicense_User_DriversMatricule",
                        column: x => x.DriversMatricule,
                        principalTable: "User",
                        principalColumn: "Matricule",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    Plate = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicensesId = table.Column<int>(type: "int", nullable: false),
                    IdLicenses = table.Column<int>(type: "int", nullable: false),
                    Payload = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.Plate);
                    table.ForeignKey(
                        name: "FK_Trucks_Licenses_LicensesId",
                        column: x => x.LicensesId,
                        principalTable: "Licenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "IdAddress", "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[,]
                {
                    { "60", "Suriname", "South Ernestina", "28387-6071", "42849", "Berge Shores" },
                    { "61", "American Samoa", "Catharinemouth", "89588", "7877", "Emiliano Cove" },
                    { "62", "Myanmar", "South Tinaville", "96975", "315", "Gottlieb Corners" },
                    { "63", "Equatorial Guinea", "East Eldonshire", "52809-3498", "8999", "Richmond Haven" },
                    { "64", "Malawi", "South Susanna", "87414", "234", "Timmy Viaduct" },
                    { "65", "Qatar", "Bernhardland", "64338", "554", "Buckridge Dam" },
                    { "66", "Kenya", "Mattiemouth", "18117", "9444", "Madisyn Ridges" },
                    { "67", "Suriname", "O'Haramouth", "09276", "02406", "Kemmer Cliffs" },
                    { "68", "Denmark", "Bernieceland", "99682", "216", "Bernhard Mountain" },
                    { "69", "Seychelles", "New Gonzalo", "50883", "7027", "Mayer Wall" }
                });

            migrationBuilder.InsertData(
                table: "Licenses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "B" },
                    { 2, "C" },
                    { 3, "CE" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "-1", "admin@admin.com", "Admin", "Admin", "admin", "Admin" },
                    { "50", "Alene70@gmail.com", "Ronaldo", "Bergnaum", "MkGwzQmnxg", "Dispatcher" },
                    { "51", "Abbie.Durgan@yahoo.com", "Clifton", "Schmeler", "NPSn7Mf8x9", "Dispatcher" },
                    { "52", "Elyse_Kohler@hotmail.com", "Lionel", "Bins", "Z1yPMOCJog", "Dispatcher" },
                    { "53", "Mafalda_Bergstrom13@gmail.com", "Dominique", "Marks", "Jm2IcbiGR1", "Dispatcher" },
                    { "54", "Garett.Schuppe@yahoo.com", "Tierra", "Bauch", "TSEukDRJre", "Dispatcher" },
                    { "55", "Brionna.Sauer39@gmail.com", "Emory", "Hirthe", "tpMcyrJZD3", "Dispatcher" },
                    { "56", "Vince_Senger9@hotmail.com", "Tod", "Heathcote", "2G_be6cBNs", "Dispatcher" },
                    { "57", "Gia_Lynch28@hotmail.com", "Giovani", "Wilkinson", "zcVZ77TycI", "Dispatcher" },
                    { "58", "Randy58@yahoo.com", "Gudrun", "Muller", "vToaTB9C_5", "Dispatcher" },
                    { "59", "Sylvan26@gmail.com", "Dennis", "Kirlin", "bFW9tWuMMG", "Dispatcher" },
                    { "40", "Taylor.Shanahan99@gmail.com", "Camden", "Ryan", "pJl4rbrfNA", "Driver" },
                    { "41", "Andre.Kessler36@hotmail.com", "Anjali", "Mohr", "GG5jdeVZtM", "Driver" },
                    { "42", "Kassandra_Dicki82@yahoo.com", "Gianni", "Predovic", "VWtt3ZOjYu", "Driver" },
                    { "43", "Hobart.Mayer@yahoo.com", "Jeanette", "Olson", "TZ6VsNmKzL", "Driver" },
                    { "44", "Joel.Goodwin55@yahoo.com", "Jannie", "Reilly", "UlxyLXZJQj", "Driver" },
                    { "45", "Trey_Roob@hotmail.com", "Lori", "Baumbach", "rVOGUDsLol", "Driver" },
                    { "46", "Van96@hotmail.com", "Joey", "Leuschke", "zRYzU5UqJ1", "Driver" },
                    { "47", "Anibal74@yahoo.com", "Creola", "Streich", "qJhKuWBpiX", "Driver" },
                    { "48", "Liana11@gmail.com", "Rachael", "Veum", "YTdZ5wlFUP", "Driver" },
                    { "49", "Kattie_Spencer@gmail.com", "Kevon", "Kuvalis", "xn1TMgdsFB", "Driver" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "CompanyAddressId", "CompanyName", "Email", "FirstName", "Name", "Number", "Password", "Role" },
                values: new object[,]
                {
                    { "70", "60", "Larkin and Sons", "Mike.Thompson39@gmail.com", "Darrin", "Emard", "539-863-4533", "Xgw7zR1yxC", "Client" },
                    { "71", "61", "Leannon Group", "Linnie3@hotmail.com", "Dovie", "Boyle", "741-716-4122", "yE6Ckxo0EI", "Client" },
                    { "72", "62", "Cronin, Mayert and Ullrich", "Shawna.Breitenberg24@yahoo.com", "Michelle", "Mayer", "621-567-3328", "abKt5Dl1Qe", "Client" },
                    { "73", "63", "Moore Inc", "Marietta.Muller@yahoo.com", "Roosevelt", "Mitchell", "400-883-1300", "T_oyCv8C6y", "Client" },
                    { "74", "64", "Quigley, O'Keefe and Rath", "Reina75@hotmail.com", "Gianni", "Effertz", "781-208-4655", "___4f5iAgk", "Client" },
                    { "75", "65", "Waters - Sipes", "Olin.Yundt90@hotmail.com", "Margarette", "Crist", "303-424-0192", "BR6dkuxfvP", "Client" },
                    { "76", "66", "Fritsch and Sons", "Emmet.Kulas@gmail.com", "Lizeth", "Ullrich", "870-448-2595", "EMDwIttWd1", "Client" },
                    { "77", "67", "Hilpert LLC", "Adell_Becker@gmail.com", "Tito", "Krajcik", "994-333-0350", "NXUbh8v6B_", "Client" },
                    { "78", "68", "Mills - Leannon", "Antone_Lemke24@gmail.com", "Giuseppe", "Wuckert", "403-976-9428", "UqeXtidOZG", "Client" },
                    { "79", "69", "Hills, Morissette and McKenzie", "Frankie_Lind28@yahoo.com", "Stephan", "Purdy", "267-694-5476", "P5er5vGDpg", "Client" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_CompanyAddressId",
                table: "User",
                column: "CompanyAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverLicense_LicensesId",
                table: "DriverLicense",
                column: "LicensesId");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_LicensesId",
                table: "Trucks",
                column: "LicensesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Certifications_User_DispatcherMatricule",
                table: "Certifications",
                column: "DispatcherMatricule",
                principalTable: "User",
                principalColumn: "Matricule");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Addresses_CompanyAddressId",
                table: "User",
                column: "CompanyAddressId",
                principalTable: "Addresses",
                principalColumn: "IdAddress",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certifications_User_DispatcherMatricule",
                table: "Certifications");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Addresses_CompanyAddressId",
                table: "User");

            migrationBuilder.DropTable(
                name: "DriverLicense");

            migrationBuilder.DropTable(
                name: "Trucks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_CompanyAddressId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Licenses",
                table: "Licenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Certifications",
                table: "Certifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DeleteData(
                table: "Licenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Licenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Licenses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "-1");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "70");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "72");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "74");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "76");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "78");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "50");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "51");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "52");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "53");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "54");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "55");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "56");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "57");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "58");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "59");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "40");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "41");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "42");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "43");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "44");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "45");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "46");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "47");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "48");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "49");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "60");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "61");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "62");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "63");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "64");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "65");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "66");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "67");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "68");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "69");

            migrationBuilder.DropColumn(
                name: "CompanyAddressId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IdAddress",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "DEV.WEB.AVC.User");

            migrationBuilder.RenameTable(
                name: "Licenses",
                newName: "DEV.WEB.AVC.License");

            migrationBuilder.RenameTable(
                name: "Certifications",
                newName: "DEV.WEB.AVC.Certification");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "DEV.WEB.AVC.Address");

            migrationBuilder.RenameColumn(
                name: "Matricule",
                table: "DEV.WEB.AVC.User",
                newName: "matricule");

            migrationBuilder.RenameColumn(
                name: "DispatcherMatricule",
                table: "DEV.WEB.AVC.Certification",
                newName: "Dispatchermatricule");

            migrationBuilder.RenameIndex(
                name: "IX_Certifications_DispatcherMatricule",
                table: "DEV.WEB.AVC.Certification",
                newName: "IX_DEV.WEB.AVC.Certification_Dispatchermatricule");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "DEV.WEB.AVC.User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Drivermatricule",
                table: "DEV.WEB.AVC.License",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocalityCode",
                table: "DEV.WEB.AVC.Address",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DEV.WEB.AVC.Address",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DEV.WEB.AVC.User",
                table: "DEV.WEB.AVC.User",
                column: "matricule");

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
                    matricule = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyAdressId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_DEV.WEB.AVC.License_Drivermatricule",
                table: "DEV.WEB.AVC.License",
                column: "Drivermatricule");

            migrationBuilder.CreateIndex(
                name: "IX_DEV.WEB.AVC.Client_CompanyAdressId",
                table: "DEV.WEB.AVC.Client",
                column: "CompanyAdressId");

            migrationBuilder.AddForeignKey(
                name: "FK_DEV.WEB.AVC.Certification_DEV.WEB.AVC.Dispatcher_Dispatchermatricule",
                table: "DEV.WEB.AVC.Certification",
                column: "Dispatchermatricule",
                principalTable: "DEV.WEB.AVC.Dispatcher",
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
