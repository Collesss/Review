namespace Review.Api.Repository.Exeptions
{
    public class DetailsErrorStringLen : DetailsError
    {
        public int MinLen { get; }

        public int MaxLen { get; }

        public DetailsErrorStringLen(string field, int minLen, int maxLen) : base(RepositoryErrorCode.String_Len, field)
        {
            MinLen = minLen;
            MaxLen = maxLen;
        }
    }
}
