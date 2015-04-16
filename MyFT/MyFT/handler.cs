using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFT
{
    public class RequestHandler
    {
        public RequestMessage Handle(StartRequest request)
        {
            Console.WriteLine("Sending request...");
            return new RequestMessage();
        }

        public void Handle(ResponseMessage response)
        {
            Console.WriteLine("Received a response.");
        }
    }

    public class ResponseHandler
    {
        public ResponseMessage Handle(RequestMessage request)
        {
            Console.WriteLine("Received a request...");
            return new ResponseMessage();
        }
    }
}
