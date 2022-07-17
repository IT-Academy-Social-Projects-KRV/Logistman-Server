using System;

namespace Core.DTO
{
    public class PointOfferConfirmDTO : IComparable<PointTripInfoDTO>
    {
        public string Address { get; set; }
        public string Settlement { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public int Order { get; set; }

        int IComparable<PointTripInfoDTO>.CompareTo(PointTripInfoDTO point)
        {
            if (point.Order > this.Order)
                return -1;
            else if (point.Order == this.Order)
                return 0;
            else
                return 1;
        }
    }
}
