namespace Review.Api.Repository.Exeptions
{
    public class DetailsErrorStringTemplate : DetailsError
    {
        public string Template { get; }

        public DetailsErrorStringTemplate(string field, string template) : base(RepositoryErrorCode.String_Template, field)
        {
            Template = template;
        }
    }
}
