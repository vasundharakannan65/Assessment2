using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CustomerFeedBackFormMVC.Models
{
    [Table("Feedback")]
    public partial class Feedback
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string FeedbackId { get; set; }
        public int? ReviewId { get; set; }
        [Required]
        [StringLength(100)]
        public string Information { get; set; }
        [StringLength(100)]
        public string ReasonForUnsatisfactory { get; set; }
        [StringLength(200)]
        public string FileUpload { get; set; }

        [ForeignKey(nameof(ReviewId))]
        [InverseProperty("Feedbacks")]
        public virtual Review Review { get; set; }
    }
}
