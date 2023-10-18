using System.ComponentModel.DataAnnotations;

namespace Review.Api.Dto.Account.Request
{
    public class UserRequestDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
