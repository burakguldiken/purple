using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Middleware.Models
{
    public class ValidationErrorDetail
    {
        public List<string> Errors { get; set; }
        public bool Success { get; set; }
        public int StatusCode { get; set; }
    }
}
