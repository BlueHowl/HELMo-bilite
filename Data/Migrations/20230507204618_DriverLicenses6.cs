using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DriverLicenses6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_User_DriverMatricule",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_DriverMatricule",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DriverMatricule",
                table: "User");

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

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "80",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Timor-Leste", "New Hazelmouth", "30183", "102", "Mafalda Wells" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "81",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Mauritius", "North Aliya", "82500-4341", "0120", "Gene Estates" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "82",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Seychelles", "South Yasminemouth", "44562-5814", "340", "Johnson Turnpike" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "83",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Latvia", "Lake Edenburgh", "23000-7070", "7839", "Edward Fields" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "84",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Falkland Islands (Malvinas)", "East Mozellehaven", "88296-0601", "365", "King Fords" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "85",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Kuwait", "New Martinechester", "76422", "6390", "Murphy Meadows" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "86",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Brazil", "East Nia", "76457", "2292", "Anibal Forges" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "87",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Turks and Caicos Islands", "East Weldonburgh", "38007", "92715", "Jamil Run" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "88",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Lithuania", "Rodrigueztown", "13739-5139", "1265", "Bauch Villages" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "89",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Myanmar", "South Darrenshire", "05402", "54891", "Aliya Mill" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "90",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Greenfelder - Schmeler", "Neil81@gmail.com", "Letitia", "Kirlin", "900-364-2937", "qV28VHvV3j" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "91",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Koss - Hintz", "Wendy.Stamm@gmail.com", "Christy", "Schinner", "322-261-3587", "6QTBKSw_9j" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "92",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Stark, Luettgen and Johnson", "Julia.Olson@gmail.com", "Chet", "O'Hara", "851-357-3239", "sRECeZkDFK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "93",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Rice, Howe and Oberbrunner", "Arianna.Heller45@yahoo.com", "Rosalind", "Lubowitz", "852-680-6976", "PUwPlXTyyV" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "94",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Anderson - Hyatt", "Gus.Herman25@yahoo.com", "Maye", "Blick", "323-249-6000", "Ydksm7GiwY" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "95",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Bayer - Bosco", "Bessie.Skiles6@yahoo.com", "Marc", "Tremblay", "991-261-0246", "ZpEBuZvlbw" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "96",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Heathcote - Hansen", "Ethan.Skiles32@yahoo.com", "Diego", "Bashirian", "564-248-1772", "LIx80YLshA" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "97",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Kilback and Sons", "Leonel_Marvin82@yahoo.com", "Salma", "Schultz", "470-610-1655", "wAFY8yPhBZ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "98",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Bosco Group", "Deron.Ullrich@hotmail.com", "Gianni", "Predovic", "947-987-8661", "wpYya_FxTD" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "99",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Harvey LLC", "Harrison.Shields97@gmail.com", "Effie", "Crona", "548-418-6282", "Ko1y6GYksW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "70",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Braulio_Simonis@yahoo.com", "Jonatan", 1, "Orn", "Sn4RbNkrgB" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Marian84@yahoo.com", "Jermain", "Emard", "FbYKyz18VZ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "72",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Brandy_Hermann76@gmail.com", "Anastacio", 3, "Mosciski", "_mTN520f_d" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Kole32@yahoo.com", "Lela", "Murazik", "FvdcjJSf2b" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "74",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Randy_Harber@hotmail.com", "Ervin", 1, "Wolff", "O_1KwpvdkE" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Ramon_Cole@yahoo.com", "Helmer", "Ward", "p9F3IiKszX" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "76",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Maximillian87@yahoo.com", "Eugenia", 1, "Beatty", "ITZ8gyVEc4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Bradly3@yahoo.com", "Sanford", "Corwin", "kVykP0QfkL" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "78",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Sally80@gmail.com", "Pink", 3, "Hilpert", "ocsqV3BB9l" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Nadia25@yahoo.com", "Jamison", 3, "Hegmann", "pc2vRqbZPr" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "51",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Werner76@gmail.com", "Francis", "Satterfield", "1eCP5ZlVSt" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "53",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Kenyatta44@gmail.com", "Rory", "Kautzer", "Q4Av61bfds" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "55",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Destiney_Hand@hotmail.com", "Ashlee", "Collins", "yTdrEiEly_" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "57",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Cooper34@yahoo.com", "Noel", "Haley", "uKAPQsppV0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "59",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jaqueline_Stanton@yahoo.com", "Dayna", "Boyle", "RU80DFRML2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Nannie2@gmail.com", "Idella", "Skiles", "c0q0X0opUo" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Trystan21@gmail.com", "Muriel", "Ruecker", "IyDX8AhS2V" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Cyril28@gmail.com", "Giuseppe", "Miller", "P7pQq10qon" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Cielo.Effertz51@hotmail.com", "Betsy", "Nienow", "qkLKrKDy2A" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Buck_Parisian@yahoo.com", "Ladarius", "Monahan", "wBalHUk8V_" });

            migrationBuilder.CreateIndex(
                name: "IX_DriverLicense_LicensesId",
                table: "DriverLicense",
                column: "LicensesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DriverLicense");

            migrationBuilder.AddColumn<string>(
                name: "DriverMatricule",
                table: "User",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "80",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Italy", "West Michel", "87812-6339", "1339", "Monroe Islands" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "81",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Holy See (Vatican City State)", "Todberg", "60938", "70509", "Norma Village" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "82",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Mali", "Port Merlmouth", "85529", "4858", "Sporer Mall" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "83",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Algeria", "Chaunceyborough", "48102-6198", "3549", "Schowalter Row" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "84",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Cote d'Ivoire", "North Cindy", "86039", "44084", "Hassie Shores" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "85",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Sao Tome and Principe", "West Imaland", "50710-5896", "70663", "Bode Mountain" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "86",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Mauritius", "Wilkinsonfort", "43186", "11517", "Cummerata Ville" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "87",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "French Polynesia", "East Monserratehaven", "87076-4412", "137", "Carroll Road" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "88",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Guinea-Bissau", "Kihnview", "80726", "2006", "Reed Place" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "89",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Qatar", "Danielbury", "38809", "956", "Larkin Spring" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "90",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Smith LLC", "Ayla_Gleason@yahoo.com", "Ruthie", "Hettinger", "631-912-4670", "dE6mnFsXi4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "91",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Lindgren, Lang and Anderson", "Elroy.Wunsch53@yahoo.com", "Brant", "Kirlin", "393-213-0590", "gDLBGE8y1s" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "92",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Abernathy and Sons", "Wanda_Mosciski26@hotmail.com", "Jazmyne", "Hane", "997-757-6890", "9zZPKexgd4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "93",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "VonRueden Group", "Ernie4@gmail.com", "Whitney", "Beier", "747-762-3446", "CuYqZ4U5dk" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "94",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Dickinson and Sons", "Watson_Blick@gmail.com", "Delmer", "Keeling", "368-754-7247", "uKVao0YePZ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "95",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Feil - Blanda", "Buford63@yahoo.com", "Amiya", "Russel", "607-634-8165", "DoEph07ykM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "96",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Hegmann, Stracke and Ward", "Dandre_Schiller38@yahoo.com", "Lilly", "Hane", "992-356-8699", "F7Wa6j5vpD" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "97",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Green LLC", "Karelle9@hotmail.com", "Kale", "Ebert", "494-731-4889", "86FwWPislI" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "98",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Monahan, Prosacco and Tromp", "Kassandra_Klocko@yahoo.com", "Gerald", "Krajcik", "246-421-9051", "x2_pps5fxU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "99",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Wiegand and Sons", "Cloyd27@hotmail.com", "Bertrand", "Halvorson", "369-443-6870", "oaQJkehrFV" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "70",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Robbie.Terry14@hotmail.com", "Emilie", 3, "Carroll", "YNTLmzs6LQ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Dulce61@hotmail.com", "Jovan", "Prohaska", "dx5UyzfqFV" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "72",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Eriberto19@yahoo.com", "August", 2, "Bosco", "Vc0qj5_soV" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jessyca.Stanton@yahoo.com", "Hunter", "McKenzie", "U3aKHJVFLG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "74",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Ibrahim_Schulist83@gmail.com", "Phyllis", 2, "Gerhold", "QQNf1gZ0_F" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Florine_Leffler@hotmail.com", "Erna", "Huels", "8CEZ9TxK85" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "76",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Damien_Leuschke@hotmail.com", "Berry", 2, "Buckridge", "RmnbzjVGk7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Alden_Murazik@hotmail.com", "Rowan", "Durgan", "sfmjRJv8rE" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "78",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Pierre_Huels38@hotmail.com", "Eldred", 2, "Cormier", "jgNNIy58eS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Israel.Hilll2@gmail.com", "Alayna", 1, "Fritsch", "XpMUXTvBBU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "51",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Tyler.Trantow20@yahoo.com", "Wilhelm", "Kuhlman", "CPBan1hjCw" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "53",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Cristal.Macejkovic54@hotmail.com", "Idella", "Koepp", "XQImEP2Sml" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "55",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jany_Littel83@yahoo.com", "Arely", "Stanton", "zN6nJvikjF" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "57",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Wiley0@gmail.com", "Arjun", "Ondricka", "LdQUo1Gg0u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "59",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Bo_Kirlin33@hotmail.com", "Bernard", "Sanford", "s2OpgAVQXn" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Beaulah74@gmail.com", "Dayne", "Kuhlman", "fnXQFF1y7h" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Dedrick83@hotmail.com", "Alexandre", "Wyman", "1RxYwlJkmH" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Zelda85@hotmail.com", "Kenya", "Weissnat", "fwUAP3UFL_" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Gwen_Rosenbaum71@hotmail.com", "Bertha", "Osinski", "W81PQi4zkh" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Iva75@yahoo.com", "Isai", "Berge", "nVK4z_DjH7" });

            migrationBuilder.CreateIndex(
                name: "IX_User_DriverMatricule",
                table: "User",
                column: "DriverMatricule");

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_DriverMatricule",
                table: "User",
                column: "DriverMatricule",
                principalTable: "User",
                principalColumn: "Matricule");
        }
    }
}
