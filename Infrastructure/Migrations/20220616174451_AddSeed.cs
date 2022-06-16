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
                    { "d7fe5b77-9194-4e13-90dd-7ba7528a5fe3", "d7fe5b77-9194-4e13-90dd-7ba7528a5fe3", "Logist", "LOGIST" },
                    { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "User", "USER" },
                    { "35bcfb0b-3b50-44cd-8410-4cdfbedec6a9", "35bcfb0b-3b50-44cd-8410-4cdfbedec6a9", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmationEmailToken", "ConfirmationEmailTokenExpirationDate", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4bb182a2-00a4-4ace-b38b-ea99d7b22f9d", 0, "e33f0a3a-b593-41d2-b8d0-23ef9114b9c5", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEK6kHvBIXeFLEpsz3zQng4lvHojsk/dTB8aMYMvKoLZZdxciI0c4BbqC4ffitWM1Qg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 17, 44, 51, 422, DateTimeKind.Unspecified).AddTicks(7129), new TimeSpan(0, 0, 0, 0, 0)), "afa2fdd1-9f01-45b9-9823-9245db758cd4", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "6ff750e2-934d-4914-a88b-37497bf479b7", 0, "0c39db58-8d8b-4a9c-9593-fecd183ae563", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEDPcsgHAPWURuthy6L9iKoJbFb8xqC0e/Uk4tNkJDmCst07VFPk91Rt4TZ2m6Ndw3g==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 17, 44, 51, 422, DateTimeKind.Unspecified).AddTicks(7121), new TimeSpan(0, 0, 0, 0, 0)), "591bbcb7-f196-45b7-91d4-c77f16c9a87f", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "9b502861-c19a-4d58-92e6-e2984425999a", 0, "421b1fe4-a964-403e-8fe5-ebd6a67ed400", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEA075V+c2ztW72UaQ37d7S65XXTmFiECatwxhbUULg3wIcyn9AsotfvNnpLenVygng==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 17, 44, 51, 422, DateTimeKind.Unspecified).AddTicks(7112), new TimeSpan(0, 0, 0, 0, 0)), "cedb1de6-a84f-462e-90cc-a9c09da17852", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "ba41b77b-afc7-4fa2-b77a-688a9b6ec13b", 0, "a4d1103b-dba7-486a-8ce4-205cd190b48c", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEG5yqlyXox0g+q1IgoEeHuVb/429w1Gr/5Ac3fLjdMyysCLhT7hXbCvIGax8+ufpIw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 17, 44, 51, 422, DateTimeKind.Unspecified).AddTicks(7104), new TimeSpan(0, 0, 0, 0, 0)), "b20efb93-9504-4035-8ac6-06f4747a5142", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "7214fe7d-0871-477a-9b19-b26151472ba6", 0, "884f0e94-3ce8-4ab6-bd38-5b18b6870d65", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEC58Wc0nNYxBk8MJcfHlONXeALhZr1akYaeeVM5hPFHbf3/w0KEdXoauSnANfpAVDQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 17, 44, 51, 422, DateTimeKind.Unspecified).AddTicks(7095), new TimeSpan(0, 0, 0, 0, 0)), "f2223ffc-b2e9-45a9-a518-686a0859fc0f", "Kernychna", false, "mapourse@gmail.com" },
                    { "ead52ad4-ee72-4929-9bb9-45982ccbeba7", 0, "d7ebc4c6-0f4c-4e04-a806-e6f4ddad28b1", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEGssW+MHXrEEu0JZAJyEz1gHNL/EtgKqX/v4N3yhNlhcVlZbItaMoaFAMSQVIKsyCQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 17, 44, 51, 422, DateTimeKind.Unspecified).AddTicks(7078), new TimeSpan(0, 0, 0, 0, 0)), "5c873297-c077-424a-9a58-e891f156b3eb", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "07e6c00f-78b3-42d4-aa7f-f44a8896f423", 0, "d1b6f74e-7ddc-472f-83be-2fed8c0765ac", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEE0ykcKb+oe54+UmNiAsf4GrvHHaCFaowMFk7SkIdRZVdD3bdjDyoVO/pl/4N/zivg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 17, 44, 51, 422, DateTimeKind.Unspecified).AddTicks(7052), new TimeSpan(0, 0, 0, 0, 0)), "bb804624-b104-4894-ba15-14c91c256a6a", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "3666a74a-eb57-4b86-8eda-4acb09cbc789", 0, "c29e92f3-1e2e-4b15-9d37-c620d1693c22", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEAj2F5eozfgU6ijGjSTT4XtH9iG3eswDo4UxN18h1cFyFydcaHYZ1ejYHMi3MNc1mQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 16, 17, 44, 51, 422, DateTimeKind.Unspecified).AddTicks(6271), new TimeSpan(0, 0, 0, 0, 0)), "d041dfb9-5a0d-4146-b950-2aaa282561fe", "Chorrny", false, "chorrny228@gmail.com" }
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
                    { "d7fe5b77-9194-4e13-90dd-7ba7528a5fe3", "ead52ad4-ee72-4929-9bb9-45982ccbeba7" },
                    { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "ba41b77b-afc7-4fa2-b77a-688a9b6ec13b" },
                    { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "6ff750e2-934d-4914-a88b-37497bf479b7" },
                    { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "7214fe7d-0871-477a-9b19-b26151472ba6" },
                    { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "9b502861-c19a-4d58-92e6-e2984425999a" },
                    { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "07e6c00f-78b3-42d4-aa7f-f44a8896f423" },
                    { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "3666a74a-eb57-4b86-8eda-4acb09cbc789" },
                    { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "4bb182a2-00a4-4ace-b38b-ea99d7b22f9d" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 8, 3, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 786.22546f, "Nissan,Titan King Cab, Pickup", "H0C5588P2RGLY63AV136", "NRH6NIQMYSMTSWM0J97K", "4bb182a2-00a4-4ace-b38b-ea99d7b22f9d", "Y0W3KUTXLEE60PI5H" },
                    { 7, 3, "Grey", new DateTimeOffset(new DateTime(2016, 7, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 497.02664f, "Jeep,Wrangler, SUV", "B2ERVFFV9AVH7ZSVBVSR", "IA46AEW27S9JC2RK693C", "4bb182a2-00a4-4ace-b38b-ea99d7b22f9d", "31WECSVK0SCOJ1X7H" },
                    { 5, 2, "Blue", new DateTimeOffset(new DateTime(2016, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 608.77136f, "Ford,F350 Super Duty Super Cab, Pickup", "LSZX6B2C0NBZ56XVBIOA", "OP127NZWG4JFANG3VD0A", "4bb182a2-00a4-4ace-b38b-ea99d7b22f9d", "LUJTFFM414YYSWRXQ" },
                    { 1, 4, "Blue", new DateTimeOffset(new DateTime(2016, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 588.43787f, "Ford,F350 Super Duty Crew Cab, Pickup", "26NL7X9E1M5VLINJEESV", "6E25A1XE9L2DT3M3ICOE", "6ff750e2-934d-4914-a88b-37497bf479b7", "MM7M1A0BXL914N4IA" },
                    { 10, 3, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 660.0813f, "Ford,F350 Super Duty Crew Cab, Pickup", "V9EHN4L0AFM2U7NIYMZG", "ITVI8EKY13AM5T3AH5KS", "ba41b77b-afc7-4fa2-b77a-688a9b6ec13b", "N9YQVW8P7KN5U1EW9" },
                    { 2, 3, "White", new DateTimeOffset(new DateTime(2016, 7, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 680.8021f, "Jeep,Wrangler Unlimited, SUV", "GJS2HVJ01QDJESFXOZME", "XOG3SZZZ01HDGM53EJKE", "3666a74a-eb57-4b86-8eda-4acb09cbc789", "VVVHPUOKM7EG7S2OA" },
                    { 4, 2, "Red", new DateTimeOffset(new DateTime(2016, 7, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 722.7849f, "Porsche,911, Convertible, Coupe", "VCP0CXYCWCXYEXITHUEJ", "99TQNPAPVAJX07LFGH72", "3666a74a-eb57-4b86-8eda-4acb09cbc789", "2WUB6MF7LIVTKMJZD" },
                    { 9, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 847.10504f, "Nissan,TITAN XD Crew Cab, Pickup", "A4MS2K2QMUIJSSHAKXWT", "168EMVWHERK314OV9AIA", "7214fe7d-0871-477a-9b19-b26151472ba6", "YKWN8W1VXOKSP3W86" },
                    { 3, 3, "Red", new DateTimeOffset(new DateTime(2016, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 606.41034f, "Jeep,Wrangler, SUV", "08Z3SNCJ4E7XNSL8A94A", "FFAZ0ED0P92IWAVNVDX7", "7214fe7d-0871-477a-9b19-b26151472ba6", "HS6IKZHGZ8R9KKX02" },
                    { 6, 3, "Red", new DateTimeOffset(new DateTime(2016, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 880.52844f, "Porsche,911, Convertible, Coupe", "V3WOIQT0YIDXT46ID7KA", "C2EGCUKCXNGY6YPRN4XP", "07e6c00f-78b3-42d4-aa7f-f44a8896f423", "3ML0YRKFCBRVKSOFC" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Wisoky, Crist and ToyBaby, Tools & Electronics proactive Outdoors & Movies transmit cultivate portal Gorgeous Wooden Cheese Gorgeous SAS moderator transmitter primary web-readiness Wooden open-source deposit.", new DateTimeOffset(new DateTime(2022, 7, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 493.51743f, false, "7214fe7d-0871-477a-9b19-b26151472ba6", 8, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Fahey, Ebert and HermanSmall Frozen Pants multi-byte Dong Kenya customer loyalty Libyan Dinar local area network Granite International bandwidth parse Home, Outdoors & Books Sleek Soft Pizza Niger Azerbaijanian Manat leverage Avenue Pa'anga dynamic Clothing transform Road monitoring Libyan Arab Jamahiriya Ameliorated next-generation responsive indexing Operations.", new DateTimeOffset(new DateTime(2022, 7, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 404.12244f, false, "3666a74a-eb57-4b86-8eda-4acb09cbc789", 2, null, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Bergnaum, Towne and BeierMotorway Granite Managed Rwanda Franc transmitter Visionary Somalia Aruban Guilder full-range CSS Causeway India.", new DateTimeOffset(new DateTime(2022, 7, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 20.016426f, false, "3666a74a-eb57-4b86-8eda-4acb09cbc789", 12, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Friesen, Kerluke and Goodwinpayment connect Intranet withdrawal Corporate Awesome Granite Tuna SMS microchip Lead calculating Auto Loan Account.", new DateTimeOffset(new DateTime(2022, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 864.7106f, false, "3666a74a-eb57-4b86-8eda-4acb09cbc789", 14, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Shields, Runolfsson and Monahanturquoise Manager Canyon Generic Steel Car bandwidth Convertible Marks Incredible Steel Chicken grid-enabled FTP calculate Rial Omani front-end Sports cross-platform integrated.", new DateTimeOffset(new DateTime(2022, 7, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 30.457544f, false, "3666a74a-eb57-4b86-8eda-4acb09cbc789", 19, null, new DateTimeOffset(new DateTime(2022, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 24, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Lynch - JacobiROI Ergonomic back-end Manager Internal channels vertical Way enterprise Personal Loan Account back-end Bedfordshire Pike Compatible transmitting PCI encoding Internal Bedfordshire Innovative Colorado Roads Fall Roads bi-directional bluetooth District Incredible.", new DateTimeOffset(new DateTime(2022, 7, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 785.39795f, false, "4bb182a2-00a4-4ace-b38b-ea99d7b22f9d", 11, null, new DateTimeOffset(new DateTime(2022, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Bradtke - GradyEstates Customer application indigo Intelligent Cotton Chair online Tunnel Fresh Berkshire synergies Web Awesome.", new DateTimeOffset(new DateTime(2022, 7, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 246.3424f, false, "07e6c00f-78b3-42d4-aa7f-f44a8896f423", 6, null, new DateTimeOffset(new DateTime(2022, 7, 5, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Schulist - Emardvertical Rubber Switzerland Up-sized supply-chains proactive Operations View system Focused Estates Dominica Georgia Toys, Garden & Automotive Credit Card Account Open-source Ferry online Fantastic Rustic Soft Soap red invoice Pennsylvania Awesome Frozen Table Granite Senior cutting-edge function.", new DateTimeOffset(new DateTime(2022, 7, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 66.00247f, false, "07e6c00f-78b3-42d4-aa7f-f44a8896f423", 7, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "McKenzie LLCclient-driven open-source Granite Fantastic Fresh Chicken instruction set Developer Pass Manager Mobility morph Cotton optimize installation wireless protocol Frozen Fantastic Kenyan Shilling Dalasi lavender PCI Estate withdrawal target.", new DateTimeOffset(new DateTime(2022, 7, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 639.7229f, false, "6ff750e2-934d-4914-a88b-37497bf479b7", 20, null, new DateTimeOffset(new DateTime(2022, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 30, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Schuster - Thielalarm enhance Technician functionalities Usability Concrete Phased Ukraine Metrics Licensed Steel Cheese content Burgs Valleys national wireless Movies override microchip Toys & Shoes Personal Loan Account Liaison Circle virtual bandwidth.", new DateTimeOffset(new DateTime(2022, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 74.5649f, false, "7214fe7d-0871-477a-9b19-b26151472ba6", 5, null, new DateTimeOffset(new DateTime(2022, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Weissnat, Quitzon and DaughertyNorth Carolina Buckinghamshire invoice Rubber Niger Brand GB Awesome Concrete Bike Lead Industrial & Movies.", new DateTimeOffset(new DateTime(2022, 7, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 225.2145f, false, "6ff750e2-934d-4914-a88b-37497bf479b7", 15, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Hilll, Nader and Ratkeleverage Mount teal Nigeria Rapid Polarised Human monetize navigating Corporate Checking Account Innovative Optimization Research calculating Analyst Designer withdrawal payment Electronics, Health & Outdoors Consultant interfaces Liaison invoice Developer.", new DateTimeOffset(new DateTime(2022, 7, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 558.4439f, false, "6ff750e2-934d-4914-a88b-37497bf479b7", 4, null, new DateTimeOffset(new DateTime(2022, 7, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 21, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Kuvalis and SonsIncredible Granite Computer Seamless Corporate CFA Franc BEAC Home, Garden & Movies transform override Senior customized Louisiana Pakistan neural Sleek Wooden Shoes Sports Wisconsin mobile Engineer International orange Handcrafted Camp Macao viral.", new DateTimeOffset(new DateTime(2022, 7, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 547.65125f, false, "07e6c00f-78b3-42d4-aa7f-f44a8896f423", 10, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Leuschke LLCPrincipal recontextualize European Unit of Account 17(E.U.A.-17) Tanzanian Shilling payment Planner Analyst JSON silver Handcrafted.", new DateTimeOffset(new DateTime(2022, 7, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 714.5301f, false, "9b502861-c19a-4d58-92e6-e2984425999a", 18, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Pouros - FayAgent Crossing Corporate Savings Account Zimbabwe Borders Developer North Carolina calculate Handcrafted Unbranded Mountains engage Cotton fuchsia haptic input Small Rubber Pizza Credit Card Account withdrawal Facilitator monitor Jewelery Implemented Intranet Shoal Incredible Fresh Fish.", new DateTimeOffset(new DateTime(2022, 7, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 310.05103f, false, "9b502861-c19a-4d58-92e6-e2984425999a", 17, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Rath, Streich and JohnsDeveloper Mission Central online red Granite Garden concept copying metrics Checking Account PNG Tunnel productize Assistant Auto Loan Account Island Metal time-frame Executive Games Canadian Dollar.", new DateTimeOffset(new DateTime(2022, 7, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 488.27295f, false, "9b502861-c19a-4d58-92e6-e2984425999a", 3, null, new DateTimeOffset(new DateTime(2022, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Quigley - Hahnport bus Rubber Home Loan Account Bermudian Dollar (customarily known as Bermuda Dollar) intermediate concept grid-enabled Plastic Sports & Health Fantastic Metrics Plaza transitional Monaco Somoni parse violet wireless Handmade Frozen Keyboard Mauritius Rupee.", new DateTimeOffset(new DateTime(2022, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 310.10156f, false, "ba41b77b-afc7-4fa2-b77a-688a9b6ec13b", 1, null, new DateTimeOffset(new DateTime(2022, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 29, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Pollich, Cruickshank and Leannonmission-critical Central Plastic real-time cross-platform payment indexing Manat Tasty Frozen Chicken vortals application Ville Bulgarian Lev Electronics & Books Connecticut Senior Outdoors & Home Home Loan Account.", new DateTimeOffset(new DateTime(2022, 7, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 868.94507f, false, "7214fe7d-0871-477a-9b19-b26151472ba6", 16, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Ebert - Jenkinssolid state generate Optimization quantify International complexity input Credit Card Account withdrawal Steel Small circuit e-commerce.", new DateTimeOffset(new DateTime(2022, 7, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 586.99963f, false, "07e6c00f-78b3-42d4-aa7f-f44a8896f423", 9, null, new DateTimeOffset(new DateTime(2022, 7, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "McCullough - Pfannerstilldeposit Lek e-commerce Rustic Rubber Bike paradigms deposit payment Beauty, Beauty & Books sensor input Tactics Applications District Direct Fantastic ivory SAS Supervisor revolutionize auxiliary Centers benchmark.", new DateTimeOffset(new DateTime(2022, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 725.604f, false, "ba41b77b-afc7-4fa2-b77a-688a9b6ec13b", 13, null, new DateTimeOffset(new DateTime(2022, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35bcfb0b-3b50-44cd-8410-4cdfbedec6a9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "07e6c00f-78b3-42d4-aa7f-f44a8896f423" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "3666a74a-eb57-4b86-8eda-4acb09cbc789" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "4bb182a2-00a4-4ace-b38b-ea99d7b22f9d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "6ff750e2-934d-4914-a88b-37497bf479b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "7214fe7d-0871-477a-9b19-b26151472ba6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "9b502861-c19a-4d58-92e6-e2984425999a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dbd1f5c6-edc1-46f8-aadd-2034d5469411", "ba41b77b-afc7-4fa2-b77a-688a9b6ec13b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d7fe5b77-9194-4e13-90dd-7ba7528a5fe3", "ead52ad4-ee72-4929-9bb9-45982ccbeba7" });

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
                keyValue: "d7fe5b77-9194-4e13-90dd-7ba7528a5fe3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbd1f5c6-edc1-46f8-aadd-2034d5469411");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07e6c00f-78b3-42d4-aa7f-f44a8896f423");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3666a74a-eb57-4b86-8eda-4acb09cbc789");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4bb182a2-00a4-4ace-b38b-ea99d7b22f9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ff750e2-934d-4914-a88b-37497bf479b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7214fe7d-0871-477a-9b19-b26151472ba6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b502861-c19a-4d58-92e6-e2984425999a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba41b77b-afc7-4fa2-b77a-688a9b6ec13b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ead52ad4-ee72-4929-9bb9-45982ccbeba7");

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
