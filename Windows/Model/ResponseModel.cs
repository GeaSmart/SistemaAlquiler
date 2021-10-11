using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Model
{
    public class ResponseModel<T>
    {
        public bool Response { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }
}
