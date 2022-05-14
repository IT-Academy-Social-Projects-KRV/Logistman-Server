using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class FirstSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Points",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Points",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "76ec43c7-a63d-4736-8848-3565beafb104", "76ec43c7-a63d-4736-8848-3565beafb104", "Logist", "LOGIST" },
                    { "39f99fcc-a477-44cf-b63c-28c71125051a", "39f99fcc-a477-44cf-b63c-28c71125051a", "User", "USER" },
                    { "31a8a679-7363-474f-a0a4-2369e454dbd3", "31a8a679-7363-474f-a0a4-2369e454dbd3", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fba7f254-af75-4e70-ac3f-1225b5829e07", 0, "dce85734-2048-4454-b5fc-aaefd5a4466b", "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEBkPcCrCvd8geCbYfRh+Iw+UxvXHUd+JtXL1sZYzfY5Mz8i2tvrP2rctkk773/dV+g==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 14, 9, 38, 22, 616, DateTimeKind.Unspecified).AddTicks(9919), new TimeSpan(0, 0, 0, 0, 0)), "366d5176-41ed-43b8-8aac-002543af0ddc", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "105bfb3a-534d-47b4-b65f-f61c5c8f71e6", 0, "8a718a4b-e45a-45d4-b63b-c29e1352e362", "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antinina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEAh0/XnlQUE7di4AD6O731IfVsDbw6PcfTXJXCCWZMBv9IVqMLe63XlRG585eocX3A==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 14, 9, 38, 22, 616, DateTimeKind.Unspecified).AddTicks(9909), new TimeSpan(0, 0, 0, 0, 0)), "9fc82413-73f5-4d01-8b34-14964a392722", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "c54aab00-11c2-432e-965e-4123bec521b4", 0, "b021b941-cc1c-48d0-a04c-96dd026f7c8c", "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEHK80dPXpq+bFRYwSn1NXHNUB8C35uio78j4Q0y2RrlRRl2O3Qo79cAgsTlrV8dzNw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 14, 9, 38, 22, 616, DateTimeKind.Unspecified).AddTicks(9901), new TimeSpan(0, 0, 0, 0, 0)), "14855f7a-d009-446a-bef1-0c2fd67f246d", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "71cedee3-b2b7-41a4-bb6f-559ff2061591", 0, "9d6caa44-718a-4a38-89ff-9b5d38febad9", "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEOgrFjZe/+RyqRG2tOIQA4YxQprc9ikChp3Q6wvkoYAPJGJqeK5Z0bl2Cd+Hq3lxNw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 14, 9, 38, 22, 616, DateTimeKind.Unspecified).AddTicks(9892), new TimeSpan(0, 0, 0, 0, 0)), "5cb2c6e1-20c6-4bb2-a59e-c6562fe9c97d", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "046a9d71-4627-4117-8d5e-512bd2c3c49b", 0, "9b48cdbf-b110-410c-a9d0-1805dc5c31a9", "User", "marynakernychna@gmail.com", true, false, null, "Maryna", "MARYNAKERNYCHNA@GMAIL.COM", "MARYNAKERNYCHNA@GMAIL.COM", "AQAAAAEAACcQAAAAENsATZaCwmgVW6GPKCRRo+kuPS1cdKMWqEVVhMnJwh0w/3luKX/tSYTYsfiABnzk5A==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 14, 9, 38, 22, 616, DateTimeKind.Unspecified).AddTicks(9881), new TimeSpan(0, 0, 0, 0, 0)), "6de24899-2933-4bfc-9883-9de9d66bae81", "Kernychna", false, "marynakernychna@gmail.com" },
                    { "e09b9653-368a-4e33-9f4a-d6cca72be3ed", 0, "e458f1df-2d2d-4343-9624-bb1bda44c154", "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEDjS4A4yzhdvmN0roI+5rL9Ecjpoy7XI9YzB0c2ly3RyeRo8A1J7GCzr4aoxu3/hxQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 14, 9, 38, 22, 616, DateTimeKind.Unspecified).AddTicks(9872), new TimeSpan(0, 0, 0, 0, 0)), "8d9e168d-cd16-44ca-b0f6-fc2d8b88abec", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "419a15a5-6494-4d52-ba85-906d3f89aa4d", 0, "043202de-b20f-4d69-9203-acedfc04fd47", "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEEQRFInInGQyWWqGKEBt4WSiB8TZDNrGPwJ39gvrWPwhCu0IJM1dBxQLsHd2fFBqhQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 14, 9, 38, 22, 616, DateTimeKind.Unspecified).AddTicks(9837), new TimeSpan(0, 0, 0, 0, 0)), "75c6a64c-731a-4ba4-bae4-da156ccb2477", "Sevastyanov", false, "oppaiarchmaster@gmail.com" },
                    { "6d4fc6f0-f463-4c1f-b2a9-92bf4bfac356", 0, "1359260c-a74c-4952-81f1-15e58980d0ab", "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEI3dUdtTKjQeEQm6v4pG/6SM3PHhShW9l15+bLA7l8kVsumk/vmKIoCM8j4pzIdN+w==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 14, 9, 38, 22, 616, DateTimeKind.Unspecified).AddTicks(6918), new TimeSpan(0, 0, 0, 0, 0)), "115fcd03-28a5-4007-8d1d-1385ce7ad77d", "Chorrny", false, "chorrny228@gmail.com" }
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
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Order", "Region", "Settlement" },
                values: new object[,]
                {
                    { 2, "місто Шпанів, Рівненська область, вулиця Вереснева", 50.663542, 26.257569, 0, " Рівненська область", "Шпанів" },
                    { 20, "місто Житомир, Житомирська область, Богунський район", 50.259729999999998, 28.649229999999999, 0, "Житомирська область", "Житомир" },
                    { 19, "місто Біла церква, Київська область, вулиця Кірова", 49.807687086999998, 30.1144958, 0, "Київська область", "Біла церква" },
                    { 18, "Горбово, Чернігівська область, 16311", 51.45984, 31.561633, 0, "Чернігівська область", "Горбово" },
                    { 1, "місто Остріг, Рівненська область, вулиця Східна", 50.328792, 26.527293, 0, "Рівненська область", "Острог" },
                    { 17, "Бобринець, Кіровоградська  область, вулиця Орджонікідзе", 48.061315, 32.158811, 0, "Кіровоградська  область", "Бобринець" },
                    { 15, "місто Миколаїв, Миколаївська область, вулиця Слов'янська", 47.032940848000003, 32.007182749999998, 0, "Миколаївська область", "Миколаїв" },
                    { 14, "місто Вінниця, Вінницька область, вулиця Братславська", 49.232585, 28.494243999999998, 0, "Вінницька область", "Вінниця" },
                    { 13, "Маків, Хмельницька  область, провулок Прорізний", 48.784157, 26.702999999999999, 0, "Хмельницька  область", "Маків" },
                    { 12, "місто Ужгород, Закарпатская область, вулиця Шишкіна, 1", 48.610622999999997, 22.317772999999999, 0, "Закарпатская область", "Ужгород" },
                    { 10, "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко", 48.460256999999999, 35.018729, 0, "Дніпропетровська область", "Дніпро" },
                    { 9, "Новодонецьк, Донецька область, вулиця Благовісна", 48.633740000000003, 36.980499999999999, 0, "Донецька область", "Новодонецьк" },
                    { 8, "Ульянівка, Харківська область", 49.371445999999999, 35.513638, 0, "Харківська область", "Ульянівка" },
                    { 7, "Гаврилівка, Харківська область, вулиця Коцюбинського", 49.672877999999997, 35.660035000000001, 0, "Харківська область", "Дніпро" },
                    { 6, "Макаровка, Донецька область", 47.779212000000001, 36.801640999999996, 0, "Донецька область", "Макаровка" },
                    { 5, "місто Нікольське, Донецька область, вулиця Пушкіна", 47.200732350000003, 37.3148804, 0, "Донецька область", "Нікольське" },
                    { 4, "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко", 48.462322270000001, 35.021573400000001, 0, "Дніпропетровська область", "Дніпро" },
                    { 3, "місто Луцьк, Волинська область, вулиця Хрещата", 50.723970999999999, 25.386282000000001, 0, "Волинська область", "Луцьк" },
                    { 16, "Центральний пайон, місто Миколаїв, Миколаївська область, вулиця Дачна", 47.044604, 32.030366999999998, 0, "Миколаївська область", "Миколаїв" },
                    { 11, "місто Львів, Львівська область, просп. Вячеслава Черновола, 11", 49.846894900000002, 4.0253360999999996, 0, "Львівська область", "Львів" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "SENDER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "RECIPIENT" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "39f99fcc-a477-44cf-b63c-28c71125051a", "fba7f254-af75-4e70-ac3f-1225b5829e07" },
                    { "39f99fcc-a477-44cf-b63c-28c71125051a", "e09b9653-368a-4e33-9f4a-d6cca72be3ed" },
                    { "39f99fcc-a477-44cf-b63c-28c71125051a", "105bfb3a-534d-47b4-b65f-f61c5c8f71e6" },
                    { "39f99fcc-a477-44cf-b63c-28c71125051a", "046a9d71-4627-4117-8d5e-512bd2c3c49b" },
                    { "39f99fcc-a477-44cf-b63c-28c71125051a", "c54aab00-11c2-432e-965e-4123bec521b4" },
                    { "39f99fcc-a477-44cf-b63c-28c71125051a", "419a15a5-6494-4d52-ba85-906d3f89aa4d" },
                    { "39f99fcc-a477-44cf-b63c-28c71125051a", "6d4fc6f0-f463-4c1f-b2a9-92bf4bfac356" },
                    { "39f99fcc-a477-44cf-b63c-28c71125051a", "71cedee3-b2b7-41a4-bb6f-559ff2061591" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 10, 3, "Червоний", new DateTimeOffset(new DateTime(2016, 7, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 423.4735f, "P 930 X", "30EKWZIGMMCUFYB63TQ5", "4Z21UK9YOIL8XG9Y4BF7", "fba7f254-af75-4e70-ac3f-1225b5829e07", "3QUSNCOFUDURS3XCP" },
                    { 9, 2, "Синій", new DateTimeOffset(new DateTime(2016, 7, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 883.85297f, "V 791 K", "BVM9BXDHMKTEN1KJHR2F", "7OSB9PZ6WPOQE8GNKYBG", "fba7f254-af75-4e70-ac3f-1225b5829e07", "UDCYJWC6JJQC7M3B0" },
                    { 8, 2, "Сірий", new DateTimeOffset(new DateTime(2016, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 985.3912f, "V 530 N", "YGR0GRP9DXHL3X7TG4CJ", "CLAT3QQEGLJ6QHNWW3MP", "fba7f254-af75-4e70-ac3f-1225b5829e07", "6MSJ68MD6CHX5D6XW" },
                    { 7, 3, "Жовтий", new DateTimeOffset(new DateTime(2016, 7, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 999.94354f, "E 549 T", "YDPFO7OMPO3BV8GNXXMX", "HT3JKHK7T755U480W8O9", "fba7f254-af75-4e70-ac3f-1225b5829e07", "7ZMCN32GOSJKA4A6U" },
                    { 6, 4, "Білий", new DateTimeOffset(new DateTime(2016, 7, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 938.62683f, "L 298 E", "CARFD81B3UN4ZOP4FJJK", "FNRFV9MA4L2PQ980XRXU", "fba7f254-af75-4e70-ac3f-1225b5829e07", "CV6EMOCHOLWNQOJCJ" },
                    { 5, 2, "Чорний", new DateTimeOffset(new DateTime(2016, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 533.7221f, "G 811 Q", "N0L3FP01Q8GS1U86E1S2", "T3E91TLULI24H9FUYDQO", "fba7f254-af75-4e70-ac3f-1225b5829e07", "YFLBO6B2XNGQUJLC2" },
                    { 1, 3, "Жовтий", new DateTimeOffset(new DateTime(2016, 7, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 464.81357f, "J 647 C", "PPBAZNIAVANI5TCJ4XSN", "LRWO6M8XB1TFRZVLN1FY", "fba7f254-af75-4e70-ac3f-1225b5829e07", "J0RMCPDGTCJYIYTN4" },
                    { 2, 2, "Синій", new DateTimeOffset(new DateTime(2016, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 850.0507f, "Y 860 L", "7R6YQW2HTJP8VWJAJKV7", "HVSGXSZX3KIXPKJV6QMJ", "6d4fc6f0-f463-4c1f-b2a9-92bf4bfac356", "QFSQXQK2U03MZCYP1" },
                    { 3, 2, "Червоний", new DateTimeOffset(new DateTime(2016, 7, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 440.6249f, "K 327 A", "RJBDN4SYBGM4DN6U9C1P", "IU2L7XGPONLGHF07MDXY", "e09b9653-368a-4e33-9f4a-d6cca72be3ed", "R5C7L1U3NSDJIXGQ5" },
                    { 4, 4, "Білий", new DateTimeOffset(new DateTime(2016, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 854.99817f, "H 709 W", "6NYMZ8VF3NF2W9ZCFVK0", "T2XW3QW76AZS2A5JNEUU", "6d4fc6f0-f463-4c1f-b2a9-92bf4bfac356", "AW2UKH6E86OO14Q1J" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "contextually-based Metal even-keeled Generic Concrete Shirt payment Planner blue Refined Cotton Hat copy Metal infomediaries salmon Island withdrawal mint green array Specialist out-of-the-box communities primary.", new DateTimeOffset(new DateTime(2022, 7, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 361.69724f, false, "6d4fc6f0-f463-4c1f-b2a9-92bf4bfac356", 2, null, new DateTimeOffset(new DateTime(2022, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Automotive, Computers & Grocery contingency Usability Group Direct Soft Incredible Granite calculating moderator reinvent Rwanda Franc connecting Islands Square Lead Canyon transmitting Toys, Industrial & Music Home Loan Account plum Lodge Investment Account.", new DateTimeOffset(new DateTime(2022, 7, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 275.32925f, false, "6d4fc6f0-f463-4c1f-b2a9-92bf4bfac356", 12, null, new DateTimeOffset(new DateTime(2022, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Ergonomic Frozen Pants Sleek primary deliver Generic Granite Soap Avon Bedfordshire platforms Secured optical extend online Open-source Cotton models backing up Reduced Optional Swiss Franc Fantastic Mobility Music Namibia Jewelery & Baby incentivize Tasty open architecture user-centric.", new DateTimeOffset(new DateTime(2022, 7, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 862.10333f, false, "6d4fc6f0-f463-4c1f-b2a9-92bf4bfac356", 14, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "solutions Games, Music & Automotive IB Trafficway Common Mississippi programming exploit driver redundant payment uniform Cuba recontextualize.", new DateTimeOffset(new DateTime(2022, 7, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 534.692f, false, "6d4fc6f0-f463-4c1f-b2a9-92bf4bfac356", 19, null, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Mission e-tailers Albania Bedfordshire multi-byte Robust withdrawal tertiary Malawi Integration matrix maximize blue Optimization.", new DateTimeOffset(new DateTime(2022, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 965.1592f, false, "419a15a5-6494-4d52-ba85-906d3f89aa4d", 6, null, new DateTimeOffset(new DateTime(2022, 7, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "transform alarm New Hampshire pixel Pennsylvania Cambridgeshire invoice Handcrafted Wooden Table Refined Burkina Faso primary Cape Manager Investment Account Cotton gold Forward solid state reintermediate.", new DateTimeOffset(new DateTime(2022, 7, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 658.5526f, false, "419a15a5-6494-4d52-ba85-906d3f89aa4d", 7, null, new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Chile Dong Rustic Cotton Chicken Profit-focused hub Lane Tala Auto Loan Account Squares PCI Synergized hack Unbranded digital overriding Identity SMTP Comoros integrate calculate Dobra Industrial Coordinator Buckinghamshire.", new DateTimeOffset(new DateTime(2022, 7, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 421.72977f, false, "419a15a5-6494-4d52-ba85-906d3f89aa4d", 9, null, new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Frozen Practical Fresh Chair primary Avon Alabama deploy technologies Baby Cambridgeshire Curve Awesome Graphical User Interface partnerships COM Leone Bahraini Dinar Cambridgeshire productivity invoice Creative District leading-edge value-added protocol Mill Cambridgeshire invoice.", new DateTimeOffset(new DateTime(2022, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 971.411f, false, "419a15a5-6494-4d52-ba85-906d3f89aa4d", 10, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Lead schemas Connecticut Manager Bulgarian Lev Utah compressing best-of-breed Investment Account Cordoba Oro alarm payment digital Health & Industrial Groves Credit Card Account deposit Awesome Fresh Shoes Ergonomic Frozen Chicken Planner Tasty Checking Account Buckinghamshire Books & Computers exploit.", new DateTimeOffset(new DateTime(2022, 7, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 4.1803074f, false, "71cedee3-b2b7-41a4-bb6f-559ff2061591", 1, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Texas needs-based matrix Road Way Turkmenistan Money Market Account deposit blue niches parsing black Riel Zimbabwe Dollar eyeballs Awesome Frozen Mouse efficient Practical Frozen Car empowering Granite Brand Sleek Plastic Fish.", new DateTimeOffset(new DateTime(2022, 7, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 369.08643f, false, "e09b9653-368a-4e33-9f4a-d6cca72be3ed", 11, null, new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Handmade Frozen Pants Berkshire Shores IB Human systems Cotton plum PCI functionalities violet payment Berkshire solutions override blue intuitive calculate website Licensed streamline Harbor Identity e-commerce Savings Account e-tailers platforms.", new DateTimeOffset(new DateTime(2022, 7, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 502.20074f, false, "e09b9653-368a-4e33-9f4a-d6cca72be3ed", 20, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Practical Granite Tuna French Polynesia frame New Jersey Buckinghamshire Forward Jewelery & Health payment Human Angola Rubber Unbranded Cotton Mouse Engineer invoice.", new DateTimeOffset(new DateTime(2022, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 267.56677f, false, "046a9d71-4627-4117-8d5e-512bd2c3c49b", 5, null, new DateTimeOffset(new DateTime(2022, 7, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "input Facilitator Center Comoro Franc Investor calculate innovate Direct pixel Jewelery & Games reboot PCI contextually-based Marketing Costa Rica world-class bus Garden, Kids & Baby hacking.", new DateTimeOffset(new DateTime(2022, 7, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 357.35373f, false, "105bfb3a-534d-47b4-b65f-f61c5c8f71e6", 15, null, new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "upward-trending override toolset Supervisor Run intangible Licensed Rubber Sausages Tasty value-added Grocery & Automotive Plastic lime Intelligent Bangladesh Plastic contingency capacitor South Carolina target leading-edge Pike Singapore Dollar Grocery Buckinghamshire strategy Home Loan Account primary Computers, Automotive & Computers.", new DateTimeOffset(new DateTime(2022, 7, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 215.0279f, false, "105bfb3a-534d-47b4-b65f-f61c5c8f71e6", 4, null, new DateTimeOffset(new DateTime(2022, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "bypassing Cotton website North Dakota online Orchard Handcrafted Cotton Table transmitting Jordan expedite Soft Awesome Metal Towels Pakistan Rupee clear-thinking bi-directional program superstructure Technician Analyst red salmon Baht fuchsia Future visionary Bedfordshire Coordinator.", new DateTimeOffset(new DateTime(2022, 7, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 387.22736f, false, "c54aab00-11c2-432e-965e-4123bec521b4", 18, null, new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Data stable pink ROI Computers, Games & Outdoors Business-focused best-of-breed Buckinghamshire payment deposit Zloty fuchsia Savings Account Gorgeous Metal Salad Rustic Concrete Chair New York Mountain Fantastic Wooden Keyboard Coordinator streamline Way Harbors Haven multi-state Georgia Analyst primary indexing.", new DateTimeOffset(new DateTime(2022, 7, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 567.5099f, false, "c54aab00-11c2-432e-965e-4123bec521b4", 17, null, new DateTimeOffset(new DateTime(2022, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Seychelles Arkansas Kroon Personal Loan Account Focused Savings Account Morocco Virgin Islands, U.S. Rubber Licensed Fresh Car exploit green Expressway Incredible Frozen Shirt enterprise Land.", new DateTimeOffset(new DateTime(2022, 7, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 63.38857f, false, "046a9d71-4627-4117-8d5e-512bd2c3c49b", 8, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "alarm strategize engage Executive blue vertical Bedfordshire Cambridgeshire Incredible Rhode Island.", new DateTimeOffset(new DateTime(2022, 7, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 586.70825f, false, "71cedee3-b2b7-41a4-bb6f-559ff2061591", 13, null, new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Generic Soft Gloves payment Associate Executive connect Buckinghamshire Awesome orchestration Associate Tasty foreground parsing Group exploit infrastructures mobile.", new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 118.653786f, false, "046a9d71-4627-4117-8d5e-512bd2c3c49b", 16, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Indian Rupee lime Executive Ford Dale Avon synthesizing sexy program bypassing connect.", new DateTimeOffset(new DateTime(2022, 7, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 618.4799f, false, "c54aab00-11c2-432e-965e-4123bec521b4", 3, null, new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31a8a679-7363-474f-a0a4-2369e454dbd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76ec43c7-a63d-4736-8848-3565beafb104");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39f99fcc-a477-44cf-b63c-28c71125051a", "046a9d71-4627-4117-8d5e-512bd2c3c49b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39f99fcc-a477-44cf-b63c-28c71125051a", "105bfb3a-534d-47b4-b65f-f61c5c8f71e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39f99fcc-a477-44cf-b63c-28c71125051a", "419a15a5-6494-4d52-ba85-906d3f89aa4d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39f99fcc-a477-44cf-b63c-28c71125051a", "6d4fc6f0-f463-4c1f-b2a9-92bf4bfac356" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39f99fcc-a477-44cf-b63c-28c71125051a", "71cedee3-b2b7-41a4-bb6f-559ff2061591" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39f99fcc-a477-44cf-b63c-28c71125051a", "c54aab00-11c2-432e-965e-4123bec521b4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39f99fcc-a477-44cf-b63c-28c71125051a", "e09b9653-368a-4e33-9f4a-d6cca72be3ed" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39f99fcc-a477-44cf-b63c-28c71125051a", "fba7f254-af75-4e70-ac3f-1225b5829e07" });

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
                keyValue: "39f99fcc-a477-44cf-b63c-28c71125051a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "046a9d71-4627-4117-8d5e-512bd2c3c49b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105bfb3a-534d-47b4-b65f-f61c5c8f71e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "419a15a5-6494-4d52-ba85-906d3f89aa4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d4fc6f0-f463-4c1f-b2a9-92bf4bfac356");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71cedee3-b2b7-41a4-bb6f-559ff2061591");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c54aab00-11c2-432e-965e-4123bec521b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e09b9653-368a-4e33-9f4a-d6cca72be3ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fba7f254-af75-4e70-ac3f-1225b5829e07");

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
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<float>(
                name: "Longitude",
                table: "Points",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "Latitude",
                table: "Points",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
