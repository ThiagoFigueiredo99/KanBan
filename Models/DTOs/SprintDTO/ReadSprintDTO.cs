using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KanBan.Models.DTOs.SprintDTO
{
    public class ReadSprintDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime TimeOfAppointment { get; set; }
        public virtual object Cards { get; set; }
    }
}
