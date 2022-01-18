using System;

namespace ApexRestaurant.Repository.Domain
{
   public class Staff
   {
      public int StaffId { get; set; }
      public int StaffRoleCode { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string OtherDetails { get; set; }
   }
}
