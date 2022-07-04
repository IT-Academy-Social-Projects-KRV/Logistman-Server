using System.ComponentModel;

namespace Core.DTO.OfferDTO
{
    public class OfferCreateTripDTO
    {
        //The Key is Id. It is needed for the list on React
        public int Key { get; set; }
        public string CreationDate { get; set; }
        public float GoodsWeight { get; set; }
        public string GoodCategoryName { get; set; }
        public string CreatorRoleName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Settlement { get; set; }
        public int Order { get; set; }
    }
}
