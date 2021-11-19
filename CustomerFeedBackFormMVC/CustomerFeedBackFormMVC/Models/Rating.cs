using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CustomerFeedBackFormMVC.Models
{
    [Table("Rating")]
    public partial class Rating
    {
        public Rating()
        {
            Reviews = new HashSet<Review>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [InverseProperty(nameof(Review.Rating))]
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
