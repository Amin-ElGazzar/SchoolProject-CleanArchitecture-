using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace School.Application.Common.Models
{
    public class Response <T>
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<String> Errors { get; set; }
        public object Meta { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public T Data { get; set; }

    }
}
