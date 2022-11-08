using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    [Table("Users")]
    public class User
    {
       
        [Key]  //ctrl+. basarak dataanotations yapıyoruz usinge ekliyor
        public Guid Id { get; set; } //user verilerinde güvenlik açısından guid yapıyoruz ---guid=uniqueId

        [StringLength(50)]
        public string? FullName { get; set; } = null;  //son sürümle null alabilen değerlerin nullable olduğunu belirtmek için ? kullanıyoruz

        [Required]
        [StringLength(30)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)] 
        public string Password { get; set; }
        public bool Locked { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now; 
    }
}
