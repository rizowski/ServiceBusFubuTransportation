using FubuTransportation.Configuration;

namespace MyFT
{
    public class Registery : FubuTransportRegistry<Settings>
    {
        public Registery()
        {
            EnableInMemoryTransport();

            Channel(x => x.Uri)
                .AcceptsMessagesInNamespace(typeof(MyEntryPoint).Namespace)
                .ReadIncoming();

            //Handlers.DisableDefaultHandlerSource();

            //Handlers.FindBy(x =>
            //{
            //    x.ExcludeMethods(y => y.ReturnType == typeof (IgnoredResponse));
            //    x.IncludeTypesImplementing<IHandle>();
            //});
        }
    }
}
