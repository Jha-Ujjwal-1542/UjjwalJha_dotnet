using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMenuItem;
using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
{
   [Route("api/menuitem")]
   public class MenuItemController : ControllerBase
   {

      private readonly IMenuItemService _menuitemService;

      public MenuItemController(IMenuItemService menuitemService)
      {
         _menuitemService = menuitemService;
      }

      [HttpGet]
      [Route("{id}")]
      public IActionResult Get([FromRoute] int id)
      {
         var menuitem = _menuitemService.GetById(id);

         if (menuitem == null)
            return NotFound();

         return Ok(menuitem);
      }

      [HttpGet]
      [Route("")]
      public IActionResult GetAll()
      {
         var MenuItems = _menuitemService.GetAll();
         return Ok(MenuItems);
      }

      [HttpPost]
      [Route("")]
      public IActionResult Post([FromBody] MenuItem model)
      {
         _menuitemService.Insert(model);
         return Ok();
      }

      [HttpPut]
      [Route("")]
      public IActionResult Put([FromBody] MenuItem model)
      {
         _menuitemService.Update(model);
         return Ok();
      }

      [HttpDelete]
      [Route("")]
      public IActionResult Delete([FromBody] MenuItem model)
      {
         _menuitemService.Delete(model);
         return Ok();
      }

   }
}