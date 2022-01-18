using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RRefStaffRole
{
   public class RefStaffRoleRepository : GenericRepository<RefStaffRole>, IRefStaffRoleRepository
   {
      public RefStaffRoleRepository(RestaurantContext dbContext)
      {
         DbContext = dbContext;
      }
   }
}