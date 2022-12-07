using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage="Lütfen kullanıcı adını girniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi girniz")]
        public string Password { get; set; }
    }
}
