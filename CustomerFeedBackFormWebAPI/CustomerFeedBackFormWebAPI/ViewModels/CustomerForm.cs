using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerFeedBackFormWebAPI.ViewModels
{
    public class CustomerForm
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

        public int RatingId { get; set; }

        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string Information { get; set; }

        public string ReasonForUnsatisfactory { get; set; }

        public string FileUpload { get; set; }

        

    }
}
