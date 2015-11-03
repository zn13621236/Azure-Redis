using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheLibrary
{
    abstract class CacheTemplate<T> 
    {
        public abstract T GetDB();

    }


}
