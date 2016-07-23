using System;
using System.Collections;

namespace Arke.Salesforce.Common
{
    public interface IForceException
    {
        Exception GetBaseException();
        string ToString();
        IDictionary Data { get; }
        Exception InnerException { get; }
        string Message { get; }
        string StackTrace { get; }
    }
}