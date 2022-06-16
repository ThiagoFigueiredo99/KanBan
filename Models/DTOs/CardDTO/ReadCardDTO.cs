using Projeto;
using Projeto.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KanBan.Models.DTOs.CardDTO
{
    public class ReadCardDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual User User { get; set; }
        public double Estimate { get; set; }
        public virtual Sprint Sprint { get; set; }
        public Status Status { get; set; }
        public DateTime TimeOfAppointment { get; set; }
    }
}
