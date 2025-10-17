using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Art_Gallery.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        
        [Display(Name="Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("PassWord", ErrorMessage = "Passwords do not match.")]


        public string ConfirmPassword { get; set; }
        public string Email { get; set; }

    }
}
