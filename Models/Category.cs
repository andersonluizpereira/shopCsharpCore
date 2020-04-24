using System.ComponentModel.DataAnnotations;

namespace Shop.Models {
    public class Category {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength (60, ErrorMessage = "Este campo deve conter entre 3 a 60 caractéres")]

        [MinLength (3, ErrorMessage = "Este campo deve conter entre 3 a 60 caractéres")]
        public string Title { get; set; }
    }
}