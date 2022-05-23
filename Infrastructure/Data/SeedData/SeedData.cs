using Bogus;
using Core.Entities.CarCategoryEntity;
using Core.Entities.CarEntity;
using Core.Entities.GoodCategoryEntity;
using Core.Entities.OfferEntity;
using Core.Entities.PointEntity;
using Core.Entities.RoleEntity;
using Core.Entities.UserEntity;
using Core.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Data.SeedData
{

    public static class SeedData
    {
        #region Users

        private static readonly string VADIM_ID = Guid.NewGuid().ToString();
        private static readonly string VLAD_ID = Guid.NewGuid().ToString();
        private static readonly string ANDREW_ID = Guid.NewGuid().ToString();
        private static readonly string MARYNA_ID = Guid.NewGuid().ToString();
        private static readonly string EUGEN_ID = Guid.NewGuid().ToString();
        private static readonly string VOLODYA_ID = Guid.NewGuid().ToString();
        private static readonly string ANTONINA_ID = Guid.NewGuid().ToString();
        private static readonly string SERGEY_ID = Guid.NewGuid().ToString();

        #endregion

        #region Roles

        private static readonly string ROLE_USER_ID = Guid.NewGuid().ToString();
        private static readonly string ROLE_ADMIN_ID = Guid.NewGuid().ToString();
        private static readonly string ROLE_LOGIST_ID = Guid.NewGuid().ToString();

        #endregion

        private static readonly string[] _colors = new[] 
            {"Червоний","Чорний","Білий","Сірий","Зелений","Синій","Жовтий"};
        private static readonly PasswordHasher<User> _passwordHasher = new PasswordHasher<User>();
        private static readonly Faker _faker = new Faker();
        private static readonly float _maxWeight = 1000f;

        public static void Seed(this ModelBuilder builder)
        {
            SeedRole(builder);
            SeedIdentityRole(builder);
            SeedGoodCategory(builder);
            SeedCarCategory(builder);
            SeedUser(builder);
            SeedIdentityUserRole(builder);
            SeedPoint(builder);
            SeedOffer(builder);
            SeedCar(builder);
        }

        #region SeedUser

        public static void SeedUser(ModelBuilder builder)
        {
            var userVadim = new User()
            {
                Id = VADIM_ID,
                Name = "Vadym",
                Surname = "Chorrny",
                UserName = "chorrny228@gmail.com",
                NormalizedEmail = "chorrny228@gmail.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "chorrny228@gmail.com".ToUpper(),
                Email = "chorrny228@gmail.com"
            };
            var userVlad = new User()
            {
                Id = VLAD_ID,
                Name = "Vlad",
                Surname = "Sievostyanov",
                UserName = "oppaiarchmaster@gmail.com",
                NormalizedEmail = "oppaiarchmaster@gmail.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "oppaiarchmaster@gmail.com".ToUpper(),
                Email = "oppaiarchmaster@gmail.com"
            };
            var userAndrew = new User()
            {
                Id = ANDREW_ID,
                Name = "Andrii",
                Surname = "Chepeliuk",
                UserName = "andrewchepeliuk@gmail.com",
                NormalizedEmail = "andrewchepeliuk@gmail.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "andrewchepeliuk@gmail.com".ToUpper(),
                Email = "andrewchepeliuk@gmail.com"
            };
            var userMaryna = new User()
            {
                Id = MARYNA_ID,
                Name = "Maryna",
                Surname = "Kernychna",
                UserName = "marynakernychna@gmail.com",
                NormalizedEmail = "marynakernychna@gmail.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "marynakernychna@gmail.com".ToUpper(),
                Email = "marynakernychna@gmail.com"
            };
            var userEugen = new User()
            {
                Id = EUGEN_ID,
                Name = "Eugen",
                Surname = "Pasichnyk",
                UserName = "yevhen.pasichnyk@oa.edu.ua",
                NormalizedEmail = "yevhen.pasichnyk@oa.edu.ua".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "yevhen.pasichnyk@oa.edu.ua".ToUpper(),
                Email = "yevhen.pasichnyk@oa.edu.ua"
            };
            var userVolodya = new User()
            {
                Id = VOLODYA_ID,
                Name = "Volodya",
                Surname = "Pashunskyi",
                UserName = "pashunskyi@gmail.com",
                NormalizedEmail = "pashunskyi@gmail.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "pashunskyi@gmail.com".ToUpper(),
                Email = "pashunskyi@gmail.com"
            };
            var userAntonina = new User()
            {
                Id = ANTONINA_ID,
                Name = "Antonina",
                Surname = "Loboda",
                UserName = "antonina.loboda@oa.edu.ua",
                NormalizedEmail = "antonina.loboda@oa.edu.ua".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "antonina.loboda@oa.edu.ua".ToUpper(),
                Email = "antonina.loboda@oa.edu.ua"
            };
            var userSergey = new User()
            {
                Id = SERGEY_ID,
                Name = "Sergey",
                Surname = "Eremenko",
                UserName = "sergeyeremenko@gmail.com",
                NormalizedEmail = "sergeyeremenko@gmail.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "sergeyeremenko@gmail.com".ToUpper(),
                Email = "sergeyeremenko@gmail.com"
            };
            userVadim.PasswordHash = _passwordHasher
                .HashPassword(userVadim, "Password_1");
            userVlad.PasswordHash = _passwordHasher
                .HashPassword(userVlad, "Password_1");
            userAndrew.PasswordHash = _passwordHasher
                .HashPassword(userAndrew, "Password_1");
            userMaryna.PasswordHash = _passwordHasher
                .HashPassword(userMaryna, "Password_1");
            userEugen.PasswordHash = _passwordHasher
                .HashPassword(userEugen, "Password_1");
            userVolodya.PasswordHash = _passwordHasher
                .HashPassword(userVolodya, "Password_1");
            userAntonina.PasswordHash = _passwordHasher
                .HashPassword(userAntonina, "Password_1");
            userSergey.PasswordHash = _passwordHasher
                .HashPassword(userSergey, "Password_1");
            builder.Entity<User>()
                .HasData(
                    userVadim,
                    userVlad,
                    userAndrew,
                    userMaryna,
                    userEugen,
                    userVolodya,
                    userAntonina,
                    userSergey
                    );
        }

        #endregion

        #region SeedIdentityRole

        public static void SeedIdentityRole(ModelBuilder builder) =>
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = ROLE_USER_ID,
                    Name = IdentityRoleNames.User,
                    NormalizedName = IdentityRoleNames.User.ToUpper(),
                    ConcurrencyStamp = ROLE_USER_ID
                },
                new IdentityRole()
                {
                    Id = ROLE_ADMIN_ID,
                    Name = IdentityRoleNames.Admin,
                    NormalizedName = IdentityRoleNames.Admin.ToUpper(),
                    ConcurrencyStamp = ROLE_ADMIN_ID
                },
                new IdentityRole()
                {
                    Id = ROLE_LOGIST_ID,
                    Name = IdentityRoleNames.Logist,
                    NormalizedName = IdentityRoleNames.Logist.ToUpper(),
                    ConcurrencyStamp = ROLE_LOGIST_ID
                });

        #endregion

        #region SeedIdentityUserRole

        public static void SeedIdentityUserRole(ModelBuilder builder) =>
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = VADIM_ID
                }, new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = VLAD_ID
                }, new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = VOLODYA_ID
                }, new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = MARYNA_ID
                }, new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = ANTONINA_ID
                }, new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = ANDREW_ID
                }, new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = EUGEN_ID
                }, new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = SERGEY_ID
                });

        #endregion

        #region SeedRole

        public static void SeedRole(ModelBuilder builder) =>
            builder.Entity<OfferRole>().HasData(
                new OfferRole()
                {
                    Id = 1,
                    Name = OfferRoles.Sender
                },
                new OfferRole()
                {
                    Id = 2,
                    Name = OfferRoles.Recipient
                });

        #endregion

        #region MyRegion

        public static void SeedGoodCategory(ModelBuilder builder) =>
            builder.Entity<GoodCategory>().HasData(
                new GoodCategory()
                {
                    Id = 1,
                    Name = "FOOD"
                },
                new GoodCategory()
                {
                    Id = 2,
                    Name = "DRINKS"
                }, new GoodCategory()
                {
                    Id = 3,
                    Name = "CLOTHING"
                }, new GoodCategory()
                {
                    Id = 4,
                    Name = "FOOTWEAR"
                }, new GoodCategory()
                {
                    Id = 5,
                    Name = "HYGIENE PRODUCTS"
                }, new GoodCategory()
                {
                    Id = 6,
                    Name = "CAMOUFLAGE"
                }, new GoodCategory()
                {
                    Id = 7,
                    Name = "MEDICINES"
                });

        #endregion

        #region SeedCarCategory

        public static void SeedCarCategory(ModelBuilder builder) =>
            builder.Entity<CarCategory>().HasData(
                new CarCategory()
                {
                    Id = 1,
                    Name = CarCategories.A
                },
                new CarCategory()
                {
                    Id = 2,
                    Name = CarCategories.B
                },
                new CarCategory()
                {
                    Id = 3,
                    Name = CarCategories.C
                },
                new CarCategory()
                {
                    Id = 4,
                    Name = CarCategories.D
                });

        #endregion

        #region SeedPoint

        public static void SeedPoint(ModelBuilder builder) =>
           builder.Entity<Point>().HasData(
               new Point()
               {
                   Id = 1,
                   Longitude = 26.527293,
                   Latitude = 50.328792,
                   Address = "місто Острог, Рівненська область, вулиця Східна",
                   Settlement = "Острог",
                   Region = "Рівненська область",
                   Order = 0
               },
               new Point()
               {
                   Id = 2,
                   Longitude = 26.257569,
                   Latitude = 50.663542,
                   Address = "місто Шпанів, Рівненська область, вулиця Вереснева",
                   Settlement = "Шпанів",
                   Region = " Рівненська область",
                   Order = 0
               },
               new Point()
               {
                   Id = 3,
                   Longitude = 25.386282,
                   Latitude = 50.723971,
                   Address = "місто Луцьк, Волинська область, вулиця Хрещата",
                   Settlement = "Луцьк",
                   Region = "Волинська область",
                   Order = 0
               },
               new Point()
               {
                   Id = 4,
                   Longitude = 35.0215734,
                   Latitude = 48.46232227,
                   Address = "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко",
                   Settlement = "Дніпро",
                   Region = "Дніпропетровська область",
                   Order = 0
               },
               new Point()
               {
                   Id = 5,
                   Longitude = 37.3148804,
                   Latitude = 47.20073235,
                   Address = "місто Нікольське, Донецька область, вулиця Пушкіна",
                   Settlement = "Нікольське",
                   Region = "Донецька область",
                   Order = 0
               },
               new Point()
               {
                   Id = 6,
                   Longitude = 36.801641,
                   Latitude = 47.779212,
                   Address = "Макаровка, Донецька область",
                   Settlement = "Макаровка",
                   Region = "Донецька область",
                   Order = 0
               },
               new Point()
               {
                   Id = 7,
                   Longitude = 35.660035,
                   Latitude = 49.672878,
                   Address = "Гаврилівка, Харківська область, вулиця Коцюбинського",
                   Settlement = "Дніпро",
                   Region = "Харківська область",
                   Order = 0
               },
               new Point()
               {
                   Id = 8,
                   Longitude = 35.513638,
                   Latitude = 49.371446,
                   Address = "Ульянівка, Харківська область",
                   Settlement = "Ульянівка",
                   Region = "Харківська область",
                   Order = 0
               },
               new Point()
               {
                   Id = 9,
                   Longitude = 36.980500,
                   Latitude = 48.633740,
                   Address = "Новодонецьк, Донецька область, вулиця Благовісна",
                   Settlement = "Новодонецьк",
                   Region = "Донецька область",
                   Order = 0
               },
               new Point()
               {
                   Id = 10,
                   Longitude = 35.018729,
                   Latitude = 48.460257,
                   Address = "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко",
                   Settlement = "Дніпро",
                   Region = "Дніпропетровська область",
                   Order = 0
               },
               new Point()
               {
                   Id = 11,
                   Longitude = 4.0253361,
                   Latitude = 49.8468949,
                   Address = "місто Львів, Львівська область, просп. Вячеслава Черновола, 11",
                   Settlement = "Львів",
                   Region = "Львівська область",
                   Order = 0
               },
               new Point()
               {
                   Id = 12,
                   Longitude = 22.317773,
                   Latitude = 48.610623,
                   Address = "місто Ужгород, Закарпатская область, вулиця Шишкіна, 1",
                   Settlement = "Ужгород",
                   Region = "Закарпатская область",
                   Order = 0
               },
               new Point()
               {
                   Id = 13,
                   Longitude = 26.703000,
                   Latitude = 48.784157,
                   Address = "Маків, Хмельницька  область, провулок Прорізний",
                   Settlement = "Маків",
                   Region = "Хмельницька  область",
                   Order = 0
               },
               new Point()
               {
                   Id = 14,
                   Longitude = 28.494244,
                   Latitude = 49.232585,
                   Address = "місто Вінниця, Вінницька область, вулиця Братславська",
                   Settlement = "Вінниця",
                   Region = "Вінницька область",
                   Order = 0
               },
               new Point()
               {
                   Id = 15,
                   Longitude = 32.00718275,
                   Latitude = 47.032940848,
                   Address = "місто Миколаїв, Миколаївська область, вулиця Слов'янська",
                   Settlement = "Миколаїв",
                   Region = "Миколаївська область",
                   Order = 0
               },
               new Point()
               {
                   Id = 16,
                   Longitude = 32.030367,
                   Latitude = 47.044604,
                   Address = "Центральний пайон, місто Миколаїв, Миколаївська область, вулиця Дачна",
                   Settlement = "Миколаїв",
                   Region = "Миколаївська область",
                   Order = 0
               },
               new Point()
               {
                   Id = 17,
                   Longitude = 32.158811,
                   Latitude = 48.061315,
                   Address = "Бобринець, Кіровоградська  область, вулиця Орджонікідзе",
                   Settlement = "Бобринець",
                   Region = "Кіровоградська  область",
                   Order = 0
               },
               new Point()
               {
                   Id = 18,
                   Longitude = 31.561633,
                   Latitude = 51.459840,
                   Address = "Горбово, Чернігівська область, 16311",
                   Settlement = "Горбово",
                   Region = "Чернігівська область",
                   Order = 0
               },
               new Point()
               {
                   Id = 19,
                   Longitude = 30.11449580,
                   Latitude = 49.807687087,
                   Address = "місто Біла церква, Київська область, вулиця Кірова",
                   Settlement = "Біла церква",
                   Region = "Київська область",
                   Order = 0
               },
               new Point()
               {
                   Id = 20,
                   Longitude = 28.649230,
                   Latitude = 50.259730,
                   Address = "місто Житомир, Житомирська область, Богунський район",
                   Settlement = "Житомир",
                   Region = "Житомирська область",
                   Order = 0
               });

        #endregion

        #region SeedOffer

        public static void SeedOffer(ModelBuilder builder) =>
            builder.Entity<Offer>().HasData(
                new Offer()
                {
                    Id = 1,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 1,
                    OfferCreatorId = EUGEN_ID,
                    CreatorRoleId = 1
                },
                new Offer()
                {
                    Id = 2,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 2,
                    OfferCreatorId = VADIM_ID,
                    CreatorRoleId = 1
                },
                new Offer()
                {
                    Id = 3,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 3,
                    OfferCreatorId = VOLODYA_ID,
                    CreatorRoleId = 1
                },
                new Offer()
                {
                    Id = 4,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 4,
                    OfferCreatorId = ANTONINA_ID,
                    CreatorRoleId =1
                },
                new Offer()
                {
                    Id = 5,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 5,
                    OfferCreatorId = MARYNA_ID,
                    CreatorRoleId = 2
                },
                new Offer()
                {
                    Id = 6,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 6,
                    OfferCreatorId = VLAD_ID,
                    CreatorRoleId = 2
                }
                ,
                new Offer()
                {
                    Id = 7,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 7,
                    OfferCreatorId = VLAD_ID,
                    CreatorRoleId = 2
                },
                new Offer()
                {
                    Id = 8,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 8,
                    OfferCreatorId = MARYNA_ID,
                    CreatorRoleId = 2
                },
                new Offer()
                {
                    Id = 9,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 9,
                    OfferCreatorId = VLAD_ID,
                    CreatorRoleId = 2
                },
                new Offer()
                {
                    Id = 10,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 10,
                    OfferCreatorId = VLAD_ID,
                    CreatorRoleId = 2
                }
                ,
                new Offer()
                {
                    Id = 11,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 11,
                    OfferCreatorId = ANDREW_ID,
                    CreatorRoleId = 1
                },
                new Offer()
                {
                    Id = 12,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 12,
                    OfferCreatorId = VADIM_ID,
                    CreatorRoleId = 1
                },
                new Offer()
                {
                    Id = 13,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 13,
                    OfferCreatorId = EUGEN_ID,
                    CreatorRoleId = 1
                },
                new Offer()
                {
                    Id = 14,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 14,
                    OfferCreatorId = VADIM_ID,
                    CreatorRoleId = 1
                },
                new Offer()
                {
                    Id = 15,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 15,
                    OfferCreatorId = ANTONINA_ID,
                    CreatorRoleId = 2
                },
                new Offer()
                {
                    Id = 16,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 16,
                    OfferCreatorId = MARYNA_ID,
                    CreatorRoleId = 2
                },
                new Offer()
                {
                    Id = 17,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 17,
                    OfferCreatorId = VOLODYA_ID,
                    CreatorRoleId = 2
                },
                new Offer()
                {
                    Id = 18,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 18,
                    OfferCreatorId = VOLODYA_ID,
                    CreatorRoleId = 2
                },
                new Offer()
                {
                    Id = 19,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 19,
                    OfferCreatorId = VADIM_ID,
                    CreatorRoleId = 1
                },
                new Offer()
                {
                    Id = 20,
                    Description = $"{_faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    ExpirationDate = DateTimeOffset.Parse($"{_faker.Random.Int(5, 10)}.07.2022 {_faker.Random.Int(12, 23)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 20,
                    OfferCreatorId = ANDREW_ID,
                    CreatorRoleId = 1
                });

        #endregion

        #region SeedCar

        public static void SeedCar(ModelBuilder builder) =>
           builder.Entity<Car>().HasData(
               new Car()
               {
                   Id = 1,
                   Model = $"{_faker.Random.Char('A', 'Z')} {_faker.Random.Int(100, 999)} {_faker.Random.Char('A', 'Z')}",
                   RegistrationNumber = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Float(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = SERGEY_ID
               },
               new Car()
               {
                   Id = 2,
                   Model = $"{_faker.Random.Char('A', 'Z')} {_faker.Random.Int(100, 999)} {_faker.Random.Char('A', 'Z')}",
                   RegistrationNumber = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Float(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = VADIM_ID
               },
               new Car()
               {
                   Id = 3,
                   Model = $"{_faker.Random.Char('A', 'Z')} {_faker.Random.Int(100, 999)} {_faker.Random.Char('A', 'Z')}",
                   RegistrationNumber = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Float(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = ANDREW_ID
               },
               new Car()
               {
                   Id = 4,
                   Model = $"{_faker.Random.Char('A', 'Z')} {_faker.Random.Int(100, 999)} {_faker.Random.Char('A', 'Z')}",
                   RegistrationNumber = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Float(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = VADIM_ID
               },
               new Car()
               {
                   Id = 5,
                   Model = $"{_faker.Random.Char('A', 'Z')} {_faker.Random.Int(100, 999)} {_faker.Random.Char('A', 'Z')}",
                   RegistrationNumber = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Float(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = SERGEY_ID
               },
               new Car()
               {
                   Id = 6,
                   Model = $"{_faker.Random.Char('A', 'Z')} {_faker.Random.Int(100, 999)} {_faker.Random.Char('A', 'Z')}",
                   RegistrationNumber = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Float(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = SERGEY_ID
               },
               new Car()
               {
                   Id = 7,
                   Model = $"{_faker.Random.Char('A', 'Z')} {_faker.Random.Int(100, 999)} {_faker.Random.Char('A', 'Z')}",
                   RegistrationNumber = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Float(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = SERGEY_ID
               },
               new Car()
               {
                   Id = 8,
                   Model = $"{_faker.Random.Char('A', 'Z')} {_faker.Random.Int(100, 999)} {_faker.Random.Char('A', 'Z')}",
                   RegistrationNumber = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Float(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = SERGEY_ID
               },
               new Car()
               {
                   Id = 9,
                   Model = $"{_faker.Random.Char('A', 'Z')} {_faker.Random.Int(100, 999)} {_faker.Random.Char('A', 'Z')}",
                   RegistrationNumber = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Float(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = SERGEY_ID
               },
               new Car()
               {
                   Id = 10,
                   Model = $"{_faker.Random.Char('A', 'Z')} {_faker.Random.Int(100, 999)} {_faker.Random.Char('A', 'Z')}",
                   RegistrationNumber = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Float(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = SERGEY_ID
               }

               );

        #endregion

    }
}
