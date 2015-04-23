using FubuMVC.Core;
using FubuMVC.StructureMap3;
using FubuTransportation.Configuration;
using StructureMap;

namespace MyFT
{
    public class MyEntryPoint : IApplicationSource
    {
        public FubuApplication BuildApplication()
        {
            //FubuTransport.AllQueuesInMemory = true;   // IMPORTANT FOR MEMORY URI'S
            return FubuTransport
                .For<Registery>()
                .StructureMap(new Container());
        }
    }
}
