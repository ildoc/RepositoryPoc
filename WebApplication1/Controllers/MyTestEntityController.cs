using Microsoft.AspNetCore.Mvc;
using WebApplication1.Infrastructure;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyTestEntityController : ControllerBase
    {
        private readonly IUnitOfWork _uof;

        public MyTestEntityController(IUnitOfWork uof)
        {
            _uof = uof;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MyTestEntity>> Get()
        {
            return Ok(_uof.Get<MyTestEntity>().FindAll(false));
        }
    }
}
