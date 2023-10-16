namespace Review.Api.Repository.Entities
{
    public class User : BaseEntity<int>
    {
        public string UserName { get; set; }

        //public string Email { get; set; }

        //public DateTime Created { get; set; }

        //public DateTime Birthday { get; set; }

        public string HashPassword { get; set; }

        //public bool EmailConfirmed { get; set; }
    }
}
