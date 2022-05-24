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
                    { "a3f39444-12ad-4679-897d-f0efbd0c0b44", "a3f39444-12ad-4679-897d-f0efbd0c0b44", "Logist", "LOGIST" },
                    { "772de9c2-0e30-44ec-8abc-eba284b78f35", "772de9c2-0e30-44ec-8abc-eba284b78f35", "User", "USER" },
                    { "62965ef0-4330-4ebf-b206-d158f67249e5", "62965ef0-4330-4ebf-b206-d158f67249e5", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "75963ba9-8f64-4ddd-b973-cd80ea5526bf", 0, "65e9ccdd-de38-48f0-99e0-bb5c4bb4ac8d", "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEJvuFwofy16oBr8F7SGPlWvmqQ1qv4q4FKlpTF+9+eHQBInN7vsB1M4GYXfvIv3n1A==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 24, 20, 3, 2, 812, DateTimeKind.Unspecified).AddTicks(4532), new TimeSpan(0, 0, 0, 0, 0)), "7c627a8d-dd03-4280-96e8-69f787094dc8", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "2322a92b-3115-474d-81be-9d1d1669df5d", 0, "02012701-8a0a-4578-8549-b6a59e907637", "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEFXytz0y/HRL/RW9o38mEk795e52PKDVxrA0j+aJdUlWOb0NyMfVOzzQ5zXK6tVRHw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 24, 20, 3, 2, 812, DateTimeKind.Unspecified).AddTicks(4523), new TimeSpan(0, 0, 0, 0, 0)), "fd03b95f-a0da-41c1-8fad-fe3ed366c97a", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "6cf0f339-0fe4-43b0-86bc-1504f5332af1", 0, "0109c444-8747-4deb-bb83-09ab60826606", "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEH+NbCXL6NeAxSWL6/m31QroCnjXeD2PG1sl5f3vIA1eNNMXm8tUhARbAtBQfX1cXw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 24, 20, 3, 2, 812, DateTimeKind.Unspecified).AddTicks(4515), new TimeSpan(0, 0, 0, 0, 0)), "04c2ca88-b6e5-42d4-9cd4-96ccc1584e37", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "b8c8598a-c06d-4d43-95cd-7fce91df8159", 0, "68853668-b3a2-4abb-8a2e-fce9244b9452", "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEE7D2m1X8+6uvA93GtSK6lvIR0w3l+cjTHwGAGQjcVC6FN6TCD7zDMJAUEdxYhqDzA==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 24, 20, 3, 2, 812, DateTimeKind.Unspecified).AddTicks(4503), new TimeSpan(0, 0, 0, 0, 0)), "26fe7e8a-7a3e-44eb-b5ac-f1ad4fa1354a", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "d5798cdc-16b7-4357-9252-e9a8c7f3c676", 0, "b6ffef37-4ce1-4d8c-a23e-8abbd3517904", "User", "marynakernychna@gmail.com", true, false, null, "Maryna", "MARYNAKERNYCHNA@GMAIL.COM", "MARYNAKERNYCHNA@GMAIL.COM", "AQAAAAEAACcQAAAAEBj+ejJf3PO67oGBQJ+vd4fX300x4X4F1zjN9Iqg2dK+BuUHaF5CDGPzUJki2ACV7Q==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 24, 20, 3, 2, 812, DateTimeKind.Unspecified).AddTicks(4495), new TimeSpan(0, 0, 0, 0, 0)), "c7a1fe3c-fa4b-439c-bf3a-e88e6dc5a2c8", "Kernychna", false, "marynakernychna@gmail.com" },
                    { "c51878aa-5a9c-46fe-bbb3-0010a36d5d92", 0, "b6e82fdb-4fcf-454c-a3ed-ba3af28a0525", "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAENKCHKL6kfKIB9sxClaZLCqnKsZ/oQ/H1Xu63bVJ2DBQYCbwT4vzyWXemaq1lFwX3g==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 24, 20, 3, 2, 812, DateTimeKind.Unspecified).AddTicks(4486), new TimeSpan(0, 0, 0, 0, 0)), "a858344f-3d89-4119-b245-ed7a601d476d", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "3a02fe58-cadf-4cb0-b3e1-34f4f890dc58", 0, "72bb1980-bc91-4c2f-8264-ebf935ff855e", "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEOMXjgAXlsW0qNs5iD5GVSbQ89MD5m1mW8MupimEWkWgl4GFuqhEvJb20QU4Xdd4SA==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 24, 20, 3, 2, 812, DateTimeKind.Unspecified).AddTicks(4442), new TimeSpan(0, 0, 0, 0, 0)), "691b44b2-6527-476f-b7b5-8749cc1461e2", "Sevastyanov", false, "oppaiarchmaster@gmail.com" },
                    { "95c402e9-49d1-406d-ad8e-671569704fc7", 0, "ae073661-05f2-44c8-b47f-15ef447e9437", "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEEN9xFzXi2HVI+Ik8oZNnB2C4dEHy17r+zdsrIjjy7CiQ4P7I6KBRYQjKqhbOGYv3Q==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 24, 20, 3, 2, 812, DateTimeKind.Unspecified).AddTicks(3419), new TimeSpan(0, 0, 0, 0, 0)), "60bca5d1-f3b3-4063-a32d-5b3c7dadb278", "Chorrny", false, "chorrny228@gmail.com" }
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
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Order", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 2, "місто Шпанів, Рівненська область, вулиця Вереснева", 50.663542, 26.257569, 0, " Рівненська область", "Шпанів", null },
                    { 20, "місто Житомир, Житомирська область, Богунський район", 50.259729999999998, 28.649229999999999, 0, "Житомирська область", "Житомир", null },
                    { 19, "місто Біла церква, Київська область, вулиця Кірова", 49.807687086999998, 30.1144958, 0, "Київська область", "Біла церква", null },
                    { 18, "Горбово, Чернігівська область, 16311", 51.45984, 31.561633, 0, "Чернігівська область", "Горбово", null },
                    { 17, "Бобринець, Кіровоградська  область, вулиця Орджонікідзе", 48.061315, 32.158811, 0, "Кіровоградська  область", "Бобринець", null },
                    { 16, "Центральний пайон, місто Миколаїв, Миколаївська область, вулиця Дачна", 47.044604, 32.030366999999998, 0, "Миколаївська область", "Миколаїв", null },
                    { 15, "місто Миколаїв, Миколаївська область, вулиця Слов'янська", 47.032940848000003, 32.007182749999998, 0, "Миколаївська область", "Миколаїв", null },
                    { 14, "місто Вінниця, Вінницька область, вулиця Братславська", 49.232585, 28.494243999999998, 0, "Вінницька область", "Вінниця", null },
                    { 13, "Маків, Хмельницька  область, провулок Прорізний", 48.784157, 26.702999999999999, 0, "Хмельницька  область", "Маків", null },
                    { 12, "місто Ужгород, Закарпатская область, вулиця Шишкіна, 1", 48.610622999999997, 22.317772999999999, 0, "Закарпатская область", "Ужгород", null },
                    { 10, "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко", 48.460256999999999, 35.018729, 0, "Дніпропетровська область", "Дніпро", null },
                    { 9, "Новодонецьк, Донецька область, вулиця Благовісна", 48.633740000000003, 36.980499999999999, 0, "Донецька область", "Новодонецьк", null },
                    { 8, "Ульянівка, Харківська область", 49.371445999999999, 35.513638, 0, "Харківська область", "Ульянівка", null },
                    { 7, "Гаврилівка, Харківська область, вулиця Коцюбинського", 49.672877999999997, 35.660035000000001, 0, "Харківська область", "Дніпро", null },
                    { 6, "Макаровка, Донецька область", 47.779212000000001, 36.801640999999996, 0, "Донецька область", "Макаровка", null },
                    { 5, "місто Нікольське, Донецька область, вулиця Пушкіна", 47.200732350000003, 37.3148804, 0, "Донецька область", "Нікольське", null },
                    { 4, "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко", 48.462322270000001, 35.021573400000001, 0, "Дніпропетровська область", "Дніпро", null },
                    { 3, "місто Луцьк, Волинська область, вулиця Хрещата", 50.723970999999999, 25.386282000000001, 0, "Волинська область", "Луцьк", null }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Order", "Region", "Settlement", "TripId" },
                values: new object[] { 1, "місто Остріг, Рівненська область, вулиця Східна", 50.328792, 26.527293, 0, "Рівненська область", "Острог", null });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Order", "Region", "Settlement", "TripId" },
                values: new object[] { 11, "місто Львів, Львівська область, просп. Вячеслава Черновола, 11", 49.846894900000002, 4.0253360999999996, 0, "Львівська область", "Львів", null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "772de9c2-0e30-44ec-8abc-eba284b78f35", "75963ba9-8f64-4ddd-b973-cd80ea5526bf" },
                    { "772de9c2-0e30-44ec-8abc-eba284b78f35", "c51878aa-5a9c-46fe-bbb3-0010a36d5d92" },
                    { "772de9c2-0e30-44ec-8abc-eba284b78f35", "2322a92b-3115-474d-81be-9d1d1669df5d" },
                    { "772de9c2-0e30-44ec-8abc-eba284b78f35", "d5798cdc-16b7-4357-9252-e9a8c7f3c676" },
                    { "772de9c2-0e30-44ec-8abc-eba284b78f35", "6cf0f339-0fe4-43b0-86bc-1504f5332af1" },
                    { "772de9c2-0e30-44ec-8abc-eba284b78f35", "3a02fe58-cadf-4cb0-b3e1-34f4f890dc58" },
                    { "772de9c2-0e30-44ec-8abc-eba284b78f35", "95c402e9-49d1-406d-ad8e-671569704fc7" },
                    { "772de9c2-0e30-44ec-8abc-eba284b78f35", "b8c8598a-c06d-4d43-95cd-7fce91df8159" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 10, 2, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 843.3126f, "Jeep,Wrangler Unlimited, SUV", "KJBOVKE2PC6QYGJ3W811", "4OJLEH2DK1FSW9MXU6HG", "75963ba9-8f64-4ddd-b973-cd80ea5526bf", "0AA0GL5G35YB0VZQ9" },
                    { 9, 3, "Білий", new DateTimeOffset(new DateTime(2016, 7, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 555.05743f, "Nissan,TITAN XD Crew Cab, Pickup", "OPUR01KWYQETSOH6Q5YZ", "DM0ARM27SE635W4241TS", "75963ba9-8f64-4ddd-b973-cd80ea5526bf", "6G6UD05OPMHQF1PK0" },
                    { 8, 4, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 934.1251f, "Nissan,Titan King Cab, Pickup", "5W1ZT9KGFWQ6TSDKSPYP", "HG95J0STOR6VFSRTNUZJ", "75963ba9-8f64-4ddd-b973-cd80ea5526bf", "SSYSUTTB46LO6OMVG" },
                    { 7, 3, "Сірий", new DateTimeOffset(new DateTime(2016, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 887.9354f, "Porsche,Cayenne, SUV", "BB3JFAJAUUVHIOLZ4Z5Z", "9P38MJQ5MOYUIOF1JO3F", "75963ba9-8f64-4ddd-b973-cd80ea5526bf", "WPOTTSG58OPZOM7VX" },
                    { 6, 4, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 690.50214f, "Ford,F350 Super Duty Super Cab, Pickup", "WZRP6QCWSZWGBIR1VGLZ", "4FXMCIVDZGOSXV77R1LP", "75963ba9-8f64-4ddd-b973-cd80ea5526bf", "RCM8JPDPQKKBBH14C" },
                    { 5, 2, "Білий", new DateTimeOffset(new DateTime(2016, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 527.9113f, "Ford,F350 Super Duty Super Cab, Pickup", "V3C89722V9XRKTUMUOVO", "MMYLL81SMYA62D3HQ2OY", "75963ba9-8f64-4ddd-b973-cd80ea5526bf", "47JQSFTIJCJPU84RM" },
                    { 1, 4, "Червоний", new DateTimeOffset(new DateTime(2016, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 575.4156f, "Ford,F350 Super Duty Super Cab, Pickup", "IVJ724HO0QJ2PJ4OX3HZ", "7BN72GVJ54UOKDCTIQVH", "75963ba9-8f64-4ddd-b973-cd80ea5526bf", "SXRL2GRNJXXY868C5" },
                    { 2, 4, "Сірий", new DateTimeOffset(new DateTime(2016, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 680.028f, "Nissan,Titan Crew Cab, Pickup", "WWUHB6A667ZP5IQFGEFR", "ILWQM55L5LA9BJW0W4QA", "95c402e9-49d1-406d-ad8e-671569704fc7", "CQY83OHXP7S70AZ4U" },
                    { 3, 4, "Білий", new DateTimeOffset(new DateTime(2016, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 869.1657f, "Jeep,Wrangler, SUV", "LWPDLLPJBN5A286RD1H3", "8W3H4JL0R9K9RFRT9VI2", "c51878aa-5a9c-46fe-bbb3-0010a36d5d92", "DJNWY2TCG4ILSPT88" },
                    { 4, 3, "Синій", new DateTimeOffset(new DateTime(2016, 7, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 668.54895f, "Nissan,TITAN XD Crew Cab, Pickup", "23VJNHDIIJFBUIJU8LJ7", "ESFQ5M2Z0NF23LBGRCBL", "95c402e9-49d1-406d-ad8e-671569704fc7", "YL3AX6AE0HHHC9N5E" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Ratke, Stamm and MorarDivision Oval Berkshire maroon Frozen Islands Technician Steel Roads hierarchy Chief JSON morph Polarised Incredible Wooden Chicken Gorgeous Tasty Generic Fresh Tuna artificial intelligence Music, Shoes & Health Compatible bypass Designer Tasty Steel Soap deposit Decentralized Islands neural.", new DateTimeOffset(new DateTime(2022, 7, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 907.3822f, false, "95c402e9-49d1-406d-ad8e-671569704fc7", 2, null, new DateTimeOffset(new DateTime(2022, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "O'Keefe and Sonsapplications Incredible Steel Cheese application open-source Investment Account Texas Cove Division throughput Refined Rubber Chair framework ubiquitous withdrawal Credit Card Account recontextualize Fantastic Fresh Chair Representative Awesome Curve SQL North Carolina toolset next generation disintermediate Rufiyaa.", new DateTimeOffset(new DateTime(2022, 7, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 280.36456f, false, "95c402e9-49d1-406d-ad8e-671569704fc7", 12, null, new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Luettgen, Buckridge and Daughertylime calculating rich Serbian Dinar hardware Plastic optimal Architect bandwidth Quality FTP Re-engineered copying Practical Wooden Computer Associate Small copy Sports Roads Kids Soft invoice Quality Practical Wooden Shoes Facilitator Avon JBOD compressing.", new DateTimeOffset(new DateTime(2022, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 575.19604f, false, "95c402e9-49d1-406d-ad8e-671569704fc7", 14, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Reichel, Pacocha and WizaRustic Concrete Village Incredible Wooden Mouse clear-thinking redundant Interactions Ameliorated quantify Bedfordshire synthesizing USB synthesizing moratorium Cambridgeshire New Jersey recontextualize Forge Rubber Accountability Fork Multi-tiered Direct Future Rest.", new DateTimeOffset(new DateTime(2022, 7, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 917.9065f, false, "95c402e9-49d1-406d-ad8e-671569704fc7", 19, null, new DateTimeOffset(new DateTime(2022, 7, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Waelchi, Champlin and MedhurstGrocery & Sports Future Netherlands Antillian Guilder Field turquoise Avon monitor Devolved invoice program microchip Iceland generate redundant.", new DateTimeOffset(new DateTime(2022, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 696.6671f, false, "3a02fe58-cadf-4cb0-b3e1-34f4f890dc58", 6, null, new DateTimeOffset(new DateTime(2022, 7, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Watsica IncConcrete Refined Cotton Computer Nevada payment Buckinghamshire Buckinghamshire withdrawal back-end transmitting Devolved Suriname executive quantifying national Handmade Rubber Pizza Sleek Metal Functionality customer loyalty capacitor AI Money Market Account Extensions Phased Fantastic invoice microchip Club.", new DateTimeOffset(new DateTime(2022, 7, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 261.46628f, false, "3a02fe58-cadf-4cb0-b3e1-34f4f890dc58", 7, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Pfeffer, Reinger and TreutelAgent platforms synthesize Plain Hong Kong Dollar Ecuador Credit Card Account Adaptive Research Walks Internal Paradigm Dynamic invoice copying Generic Fresh Salad Polarised parsing invoice Licensed Granite Ball pink Kansas e-tailers Customer Frozen Marketing Research Re-engineered.", new DateTimeOffset(new DateTime(2022, 7, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 874.8177f, false, "3a02fe58-cadf-4cb0-b3e1-34f4f890dc58", 9, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Murphy - DanielRapids Research open architecture Awesome Incredible architectures Meadows Cambridgeshire Security Swedish Krona reboot Books Advanced collaborative optical back-end Research Wall transmitting Advanced payment Kansas Switchable index Station matrix Fall Norfolk Island Checking Account Handcrafted.", new DateTimeOffset(new DateTime(2022, 7, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 767.62885f, false, "3a02fe58-cadf-4cb0-b3e1-34f4f890dc58", 10, null, new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Sanford - Romagueracompelling partnerships bluetooth Russian Federation Soft backing up EXE Brazilian Real Practical Soft Keyboard integrate Macao.", new DateTimeOffset(new DateTime(2022, 7, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 160.33119f, false, "b8c8598a-c06d-4d43-95cd-7fce91df8159", 1, null, new DateTimeOffset(new DateTime(2022, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Willms IncRidges Plastic Cambridgeshire navigate upward-trending Cambridgeshire Summit payment Squares synergistic hard drive Adaptive vertical Uganda Shilling dynamic.", new DateTimeOffset(new DateTime(2022, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 373.3877f, false, "c51878aa-5a9c-46fe-bbb3-0010a36d5d92", 11, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 24, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Hettinger Incinterface Savings Account Home, Industrial & Outdoors Generic Rubber Soap Oval revolutionize reboot Jewelery Research interactive port ADP Borders bypassing Sri Lanka calculating Tasty Frozen Soap input wireless multi-tasking.", new DateTimeOffset(new DateTime(2022, 7, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 782.76825f, false, "c51878aa-5a9c-46fe-bbb3-0010a36d5d92", 20, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Mueller, Quigley and GreenholtEXE Unbranded Concrete Pizza Intranet SMS Re-contextualized primary IB Gibraltar Pound digital mission-critical deposit wireless invoice violet FTP Avon Gorgeous Rubber Shoes virtual tan District Rustic Fresh Salad.", new DateTimeOffset(new DateTime(2022, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 712.8905f, false, "d5798cdc-16b7-4357-9252-e9a8c7f3c676", 5, null, new DateTimeOffset(new DateTime(2022, 7, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Pfannerstill - FritschFacilitator Generic Rubber Car New Israeli Sheqel Berkshire Operations Investor Jewelery, Automotive & Games quantifying Light Intelligent Tools & Sports contextually-based Bedfordshire payment Fresh Central virtual Buckinghamshire Gorgeous Fresh Mouse deposit.", new DateTimeOffset(new DateTime(2022, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 38.63177f, false, "2322a92b-3115-474d-81be-9d1d1669df5d", 15, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "King - Blickblack Latvia Kids, Music & Tools Specialist dynamic haptic Iraqi Dinar withdrawal Berkshire Avon synthesize Internal index Intelligent Wooden.", new DateTimeOffset(new DateTime(2022, 7, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 772.5556f, false, "2322a92b-3115-474d-81be-9d1d1669df5d", 4, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 29, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Hyatt, Torphy and Satterfieldcompelling Investment Account Practical Cotton Cheese Product transmit withdrawal wireless Unbranded Generic Metal Soap multi-tasking CFP Franc encryption Kiribati extensible Berkshire sky blue Gambia Avon Latvian Lats Mountain Intelligent.", new DateTimeOffset(new DateTime(2022, 7, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 749.36456f, false, "6cf0f339-0fe4-43b0-86bc-1504f5332af1", 18, null, new DateTimeOffset(new DateTime(2022, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Donnelly GroupGB Wooden alarm Handcrafted Fresh Shoes Macedonia Circle teal interfaces Generic Concrete Car actuating European Monetary Unit (E.M.U.-6) secured line ADP Shoals Executive Rubber navigate Rubber compressing generate Automated Libyan Arab Jamahiriya Handmade Granite Hat Concrete.", new DateTimeOffset(new DateTime(2022, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 496.20468f, false, "6cf0f339-0fe4-43b0-86bc-1504f5332af1", 17, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Crooks, Collier and O'ReillyOrchard Administrator Wisconsin calculating Central African Republic Practical Cotton Tuna teal Soft Senior TCP productize compress Rustic Home & Movies Alaska Buckinghamshire payment Gorgeous Soft Pants input Open-architected bifurcated Practical Rubber Shirt.", new DateTimeOffset(new DateTime(2022, 7, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 214.67558f, false, "d5798cdc-16b7-4357-9252-e9a8c7f3c676", 8, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 30, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Walter - BarrowsArgentine Peso user-facing Berkshire connecting groupware Tasty Fresh Chicken Credit Card Account Unbranded Plastic Chips matrix Metal Health Graphic Interface Rubber Response Representative next generation end-to-end Games & Computers JBOD Shoes, Electronics & Grocery infomediaries.", new DateTimeOffset(new DateTime(2022, 7, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 607.3335f, false, "b8c8598a-c06d-4d43-95cd-7fce91df8159", 13, null, new DateTimeOffset(new DateTime(2022, 7, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Jast, Medhurst and LeuschkeCuba Sleek Plastic Bike Unbranded Unbranded Hill Florida Money Market Account compressing programming Licensed Cotton Chicken Data auxiliary Tala Cambridgeshire zero administration Planner.", new DateTimeOffset(new DateTime(2022, 7, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 989.4972f, false, "d5798cdc-16b7-4357-9252-e9a8c7f3c676", 16, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Considine - SchillerPNG Auto Loan Account Home & Computers Rustic Frozen Ball Fantastic Berkshire withdrawal monitor mint green turquoise feed Agent Rustic Fresh Chair blue Silver Isle of Man Steel Awesome invoice grow Buckinghamshire incubate Intelligent Cotton Car monitor Drives Incredible Rubber Shirt silver tangible Tasty.", new DateTimeOffset(new DateTime(2022, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 693.00977f, false, "6cf0f339-0fe4-43b0-86bc-1504f5332af1", 3, null, new DateTimeOffset(new DateTime(2022, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62965ef0-4330-4ebf-b206-d158f67249e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3f39444-12ad-4679-897d-f0efbd0c0b44");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "772de9c2-0e30-44ec-8abc-eba284b78f35", "2322a92b-3115-474d-81be-9d1d1669df5d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "772de9c2-0e30-44ec-8abc-eba284b78f35", "3a02fe58-cadf-4cb0-b3e1-34f4f890dc58" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "772de9c2-0e30-44ec-8abc-eba284b78f35", "6cf0f339-0fe4-43b0-86bc-1504f5332af1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "772de9c2-0e30-44ec-8abc-eba284b78f35", "75963ba9-8f64-4ddd-b973-cd80ea5526bf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "772de9c2-0e30-44ec-8abc-eba284b78f35", "95c402e9-49d1-406d-ad8e-671569704fc7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "772de9c2-0e30-44ec-8abc-eba284b78f35", "b8c8598a-c06d-4d43-95cd-7fce91df8159" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "772de9c2-0e30-44ec-8abc-eba284b78f35", "c51878aa-5a9c-46fe-bbb3-0010a36d5d92" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "772de9c2-0e30-44ec-8abc-eba284b78f35", "d5798cdc-16b7-4357-9252-e9a8c7f3c676" });

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
                keyValue: "772de9c2-0e30-44ec-8abc-eba284b78f35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2322a92b-3115-474d-81be-9d1d1669df5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a02fe58-cadf-4cb0-b3e1-34f4f890dc58");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6cf0f339-0fe4-43b0-86bc-1504f5332af1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75963ba9-8f64-4ddd-b973-cd80ea5526bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95c402e9-49d1-406d-ad8e-671569704fc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8c8598a-c06d-4d43-95cd-7fce91df8159");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c51878aa-5a9c-46fe-bbb3-0010a36d5d92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5798cdc-16b7-4357-9252-e9a8c7f3c676");

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
        }
    }
}
