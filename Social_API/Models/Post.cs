using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_API.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public int UserId { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string? Image {  get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Content {  get; set; }
        public DateTime CreatedAt {  get; set; }
        public DateTime? UpdatedAt { get; set;}

    }
}
