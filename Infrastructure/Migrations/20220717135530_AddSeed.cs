using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace Infrastructure.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fc8ef21d-0e05-4985-bad1-6821df1a7720", "fc8ef21d-0e05-4985-bad1-6821df1a7720", "Logist", "LOGIST" },
                    { "75a5b518-da54-4f93-bd7a-c793508b0925", "75a5b518-da54-4f93-bd7a-c793508b0925", "User", "USER" },
                    { "0bb91cd1-4f34-4342-8455-d09132b6f169", "0bb91cd1-4f34-4342-8455-d09132b6f169", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmationEmailToken", "ConfirmationEmailTokenExpirationDate", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f04495ec-270a-4fce-87f2-740cca1575dd", 0, "31991a2a-e7dd-49f0-8164-9df930d4f436", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAECmsH/YqM8E7v5lBl6hdM7AB0dRwbVnrBV0e4hJV7gEjgUsfj6G3Iju7/7XqNrzDMA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 17, 13, 55, 28, 779, DateTimeKind.Unspecified).AddTicks(1246), new TimeSpan(0, 0, 0, 0, 0)), "2f5c5e81-81cc-48ac-b42a-3343478af35a", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "614ed0a3-c30f-4193-a3ea-21c396bffcc5", 0, "055b73e5-ba84-47fa-b2d1-171b5a25e0db", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEOhBPHuoL3uQfY/xsnJ5H7AmkQas7u9g6JUY7a75IdCEI3PlqktCcA6uiBxKlZEf5A==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 17, 13, 55, 28, 779, DateTimeKind.Unspecified).AddTicks(1226), new TimeSpan(0, 0, 0, 0, 0)), "859a7532-58a3-452e-9b5a-447a40aa2248", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "0147d174-6dd4-45e8-8582-3395c3d1b281", 0, "bd1d39e4-35bb-4e0c-85fa-a184dcd75a52", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEMfej40ISjSUmGh+ZUYjuAZQ9GjlEXVQYOqhTbvSyirqND+flTR/Q2BgXw3wsvQZQw==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 17, 13, 55, 28, 779, DateTimeKind.Unspecified).AddTicks(1199), new TimeSpan(0, 0, 0, 0, 0)), "6c778a8e-ad7d-48b9-a428-47111ea524f9", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "792e95d9-7604-47bc-bb22-08ed374e0b3b", 0, "9ab8ee7f-c8ee-4e3c-bf1d-ccb50f7d68d7", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEFsZfGvRn1266jlpQtQAGTNyj4R9GoS38kM2XvNLUbDMjKdo4YbcObcpEo/tUUPOnA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 17, 13, 55, 28, 779, DateTimeKind.Unspecified).AddTicks(1178), new TimeSpan(0, 0, 0, 0, 0)), "286f9bea-c027-47cf-ad80-e13ad10d6133", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "f97c39af-da23-472d-8c0a-04c91f830eb5", 0, "e3104e76-f985-4d23-9553-57c2b9692cdb", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEIgNzoTuY5QKcfGKt+4r1vNlv6eza59M3dBSgFds+AJnWKN/JbDdvOw+wignbguV5A==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 17, 13, 55, 28, 779, DateTimeKind.Unspecified).AddTicks(1144), new TimeSpan(0, 0, 0, 0, 0)), "9a9823ed-6893-496e-ac37-4647d1171663", "Kernychna", false, "mapourse@gmail.com" },
                    { "766b3277-a89e-4d70-86c6-7d9f23c854e0", 0, "8ddf15e0-f952-42b5-a239-8f0c37ee39fe", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEBHYCw2uMUTkWinp/DBUiVPOFG381g31W3DfvbK1wwrfEUzZE8k1Gd+0c3ecLbmZ+w==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 17, 13, 55, 28, 779, DateTimeKind.Unspecified).AddTicks(1121), new TimeSpan(0, 0, 0, 0, 0)), "5e32f2b9-5287-45c6-9cca-66304244aab3", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "4aa50ef6-4121-455c-bc23-d274242678ee", 0, "ed18e4a3-d3f7-4716-9936-ad1ebae7ff8c", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAECWeoWMa/i3JfYEvyDH3Q8VIRjiGG/jvmEAcMAHSEWGJLlw1/BNrLeQRiOuUU4ty/w==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 17, 13, 55, 28, 779, DateTimeKind.Unspecified).AddTicks(987), new TimeSpan(0, 0, 0, 0, 0)), "6d7b0e16-779a-4b3b-a510-f20540c4ea7b", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "2b4f6cbc-d9c6-465e-a94c-7c9138228945", 0, "6e174153-7b4c-4a09-b768-365f151eadc5", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEECOwpP2IAoHj40d+83KiQ0Wmhvn2kQIyo5jQ7QFmStWZKTAh7dIO4o0+tgQN0IDnA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 17, 13, 55, 28, 778, DateTimeKind.Unspecified).AddTicks(8139), new TimeSpan(0, 0, 0, 0, 0)), "dd4a8700-8343-4d14-b3df-91cea06ad325", "Chorrny", false, "chorrny228@gmail.com" }
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
                    { 6, "CAMOUFLAGE" },
                    { 1, "FOOD" },
                    { 2, "DRINKS" },
                    { 3, "CLOTHING" },
                    { 4, "FOOTWEAR" },
                    { 5, "HYGIENE PRODUCTS" },
                    { 7, "MEDICINES" }
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
                columns: new[] { "Id", "Address", "Country", "Location", "OfferId", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 24, "вулиця Шевченка, 10", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.9116167 47.1991193)"), 24, 0, "67301", "Одеська область", "Березівка", null },
                    { 25, "Трасса Е 95", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.317371 47.0234622)"), 25, 0, "67211", "Одеська область", "Знам'янка", null },
                    { 26, "48Q2+JJ Дубинове", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3017199 48.1390924)"), 26, 0, "66220", "Одеська область", "Дубинове", null },
                    { 2, "вулиця Соборна, 5", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.2614291 50.6175848)"), 2, 0, "33000", "Рівненська область", "Рівне", null },
                    { 28, "вул. Станціонна, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.4974225 47.5464278)"), 28, 0, "55642", "Миколаївська область", "Новополтавка", null },
                    { 23, "Криве Озеро", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3443027 47.9484405)"), 23, 0, "55100", "Миколаївська область", "Криве Озеро", null },
                    { 27, "вулиця Медична, 19", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (33.3832712 47.8876902)"), 27, 0, "50005", "Дніпропетровська область", "Кривий Ріг", null },
                    { 22, "Центральна 119", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.1641172 48.1413224)"), 22, 0, "66221", "Одеська область", "Вільшанка", null },
                    { 21, "вул Соборна 44б", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.4570465 48.3880023)"), 21, 0, "26500", "Кіровоградська область", "Голованівськ", null },
                    { 20, "вулиця Бориса Тена, 2", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.6727154 50.2541948)"), 20, 0, "10001", "Житомирська область", "Житомир", null },
                    { 3, "Вишнівецька вулиця, 30", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.3839251 50.724626)"), 3, 0, "43000", "Волинська область", "Луцьк", null },
                    { 4, "вулиця Юрія Савченко, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.0256349 48.4674516)"), 4, 0, "49000", "Дніпропетровська область", "Дніпро", null },
                    { 5, "вулиця Пушкіна, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.3386598 47.1917281)"), 5, 0, "87000", "Донецька область", "Нікольське", null },
                    { 6, "вулиця Садова, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0033648 46.9690278)"), 6, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 7, "вулиця Павлова, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2345305 48.5175858)"), 7, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 8, "вулиця Чкалова, 20", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2277797 48.5183484)"), 8, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 9, "Посадочна вулиця, 5", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2269653 48.5181244)"), 9, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 1, "вулиця Східна, 32", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5283633 50.3288577)"), 1, 0, "35800", "Рівненська область", "Острог", null }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Country", "Location", "OfferId", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 10, "вулиця Юрія Савченка, 3", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.0247707 48.4658504)"), 10, 0, "49000", "Дніпропетровська область", "Дніпро", null },
                    { 12, "вулиця Шишкіна, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (22.3178905 48.6102995)"), 12, 0, "88000", "Закарпатська область", "Ужгород", null },
                    { 13, "вулиця Козацька, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.9919167 49.4178562)"), 13, 0, "29000", "Хмельницька  область", "Хмельницький", null },
                    { 14, "вулиця Братиславська, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (33.3286723 47.8847308)"), 14, 0, "50000", "Дніпропетровська область", "Кривий Ріг", null },
                    { 16, "вулиця Привільна, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0222338 46.9858772)"), 16, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 17, "вулиця Привільна, 10", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0210963 46.9880672)"), 17, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 18, "вулиця В'ячеслава Чорновола, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.36196 50.755603)"), 18, 0, "43000", "Волинська область", "Луцьк", null },
                    { 19, "вулиця Острозька, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.8544323 50.3006939)"), 19, 0, "30000", "Хмельницька область", "Славута", null },
                    { 11, "просп. Вячеслава Черновола, 11", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.0253381 49.8468734)"), 11, 0, "79000", "Львівська область", "Львів", null },
                    { 15, "вулиця Слов'янська, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0147107 47.031949)"), 15, 0, "54000", "Миколаївська область", "Миколаїв", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fc8ef21d-0e05-4985-bad1-6821df1a7720", "766b3277-a89e-4d70-86c6-7d9f23c854e0" },
                    { "75a5b518-da54-4f93-bd7a-c793508b0925", "792e95d9-7604-47bc-bb22-08ed374e0b3b" },
                    { "75a5b518-da54-4f93-bd7a-c793508b0925", "614ed0a3-c30f-4193-a3ea-21c396bffcc5" },
                    { "75a5b518-da54-4f93-bd7a-c793508b0925", "f97c39af-da23-472d-8c0a-04c91f830eb5" },
                    { "75a5b518-da54-4f93-bd7a-c793508b0925", "0147d174-6dd4-45e8-8582-3395c3d1b281" },
                    { "75a5b518-da54-4f93-bd7a-c793508b0925", "4aa50ef6-4121-455c-bc23-d274242678ee" },
                    { "75a5b518-da54-4f93-bd7a-c793508b0925", "2b4f6cbc-d9c6-465e-a94c-7c9138228945" },
                    { "75a5b518-da54-4f93-bd7a-c793508b0925", "f04495ec-270a-4fce-87f2-740cca1575dd" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 8, 2, "Red", new DateTimeOffset(new DateTime(2016, 7, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 901f, "Nissan,TITAN XD Crew Cab, Pickup", "BH2333XI", "ILH7GHK85LOHGAGU3BLH", "f04495ec-270a-4fce-87f2-740cca1575dd", "922N0S291JZZSOBIU" },
                    { 7, 2, "Blue", new DateTimeOffset(new DateTime(2016, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 424f, "Nissan,Titan Crew Cab, Pickup", "BC7739AA", "9LQOTMGL80H218WQ97HR", "f04495ec-270a-4fce-87f2-740cca1575dd", "A9TPBV3E070ZLWX7X" },
                    { 5, 4, "Red", new DateTimeOffset(new DateTime(2016, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 881f, "Jeep,Wrangler Unlimited, SUV", "BH1232AA", "GTT23LPWDPWXQXLQFL5X", "f04495ec-270a-4fce-87f2-740cca1575dd", "UTSPOCMW62F21TNQY" },
                    { 1, 3, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 917f, "Nissan,TITAN XD Crew Cab, Pickup", "AA4567XI", "MNI2PE1V715KTKFIJNUY", "614ed0a3-c30f-4193-a3ea-21c396bffcc5", "V3HSSKBMLBQ6A7CZT" },
                    { 10, 3, "Grey", new DateTimeOffset(new DateTime(2016, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 811f, "Porsche,911, Convertible, Coupe", "AC1273IX", "WG1ADVC1WRYX261O2PT8", "792e95d9-7604-47bc-bb22-08ed374e0b3b", "K9CNOMB2FHGN91F8E" },
                    { 9, 3, "Grey", new DateTimeOffset(new DateTime(2016, 7, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 942f, "Porsche,911, Convertible, Coupe", "AA8992BH", "MBI5LGCT4NJYIBF5THR6", "f97c39af-da23-472d-8c0a-04c91f830eb5", "5HGIRJLG7ZO6NQJIE" },
                    { 2, 3, "Grey", new DateTimeOffset(new DateTime(2016, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 735f, "Jeep,Wrangler Unlimited, SUV", "BC2234OP", "JUUS0O81TOSVMSEKWLGJ", "2b4f6cbc-d9c6-465e-a94c-7c9138228945", "TUNA85KU6PDUB9N0S" },
                    { 4, 4, "Black", new DateTimeOffset(new DateTime(2016, 7, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 528f, "Jeep,Wrangler Unlimited, SUV", "AC6344AC", "XF878NW1FZ4T4URWXTG1", "2b4f6cbc-d9c6-465e-a94c-7c9138228945", "HNGT2Q4NWA0C53JAW" },
                    { 6, 3, "Grey", new DateTimeOffset(new DateTime(2016, 7, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 676f, "Nissan,Titan Crew Cab, Pickup", "AA5421BH", "K3EE5YKGOTUBDZ09DWD9", "4aa50ef6-4121-455c-bc23-d274242678ee", "UHOVR2PM0J2K9PEAI" },
                    { 3, 4, "Grey", new DateTimeOffset(new DateTime(2016, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 979f, "Nissan,TITAN XD Crew Cab, Pickup", "BH4456AI", "MXAOEYEW1RYL40Z4QG3G", "f97c39af-da23-472d-8c0a-04c91f830eb5", "3ISH5XVTKGYN7XDLT" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodsWeight", "IsClosed", "NotificationId", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 20, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Toy and SonsHonduras Hills Borders Response Unbranded Wooden Chips revolutionary Berkshire neural Money Market Account toolset tan feed channels Soft action-items IB.", 5, 472.0957f, false, null, "f97c39af-da23-472d-8c0a-04c91f830eb5", 5, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Cronin Groupvirtual Practical South Dakota Factors backing up override Guatemala Granite optimal one-to-one deposit Practical Fresh Bike 24/7 Brand incubate indexing Colorado.", 1, 238.6434f, false, null, "2b4f6cbc-d9c6-465e-a94c-7c9138228945", 2, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 26, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Sipes - RaynorCurve Money Market Account cross-media backing up deliverables Markets back up Small Metal Computer Isle Kyat Rufiyaa Licensed Soft Chicken Checking Account Wallis and Futuna architectures Lead multi-byte.", 7, 610.6465f, false, null, "2b4f6cbc-d9c6-465e-a94c-7c9138228945", 12, null, new DateTimeOffset(new DateTime(2022, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Strosin, Lebsack and Boyerneural Streamlined Handmade Steel Pizza connecting Riel Awesome Borders Pre-emptive Ergonomic system-worthy digital red Granite Brand Nevada Intelligent Wooden Ball.", 2, 204.96957f, false, null, "2b4f6cbc-d9c6-465e-a94c-7c9138228945", 14, null, new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Glover and Sonscross-platform e-enable secondary Refined AGP Netherlands Antilles empower generating wireless human-resource Concrete Fantastic.", 2, 773.6103f, false, null, "2b4f6cbc-d9c6-465e-a94c-7c9138228945", 19, null, new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "McKenzie - Metzmindshare SDD content capacitor Planner Refined Cotton Tuna Mission Ergonomic Drive Central Mississippi Practical Fresh Cheese Palau Cuba Mission Handmade Soft Fish Finland Mozambique Fresh deposit Executive back-end Central Practical Fresh Chips Fantastic Steel Chips Walks.", 7, 444.2189f, false, null, "f04495ec-270a-4fce-87f2-740cca1575dd", 11, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Dibbert - Paucekpayment Technician Assistant Lakes zero tolerance Electronics & Movies Stravenue ivory Incredible Granite Cheese Granite Savings Account Distributed pixel primary static hacking Surinam Dollar.", 7, 213.816f, false, null, "4aa50ef6-4121-455c-bc23-d274242678ee", 6, null, new DateTimeOffset(new DateTime(2022, 7, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 29, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "VonRueden, Berge and Beahansecondary backing up generate District Avon quantify whiteboard deposit Product architect.", 4, 422.29675f, false, null, "4aa50ef6-4121-455c-bc23-d274242678ee", 7, null, new DateTimeOffset(new DateTime(2022, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Hane - KemmerUSB Sudanese Pound Islands strategy local Sleek Circle focus group Washington Organized Balanced hack Intranet Plastic Wooden Tunnel Parks Orchestrator payment Awesome Granite Mouse IB Soft Metal.", 5, 758.6961f, false, null, "4aa50ef6-4121-455c-bc23-d274242678ee", 9, null, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 28, new DateTimeOffset(new DateTime(2022, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 8 offer", 6, 120f, false, null, "614ed0a3-c30f-4193-a3ea-21c396bffcc5", 28, null, new DateTimeOffset(new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 24, new DateTimeOffset(new DateTime(2022, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 4 offer", 6, 120f, false, null, "614ed0a3-c30f-4193-a3ea-21c396bffcc5", 24, null, new DateTimeOffset(new DateTime(2022, 7, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Krajcik GroupArchitect Sports & Books regional matrix Berkshire Fantastic Rustic withdrawal Representative Liaison Walks Soft capacitor infrastructures Associate sensor frame Drives AGP grey Avon District visualize Intelligent Steel Pizza Cambridgeshire Human HTTP Armenia.", 5, 291.16547f, false, null, "614ed0a3-c30f-4193-a3ea-21c396bffcc5", 20, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Lakin LLCinterfaces intuitive program Alley Books, Movies & Baby Generic Granite Salad parse Fantastic Fresh Shoes pink sensor overriding Investor moratorium Morocco Idaho virtual leading-edge Intelligent Wooden Ball Fresh Rubber brand Macao B2B.", 6, 556.52625f, false, null, "614ed0a3-c30f-4193-a3ea-21c396bffcc5", 15, null, new DateTimeOffset(new DateTime(2022, 7, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 27, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Shanahan - Westback up Visionary microchip Manager Refined Wooden Tuna invoice SMS Steel lavender Grocery Borders Outdoors multi-byte Rustic Metal Computer auxiliary info-mediaries Ranch programming port California Stravenue.", 3, 831.8872f, false, null, "4aa50ef6-4121-455c-bc23-d274242678ee", 10, null, new DateTimeOffset(new DateTime(2022, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Wolf, Harvey and SchaeferUSB virtual unleash Accounts Wooden grey card Director Fantastic Granite Car navigating Home Loan Account Adaptive.", 7, 984.8326f, false, null, "0147d174-6dd4-45e8-8582-3395c3d1b281", 18, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Hahn, Witting and WaelchiPersevering Practical Plastic Chips deposit Brand AI Savings Account Rustic Wooden Hat Awesome Granite Pants Dale payment bypass Books, Computers & Music invoice Dale Wooden global Plains invoice user-facing compressing Legacy solid state monetize RAM Baby, Electronics & Toys red.", 7, 73.07881f, false, null, "0147d174-6dd4-45e8-8582-3395c3d1b281", 17, null, new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Stamm, Zemlak and Gaylordprojection TCP Station feed port Home Loan Account hub Yemeni Rial calculate maroon Licensed Steel Ball Bedfordshire exuding Bedfordshire turquoise Parks Practical Steel Chair Forward Soft neural Savings Account Generic Wooden Bike Intelligent Soft Pizza Investment Account.", 2, 798.1858f, false, null, "0147d174-6dd4-45e8-8582-3395c3d1b281", 3, null, new DateTimeOffset(new DateTime(2022, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 25, new DateTimeOffset(new DateTime(2022, 7, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 5 offer", 5, 120f, false, null, "792e95d9-7604-47bc-bb22-08ed374e0b3b", 25, null, new DateTimeOffset(new DateTime(2022, 7, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 21, new DateTimeOffset(new DateTime(2022, 7, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 1 offer", 5, 120f, false, null, "792e95d9-7604-47bc-bb22-08ed374e0b3b", 21, null, new DateTimeOffset(new DateTime(2022, 7, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 23, new DateTimeOffset(new DateTime(2022, 7, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 3 offer", 1, 120f, false, null, "4aa50ef6-4121-455c-bc23-d274242678ee", 23, null, new DateTimeOffset(new DateTime(2022, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "VonRueden - DachFocused matrix primary context-sensitive Mission Director Rufiyaa connecting compress Assistant circuit Front-line synergies Incredible Cotton Soap application cross-platform Harbor 3rd generation Legacy Metal PNG.", 7, 475.9173f, false, null, "792e95d9-7604-47bc-bb22-08ed374e0b3b", 1, null, new DateTimeOffset(new DateTime(2022, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 27, new DateTimeOffset(new DateTime(2022, 7, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 7 offer", 4, 120f, false, null, "4aa50ef6-4121-455c-bc23-d274242678ee", 27, null, new DateTimeOffset(new DateTime(2022, 7, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 26, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 6 offer", 4, 120f, false, null, "f97c39af-da23-472d-8c0a-04c91f830eb5", 26, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 22, new DateTimeOffset(new DateTime(2022, 7, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 2 offer", 5, 120f, false, null, "f97c39af-da23-472d-8c0a-04c91f830eb5", 22, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodsWeight", "IsClosed", "NotificationId", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 24, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Schmitt - Buckridgeinterface Cotton Incredible Steel Table deposit model synergy cyan 24/7 indexing Licensed customer loyalty Practical Steel Chair knowledge user Ecuador Refined Pennsylvania.", 1, 721.8478f, false, null, "f97c39af-da23-472d-8c0a-04c91f830eb5", 16, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Parisian - GibsonChilean Peso Intelligent Granite Cheese Associate Lead Accounts magenta Road copy infomediaries Dynamic Hryvnia Crossroad B2C mint green 24/7 Refined Cotton Soap Extension cyan Synchronised viral multi-state Forward Rustic Cotton Mouse.", 1, 282.69745f, false, null, "f97c39af-da23-472d-8c0a-04c91f830eb5", 8, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Labadie IncHandmade Cotton Ball USB Som directional Officer withdrawal Rubber Enhanced Tasty Metal Chicken Intranet Home Loan Account Buckinghamshire Right-sized.", 4, 547.1726f, false, null, "614ed0a3-c30f-4193-a3ea-21c396bffcc5", 4, null, new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Bergnaum LLCAI human-resource Fundamental deposit Cliffs Awesome Fresh Computer Hill lavender Engineer Steel.", 1, 214.20059f, false, null, "792e95d9-7604-47bc-bb22-08ed374e0b3b", 13, null, new DateTimeOffset(new DateTime(2022, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "InitialDistance", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 2, "I'm going from Kyiv to Rivne. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 400f, false, false, 2000f, 15, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (30.36545 50.45624, 28.68603 50.26679, 27.62649 50.58838, 26.2517 50.62034)"), new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, "f97c39af-da23-472d-8c0a-04c91f830eb5" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "InitialDistance", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 3, "I'm going from Lutsk to Uzhhorod. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 400f, false, false, 2000f, 15, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (25.35595 50.7553, 24.76512 50.50216, 24.63097 50.28358, 24.00991 49.77351, 23.85867 49.26081, 22.3112 48.60822)"), new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 10, "792e95d9-7604-47bc-bb22-08ed374e0b3b" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "InitialDistance", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 1, "It`s my first offer!", 150f, null, new DateTimeOffset(new DateTime(2022, 8, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 150f, false, false, 2000f, 20, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (30.2557039 48.7424709, 30.3017199 48.1390924, 30.3174055 47.0235592, 30.6598914 46.4932837)"), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "614ed0a3-c30f-4193-a3ea-21c396bffcc5" });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Country", "Location", "OfferId", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 33, "проспект Перемоги, ст. метро Житомирська", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.36545 50.45624)"), null, 1, "02000", "Київcька область", "Київ", 2 },
                    { 34, "вулиця Київська, 77", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.68603 50.26679)"), null, 2, "10001", "Житомирська область", "Житомир", 2 },
                    { 35, "вулиця Житомирська, 41-А", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (27.62649 50.58838)"), null, 3, "11702", "Житомирська область", "Новоград-Волинський", 2 },
                    { 36, "майдан Незалежності, 2", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.2517 50.62034)"), null, 4, "33000", "Рівненська область", "Рівне", 2 },
                    { 37, "вулиця Сухомлинського, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.35595 50.7553)"), null, 1, "43000", "Волинська область", "Луцьк", 3 },
                    { 38, "вулиця Луцька, 27", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.76512 50.50216)"), null, 2, "45700", "Волинська область", "Горохів", 3 },
                    { 39, "вулиця Витківська", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.63097 50.28358)"), null, 3, "80200", "Львівська область", "Радехів", 3 },
                    { 40, "вулиця Стрийська, 30 ТРЦ King Cross Leopolis", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.00991 49.77351)"), null, 4, "81130", "Львівська область", "Сокільники", 3 },
                    { 41, "вулиця Дубравського, 6", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (23.85867 49.26081)"), null, 5, "82400", "Львівська область", "Стрий", 3 },
                    { 42, "вулиця Верещагіна, 16", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (22.3112 48.60822)"), null, 6, "88000", "Закарпатська область", "Ужгород", 3 },
                    { 29, "вулиця Волкова, 2", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.2557039 48.7424709)"), null, 1, "20300", "Черкаська область", "Умань", 1 },
                    { 30, "48Q2+JJ", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3017199 48.1390924)"), null, 2, "20300", "Одеська область", "Дубинове", 1 },
                    { 31, "28F8+9X", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3174055 47.0235592)"), null, 3, "20300", "Одеська область", "Знам'янка", 1 },
                    { 32, "вулиця Мічуріна, 41", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.6598914 46.4932837)"), null, 4, "65000", "Одеська область", "Одеса", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0bb91cd1-4f34-4342-8455-d09132b6f169");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75a5b518-da54-4f93-bd7a-c793508b0925", "0147d174-6dd4-45e8-8582-3395c3d1b281" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75a5b518-da54-4f93-bd7a-c793508b0925", "2b4f6cbc-d9c6-465e-a94c-7c9138228945" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75a5b518-da54-4f93-bd7a-c793508b0925", "4aa50ef6-4121-455c-bc23-d274242678ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75a5b518-da54-4f93-bd7a-c793508b0925", "614ed0a3-c30f-4193-a3ea-21c396bffcc5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc8ef21d-0e05-4985-bad1-6821df1a7720", "766b3277-a89e-4d70-86c6-7d9f23c854e0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75a5b518-da54-4f93-bd7a-c793508b0925", "792e95d9-7604-47bc-bb22-08ed374e0b3b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75a5b518-da54-4f93-bd7a-c793508b0925", "f04495ec-270a-4fce-87f2-740cca1575dd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75a5b518-da54-4f93-bd7a-c793508b0925", "f97c39af-da23-472d-8c0a-04c91f830eb5" });

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

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
                table: "Offers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a5b518-da54-4f93-bd7a-c793508b0925");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc8ef21d-0e05-4985-bad1-6821df1a7720");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0147d174-6dd4-45e8-8582-3395c3d1b281");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b4f6cbc-d9c6-465e-a94c-7c9138228945");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4aa50ef6-4121-455c-bc23-d274242678ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "766b3277-a89e-4d70-86c6-7d9f23c854e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f04495ec-270a-4fce-87f2-740cca1575dd");

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "614ed0a3-c30f-4193-a3ea-21c396bffcc5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "792e95d9-7604-47bc-bb22-08ed374e0b3b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f97c39af-da23-472d-8c0a-04c91f830eb5");

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
