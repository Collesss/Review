namespace Review.Api.AuthorizationService.Data
{
    public class Tokens
    {
        public string Access { get; }

        public string Refresh { get; }

        public Tokens(string access, string refresh)
        {
            Access = access;
            Refresh = refresh;
        }
    }
}
