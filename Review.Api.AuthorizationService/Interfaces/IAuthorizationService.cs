using Review.Api.AuthorizationService.Data;

namespace Review.Api.AuthorizationService.Interfaces
{
    public interface IAuthorizationService
    {
        public Tokens Login(string username, string password);

        public Tokens UpdateTokens(string refreshToken);
    }
}
