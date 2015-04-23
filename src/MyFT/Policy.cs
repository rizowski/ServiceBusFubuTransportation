using System;
using FubuTransportation.Configuration;

namespace MyFT
{
    public class ErrorPolicy : HandlerChainPolicy
    {
        public override void Configure(HandlerChain handlerChain)
        {
            handlerChain.MaximumAttempts = 5;

            //handlerChain.OnException<Exception>()
            //    .MoveToErrorQueue(); // For Diagnostics / Can be subscribed to?

            handlerChain.OnException<Exception>()
                .Retry();  //.Requeue
        }
    }
}
