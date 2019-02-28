using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Protocol;

namespace ThriftDecoder.Thrift
{
    public interface TProcessor
    {
        bool Process(TProtocol iprot, TProtocol oprot);
    }
}
