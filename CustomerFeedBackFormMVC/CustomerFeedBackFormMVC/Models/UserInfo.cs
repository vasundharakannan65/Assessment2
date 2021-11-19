using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CustomerFeedBackFormMVC.Models
{
    [Table("UserInfo")]
    public partial class UserInfo
    {
        public UserInfo()
        {
            Reviews = new HashSet<Review>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(5)]
        public string Title { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(5)]
        public string Initials { get; set; }
        [Required]
        [StringLength(60)]
        public string StreetAddress1 { get; set; }
        [StringLength(60)]
        public string StreetAddress2 { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        [Required]
        [StringLength(6)]
        public string ZipCode { get; set; }
        [Required]
        [StringLength(50)]
        public string Region { get; set; }
        [Required]
        [StringLength(50)]
        public string Country { get; set; }
        [Required]
        [StringLength(100)]
        public string EmailId { get; set; }

        [InverseProperty(nameof(Review.User))]
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
