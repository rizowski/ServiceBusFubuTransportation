using System;
using System.Collections.Generic;
using FubuTransportation.Polling;

namespace MyFT.Jobs
{
    public class ImNeedyJob : IJob
    {
        #region Secrets
        private readonly Dictionary<int, string> _sayings = new Dictionary<int, string>
        {
            {1, "Hi!"},
            {2, "Can I love you?"},
            {3, "I reaaaaally like you!"},
            {4, "Why Don't you return my 0's and 1's??"},
            {5, "Hi!"}
        };
        private string Random()
        {
            var rand = new Random();
            var index = rand.Next(1, 5);
            return _sayings[index];

        }
        #endregion

        public void Execute()
        {
            Console.WriteLine(Random());
        }
    }
}
