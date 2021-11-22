using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerFeedBackFormMVC.ViewModels
{
    public class CustomerFeedbackFormViewModel
    {
        public string Title { get; set; }

        public string Name { get; set; }

        public string Initials { get; set; }

        public string EmailId { get; set; }

        public string StreetAddress1 { get; set; }

        public string StreetAddress2 { get; set; }

        public string City { get; set; }

        public int ZipCode { get; set; }

        public string Region { get; set; }

        public string Country { get; set; }

        public string RatingName { get; set; }

        public string ProductName { get; set; }

        public string CategoryName { get; set; }

        public string Information { get; set; }

        public string ReasonForUnsatisfactory { get; set; }

        public string FileUpload { get; set; }

        public string UniqueFeedbackId { get; set; }
    }
}
