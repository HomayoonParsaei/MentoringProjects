using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);

            //return new JsonResult(
            //    new List<object>
            //    {
            //          new {id = 1,Name ="New York City"},
            //        new {id = 2,Name ="Antwerp"}
            //    });
        }
    }
          
}
