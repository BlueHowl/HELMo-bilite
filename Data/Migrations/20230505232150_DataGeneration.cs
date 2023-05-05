using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DataGeneration : Migration
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

            migrationBuilder.DropColumn(
                name: "Status",
                table: "DEV.WEB.AVC.User");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DEV.WEB.AVC.Address");

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
                name: "matricule",
                table: "User",
                newName: "Matricule");

            migrationBuilder.RenameColumn(
                name: "DriverId",
                table: "License",
                newName: "DriverMatricule");

            migrationBuilder.RenameIndex(
                name: "IX_DEV.WEB.AVC.License_DriverId",
                table: "License",
                newName: "IX_License_DriverMatricule");

            migrationBuilder.RenameColumn(
                name: "DispatcherId",
                table: "Certification",
                newName: "DispatcherMatricule");

            migrationBuilder.RenameIndex(
                name: "IX_DEV.WEB.AVC.Certification_DispatcherId",
                table: "Certification",
                newName: "IX_Certification_DispatcherMatricule");

            migrationBuilder.AlterColumn<string>(
                name: "Matricule",
                table: "User",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.AlterColumn<string>(
                name: "LocalityCode",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "IdAddress",
                table: "Address",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Matricule");

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
                column: "IdAddress");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "IdAddress", "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[,]
                {
                    { "60", "Turks and Caicos Islands", "Christiansenstad", "77483-3165", "532", "Carson Path" },
                    { "61", "Hungary", "Mayertburgh", "73379-5426", "364", "Dickinson Greens" },
                    { "62", "Liechtenstein", "Hellerburgh", "43568-6742", "188", "Strosin Port" },
                    { "63", "Sudan", "New Aylaside", "90207", "0330", "Huels Vista" },
                    { "64", "Belgium", "Port Orvilleburgh", "19788-9089", "029", "Walter Squares" },
                    { "65", "Grenada", "North Zachariahburgh", "42104-9162", "6746", "Lily Path" },
                    { "66", "Turkmenistan", "Mayershire", "64520-8518", "20832", "Elna Passage" },
                    { "67", "South Georgia and the South Sandwich Islands", "Lake Susannahaven", "68023", "292", "O'Kon Freeway" },
                    { "68", "Belarus", "South Woodrowstad", "77660-0667", "55172", "Dickens Freeway" },
                    { "69", "Indonesia", "West Greysonton", "27512", "6717", "Morar River" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "-1", "admin@admin.com", "Admin", "Admin", "admin", "Admin" },
                    { "50", "Vladimir.Paucek55@hotmail.com", "Merlin", "Mueller", "oZ8vKVYEbx", "Dispatcher" },
                    { "51", "Ursula41@hotmail.com", "Deangelo", "Wiegand", "TlztgutH4k", "Dispatcher" },
                    { "52", "Rolando.Turner95@hotmail.com", "Treva", "Purdy", "KJUn9mxYco", "Dispatcher" },
                    { "53", "Maryse47@hotmail.com", "Myrtice", "Shanahan", "1pIMkFicl2", "Dispatcher" },
                    { "54", "Laurie.Sawayn@gmail.com", "Coleman", "Turner", "HiZXm1RPgo", "Dispatcher" },
                    { "55", "Tatyana.Champlin@gmail.com", "Kariane", "Marvin", "TFnxu6_3KO", "Dispatcher" },
                    { "56", "Andreanne53@hotmail.com", "Citlalli", "Gorczany", "H_YSn1M_70", "Dispatcher" },
                    { "57", "Nakia21@gmail.com", "Cale", "Considine", "hqbG0MO5pe", "Dispatcher" },
                    { "58", "Derrick17@yahoo.com", "Zetta", "Tillman", "ry8gkNk9B0", "Dispatcher" },
                    { "59", "Laurie.Botsford@yahoo.com", "Paul", "Ryan", "XA4bdNojcW", "Dispatcher" },
                    { "40", "Theo.Kunde87@hotmail.com", "Arthur", "Windler", "idliFpfOAa", "Driver" },
                    { "41", "Sylvan.Terry80@yahoo.com", "Kiera", "Mueller", "EQBEfpuHCG", "Driver" },
                    { "42", "Jerome.Rohan80@gmail.com", "Alessia", "Cole", "zaa67ZA_PR", "Driver" },
                    { "43", "Delilah.Bashirian4@gmail.com", "Nelson", "Kiehn", "tSL2tJgDIq", "Driver" },
                    { "44", "Sheridan21@gmail.com", "Lina", "Wisozk", "L4ly8KWHIB", "Driver" },
                    { "45", "Arnold55@hotmail.com", "Art", "Mann", "VV9XcmttgB", "Driver" },
                    { "46", "Daphne.Bruen54@hotmail.com", "Arvel", "D'Amore", "vjyoTiST47", "Driver" },
                    { "47", "Luella.Kirlin@hotmail.com", "Ethan", "Wiegand", "DumzDVWqa_", "Driver" },
                    { "48", "Wilfrid.Grant28@hotmail.com", "Chanelle", "Kreiger", "L7YFAjRpm2", "Driver" },
                    { "49", "Audreanne52@hotmail.com", "Gilbert", "Johnston", "7U3Q3S1fxh", "Driver" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "CompanyAddressId", "CompanyName", "Email", "FirstName", "Name", "Number", "Password", "Role" },
                values: new object[,]
                {
                    { "70", "60", "Rodriguez Inc", "Erin.Parker@yahoo.com", "Jesus", "Bechtelar", "486-250-8053", "TW97iADotQ", "Client" },
                    { "71", "61", "Abernathy and Sons", "Cathy_Schowalter@gmail.com", "Brennan", "O'Keefe", "578-899-7693", "oaTyKK0H6U", "Client" },
                    { "72", "62", "Schmitt and Sons", "Maryam_Grady@gmail.com", "Hilda", "Jacobs", "350-348-4779", "mrZc7oi2yj", "Client" },
                    { "73", "63", "Hartmann LLC", "Lola_Quigley@gmail.com", "Jamel", "Bauch", "574-848-3083", "AREp7pgU2j", "Client" },
                    { "74", "64", "Kuhic - Effertz", "Anna_Larson13@gmail.com", "Adalberto", "Frami", "587-514-4357", "DWmnuVM6aM", "Client" },
                    { "75", "65", "Hagenes Inc", "Jarrett16@hotmail.com", "Delia", "Effertz", "383-449-8923", "xOjnmx9JMI", "Client" },
                    { "76", "66", "Orn Inc", "Akeem2@yahoo.com", "Brandyn", "D'Amore", "435-358-9142", "hQl0f4aadZ", "Client" },
                    { "77", "67", "Kuhn and Sons", "Arianna.Langosh41@gmail.com", "Edmond", "Durgan", "898-586-3625", "68s4RJSpfM", "Client" },
                    { "78", "68", "Osinski - Franecki", "Cristal97@yahoo.com", "Daphne", "Feeney", "796-774-2920", "9KgthYQCaB", "Client" },
                    { "79", "69", "Daniel, Kilback and Berge", "Sandra_Fay24@yahoo.com", "Oral", "Wyman", "922-565-1752", "zib2jDUkBc", "Client" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_CompanyAddressId",
                table: "User",
                column: "CompanyAddressId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_CompanyAddressId",
                table: "User",
                column: "CompanyAddressId",
                principalTable: "Address",
                principalColumn: "IdAddress",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certification_User_DispatcherMatricule",
                table: "Certification");

            migrationBuilder.DropForeignKey(
                name: "FK_License_User_DriverMatricule",
                table: "License");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_CompanyAddressId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_CompanyAddressId",
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
                table: "Address",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "60");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "61");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "62");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "63");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "64");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "65");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "66");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "67");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyColumnType: "nvarchar(450)",
                keyValue: "68");

            migrationBuilder.DeleteData(
                table: "Address",
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
                name: "Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IdAddress",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Address");

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
                name: "Matricule",
                table: "DEV.WEB.AVC.User",
                newName: "matricule");

            migrationBuilder.RenameColumn(
                name: "DriverMatricule",
                table: "DEV.WEB.AVC.License",
                newName: "DriverId");

            migrationBuilder.RenameIndex(
                name: "IX_License_DriverMatricule",
                table: "DEV.WEB.AVC.License",
                newName: "IX_DEV.WEB.AVC.License_DriverId");

            migrationBuilder.RenameColumn(
                name: "DispatcherMatricule",
                table: "DEV.WEB.AVC.Certification",
                newName: "DispatcherId");

            migrationBuilder.RenameIndex(
                name: "IX_Certification_DispatcherMatricule",
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

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "DEV.WEB.AVC.User",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
