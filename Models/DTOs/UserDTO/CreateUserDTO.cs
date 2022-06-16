using System.ComponentModel.DataAnnotations;

namespace KanBan.Models.DTOs.UserDTO
{
    public class CreateUserDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
