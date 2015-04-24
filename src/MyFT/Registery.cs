using System;
using System.Security.Cryptography.X509Certificates;
using FubuTransportation.Configuration;
using MyFT.Jobs;

namespace MyFT
{
    public class Registery : FubuTransportRegistry<Settings>
    {
        public Registery()
        {
            EnableInMemoryTransport();

            Channel(x => x.Uri)
                .AcceptsMessagesInNamespace(typeof (MyEntryPoint).Namespace)
                .ReadIncoming();

            Polling.RunJob<ImNeedyJob>().ScheduledAtInterval<NeedynessInterval>(x => x.Interval);
        }

        public class NeedynessInterval
        {
            public NeedynessInterval()
            {
                Interval = TimeSpan.FromSeconds(0.5).Milliseconds;
            }

            public double Interval { get; set; }
        }
    }
}
