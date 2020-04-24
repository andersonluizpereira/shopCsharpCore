using System.ComponentModel.DataAnnotations;

namespace Shop.Models {
    public class User {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength (20, ErrorMessage = "Este campo deve conter entre 3 a 20 caractéres")]

        [MinLength (3, ErrorMessage = "Este campo deve conter entre 3 a 20 caractéres")]
        public string UserName { get; set; }

        [Required]
        [MaxLength (20, ErrorMessage = "Este campo deve conter entre 3 a 20 caractéres")]

        [MinLength (3, ErrorMessage = "Este campo deve conter entre 3 a 20 caractéres")]
        public string Password { get; set; }

        public string Role { get; set; }

    }
}