namespace Review.Api.AuthorizationService.Exceptions
{
    public class AuthorizationServiceExceptions : Exception
    {
        public AuthorizationServiceExceptions(string message) : base(message) { }

        public AuthorizationServiceExceptions(string message, Exception innerException) : base(message, innerException) { }
    }
}
