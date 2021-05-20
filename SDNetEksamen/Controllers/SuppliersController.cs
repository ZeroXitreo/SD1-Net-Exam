using Microsoft.AspNetCore.Mvc;
using SDNetEksamen.Data;
using SDNetEksamen.Models;

namespace SDNetEksamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : CrudController<Supplier>
    {
        public SuppliersController(ApplicationDbContext context) : base(context)
        {
        }
    }
}
