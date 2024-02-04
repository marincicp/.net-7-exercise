using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendvjezba.Models
{
    // T is actuial type of data we want to return
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }

        public bool Success { get; set; }


        public string Message { get; set; } = String.Empty;


    }
}