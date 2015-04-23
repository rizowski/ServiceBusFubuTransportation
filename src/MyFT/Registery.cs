using FubuTransportation.Configuration;
using MyFT.Handlers.Ignored;
using MyFT.Messages.Ignored;

namespace MyFT
{
    public class Registery : FubuTransportRegistry<Settings>
    {
        public Registery()
        {
            EnableInMemoryTransport();

            //Channel(x => x.Simple)
            //    //.AcceptsMessagesInNamespace(typeof(Basic.RequestHandler).Namespace)
            //    .AcceptsMessagesInNamespace(typeof(MyEntryPoint).Namespace)
            //    .ReadIncoming();

            Channel(x => x.Ignore)
                .AcceptsMessagesInAssemblyContainingType<MultiplyMessage>()
                .ReadIncoming();

            //Handlers.DisableDefaultHandlerSource();
            //Handlers.FindBy(x =>
            //{
            //    x.ExcludeTypes(type => type == typeof (SumHandler));
                
            //}); // I am sad this doesn't work
        }
    }
}
