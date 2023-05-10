using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        //The question mark after string indicates that the property is nullable. 
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        //The question mark after string indicates that the property is nullable. 
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}