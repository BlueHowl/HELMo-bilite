using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DeliveryIncomplet6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "9ULQWAS6LIAQ68485");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "AWYXE18XE7C528931");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "B0G6WMO94BM157815");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "D128QHJH5EZP88040");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "GWWCBTYW04E928347");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "JX5INS7LBOMT93516");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "MZ1KYNSSS8SN29023");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "MZ9CVGLPJ2UR51277");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "OB0TAJZ3QUWS99021");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "SQEN43DTK2JJ33978");

            migrationBuilder.AddColumn<string>(
                name: "IdVehicule",
                table: "Deliveries",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "90",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Australia", "Siennafort", "17340", "9540", "Tyra Cape" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "91",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Virgin Islands, British", "Stantonport", "12894-8358", "8447", "Clemmie Loaf" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "92",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Dominican Republic", "Ashahaven", "99743-6360", "84627", "Kovacek Club" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "93",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Ukraine", "Langborough", "25046", "6997", "McCullough Grove" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "94",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Palestinian Territory", "East Marciamouth", "82891-6062", "53459", "Laurie Corners" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "95",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Republic of Korea", "Corneliusview", "19953", "7445", "Conroy Overpass" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "96",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Nauru", "Wadeshire", "97389", "20767", "Gutmann Extensions" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "97",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Andorra", "Aglaeside", "12966", "383", "Kessler Plain" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "98",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Saint Helena", "Mantebury", "88531-6222", "23051", "Hegmann Grove" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "99",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Cocos (Keeling) Islands", "Nehamouth", "67253-1020", "68161", "Thiel Extension" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "100",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Bahringer, Lakin and Rau", "Rosario.Tromp@hotmail.com", "Gene", "Larkin", "888-805-2530", "qSeVkKO1nn" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "101",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Padberg, Kshlerin and Blick", "Ford67@hotmail.com", "Lavada", "Heathcote", "257-287-4774", "pDFn0gPuOX" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "102",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Douglas, Dickens and Runolfsson", "Sam.Hagenes67@gmail.com", "Clay", "Bruen", "420-901-7710", "0Em9ziD0lX" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "103",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Baumbach and Sons", "Dillon99@yahoo.com", "Geraldine", "Stark", "228-399-6120", "WcR4uPWQz1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "104",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Cummings - Stamm", "Yvette.Gutkowski47@gmail.com", "Wilhelm", "Homenick", "743-476-9548", "Vr3pWROTrm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "105",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Halvorson, Koelpin and Altenwerth", "Harold_Zieme@hotmail.com", "Dion", "Goyette", "572-251-4812", "AHuOoUmyoY" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "106",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Kuhn - Mohr", "Felipe62@yahoo.com", "Consuelo", "Zieme", "634-767-0995", "UiUOW9_B5i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "107",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Wiza - Fisher", "Josiah_Bergnaum@gmail.com", "Tom", "Ankunding", "733-449-5227", "DAiWHKXT31" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "108",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Zemlak, Lemke and Powlowski", "Berta.Barton85@yahoo.com", "Lavinia", "Stanton", "294-518-4196", "UFCl4asu19" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "109",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Bradtke Inc", "Electa7@gmail.com", "Ellsworth", "Hilpert", "504-953-3710", "LRKPRoeZUM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "80",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Leda_Langosh73@yahoo.com", "Ebba", 1, "Wunsch", "KbdvQU8pxw" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "81",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Benjamin86@hotmail.com", "Cesar", 2, "Homenick", "QEH1L3IKlN" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "82",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Faye_Kihn46@hotmail.com", "Dameon", 2, "Streich", "9b0FfN5vDE" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "83",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Paxton12@gmail.com", "Daisy", 3, "Keebler", "cikM7WJmop" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "84",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Lorenza.Schaden@yahoo.com", "Audrey", 3, "Grady", "GCagCPqt0R" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Niko_Turcotte@gmail.com", "Gregoria", 3, "DuBuque", "96uAFQY1ag" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "86",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Ward_Wunsch@hotmail.com", "Genesis", 1, "Goldner", "qmMu34etHC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "87",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Eulalia44@yahoo.com", "Hazle", 1, "Powlowski", "qTSGulnZwh" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "88",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Juliana.Robel@hotmail.com", "Jaylin", 2, "Kuphal", "D1JapCrAmZ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "89",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Elmo.Stiedemann29@gmail.com", "Caleigh", "Haag", "uW6EBuwEBk" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Edwardo_Boyle@gmail.com", "Marvin", "Maggio", "f9Z9OxUIZl" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Edyth_Mills40@gmail.com", "Daniella", "Legros", "3nxsZVqpBq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Eusebio.Dibbert73@gmail.com", "Boris", "Nikolaus", "OybgjNnunD" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jeffery28@yahoo.com", "Marlee", "Olson", "EULzaTI6DN" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Deon.Pfeffer45@hotmail.com", "Alexandria", "Lowe", "0qEpDRrMQp" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Earline_Aufderhar@yahoo.com", "Tessie", "Kerluke", "erkA9TFY1n" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Juwan.Hackett94@gmail.com", "Jada", "Collier", "aT5n0CRbLo" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Vergie_MacGyver10@gmail.com", "Sherwood", "Friesen", "j1VKkZI5ox" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Augustus43@yahoo.com", "Blair", "Ebert", "0Qa1i4ycAi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Rhea_Breitenberg@yahoo.com", "Tony", "Franecki", "E3mVXzlaVQ" });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "6A9LH2QG4UQF26306", "Ford", 3, "Spyder", 22000, null },
                    { "AU778B6PJHNZ88743", "Mercedes Benz", 1, "Roadster", 5000, null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "D58D2GU3EBUW83916", "Aston Martin", 1, "1", 4000, null },
                    { "E6XJ0U58QCVV69017", "Maserati", 3, "LeBaron", 33000, null },
                    { "G8X2IUPB1KPV11836", "Toyota", 1, "Land Cruiser", 19000, null },
                    { "HAD4QHODK4RJ80527", "Fiat", 1, "Spyder", 15000, null },
                    { "NPPMV3YSCITE36620", "Tesla", 1, "Fortwo", 15000, null },
                    { "ODZMJINVI0C078483", "Dodge", 3, "Aventador", 22000, null },
                    { "VE4BS6JS6VB756830", "Ferrari", 2, "Accord", 15000, null },
                    { "X2UZT04BSUSZ92665", "Mini", 2, "Silverado", 29000, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_IdVehicule",
                table: "Deliveries",
                column: "IdVehicule");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Vehicules_IdVehicule",
                table: "Deliveries",
                column: "IdVehicule",
                principalTable: "Vehicules",
                principalColumn: "Plate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Vehicules_IdVehicule",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_IdVehicule",
                table: "Deliveries");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "6A9LH2QG4UQF26306");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "AU778B6PJHNZ88743");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "D58D2GU3EBUW83916");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "E6XJ0U58QCVV69017");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "G8X2IUPB1KPV11836");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "HAD4QHODK4RJ80527");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "NPPMV3YSCITE36620");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "ODZMJINVI0C078483");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "VE4BS6JS6VB756830");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "X2UZT04BSUSZ92665");

            migrationBuilder.DropColumn(
                name: "IdVehicule",
                table: "Deliveries");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "90",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "French Polynesia", "Jazminchester", "22077", "54799", "Kennith Lights" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "91",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Christmas Island", "East Marcellaville", "30113-7333", "8649", "Kira Summit" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "92",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Tanzania", "Heidenreichfort", "21267", "2308", "Trent Village" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "93",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Bouvet Island (Bouvetoya)", "Gottliebmouth", "12937", "2868", "Koch Springs" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "94",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Sierra Leone", "Adrienneview", "52632", "606", "Daniel Shores" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "95",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Bahamas", "North Erwinfurt", "02288-0934", "3084", "Rosalia Summit" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "96",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Greece", "Claratown", "64678-2602", "1075", "Gilberto Junctions" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "97",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Czech Republic", "Alvisborough", "19619", "290", "Mayer Islands" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "98",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Heard Island and McDonald Islands", "Abshirefort", "21828", "11090", "Jones Road" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "99",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "United States Minor Outlying Islands", "Nellamouth", "68625", "8585", "Zulauf Square" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "100",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Deckow - Beahan", "Darron.Abernathy@yahoo.com", "Obie", "Torp", "279-928-8024", "S_3e8RklMI" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "101",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Pfeffer and Sons", "Elinore.Schamberger@yahoo.com", "Oda", "Moen", "527-543-4652", "oNtFlnSzy2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "102",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "DuBuque, Langworth and Vandervort", "Kraig_Schiller@hotmail.com", "Kyra", "O'Hara", "629-676-1999", "96l9EUVOl3" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "103",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Walker, Veum and Gulgowski", "Robbie.Ortiz35@yahoo.com", "Elbert", "Hyatt", "201-404-2502", "KOOXAMWjLH" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "104",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Rohan and Sons", "Hardy.Mueller@hotmail.com", "Dortha", "Stanton", "475-637-1465", "kKQXscDgXF" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "105",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Wintheiser - Reinger", "Petra_King@gmail.com", "Janelle", "Torp", "719-751-2082", "rab0dm0PtI" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "106",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Lesch Inc", "Corene_Collier84@gmail.com", "Tom", "Stamm", "929-765-2821", "XUPi62RUmD" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "107",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Upton - Hansen", "Shemar_Lesch@yahoo.com", "Santa", "Roberts", "285-586-5065", "kATGW7AOgI" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "108",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Zboncak - Gleichner", "Doris.Ankunding@hotmail.com", "Adolfo", "Harber", "528-927-2144", "UWTfImwNHf" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "109",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Dickinson - Kessler", "Armando87@gmail.com", "Royce", "Steuber", "249-521-8114", "rjiV9mCqRh" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "80",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Amy.Prosacco@yahoo.com", "Hope", 2, "McClure", "6UwaAH7mRl" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "81",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Lolita_Bogan30@gmail.com", "Reyna", 1, "Dicki", "SEo2b2h5RG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "82",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Ressie.Thompson12@yahoo.com", "Wilfred", 1, "MacGyver", "OfkTQXcVPv" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "83",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Salvador.OReilly@yahoo.com", "Mathilde", 1, "Adams", "Y3k1G33bNq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "84",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Fabiola.Wiza@gmail.com", "Waldo", 1, "Heller", "AJhqSP7aAx" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Gail_Stiedemann2@gmail.com", "Tiffany", 1, "Schimmel", "rQwoaL_mPO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "86",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Jeanette.Kutch55@gmail.com", "Katherine", 3, "Goyette", "IUXXQxfxPd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "87",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Karlee71@gmail.com", "Britney", 3, "Heller", "VWRORUobJZ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "88",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Herman_Funk82@yahoo.com", "Carli", 1, "Breitenberg", "8UJCY39Xuk" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "89",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Vincenzo78@gmail.com", "Frances", "Crooks", "kK5P2T4jAA" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Vincenzo57@hotmail.com", "Hubert", "Gulgowski", "94TL4CCpTk" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Virgie.Orn@gmail.com", "Zelma", "Lehner", "nHCf54NTP9" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Kari37@yahoo.com", "Leif", "Stokes", "lmlcpXwR5A" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Skye_OKon33@gmail.com", "Nella", "MacGyver", "raUhGr4oxV" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Paris_Thompson81@yahoo.com", "Jadyn", "Bogan", "3L9HVmVWes" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Dustin.Schmeler26@yahoo.com", "Hollie", "Schiller", "kymnq5P4xd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Vivienne.Murazik61@gmail.com", "Yasmeen", "Cummings", "kEnnzXVAqU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Theresa_Stamm54@gmail.com", "Marjolaine", "Cummings", "xlVJK3LawK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Schuyler.Bednar41@yahoo.com", "Demarcus", "Bashirian", "7YTTR5tp1u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Patricia.Mayert@gmail.com", "Jamil", "Kshlerin", "5piMIb0BCA" });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "9ULQWAS6LIAQ68485", "BMW", 2, "Ranchero", 18000, null },
                    { "AWYXE18XE7C528931", "Lamborghini", 3, "Volt", 8000, null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "B0G6WMO94BM157815", "Chrysler", 2, "Volt", 21000, null },
                    { "D128QHJH5EZP88040", "Chrysler", 1, "Durango", 10000, null },
                    { "GWWCBTYW04E928347", "Volkswagen", 2, "Model 3", 39000, null },
                    { "JX5INS7LBOMT93516", "Lamborghini", 3, "V90", 25000, null },
                    { "MZ1KYNSSS8SN29023", "Maserati", 2, "Accord", 25000, null },
                    { "MZ9CVGLPJ2UR51277", "Volvo", 2, "Explorer", 31000, null },
                    { "OB0TAJZ3QUWS99021", "Dodge", 1, "Camaro", 36000, null },
                    { "SQEN43DTK2JJ33978", "Kia", 1, "Prius", 18000, null }
                });
        }
    }
}
