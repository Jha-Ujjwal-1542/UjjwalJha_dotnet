using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RMenuItem;

namespace ApexRestaurant.Services.SMenuItem
{
   public class MenuItemService : GenericService<MenuItem>, IMenuItemService
   {
      public MenuItemService(IMenuItemRepository MenuItemRepository) :
      base(MenuItemRepository)
      {

      }
   }
}