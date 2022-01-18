using System;

namespace ApexRestaurant.Repository.Domain
{
   public class Menu
   {
      public int MenuId { get; set; }
      public string MenuName { get; set; }
      public DateTime AvailableDateFrom { get; set; }
      public DateTime AvailableDateTo { get; set; }
      public string OtherDetails { get; set; }
   }
}