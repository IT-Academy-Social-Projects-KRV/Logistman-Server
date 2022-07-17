using System;

namespace Core.DTO.OfferDTO
{
    public class OfferPreviewForConfirmDTO
    {
        public int Id { get; set; }
        public string CreatorRoleName { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public string GoodCategoryName { get; set; }
        public string Description { get; set; }
        public bool IsClosed { get; set; }
        public bool IsConfirmedByCreator { get; set; }
        public bool IsAnsweredByCreator { get; set; }
        public bool IsAnsweredByDriver { get; set; }
        public float GoodsWeight { get; set; }
        public string Address { get; set; }
        public string Settlement { get; set; }
        public string Region { get; set; }
        public UserFullNameDTO DriverFullName { get; set; }
        public TripCarInfoDTO Car { get; set; }
    }
}
