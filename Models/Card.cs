using Projeto.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto
{
    public class Card
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


        public virtual User User { get; set; }
        //[ForeignKey("IdUser")]
        public int UserId { get; set; }
       
        

        public virtual Sprint Sprint { get; set; }
        //[ForeignKey("IdSprint")]
        public int SprintId { get; set; }
        
        

        public double Estimation { get; set; }
        public Status Status { get; set; }

        /* public Card(string title, string description, double estimation)
         {
             Title = title;
             Description = description;
             Estimation = estimation;
         }*/
    }

}
