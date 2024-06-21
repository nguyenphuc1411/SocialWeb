using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_API.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string Content {  get; set; }
        public DateTime CreatedAt {  get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int UserId { get; set; }
    }
}
