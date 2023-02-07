using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoropechatanie
{
    public class Info
    {
        static public string Name;
        static public double SymbMin;
        static public double SymbSec;

        public Info(string  name, double min, double sec)
        {
            Name = name;
            SymbMin = min;
            SymbSec = sec;
        }
        public Info()
        {

        }
    }
}
