using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DriverLicenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverLicense_Licenses_LicensesId",
                table: "DriverLicense");

            migrationBuilder.DropForeignKey(
                name: "FK_DriverLicense_User_DriversMatricule",
                table: "DriverLicense");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DriverLicense",
                table: "DriverLicense");

            migrationBuilder.RenameTable(
                name: "DriverLicense",
                newName: "DriverLicenses");

            migrationBuilder.RenameIndex(
                name: "IX_DriverLicense_LicensesId",
                table: "DriverLicenses",
                newName: "IX_DriverLicenses_LicensesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DriverLicenses",
                table: "DriverLicenses",
                columns: new[] { "DriversMatricule", "LicensesId" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "60",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Macedonia", "Calichester", "68696-3416", "633", "Zieme Divide" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "61",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Serbia", "Jessycashire", "00995", "404", "Nadia Mission" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "62",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Honduras", "West Emmet", "55811", "62542", "Catalina Vista" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "63",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Dominican Republic", "Port Sophia", "76328", "4201", "Caleigh Mills" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "64",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Liechtenstein", "Johathanburgh", "20731", "1294", "Huels Mission" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "65",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Sao Tome and Principe", "New Jettie", "43774-0715", "9286", "Bashirian Ridge" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "66",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Armenia", "Lake Marlene", "32297-4596", "253", "Tina Hill" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "67",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "New Zealand", "North Arnulfoberg", "36955-7457", "33324", "Eva Alley" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "68",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Kuwait", "Cleoraport", "26130-3398", "556", "Terry Mill" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "69",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Puerto Rico", "Torphychester", "85661", "582", "Stefan Spring" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "70",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Emmerich Inc", "Christopher_Kuvalis5@gmail.com", "Malcolm", "Lehner", "463-244-9358", "l5DXQAoHDG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Lang Inc", "Baylee45@hotmail.com", "Kay", "Stracke", "556-445-0142", "FWlxISk3pu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "72",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Borer LLC", "Helena.Hammes@yahoo.com", "Mylene", "Senger", "361-632-2598", "8Ifn_KOQOC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Feest, Paucek and Daniel", "Dino.Stark@yahoo.com", "Arlene", "Hagenes", "954-761-9577", "fEkcKgXf2G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "74",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Cassin, Price and Hahn", "Liliane.Gislason65@gmail.com", "Sherman", "Cole", "933-647-4689", "M0B4prOqHn" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Goodwin Inc", "Geovany.Brekke@hotmail.com", "Weston", "Yost", "610-896-5198", "pcJP5g5Y7O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "76",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Boyle, O'Connell and Hand", "Geraldine.Mertz25@yahoo.com", "Foster", "Altenwerth", "273-507-4887", "oO4DXXUZmv" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Torp and Sons", "Kaylah_Schaefer@gmail.com", "Charles", "Trantow", "512-951-9789", "qcudC_vcfX" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "78",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Huels - Ferry", "Cassidy.Krajcik71@yahoo.com", "Brandy", "McClure", "508-374-6410", "FqiHhrycfS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Bradtke - Towne", "Martine66@hotmail.com", "Helga", "Kassulke", "867-998-9303", "jVOqA5OiPu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "50",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Floy.Kunze@gmail.com", "Garrick", 2, "Gulgowski", "M9x1zLE2tv" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "51",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Abel51@yahoo.com", "Rosina", "Bernier", "nruam4nvAK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "52",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Maria67@gmail.com", "Kelton", 3, "Legros", "BDtH1fngZr" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "53",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Krystina48@hotmail.com", "Jettie", 3, "Toy", "fvUkDjJHgM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "54",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Emmett63@yahoo.com", "Micaela", 2, "Crist", "RJ46HEzURC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "55",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Giles.Cremin54@gmail.com", "Sydni", "Carroll", "R4QHsoHRyP" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "56",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Ella.Hayes87@gmail.com", "Alexie", "Flatley", "RnpGhao5is" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "57",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Regan36@hotmail.com", "Santina", 3, "Robel", "x6ENKeWsa1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "58",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Cathrine_Gorczany@yahoo.com", "Tate", 2, "Fisher", "fwBlwgZsLb" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "59",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Johnny90@hotmail.com", "Deontae", 2, "Abshire", "xPaD8KW4un" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "40",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Dillon.Witting44@hotmail.com", "Alanna", "Lueilwitz", "jYOWiJS72n" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "41",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Amina.Bode@yahoo.com", "Lesly", "Pagac", "S2NR8YEx2w" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "42",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Justice68@hotmail.com", "Josiah", "Fahey", "RuuIq74htU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "43",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Bryce_Brown@yahoo.com", "Jaiden", "Stroman", "8LTgfFo4b9" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "44",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Susan74@yahoo.com", "Alessia", "Hettinger", "U0_t57dOfo" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "45",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Laurianne7@yahoo.com", "Zetta", "Greenholt", "6CDVlTGUXs" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "46",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "William.Streich@gmail.com", "Carrie", "Gerhold", "mn_je0SFzZ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "47",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Hector15@yahoo.com", "Reta", "Moore", "F0xS1WATzG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "48",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Elvera_Luettgen@hotmail.com", "Derek", "Ankunding", "pROGP8O1q0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "49",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Oda.Kohler@hotmail.com", "Susan", "Langosh", "OGdywpJpWU" });

            migrationBuilder.AddForeignKey(
                name: "FK_DriverLicenses_Licenses_LicensesId",
                table: "DriverLicenses",
                column: "LicensesId",
                principalTable: "Licenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DriverLicenses_User_DriversMatricule",
                table: "DriverLicenses",
                column: "DriversMatricule",
                principalTable: "User",
                principalColumn: "Matricule",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverLicenses_Licenses_LicensesId",
                table: "DriverLicenses");

            migrationBuilder.DropForeignKey(
                name: "FK_DriverLicenses_User_DriversMatricule",
                table: "DriverLicenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DriverLicenses",
                table: "DriverLicenses");

            migrationBuilder.RenameTable(
                name: "DriverLicenses",
                newName: "DriverLicense");

            migrationBuilder.RenameIndex(
                name: "IX_DriverLicenses_LicensesId",
                table: "DriverLicense",
                newName: "IX_DriverLicense_LicensesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DriverLicense",
                table: "DriverLicense",
                columns: new[] { "DriversMatricule", "LicensesId" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "60",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Montenegro", "Batzbury", "58263-6452", "5020", "Hailie Shoal" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "61",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Liberia", "South Jovannyside", "47684-3126", "882", "Deckow Pike" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "62",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Ghana", "Wizafort", "80987-5463", "4496", "Jarret Port" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "63",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Mali", "Jastborough", "91888-5632", "136", "Flatley Dam" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "64",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Montserrat", "Fidelshire", "53809-7112", "45855", "Treutel Valleys" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "65",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Bahamas", "Lianachester", "76706-8035", "691", "Feil Parks" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "66",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Cameroon", "Towneview", "65591", "6830", "Cole Stream" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "67",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Falkland Islands (Malvinas)", "Bodeshire", "49925-2964", "0568", "Santina Expressway" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "68",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Poland", "West Makenziemouth", "21634", "29119", "Ozella Mount" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "69",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Afghanistan", "Lake Rosetta", "27476", "4170", "Vivienne Estate" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "70",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Lynch and Sons", "Oscar71@yahoo.com", "Felicity", "Rogahn", "303-232-6976", "GFizTAtCT0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Rau - Abernathy", "Kacey3@yahoo.com", "Patricia", "Kling", "529-995-6631", "WcZbIpbwh7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "72",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Littel - Kub", "Shad_Lesch@yahoo.com", "Anika", "Vandervort", "667-467-5238", "bZJqh1NukG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Ritchie, Stoltenberg and Howell", "Raymond_Kris@yahoo.com", "Garret", "Olson", "416-466-7024", "9Mqym8XGCM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "74",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Aufderhar, Goodwin and Ledner", "Maya62@hotmail.com", "Melissa", "Monahan", "384-581-2366", "r7M3Dn8VHl" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Walter - Walsh", "Russ59@yahoo.com", "Kellie", "Breitenberg", "739-204-9691", "iO6bVKexGw" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "76",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Kunde LLC", "Aurelio7@yahoo.com", "Rowena", "Kling", "386-958-3324", "rPoMxhxKaY" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Boyer - Feil", "Laron_Dickinson50@gmail.com", "Kristofer", "Sipes", "342-388-9184", "FLOMo0TKca" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "78",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Wuckert and Sons", "Alejandrin_Rice78@yahoo.com", "Bonita", "Schamberger", "759-890-1193", "JlEYpM0NoA" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Kautzer, Collins and Waelchi", "Presley46@gmail.com", "Davonte", "Ziemann", "909-419-3666", "NOxoqe441P" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "50",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Devin_Fisher11@yahoo.com", "Matilde", 1, "Lemke", "_qGdF6ApHV" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "51",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Dessie92@gmail.com", "Ernesto", "Harvey", "AZWhGwVNIN" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "52",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Dedric6@yahoo.com", "Elwin", 1, "Buckridge", "FubIa6s3hm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "53",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Winona84@yahoo.com", "Jose", 2, "Bartoletti", "tUJwLEl1cc" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "54",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Rory21@hotmail.com", "Ezekiel", 3, "Haag", "tFDG8f7rPe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "55",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Abigayle.Kuhic12@hotmail.com", "Cierra", "Hyatt", "I_QYlV6NPF" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "56",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Enoch_Bradtke50@yahoo.com", "Erica", "Parisian", "27GyxItYBc" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "57",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Elliot_Schamberger39@gmail.com", "Mathew", 2, "Wisoky", "p_JR0jwPck" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "58",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Dina.Toy@yahoo.com", "Myrtice", 3, "Green", "EJS2oFJh2c" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "59",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Celestine20@hotmail.com", "Maxime", 1, "Beer", "yMaikVNE_r" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "40",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Adrian87@yahoo.com", "Kasandra", "Greenholt", "2Vo9oBXQCL" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "41",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jayda2@gmail.com", "Dorris", "Gibson", "_CZ7ULXUit" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "42",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Tillman79@gmail.com", "Mortimer", "Fadel", "l3ryFt4Ng7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "43",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Loyal_OConnell58@hotmail.com", "Norbert", "Schultz", "jd1_4TAB9V" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "44",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Kathleen_Emmerich68@hotmail.com", "Braeden", "Jast", "3P__4SXVRm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "45",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Ari56@yahoo.com", "Emery", "Miller", "0gQn9vGduf" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "46",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Leonel.Schoen@gmail.com", "Jon", "Labadie", "9RR4ET8fZM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "47",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Verlie_Cole@yahoo.com", "Cooper", "Swaniawski", "PVej9kqPAB" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "48",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Rylee.Zemlak78@yahoo.com", "Jamey", "Bogisich", "5WtSKIQ6R_" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "49",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jack.Denesik@hotmail.com", "Judah", "Welch", "jAGFKwAezc" });

            migrationBuilder.AddForeignKey(
                name: "FK_DriverLicense_Licenses_LicensesId",
                table: "DriverLicense",
                column: "LicensesId",
                principalTable: "Licenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DriverLicense_User_DriversMatricule",
                table: "DriverLicense",
                column: "DriversMatricule",
                principalTable: "User",
                principalColumn: "Matricule",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
