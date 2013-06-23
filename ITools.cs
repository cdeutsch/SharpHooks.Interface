using System;
using System.Collections.Generic;
using System.Text;

namespace SharpHooks.Interface
{
    public interface ITools
    {
        string SerializeJson(object obj);

        T DeserializeJson<T>(string value);

        IRestResponse ExecuteRestRequest(string url, object data);

        IRestResponse<T> ExecuteRestRequest<T>(string url, object data) where T : new();

    }
}
