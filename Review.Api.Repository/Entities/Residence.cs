namespace Review.Api.Repository.Entities
{
    public class Residence : BaseEntity<int>
    {
        public string Address { get; set; }

        public string Description { get; set; }
    }
}
