using System;

namespace ApexRestaurant.Repository.Domain
{
   public class MenuItem
   {
      public int MenuItemId { get; set; }
      public int MenuId { get; set; }
      public string MenuItemName { get; set; }
      public string OtherDetails { get; set; }
   }
}