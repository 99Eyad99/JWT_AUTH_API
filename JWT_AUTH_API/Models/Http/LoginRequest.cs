using System.ComponentModel.DataAnnotations;

namespace JWT_AUTH_API.Models.Http
{
    public class LoginRequest
    {
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
