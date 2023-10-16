namespace Review.Api.Repository.Entities
{
    public class Comment : BaseEntity<int>
    {
        public string Description { get; set; }

        public int Grade { get; set; }

        public int ResidenceId { get; set; }

        public int UserId { get; set; }
    }
}
