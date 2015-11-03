using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheLibrary
{
    public interface Iconfig
    {
         
    }

    public class AppConfig : Iconfig
    {
        public string Password { get; set; }

        public string DBName { get; set; }
    }
}
