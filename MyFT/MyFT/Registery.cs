using FubuTransportation.Configuration;

namespace MyFT
{
    public class Registery : FubuTransportRegistry<Settings>
    {
        public Registery()
        {
            Channel(x => x.Uri)
                .AcceptsMessagesInNamespace(typeof(MyEntryPoint).Namespace)
                //.Services(x => x.ReplaceService<ISubscriptionPersistence, InMemorySubscriptionPersistence>())
                .ReadIncoming();
        }
    }
}
