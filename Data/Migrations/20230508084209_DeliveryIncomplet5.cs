using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DeliveryIncomplet5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "67IGR099DVY556591");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "6Y1HUZPJA5SB80574");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "7FA7IOIT7IKU37067");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "9T64915NZ3BU19883");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "KXOMJ7A7UABW88687");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "OXXQDNRKXLFV36481");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "S7P3UHAFKSH298884");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "Y3XC4JLPH2K514062");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "YCR739LKFRIW39986");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "YUFDPAE3QEOM83916");

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
                columns: new[] { "CompanyName", "Email", "Name", "Number", "Password" },
                values: new object[] { "Upton - Hansen", "Shemar_Lesch@yahoo.com", "Roberts", "285-586-5065", "kATGW7AOgI" });

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
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Gail_Stiedemann2@gmail.com", "Tiffany", "Schimmel", "rQwoaL_mPO" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "90",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Anguilla", "Jamiehaven", "44136-5081", "8203", "Kyleigh Views" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "91",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Cayman Islands", "Lake Bailee", "34380-5585", "0448", "Rey Points" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "92",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Iceland", "Langmouth", "19051-4476", "894", "Rylan Keys" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "93",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Mauritius", "Botsfordburgh", "62382-1118", "10847", "Eriberto Park" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "94",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Austria", "Port Jonbury", "09552", "935", "Torp Ville" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "95",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Aruba", "Crystelberg", "85477-8414", "51573", "Frami Centers" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "96",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Bulgaria", "Faheyton", "32983", "189", "Mortimer Oval" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "97",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Canada", "Sipesmouth", "53131-3023", "0678", "Gerhold Tunnel" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "98",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Bosnia and Herzegovina", "Markville", "21278", "21203", "Meda Mall" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "99",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Hungary", "Anitaton", "08326", "4013", "Rodriguez Spurs" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "100",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Bauch LLC", "Orin42@yahoo.com", "Rocky", "Ebert", "706-845-0400", "4Jeb2igbGV" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "101",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Crist Group", "Mona.Cole62@gmail.com", "Crystel", "Kshlerin", "786-548-7926", "ZDHhvnzdgW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "102",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Treutel, Turner and Lemke", "Rosa.Mante@yahoo.com", "Meagan", "Rippin", "563-216-1273", "EhHV2ELutf" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "103",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "McCullough LLC", "Abigale41@hotmail.com", "Mandy", "Barrows", "929-871-8865", "Gko5Re8GzC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "104",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Crist, VonRueden and Robel", "Christine56@yahoo.com", "Dangelo", "Thiel", "687-830-7428", "c7uNnlpw3D" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "105",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Shields LLC", "Morris28@yahoo.com", "Eddie", "MacGyver", "357-218-9160", "oj60W9dQ3W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "106",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Rolfson, Connelly and Moen", "Crystal_Larkin0@gmail.com", "Gabriel", "Jenkins", "253-250-5579", "LG9fHjbkl1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "107",
                columns: new[] { "CompanyName", "Email", "Name", "Number", "Password" },
                values: new object[] { "Morissette - Towne", "Chloe.Boyle@hotmail.com", "Dooley", "390-648-8623", "_atRZLhSGt" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "108",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Barton Inc", "Stephon.Harris@hotmail.com", "Ethyl", "Rice", "270-782-7509", "1thWE2l0Qf" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "109",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Kertzmann - Funk", "Eveline.Walter34@yahoo.com", "Brant", "Gorczany", "433-782-5153", "EXgPstvOt7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "80",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Henderson77@hotmail.com", "Mohamed", 3, "Hudson", "ps9i6r4DZJ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "81",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Wilfredo50@hotmail.com", "Sherman", 2, "Halvorson", "NvRzulhF9U" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "82",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Tillman_Renner@yahoo.com", "Faustino", 2, "Streich", "909_JrkAFL" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "83",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Phyllis18@hotmail.com", "Emmett", 2, "Kris", "plYQETfPKV" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "84",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Brennan40@yahoo.com", "Laurianne", 3, "Marquardt", "OHzyP_kISU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Kathryne75@gmail.com", "Nathan", "Goyette", "S2DpIYjx90" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "86",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Yolanda_Cassin@hotmail.com", "Loren", 1, "Greenholt", "ZOMijlRsii" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "87",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Wilfrid_Corkery23@hotmail.com", "Seamus", 1, "Gusikowski", "uD4zt0QhVv" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "88",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Claudia97@hotmail.com", "Rose", 3, "Schmidt", "mj08tGnliv" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "89",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Savanna.Conn@hotmail.com", "Nicolas", "Bins", "D_0pDGfiim" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Shayna.Kerluke@gmail.com", "Gianni", "Mante", "1FgUC_q0cr" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Hilma73@yahoo.com", "Rigoberto", "Jones", "LeTRGnTRht" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Napoleon_Baumbach7@yahoo.com", "Mazie", "Heidenreich", "V_30zeRUbb" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Oceane_Gulgowski56@hotmail.com", "Zack", "Pouros", "Aa0DkfhWu0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Alejandra45@hotmail.com", "Lesly", "McClure", "uaN27sukeQ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Osvaldo.Purdy3@yahoo.com", "Macy", "O'Keefe", "d9RGObgQQV" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Darion_Grant89@gmail.com", "Werner", "Parisian", "l_l3si_Cx3" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Isaias_Langworth@hotmail.com", "Fidel", "Schumm", "oCdlHshj6A" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Nichole_Hodkiewicz@gmail.com", "Giles", "Nader", "0uQNw4rdBq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Hanna.Walker@gmail.com", "Gerardo", "Maggio", "VtJW35w5lK" });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "67IGR099DVY556591", "Volvo", 2, "Sentra", 38000, null },
                    { "6Y1HUZPJA5SB80574", "Jaguar", 2, "Spyder", 10000, null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "7FA7IOIT7IKU37067", "Volvo", 3, "Civic", 36000, null },
                    { "9T64915NZ3BU19883", "Fiat", 3, "Grand Caravan", 38000, null },
                    { "KXOMJ7A7UABW88687", "Porsche", 3, "Mustang", 20000, null },
                    { "OXXQDNRKXLFV36481", "Mini", 3, "2", 13000, null },
                    { "S7P3UHAFKSH298884", "Polestar", 1, "Corvette", 6000, null },
                    { "Y3XC4JLPH2K514062", "Jeep", 2, "Prius", 23000, null },
                    { "YCR739LKFRIW39986", "Fiat", 3, "Focus", 28000, null },
                    { "YUFDPAE3QEOM83916", "Nissan", 1, "PT Cruiser", 40000, null }
                });
        }
    }
}
