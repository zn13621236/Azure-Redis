using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheLibrary
{
    abstract class AzureTemplate<T>
    {

        public abstract T GetClient();

        public abstract string Get();

        public abstract void Set(string key, string value);
    }
}
