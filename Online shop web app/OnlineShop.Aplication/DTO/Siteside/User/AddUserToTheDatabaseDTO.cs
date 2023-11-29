

using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Application.DTO.Siteside.User
{
    public class AddUserToTheDatabaseDTO
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords don't match")]
        public string RePassword { get; set; }
    }
}
