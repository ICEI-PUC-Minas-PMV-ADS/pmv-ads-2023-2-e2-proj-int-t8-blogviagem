using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogViagem.Models
{
    [Table("Posts")]

    public class Post
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o titulo!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime Datapost { get; set; }

        public int IdAdmin { get; set; }

    }
}
