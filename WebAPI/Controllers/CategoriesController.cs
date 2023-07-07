using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebAPI.Data;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ProductContext _context;

        public CategoriesController(ProductContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetWithProducts(int id) 
        {
            var data = _context.Categories.Include(x=>x.Products).SingleOrDefault(x=>x.Id == id);

            if (data == null)
            {
                return NotFound(id);
            }
            return Ok(data);
        }
    }
}
