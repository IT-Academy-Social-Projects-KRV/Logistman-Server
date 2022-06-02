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
                    { "bac99df7-fe71-49f0-be14-c89dca349245", "bac99df7-fe71-49f0-be14-c89dca349245", "Logist", "LOGIST" },
                    { "c98263e8-c741-4b7e-928e-133e9927d914", "c98263e8-c741-4b7e-928e-133e9927d914", "User", "USER" },
                    { "5cabac42-7be9-4599-a5d1-da1b35b6c5e9", "5cabac42-7be9-4599-a5d1-da1b35b6c5e9", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7dd284b7-4bc5-4350-b013-ea668a8937bf", 0, "460617b5-cc6a-41ea-a827-171cc739da14", "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEJB/bBqPkJjnWSuJKzKV2S182nvADZavgm10+i5FpfktckBckBxFZp5wg9z2m0KhJg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 2, 9, 17, 22, 443, DateTimeKind.Unspecified).AddTicks(1749), new TimeSpan(0, 0, 0, 0, 0)), "a2832f71-5624-4c47-9dc1-bf645dee317f", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "75badc63-f7f4-44ef-b35f-a572f89a1218", 0, "bf71c9be-524a-405d-bfdc-37690c3d9463", "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEBsq+8D3BYHItKuz0QXJOFN88/P+xCwsUngOdO1f97WjOEJVOfOMn8wWPmpphVjznQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 2, 9, 17, 22, 443, DateTimeKind.Unspecified).AddTicks(1726), new TimeSpan(0, 0, 0, 0, 0)), "2822118b-7092-479e-8813-0f6d4abfdaad", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "71d30880-20c4-4ca5-9599-1746df8d15f0", 0, "5932a8f5-2701-45be-8ab3-9e73d90f96fc", "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEKO851s2Iukg++FrR3fS6FwOV98l8V6T/qvrb/D1bml2ogRTCoI1WaDOT/BxW64s7g==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 2, 9, 17, 22, 443, DateTimeKind.Unspecified).AddTicks(1707), new TimeSpan(0, 0, 0, 0, 0)), "48bab78b-53a7-4493-9bf7-49abb3735e6b", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "08d97b99-743e-4173-a06f-c0dfe18589e8", 0, "178aa9fe-0f76-4202-8ae7-57e4ff4cb467", "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEJcb4oFCOOgZxiOnjtiXeWoKw8wJFyUCdsnsVOgOfiAQ62KLnEtJ8KdJSlhSsA9XkQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 2, 9, 17, 22, 443, DateTimeKind.Unspecified).AddTicks(1682), new TimeSpan(0, 0, 0, 0, 0)), "cfe8198c-a341-4427-8f45-73a650fcb9d3", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "e443fbad-4027-44d9-b53d-5837d7588fa2", 0, "c36a82f5-d725-440f-b0a6-c1a297e82d57", "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEPDDliHqSMxgZcWjzQPgjVJOyByt7zQRC1KpVOuiYfVY6Xnsjd9RyDRkvYYWx/Vzsg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 2, 9, 17, 22, 443, DateTimeKind.Unspecified).AddTicks(1663), new TimeSpan(0, 0, 0, 0, 0)), "ec055cb3-d5f7-4489-b890-68b369e8b06c", "Kernychna", false, "mapourse@gmail.com" },
                    { "4c505239-31b5-4fc8-a06d-b9176ad5d705", 0, "0a834519-569a-43b3-9ed8-67219ad8fd6a", "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEKs8vyFouQVz0mHkzEjNKuNPcvIE5zA/ncykurKfqeZ+U7FpvEDMrRl9l+0smzdu4Q==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 2, 9, 17, 22, 443, DateTimeKind.Unspecified).AddTicks(1640), new TimeSpan(0, 0, 0, 0, 0)), "bc886559-c6b7-468d-b304-0b4200e23565", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "070ebbf6-6f6b-4cf1-bad7-9447dd5dd310", 0, "9e1dc0f3-2c79-40e6-b6bb-f517b99024cc", "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEG/+W9mph3dKo/OYTmQ7i3svPG96cdJTouMrZVBR3s/8B9/tSjAYIPXJqWYtVvTqDQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 2, 9, 17, 22, 443, DateTimeKind.Unspecified).AddTicks(1453), new TimeSpan(0, 0, 0, 0, 0)), "6863a386-6f94-4c7a-93aa-75b09a019645", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "08ea12cb-8ccb-4ae0-bf40-ae8ccbf52482", 0, "f67a1853-d2cd-43db-8d28-6ac3f00e1cab", "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEJNxAyG5e6JvJV3PVOBAg7BdcdCN0jZxkBHVXLjPTM2VybInKIT6aGTJGxdMZTYqwQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 2, 9, 17, 22, 442, DateTimeKind.Unspecified).AddTicks(7937), new TimeSpan(0, 0, 0, 0, 0)), "07635bd6-e5ac-41e0-876a-f7da366c170a", "Chorrny", false, "chorrny228@gmail.com" }
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
                values: new object[] { 1, "місто Острог, Рівненська область, вулиця Східна", 50.328792, 26.527293, 0, "Рівненська область", "Острог", null });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Order", "Region", "Settlement", "TripId" },
                values: new object[] { 11, "місто Львів, Львівська область, просп. Вячеслава Черновола, 11", 49.846894900000002, 4.0253360999999996, 0, "Львівська область", "Львів", null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bac99df7-fe71-49f0-be14-c89dca349245", "4c505239-31b5-4fc8-a06d-b9176ad5d705" },
                    { "c98263e8-c741-4b7e-928e-133e9927d914", "08d97b99-743e-4173-a06f-c0dfe18589e8" },
                    { "c98263e8-c741-4b7e-928e-133e9927d914", "75badc63-f7f4-44ef-b35f-a572f89a1218" },
                    { "c98263e8-c741-4b7e-928e-133e9927d914", "e443fbad-4027-44d9-b53d-5837d7588fa2" },
                    { "c98263e8-c741-4b7e-928e-133e9927d914", "71d30880-20c4-4ca5-9599-1746df8d15f0" },
                    { "c98263e8-c741-4b7e-928e-133e9927d914", "070ebbf6-6f6b-4cf1-bad7-9447dd5dd310" },
                    { "c98263e8-c741-4b7e-928e-133e9927d914", "08ea12cb-8ccb-4ae0-bf40-ae8ccbf52482" },
                    { "c98263e8-c741-4b7e-928e-133e9927d914", "7dd284b7-4bc5-4350-b013-ea668a8937bf" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 8, 3, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 589.5714f, "Nissan,Titan King Cab, Pickup", "SEV23KOPAICKADJZRGB1", "PDGY93L7PRY8FU5U2SEH", "7dd284b7-4bc5-4350-b013-ea668a8937bf", "UIYT4FXWIP2SXEXXS" },
                    { 7, 4, "Grey", new DateTimeOffset(new DateTime(2016, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 572.78864f, "Jeep,Wrangler Unlimited, SUV", "58TX3RVWAV4PLZCADMYU", "RCRXMXE1AIH8NIEOL24M", "7dd284b7-4bc5-4350-b013-ea668a8937bf", "Y8YUH2ZK40ADETGVA" },
                    { 5, 2, "White", new DateTimeOffset(new DateTime(2016, 7, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 642.5682f, "Porsche,911, Convertible, Coupe", "XP9SRFXLIVKFNMPWX6JK", "HB9T8MQQ9WAZJ50GL61P", "7dd284b7-4bc5-4350-b013-ea668a8937bf", "2ZQWL44ZB195BMGGK" },
                    { 1, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 956.4251f, "Jeep,Wrangler, SUV", "FQQVYVU3KXEM6DTNTG5N", "SX76D27G6AWTF3QK8STQ", "75badc63-f7f4-44ef-b35f-a572f89a1218", "GU1E82OIJ3W28IIJI" },
                    { 10, 2, "Blue", new DateTimeOffset(new DateTime(2016, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 412.48547f, "Nissan,TITAN XD Crew Cab, Pickup", "ZNBVZ7Z5PAY1SPMYKUVX", "8MFOOO1NY86QH8JYW63N", "08d97b99-743e-4173-a06f-c0dfe18589e8", "NPV4DKPXWNKUJD8N6" },
                    { 2, 2, "Red", new DateTimeOffset(new DateTime(2016, 7, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 655.9693f, "Porsche,Cayenne, SUV", "A1K62M9F1NEQLGD5YU4R", "ORSXDU71P9X3JA6SH75F", "08ea12cb-8ccb-4ae0-bf40-ae8ccbf52482", "IGHCN25DJ1IM8J8NT" },
                    { 4, 4, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 560.25037f, "Porsche,911, Convertible, Coupe", "CRN46IM8UUDCLWIRNDCO", "LLWRWZPVGW44JUHL54HS", "08ea12cb-8ccb-4ae0-bf40-ae8ccbf52482", "Y6VYS5BYLVBB8QUW8" },
                    { 9, 4, "Red", new DateTimeOffset(new DateTime(2016, 7, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 544.61536f, "Porsche,Cayenne, SUV", "IK34F8OWZ2UQUJX0FZ5A", "T986NXRW5ZEIUVBYUPO7", "e443fbad-4027-44d9-b53d-5837d7588fa2", "JM822VZWDZT669BWH" },
                    { 3, 2, "Green", new DateTimeOffset(new DateTime(2016, 7, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 734.87256f, "Nissan,TITAN XD Crew Cab, Pickup", "RPB6AAKOQOPCK8CF075W", "BPVKX1MKTEX17DQQ65DR", "e443fbad-4027-44d9-b53d-5837d7588fa2", "TCT9OAV7T09BE1UQ9" },
                    { 6, 2, "Green", new DateTimeOffset(new DateTime(2016, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 930.2133f, "Ford,F350 Super Duty Crew Cab, Pickup", "MLLVHM9BR4U54892B0ML", "9K8PDUD05LW070GD504H", "070ebbf6-6f6b-4cf1-bad7-9447dd5dd310", "KWE07E6E943K22CVI" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Bergstrom - Hillsholistic Saint Pierre and Miquelon software Manager Money Market Account coherent indigo partnerships Burundi Franc American Samoa program Program Trinidad and Tobago Dollar PCI.", new DateTimeOffset(new DateTime(2022, 7, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 285.06345f, false, "e443fbad-4027-44d9-b53d-5837d7588fa2", 8, null, new DateTimeOffset(new DateTime(2022, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Rohan, Witting and Kuvalisgold Parks Engineer Toys & Sports Accounts Licensed Plastic Keyboard channels Cambridgeshire sky blue salmon Borders Belize Dollar Baby Refined Concrete Cheese quantifying Licensed Beauty Future-proofed Mayotte program Seychelles intermediate Borders Credit Card Account Personal Loan Account Fantastic Rubber Salad Idaho.", new DateTimeOffset(new DateTime(2022, 7, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 194.7702f, false, "08ea12cb-8ccb-4ae0-bf40-ae8ccbf52482", 2, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Purdy - ShieldsGuadeloupe calculate leverage backing up port Administrator synthesize Buckinghamshire Lilangeni Angola JSON seize Wooden monitor Ameliorated input Incredible.", new DateTimeOffset(new DateTime(2022, 7, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 265.5286f, false, "08ea12cb-8ccb-4ae0-bf40-ae8ccbf52482", 12, null, new DateTimeOffset(new DateTime(2022, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 29, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Bosco, Howell and O'ConnerAuto Loan Account matrix Handmade Rubber Sausages Gorgeous Concrete Shoes Buckinghamshire Home Loan Account Plastic invoice cultivate e-business Handmade Granite Chicken.", new DateTimeOffset(new DateTime(2022, 7, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 774.96027f, false, "08ea12cb-8ccb-4ae0-bf40-ae8ccbf52482", 14, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 22, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Zieme, Fisher and KubCambridgeshire Knolls architectures enable Metrics users approach e-business wireless Music calculating Rustic Metal Mouse Awesome Fresh Chicken Moldova Sleek Rubber Tuna Personal Loan Account Generic Wooden Mouse Regional e-business Electronics, Games & Garden De-engineered payment Practical Concrete Chicken B2C Alaska.", new DateTimeOffset(new DateTime(2022, 7, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 309.82993f, false, "08ea12cb-8ccb-4ae0-bf40-ae8ccbf52482", 19, null, new DateTimeOffset(new DateTime(2022, 7, 5, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 30, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Witting, Ebert and Hauckinterfaces calculating Manager Wooden Underpass invoice synergize cyan Cambridgeshire best-of-breed.", new DateTimeOffset(new DateTime(2022, 7, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 617.55054f, false, "7dd284b7-4bc5-4350-b013-ea668a8937bf", 11, null, new DateTimeOffset(new DateTime(2022, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 23, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Considine and SonsMontana Northern Mariana Islands Refined Frozen Bike Texas Implementation exploit Checking Account next-generation engineer Response plum expedite Phased matrix Reduced.", new DateTimeOffset(new DateTime(2022, 7, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 808.4439f, false, "070ebbf6-6f6b-4cf1-bad7-9447dd5dd310", 6, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Lindgren - QuigleyCustomizable data-warehouse Generic Investment Account quantify end-to-end plug-and-play interface Isle generating Ferry strategize.", new DateTimeOffset(new DateTime(2022, 7, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 335.7376f, false, "070ebbf6-6f6b-4cf1-bad7-9447dd5dd310", 7, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Spinka, Purdy and Yundtneural transmit Rustic Cotton Fish global relationships indexing maroon scalable intranet Rubber Fields index Frozen Orchestrator vortals invoice benchmark Trail purple Incredible Frozen Tuna quantify copy Licensed Cotton Chair.", new DateTimeOffset(new DateTime(2022, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 394.39752f, false, "75badc63-f7f4-44ef-b35f-a572f89a1218", 20, null, new DateTimeOffset(new DateTime(2022, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 27, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Bechtelar - Gibsonmint green parse Vanuatu Movies, Shoes & Home Handmade Concrete Car Berkshire Borders visualize Executive withdrawal grow orange info-mediaries cutting-edge e-markets Mobility Moroccan Dirham one-to-one neutral Connecticut synthesize framework robust Central Dynamic Centralized Metal Sleek Fresh Shoes compress.", new DateTimeOffset(new DateTime(2022, 7, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 958.0498f, false, "e443fbad-4027-44d9-b53d-5837d7588fa2", 5, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 21, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Armstrong, Frami and ReingerConfiguration Generic Rubber Salad Handmade Metal Soap synthesize payment Riel indigo complexity GB full-range.", new DateTimeOffset(new DateTime(2022, 7, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 824.49866f, false, "75badc63-f7f4-44ef-b35f-a572f89a1218", 15, null, new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Wisoky LLCAuto Loan Account Cambridgeshire Human European Monetary Unit (E.M.U.-6) Auto Loan Account Incredible Steel Tuna Forward Ramp Ergonomic Steel Mouse Supervisor Svalbard & Jan Mayen Islands Auto Loan Account system Rustic Soft Car Checking Account program transform process improvement Granite deposit dedicated Handmade.", new DateTimeOffset(new DateTime(2022, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 309.60043f, false, "75badc63-f7f4-44ef-b35f-a572f89a1218", 4, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Howe IncHandcrafted Concrete Tuna hard drive recontextualize neural Fork Practical bandwidth Avon lavender Handcrafted Soft Towels copying Intelligent Wooden Gloves overriding indexing.", new DateTimeOffset(new DateTime(2022, 7, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 435.47763f, false, "070ebbf6-6f6b-4cf1-bad7-9447dd5dd310", 10, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 23, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Sauer, Nikolaus and LebsackUnbranded Rubber Chips Director Concrete Refined Steel Sausages bypass Mission Pennsylvania solution-oriented transmitter bluetooth Licensed Concrete Chair Direct backing up Gibraltar Pound collaborative Personal Loan Account user-centric framework invoice payment Unbranded Frozen Hat Automated visualize Engineer.", new DateTimeOffset(new DateTime(2022, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 112.22237f, false, "71d30880-20c4-4ca5-9599-1746df8d15f0", 18, null, new DateTimeOffset(new DateTime(2022, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 24, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Hagenes IncMobility Accounts GB applications Investment Account Swedish Krona software Soft Grocery, Automotive & Sports Home Loan Account Cayman Islands Practical Metal Keyboard connect open system Austria Bedfordshire extensible Guinea quantifying Practical Frozen Salad Credit Card Account Vision-oriented e-business lavender contingency e-markets.", new DateTimeOffset(new DateTime(2022, 7, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 819.4861f, false, "71d30880-20c4-4ca5-9599-1746df8d15f0", 17, null, new DateTimeOffset(new DateTime(2022, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Kiehn - Stoltenberguser-centric Sports, Sports & Kids Balanced Rubber local area network Concrete back up content lavender Liaison payment Internal Incredible Frozen Keyboard Handcrafted Frozen Gloves bus Granite copy strategic Incredible Money Market Account Future port Strategist payment.", new DateTimeOffset(new DateTime(2022, 7, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 333.94983f, false, "71d30880-20c4-4ca5-9599-1746df8d15f0", 3, null, new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Vandervort, Cummings and KilbackArkansas Fresh Rubber web-enabled Loop National hacking wireless quantify Granite Multi-lateral portals Brook Mexico zero administration Wooden matrix Compatible Accounts Gorgeous Plastic Shirt Tools, Home & Industrial Solutions web-readiness proactive Branding Handcrafted copy Steel.", new DateTimeOffset(new DateTime(2022, 7, 7, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 764.847f, false, "08d97b99-743e-4173-a06f-c0dfe18589e8", 1, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 30, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Wisoky, Johnson and BeerNew Jersey navigating Direct yellow Kyat Corporate Auto Loan Account Up-sized British Indian Ocean Territory (Chagos Archipelago) multi-byte Auto Loan Account 24/7 De-engineered Sleek invoice Pound Sterling.", new DateTimeOffset(new DateTime(2022, 7, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 637.7617f, false, "e443fbad-4027-44d9-b53d-5837d7588fa2", 16, null, new DateTimeOffset(new DateTime(2022, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Bernhard, Gusikowski and RoobLicensed Steel Cheese pixel matrix magenta Borders bleeding-edge Camp Avon Virgin Islands, British Personal Loan Account Nepalese Rupee Music & Kids open-source Auto Loan Account.", new DateTimeOffset(new DateTime(2022, 7, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 755.5281f, false, "070ebbf6-6f6b-4cf1-bad7-9447dd5dd310", 9, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Harber, Becker and Abshireresponsive Fantastic Metal Mouse online Ville target Fresh Soft Malagasy Ariary Fundamental Lock Estates Concrete Personal Loan Account Illinois Incredible Wooden Bike Unions Generic Rubber stable Bulgarian Lev Centralized Cape Analyst Creative quantifying Buckinghamshire productize hub Tunnel.", new DateTimeOffset(new DateTime(2022, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 918.5042f, false, "08d97b99-743e-4173-a06f-c0dfe18589e8", 13, null, new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cabac42-7be9-4599-a5d1-da1b35b6c5e9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c98263e8-c741-4b7e-928e-133e9927d914", "070ebbf6-6f6b-4cf1-bad7-9447dd5dd310" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c98263e8-c741-4b7e-928e-133e9927d914", "08d97b99-743e-4173-a06f-c0dfe18589e8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c98263e8-c741-4b7e-928e-133e9927d914", "08ea12cb-8ccb-4ae0-bf40-ae8ccbf52482" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bac99df7-fe71-49f0-be14-c89dca349245", "4c505239-31b5-4fc8-a06d-b9176ad5d705" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c98263e8-c741-4b7e-928e-133e9927d914", "71d30880-20c4-4ca5-9599-1746df8d15f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c98263e8-c741-4b7e-928e-133e9927d914", "75badc63-f7f4-44ef-b35f-a572f89a1218" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c98263e8-c741-4b7e-928e-133e9927d914", "7dd284b7-4bc5-4350-b013-ea668a8937bf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c98263e8-c741-4b7e-928e-133e9927d914", "e443fbad-4027-44d9-b53d-5837d7588fa2" });

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
                keyValue: "bac99df7-fe71-49f0-be14-c89dca349245");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c98263e8-c741-4b7e-928e-133e9927d914");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070ebbf6-6f6b-4cf1-bad7-9447dd5dd310");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08d97b99-743e-4173-a06f-c0dfe18589e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08ea12cb-8ccb-4ae0-bf40-ae8ccbf52482");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c505239-31b5-4fc8-a06d-b9176ad5d705");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71d30880-20c4-4ca5-9599-1746df8d15f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75badc63-f7f4-44ef-b35f-a572f89a1218");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dd284b7-4bc5-4350-b013-ea668a8937bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e443fbad-4027-44d9-b53d-5837d7588fa2");

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
