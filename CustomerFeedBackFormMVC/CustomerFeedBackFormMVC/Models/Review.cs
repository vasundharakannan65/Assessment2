using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CustomerFeedBackFormMVC.Models
{
    [Table("Review")]
    public partial class Review
    {
        public Review()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        [Key]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ProductId { get; set; }
        public int? RatingId { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("Reviews")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(RatingId))]
        [InverseProperty("Reviews")]
        public virtual Rating Rating { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(UserInfo.Reviews))]
        public virtual UserInfo User { get; set; }
        [InverseProperty(nameof(Feedback.Review))]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
