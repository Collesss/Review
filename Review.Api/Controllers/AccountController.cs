using Microsoft.AspNetCore.Mvc;

namespace Review.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger) 
        {
            _logger = logger;
        }


        public void Authenticate()
        {

        }
    }
}
