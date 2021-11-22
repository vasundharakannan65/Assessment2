using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerFeedBackFormWebAPI.ViewModels
{
    public class ErrorResponseViewModel<T>
    {
        public int Status { get; set; }

        public String Message { get; set; }

        public bool Succeeded { get; set; } = true;

        public T Data { get; set; }
    }
}
