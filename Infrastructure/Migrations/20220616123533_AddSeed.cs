using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace Infrastructure.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Point>(
                name: "Location",
                table: "Points",
                type: "geography",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bd9f7b52-d68d-4d21-8705-26c10a5865c4", "bd9f7b52-d68d-4d21-8705-26c10a5865c4", "Logist", "LOGIST" },
                    { "ff95caa4-f6b8-4743-a442-bc72537d7333", "ff95caa4-f6b8-4743-a442-bc72537d7333", "User", "USER" },
                    { "93653a5b-7b42-4f30-9269-93799a2a9485", "93653a5b-7b42-4f30-9269-93799a2a9485", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmationEmailToken", "ConfirmationEmailTokenExpirationDate", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5ed30093-99ec-4c8d-a622-4b77b45e01ab", 0, "bf75b3b7-0340-414b-bf25-072d393ecfbe", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEHeslvS0RJzyKmCnLWPNPFijc9yoxQ1g/JQYsayFNvlbW/YsBMfnNYE7+sR2UeQnHw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 12, 35, 32, 976, DateTimeKind.Unspecified).AddTicks(4243), new TimeSpan(0, 0, 0, 0, 0)), "2ad38947-e2c9-4369-bfa3-fec6dc29ca8a", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "33495b49-2a31-4fd9-9c54-ec052f3fd101", 0, "20193d21-4106-4299-9c66-ba7f7b7893d4", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEF/58nh+4klaOSguicB6Cgj6KnAt+Fby6M5OdF3U2ouFkKbaljwqskVmqc5SaJ2kxA==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 12, 35, 32, 976, DateTimeKind.Unspecified).AddTicks(4209), new TimeSpan(0, 0, 0, 0, 0)), "5781d45a-c80e-474c-8080-50ad246f3858", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "000feec1-4ea2-441f-8972-95887ef23d34", 0, "883692a6-ae1c-4f53-97c5-1b027db9af91", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEBDa7zbCWWoGSERiIiud48BtXVRA9LUjcFu5XZOoFZdAg6C8fVA6Uclzrk+Q0+L6zw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 12, 35, 32, 976, DateTimeKind.Unspecified).AddTicks(4202), new TimeSpan(0, 0, 0, 0, 0)), "95dca79a-cd59-4a95-8c5d-ca98aa9908fb", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "e67eebd3-ca2e-460d-88d3-18f05f720d23", 0, "9a6d23e2-0b1c-4806-af9a-b2662661d0dd", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEBSOtcdds3slL92VnB6cRXsrHxdR87eFyhkZGzQyAVvIdAONwxBuHkO0OGEtP0kXmw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 12, 35, 32, 976, DateTimeKind.Unspecified).AddTicks(4193), new TimeSpan(0, 0, 0, 0, 0)), "38233222-09c6-470d-856b-d894ad025785", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "e47b8928-9077-4465-8b0e-02f89774fa0a", 0, "86708015-ca2e-410f-a6cb-00d75bad806d", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEJ4+HYaWcQTrAuG/YRyuQ+xKuuD/eaAnMlThNZx93EiromaR9GUPlxIBUG0ikORFPg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 12, 35, 32, 976, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, 0, 0, 0, 0)), "509972c3-3cd8-4205-b17c-09f7a38f9cb4", "Kernychna", false, "mapourse@gmail.com" },
                    { "ae5dd945-f1a2-46ec-8711-a23859633c5c", 0, "6025c92f-9706-41df-bec4-b2ac791aa6cd", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAENfgctMxLNdghRPA48n8P4PHgrRFvWRPP+Vcl2NG2hM7Ia9BdDjuQOoaF3aPHXj9LQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 12, 35, 32, 976, DateTimeKind.Unspecified).AddTicks(4177), new TimeSpan(0, 0, 0, 0, 0)), "45fc02ec-73f3-4729-ba82-1eab17a3b5b2", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "bf81f6cd-8032-4536-b534-52ec79fe8b16", 0, "ba2ba536-56be-4791-8e7e-5cec06804aef", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEN/lCyWCTpOwulgNVzApHnqXivcMMvZCnZ7SZz/4shm5awvqv/r3QwEaKx91hNhNhg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 12, 35, 32, 976, DateTimeKind.Unspecified).AddTicks(4144), new TimeSpan(0, 0, 0, 0, 0)), "531238c7-ca49-42df-b2c8-97ae22894429", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "dc3e6f85-0c7b-4112-ac9f-dda731b32c3d", 0, "d9788698-9348-451e-8153-8526c8171d13", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEK2fJL/J9edm1tZ5lEfyVThzvIEaiDJpsWmsAdZvmgu3j19doYlDqK9VcngOzsWpYg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 12, 35, 32, 976, DateTimeKind.Unspecified).AddTicks(3386), new TimeSpan(0, 0, 0, 0, 0)), "5fedd110-81a0-44a6-acaf-623c3c78d778", "Chorrny", false, "chorrny228@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "CarCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "A" },
                    { 2, "B" },
                    { 3, "C" },
                    { 4, "D" }
                });

            migrationBuilder.InsertData(
                table: "GoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "FOOD" },
                    { 2, "DRINKS" },
                    { 3, "CLOTHING" },
                    { 4, "FOOTWEAR" },
                    { 5, "HYGIENE PRODUCTS" },
                    { 7, "MEDICINES" },
                    { 6, "CAMOUFLAGE" }
                });

            migrationBuilder.InsertData(
                table: "OfferRoles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "RECIPIENT" },
                    { 1, "SENDER" }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Location", "Longitude", "Order", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 2, "місто Шпанів, Рівненська область, вулиця Вереснева", 50.663542, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.257569 50.663542)"), 26.257569, 0, " Рівненська область", "Шпанів", null },
                    { 20, "місто Житомир, Житомирська область, Богунський район", 50.259729999999998, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.64923 50.25973)"), 28.649229999999999, 0, "Житомирська область", "Житомир", null },
                    { 19, "місто Біла церква, Київська область, вулиця Кірова", 49.807687086999998, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.1144958 49.807687087)"), 30.1144958, 0, "Київська область", "Біла церква", null },
                    { 18, "Горбово, Чернігівська область, 16311", 51.45984, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (31.561633 51.45984)"), 31.561633, 0, "Чернігівська область", "Горбово", null },
                    { 17, "Бобринець, Кіровоградська  область, вулиця Орджонікідзе", 48.061315, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.158811 48.061315)"), 32.158811, 0, "Кіровоградська  область", "Бобринець", null },
                    { 16, "Центральний пайон, місто Миколаїв, Миколаївська область, вулиця Дачна", 47.044604, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.030367 47.044604)"), 32.030366999999998, 0, "Миколаївська область", "Миколаїв", null },
                    { 15, "місто Миколаїв, Миколаївська область, вулиця Слов'янська", 47.032940848000003, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.00718275 47.032940848)"), 32.007182749999998, 0, "Миколаївська область", "Миколаїв", null },
                    { 14, "місто Вінниця, Вінницька область, вулиця Братславська", 49.232585, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.494244 49.232585)"), 28.494243999999998, 0, "Вінницька область", "Вінниця", null },
                    { 13, "Маків, Хмельницька  область, провулок Прорізний", 48.784157, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.703 48.784157)"), 26.702999999999999, 0, "Хмельницька  область", "Маків", null },
                    { 12, "місто Ужгород, Закарпатская область, вулиця Шишкіна, 1", 48.610622999999997, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (22.317773 48.610623)"), 22.317772999999999, 0, "Закарпатская область", "Ужгород", null },
                    { 10, "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко", 48.460256999999999, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.018729 48.460257)"), 35.018729, 0, "Дніпропетровська область", "Дніпро", null },
                    { 9, "Новодонецьк, Донецька область, вулиця Благовісна", 48.633740000000003, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (36.9805 48.63374)"), 36.980499999999999, 0, "Донецька область", "Новодонецьк", null },
                    { 8, "Ульянівка, Харківська область", 49.371445999999999, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.513638 49.371446)"), 35.513638, 0, "Харківська область", "Ульянівка", null },
                    { 7, "Гаврилівка, Харківська область, вулиця Коцюбинського", 49.672877999999997, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.660035 49.672878)"), 35.660035000000001, 0, "Харківська область", "Дніпро", null },
                    { 6, "Макаровка, Донецька область", 47.779212000000001, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (36.801641 47.779212)"), 36.801640999999996, 0, "Донецька область", "Макаровка", null },
                    { 5, "місто Нікольське, Донецька область, вулиця Пушкіна", 47.200732350000003, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.3148804 47.20073235)"), 37.3148804, 0, "Донецька область", "Нікольське", null },
                    { 4, "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко", 48.462322270000001, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.0215734 48.46232227)"), 35.021573400000001, 0, "Дніпропетровська область", "Дніпро", null },
                    { 3, "місто Луцьк, Волинська область, вулиця Хрещата", 50.723970999999999, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.386282 50.723971)"), 25.386282000000001, 0, "Волинська область", "Луцьк", null }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Location", "Longitude", "Order", "Region", "Settlement", "TripId" },
                values: new object[] { 1, "місто Острог, Рівненська область, вулиця Східна", 50.328792, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.527293 50.328792)"), 26.527293, 0, "Рівненська область", "Острог", null });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Location", "Longitude", "Order", "Region", "Settlement", "TripId" },
                values: new object[] { 11, "місто Львів, Львівська область, просп. Вячеслава Черновола, 11", 49.846894900000002, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (34.0253361 49.8468949)"), 34.025336099999997, 0, "Львівська область", "Львів", null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bd9f7b52-d68d-4d21-8705-26c10a5865c4", "ae5dd945-f1a2-46ec-8711-a23859633c5c" },
                    { "ff95caa4-f6b8-4743-a442-bc72537d7333", "e67eebd3-ca2e-460d-88d3-18f05f720d23" },
                    { "ff95caa4-f6b8-4743-a442-bc72537d7333", "33495b49-2a31-4fd9-9c54-ec052f3fd101" },
                    { "ff95caa4-f6b8-4743-a442-bc72537d7333", "e47b8928-9077-4465-8b0e-02f89774fa0a" },
                    { "ff95caa4-f6b8-4743-a442-bc72537d7333", "000feec1-4ea2-441f-8972-95887ef23d34" },
                    { "ff95caa4-f6b8-4743-a442-bc72537d7333", "bf81f6cd-8032-4536-b534-52ec79fe8b16" },
                    { "ff95caa4-f6b8-4743-a442-bc72537d7333", "dc3e6f85-0c7b-4112-ac9f-dda731b32c3d" },
                    { "ff95caa4-f6b8-4743-a442-bc72537d7333", "5ed30093-99ec-4c8d-a622-4b77b45e01ab" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 8, 2, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 577.1905f, "Jeep,Wrangler, SUV", "KFV0PLGA3SH8QG4MM1VA", "B38YZAA81XLCHXHY5BBP", "5ed30093-99ec-4c8d-a622-4b77b45e01ab", "CZ9R3QFIU8F6PG6X1" },
                    { 7, 3, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 985.5344f, "Ford,F350 Super Duty Super Cab, Pickup", "P3SDDIJI3HM0U29GHP57", "OIJNX261HJ1QZ4HT6DWN", "5ed30093-99ec-4c8d-a622-4b77b45e01ab", "2E1B0BQ5FSR0T7K4G" },
                    { 5, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 926.33765f, "Jeep,Wrangler Unlimited, SUV", "JUVVW200IRJT1SRTSUBJ", "KARS605FPVMHOKKS7EB7", "5ed30093-99ec-4c8d-a622-4b77b45e01ab", "776L0V68LG2FL822P" },
                    { 1, 4, "Blue", new DateTimeOffset(new DateTime(2016, 7, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 515.50104f, "Porsche,911, Convertible, Coupe", "6ZCTHDXGA8GHS0V34J9H", "BTPKWYD4JNNJ8JG7WSCD", "33495b49-2a31-4fd9-9c54-ec052f3fd101", "IF2I3C9JMC9QID9RX" },
                    { 10, 3, "Green", new DateTimeOffset(new DateTime(2016, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 684.37494f, "Ford,F250 Super Duty Super Cab, Pickup", "1TRXTLGJ7WQJGKUO5YBU", "ZGPMOW2ZXKPUVTHOI8G3", "e67eebd3-ca2e-460d-88d3-18f05f720d23", "MA1VAIYIANLJ8L448" },
                    { 2, 4, "White", new DateTimeOffset(new DateTime(2016, 7, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 746.7472f, "Porsche,Cayenne, SUV", "NLW88JO7C7VAIAAIEU1U", "Z1B9I03X4USEDVVT59VS", "dc3e6f85-0c7b-4112-ac9f-dda731b32c3d", "95DF02Y9JOXYXL9MQ" },
                    { 4, 4, "Blue", new DateTimeOffset(new DateTime(2016, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 792.6592f, "Porsche,911, Convertible, Coupe", "KCXFDZF0KLDHZWERROFH", "SWEV22LGU1QIL2UDQ8WV", "dc3e6f85-0c7b-4112-ac9f-dda731b32c3d", "3N2A8AW9QZPF1OX1D" },
                    { 9, 3, "Red", new DateTimeOffset(new DateTime(2016, 7, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 563.1197f, "Ford,F250 Super Duty Super Cab, Pickup", "664RTY5GBQ50FR9O77JS", "I3DXB71S89WE3M5S50AS", "e47b8928-9077-4465-8b0e-02f89774fa0a", "II969PX8T7REQ3T7F" },
                    { 3, 4, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 697.2096f, "Jeep,Wrangler, SUV", "HEHXMEGC4Z99NR6W2Z0Z", "VB3GFY9KIJMBT9SQVIEN", "e47b8928-9077-4465-8b0e-02f89774fa0a", "EPOOAU3QN8FR76A1H" },
                    { 6, 2, "Green", new DateTimeOffset(new DateTime(2016, 7, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 536.8399f, "Ford,F350 Super Duty Crew Cab, Pickup", "N525H8YMEJ3OB2KMK098", "G95F8ZBQ4OFBAXK14GJN", "bf81f6cd-8032-4536-b534-52ec79fe8b16", "7WYRA5IG5VNCVDZMW" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 21, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Schuppe - Harrisparsing Data Somali Shilling Lead Rustic systematic Team-oriented model optical Metal payment Alaska Ouguiya iterate Handmade Steel Table connecting haptic Identity bandwidth Rubber next generation Borders Fresh grey benchmark.", new DateTimeOffset(new DateTime(2022, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 676.43854f, false, "e47b8928-9077-4465-8b0e-02f89774fa0a", 8, null, new DateTimeOffset(new DateTime(2022, 7, 4, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Ortiz, Ankunding and SchummTCP Highway Persevering Uganda Shilling Producer backing up Latvia Awesome Rubber Car transmitting Jewelery & Health Savings Account policy Legacy Bedfordshire repurpose deposit Licensed Concrete Gloves Global Chief interface unleash Ergonomic Wooden Tuna Tasty Metal Bike Cross-group Netherlands Antillian Guilder.", new DateTimeOffset(new DateTime(2022, 7, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 265.7935f, false, "dc3e6f85-0c7b-4112-ac9f-dda731b32c3d", 2, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 29, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Torphy and Sonsplatforms Drive Saint Helena upward-trending SQL Gorgeous Concrete Salad Baby & Jewelery Fresh firewall explicit cross-platform bypassing foreground Tools invoice Outdoors & Music connecting SQL Neck Hill Assistant Concrete Shoal Forest SCSI Horizontal Unbranded Concrete Chicken Bedfordshire solid state Alaska.", new DateTimeOffset(new DateTime(2022, 7, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 8.640296f, false, "dc3e6f85-0c7b-4112-ac9f-dda731b32c3d", 12, null, new DateTimeOffset(new DateTime(2022, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Kuhn, Sipes and Terrywithdrawal Libyan Dinar Credit Card Account Principal deposit Associate Metal fuchsia global GB North Dakota Uganda Shilling Rustic Steel Chicken International reboot Pakistan Baby, Toys & Games.", new DateTimeOffset(new DateTime(2022, 7, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 590.0295f, false, "dc3e6f85-0c7b-4112-ac9f-dda731b32c3d", 14, null, new DateTimeOffset(new DateTime(2022, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Balistreri - WalkerOfficer Analyst Organized navigating copying models leading-edge orchid Somoni United States of America.", new DateTimeOffset(new DateTime(2022, 7, 7, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 148.36752f, false, "dc3e6f85-0c7b-4112-ac9f-dda731b32c3d", 19, null, new DateTimeOffset(new DateTime(2022, 7, 4, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Deckow - PfefferFlat Configuration Intelligent Granite Fish Route Mountain Congolese Franc Designer International Legacy B2C Handcrafted Metal Ball Ergonomic Steel Soap Springs back-end.", new DateTimeOffset(new DateTime(2022, 7, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 872.9995f, false, "5ed30093-99ec-4c8d-a622-4b77b45e01ab", 11, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "McClure, Medhurst and Gulgowskiwithdrawal Burg navigate Refined Frozen Table Solutions Berkshire Lodge Sleek generating ubiquitous Rupiah Rustic Frozen challenge synthesizing core Refined Rubber black protocol Dale Handcrafted Soft Computer Administrator SDD.", new DateTimeOffset(new DateTime(2022, 7, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 763.0803f, false, "bf81f6cd-8032-4536-b534-52ec79fe8b16", 6, null, new DateTimeOffset(new DateTime(2022, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Fay LLCSavings Account Ethiopian Birr deliverables interactive knowledge base compressing back-end Practical Plastic Chair Interactions policy Sports & Garden Small Metal Towels Sleek Granite Bacon Yemen Operations Dominican Peso Fantastic Soft Mouse RAM platforms Operations coherent motivating Cambridgeshire yellow streamline Hill.", new DateTimeOffset(new DateTime(2022, 7, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 829.3838f, false, "bf81f6cd-8032-4536-b534-52ec79fe8b16", 7, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "O'Hara - HowellIB port maroon Barbados Berkshire deposit Polarised synthesizing Concrete quantifying Virgin Islands, U.S..", new DateTimeOffset(new DateTime(2022, 7, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 889.2928f, false, "33495b49-2a31-4fd9-9c54-ec052f3fd101", 20, null, new DateTimeOffset(new DateTime(2022, 7, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 26, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Larson, Johns and ChamplinVirgin Islands, British withdrawal Bedfordshire Uzbekistan Sum customized driver Handmade Frozen Keyboard Personal Loan Account override Generic Ergonomic Fresh Gloves Investment Account reciprocal Grocery, Grocery & Health holistic infrastructure interface sensor Rustic Cotton Pants Personal Loan Account override Port Communications XSS.", new DateTimeOffset(new DateTime(2022, 7, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 550.86816f, false, "e47b8928-9077-4465-8b0e-02f89774fa0a", 5, null, new DateTimeOffset(new DateTime(2022, 7, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Cronin - BoyerUser-friendly application Assistant copying Borders green Administrator Awesome Rapids Down-sized bypass bifurcated Practical zero tolerance Cotton hard drive back-end Wisconsin program Jewelery Progressive.", new DateTimeOffset(new DateTime(2022, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 3.1812725f, false, "33495b49-2a31-4fd9-9c54-ec052f3fd101", 15, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Zieme - Lakinorchestration Canada e-business Springs Reunion Orchestrator Ergonomic Concrete communities Inlet Executive Spring black Small Frozen Table COM lime white functionalities virtual withdrawal Frozen policy Director Generic Rubber Keyboard Delaware Manager Soft Program Rubber.", new DateTimeOffset(new DateTime(2022, 7, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 824.8118f, false, "33495b49-2a31-4fd9-9c54-ec052f3fd101", 4, null, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Dickens Incpayment optimize transmitter scalable Communications Refined Concrete Table Credit Card Account Intelligent Concrete Shirt Motorway Unbranded Cotton Chips compress Cotton Persevering Analyst Baby & Games Lao People's Democratic Republic multi-byte Kids open-source impactful Accounts Jewelery Delaware vortals Baht Ergonomic Frozen Shoes brand calculating paradigms Tasty Metal Chicken.", new DateTimeOffset(new DateTime(2022, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 613.3087f, false, "bf81f6cd-8032-4536-b534-52ec79fe8b16", 10, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 29, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Leffler and Sonsquantifying bluetooth Florida transitional Generic Frozen Car Washington District gold Soft USB Divide Accounts withdrawal connect.", new DateTimeOffset(new DateTime(2022, 7, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 541.07526f, false, "000feec1-4ea2-441f-8972-95887ef23d34", 18, null, new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 29, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Kovacek and SonsIsland Sleek Granite Table back-end Granite hack Village paradigms indexing Handmade Fresh Sausages Rustic Plastic Gloves Pakistan e-business Principal invoice Cotton compressing Assistant AGP Granite Crossroad Generic Granite Fish gold mindshare Branding red mint green Marketing.", new DateTimeOffset(new DateTime(2022, 7, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 797.51385f, false, "000feec1-4ea2-441f-8972-95887ef23d34", 17, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Bechtelar, Kunde and SchmidtVirginia Saint Lucia overriding Licensed North Dakota quantifying SDD implement users Direct Small Frozen Soap Sudanese Pound Vatu Via Home & Jewelery Checking Account Practical Cotton Sausages Field Fiji Dollar Awesome Cotton Hat project solutions Oklahoma Malagasy Ariary Factors Rustic Granite Bike Pre-emptive.", new DateTimeOffset(new DateTime(2022, 7, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 673.4562f, false, "000feec1-4ea2-441f-8972-95887ef23d34", 3, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Toy - ChristiansenSolutions Rustic sensor interface deliver Borders yellow Texas Kyrgyz Republic Gorgeous Wooden Table Argentina Savings Account e-business Hill.", new DateTimeOffset(new DateTime(2022, 7, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 883.5348f, false, "e67eebd3-ca2e-460d-88d3-18f05f720d23", 1, null, new DateTimeOffset(new DateTime(2022, 7, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 28, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Vandervort - TillmanMetal Ridge Nevada CSS Refined Metal Bike optical Soft North Carolina Practical Israel eco-centric deposit contextually-based deposit Generic Frozen Pants solutions mint green Borders Program Savings Account Intelligent Cotton Computer payment driver online open system solutions.", new DateTimeOffset(new DateTime(2022, 7, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 16.963287f, false, "e47b8928-9077-4465-8b0e-02f89774fa0a", 16, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Aufderhar - TorphyRefined Steel Chicken Licensed North Korean Won supply-chains Bhutan Street Alaska relationships Tunisian Dinar deploy override Borders Steel content-based array invoice.", new DateTimeOffset(new DateTime(2022, 7, 7, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 660.76996f, false, "bf81f6cd-8032-4536-b534-52ec79fe8b16", 9, null, new DateTimeOffset(new DateTime(2022, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Shanahan, Harvey and BarrowsCustomer-focused Rubber United States of America Wall Gorgeous Granite Sausages Paradigm gold enterprise South Carolina Creative homogeneous system Cotton Savings Account web-readiness Steel Designer open-source web-enabled Steel COM radical implement withdrawal robust compress District.", new DateTimeOffset(new DateTime(2022, 7, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 881.4312f, false, "e67eebd3-ca2e-460d-88d3-18f05f720d23", 13, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93653a5b-7b42-4f30-9269-93799a2a9485");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff95caa4-f6b8-4743-a442-bc72537d7333", "000feec1-4ea2-441f-8972-95887ef23d34" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff95caa4-f6b8-4743-a442-bc72537d7333", "33495b49-2a31-4fd9-9c54-ec052f3fd101" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff95caa4-f6b8-4743-a442-bc72537d7333", "5ed30093-99ec-4c8d-a622-4b77b45e01ab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd9f7b52-d68d-4d21-8705-26c10a5865c4", "ae5dd945-f1a2-46ec-8711-a23859633c5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff95caa4-f6b8-4743-a442-bc72537d7333", "bf81f6cd-8032-4536-b534-52ec79fe8b16" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff95caa4-f6b8-4743-a442-bc72537d7333", "dc3e6f85-0c7b-4112-ac9f-dda731b32c3d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff95caa4-f6b8-4743-a442-bc72537d7333", "e47b8928-9077-4465-8b0e-02f89774fa0a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff95caa4-f6b8-4743-a442-bc72537d7333", "e67eebd3-ca2e-460d-88d3-18f05f720d23" });

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd9f7b52-d68d-4d21-8705-26c10a5865c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff95caa4-f6b8-4743-a442-bc72537d7333");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "000feec1-4ea2-441f-8972-95887ef23d34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33495b49-2a31-4fd9-9c54-ec052f3fd101");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ed30093-99ec-4c8d-a622-4b77b45e01ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae5dd945-f1a2-46ec-8711-a23859633c5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf81f6cd-8032-4536-b534-52ec79fe8b16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc3e6f85-0c7b-4112-ac9f-dda731b32c3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47b8928-9077-4465-8b0e-02f89774fa0a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e67eebd3-ca2e-460d-88d3-18f05f720d23");

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OfferRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OfferRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Points");
        }
    }
}
