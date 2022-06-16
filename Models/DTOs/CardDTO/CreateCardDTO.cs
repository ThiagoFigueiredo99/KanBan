using Projeto.Enums;

namespace KanBan.Models.DTOs.CardDTO
{
    public class CreateCardDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public double Estimate { get; set; }
        public int SprintId { get; set; }
        public Status Status { get; set; }
    }
}
