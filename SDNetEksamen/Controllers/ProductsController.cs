using Microsoft.AspNetCore.Mvc;
using SDNetEksamen.Data;
using SDNetEksamen.Models;

namespace SDNetEksamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : CrudController<Product>
    {
        public ProductsController(ApplicationDbContext context) : base(context)
        {
        }
    }
}
