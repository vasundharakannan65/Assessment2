using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerFeedBackFormMVC.ViewModels
{
    public class FeedbackViewModel
    {
        [Required(ErrorMessage ="Title is Required")]
        [StringLength(5, ErrorMessage = "Title must be length of 5")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50, ErrorMessage = "Name must be length of 50")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Initials is Required")]
        [StringLength(5, ErrorMessage = "Initials must be length of 5")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string Initials { get; set; }

        [Required(ErrorMessage = "EmailId is Required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Email Id is not valid")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "StreetAddress1 is Required")]
        [StringLength(50, ErrorMessage = "Initials must be length of 50")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string StreetAddress1 { get; set; }


        [StringLength(50, ErrorMessage = "StreetAddress2 must be length of 50")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string StreetAddress2 { get; set; }

        [Required(ErrorMessage = "City is Required")]
        [StringLength(50, ErrorMessage = "City must be length of 50")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string City { get; set; }

        [Required(ErrorMessage = "ZipCode is Required")]
        [StringLength(6, ErrorMessage = "ZipCode must be length of 6")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public int ZipCode { get; set; }


        [Required(ErrorMessage = "Region is Required")]
        [StringLength(50, ErrorMessage = "Region must be length of 50")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string Region { get; set; }

        [Required(ErrorMessage = "Country is Required")]
        [StringLength(50, ErrorMessage = "Country must be length of 50")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string Country { get; set; }

        [Required]
        public int RatingId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Information is Required")]
        [StringLength(50, ErrorMessage = "Information must be length of 50")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string Information { get; set; }

        [Required(ErrorMessage = "ReasonForUnsatisfactory is Required")]
        [StringLength(100, ErrorMessage = "ReasonForUnsatisfactory must be length of 100")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string ReasonForUnsatisfactory { get; set; }

        [Required(ErrorMessage = "FileUpload is Required")]
        public string FileUpload { get; set; }
    }
}
