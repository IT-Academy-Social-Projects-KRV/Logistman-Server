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
                    { "0cf1c239-0103-4837-a770-3a690e873d21", "0cf1c239-0103-4837-a770-3a690e873d21", "Logist", "LOGIST" },
                    { "434a3562-d911-44b4-9def-42aff094ccfa", "434a3562-d911-44b4-9def-42aff094ccfa", "User", "USER" },
                    { "9e296e62-93f5-426d-8cb7-301a5bdf09b4", "9e296e62-93f5-426d-8cb7-301a5bdf09b4", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6941f5ed-a04e-4bac-87fe-21ff5b28f5c7", 0, "bd330d66-a8c8-4db6-b597-747b7a7a859b", "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEHpnMiugBhtQpgtLPNHlhbYXLlHAge1YbnOvRb5+QU6V4qLYyrcyJfYGoYBUNi7lZQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 26, 21, 49, 14, 510, DateTimeKind.Unspecified).AddTicks(8613), new TimeSpan(0, 0, 0, 0, 0)), "28e4249d-b60d-4c96-bcc5-f9877a269618", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "5affa92c-c1bb-4465-9872-6f92e5fa6b53", 0, "70a5bc1b-e4f8-44b8-accf-b7d9513defc2", "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEC9oPNf+EyPwChAgfVxrTzeFiNeSCHowkEdydDrVT6Cp/2ZKni8ou59q0/AWdQfSUg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 26, 21, 49, 14, 510, DateTimeKind.Unspecified).AddTicks(8600), new TimeSpan(0, 0, 0, 0, 0)), "e4dc1340-396b-4a0d-999d-23d94ba7b84b", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "b022e8d9-57fd-4470-bd26-ebfb92b0e044", 0, "15c5778c-6232-422f-bed8-b24e2e4c62dd", "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEGPzK1tBwhys5opsjWGu2ZZEr/an8SJa4QRr+0U64+ArZHi15e32nK+VooRQM9iq3g==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 26, 21, 49, 14, 510, DateTimeKind.Unspecified).AddTicks(8589), new TimeSpan(0, 0, 0, 0, 0)), "fd69c10b-1d76-40d7-9d65-31900c2cda56", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "2130537d-2c33-4f1a-85ed-5479b0c6213d", 0, "333dabb9-3053-4543-b773-f080ae1a1ace", "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAENQlNeqVNjQJEQx7P0LyzFmT+9li1Gu9nKT2UMgL0KPlXvDpEYlikCC3MH/HvIglRw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 26, 21, 49, 14, 510, DateTimeKind.Unspecified).AddTicks(8559), new TimeSpan(0, 0, 0, 0, 0)), "e9d8d472-3782-4be5-8d30-5c6ece179e3a", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "9077d95e-c10c-4e15-8b17-8c0ec84a0e14", 0, "7456da3a-0ea2-4a53-b0a4-282c2d192090", "User", "marynakernychna@gmail.com", true, false, null, "Maryna", "MARYNAKERNYCHNA@GMAIL.COM", "MARYNAKERNYCHNA@GMAIL.COM", "AQAAAAEAACcQAAAAECy7ZMf+vktmR+Kmx+nmIa7olkQhTu+qDPO2hbeyz02Tfpd+s5SUYA1Vx2eEBt5p3Q==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 26, 21, 49, 14, 510, DateTimeKind.Unspecified).AddTicks(8544), new TimeSpan(0, 0, 0, 0, 0)), "24fc1348-a9a3-463f-b63b-a6ab7d3edf84", "Kernychna", false, "marynakernychna@gmail.com" },
                    { "16f3e8c2-8ed4-4c33-847b-00a78c688b19", 0, "ef4fef8d-d729-475e-9030-a43848f85b9b", "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEMt1Do0zFWdt5990WxTuxXkO8SVHI35dJHg2SrlpHWsFE56qQ2XxYfAZmsXu8CW0Jg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 26, 21, 49, 14, 510, DateTimeKind.Unspecified).AddTicks(8532), new TimeSpan(0, 0, 0, 0, 0)), "c32105fa-bad2-4102-9efc-5302473d93c8", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "04ab2f61-1335-4399-9a60-6c079e223d88", 0, "494a0a18-0732-4d96-9110-5a1a89d72988", "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEGbwUYIevhPzXl1Z5ppU6bX0VMXW6r63O0T3rMaw1g3bFvKGTmQiP4RqyczC8rIVpg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 26, 21, 49, 14, 510, DateTimeKind.Unspecified).AddTicks(8485), new TimeSpan(0, 0, 0, 0, 0)), "da6d5ef6-90eb-48f2-9d3a-ce86893b6333", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "ff9ef5b1-c563-47d9-9d56-60ee93f9298f", 0, "9e66cca7-42bb-49c2-8f55-d933c026848d", "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEI+2+Wx/C5KCPdtLopT6L/bc/Lo8fLiOnKNK4qtm/3/O5lAZmjiMkYIUalmNgxKxLQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 26, 21, 49, 14, 510, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 0, 0, 0, 0)), "22eb00d9-f3f7-4509-a26a-b2535d8c8e3c", "Chorrny", false, "chorrny228@gmail.com" }
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
                    { "434a3562-d911-44b4-9def-42aff094ccfa", "6941f5ed-a04e-4bac-87fe-21ff5b28f5c7" },
                    { "434a3562-d911-44b4-9def-42aff094ccfa", "16f3e8c2-8ed4-4c33-847b-00a78c688b19" },
                    { "434a3562-d911-44b4-9def-42aff094ccfa", "5affa92c-c1bb-4465-9872-6f92e5fa6b53" },
                    { "434a3562-d911-44b4-9def-42aff094ccfa", "9077d95e-c10c-4e15-8b17-8c0ec84a0e14" },
                    { "434a3562-d911-44b4-9def-42aff094ccfa", "b022e8d9-57fd-4470-bd26-ebfb92b0e044" },
                    { "434a3562-d911-44b4-9def-42aff094ccfa", "04ab2f61-1335-4399-9a60-6c079e223d88" },
                    { "434a3562-d911-44b4-9def-42aff094ccfa", "ff9ef5b1-c563-47d9-9d56-60ee93f9298f" },
                    { "434a3562-d911-44b4-9def-42aff094ccfa", "2130537d-2c33-4f1a-85ed-5479b0c6213d" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 10, 4, "Blue", new DateTimeOffset(new DateTime(2016, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 774.3549f, "Nissan,Titan Crew Cab, Pickup", "6NMYQOWWJ53KWBCB4URB", "2OLGJOHYI7FKOHSXVIZV", "6941f5ed-a04e-4bac-87fe-21ff5b28f5c7", "AF18TTEHZSF2GI15E" },
                    { 9, 3, "Red", new DateTimeOffset(new DateTime(2016, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 457.78503f, "Nissan,Titan King Cab, Pickup", "FOLP7I9AOT8A4BL8V8VN", "XAXSLKBURH6MCEMOBB2S", "6941f5ed-a04e-4bac-87fe-21ff5b28f5c7", "YLHGPKJPTK5SQ5QS4" },
                    { 8, 3, "Red", new DateTimeOffset(new DateTime(2016, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 875.7388f, "Jeep,Wrangler, SUV", "A22LB8HWD142MQ8ZUTV3", "6EY4WI609XCJCF7ZP6ZN", "6941f5ed-a04e-4bac-87fe-21ff5b28f5c7", "2CW19ACBNFQRUW4XO" },
                    { 7, 4, "Grey", new DateTimeOffset(new DateTime(2016, 7, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 506.87427f, "Porsche,Cayenne, SUV", "9W34CD674E8LPG3HTM98", "38ARM4RC5TC60E8MKGL5", "6941f5ed-a04e-4bac-87fe-21ff5b28f5c7", "H1RRAV9YFD13W1LBI" },
                    { 6, 3, "White", new DateTimeOffset(new DateTime(2016, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 618.1785f, "Jeep,Wrangler, SUV", "9ZKMK2YS4OV4GFWT7RPZ", "3YM4DKRLSURSZ32PM2CH", "6941f5ed-a04e-4bac-87fe-21ff5b28f5c7", "HJNKYIDOMG0DZBDG8" },
                    { 5, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 604.1258f, "Jeep,Wrangler, SUV", "PVJQW0MCTU9PKST3RNFG", "NRM0WO9A9KUO2ZPVBNZJ", "6941f5ed-a04e-4bac-87fe-21ff5b28f5c7", "CP7PXJB6M7JOEX9IT" },
                    { 1, 3, "Green", new DateTimeOffset(new DateTime(2016, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 678.0221f, "Nissan,Titan Crew Cab, Pickup", "MXNNTKPWN9VC2E9YZD3M", "2YMRZ7A6ZTRU0Q6PQCWN", "6941f5ed-a04e-4bac-87fe-21ff5b28f5c7", "Y1B9RRA5O36BGNAVN" },
                    { 2, 2, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 842.521f, "Porsche,Cayenne, SUV", "TH0CC8K8MHF6GZLFPGJV", "U5NOP9IEUPADXP5JBWEI", "ff9ef5b1-c563-47d9-9d56-60ee93f9298f", "2MQ5ZOPFX5QN2OTBM" },
                    { 3, 3, "White", new DateTimeOffset(new DateTime(2016, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 794.95605f, "Ford,F350 Super Duty Crew Cab, Pickup", "X628QU14T105X31YKAUP", "ER5MANHPZ9CSLI5GNW8T", "16f3e8c2-8ed4-4c33-847b-00a78c688b19", "43QI4LSC2SVFZ60FY" },
                    { 4, 2, "Red", new DateTimeOffset(new DateTime(2016, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 530.5269f, "Jeep,Wrangler Unlimited, SUV", "JO7JEXKAN1013M1VSJWX", "M7KX5JZF7Y5HB6LEJYPN", "ff9ef5b1-c563-47d9-9d56-60ee93f9298f", "FQUDWJZJ6JGEHB49D" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 21, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Walsh - WalkerWestern Sahara Self-enabling reintermediate Tasty Steel Towels Customer Internal Steel Avon XML strategic Forward Sleek Wooden Chair reinvent Solomon Islands Dollar Investor Identity responsive calculating deposit.", new DateTimeOffset(new DateTime(2022, 7, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 822.38995f, false, "ff9ef5b1-c563-47d9-9d56-60ee93f9298f", 2, null, new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Reinger - SkilesAvon methodology reboot copy driver alarm Mountains Pennsylvania Upgradable Personal Loan Account frictionless Global Officer Borders metrics.", new DateTimeOffset(new DateTime(2022, 7, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 553.279f, false, "ff9ef5b1-c563-47d9-9d56-60ee93f9298f", 12, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 25, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Schroeder - Metzreinvent Direct Grenada Sleek Fresh Shirt Awesome Plastic Ball B2B Inverse Maldives lime Legacy Automotive, Kids & Industrial transition Granite Awesome Square Intelligent Incredible Granite Tuna Buckinghamshire Officer Kids, Outdoors & Industrial analyzer Point challenge.", new DateTimeOffset(new DateTime(2022, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 104.35594f, false, "ff9ef5b1-c563-47d9-9d56-60ee93f9298f", 14, null, new DateTimeOffset(new DateTime(2022, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 24, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Powlowski, Bartoletti and ToyDominica whiteboard Technician Fantastic Plastic Mouse payment Cliff parallelism Sleek fuchsia sky blue Fresh Saudi Riyal compelling Cambridgeshire Organic modular Buckinghamshire back-end Corporate grow Point Pass bandwidth.", new DateTimeOffset(new DateTime(2022, 7, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 175.57687f, false, "ff9ef5b1-c563-47d9-9d56-60ee93f9298f", 19, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Pacocha, Kautzer and O'KonInvestment Account content-based 3rd generation Cambridgeshire optical AGP content Refined AI Branding challenge neural hard drive program.", new DateTimeOffset(new DateTime(2022, 7, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 468.78036f, false, "04ab2f61-1335-4399-9a60-6c079e223d88", 6, null, new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Smitham LLCgrey Venezuela New Hampshire teal ADP Response Avon RSS Manor Reunion mission-critical Fork back-end global Communications.", new DateTimeOffset(new DateTime(2022, 7, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 642.7203f, false, "04ab2f61-1335-4399-9a60-6c079e223d88", 7, null, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Hickle - HackettGranite Analyst zero administration Borders plum reboot efficient CSS Cliff invoice infrastructures technologies Administrator CSS.", new DateTimeOffset(new DateTime(2022, 7, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 936.41113f, false, "04ab2f61-1335-4399-9a60-6c079e223d88", 9, null, new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 29, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Johns, Kautzer and Veumconnect purple Cambridgeshire grey Pennsylvania Road engineer Toys Sudan Plastic payment open architecture Pre-emptive Administrator Dam payment systems deposit Object-based Buckinghamshire.", new DateTimeOffset(new DateTime(2022, 7, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 813.07355f, false, "04ab2f61-1335-4399-9a60-6c079e223d88", 10, null, new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Jacobi, Schamberger and Reynoldsmobile Intelligent Soft Towels Agent database turquoise Walks Global synergies bleeding-edge Bangladesh one-to-one flexibility Small Metal Shoes EXE help-desk National Auto Loan Account Sleek dot-com Expressway wireless Agent.", new DateTimeOffset(new DateTime(2022, 7, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 89.69818f, false, "2130537d-2c33-4f1a-85ed-5479b0c6213d", 1, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Collier - Torpdigital Fresh Central Fundamental lavender Generic mobile Directives next-generation value-added strategize Bedfordshire withdrawal synergy system Computers Unbranded Concrete Hat copy copy Granite FTP architecture.", new DateTimeOffset(new DateTime(2022, 7, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 409.01477f, false, "16f3e8c2-8ed4-4c33-847b-00a78c688b19", 11, null, new DateTimeOffset(new DateTime(2022, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Ledner Groupconcept National Executive projection Park Chief Camp Buckinghamshire Sleek bandwidth-monitored Functionality bluetooth recontextualize Algerian Dinar Sleek Rubber Ball plum.", new DateTimeOffset(new DateTime(2022, 7, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 827.9487f, false, "16f3e8c2-8ed4-4c33-847b-00a78c688b19", 20, null, new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 30, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Thiel Groupcross-media Health, Health & Beauty withdrawal lavender Square Branding Assistant Steel Solomon Islands Lakes open-source olive Refined quantify Paradigm Specialist Function-based Investment Account Savings Account Estate metrics interface override Louisiana Fresh Avon SQL Guyana Dollar.", new DateTimeOffset(new DateTime(2022, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 320.31757f, false, "9077d95e-c10c-4e15-8b17-8c0ec84a0e14", 5, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 24, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Denesik LLCAvon Multi-lateral Re-contextualized Practical Jewelery Web target Internal bandwidth Response Personal Loan Account payment parsing Tasty invoice Specialist Configurable input transmitting firewall GB Handmade Granite Bacon Steel Savings Account Tugrik.", new DateTimeOffset(new DateTime(2022, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 759.5488f, false, "5affa92c-c1bb-4465-9872-6f92e5fa6b53", 15, null, new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Stroman LLCBeauty, Kids & Sports Home Dynamic Fall compressing Cambridgeshire Money Market Account Industrial innovate Tasty Fresh Pizza Avon vertical program payment Money Market Account Courts Incredible Steel Chair Industrial viral Markets Creative compressing THX Identity Personal Loan Account Soft Organized.", new DateTimeOffset(new DateTime(2022, 7, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 610.0664f, false, "5affa92c-c1bb-4465-9872-6f92e5fa6b53", 4, null, new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Koch - AnkundingGeneric Cotton Fish Officer Programmable Optimization Human Re-contextualized Point Small Plastic Fish override Mountains overriding Investment Account Security optimal protocol transitional Identity Administrator Gorgeous Frozen Car SCSI Jamaica Automotive & Kids Gorgeous Frozen Chips Refined Fresh Bacon Texas.", new DateTimeOffset(new DateTime(2022, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 727.1999f, false, "b022e8d9-57fd-4470-bd26-ebfb92b0e044", 18, null, new DateTimeOffset(new DateTime(2022, 7, 5, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Breitenberg LLCElectronics & Baby Rupiah Representative Fresh Music & Baby Rustic Frozen Chips Tasty Fresh Chair deposit Kids Consultant SSL Refined Concrete Fish redundant Gibraltar Tasty Green Human.", new DateTimeOffset(new DateTime(2022, 7, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 568.337f, false, "b022e8d9-57fd-4470-bd26-ebfb92b0e044", 17, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Cronin and SonsKids virtual Future Clothing, Garden & Outdoors Planner Future Practical Concrete Sausages demand-driven solid state Buckinghamshire West Virginia 1080p Future-proofed innovate Lane invoice indexing Clothing, Automotive & Clothing International TCP expedite.", new DateTimeOffset(new DateTime(2022, 7, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 809.16284f, false, "9077d95e-c10c-4e15-8b17-8c0ec84a0e14", 8, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 29, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Welch, Marks and Wolfreintermediate Generic Music Architect Unbranded Corporate reciprocal Home Loan Account Flats Internal Bedfordshire Brand capacitor synthesize Public-key seize Designer.", new DateTimeOffset(new DateTime(2022, 7, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 876.47504f, false, "2130537d-2c33-4f1a-85ed-5479b0c6213d", 13, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Koch and Sonsbluetooth solutions panel Planner Group supply-chains Factors Small Soft Car bleeding-edge Practical Granite Cheese Polarised Small Cotton Sausages Iran.", new DateTimeOffset(new DateTime(2022, 7, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 801.01294f, false, "9077d95e-c10c-4e15-8b17-8c0ec84a0e14", 16, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Kutch IncFantastic Steel Shirt program Colorado Auto Loan Account overriding withdrawal Legacy synthesize circuit copying 24/365 GB Outdoors & Garden Implementation withdrawal Borders strategy Tasty Wooden Hat productize.", new DateTimeOffset(new DateTime(2022, 7, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 667.8035f, false, "b022e8d9-57fd-4470-bd26-ebfb92b0e044", 3, null, new DateTimeOffset(new DateTime(2022, 7, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cf1c239-0103-4837-a770-3a690e873d21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e296e62-93f5-426d-8cb7-301a5bdf09b4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "434a3562-d911-44b4-9def-42aff094ccfa", "04ab2f61-1335-4399-9a60-6c079e223d88" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "434a3562-d911-44b4-9def-42aff094ccfa", "16f3e8c2-8ed4-4c33-847b-00a78c688b19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "434a3562-d911-44b4-9def-42aff094ccfa", "2130537d-2c33-4f1a-85ed-5479b0c6213d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "434a3562-d911-44b4-9def-42aff094ccfa", "5affa92c-c1bb-4465-9872-6f92e5fa6b53" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "434a3562-d911-44b4-9def-42aff094ccfa", "6941f5ed-a04e-4bac-87fe-21ff5b28f5c7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "434a3562-d911-44b4-9def-42aff094ccfa", "9077d95e-c10c-4e15-8b17-8c0ec84a0e14" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "434a3562-d911-44b4-9def-42aff094ccfa", "b022e8d9-57fd-4470-bd26-ebfb92b0e044" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "434a3562-d911-44b4-9def-42aff094ccfa", "ff9ef5b1-c563-47d9-9d56-60ee93f9298f" });

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
                keyValue: "434a3562-d911-44b4-9def-42aff094ccfa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04ab2f61-1335-4399-9a60-6c079e223d88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16f3e8c2-8ed4-4c33-847b-00a78c688b19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2130537d-2c33-4f1a-85ed-5479b0c6213d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5affa92c-c1bb-4465-9872-6f92e5fa6b53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6941f5ed-a04e-4bac-87fe-21ff5b28f5c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9077d95e-c10c-4e15-8b17-8c0ec84a0e14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b022e8d9-57fd-4470-bd26-ebfb92b0e044");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff9ef5b1-c563-47d9-9d56-60ee93f9298f");

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
