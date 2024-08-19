using DressCoder.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace DressCoder.Controllers
{
    [Route("api/controller")]
    [ApiController]

    public class LoginController : Controller
    {
        private readonly DataContextTables _dataTables;
        public LoginController(DataContextTables dataTables)
        {
            _dataTables = dataTables;
        }


        [HttpGet("/GetLoginDetals")]
        public IActionResult GetLoginDetails()
        {
            var LoginDetails = _dataTables.UserLogins.ToList();
            return Ok(LoginDetails);
        }
    }
}
