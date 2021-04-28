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
    public class SessionManagement
    {
        private readonly ClientApi _api;

        public SessionManagement(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Gets the name of the session management methods.
        /// </summary>
        /// <returns></returns>
        public IApiResponse GetSupportedSessionManagementMethods()
        {
            return _api.CallApi("sessionManagement", "view", "getSupportedSessionManagementMethods", null);
        }

        /// <summary>
        ///Gets the configuration parameters for the session management method with the given name.
        /// </summary>
        /// <returns></returns>
        public IApiResponse GetSessionManagementMethodConfigParams(string methodName)
        {
            var parameters = new Dictionary<string, string> { { "methodName", methodName } };
            return _api.CallApi("sessionManagement", "view", "getSessionManagementMethodConfigParams", parameters);
        }

        /// <summary>
        ///Gets the name of the session management method for the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse GetSessionManagementMethod(string contextId)
        {
            var parameters = new Dictionary<string, string> { { "contextId", contextId } };
            return _api.CallApi("sessionManagement", "view", "getSessionManagementMethod", parameters);
        }

        /// <summary>
        ///Sets the session management method for the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetSessionManagementMethod(string contextId, string methodName, string methodConfigParams)
        {
            var parameters = new Dictionary<string, string>
            {
                {"contextId", contextId}, {"methodName", methodName}, {"methodConfigParams", methodConfigParams}
            };
            return _api.CallApi("sessionManagement", "action", "setSessionManagementMethod", parameters);
        }

    }
}
