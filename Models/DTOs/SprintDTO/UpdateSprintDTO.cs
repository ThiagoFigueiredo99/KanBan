using System.ComponentModel.DataAnnotations;

namespace KanBan.Models.DTOs.SprintDTO
{
    public class UpdateSprintDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
