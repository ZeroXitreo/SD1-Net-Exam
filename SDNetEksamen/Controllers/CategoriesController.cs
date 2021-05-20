using Microsoft.AspNetCore.Mvc;
using SDNetEksamen.Data;
using SDNetEksamen.Models;

namespace SDNetEksamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : CrudController<Category>
    {
        public CategoriesController(ApplicationDbContext context) : base(context)
        {
        }
    }
}
