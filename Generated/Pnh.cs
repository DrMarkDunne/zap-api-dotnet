/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright 2019 the ZAP development team
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
using System.Collections.Generic;


/*
 * This file was automatically generated.
 */
namespace OWASPZAPDotNetAPI.Generated
{
    public class Pnh
    {
        private readonly ClientApi _api;

        public Pnh(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse Monitor(string id, string message)
        {
            var parameters = new Dictionary<string, string> { { "id", id }, { "message", message } };
            return _api.CallApi("pnh", "action", "monitor", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse Oracle(string id)
        {
            var parameters = new Dictionary<string, string> { { "id", id } };
            return _api.CallApi("pnh", "action", "oracle", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse StartMonitoring(string url)
        {
            var parameters = new Dictionary<string, string> { { "url", url } };
            return _api.CallApi("pnh", "action", "startMonitoring", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse StopMonitoring(string id)
        {
            var parameters = new Dictionary<string, string> { { "id", id } };
            return _api.CallApi("pnh", "action", "stopMonitoring", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public byte[] PnhMethod()
        {
            return _api.CallApiOther("pnh", "other", "pnh", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public byte[] Manifest()
        {
            return _api.CallApiOther("pnh", "other", "manifest", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public byte[] Service()
        {
            return _api.CallApiOther("pnh", "other", "service", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public byte[] FxPnhXpi()
        {
            return _api.CallApiOther("pnh", "other", "fx_pnh.xpi", null);
        }
    }
}
