using System.ComponentModel.DataAnnotations;
using WebAppCustomDataAnnotation.ArrtibuteValidation;

namespace WebAppCustomDataAnnotation.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Email address is required.")]
        [UniqueEmail]
        public string Email { get; set; }
    }
}