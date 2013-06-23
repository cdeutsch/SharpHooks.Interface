using System;
using System.Collections.Generic;

namespace SharpHooks.Interface
{
    public interface IJob
    {
        ILogger Logger { get; }

        ITools Tools { get; }

        
        void Status(int percentComplete, string message = null);

        void Warn(string message = null);

        void Fail(string message = null);

        T JsonBodyToObject<T>();

        bool CancellationPending { get; set; }

        string StatusMessage { get; set; }

        string Body { get; }

        byte[] BodyRawBytes { get; }

        IDictionary<string, string> RequestData { get; }

        string AppName { get; }

        string QueueUrl { get; }

        string WorkerId { get; }

        string WorkerUrl { get; }
    }
}
