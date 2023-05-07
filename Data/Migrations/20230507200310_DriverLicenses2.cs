using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DriverLicenses2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: "60");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "61");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "62");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "63");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "64");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "65");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "66");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "67");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "68");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "69");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "IdAddress", "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[,]
                {
                    { "80", "Cook Islands", "West Kaitlyntown", "55655-4733", "8297", "Maximillia Spring" },
                    { "81", "Guam", "Veumville", "17369", "74095", "Roberts Center" },
                    { "82", "Saint Barthelemy", "Marksbury", "80442-7490", "234", "Florida Summit" },
                    { "83", "Cote d'Ivoire", "Jazminton", "39658", "57328", "Steuber Crescent" },
                    { "84", "Svalbard & Jan Mayen Islands", "Cristianfurt", "25290-1750", "47589", "Dandre Lakes" },
                    { "85", "Benin", "South Isaiahhaven", "40708-6518", "97328", "Frami Mount" },
                    { "86", "Norway", "Brentfort", "16921-4600", "412", "Marley Haven" },
                    { "87", "Myanmar", "New Anissa", "85288-9313", "6077", "Eleanore Parks" },
                    { "88", "American Samoa", "South Celestino", "13035-6676", "347", "Stroman Coves" },
                    { "89", "Aruba", "DuBuquechester", "54965", "2691", "Smitham Lake" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "IdCertification", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "70", "Taya_Adams56@hotmail.com", "Clement", 2, "Pacocha", "DuJ31naY23", "Dispatcher" },
                    { "71", "Fermin.Grady@hotmail.com", "Josefa", 3, "Wiza", "rwx706ajbH", "Dispatcher" },
                    { "72", "Jaycee79@hotmail.com", "Shakira", 1, "Abernathy", "JR241bnSaW", "Dispatcher" },
                    { "73", "Linnea_Casper@yahoo.com", "Fiona", 3, "Gaylord", "r3pz2TlN58", "Dispatcher" },
                    { "74", "Jalen.Bartell21@hotmail.com", "Evie", 1, "Littel", "blHIbHQOxd", "Dispatcher" },
                    { "75", "Julius.Johnston77@gmail.com", "Melody", 3, "Muller", "jL1GbC9afM", "Dispatcher" },
                    { "76", "Einar.Conn@gmail.com", "Maudie", 1, "Stehr", "86WFKFV2fh", "Dispatcher" },
                    { "77", "Richard_Schaden@gmail.com", "Dale", 2, "Christiansen", "_ZRSqKm9LG", "Dispatcher" },
                    { "78", "Jennie96@gmail.com", "Idella", 2, "Feil", "KnKD2ZCjbq", "Dispatcher" },
                    { "79", "Winona_Schumm@hotmail.com", "Tanya", 1, "Stiedemann", "6XNXkHEOxd", "Dispatcher" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "51", "Estelle.Lueilwitz34@yahoo.com", "Ila", "Lehner", "XLUo_5ui_m", "Driver" },
                    { "53", "Ayana47@yahoo.com", "Sylvester", "Lowe", "zi_el4GT1s", "Driver" },
                    { "55", "Easton_Marquardt@gmail.com", "Susie", "Considine", "wE3QhD2iSm", "Driver" },
                    { "57", "Kaitlin_Jones30@yahoo.com", "Jerad", "Kuhn", "ojK_gQoGMi", "Driver" },
                    { "59", "Paula.Ankunding18@hotmail.com", "Nola", "Bartell", "Xk3iN3Mymj", "Driver" },
                    { "61", "Brandy9@yahoo.com", "Ramiro", "Stoltenberg", "gGhtEDeZWn", "Driver" },
                    { "63", "Liam_Von19@hotmail.com", "Sammy", "Hahn", "97t6Ts332u", "Driver" },
                    { "65", "Mathew65@yahoo.com", "Chelsea", "Pollich", "tHMpWr8Izi", "Driver" },
                    { "67", "Assunta_Mills@yahoo.com", "Alia", "Kub", "PRvJMOcX8A", "Driver" },
                    { "69", "Alanna_Sanford@yahoo.com", "Jonatan", "Cummerata", "hG8FJYUnNe", "Driver" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "CompanyAddressId", "CompanyName", "Email", "FirstName", "Name", "Number", "Password", "Role" },
                values: new object[,]
                {
                    { "90", "80", "Corkery - Howe", "Aisha.Schroeder9@hotmail.com", "Giovanna", "Kub", "433-381-7173", "bflnMimTDy", "Client" },
                    { "91", "81", "Kovacek - Abbott", "Zachariah.Labadie4@gmail.com", "Ila", "Steuber", "834-667-8046", "0pyD0CysEn", "Client" },
                    { "92", "82", "Jast - Nader", "Jaylen27@gmail.com", "Ocie", "Von", "955-361-8919", "6NfxBpBjq4", "Client" },
                    { "93", "83", "Rau, Ernser and McCullough", "Marcos.Kunze@yahoo.com", "Reinhold", "Ebert", "612-539-7958", "vOjyRy6aLE", "Client" },
                    { "94", "84", "Ward - Gerhold", "Jaleel_Ferry@gmail.com", "Kimberly", "Wehner", "802-993-1306", "FEjxJuPdfU", "Client" },
                    { "95", "85", "Harber Inc", "Cody6@hotmail.com", "Noel", "Bauch", "382-772-7841", "HndsjUqRsk", "Client" },
                    { "96", "86", "Hansen, Volkman and Armstrong", "Rosemary.Hudson7@hotmail.com", "Freeda", "Reilly", "224-631-6678", "x_NEJrjifO", "Client" },
                    { "97", "87", "O'Reilly, Deckow and Hoppe", "Cordelia.Gislason@gmail.com", "Tia", "Hamill", "638-564-8244", "qOTlZO6gAi", "Client" },
                    { "98", "88", "Luettgen - O'Keefe", "Gillian_Wisoky22@gmail.com", "Bell", "Breitenberg", "843-974-6986", "hzKhaqPbaf", "Client" },
                    { "99", "89", "Schuster - Prosacco", "Ewell.OConnell25@hotmail.com", "Malvina", "Johnson", "797-898-9904", "THC8i2a9fp", "Client" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "90");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "91");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "92");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "93");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "94");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "95");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "96");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "97");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "98");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "99");

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
                keyValue: "51");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "53");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "55");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "57");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "59");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "80");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "81");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "82");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "83");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "84");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "85");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "86");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "87");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "88");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "89");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "IdAddress", "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[,]
                {
                    { "60", "Macedonia", "Calichester", "68696-3416", "633", "Zieme Divide" },
                    { "61", "Serbia", "Jessycashire", "00995", "404", "Nadia Mission" },
                    { "62", "Honduras", "West Emmet", "55811", "62542", "Catalina Vista" },
                    { "63", "Dominican Republic", "Port Sophia", "76328", "4201", "Caleigh Mills" },
                    { "64", "Liechtenstein", "Johathanburgh", "20731", "1294", "Huels Mission" },
                    { "65", "Sao Tome and Principe", "New Jettie", "43774-0715", "9286", "Bashirian Ridge" },
                    { "66", "Armenia", "Lake Marlene", "32297-4596", "253", "Tina Hill" },
                    { "67", "New Zealand", "North Arnulfoberg", "36955-7457", "33324", "Eva Alley" },
                    { "68", "Kuwait", "Cleoraport", "26130-3398", "556", "Terry Mill" },
                    { "69", "Puerto Rico", "Torphychester", "85661", "582", "Stefan Spring" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "IdCertification", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "50", "Floy.Kunze@gmail.com", "Garrick", 2, "Gulgowski", "M9x1zLE2tv", "Dispatcher" },
                    { "51", "Abel51@yahoo.com", "Rosina", 3, "Bernier", "nruam4nvAK", "Dispatcher" },
                    { "52", "Maria67@gmail.com", "Kelton", 3, "Legros", "BDtH1fngZr", "Dispatcher" },
                    { "53", "Krystina48@hotmail.com", "Jettie", 3, "Toy", "fvUkDjJHgM", "Dispatcher" },
                    { "54", "Emmett63@yahoo.com", "Micaela", 2, "Crist", "RJ46HEzURC", "Dispatcher" },
                    { "55", "Giles.Cremin54@gmail.com", "Sydni", 1, "Carroll", "R4QHsoHRyP", "Dispatcher" },
                    { "56", "Ella.Hayes87@gmail.com", "Alexie", 3, "Flatley", "RnpGhao5is", "Dispatcher" },
                    { "57", "Regan36@hotmail.com", "Santina", 3, "Robel", "x6ENKeWsa1", "Dispatcher" },
                    { "58", "Cathrine_Gorczany@yahoo.com", "Tate", 2, "Fisher", "fwBlwgZsLb", "Dispatcher" },
                    { "59", "Johnny90@hotmail.com", "Deontae", 2, "Abshire", "xPaD8KW4un", "Dispatcher" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "40", "Dillon.Witting44@hotmail.com", "Alanna", "Lueilwitz", "jYOWiJS72n", "Driver" },
                    { "41", "Amina.Bode@yahoo.com", "Lesly", "Pagac", "S2NR8YEx2w", "Driver" },
                    { "42", "Justice68@hotmail.com", "Josiah", "Fahey", "RuuIq74htU", "Driver" },
                    { "43", "Bryce_Brown@yahoo.com", "Jaiden", "Stroman", "8LTgfFo4b9", "Driver" },
                    { "44", "Susan74@yahoo.com", "Alessia", "Hettinger", "U0_t57dOfo", "Driver" },
                    { "45", "Laurianne7@yahoo.com", "Zetta", "Greenholt", "6CDVlTGUXs", "Driver" },
                    { "46", "William.Streich@gmail.com", "Carrie", "Gerhold", "mn_je0SFzZ", "Driver" },
                    { "47", "Hector15@yahoo.com", "Reta", "Moore", "F0xS1WATzG", "Driver" },
                    { "48", "Elvera_Luettgen@hotmail.com", "Derek", "Ankunding", "pROGP8O1q0", "Driver" },
                    { "49", "Oda.Kohler@hotmail.com", "Susan", "Langosh", "OGdywpJpWU", "Driver" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "CompanyAddressId", "CompanyName", "Email", "FirstName", "Name", "Number", "Password", "Role" },
                values: new object[,]
                {
                    { "70", "60", "Emmerich Inc", "Christopher_Kuvalis5@gmail.com", "Malcolm", "Lehner", "463-244-9358", "l5DXQAoHDG", "Client" },
                    { "71", "61", "Lang Inc", "Baylee45@hotmail.com", "Kay", "Stracke", "556-445-0142", "FWlxISk3pu", "Client" },
                    { "72", "62", "Borer LLC", "Helena.Hammes@yahoo.com", "Mylene", "Senger", "361-632-2598", "8Ifn_KOQOC", "Client" },
                    { "73", "63", "Feest, Paucek and Daniel", "Dino.Stark@yahoo.com", "Arlene", "Hagenes", "954-761-9577", "fEkcKgXf2G", "Client" },
                    { "74", "64", "Cassin, Price and Hahn", "Liliane.Gislason65@gmail.com", "Sherman", "Cole", "933-647-4689", "M0B4prOqHn", "Client" },
                    { "75", "65", "Goodwin Inc", "Geovany.Brekke@hotmail.com", "Weston", "Yost", "610-896-5198", "pcJP5g5Y7O", "Client" },
                    { "76", "66", "Boyle, O'Connell and Hand", "Geraldine.Mertz25@yahoo.com", "Foster", "Altenwerth", "273-507-4887", "oO4DXXUZmv", "Client" },
                    { "77", "67", "Torp and Sons", "Kaylah_Schaefer@gmail.com", "Charles", "Trantow", "512-951-9789", "qcudC_vcfX", "Client" },
                    { "78", "68", "Huels - Ferry", "Cassidy.Krajcik71@yahoo.com", "Brandy", "McClure", "508-374-6410", "FqiHhrycfS", "Client" },
                    { "79", "69", "Bradtke - Towne", "Martine66@hotmail.com", "Helga", "Kassulke", "867-998-9303", "jVOqA5OiPu", "Client" }
                });
        }
    }
}
