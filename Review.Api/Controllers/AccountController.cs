using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Review.Api.Dto.Account.Request;
using Review.Api.Dto.Account.Response;
using System.IdentityModel.Tokens.Jwt;

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

        [AllowAnonymous]
        public TokensResponseDto Authenticate(UserRequestDto userRequestDto)
        {
            return null;
        }

        [Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme}1")]
        public TokensResponseDto UpdateTokens()
        {
            return null;
        }
    }
}
