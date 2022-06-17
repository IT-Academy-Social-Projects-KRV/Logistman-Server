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
                    { "57f04dcd-3724-42b2-8fa6-8071c167d807", "57f04dcd-3724-42b2-8fa6-8071c167d807", "Logist", "LOGIST" },
                    { "b287047c-53fc-45d0-b3da-828ae4d9c357", "b287047c-53fc-45d0-b3da-828ae4d9c357", "User", "USER" },
                    { "f467b2b0-6e1b-4034-b661-7355d1a75661", "f467b2b0-6e1b-4034-b661-7355d1a75661", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmationEmailToken", "ConfirmationEmailTokenExpirationDate", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "509ac7cf-fd69-49e6-942d-100ae3d7c2d1", 0, "f24afd44-0318-4f78-a0c4-fb4c54d3fbd9", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEL0a21fYQB6Cge27NYhbILiMcVeOzXzKEMBA1NX/oQwIogjVoZr5IXtGc57VzoQvbw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 10, 1, 22, 561, DateTimeKind.Unspecified).AddTicks(9361), new TimeSpan(0, 0, 0, 0, 0)), "f06330de-3499-4afb-8c62-f2fdda4b9c50", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "6e1a9428-b6bb-45ad-88c8-c7bc3b455f87", 0, "c7f1d6a0-335d-49b6-a03a-cc9b6d2f62c4", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAELIFkjaxVn7N4+QaNCZrQYFRjCK6NlDXnBiD9Z1Vo21u4pKryP76/GDc3FIK+LLrvw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 10, 1, 22, 561, DateTimeKind.Unspecified).AddTicks(9352), new TimeSpan(0, 0, 0, 0, 0)), "aeb5f20d-f924-4b4e-bc6f-b95d7c038f41", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "47ff4b1c-9a96-4c00-acdb-50f8abb6bbef", 0, "783530e3-8910-4a9e-bed6-e5af29b3ed94", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEPBXkJuCxJl6xBQkgg1f/p783vxB20Wf4ElvejG9xuAl3pe1Vg0qdiua9a/C2nln8g==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 10, 1, 22, 561, DateTimeKind.Unspecified).AddTicks(9344), new TimeSpan(0, 0, 0, 0, 0)), "8331a5d9-edfc-44a6-8985-b1422407d8c2", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "40bdf860-4e68-4051-ac61-7a566aa2e24e", 0, "a61ef869-883f-452d-af80-9dfc072e1a6b", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEFGZMKgxmm73tdpRZRTBVRGIu6fyuL2IEKC2+stcS6VLmWI7PyBj5n0UO3haClFUmQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 10, 1, 22, 561, DateTimeKind.Unspecified).AddTicks(9333), new TimeSpan(0, 0, 0, 0, 0)), "7c3c0ca2-0906-4032-9df1-1b59a67fe3ee", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "5932bf63-bdc5-4038-88b6-1bd38363f2dc", 0, "da7a823e-eb5c-4582-a14f-753a47fc3db4", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEICy4gezO9l+TTPNxW0Oiy38HxNBqv/nukvcJ+QUcErasUwQ9PVfjWP0pA6qZh5FMQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 10, 1, 22, 561, DateTimeKind.Unspecified).AddTicks(9325), new TimeSpan(0, 0, 0, 0, 0)), "16f5ef29-c534-4747-97d7-98e97e347842", "Kernychna", false, "mapourse@gmail.com" },
                    { "976f7bdc-b53c-4e79-91e9-6720bc3a7ecc", 0, "e1287eab-316d-403a-b742-0d3666316912", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEAFgxgOuRDaU56Jb1zObz0JftjFf1B2nDYBM81Z5n44Jv+aA6UxlK2bV0+cK1AJ5zw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 10, 1, 22, 561, DateTimeKind.Unspecified).AddTicks(9317), new TimeSpan(0, 0, 0, 0, 0)), "6814dc19-543e-4756-b1d9-8f573e952db1", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "7140fd2f-d30d-4532-9bfe-4d32ce26bdff", 0, "77feee4f-efde-4307-996f-5a13de857e61", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAELZMbd+vPzFx8VFzcztl9Hk5c8o+gat8cPOigvnqprBFetWAVtZkhFeGUKIArfvFZw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 10, 1, 22, 561, DateTimeKind.Unspecified).AddTicks(9286), new TimeSpan(0, 0, 0, 0, 0)), "027cf4ce-44fb-4b02-b046-f0b898363820", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "736310cf-b0fc-47da-986e-3bcb86525409", 0, "d10cbb84-643f-4f46-b451-d3a062cba501", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEAqfgdaBOzOcJJ+SZU1Lk06J1c31vzAsAWPOgx7GZW9y6LHj+TvRyczj0wePOkEloQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 10, 1, 22, 561, DateTimeKind.Unspecified).AddTicks(8298), new TimeSpan(0, 0, 0, 0, 0)), "87f139d1-f137-4b09-a2d7-c20a80775b87", "Chorrny", false, "chorrny228@gmail.com" }
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
                columns: new[] { "Id", "Address", "Latitude", "Location", "Longitude", "Order", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 24, "вулиця Шевченка, 10, Березівка, Одеська область, 67301", 47.199119385067711, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.911616773891865 47.19911938506771)"), 30.911616773891865, 0, "Одеська область", "Березівка", null },
                    { 25, "Трасса Е 95, Знам'янка, Одеська область, 67211", 47.0234622881908, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.317371060250917 47.0234622881908)"), 30.317371060250917, 0, "Одеська область", "Знам'янка", null },
                    { 26, "48Q2+JJ Дубинове, Одеська область", 48.139092436783365, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.301719955968146 48.139092436783365)"), 30.301719955968146, 0, "Одеська область", "Дубинове", null },
                    { 2, "місто Шпанів, Рівненська область, вулиця Вереснева", 50.663542, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.257569 50.663542)"), 26.257569, 0, " Рівненська область", "Шпанів", null },
                    { 28, "вул. Станціонна, 1, Новополтавка, Миколаївська область, 55642", 47.546419999999998, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.49742 47.54642)"), 32.497419999999998, 0, "Миколаївська область", "Новополтавка", null },
                    { 23, "Криве Озеро, Миколаївська область, 55100", 47.948440524775656, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.344302712523117 47.948440524775656)"), 30.344302712523117, 0, "Миколаївська область", "Криве Озеро", null },
                    { 27, "вулиця Медична, 19, Кривий Ріг, Дніпропетровська область, 50005", 47.887689999999999, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (33.38327 47.88769)"), 33.383270000000003, 0, "Дніпропетровська область", "Кривий Ріг", null },
                    { 22, "Р54, 119, Вільшанка, Одеська область, 66221", 48.141322486857703, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.164117207748024 48.1413224868577)"), 30.164117207748024, 0, "Одеська область", "Вільшанка", null },
                    { 21, "вул Соборна 44б, Голованівськ, Кіровоградська область, 26500", 48.388002346569579, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.45704659882904 48.38800234656958)"), 30.457046598829042, 0, "Кіровоградська область", "Голованівськ", null },
                    { 20, "місто Житомир, Житомирська область, Богунський район", 50.259729999999998, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.64923 50.25973)"), 28.649229999999999, 0, "Житомирська область", "Житомир", null },
                    { 3, "місто Луцьк, Волинська область, вулиця Хрещата", 50.723970999999999, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.386282 50.723971)"), 25.386282000000001, 0, "Волинська область", "Луцьк", null },
                    { 4, "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко", 48.462322270000001, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.0215734 48.46232227)"), 35.021573400000001, 0, "Дніпропетровська область", "Дніпро", null },
                    { 5, "місто Нікольське, Донецька область, вулиця Пушкіна", 47.200732350000003, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.3148804 47.20073235)"), 37.3148804, 0, "Донецька область", "Нікольське", null },
                    { 6, "Макаровка, Донецька область", 47.779212000000001, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (36.801641 47.779212)"), 36.801640999999996, 0, "Донецька область", "Макаровка", null },
                    { 7, "Гаврилівка, Харківська область, вулиця Коцюбинського", 49.672877999999997, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.660035 49.672878)"), 35.660035000000001, 0, "Харківська область", "Дніпро", null },
                    { 8, "Ульянівка, Харківська область", 49.371445999999999, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.513638 49.371446)"), 35.513638, 0, "Харківська область", "Ульянівка", null },
                    { 9, "Новодонецьк, Донецька область, вулиця Благовісна", 48.633740000000003, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (36.9805 48.63374)"), 36.980499999999999, 0, "Донецька область", "Новодонецьк", null },
                    { 1, "місто Острог, Рівненська область, вулиця Східна", 50.328792, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.527293 50.328792)"), 26.527293, 0, "Рівненська область", "Острог", null }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Location", "Longitude", "Order", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 10, "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко", 48.460256999999999, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.018729 48.460257)"), 35.018729, 0, "Дніпропетровська область", "Дніпро", null },
                    { 12, "місто Ужгород, Закарпатская область, вулиця Шишкіна, 1", 48.610622999999997, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (22.317773 48.610623)"), 22.317772999999999, 0, "Закарпатская область", "Ужгород", null },
                    { 13, "Маків, Хмельницька  область, провулок Прорізний", 48.784157, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.703 48.784157)"), 26.702999999999999, 0, "Хмельницька  область", "Маків", null },
                    { 14, "місто Вінниця, Вінницька область, вулиця Братславська", 49.232585, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.494244 49.232585)"), 28.494243999999998, 0, "Вінницька область", "Вінниця", null },
                    { 16, "Центральний пайон, місто Миколаїв, Миколаївська область, вулиця Дачна", 47.044604, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.030367 47.044604)"), 32.030366999999998, 0, "Миколаївська область", "Миколаїв", null },
                    { 17, "Бобринець, Кіровоградська  область, вулиця Орджонікідзе", 48.061315, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.158811 48.061315)"), 32.158811, 0, "Кіровоградська  область", "Бобринець", null },
                    { 18, "Горбово, Чернігівська область, 16311", 51.45984, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (31.561633 51.45984)"), 31.561633, 0, "Чернігівська область", "Горбово", null },
                    { 19, "місто Біла церква, Київська область, вулиця Кірова", 49.807687086999998, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.1144958 49.807687087)"), 30.1144958, 0, "Київська область", "Біла церква", null },
                    { 11, "місто Львів, Львівська область, просп. Вячеслава Черновола, 11", 49.846894900000002, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (34.0253361 49.8468949)"), 34.025336099999997, 0, "Львівська область", "Львів", null },
                    { 15, "місто Миколаїв, Миколаївська область, вулиця Слов'янська", 47.032940848000003, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.00718275 47.032940848)"), 32.007182749999998, 0, "Миколаївська область", "Миколаїв", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "57f04dcd-3724-42b2-8fa6-8071c167d807", "976f7bdc-b53c-4e79-91e9-6720bc3a7ecc" },
                    { "b287047c-53fc-45d0-b3da-828ae4d9c357", "40bdf860-4e68-4051-ac61-7a566aa2e24e" },
                    { "b287047c-53fc-45d0-b3da-828ae4d9c357", "6e1a9428-b6bb-45ad-88c8-c7bc3b455f87" },
                    { "b287047c-53fc-45d0-b3da-828ae4d9c357", "5932bf63-bdc5-4038-88b6-1bd38363f2dc" },
                    { "b287047c-53fc-45d0-b3da-828ae4d9c357", "47ff4b1c-9a96-4c00-acdb-50f8abb6bbef" },
                    { "b287047c-53fc-45d0-b3da-828ae4d9c357", "7140fd2f-d30d-4532-9bfe-4d32ce26bdff" },
                    { "b287047c-53fc-45d0-b3da-828ae4d9c357", "736310cf-b0fc-47da-986e-3bcb86525409" },
                    { "b287047c-53fc-45d0-b3da-828ae4d9c357", "509ac7cf-fd69-49e6-942d-100ae3d7c2d1" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 8, 2, "White", new DateTimeOffset(new DateTime(2016, 7, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 552.45215f, "Nissan,Titan King Cab, Pickup", "JRO4JDL2U37L6QMDUVZT", "B1SXK8OHXV80OKR6O2T9", "509ac7cf-fd69-49e6-942d-100ae3d7c2d1", "ZIQ3D2JQODUNDIYQJ" },
                    { 7, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 496.11032f, "Jeep,Wrangler, SUV", "UQUIHG6EE7ICCU948L2Q", "G1KQ07LOPVFU8THN1EIU", "509ac7cf-fd69-49e6-942d-100ae3d7c2d1", "AYC6CMUDTMXOKT54I" },
                    { 5, 3, "Blue", new DateTimeOffset(new DateTime(2016, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 435.8281f, "Nissan,Titan King Cab, Pickup", "4VLLETQ6SCXDUKWJF9B3", "79KCJDK794KE407EDTRU", "509ac7cf-fd69-49e6-942d-100ae3d7c2d1", "QKQ6I761YWCYEUB92" },
                    { 1, 2, "Green", new DateTimeOffset(new DateTime(2016, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 622.4452f, "Ford,F350 Super Duty Crew Cab, Pickup", "BAG9X3N9N7RY2HL5W0ZE", "26P3TUZCLFK5VWEKA8C2", "6e1a9428-b6bb-45ad-88c8-c7bc3b455f87", "0802GY2LCR0N85KDG" },
                    { 10, 2, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 429.0325f, "Nissan,TITAN XD Crew Cab, Pickup", "9J6FU1MOA3IU4AJ1XTSI", "EE3GZ79MI9CCUAMRYNIF", "40bdf860-4e68-4051-ac61-7a566aa2e24e", "SCLATGH0YLXPCVGPG" },
                    { 9, 2, "Red", new DateTimeOffset(new DateTime(2016, 7, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 456.18118f, "Jeep,Wrangler Unlimited, SUV", "YV6XMZGPS2QK01A7GULY", "67U50787XIIK550NJ6R3", "5932bf63-bdc5-4038-88b6-1bd38363f2dc", "WB42DGOJ3F35YR11W" },
                    { 2, 2, "Green", new DateTimeOffset(new DateTime(2016, 7, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 421.9306f, "Nissan,Titan King Cab, Pickup", "7MM3521VOOW0D5H3QE1A", "03S48O90XS9Z30TLDZAV", "736310cf-b0fc-47da-986e-3bcb86525409", "O33MU039PO20N4UHU" },
                    { 4, 2, "Green", new DateTimeOffset(new DateTime(2016, 7, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 523.035f, "Porsche,911, Convertible, Coupe", "MA28LNYTXCLP4400B2ZK", "GV6IVFZW7TH03QBAUIP2", "736310cf-b0fc-47da-986e-3bcb86525409", "B9YF6OSZJXOJCR3KD" },
                    { 6, 3, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 799.7696f, "Porsche,Cayenne, SUV", "NSJ8UCI5LHG1EJZLCVD0", "76N15LD34RQLIW2S7XNU", "7140fd2f-d30d-4532-9bfe-4d32ce26bdff", "CEWXZBCNP5VIOH4I2" },
                    { 3, 2, "Grey", new DateTimeOffset(new DateTime(2016, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 528.6123f, "Porsche,Cayenne, SUV", "WEWXDCVPR358BFO1LU9W", "N3LX2DOQW4T2ZQSP7OHN", "5932bf63-bdc5-4038-88b6-1bd38363f2dc", "YKXRBP6G9MK4ASTZU" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Braun LLCField Operations invoice Berkshire Practical Hawaii 1080p Facilitator PCI Cambridgeshire target Sleek Steel Chicken sky blue back up quantifying Spurs circuit Sleek Timor-Leste Proactive hub.", new DateTimeOffset(new DateTime(2022, 7, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 399.60742f, false, "5932bf63-bdc5-4038-88b6-1bd38363f2dc", 5, null, new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Wiegand Grouputilize Handmade Metal Car process improvement Fantastic Steel Shirt Auto Loan Account Tanzanian Shilling users payment Money Market Account Savings Account Handcrafted Rubber Computer synthesizing bluetooth Research Monaco Frozen.", new DateTimeOffset(new DateTime(2022, 7, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 576.159f, false, "736310cf-b0fc-47da-986e-3bcb86525409", 2, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Braun LLCConsultant Avon Implementation transmit Cape Verde incubate Kyrgyz Republic communities Bulgarian Lev Money Market Account Intelligent Concrete Tuna Architect Costa Rica Home Loan Account wireless Incredible Wooden Cheese Serbian Dinar neutral Shoals Grove Facilitator blue Implementation View Bedfordshire PNG Throughway turquoise Mauritius Rupee.", new DateTimeOffset(new DateTime(2022, 7, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 191.40852f, false, "736310cf-b0fc-47da-986e-3bcb86525409", 12, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "O'Reilly GroupErgonomic Rubber Salad input circuit e-enable Hungary Clothing & Jewelery Handmade SDR Ergonomic Cotton Bike Principal Loaf Saint Lucia Associate Garden, Baby & Music Chile Rhode Island back up microchip enterprise indigo Refined Rubber Chips Representative Developer holistic override frame Personal Loan Account Key Compatible Toys & Toys.", new DateTimeOffset(new DateTime(2022, 7, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 138.11382f, false, "736310cf-b0fc-47da-986e-3bcb86525409", 14, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 22, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Becker - LeuschkeTajikistan Outdoors, Clothing & Music systematic 1080p Handcrafted Steel Shirt azure Venezuela solid state Avon salmon Seamless Producer Rubber bus payment Factors West Virginia Awesome Fresh Pizza Mountains SMTP matrix Concrete bypassing matrix Jewelery, Music & Kids Direct Buckinghamshire Small Concrete Chair.", new DateTimeOffset(new DateTime(2022, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 379.59494f, false, "736310cf-b0fc-47da-986e-3bcb86525409", 19, null, new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Carroll - GerlachADP Liaison reciprocal West Virginia Mission intranet payment Handcrafted Steel Shirt Small Rubber Car Internal synthesize asynchronous Hawaii overriding National Wisconsin.", new DateTimeOffset(new DateTime(2022, 7, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 465.18488f, false, "509ac7cf-fd69-49e6-942d-100ae3d7c2d1", 11, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Nader - DarePractical Granite Chair Personal Loan Account Burundi Franc Personal Loan Account back up Jewelery transparent Route microchip Bermudian Dollar (customarily known as Bermuda Dollar) optical Buckinghamshire Wooden Steel multi-byte optical deposit Eritrea throughput fuchsia Latvia wireless circuit Tonga Unbranded Cotton Fish viral Savings Account Intelligent Rubber Sausages Taiwan.", new DateTimeOffset(new DateTime(2022, 7, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 971.6463f, false, "7140fd2f-d30d-4532-9bfe-4d32ce26bdff", 6, null, new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 23, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Satterfield - ZiemannHighway Licensed Manager Savings Account Agent Small Granite Gloves Junction Steel incentivize turn-key Hong Kong Berkshire port Row Buckinghamshire connect copy Fantastic Concrete Pants encoding Senior Devolved program programming grey deliverables Uruguay wireless instruction set.", new DateTimeOffset(new DateTime(2022, 7, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 484.88138f, false, "7140fd2f-d30d-4532-9bfe-4d32ce26bdff", 7, null, new DateTimeOffset(new DateTime(2022, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Roob - BednarTunnel Multi-tiered Courts backing up Response Handcrafted Frozen Pants Morocco pixel Handcrafted Soft Table gold Rustic.", new DateTimeOffset(new DateTime(2022, 7, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 587.2326f, false, "7140fd2f-d30d-4532-9bfe-4d32ce26bdff", 9, null, new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 28, new DateTimeOffset(new DateTime(2022, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 8 offer", new DateTimeOffset(new DateTime(2022, 8, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 120f, false, "6e1a9428-b6bb-45ad-88c8-c7bc3b455f87", 28, null, new DateTimeOffset(new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 24, new DateTimeOffset(new DateTime(2022, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 4 offer", new DateTimeOffset(new DateTime(2022, 7, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 120f, false, "6e1a9428-b6bb-45ad-88c8-c7bc3b455f87", 24, null, new DateTimeOffset(new DateTime(2022, 7, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 28, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Mante - OrnCanyon Orchestrator Forward Savings Account payment Rustic Hill Practical Plastic Computer initiative Kina mesh IB coherent Valley e-tailers Fantastic Steel Pizza Fresh copying web-readiness repurpose leading-edge Dynamic bus generate.", new DateTimeOffset(new DateTime(2022, 7, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 276.46558f, false, "6e1a9428-b6bb-45ad-88c8-c7bc3b455f87", 20, null, new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Nitzsche - Kozeypartnerships Tools, Industrial & Jewelery Maryland grow strategize calculating Operations Licensed morph Assistant bluetooth Lead full-range South Carolina invoice Liberian Dollar viral models Refined Steel Mouse synthesize Investor copying Ridge strategy Generic Gateway Enhanced Cambridgeshire Brunei Darussalam.", new DateTimeOffset(new DateTime(2022, 7, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 822.1834f, false, "6e1a9428-b6bb-45ad-88c8-c7bc3b455f87", 15, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Hauck, Beahan and LynchBhutan Savings Account XSS Canadian Dollar Trafficway open-source Tools, Garden & Games Riel brand Peru Avon structure.", new DateTimeOffset(new DateTime(2022, 7, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 791.3639f, false, "7140fd2f-d30d-4532-9bfe-4d32ce26bdff", 10, null, new DateTimeOffset(new DateTime(2022, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 23, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Zulauf, Senger and HintzGeneric Cotton Ball invoice Clothing, Music & Beauty Practical Plastic Shoes architecture generate Fork concept Wooden synergistic Cambridgeshire white Lesotho Plains streamline Virtual index Idaho mobile Stand-alone calculate Handmade.", new DateTimeOffset(new DateTime(2022, 7, 7, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 234.78427f, false, "47ff4b1c-9a96-4c00-acdb-50f8abb6bbef", 18, null, new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Macejkovic LLCIraqi Dinar backing up deposit Squares Lakes Refined Metal Ball Generic Rubber Soap quantify recontextualize Function-based CSS parse Berkshire payment vortals.", new DateTimeOffset(new DateTime(2022, 7, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 938.2659f, false, "47ff4b1c-9a96-4c00-acdb-50f8abb6bbef", 17, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 24, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Schmidt - Ritchiesensor hardware Bulgarian Lev methodologies Azerbaijanian Manat Cocos (Keeling) Islands National Minnesota Mission scalable Cayman Islands Dollar orange Fantastic Guinea Franc Computers navigate.", new DateTimeOffset(new DateTime(2022, 7, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 533.9677f, false, "47ff4b1c-9a96-4c00-acdb-50f8abb6bbef", 3, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 25, new DateTimeOffset(new DateTime(2022, 7, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 5 offer", new DateTimeOffset(new DateTime(2022, 7, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 120f, false, "40bdf860-4e68-4051-ac61-7a566aa2e24e", 25, null, new DateTimeOffset(new DateTime(2022, 7, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 21, new DateTimeOffset(new DateTime(2022, 7, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 1 offer", new DateTimeOffset(new DateTime(2022, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 120f, false, "40bdf860-4e68-4051-ac61-7a566aa2e24e", 21, null, new DateTimeOffset(new DateTime(2022, 7, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 23, new DateTimeOffset(new DateTime(2022, 7, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 3 offer", new DateTimeOffset(new DateTime(2022, 7, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 120f, false, "7140fd2f-d30d-4532-9bfe-4d32ce26bdff", 23, null, new DateTimeOffset(new DateTime(2022, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 21, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Heathcote and SonsUSB monitor Russian Federation HTTP EXE Fantastic Egyptian Pound orange Rustic Frozen Shoes maximized Practical Plastic Bacon bandwidth benchmark 5th generation port Ergonomic Ergonomic Concrete Soap Gorgeous Heights Djibouti Franc Western Sahara Program Utah functionalities Gateway Dalasi Ridge Consultant.", new DateTimeOffset(new DateTime(2022, 7, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 658.443f, false, "40bdf860-4e68-4051-ac61-7a566aa2e24e", 1, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 27, new DateTimeOffset(new DateTime(2022, 7, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 7 offer", new DateTimeOffset(new DateTime(2022, 7, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 120f, false, "7140fd2f-d30d-4532-9bfe-4d32ce26bdff", 27, null, new DateTimeOffset(new DateTime(2022, 7, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 26, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 6 offer", new DateTimeOffset(new DateTime(2022, 7, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 120f, false, "5932bf63-bdc5-4038-88b6-1bd38363f2dc", 26, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 22, new DateTimeOffset(new DateTime(2022, 7, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 2 offer", new DateTimeOffset(new DateTime(2022, 7, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 120f, false, "5932bf63-bdc5-4038-88b6-1bd38363f2dc", 22, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Homenick LLCregional Rustic Metal Gloves Virtual optical Buckinghamshire primary Games Gorgeous Wooden Pants PCI Unbranded Cotton Salad Cambridgeshire Automotive & Games Maine deposit Sleek Handmade Granite Gloves Security Baby, Home & Garden Villages Rubber grey.", new DateTimeOffset(new DateTime(2022, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 415.39667f, false, "5932bf63-bdc5-4038-88b6-1bd38363f2dc", 16, null, new DateTimeOffset(new DateTime(2022, 7, 5, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 24, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Collier - Hammesbacking up Program system Incredible Metal Salad Prairie Brazil 3rd generation Data Berkshire Handmade Fresh Chips payment invoice USB open architecture Lock Haiti online Implemented Alabama multi-byte Principal Dalasi Extended Handmade Metal Sausages Brunei Dollar.", new DateTimeOffset(new DateTime(2022, 7, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 168.07968f, false, "5932bf63-bdc5-4038-88b6-1bd38363f2dc", 8, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Gerhold LLCFront-line optimal system Central Home Loan Account definition Director function Tasty South Dakota transmit envisioneer bandwidth-monitored Security Chief Georgia withdrawal SDD Parks next generation B2C circuit back up e-business Steel Intelligent Metal Fish Fantastic.", new DateTimeOffset(new DateTime(2022, 7, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 926.0476f, false, "6e1a9428-b6bb-45ad-88c8-c7bc3b455f87", 4, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Adams - SchummHong Kong Dollar reboot deposit help-desk Inverse Electronics, Automotive & Health mission-critical indexing mobile Awesome Granite Chips hardware Garden, Baby & Toys Granite Malaysia Electronics, Movies & Games disintermediate program Manor Buckinghamshire Clothing & Beauty Baby, Shoes & Computers Tactics Gibraltar Pound circuit index synthesize web services sexy Investment Account.", new DateTimeOffset(new DateTime(2022, 7, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 623.32837f, false, "40bdf860-4e68-4051-ac61-7a566aa2e24e", 13, null, new DateTimeOffset(new DateTime(2022, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f467b2b0-6e1b-4034-b661-7355d1a75661");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b287047c-53fc-45d0-b3da-828ae4d9c357", "40bdf860-4e68-4051-ac61-7a566aa2e24e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b287047c-53fc-45d0-b3da-828ae4d9c357", "47ff4b1c-9a96-4c00-acdb-50f8abb6bbef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b287047c-53fc-45d0-b3da-828ae4d9c357", "509ac7cf-fd69-49e6-942d-100ae3d7c2d1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b287047c-53fc-45d0-b3da-828ae4d9c357", "5932bf63-bdc5-4038-88b6-1bd38363f2dc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b287047c-53fc-45d0-b3da-828ae4d9c357", "6e1a9428-b6bb-45ad-88c8-c7bc3b455f87" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b287047c-53fc-45d0-b3da-828ae4d9c357", "7140fd2f-d30d-4532-9bfe-4d32ce26bdff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b287047c-53fc-45d0-b3da-828ae4d9c357", "736310cf-b0fc-47da-986e-3bcb86525409" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57f04dcd-3724-42b2-8fa6-8071c167d807", "976f7bdc-b53c-4e79-91e9-6720bc3a7ecc" });

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 4);

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57f04dcd-3724-42b2-8fa6-8071c167d807");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b287047c-53fc-45d0-b3da-828ae4d9c357");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40bdf860-4e68-4051-ac61-7a566aa2e24e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47ff4b1c-9a96-4c00-acdb-50f8abb6bbef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "509ac7cf-fd69-49e6-942d-100ae3d7c2d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5932bf63-bdc5-4038-88b6-1bd38363f2dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e1a9428-b6bb-45ad-88c8-c7bc3b455f87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7140fd2f-d30d-4532-9bfe-4d32ce26bdff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "736310cf-b0fc-47da-986e-3bcb86525409");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "976f7bdc-b53c-4e79-91e9-6720bc3a7ecc");

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Points");
        }
    }
}
