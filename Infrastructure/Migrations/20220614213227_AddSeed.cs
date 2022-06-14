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
                    { "7d0210d0-4c6e-4748-91fc-d56ddf4cf76e", "7d0210d0-4c6e-4748-91fc-d56ddf4cf76e", "Logist", "LOGIST" },
                    { "6cea2466-aad2-4214-a08b-cd4769fe635f", "6cea2466-aad2-4214-a08b-cd4769fe635f", "User", "USER" },
                    { "8bbe5789-a3d4-4a4f-abab-7a1fc1c8a387", "8bbe5789-a3d4-4a4f-abab-7a1fc1c8a387", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmationEmailToken", "ConfirmationEmailTokenExpirationDate", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1eeb2477-3743-4bff-8b03-5f75b9d77eef", 0, "1e23ea3b-9a22-41f1-b4f1-c2224bc98c90", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEKEm3eAcgr+3E5GCsHdJB4k+o6nUKYMvjRqXPJCGZtCVa5PJS4EdzBXQjxCRdfcJqQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 14, 21, 32, 27, 180, DateTimeKind.Unspecified).AddTicks(6193), new TimeSpan(0, 0, 0, 0, 0)), "1f519f5f-1f65-4dee-87cd-c69029d7b8b3", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "416c35b8-6576-4a42-8e7e-deacfb560a8f", 0, "243c886d-ede2-427b-8426-40f254a20c8b", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEGFkCMd1DoG1z+kpg8audRZY9lkZfAHP7x6isndCtm++EPMo5wx6xVzt2AvEFk1lYQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 14, 21, 32, 27, 180, DateTimeKind.Unspecified).AddTicks(6186), new TimeSpan(0, 0, 0, 0, 0)), "bdf71e6d-e521-48b2-8d8c-51eb3c94ce74", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "c467a078-00e2-4ca4-b873-53224f709b4d", 0, "162c1786-f495-4186-acf5-e7e4770f9ac5", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEAnIVAVDAsBeQ0GNhxwA5VKvp0nqko7PW74achqaU0S5EXb8piMS8yQ7X1OSnwKoLg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 14, 21, 32, 27, 180, DateTimeKind.Unspecified).AddTicks(6178), new TimeSpan(0, 0, 0, 0, 0)), "f807d1f8-f59d-4c0b-b92b-5446399ebdf7", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "c04ec7e8-30b2-4e8e-8699-30481c758e20", 0, "a61f3b36-0cc0-41f4-8b03-b120cd73117c", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEC/dBq2DUDXxEPiCk98vDgZVOJ1FJKgCC50c3w0kRI5XoYi6mGrBQWkzgrxYHs6P9A==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 14, 21, 32, 27, 180, DateTimeKind.Unspecified).AddTicks(6168), new TimeSpan(0, 0, 0, 0, 0)), "b52a0d9b-f084-4354-8720-abf38684b279", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "d1d77b9f-0bb5-4b7b-8bb1-6e89abbd1d8d", 0, "9748666f-4c7d-444f-8c97-a6e967b0a109", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEIBWGmXFuCXuT9yWY81147DsKrYS9XrDkR6OwdQceHCwUUIZoY7WH+H+wfAcKeCOOQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 14, 21, 32, 27, 180, DateTimeKind.Unspecified).AddTicks(6160), new TimeSpan(0, 0, 0, 0, 0)), "877c3bc3-bbdb-4abb-ae24-640570b6ad1f", "Kernychna", false, "mapourse@gmail.com" },
                    { "fac4fe4d-6fcb-4dfc-8cd2-bb6edcfab2b2", 0, "68fd49e2-85d3-48a8-967c-85b81db778f4", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEOYvmHJl6OyU+oIr8LCvJBTg4Yx5youYd4N2Vf3/vUg8XvhZw/ZXjHBh0RaoXunM8A==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 14, 21, 32, 27, 180, DateTimeKind.Unspecified).AddTicks(6098), new TimeSpan(0, 0, 0, 0, 0)), "a11b31e2-a01e-4ab2-ad0f-ac668f33a3d9", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "826a4bca-9f1c-4e2e-84a8-1d827b44c5bb", 0, "b6d66252-63bc-4ef4-a7d6-6f9d25036ced", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEMYBBZQGfVRl1Nc9OT/9aBUHSkvkyyCaSA6WKVnBGrmVdH881oNRTMVmOfHzJ73j6A==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 14, 21, 32, 27, 180, DateTimeKind.Unspecified).AddTicks(6073), new TimeSpan(0, 0, 0, 0, 0)), "4d817275-39bd-4126-a4dd-76e5d3793d90", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "c94455ee-a8ea-45e0-bf7e-df2464b5c044", 0, "5a228ac5-bc7f-4c41-bce2-2ae24d228679", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEKyIs1IrWi7QvG9MI/wvyZDxV86MtZThiVVkXD4PHbSXWFNq7p94KQO98pMvq58THw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 14, 21, 32, 27, 180, DateTimeKind.Unspecified).AddTicks(5297), new TimeSpan(0, 0, 0, 0, 0)), "c9dddbb6-9aea-46df-b21b-1f1c8b54f591", "Chorrny", false, "chorrny228@gmail.com" }
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
                    { "7d0210d0-4c6e-4748-91fc-d56ddf4cf76e", "fac4fe4d-6fcb-4dfc-8cd2-bb6edcfab2b2" },
                    { "6cea2466-aad2-4214-a08b-cd4769fe635f", "c04ec7e8-30b2-4e8e-8699-30481c758e20" },
                    { "6cea2466-aad2-4214-a08b-cd4769fe635f", "416c35b8-6576-4a42-8e7e-deacfb560a8f" },
                    { "6cea2466-aad2-4214-a08b-cd4769fe635f", "d1d77b9f-0bb5-4b7b-8bb1-6e89abbd1d8d" },
                    { "6cea2466-aad2-4214-a08b-cd4769fe635f", "c467a078-00e2-4ca4-b873-53224f709b4d" },
                    { "6cea2466-aad2-4214-a08b-cd4769fe635f", "826a4bca-9f1c-4e2e-84a8-1d827b44c5bb" },
                    { "6cea2466-aad2-4214-a08b-cd4769fe635f", "c94455ee-a8ea-45e0-bf7e-df2464b5c044" },
                    { "6cea2466-aad2-4214-a08b-cd4769fe635f", "1eeb2477-3743-4bff-8b03-5f75b9d77eef" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 8, 3, "Blue", new DateTimeOffset(new DateTime(2016, 7, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 777.32025f, "Ford,F350 Super Duty Super Cab, Pickup", "DBXJFGQQBNU6ZE12204F", "6RVYB4T2S7RF0GSW0ZXV", "1eeb2477-3743-4bff-8b03-5f75b9d77eef", "KMC1IJ5XU5JLBMGZ7" },
                    { 7, 2, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 441.41168f, "Ford,F350 Super Duty Super Cab, Pickup", "HH1KI3U71H23171JGLY9", "XKA1MCFTQN55JMRAS5X3", "1eeb2477-3743-4bff-8b03-5f75b9d77eef", "68YJCBDKWA67IX70X" },
                    { 5, 4, "Black", new DateTimeOffset(new DateTime(2016, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 412.66776f, "Jeep,Wrangler Unlimited, SUV", "BGGWSBK5Y9S9ORTQCRJU", "G1HAMIXTNZ1CQQG582AG", "1eeb2477-3743-4bff-8b03-5f75b9d77eef", "YEAKZKPKI9YJOAZ5A" },
                    { 1, 3, "Blue", new DateTimeOffset(new DateTime(2016, 7, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 521.59485f, "Porsche,911, Convertible, Coupe", "AYPEPS637QDF6GVXRQAA", "5J2VOB7J8PEPCYU656OS", "416c35b8-6576-4a42-8e7e-deacfb560a8f", "ZFZMX1Q4ET09QQVTP" },
                    { 10, 2, "Green", new DateTimeOffset(new DateTime(2016, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 802.82635f, "Jeep,Wrangler, SUV", "AH0UGPJOFLDWZKJLL6Q8", "OVXW8TPGE3MHBUGL9YIP", "c04ec7e8-30b2-4e8e-8699-30481c758e20", "H3YT36PX56PGCFK4L" },
                    { 2, 3, "White", new DateTimeOffset(new DateTime(2016, 7, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 419.01343f, "Porsche,911, Convertible, Coupe", "HCO27LORL2H3AKNV1D5T", "4BKP374ABG98K0H3BKPG", "c94455ee-a8ea-45e0-bf7e-df2464b5c044", "TRI6G68YO0ESP6RZZ" },
                    { 4, 3, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 466.99792f, "Ford,F250 Super Duty Super Cab, Pickup", "WZQ5VTTX9LUDZLX3SCND", "JJGFAUBGSY5DG6ACYU2U", "c94455ee-a8ea-45e0-bf7e-df2464b5c044", "SMOY2RLCXO3UNCIAU" },
                    { 9, 4, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 408.08716f, "Porsche,Cayenne, SUV", "3WE6IL52339SC69LALAX", "UCMVE55G1SM8YWGQXU0X", "d1d77b9f-0bb5-4b7b-8bb1-6e89abbd1d8d", "R2ATYF7DXPBQ2R9IR" },
                    { 3, 2, "White", new DateTimeOffset(new DateTime(2016, 7, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 813.2225f, "Ford,F350 Super Duty Super Cab, Pickup", "5S9IA2JJHOPSRIT6XRY2", "DS9TSABBCLPYMWOZ9N54", "d1d77b9f-0bb5-4b7b-8bb1-6e89abbd1d8d", "6BPZYOXS18JC2DJGP" },
                    { 6, 3, "Red", new DateTimeOffset(new DateTime(2016, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 418.6359f, "Ford,F350 Super Duty Super Cab, Pickup", "Z7GJXANI9H3T82202JC4", "3GSD61662S029QY7T019", "826a4bca-9f1c-4e2e-84a8-1d827b44c5bb", "8RUPG7X57Q1MDIE3C" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Hermann - HartmannRustic Refined Cotton Car dot-com Afghani emulation Intelligent Fresh Sausages Developer Savings Account Generic Granite Chips Refined Wooden Bike Incredible Plastic Hat.", new DateTimeOffset(new DateTime(2022, 7, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 870.00195f, false, "d1d77b9f-0bb5-4b7b-8bb1-6e89abbd1d8d", 8, null, new DateTimeOffset(new DateTime(2022, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Baumbach, Gutmann and RunolfssonGranite application partnerships Mongolia Handcrafted New Jersey compressing Belgium technologies Configuration online Organized envisioneer Malaysian Ringgit open-source Avon.", new DateTimeOffset(new DateTime(2022, 7, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 167.73445f, false, "c94455ee-a8ea-45e0-bf7e-df2464b5c044", 2, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Schamberger and Sonshack Human reboot panel mesh Ford IB Incredible Fresh Tuna Outdoors & Toys Robust Texas Adaptive Fantastic Rubber Computer Licensed Rubber Chicken Convertible Marks South Carolina incentivize Bypass invoice Refined Soft Fish firewall program Future Marketing customized Saint Helena Pound.", new DateTimeOffset(new DateTime(2022, 7, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 987.5813f, false, "c94455ee-a8ea-45e0-bf7e-df2464b5c044", 12, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Bashirian, Luettgen and FarrellMali time-frame Soft Unbranded Metal Car Practical Cotton viral Unbranded Wooden Towels neural out-of-the-box Auto Loan Account Place Tasty Cayman Islands Stravenue Handmade Plastic Car.", new DateTimeOffset(new DateTime(2022, 7, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 48.891537f, false, "c94455ee-a8ea-45e0-bf7e-df2464b5c044", 14, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Wyman, Veum and WildermanIowa Rubber Common workforce multi-state leading-edge Japan engage Throughway cross-platform Causeway Personal Loan Account deploy Rustic Steel Computer Suriname hack world-class yellow.", new DateTimeOffset(new DateTime(2022, 7, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 838.39734f, false, "c94455ee-a8ea-45e0-bf7e-df2464b5c044", 19, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Grant, Thompson and SchillerTimor-Leste driver platforms Virginia Gorgeous Frozen Chips Ports COM harness impactful Sri Lanka Rupee cyan Creative Producer Glens Buckinghamshire Awesome Fresh Sausages overriding Producer Central Island generating Paradigm bandwidth web services.", new DateTimeOffset(new DateTime(2022, 7, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 599.1577f, false, "1eeb2477-3743-4bff-8b03-5f75b9d77eef", 11, null, new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Rath LLCinterfaces withdrawal Curve Designer plum Orchestrator synthesizing bluetooth Forest input Alabama deliverables Practical Frozen Ball Court transmitter Ergonomic Frozen Chair optical hacking Concrete interface Developer invoice Corporate European Unit of Account 9(E.U.A.-9) Factors niches Unbranded Concrete Keyboard magenta Senior hacking.", new DateTimeOffset(new DateTime(2022, 7, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 485.4833f, false, "826a4bca-9f1c-4e2e-84a8-1d827b44c5bb", 6, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 24, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Harvey - Grantnavigate hack strategize applications overriding Naira SCSI Credit Card Account Administrator multimedia.", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 529.0492f, false, "826a4bca-9f1c-4e2e-84a8-1d827b44c5bb", 7, null, new DateTimeOffset(new DateTime(2022, 7, 5, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Green - Tremblayembrace Rubber online deposit Vision-oriented Intelligent Frozen Keyboard Granite 24/365 Handmade e-services Books & Shoes leading-edge SMTP Handmade Exclusive interface panel strategy Supervisor Internal Wooden generating incubate productize mint green streamline.", new DateTimeOffset(new DateTime(2022, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 99.85049f, false, "416c35b8-6576-4a42-8e7e-deacfb560a8f", 20, null, new DateTimeOffset(new DateTime(2022, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 28, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "McGlynn LLCcompressing Identity Jamaican Dollar Operations Markets transitional South Africa Fantastic Rubber Shoes Cotton archive capacitor.", new DateTimeOffset(new DateTime(2022, 7, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 971.7836f, false, "d1d77b9f-0bb5-4b7b-8bb1-6e89abbd1d8d", 5, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Harber - WizaChecking Account Prairie Buckinghamshire salmon firmware Awesome Soft Tuna Washington Home Canyon Refined Generic Wooden Chair customized withdrawal Proactive grey models copy architectures input application functionalities Granite Principal Steel exploit Illinois application innovate quantifying.", new DateTimeOffset(new DateTime(2022, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 640.3127f, false, "416c35b8-6576-4a42-8e7e-deacfb560a8f", 15, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Lesch - WildermanPractical Soft Pants Handcrafted Soft Towels SCSI Chief Multi-lateral indigo digital programming Administrator Camp parsing next-generation Rustic Plastic Bike Books card B2B Malagasy Ariary SAS Metrics Tools & Health Buckinghamshire models Unbranded Soft Bacon generate Future-proofed Identity Denar European Unit of Account 17(E.U.A.-17).", new DateTimeOffset(new DateTime(2022, 7, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 922.1443f, false, "416c35b8-6576-4a42-8e7e-deacfb560a8f", 4, null, new DateTimeOffset(new DateTime(2022, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "McCullough GroupItaly Small tangible synergies Jewelery, Baby & Clothing Oval Checking Account CSS Small Metal Bacon Bulgarian Lev deposit Credit Card Account Tasty Steel Keyboard calculating Hawaii Tactics artificial intelligence synthesize overriding networks Flats transition Isle.", new DateTimeOffset(new DateTime(2022, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 666.56726f, false, "826a4bca-9f1c-4e2e-84a8-1d827b44c5bb", 10, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Witting and Sonsnavigate orange index experiences Saint Martin firewall Chief parallelism didactic Auto Loan Account.", new DateTimeOffset(new DateTime(2022, 7, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 989.75256f, false, "c467a078-00e2-4ca4-b873-53224f709b4d", 18, null, new DateTimeOffset(new DateTime(2022, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 21, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Crona, Durgan and HarberConfigurable Human fuchsia Developer Dynamic alarm homogeneous Assistant Alaska Plastic mint green back-end invoice Awesome Concrete Chips Frozen Legacy Center Buckinghamshire bus interface mint green.", new DateTimeOffset(new DateTime(2022, 7, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 108.11358f, false, "c467a078-00e2-4ca4-b873-53224f709b4d", 17, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Cartwright, Zemlak and SteuberOrchestrator SMTP AI Money Market Account Central deposit Fantastic Wooden Table Accounts digital Italy parse parse Rustic Wooden Computer Lebanese Pound morph infomediaries.", new DateTimeOffset(new DateTime(2022, 7, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 820.94574f, false, "c467a078-00e2-4ca4-b873-53224f709b4d", 3, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Veum and SonsWooden EXE Progressive capacitor markets Direct Malawi index Accounts 1080p auxiliary Ghana Markets communities JBOD invoice next generation.", new DateTimeOffset(new DateTime(2022, 7, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 71.87509f, false, "c04ec7e8-30b2-4e8e-8699-30481c758e20", 1, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Windler Groupextranet Cotton mint green SCSI Developer coherent empowering back-end models Assurance Burundi Franc.", new DateTimeOffset(new DateTime(2022, 7, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 123.21845f, false, "d1d77b9f-0bb5-4b7b-8bb1-6e89abbd1d8d", 16, null, new DateTimeOffset(new DateTime(2022, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Sanford GroupCambridgeshire SAS Multi-channelled Soft panel Baby & Electronics Tugrik Direct Junction Tanzanian Shilling content microchip white repurpose Plastic invoice Bedfordshire Specialist Games & Beauty input.", new DateTimeOffset(new DateTime(2022, 7, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 599.11035f, false, "826a4bca-9f1c-4e2e-84a8-1d827b44c5bb", 9, null, new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Schmeler - BoyleGeneric Officer Licensed withdrawal violet deposit frictionless National hard drive alarm Metal mission-critical Clothing Rubber.", new DateTimeOffset(new DateTime(2022, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 422.94702f, false, "c04ec7e8-30b2-4e8e-8699-30481c758e20", 13, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bbe5789-a3d4-4a4f-abab-7a1fc1c8a387");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6cea2466-aad2-4214-a08b-cd4769fe635f", "1eeb2477-3743-4bff-8b03-5f75b9d77eef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6cea2466-aad2-4214-a08b-cd4769fe635f", "416c35b8-6576-4a42-8e7e-deacfb560a8f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6cea2466-aad2-4214-a08b-cd4769fe635f", "826a4bca-9f1c-4e2e-84a8-1d827b44c5bb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6cea2466-aad2-4214-a08b-cd4769fe635f", "c04ec7e8-30b2-4e8e-8699-30481c758e20" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6cea2466-aad2-4214-a08b-cd4769fe635f", "c467a078-00e2-4ca4-b873-53224f709b4d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6cea2466-aad2-4214-a08b-cd4769fe635f", "c94455ee-a8ea-45e0-bf7e-df2464b5c044" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6cea2466-aad2-4214-a08b-cd4769fe635f", "d1d77b9f-0bb5-4b7b-8bb1-6e89abbd1d8d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7d0210d0-4c6e-4748-91fc-d56ddf4cf76e", "fac4fe4d-6fcb-4dfc-8cd2-bb6edcfab2b2" });

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
                keyValue: "6cea2466-aad2-4214-a08b-cd4769fe635f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d0210d0-4c6e-4748-91fc-d56ddf4cf76e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1eeb2477-3743-4bff-8b03-5f75b9d77eef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "416c35b8-6576-4a42-8e7e-deacfb560a8f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "826a4bca-9f1c-4e2e-84a8-1d827b44c5bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c04ec7e8-30b2-4e8e-8699-30481c758e20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c467a078-00e2-4ca4-b873-53224f709b4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c94455ee-a8ea-45e0-bf7e-df2464b5c044");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1d77b9f-0bb5-4b7b-8bb1-6e89abbd1d8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac4fe4d-6fcb-4dfc-8cd2-bb6edcfab2b2");

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
