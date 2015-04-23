using System;
using FubuTransportation;

namespace MyFT
{
    public class Settings
    {
        public Settings()
        {
            Uri = "memory://simple".ToUri();
        }

        public Uri Uri { get; set; }
    }
}
