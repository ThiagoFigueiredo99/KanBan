using Projeto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    public User(string name)
    {
        Name = name;
    }

    [Column("usuario_id")] // olhar e pesquisar
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Card>cards { get; set; }
}