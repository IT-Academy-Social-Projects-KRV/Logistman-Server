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
                    { "6405ced5-a5f2-4528-834b-d4f0696dc6f2", "6405ced5-a5f2-4528-834b-d4f0696dc6f2", "Logist", "LOGIST" },
                    { "4c6485a3-9532-4e26-8b0f-a923e1857628", "4c6485a3-9532-4e26-8b0f-a923e1857628", "User", "USER" },
                    { "49760de6-8907-40db-9f43-92c5c00c5756", "49760de6-8907-40db-9f43-92c5c00c5756", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmationEmailToken", "ConfirmationEmailTokenExpirationDate", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9a39781d-7e44-4481-aa45-80307aa6f2d8", 0, "6ea7df32-ce3b-4d0f-bbbd-9493be476ed0", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEN5AMqR98eckEh8TtRgD3xzkQ0cT3YwKVd/SJU9/LDyDwWUo6uqwLw0mSD/2CGKKdA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 13, 8, 45, 37, 902, DateTimeKind.Unspecified).AddTicks(1892), new TimeSpan(0, 0, 0, 0, 0)), "cabf9f71-f34d-46ba-908a-b1d4f742256e", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "16441472-4400-461b-831f-a2270eed2ac1", 0, "fbf86d36-40fd-4b77-b754-024e49c0e0d2", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEANGMYAax9WMPZp25cR7O1Y55FBL02qHirUVzMKb/sNadKHF8Mn0lOPItd/SGRRLEA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 13, 8, 45, 37, 902, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), "644ebd80-2d85-4bbb-a376-fc0ed48981fc", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "08316800-d508-4238-8ed5-a2b93bd0dfff", 0, "7578db9b-c700-49d9-ab1b-37b583ec84b0", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEJcZUnOYefy+VDY7qIV6tKTbsoge9rg+rY0WEgN5J+tsST64Si66+b3EBvaxziFtVQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 13, 8, 45, 37, 902, DateTimeKind.Unspecified).AddTicks(1867), new TimeSpan(0, 0, 0, 0, 0)), "6b67ef8f-eedf-431c-a034-cebb23193a00", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "7254a20d-6758-471f-a820-be2a51cb1e0e", 0, "9909d171-7f3f-4122-884b-14deeffcc4d4", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEMvQfm14vHbz7of1WtvJ+IlC0Wnh1z5EhLRJ4uYTHmwyRnExiIVZceyi4Q0FAcDL1Q==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 13, 8, 45, 37, 902, DateTimeKind.Unspecified).AddTicks(1855), new TimeSpan(0, 0, 0, 0, 0)), "edef53ea-74df-4913-8ecf-dd271c7c73ff", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "640450d6-5f42-410a-9b47-54183b100f1d", 0, "dd34d5a5-9e02-45ab-9ea6-494ad0a9d9dd", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEGP2M3KL7kpxGFx4ko30A+Te8pTz5UN4KBQP5pncrdO8d7hshK3OE+RA5xk4zWcSgg==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 13, 8, 45, 37, 902, DateTimeKind.Unspecified).AddTicks(1843), new TimeSpan(0, 0, 0, 0, 0)), "0e6e115c-d9d9-4e55-be00-a35ca1f73c30", "Kernychna", false, "mapourse@gmail.com" },
                    { "d513bf1f-dc07-41d7-8e34-23efaca49450", 0, "f557b545-637d-4e1e-985e-8e283287f440", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEJRLB8YT37Wh1AbbvHAVJTxb6/NT9I5knnQOKo9bWXtAa7AeKMYbjWxd8y2X1QuBPQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 13, 8, 45, 37, 902, DateTimeKind.Unspecified).AddTicks(1825), new TimeSpan(0, 0, 0, 0, 0)), "8fb1cf1b-3f16-4444-92ce-ee3e969cb2fd", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "b0e57555-7acd-4b2f-9a06-f160ca755570", 0, "2ba56775-9655-48cf-b8b2-74653a653696", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEFNhgEDMpQ8hNgvXcRpNJUxsCtxqjV5E4Lx400gEF+KoPgydSYOuvAvPaWtrjjTcbQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 13, 8, 45, 37, 902, DateTimeKind.Unspecified).AddTicks(1778), new TimeSpan(0, 0, 0, 0, 0)), "df3248ec-1e46-4df6-93af-f9aa571cbc26", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "5858b40a-226d-4043-8983-c042bc72740f", 0, "1c100446-416c-48b4-b244-968d7932b2f6", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAECpFwW/YypTFHr0NPD6DsW38b284Gwiw63w1iSyYNJf5U3gs7Vi/1NnH7IZWFtETEg==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 13, 8, 45, 37, 902, DateTimeKind.Unspecified).AddTicks(124), new TimeSpan(0, 0, 0, 0, 0)), "4e87cdda-cd3a-460f-b35a-1219eb9fc2c2", "Chorrny", false, "chorrny228@gmail.com" }
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
                columns: new[] { "Id", "Address", "Country", "IsStopover", "Location", "OfferId", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 24, "вулиця Шевченка, 10", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.9116167 47.1991193)"), 24, 0, "67301", "Одеська область", "Березівка", null },
                    { 25, "Трасса Е 95", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.317371 47.0234622)"), 25, 0, "67211", "Одеська область", "Знам'янка", null },
                    { 26, "48Q2+JJ Дубинове", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3017199 48.1390924)"), 26, 0, "66220", "Одеська область", "Дубинове", null },
                    { 2, "вулиця Соборна, 5", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.2614291 50.6175848)"), 2, 0, "33000", "Рівненська область", "Рівне", null },
                    { 28, "вул. Станціонна, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.4974225 47.5464278)"), 28, 0, "55642", "Миколаївська область", "Новополтавка", null },
                    { 23, "Криве Озеро", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3443027 47.9484405)"), 23, 0, "55100", "Миколаївська область", "Криве Озеро", null },
                    { 27, "вулиця Медична, 19", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (33.3832712 47.8876902)"), 27, 0, "50005", "Дніпропетровська область", "Кривий Ріг", null },
                    { 22, "Центральна 119", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.1641172 48.1413224)"), 22, 0, "66221", "Одеська область", "Вільшанка", null },
                    { 21, "вул Соборна 44б", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.4570465 48.3880023)"), 21, 0, "26500", "Кіровоградська область", "Голованівськ", null },
                    { 20, "вулиця Бориса Тена, 2", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.6727154 50.2541948)"), 20, 0, "10001", "Житомирська область", "Житомир", null },
                    { 3, "Вишнівецька вулиця, 30", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.3839251 50.724626)"), 3, 0, "43000", "Волинська область", "Луцьк", null },
                    { 4, "вулиця Юрія Савченко, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.0256349 48.4674516)"), 4, 0, "49000", "Дніпропетровська область", "Дніпро", null },
                    { 5, "вулиця Пушкіна, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.3386598 47.1917281)"), 5, 0, "87000", "Донецька область", "Нікольське", null },
                    { 6, "вулиця Садова, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0033648 46.9690278)"), 6, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 7, "вулиця Павлова, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2345305 48.5175858)"), 7, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 8, "вулиця Чкалова, 20", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2277797 48.5183484)"), 8, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 9, "Посадочна вулиця, 5", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2269653 48.5181244)"), 9, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 1, "вулиця Східна, 32", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5283633 50.3288577)"), 1, 0, "35800", "Рівненська область", "Острог", null }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Country", "IsStopover", "Location", "OfferId", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 10, "вулиця Юрія Савченка, 3", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.0247707 48.4658504)"), 10, 0, "49000", "Дніпропетровська область", "Дніпро", null },
                    { 12, "вулиця Шишкіна, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (22.3178905 48.6102995)"), 12, 0, "88000", "Закарпатська область", "Ужгород", null },
                    { 13, "вулиця Козацька, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.9919167 49.4178562)"), 13, 0, "29000", "Хмельницька  область", "Хмельницький", null },
                    { 14, "вулиця Братиславська, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (33.3286723 47.8847308)"), 14, 0, "50000", "Дніпропетровська область", "Кривий Ріг", null },
                    { 16, "вулиця Привільна, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0222338 46.9858772)"), 16, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 17, "вулиця Привільна, 10", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0210963 46.9880672)"), 17, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 18, "вулиця В'ячеслава Чорновола, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.36196 50.755603)"), 18, 0, "43000", "Волинська область", "Луцьк", null },
                    { 19, "вулиця Острозька, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.8544323 50.3006939)"), 19, 0, "30000", "Хмельницька область", "Славута", null },
                    { 11, "просп. Вячеслава Черновола, 11", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.0253381 49.8468734)"), 11, 0, "79000", "Львівська область", "Львів", null },
                    { 15, "вулиця Слов'янська, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0147107 47.031949)"), 15, 0, "54000", "Миколаївська область", "Миколаїв", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6405ced5-a5f2-4528-834b-d4f0696dc6f2", "d513bf1f-dc07-41d7-8e34-23efaca49450" },
                    { "4c6485a3-9532-4e26-8b0f-a923e1857628", "7254a20d-6758-471f-a820-be2a51cb1e0e" },
                    { "4c6485a3-9532-4e26-8b0f-a923e1857628", "16441472-4400-461b-831f-a2270eed2ac1" },
                    { "4c6485a3-9532-4e26-8b0f-a923e1857628", "640450d6-5f42-410a-9b47-54183b100f1d" },
                    { "4c6485a3-9532-4e26-8b0f-a923e1857628", "08316800-d508-4238-8ed5-a2b93bd0dfff" },
                    { "4c6485a3-9532-4e26-8b0f-a923e1857628", "b0e57555-7acd-4b2f-9a06-f160ca755570" },
                    { "4c6485a3-9532-4e26-8b0f-a923e1857628", "5858b40a-226d-4043-8983-c042bc72740f" },
                    { "4c6485a3-9532-4e26-8b0f-a923e1857628", "9a39781d-7e44-4481-aa45-80307aa6f2d8" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 8, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 409f, "Nissan,TITAN XD Crew Cab, Pickup", "BH2333XI", "5VRB9F8VL3QU7AAOIRN0", "9a39781d-7e44-4481-aa45-80307aa6f2d8", "XBUPETF7DFTEN2MOW" },
                    { 7, 4, "Red", new DateTimeOffset(new DateTime(2016, 7, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 813f, "Nissan,Titan Crew Cab, Pickup", "BC7739AA", "B482HXAOEYFT2I02CHHD", "9a39781d-7e44-4481-aa45-80307aa6f2d8", "TYDZ6NOESHI8SL9W9" },
                    { 5, 3, "Red", new DateTimeOffset(new DateTime(2016, 7, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 886f, "Jeep,Wrangler, SUV", "BH1232AA", "0MC9U569DKNSY0LYN75Z", "9a39781d-7e44-4481-aa45-80307aa6f2d8", "9D5VJB6QSJ2H1UVEN" },
                    { 1, 4, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 896f, "Ford,F250 Super Duty Super Cab, Pickup", "AA4567XI", "N9VLJJM8M8USZAZ3CDYX", "16441472-4400-461b-831f-a2270eed2ac1", "5DW67LAEPY5OVK342" },
                    { 10, 3, "Blue", new DateTimeOffset(new DateTime(2016, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 707f, "Porsche,Cayenne, SUV", "AC1273IX", "4YPO467C603SMGCTNS5W", "7254a20d-6758-471f-a820-be2a51cb1e0e", "A7YDW0GWK7XR622Y2" },
                    { 9, 3, "Blue", new DateTimeOffset(new DateTime(2016, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 633f, "Jeep,Wrangler Unlimited, SUV", "AA8992BH", "DRDLAZ7RDAVOYXGGK1FF", "640450d6-5f42-410a-9b47-54183b100f1d", "B1SM72UUGKH0KJG34" },
                    { 2, 4, "Grey", new DateTimeOffset(new DateTime(2016, 7, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 538f, "Jeep,Wrangler, SUV", "BC2234OP", "QHFKT77H60PDS4HODB1X", "5858b40a-226d-4043-8983-c042bc72740f", "VNBFF08APOZVEWHLE" },
                    { 4, 4, "Grey", new DateTimeOffset(new DateTime(2016, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 999f, "Nissan,TITAN XD Crew Cab, Pickup", "AC6344AC", "I236BQD0LUONOEV5P08Y", "5858b40a-226d-4043-8983-c042bc72740f", "1H8NI71STF9IICUJA" },
                    { 6, 2, "Blue", new DateTimeOffset(new DateTime(2016, 7, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 777f, "Ford,F350 Super Duty Super Cab, Pickup", "AA5421BH", "VMPKB8KM88Y8YDY3ZMV3", "b0e57555-7acd-4b2f-9a06-f160ca755570", "3PHZR29J44ALERGB7" },
                    { 3, 3, "White", new DateTimeOffset(new DateTime(2016, 7, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 923f, "Nissan,Titan Crew Cab, Pickup", "BH4456AI", "YFA2FMFPX6WS7LR8DS78", "640450d6-5f42-410a-9b47-54183b100f1d", "0EXPL6RXNVAZX81CZ" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodTransferConfirmedByCreator", "GoodTransferConfirmedByDriver", "GoodsWeight", "IsAnsweredByCreator", "IsAnsweredByDriver", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Grady - KuhicRussian Federation Buckinghamshire Club capacitor Lead Quetzal Auto Loan Account Soft Cape Verde Iranian Rial lavender primary Views Rubber multi-byte Product plum cyan panel input Streets e-business navigate.", 4, false, false, 279.45535f, false, false, false, "640450d6-5f42-410a-9b47-54183b100f1d", 5, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Mante, Wiza and Adamssecondary Falkland Islands (Malvinas) Small Soft Car Quality-focused Plastic maximize parsing solid state composite Meadows Maine Identity Burg CSS action-items Home Loan Account Awesome New Israeli Sheqel.", 7, false, false, 495.15442f, false, false, false, "5858b40a-226d-4043-8983-c042bc72740f", 2, null, new DateTimeOffset(new DateTime(2022, 7, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Kemmer, Torp and Okunevastatic Harbor South Dakota ivory Phased synthesizing deliverables Checking Account Associate logistical Brooks human-resource Glen Cambridgeshire Guam Rubber invoice Books & Outdoors Dynamic.", 6, false, false, 311.39835f, false, false, false, "5858b40a-226d-4043-8983-c042bc72740f", 12, null, new DateTimeOffset(new DateTime(2022, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Wilderman, Huel and BoyleAvon well-modulated Bangladesh Cambridgeshire Proactive Applications Missouri drive Uzbekistan Sum Djibouti Franc Street connect portals payment connect Investment Account web services redundant El Salvador markets non-volatile Investment Account Street SSL Accounts Ergonomic Metal Salad turn-key extend Connecticut.", 6, false, false, 422.7875f, false, false, false, "5858b40a-226d-4043-8983-c042bc72740f", 14, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Schmitt - McDermottBorders interface Steel portals Rubber Functionality Director Kuwaiti Dinar Gorgeous Fresh Car foreground transmitting Arkansas Home Loan Account navigating Fresh Awesome Soft Chips Incredible Fresh Chair Licensed Rubber Bike Producer Open-source Trail withdrawal Global Cliffs navigating.", 7, false, false, 962.7477f, false, false, false, "5858b40a-226d-4043-8983-c042bc72740f", 19, null, new DateTimeOffset(new DateTime(2022, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Dibbert, Kunze and Gutkowskisystem engine Tenge quantify Montenegro Gorgeous Rubber Table customer loyalty database Savings Account Brooks Buckinghamshire District.", 1, false, false, 967.9186f, false, false, false, "9a39781d-7e44-4481-aa45-80307aa6f2d8", 11, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Breitenberg - KovacekDistrict monitoring Marketing Plastic Fantastic Steel Flats Fantastic Cotton Sausages Tactics Uganda artificial intelligence invoice Fantastic Operations bandwidth Rubber Paradigm bypassing virtual bandwidth index Exclusive.", 2, false, false, 776.7926f, false, false, false, "b0e57555-7acd-4b2f-9a06-f160ca755570", 6, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Cassin IncConcrete Officer Handmade Plastic Towels deposit XSS radical Kansas Metal Investment Account Refined Fresh Shirt Industrial, Clothing & Toys Unbranded Steel Towels Directives Checking Account Savings Account Mobility ivory Implemented parsing Credit Card Account payment Libyan Arab Jamahiriya invoice Future-proofed Dale Robust invoice Cliff AI knowledge base.", 3, false, false, 930.3759f, false, false, false, "b0e57555-7acd-4b2f-9a06-f160ca755570", 7, null, new DateTimeOffset(new DateTime(2022, 7, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "O'Connell and Sonsorchid payment Health & Toys capacitor Borders hack customer loyalty Mission cross-platform Dynamic multi-byte Operations Springs Crescent Sleek Unbranded Granite Table Soft Technician killer Intelligent Concrete Chair.", 3, false, false, 205.99028f, false, false, false, "b0e57555-7acd-4b2f-9a06-f160ca755570", 9, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 28, new DateTimeOffset(new DateTime(2022, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 8 offer", 5, false, false, 120f, false, false, false, "16441472-4400-461b-831f-a2270eed2ac1", 28, null, new DateTimeOffset(new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 24, new DateTimeOffset(new DateTime(2022, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 4 offer", 3, false, false, 120f, false, false, false, "16441472-4400-461b-831f-a2270eed2ac1", 24, null, new DateTimeOffset(new DateTime(2022, 7, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Brown - DibbertOregon systemic Summit RSS quantify IB bypassing Tasty Soft Bacon Global Metal Soft wireless Savings Account upward-trending optical Sri Lanka Developer Spurs.", 7, false, false, 869.5726f, false, false, false, "16441472-4400-461b-831f-a2270eed2ac1", 20, null, new DateTimeOffset(new DateTime(2022, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Morissette LLCMandatory Plaza Accountability Face to face COM Berkshire Ways relationships generate Savings Account Clothing, Computers & Baby extensible RSS Soft interactive Operations Credit Card Account Tasty Granite Table Unbranded Books & Garden Plastic Paraguay Alabama Wisconsin Rwanda silver Savings Account engineer transmitter Synergistic.", 7, false, false, 622.4466f, false, false, false, "16441472-4400-461b-831f-a2270eed2ac1", 15, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Ortiz LLCprimary firewall calculating Rubber parsing revolutionize invoice Metal Papua New Guinea interactive Generic Plastic Sausages encryption Australian Dollar Malta turquoise dot-com Checking Account Jewelery & Baby knowledge base global Investment Account Flat user-facing Generic Plastic Computer Dynamic application sky blue Music product Central.", 5, false, false, 170.34364f, false, false, false, "b0e57555-7acd-4b2f-9a06-f160ca755570", 10, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Block - Lockmanleading edge SQL Harbors Principal upward-trending Investment Account Generic Soft Hat implementation deposit Realigned Credit Card Account database Investment Account mobile Awesome Wooden Fish solid state.", 2, false, false, 968.45306f, false, false, false, "08316800-d508-4238-8ed5-a2b93bd0dfff", 18, null, new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Prohaska, Kris and Effertzquantifying Bedfordshire Intelligent withdrawal extend Direct synergies Louisiana navigating SCSI Taiwan deliver payment Small Cambridgeshire Kazakhstan Bedfordshire optical program.", 1, false, false, 122.06439f, false, false, false, "08316800-d508-4238-8ed5-a2b93bd0dfff", 17, null, new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Conroy - Dibbertuniform SMTP Pa'anga Accounts bi-directional cross-media Oklahoma red real-time Peso Uruguayo Gabon high-level models RSS Gorgeous Soft Bacon Small Soft Sausages portal invoice.", 4, false, false, 592.13153f, false, false, false, "08316800-d508-4238-8ed5-a2b93bd0dfff", 3, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 25, new DateTimeOffset(new DateTime(2022, 7, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 5 offer", 6, false, false, 120f, false, false, false, "7254a20d-6758-471f-a820-be2a51cb1e0e", 25, null, new DateTimeOffset(new DateTime(2022, 7, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 21, new DateTimeOffset(new DateTime(2022, 7, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 1 offer", 4, false, false, 120f, false, false, false, "7254a20d-6758-471f-a820-be2a51cb1e0e", 21, null, new DateTimeOffset(new DateTime(2022, 7, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 23, new DateTimeOffset(new DateTime(2022, 7, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 3 offer", 2, false, false, 120f, false, false, false, "b0e57555-7acd-4b2f-9a06-f160ca755570", 23, null, new DateTimeOffset(new DateTime(2022, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Williamson IncLoaf AGP Cayman Islands Colorado web services Dale circuit Director Personal Loan Account facilitate orchid New Jersey Ergonomic Metal Chips.", 1, false, false, 747.7225f, false, false, false, "7254a20d-6758-471f-a820-be2a51cb1e0e", 1, null, new DateTimeOffset(new DateTime(2022, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 27, new DateTimeOffset(new DateTime(2022, 7, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 7 offer", 7, false, false, 120f, false, false, false, "b0e57555-7acd-4b2f-9a06-f160ca755570", 27, null, new DateTimeOffset(new DateTime(2022, 7, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 26, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 6 offer", 4, false, false, 120f, false, false, false, "640450d6-5f42-410a-9b47-54183b100f1d", 26, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 22, new DateTimeOffset(new DateTime(2022, 7, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 2 offer", 1, false, false, 120f, false, false, false, "640450d6-5f42-410a-9b47-54183b100f1d", 22, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodTransferConfirmedByCreator", "GoodTransferConfirmedByDriver", "GoodsWeight", "IsAnsweredByCreator", "IsAnsweredByDriver", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Rice GroupNuevo Sol Personal Loan Account Luxembourg Administrator black Books, Outdoors & Health Incredible Balanced clear-thinking violet Handmade Metal Towels invoice Jewelery, Books & Baby Awesome Plastic Tuna bus compressing Villages THX Tunnel maximize azure payment withdrawal tan Synchronised Paradigm Falls.", 3, false, false, 413.19446f, false, false, false, "640450d6-5f42-410a-9b47-54183b100f1d", 16, null, new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 27, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Carroll, Murphy and Bashiriancopying Beauty, Grocery & Beauty Direct Response Lao People's Democratic Republic Officer Intelligent Rustic Granite Table deposit connect Sports Agent Metal.", 3, false, false, 551.429f, false, false, false, "640450d6-5f42-410a-9b47-54183b100f1d", 8, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 22, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Morissette GroupHealth, Garden & Outdoors Orchestrator Gardens Agent Buckinghamshire Beauty & Beauty Uzbekistan neutral Bosnia and Herzegovina AGP green system Rapids next generation Savings Account PCI hacking copy RSS.", 5, false, false, 659.26404f, false, false, false, "16441472-4400-461b-831f-a2270eed2ac1", 4, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Graham, Boehm and Lowemaximize Refined Organized Handmade eco-centric database RSS background payment Automated Rustic Gorgeous Metal Pants Hollow Practical Concrete Cheese Group capacitor Turnpike program Marketing invoice Sports, Tools & Outdoors concept Texas Cambridgeshire intermediate digital Corporate hard drive bypassing.", 6, false, false, 524.55054f, false, false, false, "7254a20d-6758-471f-a820-be2a51cb1e0e", 13, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 2, "I'm going from Kyiv to Rivne. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 15, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, "640450d6-5f42-410a-9b47-54183b100f1d" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 3, "I'm going from Lutsk to Uzhhorod. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 15, new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 10, "7254a20d-6758-471f-a820-be2a51cb1e0e" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 1, "It`s my first offer!", 150f, null, new DateTimeOffset(new DateTime(2022, 8, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 20, new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "16441472-4400-461b-831f-a2270eed2ac1" });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Country", "IsStopover", "Location", "OfferId", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 33, "проспект Перемоги, ст. метро Житомирська", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.36545 50.45624)"), null, 1, "02000", "Київcька область", "Київ", 2 },
                    { 34, "вулиця Київська, 77", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.68603 50.26679)"), null, 2, "10001", "Житомирська область", "Житомир", 2 },
                    { 35, "вулиця Житомирська, 41-А", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (27.62649 50.58838)"), null, 3, "11702", "Житомирська область", "Новоград-Волинський", 2 },
                    { 36, "майдан Незалежності, 2", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.2517 50.62034)"), null, 4, "33000", "Рівненська область", "Рівне", 2 },
                    { 37, "вулиця Сухомлинського, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.35595 50.7553)"), null, 1, "43000", "Волинська область", "Луцьк", 3 },
                    { 38, "вулиця Луцька, 27", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.76512 50.50216)"), null, 2, "45700", "Волинська область", "Горохів", 3 },
                    { 39, "вулиця Витківська", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.63097 50.28358)"), null, 3, "80200", "Львівська область", "Радехів", 3 },
                    { 40, "вулиця Стрийська, 30 ТРЦ King Cross Leopolis", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.00991 49.77351)"), null, 4, "81130", "Львівська область", "Сокільники", 3 },
                    { 41, "вулиця Дубравського, 6", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (23.85867 49.26081)"), null, 5, "82400", "Львівська область", "Стрий", 3 },
                    { 42, "вулиця Верещагіна, 16", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (22.3112 48.60822)"), null, 6, "88000", "Закарпатська область", "Ужгород", 3 },
                    { 29, "вулиця Волкова, 2", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.2557039 48.7424709)"), null, 1, "20300", "Черкаська область", "Умань", 1 },
                    { 30, "48Q2+JJ", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3017199 48.1390924)"), null, 2, "20300", "Одеська область", "Дубинове", 1 },
                    { 31, "28F8+9X", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3174055 47.0235592)"), null, 3, "20300", "Одеська область", "Знам'янка", 1 },
                    { 32, "вулиця Мічуріна, 41", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.6598914 46.4932837)"), null, 4, "65000", "Одеська область", "Одеса", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49760de6-8907-40db-9f43-92c5c00c5756");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c6485a3-9532-4e26-8b0f-a923e1857628", "08316800-d508-4238-8ed5-a2b93bd0dfff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c6485a3-9532-4e26-8b0f-a923e1857628", "16441472-4400-461b-831f-a2270eed2ac1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c6485a3-9532-4e26-8b0f-a923e1857628", "5858b40a-226d-4043-8983-c042bc72740f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c6485a3-9532-4e26-8b0f-a923e1857628", "640450d6-5f42-410a-9b47-54183b100f1d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c6485a3-9532-4e26-8b0f-a923e1857628", "7254a20d-6758-471f-a820-be2a51cb1e0e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c6485a3-9532-4e26-8b0f-a923e1857628", "9a39781d-7e44-4481-aa45-80307aa6f2d8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c6485a3-9532-4e26-8b0f-a923e1857628", "b0e57555-7acd-4b2f-9a06-f160ca755570" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6405ced5-a5f2-4528-834b-d4f0696dc6f2", "d513bf1f-dc07-41d7-8e34-23efaca49450" });

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
                keyValue: "4c6485a3-9532-4e26-8b0f-a923e1857628");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6405ced5-a5f2-4528-834b-d4f0696dc6f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08316800-d508-4238-8ed5-a2b93bd0dfff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5858b40a-226d-4043-8983-c042bc72740f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a39781d-7e44-4481-aa45-80307aa6f2d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0e57555-7acd-4b2f-9a06-f160ca755570");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d513bf1f-dc07-41d7-8e34-23efaca49450");

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
                keyValue: "16441472-4400-461b-831f-a2270eed2ac1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "640450d6-5f42-410a-9b47-54183b100f1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7254a20d-6758-471f-a820-be2a51cb1e0e");

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
