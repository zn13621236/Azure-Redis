using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace TestCacheClient
{
    class Program
    {
        static void Main(string[] args)
        {

            ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(",abortConnect=false,ssl=true,password=");
            IDatabase cache=connection.GetDatabase();
            cache.StringSet("k1", "123123123123123");
            cache.StringSet("asdf", "zxcvzxcv");

            string r1 = cache.StringGet("k1");
            string r2 = cache.StringGet("asdf");

            string r3 = null;

        }
    }
}
