using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMealDish;
using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
{
   [Route("api/mealdish")]
   public class MealDishController : ControllerBase
   {

      private readonly IMealDishService _mealdishService;

      public MealDishController(IMealDishService mealdishService)
      {
         _mealdishService = mealdishService;
      }

      [HttpGet]
      [Route("{id}")]
      public IActionResult Get([FromRoute] int id)
      {
         var mealdish = _mealdishService.GetById(id);

         if (mealdish == null)
            return NotFound();

         return Ok(mealdish);
      }

      [HttpGet]
      [Route("")]
      public IActionResult GetAll()
      {
         var MealDishes = _mealdishService.GetAll();
         return Ok(MealDishes);
      }

      [HttpPost]
      [Route("")]
      public IActionResult Post([FromBody] MealDish model)
      {
         _mealdishService.Insert(model);
         return Ok();
      }

      [HttpPut]
      [Route("")]
      public IActionResult Put([FromBody] MealDish model)
      {
         _mealdishService.Update(model);
         return Ok();
      }

      [HttpDelete]
      [Route("")]
      public IActionResult Delete([FromBody] MealDish model)
      {
         _mealdishService.Delete(model);
         return Ok();
      }

   }
}