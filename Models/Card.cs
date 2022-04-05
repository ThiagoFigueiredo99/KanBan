using Projeto.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto
{
    public class Card
    {
        public Card(string title, string description, int idUser, int idSprint, double estimation, Status status)
        {
            Title = title;
            Description = description;
            Status = status;
            IdUser = idUser;
            IdSprint = idSprint;
            Estimation = estimation;
        }

        [Column("cartao_id")] // olhar e pesquisar
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int IdUser { get; set; }
        public int IdSprint { get; set; }
        public double Estimation { get; set; }
        public Status Status { get; set; }

    }

}
