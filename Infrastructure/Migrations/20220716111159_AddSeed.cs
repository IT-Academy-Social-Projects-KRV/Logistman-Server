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
                    { "6fd6be5d-128f-44a0-a068-394d31927c45", "6fd6be5d-128f-44a0-a068-394d31927c45", "Logist", "LOGIST" },
                    { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "User", "USER" },
                    { "800e7501-1c9c-40f2-b252-4d92917fbceb", "800e7501-1c9c-40f2-b252-4d92917fbceb", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmationEmailToken", "ConfirmationEmailTokenExpirationDate", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6de0959b-fc5f-472e-8bb2-0a23efbbe7e2", 0, "6d2164b9-7b51-494a-bf61-752dda8194a1", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEFMWb6Afx0QXs/1bhlSZTdU3t1ZoZW9tSKmv/aFvRs+PBUalcswjI/YWkMm/dVhpKw==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 11, 11, 59, 379, DateTimeKind.Unspecified).AddTicks(3101), new TimeSpan(0, 0, 0, 0, 0)), "8703a6a8-2029-4e68-b5de-3b39c771f85e", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "ccac7899-8087-43b5-8d73-24b48fa5a0e6", 0, "d992025b-6aa0-44de-95cb-b7c3cad34a73", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEBN0stSWXR5cPnI5Z5wlhcFU4cROOZx2Swf/13s7HGC7zKPwW27tpPfE9R9hirbGSQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 11, 11, 59, 379, DateTimeKind.Unspecified).AddTicks(3094), new TimeSpan(0, 0, 0, 0, 0)), "f37afd98-6a8f-4715-a829-2b4764a01e51", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "7a0f0c6c-e208-4585-9b91-4fc526adcac3", 0, "1149ac68-e32e-44f8-8352-6a7aeed3777a", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEAI93lUlAIOTAhUagPesoa/XsGPRO5s3ZlhwQmi/YvvmJIIxwFIu0KfemWnCxxfcww==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 11, 11, 59, 379, DateTimeKind.Unspecified).AddTicks(3086), new TimeSpan(0, 0, 0, 0, 0)), "6e6c9f2f-ac5d-424e-84e0-f4eca928f117", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "5ad8ba8a-c7c3-492b-be0a-59e4c9ff90b3", 0, "892d73d3-5c94-4d8e-9577-99b17ccbbb7f", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEAwwkjdCvEM7Wpmyedh+xqHQ2Z52WVyISNl3O+DKS5sTlmcKHlYo8Xe12F5r9FVMSA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 11, 11, 59, 379, DateTimeKind.Unspecified).AddTicks(3076), new TimeSpan(0, 0, 0, 0, 0)), "822d3514-b5fc-49b5-939a-217a44e650e6", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "74e8af8c-702a-4fae-9031-d286d6c3c852", 0, "0607773a-0bb1-4ae5-9d5d-f3b474a291a7", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEGikIkcz2wxsJK+2gKeIZVV0nFEjaZrWEKZ2kiJH/16xaEHRoPAGx62wkaKFFsOC3w==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 11, 11, 59, 379, DateTimeKind.Unspecified).AddTicks(3042), new TimeSpan(0, 0, 0, 0, 0)), "606610ac-ff30-43a6-a461-008f8a899489", "Kernychna", false, "mapourse@gmail.com" },
                    { "882c74ed-95ee-42a0-a1c4-366044225d28", 0, "e0753b42-7192-4bc2-87d1-7b480d7de0ff", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEHSLe5oAWwy5mpxkbWbzaCvCVlxJuugBwLxOK2q2n8vJjxpTawFEU5JA4afLXPIPJA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 11, 11, 59, 379, DateTimeKind.Unspecified).AddTicks(3026), new TimeSpan(0, 0, 0, 0, 0)), "f6078292-2695-4d1d-9bbf-5946bc334a09", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "50c9cb2f-28f5-4dee-821f-a4b011054320", 0, "89ec7391-562f-4399-8ea1-8b2c11abf0f9", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEIv7Tk8NI4skys9I7c7vKOj1z00wx4ZXFzq3HzxYYxN5qdjAgZ7UtpTggHFR947Uqw==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 11, 11, 59, 379, DateTimeKind.Unspecified).AddTicks(3001), new TimeSpan(0, 0, 0, 0, 0)), "91331219-ff72-48ea-8e5a-75c93dd0ed49", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "451573b8-ff62-4837-ab5a-d57fa9691e9f", 0, "f6712295-c39c-4f96-aef4-450472ba4bd2", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEBdrHUejqrSSOVTugsERvTB+pVqSFVNPO2XizAGS06YJyLM//pxW1snuYx0L96JkXA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 11, 11, 59, 379, DateTimeKind.Unspecified).AddTicks(2176), new TimeSpan(0, 0, 0, 0, 0)), "2abdec67-e897-47e2-a0a6-f64cf1dc39a7", "Chorrny", false, "chorrny228@gmail.com" }
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
                    { "6fd6be5d-128f-44a0-a068-394d31927c45", "882c74ed-95ee-42a0-a1c4-366044225d28" },
                    { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "5ad8ba8a-c7c3-492b-be0a-59e4c9ff90b3" },
                    { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "ccac7899-8087-43b5-8d73-24b48fa5a0e6" },
                    { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "74e8af8c-702a-4fae-9031-d286d6c3c852" },
                    { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "7a0f0c6c-e208-4585-9b91-4fc526adcac3" },
                    { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "50c9cb2f-28f5-4dee-821f-a4b011054320" },
                    { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "451573b8-ff62-4837-ab5a-d57fa9691e9f" },
                    { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "6de0959b-fc5f-472e-8bb2-0a23efbbe7e2" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 8, 4, "White", new DateTimeOffset(new DateTime(2016, 7, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 675f, "Nissan,Titan Crew Cab, Pickup", "BH2333XI", "5H43P68RGFEMBPT2IRH7", "6de0959b-fc5f-472e-8bb2-0a23efbbe7e2", "XT06FTTB6R12O03VC" },
                    { 7, 4, "Green", new DateTimeOffset(new DateTime(2016, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 846f, "Ford,F350 Super Duty Crew Cab, Pickup", "BC7739AA", "YJAAHU9F1GTY4A7X9OZD", "6de0959b-fc5f-472e-8bb2-0a23efbbe7e2", "UH7Y2S7K4W433R4FD" },
                    { 5, 2, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 693f, "Ford,F250 Super Duty Super Cab, Pickup", "BH1232AA", "8ZE2XN0FWPAAHBJJBZ9C", "6de0959b-fc5f-472e-8bb2-0a23efbbe7e2", "SCVJ0P3088Z3LOWGU" },
                    { 1, 3, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 701f, "Porsche,911, Convertible, Coupe", "AA4567XI", "9K6WUVMBZ2MQZHUSSN26", "ccac7899-8087-43b5-8d73-24b48fa5a0e6", "2PDX9SHR49D6HTE9R" },
                    { 10, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 766f, "Jeep,Wrangler Unlimited, SUV", "AC1273IX", "OKYUGSRTUJVJ73XJ0IC6", "5ad8ba8a-c7c3-492b-be0a-59e4c9ff90b3", "7G637L4DWGN4YZ97B" },
                    { 9, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 483f, "Nissan,Titan King Cab, Pickup", "AA8992BH", "GQHS1BCU13G4UJA3JRFY", "74e8af8c-702a-4fae-9031-d286d6c3c852", "MK81SZNFV8NNG3IED" },
                    { 2, 2, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 539f, "Porsche,Cayenne, SUV", "BC2234OP", "LLH2LCLLIOADBIHIXLTT", "451573b8-ff62-4837-ab5a-d57fa9691e9f", "CDS00DIVSLWZH3VUO" },
                    { 4, 4, "White", new DateTimeOffset(new DateTime(2016, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 876f, "Jeep,Wrangler, SUV", "AC6344AC", "U58UTRK33P2YODCTAJ3Q", "451573b8-ff62-4837-ab5a-d57fa9691e9f", "TOAISAQMRAMSUB36J" },
                    { 6, 4, "Grey", new DateTimeOffset(new DateTime(2016, 7, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 941f, "Porsche,911, Convertible, Coupe", "AA5421BH", "KCICZKN8V9GSA626EMAC", "50c9cb2f-28f5-4dee-821f-a4b011054320", "2BEQVNV4LLA27ZD61" },
                    { 3, 2, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 789f, "Nissan,Titan King Cab, Pickup", "BH4456AI", "L2T6BXQUOQRQM93ALB72", "74e8af8c-702a-4fae-9031-d286d6c3c852", "OGC1DM3WDX2CRBZUP" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Schneider GroupIntelligent Wooden Chicken Mobility violet reboot Ohio hacking Supervisor program Kip Missouri input Health & Toys e-tailers Checking Account Liaison Unbranded Cotton Ball capability Lilangeni Intelligent Steel Bacon Tanzanian Shilling Moldovan Leu.", 3, 820.6935f, false, "74e8af8c-702a-4fae-9031-d286d6c3c852", 5, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Gulgowski and Sonsprotocol auxiliary solutions Handcrafted XSS input Rubber implement integrated bandwidth Handmade Fresh Table pricing structure Paradigm Customer Port primary Savings Account.", 5, 773.63873f, false, "451573b8-ff62-4837-ab5a-d57fa9691e9f", 2, null, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 30, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Franecki - OsinskiRun Licensed Granite Gloves revolutionary Bypass Personal Loan Account Metal architecture Unbranded Rustic Concrete Hat Sleek Plastic Mouse Incredible models Soft Idaho initiatives Licensed Soft Fish Licensed Wooden Salad Turkish Lira connect explicit connecting salmon deposit Orchard Berkshire Assimilated payment Internal.", 2, 333.29602f, false, "451573b8-ff62-4837-ab5a-d57fa9691e9f", 12, null, new DateTimeOffset(new DateTime(2022, 7, 5, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Torphy - MertzBranding backing up well-modulated synergy Tools & Automotive Money Market Account lime Faroe Islands Savings Account copying Cambridgeshire Awesome Granite Tuna Creek Guinea Avon Auto Loan Account.", 6, 36.870975f, false, "451573b8-ff62-4837-ab5a-d57fa9691e9f", 14, null, new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Feest - JohnstonProgram Route Delaware Avon transmitter Corner withdrawal Lock matrix withdrawal Quality Qatari Rial Inlet primary.", 6, 103.03326f, false, "451573b8-ff62-4837-ab5a-d57fa9691e9f", 19, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Runte, McLaughlin and LockmanProgram Credit Card Account Intelligent deposit national attitude-oriented Benin Ergonomic Fresh Chips Intelligent Fresh Pizza Passage Music Electronics, Kids & Garden Fantastic Fresh Towels National.", 5, 675.35974f, false, "6de0959b-fc5f-472e-8bb2-0a23efbbe7e2", 11, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Jakubowski - Predovicmigration Practical Plastic Hat feed Baby Borders San Marino redundant Row gold invoice XML Triple-buffered Savings Account Borders Planner SCSI Handmade Rubber Salad Avon.", 7, 30.263662f, false, "50c9cb2f-28f5-4dee-821f-a4b011054320", 6, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "McGlynn - Erdmanquantifying Borders Auto Loan Account Tasty Steel Soap Granite Nevada invoice alarm protocol wireless Cross-platform optical 24/7 Sleek Plastic Chair Dynamic.", 3, 687.9381f, false, "50c9cb2f-28f5-4dee-821f-a4b011054320", 7, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Koss Incarchive Unbranded Frozen Pizza Glens Avon Principal deposit whiteboard open-source models Strategist Licensed Fresh Fish Granite revolutionize Avon high-level Handmade.", 1, 75.39445f, false, "50c9cb2f-28f5-4dee-821f-a4b011054320", 9, null, new DateTimeOffset(new DateTime(2022, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 28, new DateTimeOffset(new DateTime(2022, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 8 offer", 4, 120f, false, "ccac7899-8087-43b5-8d73-24b48fa5a0e6", 28, null, new DateTimeOffset(new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 24, new DateTimeOffset(new DateTime(2022, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 4 offer", 3, 120f, false, "ccac7899-8087-43b5-8d73-24b48fa5a0e6", 24, null, new DateTimeOffset(new DateTime(2022, 7, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Reilly - HackettCreative concept artificial intelligence South Georgia and the South Sandwich Islands orchid Rustic Plastic Tuna Causeway Ergonomic cultivate composite best-of-breed Assurance Investor Director Games, Home & Books bypassing index Dale Savings Account.", 5, 183.40483f, false, "ccac7899-8087-43b5-8d73-24b48fa5a0e6", 20, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "King, Emmerich and BartolettiCoves Tennessee Gorgeous dot-com Savings Account Metrics system Money Market Account Principal Beauty & Baby Rapid Gorgeous Fresh Mouse Director Handcrafted Steel Towels Operations Gorgeous Cotton Computer Generic Frozen Towels Practical dynamic architectures Practical Concrete Towels Cambridgeshire Bolivar Fuerte transmit orchestrate France Concrete Officer Avon Polarised.", 7, 537.9504f, false, "ccac7899-8087-43b5-8d73-24b48fa5a0e6", 15, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "King LLCgenerate EXE User-centric Sleek Plastic Gloves National Intelligent Metal Computer Dynamic Auto Loan Account microchip Technician Expressway function partnerships payment Fantastic Communications Stream Oval Music, Jewelery & Jewelery hard drive.", 7, 735.7048f, false, "50c9cb2f-28f5-4dee-821f-a4b011054320", 10, null, new DateTimeOffset(new DateTime(2022, 7, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 26, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Kshlerin LLCFTP user-centric New Zealand Concrete Naira Isle Total wireless Sleek Steel Hat Hong Kong reboot Sleek Frozen Cheese Adaptive Chief.", 6, 923.1607f, false, "7a0f0c6c-e208-4585-9b91-4fc526adcac3", 18, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Swaniawski LLCFresh deposit Sleek Soft Chair Paradigm programming Checking Account East Caribbean Dollar Unbranded Music & Computers vertical Tasty open-source architectures Tasty Unbranded Marketing COM e-commerce Savings Account.", 3, 103.166954f, false, "7a0f0c6c-e208-4585-9b91-4fc526adcac3", 17, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Rau, Cronin and Daughertyrevolutionize Health & Toys extranet Virginia models withdrawal 1080p hybrid Frozen Games, Computers & Electronics Associate digital Officer bandwidth-monitored leverage Cambridgeshire Metrics Sleek Soft Car function.", 4, 390.72214f, false, "7a0f0c6c-e208-4585-9b91-4fc526adcac3", 3, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 25, new DateTimeOffset(new DateTime(2022, 7, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 5 offer", 3, 120f, false, "5ad8ba8a-c7c3-492b-be0a-59e4c9ff90b3", 25, null, new DateTimeOffset(new DateTime(2022, 7, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 21, new DateTimeOffset(new DateTime(2022, 7, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 1 offer", 1, 120f, false, "5ad8ba8a-c7c3-492b-be0a-59e4c9ff90b3", 21, null, new DateTimeOffset(new DateTime(2022, 7, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 23, new DateTimeOffset(new DateTime(2022, 7, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 3 offer", 2, 120f, false, "50c9cb2f-28f5-4dee-821f-a4b011054320", 23, null, new DateTimeOffset(new DateTime(2022, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Krajcik LLCarchitect Agent Branding reinvent object-oriented plum Money Market Account payment Beauty & Tools Light Technician Borders incubate incentivize customized Ukraine Paraguay Integration Cambridgeshire Music & Electronics Markets Namibia invoice.", 2, 954.49603f, false, "5ad8ba8a-c7c3-492b-be0a-59e4c9ff90b3", 1, null, new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 27, new DateTimeOffset(new DateTime(2022, 7, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 7 offer", 6, 120f, false, "50c9cb2f-28f5-4dee-821f-a4b011054320", 27, null, new DateTimeOffset(new DateTime(2022, 7, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 26, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 6 offer", 2, 120f, false, "74e8af8c-702a-4fae-9031-d286d6c3c852", 26, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 22, new DateTimeOffset(new DateTime(2022, 7, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 2 offer", 1, 120f, false, "74e8af8c-702a-4fae-9031-d286d6c3c852", 22, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Medhurst - Yostindex matrices Berkshire Small Fresh Bike Nigeria matrix Handcrafted Terrace Avon copying help-desk Product maximized Stand-alone coherent neural optimize Shoes & Toys Practical Assimilated Fresh.", 1, 202.81886f, false, "74e8af8c-702a-4fae-9031-d286d6c3c852", 16, null, new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 22, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Murazik - SchultzAnalyst Business-focused maroon Unbranded Fresh Keyboard Court portals transmit Burundi generating archive Money Market Account PCI navigating Lane Cocos (Keeling) Islands Regional Incredible Rubber Mouse calculating Isle Licensed Soft Towels SMS Japan index open-source Vermont JSON gold Plaza.", 2, 499.7268f, false, "74e8af8c-702a-4fae-9031-d286d6c3c852", 8, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Bahringer Incexpedite index Borders Bosnia and Herzegovina Oregon Rubber enterprise success installation Practical Concrete Sausages IB synthesizing Lempira Granite Engineer Human gold Rubber.", 5, 497.22827f, false, "ccac7899-8087-43b5-8d73-24b48fa5a0e6", 4, null, new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Harber Incincentivize connect systems Small Fresh Soap Well Kentucky New Mexico hub Avon Fantastic Frozen Pizza Cambridgeshire Compatible Parkway e-business Bedfordshire Lempira parse Planner.", 3, 984.2061f, false, "5ad8ba8a-c7c3-492b-be0a-59e4c9ff90b3", 13, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "CreationDate", "DepartureDate", "Description", "Distance", "EndDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 2, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "I'm going from Kyiv to Rivne. So welcome!", 400f, null, false, false, 2000f, 15, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (30.36545 50.45624, 28.68603 50.26679, 27.62649 50.58838, 26.2517 50.62034)"), 3, "74e8af8c-702a-4fae-9031-d286d6c3c852" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "CreationDate", "DepartureDate", "Description", "Distance", "EndDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 3, new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "I'm going from Lutsk to Uzhhorod. So welcome!", 400f, null, false, false, 2000f, 15, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (25.35595 50.7553, 24.76512 50.50216, 24.63097 50.28358, 24.00991 49.77351, 23.85867 49.26081, 22.3112 48.60822)"), 10, "5ad8ba8a-c7c3-492b-be0a-59e4c9ff90b3" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "CreationDate", "DepartureDate", "Description", "Distance", "EndDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "It`s my first offer!", 150f, null, false, false, 2000f, 20, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (30.2557039 48.7424709, 30.3017199 48.1390924, 30.3174055 47.0235592, 30.6598914 46.4932837)"), 1, "ccac7899-8087-43b5-8d73-24b48fa5a0e6" });

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
                keyValue: "800e7501-1c9c-40f2-b252-4d92917fbceb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "451573b8-ff62-4837-ab5a-d57fa9691e9f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "50c9cb2f-28f5-4dee-821f-a4b011054320" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "5ad8ba8a-c7c3-492b-be0a-59e4c9ff90b3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "6de0959b-fc5f-472e-8bb2-0a23efbbe7e2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "74e8af8c-702a-4fae-9031-d286d6c3c852" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "7a0f0c6c-e208-4585-9b91-4fc526adcac3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6fd6be5d-128f-44a0-a068-394d31927c45", "882c74ed-95ee-42a0-a1c4-366044225d28" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6", "ccac7899-8087-43b5-8d73-24b48fa5a0e6" });

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
                keyValue: "46bb1ae6-2463-4c29-b28e-b8bbcfbf60a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fd6be5d-128f-44a0-a068-394d31927c45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "451573b8-ff62-4837-ab5a-d57fa9691e9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50c9cb2f-28f5-4dee-821f-a4b011054320");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6de0959b-fc5f-472e-8bb2-0a23efbbe7e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a0f0c6c-e208-4585-9b91-4fc526adcac3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "882c74ed-95ee-42a0-a1c4-366044225d28");

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
                keyValue: "5ad8ba8a-c7c3-492b-be0a-59e4c9ff90b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74e8af8c-702a-4fae-9031-d286d6c3c852");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccac7899-8087-43b5-8d73-24b48fa5a0e6");

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
