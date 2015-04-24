using System;
using MyFT;

namespace Server
{
    public class Server
    {
        static void Main(string[] args)
        {
            var applicationSource = new MyEntryPoint();
            var application = applicationSource.BuildApplication();
            application.Bootstrap();

            Console.Read();
        }
    }
}
