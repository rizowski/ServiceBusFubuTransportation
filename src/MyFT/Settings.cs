using System;
using FubuTransportation;

namespace MyFT
{
    public class Settings
    {
        public Settings()
        {
            Simple = "memory://simple".ToUri();
            Ignore = "memory://ignore".ToUri();
        }

        public Uri Simple { get; set; }
        public Uri Ignore { get; set; }
    }
}
