using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class LoginViewModel
    {
        //[Display(Name = "Kullanıcı Adı", Prompt ="JohnDoe")] login sayfasında bunları yazmaıyıp sadece backend kısmını kullanarak bunkları ekleyebiliriz
        [Required(ErrorMessage ="Username is required")]
        [StringLength(30, ErrorMessage ="Username can be max 30 characters")]
        public string Username { get; set; }

        [DataType(DataType.Password)] //passwordun gizli olması için backend tarafında bu yapılabilir
        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password can be min 6 characters ")]
        [MaxLength(16, ErrorMessage =" Password can be max 30 characters")]
        public string Password { get; set; }
    }
}


