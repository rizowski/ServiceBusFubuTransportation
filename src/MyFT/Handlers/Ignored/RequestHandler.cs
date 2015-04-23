using System;
using MyFT.Messages;
using MyFT.Messages.Ignored;

namespace MyFT.Handlers.Ignored
{
    public class RequestHandler
    {
        public MultiplyMessage Handle(StartMultiplyRequest request)
        {
            Console.WriteLine("I am going to send 5, 5");
            return new MultiplyMessage
            {
                NumberOne = 5,
                NumberTwo = 5
            };
        }

        public SumMessage Handle(StartSumRequest request)
        {
            Console.WriteLine("I am going to send 5, 5");
            return new SumMessage
            {
                NumberOne = 5,
                NumberTwo = 5
            };
        }

        public void Handle(ResponseMessage response)
        {
            Console.WriteLine("I received back {0}", response.Result);
        }
    }
}
