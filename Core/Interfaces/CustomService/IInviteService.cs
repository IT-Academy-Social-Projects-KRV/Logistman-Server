using Core.DTO.InviteDTO;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IInviteService
    {
        Task ManageTripInvitesAsync(CreateTripInvitesDTO createTripInvitesDTO);
        Task ManageAsync(ManageInviteDTO manageInviteDTO, string userId);
    }
}
