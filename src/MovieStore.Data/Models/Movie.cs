using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStore.Data.Models
{
    public class Movie : BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Required]
        [Column(Order = 1)]
        public string Name { get; set; } = String.Empty;

        [Required]
        [Column(Order = 2)]
        public string Year { get; set; } = String.Empty;

        [Required]
        [Column(Order = 3)]
        public int MovieTypeId { get; set; }
        public virtual MovieGenre MovieType { get; set; } = new MovieGenre();

        [Required]
        [Column(Order = 4)]
        public double MovieCost { get; set; }

    }
}