using System.ComponentModel.DataAnnotations;

namespace MVCDHProject2.Models
{
    public class ChangePasswordModel
    {
        [Required]
        [Display(Name = "User Name")]
        [RegularExpression("[A-Za-z0-9-._@+]*")]
        public string Name { get; set; }

    }
}
