using System;
using MyFT.Messages.Basic;

namespace MyFT.Handlers.Basic
{
    public class ResponseHandler
    {
        public ResponseMessage Handle(RequestMessage request)
        {
            Console.WriteLine("Received from client: {0}", request.Type);
            var message = request.Type == MessageType.Hello ? "Hi Thar!" : "Go away! :D";
            
            //throw new Exception();
            
            return new ResponseMessage
            {
                Message = message
            };
        }
    }
}
