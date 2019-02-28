using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftDecoder.Thrift
{
    public class TException : Exception
    {
        public TException()
        {
        }

        public TException(string message) : base(message)
        {
        }
    }
}
