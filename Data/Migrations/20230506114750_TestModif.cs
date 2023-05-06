using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class TestModif : Migration
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

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    Plate = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicensesId = table.Column<int>(type: "int", nullable: false),
                    Payload = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.Plate);
                    table.ForeignKey(
                        name: "FK_Trucks_License_LicensesId",
                        column: x => x.LicensesId,
                        principalTable: "License",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "IdAddress", "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[,]
                {
                    { "50", "Norfolk Island", "Connland", "26685-3848", "61700", "Schneider Plains" },
                    { "51", "Slovakia (Slovak Republic)", "New Sebastian", "72159", "5986", "Bosco Forks" },
                    { "52", "Belgium", "Friesenfurt", "29613-6738", "980", "Demond Track" },
                    { "53", "Finland", "South Ardenborough", "01426-5588", "2923", "Tiara Cove" },
                    { "54", "Bahamas", "New Yesseniabury", "17316-5466", "709", "Howell Manors" },
                    { "55", "Philippines", "South Reggie", "14517-4093", "547", "Raquel Lock" },
                    { "56", "Falkland Islands (Malvinas)", "Adelbertton", "97961-2222", "2111", "Dallas Mountains" },
                    { "57", "United Arab Emirates", "East Stephonville", "73406", "7919", "Feest Ramp" },
                    { "58", "Croatia", "New Amberhaven", "74493", "179", "Marcelino Terrace" },
                    { "59", "Vietnam", "Lake Michaleburgh", "14514", "775", "Hand Centers" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "40", "Katlyn.Lynch91@gmail.com", "Rowland", "Herzog", "CHUKMz8opX", "Dispatcher" },
                    { "41", "Skylar_Abshire80@gmail.com", "Kellen", "Beahan", "h0fK4dY8o3", "Dispatcher" },
                    { "42", "Casey.Considine@gmail.com", "Burdette", "Willms", "gLwoqtBXux", "Dispatcher" },
                    { "43", "Jacques61@yahoo.com", "Novella", "White", "lSW2KgWgf4", "Dispatcher" },
                    { "44", "Albina17@yahoo.com", "Dario", "Huel", "5h7tu_LMUm", "Dispatcher" },
                    { "45", "Cheyenne.Reichel@yahoo.com", "Otilia", "Hartmann", "wLoiXaMD6i", "Dispatcher" },
                    { "46", "Dayne.King@gmail.com", "Aletha", "Russel", "JB6j8KEUe1", "Dispatcher" },
                    { "47", "Yvonne81@yahoo.com", "Pearlie", "Gibson", "MFWE7agdEj", "Dispatcher" },
                    { "48", "Yazmin.Krajcik25@yahoo.com", "Chad", "Davis", "U_PWXpJZu2", "Dispatcher" },
                    { "49", "Domenico.Senger81@gmail.com", "Albert", "Dibbert", "SyVLvmESUZ", "Dispatcher" },
                    { "30", "Jasmin_Braun@yahoo.com", "Mikayla", "Gaylord", "uexyoim7Tc", "Driver" },
                    { "31", "Bria_Marquardt@yahoo.com", "Makenzie", "Pollich", "4Y4Tlrfjjd", "Driver" },
                    { "32", "London_King80@yahoo.com", "Hortense", "Labadie", "bePGNsIAXq", "Driver" },
                    { "33", "Lucie.Kunze@gmail.com", "Norris", "Cassin", "zN5Udy9cvV", "Driver" },
                    { "34", "Freeman_Kuvalis@gmail.com", "Ila", "Trantow", "l7MZJPP2Oy", "Driver" },
                    { "35", "Hallie42@hotmail.com", "Junius", "Gibson", "pg0HhmUx9D", "Driver" },
                    { "36", "Mose_Miller1@yahoo.com", "Annamarie", "Reichel", "IgjuyYDzA3", "Driver" },
                    { "37", "Samir40@hotmail.com", "Lorena", "Wiza", "UNrENC90ky", "Driver" },
                    { "38", "Keyshawn51@yahoo.com", "Fannie", "Rau", "WpCTOVgIh7", "Driver" },
                    { "39", "Coty.Johns@hotmail.com", "Alba", "Franecki", "KqpIVM3nnB", "Driver" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_LicensesId",
                table: "Trucks",
                column: "LicensesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trucks");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "50");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "51");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "52");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "53");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "54");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "55");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "56");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "57");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "58");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
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
                table: "User",
                keyColumn: "Matricule",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "31");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "32");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "33");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "34");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "35");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "36");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "37");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "38");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "39");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "IdAddress", "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[,]
                {
                    { "60", "Russian Federation", "North Lou", "48349", "6726", "Cassidy Avenue" },
                    { "61", "Svalbard & Jan Mayen Islands", "South Marcos", "82122-6127", "9350", "Schowalter Union" },
                    { "62", "American Samoa", "Port Brigitte", "79338", "52797", "Ola Street" },
                    { "63", "Saint Helena", "Prohaskastad", "08713", "4960", "Jerod Lake" },
                    { "64", "Angola", "South Alyson", "11476-4355", "41539", "Adele Terrace" },
                    { "65", "New Zealand", "Port Estebanville", "65548-8295", "582", "Rosenbaum Forges" },
                    { "66", "Kuwait", "New Kraigfurt", "42410-2502", "4513", "Joana Coves" },
                    { "67", "South Africa", "Mckenzieton", "09267", "03435", "Greenholt Summit" },
                    { "68", "Algeria", "Jessycaton", "76118-9718", "703", "Schaefer Mission" },
                    { "69", "Bhutan", "Russelville", "29489", "1578", "Schmeler Pass" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "50", "Seamus_Marvin@yahoo.com", "Daron", "Goodwin", "F96W8StFtx", "Dispatcher" },
                    { "51", "Carol.Connelly@hotmail.com", "Keyon", "Pouros", "yIuqlliiFc", "Dispatcher" },
                    { "52", "Kris30@yahoo.com", "Zella", "Wunsch", "kzHgSIXXmV", "Dispatcher" },
                    { "53", "Aletha.Johnson43@hotmail.com", "Gennaro", "O'Hara", "k1Ib2QGpNF", "Dispatcher" },
                    { "54", "Deven16@gmail.com", "Jannie", "Stoltenberg", "MEn4OEH_k4", "Dispatcher" },
                    { "55", "Marielle.Ortiz80@yahoo.com", "Ari", "Huels", "_OWSQCae5r", "Dispatcher" },
                    { "56", "Maximo_Mann@yahoo.com", "Linnea", "Cruickshank", "emwE3_XS1c", "Dispatcher" },
                    { "57", "Rashawn.Gorczany@hotmail.com", "Hailie", "Roob", "2tjcXj3OWG", "Dispatcher" },
                    { "58", "Tressie62@yahoo.com", "Yolanda", "Heaney", "I_tFy7un4T", "Dispatcher" },
                    { "59", "Al11@gmail.com", "Dorris", "Hartmann", "1FbcZXDsSK", "Dispatcher" },
                    { "40", "Mia.Hegmann78@gmail.com", "Ari", "Towne", "iis3mbTU_J", "Driver" },
                    { "41", "Rahul.Ryan@yahoo.com", "Bryce", "Weber", "FluObpMySQ", "Driver" },
                    { "42", "Elliott.Klocko59@hotmail.com", "Laverne", "Gleason", "J9tn4YOiGD", "Driver" },
                    { "43", "Alayna92@hotmail.com", "Devante", "Franecki", "aa79IAnyQu", "Driver" },
                    { "44", "Eulalia_Cronin@yahoo.com", "Yasmine", "Thiel", "Xuzq6M7ZC4", "Driver" },
                    { "45", "Carmel_Legros23@gmail.com", "Armando", "Bogisich", "SHrbDJ2vGy", "Driver" },
                    { "46", "Norberto.Considine15@hotmail.com", "Olin", "Johnson", "pZZxSvMhGt", "Driver" },
                    { "47", "Amanda37@gmail.com", "Richmond", "Ritchie", "9hJZUJebEJ", "Driver" },
                    { "48", "Rudy.Kreiger@hotmail.com", "Lawson", "Kassulke", "sB0cUCbU7U", "Driver" },
                    { "49", "Kamron.Corkery@hotmail.com", "Lonnie", "Borer", "VjERNCVWtE", "Driver" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "CompanyAddressId", "CompanyName", "Email", "FirstName", "Name", "Number", "Password", "Role" },
                values: new object[,]
                {
                    { "70", "60", "Nikolaus Inc", "Breanna.Hoppe33@yahoo.com", "Jenifer", "Schimmel", "477-494-5965", "DZ0VPIVozW", "Client" },
                    { "71", "61", "Walter - Nitzsche", "Genesis94@gmail.com", "Bernardo", "Kautzer", "541-411-4812", "k7A01paGTG", "Client" },
                    { "72", "62", "Barrows Inc", "Roosevelt0@hotmail.com", "Lauriane", "Mayer", "273-607-7095", "zjl2UdPNvv", "Client" },
                    { "73", "63", "Skiles, Stroman and Hills", "Kyleigh9@hotmail.com", "Julianne", "Erdman", "964-735-3836", "EjWTr4STOI", "Client" },
                    { "74", "64", "Heathcote Inc", "Mireya.Haley19@yahoo.com", "Jalen", "Reinger", "279-953-3500", "mBJvOS8SZ1", "Client" },
                    { "75", "65", "Zieme, Jerde and Simonis", "Gregorio_Huels67@hotmail.com", "Mia", "Kirlin", "717-251-9819", "MDcYZ3Wafi", "Client" },
                    { "76", "66", "Wehner - Mosciski", "Baron.Zulauf@yahoo.com", "Carolyne", "Jaskolski", "629-225-9968", "QenYc_FXP2", "Client" },
                    { "77", "67", "McGlynn - Schroeder", "Teagan_Lesch63@hotmail.com", "Carolina", "Weber", "219-446-0641", "mUSq0qJL83", "Client" },
                    { "78", "68", "Wolff - Cole", "Virgie94@yahoo.com", "Maci", "Hegmann", "489-338-8948", "L62Oz2ytD9", "Client" },
                    { "79", "69", "Zulauf Group", "Akeem.McKenzie1@hotmail.com", "Dwight", "Bartoletti", "987-522-2456", "C0pJ0H_rTc", "Client" }
                });
        }
    }
}
