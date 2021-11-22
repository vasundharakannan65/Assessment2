using CustomerFeedBackFormWebAPI.Interfaces;
using CustomerFeedBackFormWebAPI.ViewModels;
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

        //Create Feedback
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

        //Get Feedback Info 
        [HttpGet]
        public async Task<IActionResult> GetFeedbackInfo()
        {
            try
            {
                var result =await _feedbackRepository.GetFeedbackInfo();
                return Ok(result);
            } 
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
