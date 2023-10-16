namespace Review.Api.Repository.Exeptions
{
    public class DetailsErrorRange : DetailsError
    {
        public int MinLen { get; }

        public int MaxLen { get; }

        public DetailsErrorRange(string field, int minLen, int maxLen) : base(RepositoryErrorCode.Range, field)
        {
            MinLen = minLen;
            MaxLen = maxLen;
        }
    }
}
