using System;

namespace ApexRestaurant.Repository.Domain
{
   public class Meal
   {
      public int MealId { get; set; }
      public int Id { get; set; }
      public int StaffId { get; set; }
      public DateTime DateOfMeal { get; set; }
      public int CostOfMeal { get; set; }
      public string OtherDetails { get; set; }
      public DateTime UpdatedOn { get; set; }
   }
}