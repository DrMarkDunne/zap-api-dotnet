/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright the ZAP development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using OWASPZAPDotNetAPI.Interfaces;
using System;
using System.IO;
using System.Net;

namespace OWASPZAPDotNetAPI
{
    public class SystemWebClient : IWebClient, IDisposable
    {
        private readonly WebClient _webClient;

        public SystemWebClient(string proxyHost, int proxyPort)
        {
            var webProxy = new WebProxy(proxyHost, proxyPort);
            _webClient = new WebClient { Proxy = webProxy };
        }

        string IWebClient.DownloadString(string address)
        {
            return _webClient.DownloadString(address);
        }

        string IWebClient.DownloadString(Uri uri)
        {
            var retVal = string.Empty;
            try
            {
                retVal = _webClient.DownloadString(uri);
            }
            catch (WebException webException)
            {
                var responseStream = webException.Response?.GetResponseStream();
                if (responseStream != null)
                {
                    using var reader = new StreamReader(responseStream);
                    retVal = reader.ReadToEnd();
                }
            }

            return retVal;
        }

        byte[] IWebClient.DownloadData(Uri uri)
        {
            var retVal = _webClient.DownloadData(uri);
            return retVal;
        }

        void IDisposable.Dispose()
        {
            _webClient.Dispose();
        }

        void IWebClient.AddRequestHeader(string headerName, string headerValue)
        {
            _webClient.Headers.Add(headerName, headerValue);
        }

        string IWebClient.GetRequestHeaderValue(string headerName)
        {
            return _webClient.Headers.Get(headerName);
        }

        void IWebClient.SetRequestHeader(string headerName, string headerValue)
        {
            _webClient.Headers.Set(headerName, headerValue);
        }
    }
}
