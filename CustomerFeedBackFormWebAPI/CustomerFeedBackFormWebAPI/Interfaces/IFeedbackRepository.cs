using CustomerFeedBackFormWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerFeedBackFormWebAPI.Interfaces
{
    public interface IFeedbackRepository
    {
        void Create(CustomerForm custerForm);
    }
}
