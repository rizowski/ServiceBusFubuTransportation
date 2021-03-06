﻿using System;
using FubuTransportation;
using MyFT;

namespace Server
{
    public class Server
    {
        static void Main(string[] args)
        {
            var applicationSource = new MyEntryPoint();
            var application = applicationSource.BuildApplication();
            var runtime = application.Bootstrap();
            var bus = runtime.Factory.Get<IServiceBus>();
            bus.Send(new StartRequest());
            Console.Read();
        }
    }
}
