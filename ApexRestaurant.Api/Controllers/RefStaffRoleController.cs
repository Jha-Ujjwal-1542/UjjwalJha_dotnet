using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SRefStaffRole;
using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
{
   [Route("api/refstaffrole")]
   public class RefStaffRoleController : ControllerBase
   {

      private readonly IRefStaffRoleService _refstaffroleService;

      public RefStaffRoleController(IRefStaffRoleService menuService)
      {
         _refstaffroleService = menuService;
      }

      [HttpGet]
      [Route("{id}")]
      public IActionResult Get([FromRoute] int id)
      {
         var menu = _refstaffroleService.GetById(id);

         if (menu == null)
            return NotFound();

         return Ok(menu);
      }

      [HttpGet]
      [Route("")]
      public IActionResult GetAll()
      {
         var Menus = _refstaffroleService.GetAll();
         return Ok(Menus);
      }

      [HttpPost]
      [Route("")]
      public IActionResult Post([FromBody] RefStaffRole model)
      {
         _refstaffroleService.Insert(model);
         return Ok();
      }

      [HttpPut]
      [Route("")]
      public IActionResult Put([FromBody] RefStaffRole model)
      {
         _refstaffroleService.Update(model);
         return Ok();
      }

      [HttpDelete]
      [Route("")]
      public IActionResult Delete([FromBody] RefStaffRole model)
      {
         _refstaffroleService.Delete(model);
         return Ok();
      }

   }
}