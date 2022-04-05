using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto
{
    public class Sprint
    {
        public Sprint(string name)
        {
            Name = name;
        }

        [Column("sprint_id")] // olhar e pesquisar
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
    }
}
