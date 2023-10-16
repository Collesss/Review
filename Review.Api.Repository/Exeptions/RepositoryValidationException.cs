namespace Review.Api.Repository.Exeptions
{
    public class RepositoryValidationException : ArgumentException
    {
        public string Table { get; } = string.Empty;

        //public List<DetailsError> Details { get; } = new List<DetailsError>();

        private readonly List<DetailsError> _details = new();

        public IReadOnlyList<DetailsError> Details { get => _details; }

        public RepositoryValidationException(string message) : base(message) { }

        public RepositoryValidationException(string message, string table, DetailsError detailsError) : base(message)
        {
            Table = table;
            _details.Add(detailsError);
        }

        public RepositoryValidationException(string message, string table, IEnumerable<DetailsError> details) : base(message)
        {
            Table = table;
            _details.AddRange(details);
        }

        public RepositoryValidationException(string message, Exception innerException) : base(message, innerException) { }

        public RepositoryValidationException(string message, Exception innerException, string table) : base(message, innerException)
        {
            Table = table;
        }

        public RepositoryValidationException(string message, Exception innerException, string table, DetailsError details) : base(message, innerException)
        {
            Table = table;
            _details.Add(details);
        }

        public RepositoryValidationException(string message, Exception innerException, string table, IEnumerable<DetailsError> details) : base(message, innerException)
        {
            Table = table;
            _details.AddRange(details);
        }
    }
}
