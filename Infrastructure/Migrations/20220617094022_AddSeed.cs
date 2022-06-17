using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                    { "a37ea022-60cc-4044-97f9-7d76740a0ad0", "a37ea022-60cc-4044-97f9-7d76740a0ad0", "Logist", "LOGIST" },
                    { "aadbfab0-5fea-4914-acb9-d43739288526", "aadbfab0-5fea-4914-acb9-d43739288526", "User", "USER" },
                    { "84fda6cd-7e61-4168-a03e-c4bbe72530f3", "84fda6cd-7e61-4168-a03e-c4bbe72530f3", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmationEmailToken", "ConfirmationEmailTokenExpirationDate", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e41f3f26-ef6a-4d78-9b77-2c6119daa219", 0, "7fb60e83-6ed1-4b53-abed-7c225a4a0e2c", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEKMcYOepsongkGy2IV7xFTGek1esflHJSac/rAefEnh0TUkNOCUL3JahJZqGSd3u5w==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 9, 40, 19, 963, DateTimeKind.Unspecified).AddTicks(6166), new TimeSpan(0, 0, 0, 0, 0)), "fa92926a-725b-4787-bd93-1dce0ed0efec", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "7fb203e7-b4f0-4f5c-9936-f16f014eac94", 0, "3caf7678-8cc7-4532-94fd-f2e0be797760", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEAR4PD841iiRzTgE8gYbw7MO8MBUXmkTLZ/+5behU9MMlaoDfbihFSZkIL9l/P/tpg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 9, 40, 19, 963, DateTimeKind.Unspecified).AddTicks(6142), new TimeSpan(0, 0, 0, 0, 0)), "ee91cfb2-a927-4451-acf5-4078a50e983d", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "69302d98-0b86-4455-a706-f5b60f857cca", 0, "f3c62216-0a1a-4288-b359-324bda64d623", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEA356IT5NZf6sm6U1F6v9nZCge9vqSF6eVcGc7kXIGizOcW6Or+uQl/MZn/tnVjbDw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 9, 40, 19, 963, DateTimeKind.Unspecified).AddTicks(5927), new TimeSpan(0, 0, 0, 0, 0)), "dce00cc1-bc63-4e49-b2eb-2fc0e1fd4980", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "585a165e-20c2-4836-a20c-db736b52c2f5", 0, "ff97bc21-9ec1-4406-a95c-e14d729994ca", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEKX26miCtkNvCWCqRKSZh7AvBEC7ZNTofBUoz3XVL9NywH9sEsfB3qWquGmb0NguIQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 9, 40, 19, 963, DateTimeKind.Unspecified).AddTicks(5907), new TimeSpan(0, 0, 0, 0, 0)), "fb418816-012c-4fba-bf72-36fc18ad8b7c", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "13cd7218-db74-4e02-86a5-1aca27bdadf3", 0, "9bdbca86-51a4-4c18-89e1-e2841dc5c199", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEMpl/iWf+kcfhMDpZohEArbTvzNNKzdW7qCg1P2ZY+pqBsAlmunOGhJW/9Sf1sDPoA==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 9, 40, 19, 963, DateTimeKind.Unspecified).AddTicks(5886), new TimeSpan(0, 0, 0, 0, 0)), "b029ee5c-1875-46ff-bb8b-fc61ab9c5474", "Kernychna", false, "mapourse@gmail.com" },
                    { "1ca43e99-2758-4b7f-a770-d4c73e6d6b8b", 0, "26d6503a-49e0-4eb2-97be-959f99702eef", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEDeLfINF478vLZyphKkyz/XSiw7hAFZA2I02xF30PNWpNoIIL8qVYZOD/71YjvDbvg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 9, 40, 19, 963, DateTimeKind.Unspecified).AddTicks(5781), new TimeSpan(0, 0, 0, 0, 0)), "6f27618e-ce6b-4862-97ce-993819fbf677", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "e19ea2ac-381b-4372-96c2-b6c2057e2a4c", 0, "a813f112-da32-476d-8e87-dfac5ffbef4b", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEOcQb4MhZAoLL3ADEiNdepf80i7m+CqrdBIrciUg+BkNnvWX7AYwoqlpgmWF95v6zg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 9, 40, 19, 963, DateTimeKind.Unspecified).AddTicks(5639), new TimeSpan(0, 0, 0, 0, 0)), "9a4dc1f2-9c78-4277-899c-ccdf306d7ec3", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "bd9bebda-dd0a-4cdd-8ff8-2f829cfd5e3b", 0, "b45604e1-3cc1-4eee-877e-81011332da2c", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEH8u72ltfu9rRhMWAH3NJtFvrX77RqC8IH89BA0aVZv2LqCUmRiS0ktzJn0dhbZfgQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 17, 9, 40, 19, 963, DateTimeKind.Unspecified).AddTicks(1792), new TimeSpan(0, 0, 0, 0, 0)), "873007b0-f5a3-4a56-967c-53c24fda40f6", "Chorrny", false, "chorrny228@gmail.com" }
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
                columns: new[] { "Id", "Address", "Country", "IsStopover", "Latitude", "Longitude", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 2, "вулиця Соборна, 5", "Україна", true, 50.617584800000003, 26.261429100000001, 0, "33000", "Рівненська область", "Рівне", null },
                    { 20, "вулиця Бориса Тена, 2", "Україна", true, 50.2541948, 28.672715400000001, 0, "10001", "Житомирська область", "Житомир", null },
                    { 19, "вулиця Острозька, 1", "Україна", true, 50.300693899999999, 26.854432299999999, 0, "30000", "Хмельницька область", "Славута", null },
                    { 18, "вулиця В'ячеслава Чорновола, 1", "Україна", true, 50.755603000000001, 25.36196, 0, "43000", "Волинська область", "Луцьк", null },
                    { 17, "вулиця Привільна, 10", "Україна", true, 46.988067200000003, 32.021096300000004, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 16, "вулиця Привільна, 1", "Україна", true, 46.985877199999997, 32.022233800000002, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 15, "вулиця Слов'янська, 1", "Україна", true, 47.031948999999997, 32.014710700000002, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 14, "вулиця Братиславська, 1", "Україна", true, 47.8847308, 33.328672300000001, 0, "50000", "Дніпропетровська область", "Кривий Ріг", null },
                    { 13, "вулиця Козацька, 1", "Україна", true, 49.417856200000003, 26.991916700000001, 0, "29000", "Хмельницька  область", "Хмельницький", null },
                    { 12, "вулиця Шишкіна, 1", "Україна", true, 48.610299500000004, 22.317890500000001, 0, "88000", "Закарпатська область", "Ужгород", null },
                    { 10, "вулиця Юрія Савченка, 3", "Україна", true, 48.465850400000001, 35.024770699999998, 0, "49000", "Дніпропетровська область", "Дніпро", null },
                    { 9, "Посадочна вулиця, 5", "Україна", true, 48.518124399999998, 32.226965300000003, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 8, "вулиця Чкалова, 20", "Україна", true, 48.518348400000001, 32.227779699999999, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 7, "вулиця Павлова, 1", "Україна", true, 48.517585799999999, 32.234530499999998, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 6, "вулиця Садова, 1", "Україна", true, 46.969027799999999, 32.0033648, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 5, "вулиця Пушкіна, 1", "Україна", true, 47.191728099999999, 37.338659800000002, 0, "87000", "Донецька область", "Нікольське", null },
                    { 4, "вулиця Юрія Савченко, 1", "Україна", true, 48.467451599999997, 35.0256349, 0, "49000", "Дніпропетровська область", "Дніпро", null },
                    { 3, "Вишнівецька вулиця, 30", "Україна", true, 50.724626000000001, 25.383925099999999, 0, "43000", "Волинська область", "Луцьк", null }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Country", "IsStopover", "Latitude", "Longitude", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[] { 1, "вулиця Східна, 32", "Україна", true, 50.3288577, 26.528363299999999, 0, "35800", "Рівненська область", "Острог", null });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Country", "IsStopover", "Latitude", "Longitude", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[] { 11, "просп. Вячеслава Черновола, 11", "Україна", true, 49.8468734, 24.025338099999999, 0, "79000", "Львівська область", "Львів", null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a37ea022-60cc-4044-97f9-7d76740a0ad0", "1ca43e99-2758-4b7f-a770-d4c73e6d6b8b" },
                    { "aadbfab0-5fea-4914-acb9-d43739288526", "585a165e-20c2-4836-a20c-db736b52c2f5" },
                    { "aadbfab0-5fea-4914-acb9-d43739288526", "7fb203e7-b4f0-4f5c-9936-f16f014eac94" },
                    { "aadbfab0-5fea-4914-acb9-d43739288526", "13cd7218-db74-4e02-86a5-1aca27bdadf3" },
                    { "aadbfab0-5fea-4914-acb9-d43739288526", "69302d98-0b86-4455-a706-f5b60f857cca" },
                    { "aadbfab0-5fea-4914-acb9-d43739288526", "e19ea2ac-381b-4372-96c2-b6c2057e2a4c" },
                    { "aadbfab0-5fea-4914-acb9-d43739288526", "bd9bebda-dd0a-4cdd-8ff8-2f829cfd5e3b" },
                    { "aadbfab0-5fea-4914-acb9-d43739288526", "e41f3f26-ef6a-4d78-9b77-2c6119daa219" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 8, 4, "Grey", new DateTimeOffset(new DateTime(2016, 7, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 822.1444f, "Ford,F350 Super Duty Crew Cab, Pickup", "UFPUP8PHXBFXEKEZDAYE", "G7FFTDOUIT9WIK298TIG", "e41f3f26-ef6a-4d78-9b77-2c6119daa219", "14IXUFTJD4MWVM090" },
                    { 7, 2, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 884.44806f, "Nissan,Titan Crew Cab, Pickup", "HCGSX92R0B2KCYSIHYWR", "AH3X1INSF6VCPMP31KNH", "e41f3f26-ef6a-4d78-9b77-2c6119daa219", "WPYO8PEZZFXV808IQ" },
                    { 5, 2, "Black", new DateTimeOffset(new DateTime(2016, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 654.4152f, "Nissan,TITAN XD Crew Cab, Pickup", "1HM7B8NB2MFJ1HVYW5MI", "5PI7MRYI896W94ZLEZO8", "e41f3f26-ef6a-4d78-9b77-2c6119daa219", "4FHX6OMP3XWFKBYFL" },
                    { 1, 4, "White", new DateTimeOffset(new DateTime(2016, 7, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 807.0597f, "Ford,F250 Super Duty Super Cab, Pickup", "86A6976R3HG9EKAAGQQS", "Y5HK7XBESVP6UIIDM6JM", "7fb203e7-b4f0-4f5c-9936-f16f014eac94", "TS97MFRWAITSA2PQZ" },
                    { 10, 2, "White", new DateTimeOffset(new DateTime(2016, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 662.9264f, "Nissan,TITAN XD Crew Cab, Pickup", "QLKTG79YDIBC6MS4ERZK", "MODM1HA4RPWUR03QKDH8", "585a165e-20c2-4836-a20c-db736b52c2f5", "RAYGU044DC3C518YS" },
                    { 2, 2, "Black", new DateTimeOffset(new DateTime(2016, 7, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 916.443f, "Porsche,Cayenne, SUV", "8S9EW1WO9644LCOAZAVM", "VL7D28GOW77QVDL00TQE", "bd9bebda-dd0a-4cdd-8ff8-2f829cfd5e3b", "0BPOPP0FZ1053NKWC" },
                    { 4, 4, "Blue", new DateTimeOffset(new DateTime(2016, 7, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 511.0791f, "Jeep,Wrangler Unlimited, SUV", "OGN47MIDX1SBBDO6BUVQ", "WIYZ443LMWK54Z50V98F", "bd9bebda-dd0a-4cdd-8ff8-2f829cfd5e3b", "0217ZG3H72XH86IN0" },
                    { 9, 4, "Blue", new DateTimeOffset(new DateTime(2016, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 801.52985f, "Porsche,Cayenne, SUV", "32IFTI5QJSHOY5BXVJ90", "YG49MPG8YT6WVIY2ZI1X", "13cd7218-db74-4e02-86a5-1aca27bdadf3", "TC57XGOC4SAT0NX8S" },
                    { 3, 2, "Black", new DateTimeOffset(new DateTime(2016, 7, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 607.41406f, "Nissan,TITAN XD Crew Cab, Pickup", "2YE87RO95JHRNKVODJQO", "G76QPAYF4H3TNGYDAFHY", "13cd7218-db74-4e02-86a5-1aca27bdadf3", "THJDF2P7Y4TJBUSOI" },
                    { 6, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 607.5071f, "Jeep,Wrangler, SUV", "TGJAXH9JWGE2ZK2QOK9W", "I590TJNNZE4YA2BZYN97", "e19ea2ac-381b-4372-96c2-b6c2057e2a4c", "7GHCKQWOX008KN7IG" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Mills - Hudsonpayment Forks context-sensitive orchestrate Designer Associate Metal Product Generic Cross-platform.", new DateTimeOffset(new DateTime(2022, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 81.59378f, false, "13cd7218-db74-4e02-86a5-1aca27bdadf3", 8, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Legros - MonahanSkyway Lesotho Loti Movies, Music & Sports Handmade bluetooth turn-key mobile Florida Lead demand-driven Rustic Granite Ball Configurable UAE Dirham Manager Route Sleek Rubber Chicken Intelligent Cotton Chicken holistic Liberia methodical Outdoors & Garden application Sleek Rubber Pizza Borders backing up Steel.", new DateTimeOffset(new DateTime(2022, 7, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 744.9896f, false, "bd9bebda-dd0a-4cdd-8ff8-2f829cfd5e3b", 2, null, new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Brown, Grimes and Moendynamic Generic Metal Shirt deposit International Personal Loan Account Fresh Throughway purple Liechtenstein Personal Loan Account networks withdrawal dot-com Bedfordshire Mill deposit Meadow Rustic Optimized Lead.", new DateTimeOffset(new DateTime(2022, 7, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 557.29596f, false, "bd9bebda-dd0a-4cdd-8ff8-2f829cfd5e3b", 12, null, new DateTimeOffset(new DateTime(2022, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 20, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Feil LLCTriple-buffered Buckinghamshire task-force copy Executive TCP Movies & Jewelery Bedfordshire Operations Infrastructure Fresh deposit PNG scale backing up synergies auxiliary Cambridgeshire help-desk Causeway embrace implementation deposit web services Unbranded Plastic Chair.", new DateTimeOffset(new DateTime(2022, 7, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 795.19336f, false, "bd9bebda-dd0a-4cdd-8ff8-2f829cfd5e3b", 14, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Deckow, Hoeger and Altenwerthredefine Isle of Man blockchains e-business Handcrafted Granite Tuna bi-directional Keys Computers & Industrial Street sensor Unbranded Fresh Ergonomic Granite Gloves dynamic driver Personal Loan Account Unbranded Metal Shoes Team-oriented Phased function Metal Legacy Steel Macao Business-focused infrastructure HDD capacitor white success.", new DateTimeOffset(new DateTime(2022, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 403.40094f, false, "bd9bebda-dd0a-4cdd-8ff8-2f829cfd5e3b", 19, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Fahey and Sonsfeed background Executive Avon navigating Fresh Investor compelling Ergonomic Granite Bacon methodical SAS regional Chief Idaho.", new DateTimeOffset(new DateTime(2022, 7, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 479.4162f, false, "e41f3f26-ef6a-4d78-9b77-2c6119daa219", 11, null, new DateTimeOffset(new DateTime(2022, 7, 4, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Crooks GroupLicensed Rubber Car Human orchid Gorgeous Frozen Pants Ville multimedia Agent Ameliorated Ergonomic Steel Soap Savings Account Center Supervisor Manager Inlet world-class Designer Borders Branch time-frame New Mexico Cotton stable Ferry Human bypassing matrix Ranch capability.", new DateTimeOffset(new DateTime(2022, 7, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 633.2987f, false, "e19ea2ac-381b-4372-96c2-b6c2057e2a4c", 6, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Kihn, Jones and O'KonHandmade Wooden Car Games back-end South Carolina local area network Eritrea Lead Licensed global reinvent invoice circuit bluetooth Small Soft Ball Spurs extensible District Crossing web-enabled.", new DateTimeOffset(new DateTime(2022, 7, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 566.4324f, false, "e19ea2ac-381b-4372-96c2-b6c2057e2a4c", 7, null, new DateTimeOffset(new DateTime(2022, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Stoltenberg - FramiCredit Card Account North Korean Won lime orange overriding haptic North Dakota Ergonomic copy Lesotho Loti hardware Planner Accounts Buckinghamshire hard drive Regional neural RAM Product sensor.", new DateTimeOffset(new DateTime(2022, 7, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 48.65233f, false, "7fb203e7-b4f0-4f5c-9936-f16f014eac94", 20, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Block, Nader and WalshTennessee neutral Practical Fresh Fish Prairie Soft invoice SAS Rubber niches bus Rue plum parallelism wireless French Southern Territories Awesome Frozen Chips Manors Avon disintermediate Networked Borders Investment Account Buckinghamshire withdrawal.", new DateTimeOffset(new DateTime(2022, 7, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 228.52217f, false, "13cd7218-db74-4e02-86a5-1aca27bdadf3", 5, null, new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Funk, Feest and SwaniawskiBooks, Home & Baby Analyst Interactions Tasty Granite Mouse cross-media killer invoice array purple fuchsia back up maximize Wooden District quantifying Junction withdrawal Legacy Unbranded Buckinghamshire Refined Identity payment.", new DateTimeOffset(new DateTime(2022, 7, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 576.1606f, false, "7fb203e7-b4f0-4f5c-9936-f16f014eac94", 15, null, new DateTimeOffset(new DateTime(2022, 7, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Okuneva - GreenTechnician calculating Money Market Account Taiwan California brand Views Gorgeous Buckinghamshire CSS Micronesia background.", new DateTimeOffset(new DateTime(2022, 7, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 856.0735f, false, "7fb203e7-b4f0-4f5c-9936-f16f014eac94", 4, null, new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Hackett IncUnion Incredible Plastic Soap Automotive, Sports & Shoes West Virginia Designer Extended contingency Costa Rican Colon Investment Account Applications Way payment input ivory Iraqi Dinar.", new DateTimeOffset(new DateTime(2022, 7, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 700.17395f, false, "e19ea2ac-381b-4372-96c2-b6c2057e2a4c", 10, null, new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 27, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Crona, Borer and HauckElectronics & Kids Kentucky Movies hacking contingency synthesize Home Loan Account 4th generation payment facilitate Small Plastic Valleys Fantastic.", new DateTimeOffset(new DateTime(2022, 7, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 290.67548f, false, "69302d98-0b86-4455-a706-f5b60f857cca", 18, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Cole, Heller and Langosholive array XSS solution global Awesome Plastic Salad Awesome Arkansas Heard Island and McDonald Islands Principal composite card deposit salmon.", new DateTimeOffset(new DateTime(2022, 7, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 66.67006f, false, "69302d98-0b86-4455-a706-f5b60f857cca", 17, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Osinski LLCSenior Checking Account Orchestrator Ergonomic Rubber Slovakia (Slovak Republic) North Dakota calculating Multi-channelled strategize Forks Up-sized bandwidth Concrete Alabama Automated orchid Oval Mandatory Falls Lead.", new DateTimeOffset(new DateTime(2022, 7, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 980.74603f, false, "69302d98-0b86-4455-a706-f5b60f857cca", 3, null, new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Macejkovic - Kautzerasynchronous salmon synthesize index Bond Markets Units European Composite Unit (EURCO) Junction Central Spain orchestrate Corporate Ohio Product Montana.", new DateTimeOffset(new DateTime(2022, 7, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 436.4224f, false, "585a165e-20c2-4836-a20c-db736b52c2f5", 1, null, new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Willms, Cole and HauckMusic repurpose well-modulated compress Tasty Concrete Gloves withdrawal circuit Small Communications New York local area network optical Idaho United Arab Emirates Auto Loan Account Practical driver Cuba Handcrafted card purple Analyst Division Zambian Kwacha SDD reinvent.", new DateTimeOffset(new DateTime(2022, 7, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 473.6684f, false, "13cd7218-db74-4e02-86a5-1aca27bdadf3", 16, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Lakin, Olson and Dickenspartnerships hack deposit integrated turquoise Grocery & Electronics Grocery & Toys array value-added reboot upward-trending HTTP Future Cambridgeshire digital Rial Omani Wooden supply-chains National District Ranch Dynamic Small Granite Sausages Creative Investment Account cutting-edge Legacy emulation.", new DateTimeOffset(new DateTime(2022, 7, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 866.5847f, false, "e19ea2ac-381b-4372-96c2-b6c2057e2a4c", 9, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Williamson - RunolfssonNational National Tactics Rustic Metal Soap background alliance zero administration back up Principal Pines seize seize.", new DateTimeOffset(new DateTime(2022, 7, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 222.23453f, false, "585a165e-20c2-4836-a20c-db736b52c2f5", 13, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84fda6cd-7e61-4168-a03e-c4bbe72530f3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aadbfab0-5fea-4914-acb9-d43739288526", "13cd7218-db74-4e02-86a5-1aca27bdadf3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a37ea022-60cc-4044-97f9-7d76740a0ad0", "1ca43e99-2758-4b7f-a770-d4c73e6d6b8b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aadbfab0-5fea-4914-acb9-d43739288526", "585a165e-20c2-4836-a20c-db736b52c2f5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aadbfab0-5fea-4914-acb9-d43739288526", "69302d98-0b86-4455-a706-f5b60f857cca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aadbfab0-5fea-4914-acb9-d43739288526", "7fb203e7-b4f0-4f5c-9936-f16f014eac94" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aadbfab0-5fea-4914-acb9-d43739288526", "bd9bebda-dd0a-4cdd-8ff8-2f829cfd5e3b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aadbfab0-5fea-4914-acb9-d43739288526", "e19ea2ac-381b-4372-96c2-b6c2057e2a4c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aadbfab0-5fea-4914-acb9-d43739288526", "e41f3f26-ef6a-4d78-9b77-2c6119daa219" });

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
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 1);

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
                keyValue: "a37ea022-60cc-4044-97f9-7d76740a0ad0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aadbfab0-5fea-4914-acb9-d43739288526");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13cd7218-db74-4e02-86a5-1aca27bdadf3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ca43e99-2758-4b7f-a770-d4c73e6d6b8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "585a165e-20c2-4836-a20c-db736b52c2f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69302d98-0b86-4455-a706-f5b60f857cca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fb203e7-b4f0-4f5c-9936-f16f014eac94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd9bebda-dd0a-4cdd-8ff8-2f829cfd5e3b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e19ea2ac-381b-4372-96c2-b6c2057e2a4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e41f3f26-ef6a-4d78-9b77-2c6119daa219");

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
        }
    }
}
