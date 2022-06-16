using System.ComponentModel.DataAnnotations;

namespace KanBan.Models.DTOs.SprintDTO
{
    public class CreateSprintDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
