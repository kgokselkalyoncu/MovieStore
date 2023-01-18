using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Data.Models
{
    public class Customer : BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order = 1)]
        public string Name { get; set; } = String.Empty;

        [Required]
        [Column(Order = 2)]
        public string Surname { get; set; } = String.Empty;

        public virtual ICollection<CustomerPurchasedMovie>? CustomerPurchasedMovie { get; set; }
        public virtual ICollection<CustomerFavoriteMovieGenre>? CustomerFavoriteMovieGenre { get; set; }

    }
}