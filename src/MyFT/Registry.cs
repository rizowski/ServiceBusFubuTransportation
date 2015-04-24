using FubuTransportation.Configuration;

namespace MyFT
{
    public class Registry : FubuTransportRegistry<Settings>
    {
        public Registry()
        {
            EnableInMemoryTransport();

            Channel(x => x.Uri)
                .AcceptsMessagesInNamespaceContainingType<MyEntryPoint>()
                .ReadIncoming();
        }
    }
}
