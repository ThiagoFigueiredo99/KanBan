using System.ComponentModel.DataAnnotations;

namespace KanBan.Models.DTOs.UserDTO
{
    public class UpdateUserDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
