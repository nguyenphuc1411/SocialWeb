using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_API.Models
{
    public class RefreshToken
    {
        [Key]
        public Guid RTId {  get; set; }

        public int UserId {  get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Token {  get; set; }
        public DateTime IssuedAt { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
