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
    public class LocalProxies
    {
        private readonly ClientApi _api;

        public LocalProxies(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Gets all of the additional proxies that have been configured.
        /// </summary>
        /// <returns></returns>
        public IApiResponse AdditionalProxies()
        {
            return _api.CallApi("localProxies", "view", "additionalProxies", null);
        }

        /// <summary>
        ///Adds an new proxy using the details supplied.
        /// </summary>
        /// <returns></returns>
        public IApiResponse AddAdditionalProxy(string address, string port, string behindNat, string alwaysDecodeZip, string removeUnsupportedEncodings)
        {
            var parameters = new Dictionary<string, string>
            {
                {"address", address},
                {"port", port},
                {"behindNat", behindNat},
                {"alwaysDecodeZip", alwaysDecodeZip},
                {"removeUnsupportedEncodings", removeUnsupportedEncodings}
            };
            return _api.CallApi("localProxies", "action", "addAdditionalProxy", parameters);
        }

        /// <summary>
        ///Removes the additional proxy with the specified address and port.
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveAdditionalProxy(string address, string port)
        {
            var parameters = new Dictionary<string, string> { { "address", address }, { "port", port } };
            return _api.CallApi("localProxies", "action", "removeAdditionalProxy", parameters);
        }
    }
}
