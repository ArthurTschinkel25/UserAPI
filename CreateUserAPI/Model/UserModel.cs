    using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreateUserAPI.Model

{
    public class UserModel
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "There must be a valid username")]
        [MaxLength(30, ErrorMessage = "The User must contain less than 30 characteres")] 
        
        public string? Name { get; set; }
        [Required(ErrorMessage = "There must be a email")]
        [EmailAddress(ErrorMessage = "The email must be valid")]
        [MaxLength(ErrorMessage = "The email must contain less than 100 characteres")]
        public string? Email { get; set; }
        [Required]
        [MaxLength(ErrorMessage = "The password must contain less than 50 characteres")]
        public string? Password { get; set; }
    }
}
