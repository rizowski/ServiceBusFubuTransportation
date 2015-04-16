using FubuTransportation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFT;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {
            var applicationSource = new MyEntryPoint();
            var application = applicationSource.BuildApplication();
            var runtime = application.Bootstrap();
            var bus = runtime.Factory.Get<IServiceBus>();
            bus.Send(new StartRequest());
        }
    }
}
