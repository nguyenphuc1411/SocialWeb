using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_API.Models
{
    public class User:IdentityUser
    {
        [Key]
        public int UserId {  get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string FullName {  get; set; }
        public DateTime CreatedAt { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Bio {  get; set; }
        [Column(TypeName = "varchar(255)")]
        public string? Avatar { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DOB { get; set; }
        public string? TokenAccount {  get; set; }
    }   
}
