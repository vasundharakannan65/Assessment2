using CustomerFeedBackFormWebAPI.Interfaces;
using CustomerFeedBackFormWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerFeedBackFormWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            this._feedbackRepository = feedbackRepository;
        }

        //Feedback
        [HttpPost]
        public void Create(CustomerForm customerForm)
        {
            try
            {
                _feedbackRepository.Create(customerForm);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
