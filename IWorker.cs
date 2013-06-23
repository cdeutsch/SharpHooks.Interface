using System;

namespace SharpHooks.Interface
{
    public interface IWorker
    {
        void Start(IJob job);
    }
}
