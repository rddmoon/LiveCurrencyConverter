using System;
using System.Net;

namespace Convertion
{
    class API
    {
        private string url;
        private WebClient client;

        public API(string url)
        {
            this.url = url;
            this.client = new WebClient();
        }

        public string SendAndGetResponse()
        {
            return client.DownloadString(url);
        }
    }
}