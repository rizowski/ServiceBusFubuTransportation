using System;
using MyFT.Messages.Basic;

namespace MyFT.Handlers.Basic
{
    public class RequestHandler
    {
        public RequestMessage Handle(StartRequest request)
        {
            Console.WriteLine("Sending request...");
            return new RequestMessage
            {
                Type = MessageType.GoodBye
            };
        }

        public void Handle(ResponseMessage response)
        {
            Console.WriteLine("Received from server: {0}", response.Message);
        }
    }
}