using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DispatcherCertif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certifications_User_DispatcherMatricule",
                table: "Certifications");

            migrationBuilder.DropIndex(
                name: "IX_Certifications_DispatcherMatricule",
                table: "Certifications");

            migrationBuilder.DropColumn(
                name: "DispatcherMatricule",
                table: "Certifications");

            migrationBuilder.AddColumn<int>(
                name: "IdCertification",
                table: "User",
                type: "int",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "CESS" },
                    { 2, "Bachelier" },
                    { 3, "Master" }
                });

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
                columns: new[] { "Email", "FirstName", "Password" },
                values: new object[] { "Rylee.Zemlak78@yahoo.com", "Jamey", "5WtSKIQ6R_" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "49",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jack.Denesik@hotmail.com", "Judah", "Welch", "jAGFKwAezc" });

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
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Dessie92@gmail.com", "Ernesto", 3, "Harvey", "AZWhGwVNIN" });

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
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Abigayle.Kuhic12@hotmail.com", "Cierra", 1, "Hyatt", "I_QYlV6NPF" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "56",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Enoch_Bradtke50@yahoo.com", "Erica", 3, "Parisian", "27GyxItYBc" });

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

            migrationBuilder.CreateIndex(
                name: "IX_User_IdCertification",
                table: "User",
                column: "IdCertification");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Certifications_IdCertification",
                table: "User",
                column: "IdCertification",
                principalTable: "Certifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Certifications_IdCertification",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_IdCertification",
                table: "User");

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Certifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "IdCertification",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "DispatcherMatricule",
                table: "Certifications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "60",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "China", "South Oceanehaven", "71414-2106", "31801", "Ratke Points" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "61",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Faroe Islands", "Elvabury", "93343-9945", "1077", "Ralph Brooks" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "62",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Albania", "Cindyside", "32601", "4421", "Harvey Underpass" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "63",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Saint Pierre and Miquelon", "Walkerfurt", "46645", "029", "Kling Divide" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "64",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Mozambique", "Hughborough", "73932", "180", "Runolfsson Road" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "65",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Turkey", "Jaceborough", "62353", "29520", "Geovanny Plains" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "66",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Andorra", "North Rigoberto", "81207", "08814", "Leone Prairie" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "67",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Uruguay", "Framiville", "83956-4151", "91280", "Lakin Crossroad" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "68",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Nicaragua", "Laurianebury", "09757-4744", "3839", "Corkery Meadows" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "69",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Comoros", "New Ulises", "31357-7242", "5382", "Desiree Underpass" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "70",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Leuschke - Leffler", "Heber_Rodriguez@hotmail.com", "Melvin", "Rath", "280-623-5988", "EM0U6J7Bry" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Treutel, Torphy and Parisian", "Fermin.Becker35@hotmail.com", "Hester", "Mitchell", "723-283-2272", "Ei2CJxhhOQ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "72",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Hilpert LLC", "Hudson35@hotmail.com", "Eliseo", "Labadie", "893-890-0860", "9W0b6xwdcE" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Lockman, Crist and Turner", "Sage.Shanahan@gmail.com", "Doyle", "Jakubowski", "430-582-0595", "4q77YdrCqU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "74",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Schuppe, Waters and Friesen", "Marge74@yahoo.com", "Amanda", "Hodkiewicz", "810-202-6198", "tdcHHBS0QU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Price, Stark and Volkman", "Orie.Walter62@gmail.com", "Clifton", "Deckow", "383-974-2568", "ScyOwgukB5" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "76",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Russel - Dach", "Ahmad.Strosin38@gmail.com", "Francesco", "Goyette", "227-445-8065", "1JUknVV6h8" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Von and Sons", "Oral_Hoppe33@gmail.com", "Odie", "Willms", "552-787-6932", "b0aLzke8aJ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "78",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Cummerata Group", "Carey_Reichert@gmail.com", "Modesta", "Christiansen", "892-526-6511", "ersIwdvCtp" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Lind Group", "Holly_Dicki0@gmail.com", "Zoey", "Ortiz", "934-698-2229", "35ImMmQSag" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "50",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Eloisa72@hotmail.com", "Ava", "Lowe", "dpxdjnK3GA" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "51",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Hazle.Swaniawski44@gmail.com", "Lilla", "Bednar", "U0kuysYVht" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "52",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Clarissa80@hotmail.com", "Nat", "Rosenbaum", "f_6OfP7WG4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "53",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Gerhard_Osinski@hotmail.com", "Alexane", "Metz", "TCkeEvk4L9" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "54",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Nannie.Schuppe29@gmail.com", "Cesar", "Tillman", "yOZ9qMn1I4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "55",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Orion_Hettinger@yahoo.com", "Max", "Beier", "6Id6PI1bkC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "56",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jovan_Koepp48@yahoo.com", "Alvena", "Hoppe", "pLgu8DUc6n" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "57",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Leanne_Metz90@hotmail.com", "Judd", "Keebler", "2h6UIn54EU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "58",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Corrine.OConnell@gmail.com", "Ressie", "Armstrong", "ckkm8GTpxh" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "59",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Murphy7@gmail.com", "Trevion", "Sporer", "WhA2yPC3KY" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "40",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Ellis_Kozey@gmail.com", "Verna", "Upton", "Ru4latlJFc" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "41",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Muhammad_Fadel92@yahoo.com", "Arch", "Baumbach", "Ao5ZlGGlAL" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "42",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Vivian_Bode2@gmail.com", "Colin", "Frami", "dEO4JdOkXd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "43",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jay.Schuppe66@gmail.com", "Levi", "Macejkovic", "XrCDN06FB7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "44",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Marianne.Kiehn45@gmail.com", "Coby", "Fay", "A1CvioS5rO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "45",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Julian.Hodkiewicz@yahoo.com", "Dejuan", "Glover", "sKjv9BeiBs" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "46",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Aubree86@yahoo.com", "Eloy", "Jakubowski", "zdsPDRyz5t" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "47",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Alyce48@gmail.com", "Mireya", "Baumbach", "1oncDBbfOd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "48",
                columns: new[] { "Email", "FirstName", "Password" },
                values: new object[] { "Rolando_Jacobson58@yahoo.com", "Raoul", "u7j2AHvkhD" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "49",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Arden.Connelly@gmail.com", "Ignatius", "Leannon", "bAkSPXdDis" });

            migrationBuilder.CreateIndex(
                name: "IX_Certifications_DispatcherMatricule",
                table: "Certifications",
                column: "DispatcherMatricule");

            migrationBuilder.AddForeignKey(
                name: "FK_Certifications_User_DispatcherMatricule",
                table: "Certifications",
                column: "DispatcherMatricule",
                principalTable: "User",
                principalColumn: "Matricule");
        }
    }
}
