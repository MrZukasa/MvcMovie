using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [DisplayName("Titolo")]
        [Required]
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data d'uscita")]
        public DateTime ReleaseDate { get; set; }
        [DisplayName("Genere")]
        public string? Genre { get; set; }    
        public decimal Price { get; set; }
    }
}