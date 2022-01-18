using System;

namespace ApexRestaurant.Repository.Domain
{
   public class MealDish
   {
      public int MenuId { get; set; }
      public int MenuItemId { get; set; }
      public string OtherItems { get; set; }
   }
}