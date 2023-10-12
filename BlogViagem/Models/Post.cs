using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace BlogViagem.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }   


        public string Description { get; set; }


        [ForeignKey(nameof(Id))]
        public int IdAdmin { get; set; }

        public DataSetDateTime DataPost { get; set; }  
    }
}
