using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Data.Models
{
    public class CustomerOrder : BaseModel
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
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; } = new Movie();

        [Required]
        [Column(Order = 3)]
        public double Price { get; set; }

        [Required]
        [Column(Order = 4)]
        public DateTime OrderDate { get; set; }
    }
}