using System;
using System.Collections.Generic;
using System.Text;

namespace TesisFrontEnd.Services
{
    public class ApiClientFactory
    {
        public static IApiClient GetApiClient(ApiClientType type)
        {
            switch (type)
            {
                case ApiClientType.DebugApiClient:
                    return new DebugApiClient();

                case ApiClientType.OnlineApiClient:
                    return null;

                case ApiClientType.OfflineApiClient:
                    return null;

                default:
                    return new DebugApiClient();
            }
        }
    }
}
