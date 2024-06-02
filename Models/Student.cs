using System.ComponentModel.DataAnnotations;
using WebAppCustomDataAnnotation.CustomAttributeValidation;


namespace WebAppCustomDataAnnotation.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        [Required]
        [UniqueName(ErrorMessage = "{0} is already exist.")]
        public string Name { get; set; }
        
        
        [Required(ErrorMessage = "Email address is required.")]
        [UniqueEmail(ErrorMessage ="Email address must be unique.")]
        public string Email { get; set; }
    }
}