using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Data.Models
{
    public class CustomerFavoriteMovieGenre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        
        [Required]
        [Column(Order = 1)]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; } = new Customer();

        [Required]
        [Column(Order = 2)]
        public int MovieGenreId { get; set; }
        public virtual MovieGenre Movie { get; set; } = new MovieGenre();
    }
}