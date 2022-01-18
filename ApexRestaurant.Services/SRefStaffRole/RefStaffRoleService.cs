using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RRefStaffRole;

namespace ApexRestaurant.Services.SRefStaffRole
{
   public class RefStaffRoleService : GenericService<RefStaffRole>, IRefStaffRoleService
   {
      public RefStaffRoleService(IRefStaffRoleRepository RefStaffRoleRepository) :
      base(RefStaffRoleRepository)
      {

      }
   }
}