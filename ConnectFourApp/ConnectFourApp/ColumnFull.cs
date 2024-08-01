using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourApp
{
    internal class ColumnFull : Exception
    {
        public ColumnFull() { }
        public ColumnFull(string m) : base(m) { }
    }
}
