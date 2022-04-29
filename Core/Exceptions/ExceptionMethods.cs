using System.Net;
using Core.Resources;
using Core.Entities.UserEntity;
using Core.Entities.CarEntity;
using Core.Entities.OfferEntity;
using Core.Entities.PointEntity;
using Core.Entities.CarCategoryEntity;
using Core.Entities.GoodCategoryEntity;
using Core.Entities.RatingEntity;
using Core.Entities.ReportEntity;
using Core.Entities.RoleEntity;

namespace Core.Exceptions
{
    public static class ExceptionMethods
    {
        public static void UserNullCheck(User user)
        {
            if (user == null)
            {
                throw new HttpException(
                    ErrorMessages.UserNotFound,
                    HttpStatusCode.NotFound);
            }
        }

        public static void CarNullCheck(Car car)
        {
            if (car == null)
            {
                throw new HttpException(
                    ErrorMessages.CarNotFound,
                    HttpStatusCode.NotFound);
            }
        }

        public static void OfferNullCheck(Offer offer)
        {
            if (offer == null)
            {
                throw new HttpException(
                    ErrorMessages.OfferNotFound,
                    HttpStatusCode.NotFound);
            }
        }

        public static void PointNullCheck(Point point)
        {
            if (point == null)
            {
                throw new HttpException(
                    ErrorMessages.PointNotFound,
                    HttpStatusCode.NotFound);
            }
        }

        public static void CarCategoryNullCheck(CarCategory carCategory)
        {
            if (carCategory == null)
            {
                throw new HttpException(
                    ErrorMessages.CarCategoryNotFound,
                    HttpStatusCode.NotFound);
            }
        }

        public static void GoodCategoryNullCheck(GoodCategory goodCategory)
        {
            if (goodCategory == null)
            {
                throw new HttpException(
                    ErrorMessages.GoodCategoryNotFound,
                    HttpStatusCode.NotFound);
            }
        }

        public static void RatingNullCheck(Rating rating)
        {
            if (rating == null)
            {
                throw new HttpException(
                    ErrorMessages.RatingNotFound,
                    HttpStatusCode.NotFound);
            }
        }

        public static void ReportNullCheck(Report report)
        {
            if (report == null)
            {
                throw new HttpException(
                    ErrorMessages.ReportNotFound,
                    HttpStatusCode.NotFound);
            }
        }

        public static void RoleNullCheck(Role role)
        {
            if (role == null)
            {
                throw new HttpException(
                    ErrorMessages.RoleNotFound,
                    HttpStatusCode.NotFound);
            }
        }
    }
}
