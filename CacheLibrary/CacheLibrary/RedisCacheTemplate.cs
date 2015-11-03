using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace CacheLibrary
{
    class RedisCacheTemplate<T> : CacheTemplate<IDatabase>
    {
        private static Iconfig _Config;

        private static readonly Lazy<ConnectionMultiplexer> LazyConnection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(_Config+"contoso5.redis.cache.windows.net,abortConnect=false,ssl=true,password=..."));

        public static ConnectionMultiplexer Connection => LazyConnection.Value;


        public RedisCacheTemplate(Iconfig config)
        {
            _Config = config;
        }

        public override IDatabase GetDB()
        {
          return Connection.GetDatabase();
        }

        public T Get(string key)
        {
           string result= GetDB().StringGet(key);
           return JsonConvert.DeserializeObject<T>(result);
        }

        public void Set(string key, T t)
        {
            var value = JsonConvert.SerializeObject(t);
            GetDB().StringSet(key, value);
        }
    }


}
