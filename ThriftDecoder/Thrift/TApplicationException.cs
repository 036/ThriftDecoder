using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Protocol;

namespace ThriftDecoder.Thrift
{
    public class TApplicationException : TException
    {
        public TApplicationException()
        {
        }

        public TApplicationException(TApplicationException.ExceptionType type)
        {
            this.type = type;
        }

        public TApplicationException(TApplicationException.ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

        public static TApplicationException Read(TProtocol iprot)
        {
            string message = null;
            TApplicationException.ExceptionType exceptionType = TApplicationException.ExceptionType.Unknown;
            iprot.ReadStructBegin();
            for (; ; )
            {
                TField tfield = iprot.ReadFieldBegin();
                if (tfield.Type == TType.Stop)
                {
                    break;
                }
                short id = tfield.ID;
                if (id != 1)
                {
                    if (id != 2)
                    {
                        TProtocolUtil.Skip(iprot, tfield.Type);
                    }
                    else if (tfield.Type == TType.I32)
                    {
                        exceptionType = (TApplicationException.ExceptionType)iprot.ReadI32();
                    }
                    else
                    {
                        TProtocolUtil.Skip(iprot, tfield.Type);
                    }
                }
                else if (tfield.Type == TType.String)
                {
                    message = iprot.ReadString();
                }
                else
                {
                    TProtocolUtil.Skip(iprot, tfield.Type);
                }
                iprot.ReadFieldEnd();
            }
            iprot.ReadStructEnd();
            return new TApplicationException(exceptionType, message);
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("TApplicationException");
            TField field = default(TField);
            oprot.WriteStructBegin(struc);
            if (!string.IsNullOrEmpty(this.Message))
            {
                field.Name = "message";
                field.Type = TType.String;
                field.ID = 1;
                oprot.WriteFieldBegin(field);
                oprot.WriteString(this.Message);
                oprot.WriteFieldEnd();
            }
            field.Name = "type";
            field.Type = TType.I32;
            field.ID = 2;
            oprot.WriteFieldBegin(field);
            oprot.WriteI32((int)this.type);
            oprot.WriteFieldEnd();
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        protected TApplicationException.ExceptionType type;

        public enum ExceptionType
        {
            Unknown,
            UnknownMethod,
            InvalidMessageType,
            WrongMethodName,
            BadSequenceID,
            MissingResult,
            InternalError,
            ProtocolError,
            InvalidTransform,
            InvalidProtocol,
            UnsupportedClientType
        }
    }
}
