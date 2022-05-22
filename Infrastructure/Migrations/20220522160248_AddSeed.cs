using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0af11548-2ad9-452b-82d3-008f6ec7bbbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "103c5f41-8d61-4fe3-b97e-9e683c666ea3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "50662ecc-f177-41fb-95b7-5ba272c2a4ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "762dd1e0-f2bb-4baa-8f2c-82d6d480df29" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "875c647c-6b1a-468c-97c5-294de8507eb3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "8b605fbc-b858-4225-8458-aa9715844640" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "8c17e1ba-57da-4b33-9559-badad2641fc3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "944e6c2f-7692-4c93-9a9c-81c30905a158" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "a4ffba1f-2bad-451a-9ad3-a8e35f1b989f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "e7a5c59a-b887-4043-bd3d-71b57733b5aa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50662ecc-f177-41fb-95b7-5ba272c2a4ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "762dd1e0-f2bb-4baa-8f2c-82d6d480df29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "875c647c-6b1a-468c-97c5-294de8507eb3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b605fbc-b858-4225-8458-aa9715844640");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c17e1ba-57da-4b33-9559-badad2641fc3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "944e6c2f-7692-4c93-9a9c-81c30905a158");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4ffba1f-2bad-451a-9ad3-a8e35f1b989f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7a5c59a-b887-4043-bd3d-71b57733b5aa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "User", "USER" },
                    { "c06deee3-2fa3-4aa8-b242-fb65c737e622", "c06deee3-2fa3-4aa8-b242-fb65c737e622", "Admin", "ADMIN" },
                    { "30b0d58d-895a-4583-b4d2-db9be0474cc7", "30b0d58d-895a-4583-b4d2-db9be0474cc7", "Logist", "LOGIST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "20168067-021d-4189-afe1-75199c8341bf", 0, "ff3b1a0b-82fb-4d3a-8429-1b40bb0a7da2", "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEG4DM1qr/MkfRuOqFlpfc5Y11SmPt8RwvjA7m6uVZ/UgoBnpfXZ0RJ0hUmm4stUR9A==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 2, 47, 2, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 0, 0, 0, 0)), "3a15166f-6476-44fe-b430-d0066d50909c", "Chorrny", false, "chorrny228@gmail.com" },
                    { "8d0e370b-b39a-47f9-98e7-36a8e3cbf58c", 0, "40592114-d956-43d2-8510-e6dc173750d8", "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEFbpppt9L/GYSNnfAme6srEy05bDqi/cTEiAwegSNDNerihZYegki/jsaaYBoYzuEQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 2, 47, 2, DateTimeKind.Unspecified).AddTicks(2621), new TimeSpan(0, 0, 0, 0, 0)), "3e40a1b3-c2db-40f0-b14d-7a8f10f9c788", "Sevastyanov", false, "oppaiarchmaster@gmail.com" },
                    { "c9166b2b-e0d6-418e-b510-a631db41b0b8", 0, "89c235d7-3894-4179-be75-c485c79d1aa2", "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAENXBkG2U5bXYbS9zISVkxQZSJWTMHOt15kujrnPIOnknh0Cu2rR2gXUeuM0uWQ1cTQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 2, 47, 2, DateTimeKind.Unspecified).AddTicks(2791), new TimeSpan(0, 0, 0, 0, 0)), "89096f54-f5cb-4508-9aa0-158b8d505903", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "daff4e48-4df0-4257-be42-356663c01791", 0, "9814fb89-2329-48d3-9b63-17b5e373359f", "User", "marynakernychna@gmail.com", true, false, null, "Maryna", "MARYNAKERNYCHNA@GMAIL.COM", "MARYNAKERNYCHNA@GMAIL.COM", "AQAAAAEAACcQAAAAEFo3Z2P72qPc7bkQfA3fCLZeisfLUf6C2JGrR9wu6lLBp834WpVWQa/1tOlhGEw8jA==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 2, 47, 2, DateTimeKind.Unspecified).AddTicks(2828), new TimeSpan(0, 0, 0, 0, 0)), "03565cbe-97f2-45f8-a4b2-32cc11060d4c", "Kernychna", false, "marynakernychna@gmail.com" },
                    { "1dbfd093-58a1-47da-ab05-d2b1353fd875", 0, "b175b1aa-1000-4119-855f-5c468eb6c3c0", "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAECfWmRf58oy3ZFsoLJN0vf9LfgxHjzcFHTl6rKTTjeuRGKwjG6QybDMLrgV8Fz1FSw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 2, 47, 2, DateTimeKind.Unspecified).AddTicks(2842), new TimeSpan(0, 0, 0, 0, 0)), "e9024392-9786-4ba7-987d-b03fcb6bc4fe", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "10e253ba-45b3-4207-93c7-7ffe5d5e6231", 0, "a350b3df-a184-455d-ab8d-495b3d87e21c", "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAED8EDOWw/ag/CEy0qs9HPOC8vMKH+7pdnjV9EgLIWfpxAi0dyFlumTxNd3N1b5u4Hg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 2, 47, 2, DateTimeKind.Unspecified).AddTicks(2857), new TimeSpan(0, 0, 0, 0, 0)), "f10eded1-8a6b-4c5e-9e63-c14874259ceb", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "13b57834-34d1-4867-b90d-5b404e5d73b3", 0, "d3fc7312-0b05-4d97-863a-387feeace063", "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEAvo22/KWb/WoptL0ZsWZ3w7AATx0dthaTqWoqyryo9I255YwISOgwvdyqVoEkloHg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 2, 47, 2, DateTimeKind.Unspecified).AddTicks(2874), new TimeSpan(0, 0, 0, 0, 0)), "09c640e4-f358-4b1f-a716-139c116b17fc", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "31d27b18-cbc2-44fc-b32b-3577eb75f788", 0, "3a5024c9-3fda-4076-a3af-e0a626b59fef", "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEHLODH03eIEL0yODbzK38dMhEJOEuN21bgP67VlarFJagye/YTbM1Veaxm47nhxrig==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 2, 47, 2, DateTimeKind.Unspecified).AddTicks(2887), new TimeSpan(0, 0, 0, 0, 0)), "160651bb-32e8-4416-abf3-f7f9742dde0a", "Eremenko", false, "sergeyeremenko@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "31d27b18-cbc2-44fc-b32b-3577eb75f788" },
                    { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "c9166b2b-e0d6-418e-b510-a631db41b0b8" },
                    { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "13b57834-34d1-4867-b90d-5b404e5d73b3" },
                    { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "daff4e48-4df0-4257-be42-356663c01791" },
                    { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "10e253ba-45b3-4207-93c7-7ffe5d5e6231" },
                    { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "8d0e370b-b39a-47f9-98e7-36a8e3cbf58c" },
                    { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "20168067-021d-4189-afe1-75199c8341bf" },
                    { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "1dbfd093-58a1-47da-ab05-d2b1353fd875" }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { 2, "Синій", new DateTimeOffset(new DateTime(2016, 7, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 754.7952f, "O 966 J", "YYBEDZYDDGLZ5C5GTP3C", "12ZUNNBYV5UH7SRUZ00C", "31d27b18-cbc2-44fc-b32b-3577eb75f788", "TUPLB91TI8FLBWZHQ" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { 3, "Сірий", new DateTimeOffset(new DateTime(2016, 7, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 826.4085f, "M 314 P", "4SDLAHSORRB8451B1W2M", "L1LHVVH9AOL8L9KSYOQC", "20168067-021d-4189-afe1-75199c8341bf", "OUZNUCOEN3FLZ27WQ" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { new DateTimeOffset(new DateTime(2016, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 567.86566f, "K 174 E", "3NVK9DC5PX1CQH705KW1", "HSZ9IL2YBD65LOVZZSF0", "c9166b2b-e0d6-418e-b510-a631db41b0b8", "QOXPGEIETYI1OBOL1" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { "Синій", new DateTimeOffset(new DateTime(2016, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 664.6267f, "V 404 T", "WR2L71D4VRJ2ABS4NFWJ", "7NJZKBDQSPV3DX1YESAD", "20168067-021d-4189-afe1-75199c8341bf", "MA58DA9INYXSJ8731" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { 2, "Синій", new DateTimeOffset(new DateTime(2016, 7, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 880.32245f, "I 236 W", "FOD9TQU5J4D09TCY3H92", "W6LESRBREQSIHEPJ00FS", "31d27b18-cbc2-44fc-b32b-3577eb75f788", "EO68X9OYJ622Z93YH" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { "Червоний", new DateTimeOffset(new DateTime(2016, 7, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 669.05554f, "T 827 I", "VJU3SX31H93RX8KT22G6", "MFEFGG1JCDP2LCAO35W0", "31d27b18-cbc2-44fc-b32b-3577eb75f788", "LTVH5QW9C0AMPF5EN" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { 3, "Синій", new DateTimeOffset(new DateTime(2016, 7, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 668.53033f, "S 186 O", "06KXVPW6FQHTLJYAAM30", "PRYNVJPIK3VFI9VALT0J", "31d27b18-cbc2-44fc-b32b-3577eb75f788", "VW7MKUO1LXL2T98W2" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { 4, "Білий", new DateTimeOffset(new DateTime(2016, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 480.18875f, "P 396 W", "2BBOOPGMJKWW2G8ZUTJI", "YUFFM2OROJ17J14A850B", "31d27b18-cbc2-44fc-b32b-3577eb75f788", "1HXC5GTC5K2TV8WW2" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { "Синій", new DateTimeOffset(new DateTime(2016, 7, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 666.96606f, "Y 113 N", "OC0CYRPT8DNSXH9W7YBE", "G5P5WEC3E9FD0Y9044VL", "31d27b18-cbc2-44fc-b32b-3577eb75f788", "UG8FYETOTQMM2JNVF" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { 3, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 829.5681f, "K 956 Y", "9RY89S33PYPA9WGFXAPG", "OREWQC9OB6UCWIYOZ6KW", "31d27b18-cbc2-44fc-b32b-3577eb75f788", "WOD8DYZ3GBOH9ID2H" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Gourde Incredible Fresh Gloves array calculating Street Singapore Dollar HTTP Extension Afghanistan Streets neural neural-net JBOD Hungary Awesome.", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 298.87082f, "1dbfd093-58a1-47da-ab05-d2b1353fd875", new DateTimeOffset(new DateTime(2022, 7, 4, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "panel haptic Principal Executive Frozen European Unit of Account 9(E.U.A.-9) Licensed transparent EXE Assimilated Multi-channelled bus Ports Global Technician Solutions Data optical.", new DateTimeOffset(new DateTime(2022, 7, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 610.60175f, "20168067-021d-4189-afe1-75199c8341bf", new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Licensed Granite Chips parse Dynamic drive Dam full-range Associate Cloned Cove Cambridgeshire Yemeni Rial zero administration Bedfordshire North Carolina mindshare Credit Card Account deposit Branding Awesome Steel Shoes Illinois Borders Japan Money Market Account payment Central.", new DateTimeOffset(new DateTime(2022, 7, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 264.0763f, "10e253ba-45b3-4207-93c7-7ffe5d5e6231", new DateTimeOffset(new DateTime(2022, 7, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ExpirationDate", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Zloty array firewall Pennsylvania Direct View bypassing Administrator Meadow Investment Account Awesome Plastic Chair Tanzanian Shilling Practical Rubber Salad experiences transform transparent optical panel Quality.", new DateTimeOffset(new DateTime(2022, 7, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 714.2937f, "13b57834-34d1-4867-b90d-5b404e5d73b3", new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "payment Garden platforms scale invoice scalable red New Leu Oregon panel Overpass sensor Berkshire hacking Interactions.", new DateTimeOffset(new DateTime(2022, 7, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 773.28125f, "daff4e48-4df0-4257-be42-356663c01791", new DateTimeOffset(new DateTime(2022, 7, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Handcrafted Concrete Shoes Intelligent neural connecting Kenyan Shilling architect moratorium Steel Plastic Auto Loan Account Gorgeous Concrete Bacon hack Valleys responsive standardization Austria Ohio Guadeloupe International Auto Loan Account Handmade Rubber Chicken Avon Refined Steel Computer Intelligent Rubber Salad didactic Radial.", new DateTimeOffset(new DateTime(2022, 7, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 216.15291f, "8d0e370b-b39a-47f9-98e7-36a8e3cbf58c", new DateTimeOffset(new DateTime(2022, 7, 5, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ExpirationDate", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "bandwidth-monitored architectures navigate Implementation Customer-focused Forest Handcrafted Cambridgeshire River Public-key help-desk Investment Account transitional homogeneous Balboa Progressive Electronics, Industrial & Baby encryption program Shoes & Sports Industrial & Shoes Licensed fuchsia navigating.", new DateTimeOffset(new DateTime(2022, 7, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 810.46497f, "8d0e370b-b39a-47f9-98e7-36a8e3cbf58c", new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Borders USB yellow Berkshire purple supply-chains Grove Refined Rubber Bike Indiana alarm backing up digital Knoll Borders Baby & Jewelery Serbia SDD open-source El Salvador.", new DateTimeOffset(new DateTime(2022, 7, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 874.9119f, "daff4e48-4df0-4257-be42-356663c01791", new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Investment Account Incredible Fresh Fish synthesizing parsing Movies & Books Connecticut Facilitator invoice zero defect Berkshire enterprise Buckinghamshire Gorgeous Cotton Cheese Nicaragua overriding Security auxiliary Armenian Dram Rustic Soft Fish Forge internet solution connecting card Nigeria Branding.", new DateTimeOffset(new DateTime(2022, 7, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 995.6542f, "8d0e370b-b39a-47f9-98e7-36a8e3cbf58c", new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Vision-oriented initiatives e-business TCP Checking Account User-centric seamless Money Market Account Mandatory Investment Account HTTP Customer-focused black attitude-oriented transmit Lakes Pines Oklahoma Industrial productize Bouvet Island (Bouvetoya).", new DateTimeOffset(new DateTime(2022, 7, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 223.30197f, "8d0e370b-b39a-47f9-98e7-36a8e3cbf58c", new DateTimeOffset(new DateTime(2022, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Industrial & Electronics Savings Account copy Brand PNG stable Buckinghamshire Saint Kitts and Nevis Unbranded budgetary management Fort Isle Metrics XML Kroon driver capacitor Forge Tactics Mobility Frozen Bedfordshire Extended system gold.", new DateTimeOffset(new DateTime(2022, 7, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 974.25104f, "c9166b2b-e0d6-418e-b510-a631db41b0b8", new DateTimeOffset(new DateTime(2022, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "didactic index Islands deposit asynchronous Maryland regional matrix Alabama South Carolina bottom-line withdrawal Greens compressing Organized calculating firewall Barbados Dollar Incredible Metal Towels back-end Officer green Program Open-architected SCSI.", new DateTimeOffset(new DateTime(2022, 7, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 659.79156f, "20168067-021d-4189-afe1-75199c8341bf", new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Sleek Cotton Cheese deposit bluetooth bypass invoice Future-proofed Strategist Rustic Avon seize auxiliary feed Executive auxiliary Lock Money Market Account Argentina portals throughput synergize Tasty Rubber Fish payment invoice web services Practical Rubber Bacon Iraqi Dinar Tasty Concrete Fish calculating Bedfordshire Refined Fresh Sausages.", new DateTimeOffset(new DateTime(2022, 7, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 555.0828f, "1dbfd093-58a1-47da-ab05-d2b1353fd875", new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "indexing Grocery e-business Credit Card Account circuit feed proactive firmware payment Lane Berkshire South Carolina Leone whiteboard.", new DateTimeOffset(new DateTime(2022, 7, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 83.765976f, "20168067-021d-4189-afe1-75199c8341bf", new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Tasty Fresh Gloves Research programming Games Mission relationships backing up unleash embrace Bedfordshire feed Cambridgeshire North Dakota partnerships Sleek Concrete revolutionize maximize middleware architectures payment Fresh intermediate transmit Streamlined Buckinghamshire Road Generic Bedfordshire.", new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 278.80975f, "13b57834-34d1-4867-b90d-5b404e5d73b3", new DateTimeOffset(new DateTime(2022, 7, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Rustic Steel Tuna connect synthesize Intranet salmon Credit Card Account Kids, Outdoors & Computers Baby & Baby monitor Rustic Plastic Keyboard Branding Albania Bosnia and Herzegovina users Practical Cotton Fish Generic Frozen.", new DateTimeOffset(new DateTime(2022, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 75.44399f, "daff4e48-4df0-4257-be42-356663c01791", new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "bypass Health & Home THX best-of-breed Alabama Dynamic Colorado New York Granite functionalities database Awesome Soft Chicken methodology.", new DateTimeOffset(new DateTime(2022, 7, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 80.69869f, "10e253ba-45b3-4207-93c7-7ffe5d5e6231", new DateTimeOffset(new DateTime(2022, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Personal Loan Account Bedfordshire backing up interface Savings Account intangible capacitor Money Market Account Saint Kitts and Nevis SAS index Optimization Function-based card primary experiences payment Assurance deposit.", new DateTimeOffset(new DateTime(2022, 7, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 550.6944f, "10e253ba-45b3-4207-93c7-7ffe5d5e6231", new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Rubber withdrawal Ireland program Handcrafted lavender Associate French Polynesia Producer South Dakota user-centric Small Investor concept Movies, Books & Baby Brand bypass Future payment Awesome Frozen Cheese synthesize.", new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 164.2255f, "20168067-021d-4189-afe1-75199c8341bf", new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Expanded Borders Tuvalu Awesome compressing deposit analyzer Producer Centralized Turnpike Gorgeous Plastic Keyboard bifurcated Marketing Practical Soft Chair Rustic Metal Bacon Graphical User Interface harness Colorado orange matrices.", new DateTimeOffset(new DateTime(2022, 7, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 486.2273f, "c9166b2b-e0d6-418e-b510-a631db41b0b8", new DateTimeOffset(new DateTime(2022, 7, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30b0d58d-895a-4583-b4d2-db9be0474cc7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c06deee3-2fa3-4aa8-b242-fb65c737e622");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "10e253ba-45b3-4207-93c7-7ffe5d5e6231" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "13b57834-34d1-4867-b90d-5b404e5d73b3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "1dbfd093-58a1-47da-ab05-d2b1353fd875" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "20168067-021d-4189-afe1-75199c8341bf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "31d27b18-cbc2-44fc-b32b-3577eb75f788" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "8d0e370b-b39a-47f9-98e7-36a8e3cbf58c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "c9166b2b-e0d6-418e-b510-a631db41b0b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6", "daff4e48-4df0-4257-be42-356663c01791" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c44f6cb-557d-4da3-b51b-0ae7dd13a6e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e253ba-45b3-4207-93c7-7ffe5d5e6231");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13b57834-34d1-4867-b90d-5b404e5d73b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1dbfd093-58a1-47da-ab05-d2b1353fd875");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20168067-021d-4189-afe1-75199c8341bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31d27b18-cbc2-44fc-b32b-3577eb75f788");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d0e370b-b39a-47f9-98e7-36a8e3cbf58c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9166b2b-e0d6-418e-b510-a631db41b0b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "daff4e48-4df0-4257-be42-356663c01791");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "User", "USER" },
                    { "0af11548-2ad9-452b-82d3-008f6ec7bbbc", "0af11548-2ad9-452b-82d3-008f6ec7bbbc", "Admin", "ADMIN" },
                    { "103c5f41-8d61-4fe3-b97e-9e683c666ea3", "103c5f41-8d61-4fe3-b97e-9e683c666ea3", "Logist", "LOGIST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e7a5c59a-b887-4043-bd3d-71b57733b5aa", 0, "f296b83c-7dbd-4dc9-902c-cb4c0db2fc4c", "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEChq9vg2lx2bK57HBw5o3JxDORmpuFEaYXWKY7VYrNRl+YObdZApdJ5DcQP8S3BRQg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(4435), new TimeSpan(0, 0, 0, 0, 0)), "4d6a94ef-6d6a-4954-9a9f-02fcc5e20fb8", "Chorrny", false, "chorrny228@gmail.com" },
                    { "8b605fbc-b858-4225-8458-aa9715844640", 0, "e168cea8-5413-4199-899d-0cbe6652471a", "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEJ4NqdZjvoGntsU42/512QSu58SWo1bgc0GmK3cLgeuVC1nHetdz6/6Lz+bt+0Ageg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(5627), new TimeSpan(0, 0, 0, 0, 0)), "cd880d2c-e349-4444-bfd0-73523394cdb0", "Sevastyanov", false, "oppaiarchmaster@gmail.com" },
                    { "a4ffba1f-2bad-451a-9ad3-a8e35f1b989f", 0, "1d3bef42-6fc1-4f81-8468-3c49a1010067", "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAECeci6a6UsJGxnKhbiuNDb4XBQhpbDdjhPdaELzMmWM+LXIaIFeM2LJ3EFcT8faxjQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(5680), new TimeSpan(0, 0, 0, 0, 0)), "2d86e35f-e432-4975-bce1-b3339b6b9dc7", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "8c17e1ba-57da-4b33-9559-badad2641fc3", 0, "32f29126-6f0e-4cd9-8847-9797ddfaad29", "User", "marynakernychna@gmail.com", true, false, null, "Maryna", "MARYNAKERNYCHNA@GMAIL.COM", "MARYNAKERNYCHNA@GMAIL.COM", "AQAAAAEAACcQAAAAEI1F66xS4lGwk1VhvFO6IvCSLCKO4JyhROVI7jgVITqf3LjU6qxl1zXW8959MPtjJw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(5690), new TimeSpan(0, 0, 0, 0, 0)), "b1d03fa9-2e05-46e5-b5e8-cde3a31cdd10", "Kernychna", false, "marynakernychna@gmail.com" },
                    { "762dd1e0-f2bb-4baa-8f2c-82d6d480df29", 0, "af517b83-d897-44e0-8ed0-1456f71d142d", "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEGfZdYx9MfOJbdY3G0J7+hBfdvRDlbVSh795FbygHhs+u2or02H3s7YOLC/0r/9P1Q==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(5700), new TimeSpan(0, 0, 0, 0, 0)), "ed22e9f8-4710-43fd-b1c8-966ce6e19782", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "875c647c-6b1a-468c-97c5-294de8507eb3", 0, "aa28b311-d2e0-4a40-bce0-7c677898ac49", "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAECtncuy6W+xCqBdl6E3jBbssjTjTbFyBO6ia72+vUZp/l/vztez37dyrlpcDFh8rEQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(5712), new TimeSpan(0, 0, 0, 0, 0)), "d12ee6b3-2fe7-48b7-9304-9f1cabdf8a1b", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "944e6c2f-7692-4c93-9a9c-81c30905a158", 0, "80d0e30a-7c89-468c-ba1e-d6a65d34c9f9", "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAELJahAF+HA3XGUVks0e1fOkLrn6+Oc5sYP4GLSNZlv5S9v45Pm2AjbORaq+Hs4s7bw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(5722), new TimeSpan(0, 0, 0, 0, 0)), "32904fce-068d-4e1e-be0a-b8dd581a3efc", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "50662ecc-f177-41fb-95b7-5ba272c2a4ce", 0, "531076e1-c2dc-4b87-bd9f-f744c6543d07", "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAECXwn6gQIXfDihQR4kgSFH7tiGbTQI6Ie0wd1KI4T0kJtCz3uNstghOyotJx/j4iRg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 0, 0, 0, 0)), "866d6435-e8dc-465c-aab2-d98562eed5e6", "Eremenko", false, "sergeyeremenko@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "50662ecc-f177-41fb-95b7-5ba272c2a4ce" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "a4ffba1f-2bad-451a-9ad3-a8e35f1b989f" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "944e6c2f-7692-4c93-9a9c-81c30905a158" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "8c17e1ba-57da-4b33-9559-badad2641fc3" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "875c647c-6b1a-468c-97c5-294de8507eb3" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "8b605fbc-b858-4225-8458-aa9715844640" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "e7a5c59a-b887-4043-bd3d-71b57733b5aa" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "762dd1e0-f2bb-4baa-8f2c-82d6d480df29" }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { 4, "Червоний", new DateTimeOffset(new DateTime(2016, 7, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 824.4033f, "S 731 D", "4STOEF723EE7XBONP8OC", "O2DCWYTFPKEAF5GAHK1K", "50662ecc-f177-41fb-95b7-5ba272c2a4ce", "728D5F4WOH1CG1FHS" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { 2, "Чорний", new DateTimeOffset(new DateTime(2016, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 738.7338f, "J 573 Z", "4SRUE6474NMVB3ITDASV", "X82PFV0SLXWOO24LDKQQ", "e7a5c59a-b887-4043-bd3d-71b57733b5aa", "WPT63D9M9IKN1VP2F" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { new DateTimeOffset(new DateTime(2016, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 676.8f, "Q 262 T", "Y68ZXGSK2BOCCV9RMJYO", "E3108VA56K8MQYUZVEB6", "a4ffba1f-2bad-451a-9ad3-a8e35f1b989f", "ICDJD76SJSNHCV58Q" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { "Сірий", new DateTimeOffset(new DateTime(2016, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 589.31256f, "J 548 B", "1LE09V87S8FLPMOI3ZE0", "GZ8MZUNN80TK09CXZ6WW", "e7a5c59a-b887-4043-bd3d-71b57733b5aa", "V9W9GL2K2OZHL2DR0" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { 4, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 499.50977f, "Z 785 K", "VKFARIW2HPW3YPPE1LOY", "5KJNAK76HNQL4U1P0AB1", "50662ecc-f177-41fb-95b7-5ba272c2a4ce", "IRPYE2A06ZBS9A1R0" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { "Зелений", new DateTimeOffset(new DateTime(2016, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 664.8034f, "O 841 Z", "BY3O0DRAMSJ2RYB55VHG", "RABLRN9A4QF0OSE0AEAM", "50662ecc-f177-41fb-95b7-5ba272c2a4ce", "O0P7ASO06U3C71NIW" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { 2, "Чорний", new DateTimeOffset(new DateTime(2016, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 650.53705f, "E 903 J", "IEYKBVRLU12LAVJDGL3K", "LXBLCCSHWIZISN7TB8D5", "50662ecc-f177-41fb-95b7-5ba272c2a4ce", "8B4GCMC0NU2CRL2D7" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { 2, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 643.97003f, "R 393 B", "JSNOQ288Y4BO0GW054WV", "4GGWLQX0E25LXALNPXMY", "50662ecc-f177-41fb-95b7-5ba272c2a4ce", "47FW2WBYX5RGW2CQ2" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { "Зелений", new DateTimeOffset(new DateTime(2016, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 832.46014f, "V 896 Z", "PRPV9A7IYGIC9GPN1PG4", "ZUGDIAYVLT6T87P4C11N", "50662ecc-f177-41fb-95b7-5ba272c2a4ce", "SZEQ2ADC3JCR0VACC" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Color", "CreationDate", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[] { 2, "Жовтий", new DateTimeOffset(new DateTime(2016, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 464.95175f, "X 217 H", "P32QKBZNSEC1HZR7OH9Q", "NGH7TU0P3BDROPPM0JS1", "50662ecc-f177-41fb-95b7-5ba272c2a4ce", "KCNUTDKQNUNDN8MUW" });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "collaborative compress Spur hard drive Tunnel copying multi-byte Soft Hill Shores Libyan Arab Jamahiriya Human payment engineer Home & Jewelery bypassing process improvement calculate Electronics & Shoes Moroccan Dirham Small Rubber Pants Data Heights Papua New Guinea revolutionize Kids, Automotive & Tools Global Intranet.", new DateTimeOffset(new DateTime(2022, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 18.269161f, "762dd1e0-f2bb-4baa-8f2c-82d6d480df29", new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "next-generation Shores redundant multi-byte Lead overriding silver budgetary management Lithuanian Litas bus Electronics composite reboot Awesome Fresh Computer Auto Loan Account Cambridgeshire Brazilian Real Checking Account Cliff Tools, Movies & Home pixel array Kids, Music & Outdoors Proactive knowledge user Sleek Soft Car Unbranded Concrete Shirt matrix Checking Account.", new DateTimeOffset(new DateTime(2022, 7, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 61.76999f, "e7a5c59a-b887-4043-bd3d-71b57733b5aa", new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "azure Garden fuchsia ability hard drive protocol primary Executive website Applications programming Music & Garden Specialist Bedfordshire Corporate hacking Checking Account violet SSL Savings Account deposit Optional Visionary Antigua and Barbuda Avon Incredible Plastic Chair.", new DateTimeOffset(new DateTime(2022, 7, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 16.921375f, "875c647c-6b1a-468c-97c5-294de8507eb3", new DateTimeOffset(new DateTime(2022, 7, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ExpirationDate", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Ranch Falls withdrawal Factors RAM bus Fords PCI Connecticut Assistant Stream JBOD San Marino Checking Account Bedfordshire Baby & Clothing Multi-lateral withdrawal Nevada Colorado Personal Loan Account.", new DateTimeOffset(new DateTime(2022, 7, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 425.77927f, "944e6c2f-7692-4c93-9a9c-81c30905a158", new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "circuit Ergonomic Rubber Cheese Ranch Forward Division Checking Account eyeballs TCP mindshare salmon Forge concept Movies & Books IB Rubber hierarchy Borders Credit Card Account Handcrafted Metal Fish Credit Card Account Consultant Outdoors input.", new DateTimeOffset(new DateTime(2022, 7, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 628.3656f, "8c17e1ba-57da-4b33-9559-badad2641fc3", new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "back up Trail Security alliance mobile port scale payment International Credit Card Account Enhanced Texas Wooden Granite Wooden Sports & Electronics TCP Licensed.", new DateTimeOffset(new DateTime(2022, 7, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 795.2876f, "8b605fbc-b858-4225-8458-aa9715844640", new DateTimeOffset(new DateTime(2022, 7, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ExpirationDate", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Money Market Account Representative Dynamic copy Wooden Montana input parsing programming invoice violet Refined Metal Table Unbranded Wooden Gloves definition Inlet Russian Federation Awesome Concrete Sausages demand-driven Aruban Guilder dot-com.", new DateTimeOffset(new DateTime(2022, 7, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 323.01862f, "8b605fbc-b858-4225-8458-aa9715844640", new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Plastic teal Plastic Avon overriding programming 6th generation communities Soft needs-based feed International Granite Rustic Wooden Sausages San Marino well-modulated.", new DateTimeOffset(new DateTime(2022, 7, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 310.41092f, "8c17e1ba-57da-4b33-9559-badad2641fc3", new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "AI Unbranded Small Granite Sausages optical open-source front-end Isle Avon Savings Account compelling Dynamic Generic Plastic Fish customized Spur Sports, Home & Sports mobile Buckinghamshire orange Handmade Turkmenistan exploit invoice Knoll Cotton Global.", new DateTimeOffset(new DateTime(2022, 7, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 395.407f, "8b605fbc-b858-4225-8458-aa9715844640", new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "24 hour Integrated panel Norway Wooden platforms Auto Loan Account Operations capacitor SMTP Ergonomic Cotton Salad West Virginia online Administrator matrix withdrawal calculating instruction set payment Wooden global Euro next generation Haven neural transmitting hacking Money Market Account.", new DateTimeOffset(new DateTime(2022, 7, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 847.3365f, "8b605fbc-b858-4225-8458-aa9715844640", new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Mews Versatile Diverse black Awesome Fresh Cheese Concrete neural-net Small payment Marketing quantify deposit Technician FTP Sleek invoice real-time Handmade Concrete Computer.", new DateTimeOffset(new DateTime(2022, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 609.37854f, "a4ffba1f-2bad-451a-9ad3-a8e35f1b989f", new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Rubber Plastic Small Steel Shoes object-oriented Money Market Account Intelligent Granite Shirt indexing partnerships upward-trending Netherlands Antilles wireless American Samoa supply-chains Prairie local RAM back up Kids & Tools Supervisor vortals.", new DateTimeOffset(new DateTime(2022, 7, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 58.465134f, "e7a5c59a-b887-4043-bd3d-71b57733b5aa", new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "demand-driven red Cambridgeshire human-resource Small Soft Ball Solutions Hill systems connect Optimization programming Bedfordshire USB Personal Loan Account multimedia Curve Specialist deposit asynchronous parse.", new DateTimeOffset(new DateTime(2022, 7, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 568.51733f, "762dd1e0-f2bb-4baa-8f2c-82d6d480df29", new DateTimeOffset(new DateTime(2022, 7, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Radial Avon interfaces index interactive analyzing Taiwan Licensed Handcrafted Soft Chair multi-state viral Solomon Islands Dollar Representative Portugal monitor Garden Gorgeous Soft Soap plum Team-oriented.", new DateTimeOffset(new DateTime(2022, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 395.20547f, "e7a5c59a-b887-4043-bd3d-71b57733b5aa", new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Center Generic Cotton Mouse National Cotton Malaysian Ringgit programming South Dakota New York Stand-alone parsing Nebraska Secured ROI cross-platform withdrawal Central Branding Bermudian Dollar (customarily known as Bermuda Dollar) Music.", new DateTimeOffset(new DateTime(2022, 7, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 930.12854f, "944e6c2f-7692-4c93-9a9c-81c30905a158", new DateTimeOffset(new DateTime(2022, 7, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "calculating Isle Kids Mill Iraq Auto Loan Account payment feed national productize Direct Plains Handcrafted Fresh Gloves proactive Managed content Unbranded Plastic Table Auto Loan Account strategic Handcrafted Cotton Ball Berkshire Operations pink Supervisor Investor Outdoors, Toys & Clothing capacity Bedfordshire maroon Object-based.", new DateTimeOffset(new DateTime(2022, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 810.4967f, "8c17e1ba-57da-4b33-9559-badad2641fc3", new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Mobility Synergistic Open-source engineer programming Islands Ireland Global Arkansas Steel Developer Bedfordshire Future RAM Cotton heuristic initiatives Euro Albania mission-critical Tactics Money Market Account back up Bahraini Dinar Internal.", new DateTimeOffset(new DateTime(2022, 7, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 297.76202f, "875c647c-6b1a-468c-97c5-294de8507eb3", new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Tasty Technician Progressive Borders Representative out-of-the-box deposit Oklahoma Direct deposit maroon EXE open-source actuating adapter.", new DateTimeOffset(new DateTime(2022, 7, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 864.35956f, "875c647c-6b1a-468c-97c5-294de8507eb3", new DateTimeOffset(new DateTime(2022, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Ohio deposit Manat Fantastic 24/7 synthesizing hybrid Corners blue Burundi Franc e-business Tools & Home Executive Product payment Greenland strategize.", new DateTimeOffset(new DateTime(2022, 7, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 981.36743f, "e7a5c59a-b887-4043-bd3d-71b57733b5aa", new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "OfferCreatorId", "StartDate" },
                values: new object[] { "Architect adapter Israel 24/7 Legacy Usability payment radical revolutionize Architect Awesome Concrete Ball Research Home Circles data-warehouse Alley Security hierarchy payment.", new DateTimeOffset(new DateTime(2022, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 77.20522f, "a4ffba1f-2bad-451a-9ad3-a8e35f1b989f", new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) });
        }
    }
}
