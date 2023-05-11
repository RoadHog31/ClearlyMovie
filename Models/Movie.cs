using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {

        //You can declaratively specify validation rules in one place (in the model class) and the rules are enforced everywhere in the app.
        //Value types (such as decimal, int, float, DateTime) are inherently required and don't need the [Required] attribute.
        //Fill out the form with some invalid values. As soon as jQuery client side validation detects the error, it displays an error message.

        public int Id { get; set; }

        //The question mark after string indicates that the property is nullable. 
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        //The question mark after string indicates that the property is nullable. 
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string? Rating { get; set; }
    }
}