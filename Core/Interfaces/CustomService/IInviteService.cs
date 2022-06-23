using Core.DTO.InviteDTO;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IInviteService
    {
        Task ManageTripInvitesAsync(CreateTripInvitesDTO createTripInvitesDTO);
    }
}
