namespace GiveNTake.Controllers
{
    using Microsoft.AspNetCore.Mvc;


    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        [HttpGet("all")]
        public string[] GetProducts()
        {
            return new[]
            {
                "1 - Microwave",
                "2 - Washing Machine",
                "3 - Mirror"
            };
        }


        [HttpGet("searchcategory/{category}/{subcategory=all}/")]
        public string[] SearchByProducts(string category, string subcategory, string location = "all", bool imageOnly = false)
        {
            return new[]
            {
        $"Category: {category}, Subcategory: {subcategory}, Location: {location}, Only with Images: {imageOnly}"
    };
        }
    }
}
