using BusinessLogic.Security;
using Microsoft.AspNetCore.Mvc;

namespace Sanay3yMasr.Controllers
{
    [ApiController]
    [Route("api/Test")]
    public class TestController : ControllerBase
    {
        [HttpGet("hash")]
        public IActionResult GenerateHash(string password)
        {
            var hash = PasswordHasher.Hash(password);
            return Ok(hash);
        }
    }

}
