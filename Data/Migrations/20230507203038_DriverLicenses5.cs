using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DriverLicenses5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DriverLicenses");

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
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Robbie.Terry14@hotmail.com", "Emilie", "Carroll", "YNTLmzs6LQ" });

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
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Jessyca.Stanton@yahoo.com", "Hunter", 1, "McKenzie", "U3aKHJVFLG" });

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
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Florine_Leffler@hotmail.com", "Erna", 2, "Huels", "8CEZ9TxK85" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "76",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Damien_Leuschke@hotmail.com", "Berry", "Buckridge", "RmnbzjVGk7" });

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
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Israel.Hilll2@gmail.com", "Alayna", "Fritsch", "XpMUXTvBBU" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "DriverLicenses",
                columns: table => new
                {
                    DriversMatricule = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LicensesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverLicenses", x => new { x.DriversMatricule, x.LicensesId });
                    table.ForeignKey(
                        name: "FK_DriverLicenses_Licenses_LicensesId",
                        column: x => x.LicensesId,
                        principalTable: "Licenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DriverLicenses_User_DriversMatricule",
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
                values: new object[] { "Wallis and Futuna", "Hanemouth", "11164-8773", "25468", "Labadie Plains" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "81",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Northern Mariana Islands", "Schummbury", "83424-2076", "4810", "Schuster Mill" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "82",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Puerto Rico", "Willport", "86647", "2765", "O'Kon Trace" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "83",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Saint Pierre and Miquelon", "South Elbert", "19479-0222", "16943", "Homenick Mission" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "84",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Serbia", "North Ellsworthport", "19940-5255", "9532", "Doyle Pike" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "85",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Niue", "DuBuqueshire", "74519", "036", "Stiedemann Shore" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "86",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Malta", "West Lilliana", "08462-1943", "280", "Jeanie Landing" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "87",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Turks and Caicos Islands", "Karliestad", "33488-7666", "573", "Torrey Streets" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "88",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Macao", "Lake Matt", "25743-9440", "90284", "Tommie Extensions" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "89",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Tanzania", "North Scottiechester", "27517-2485", "8370", "Schmeler Green" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "90",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "West - Cummerata", "Tiara48@hotmail.com", "Sven", "Jacobi", "344-414-0660", "uyNDyPoWE7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "91",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Jones LLC", "Mollie.Skiles@hotmail.com", "Roderick", "Cronin", "209-843-9907", "c13vZzzix5" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "92",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Dach - Rowe", "Braden_Hoeger@gmail.com", "Sean", "Block", "650-591-6928", "mXhjNrZhQR" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "93",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Morar - Torphy", "Fiona92@gmail.com", "Norberto", "Crooks", "468-678-8516", "MNKdYAncCJ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "94",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Hoppe, Cremin and Graham", "Shaun8@yahoo.com", "Javon", "Robel", "534-362-1026", "24edQjYZm0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "95",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Kerluke - Schmitt", "Ellis_Raynor@yahoo.com", "Eliane", "King", "332-773-8864", "r2MttT3SMu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "96",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Lynch - Huel", "Lizzie_Greenholt87@hotmail.com", "Esmeralda", "Ondricka", "471-213-2140", "JVMBZGs48r" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "97",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Goyette, Bogisich and Vandervort", "Anibal70@gmail.com", "Alysson", "Romaguera", "682-252-2498", "7yojvN7FWM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "98",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Wilderman, Abernathy and Little", "Katharina_Nikolaus9@yahoo.com", "Myra", "Roberts", "292-378-5916", "PepIsu3Cui" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "99",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Wisoky LLC", "Marcelino.McCullough74@yahoo.com", "Linnea", "Dicki", "235-245-7990", "DS2_msLpD9" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "70",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Duncan_Paucek94@gmail.com", "Benton", "Kozey", "CGzDIbX0P6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Desmond66@yahoo.com", "Jared", "Grady", "TkGukye3is" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "72",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Stephanie.Reynolds@gmail.com", "Toy", 3, "Buckridge", "UHcEKkENZC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Rusty.Casper38@hotmail.com", "Myra", 2, "Osinski", "ni1ka0tdCc" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "74",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Presley_Walter3@yahoo.com", "Kristofer", 1, "Gusikowski", "NMSqxZjodi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Claude_Schroeder@hotmail.com", "Scotty", 3, "Kirlin", "2mHqrvTUrp" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "76",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Shanie61@hotmail.com", "Carmella", "Hyatt", "qo7z_QFHhd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Vita22@hotmail.com", "Darrin", "Windler", "0NRlKpKVF2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "78",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Buford.Wilderman@yahoo.com", "Cayla", 3, "Howell", "YJQ3D9jpnd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Alysa.Hickle@yahoo.com", "Magali", "Erdman", "MxqOlmwnGk" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "51",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Stan.Hahn30@yahoo.com", "Hal", "Schamberger", "Ddd1Noo00R" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "53",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Moriah64@hotmail.com", "Malinda", "Sauer", "WpoltY0zwv" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "55",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Bertrand67@yahoo.com", "Bell", "Renner", "6_FVoaAJWA" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "57",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Kristin.Wintheiser@yahoo.com", "Karolann", "Purdy", "0a9DFNOuAD" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "59",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Herman85@hotmail.com", "Cortez", "Schinner", "SBR4ELcYZE" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Golden_Breitenberg65@yahoo.com", "Jaleel", "Kunze", "ww4i5mHeme" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Bianka.Kirlin@gmail.com", "Ethel", "Schimmel", "95AbXHapZ2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Karli29@hotmail.com", "Veda", "Will", "EoZBTobB96" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Kristian_Metz40@hotmail.com", "Gudrun", "Carroll", "F_zYUjSMX_" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Adell61@hotmail.com", "Boris", "Ritchie", "YYXUOZaQnZ" });

            migrationBuilder.CreateIndex(
                name: "IX_DriverLicenses_LicensesId",
                table: "DriverLicenses",
                column: "LicensesId");
        }
    }
}
