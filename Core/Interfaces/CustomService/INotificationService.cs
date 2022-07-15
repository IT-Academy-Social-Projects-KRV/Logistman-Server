using Core.DTO.NotificationDTO;
using Core.Entities.TripEntity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface INotificationService
    {
        Task ManageTripNotificationsAsync(Trip trip, List<BriefNotificationDTO> offers);
    }
}
