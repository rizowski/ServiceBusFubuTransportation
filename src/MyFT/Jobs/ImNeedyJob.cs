using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FubuTransportation.Polling;

namespace MyFT.Jobs
{
    public class ImNeedyJob : IJob
    {
        #region Secrets
        private readonly Dictionary<int, string> Sayings = new Dictionary<int, string>
        {
            {1, "Hi!"},
            {2, "Can I love you?"},
            {3, "I reaaaaally like you!"},
            {4, "Why Don't you return my 0's and 1's??"},
            {5, "Hi!"}
        };
        #endregion

        public void Execute()
        {
            Console.WriteLine(Random());
        }

        private string Random()
        {
            var rand = new Random();
            var index = rand.Next(1, 5);
            return Sayings[index];

        }
    }
}
