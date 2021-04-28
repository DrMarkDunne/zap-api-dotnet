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
    public class Authentication
    {
        private readonly ClientApi _api;

        public Authentication(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Gets the name of the authentication methods.
        /// </summary>
        /// <returns></returns>
        public IApiResponse GetSupportedAuthenticationMethods()
        {
            return _api.CallApi("authentication", "view", "getSupportedAuthenticationMethods", null);
        }

        /// <summary>
        ///Gets the configuration parameters for the authentication method with the given name.
        /// </summary>
        /// <returns></returns>
        public IApiResponse GetAuthenticationMethodConfigParams(string authMethodName)
        {

            var parameters = new Dictionary<string, string> { { "authMethodName", authMethodName } };
            return _api.CallApi("authentication", "view", "getAuthenticationMethodConfigParams", parameters);
        }

        /// <summary>
        ///Gets the name of the authentication method for the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse GetAuthenticationMethod(string contextId)
        {

            var parameters = new Dictionary<string, string> { { "contextId", contextId } };
            return _api.CallApi("authentication", "view", "getAuthenticationMethod", parameters);
        }

        /// <summary>
        ///Gets the logged in indicator for the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse GetLoggedInIndicator(string contextId)
        {

            var parameters = new Dictionary<string, string> { { "contextId", contextId } };
            return _api.CallApi("authentication", "view", "getLoggedInIndicator", parameters);
        }

        /// <summary>
        ///Gets the logged out indicator for the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse GetLoggedOutIndicator(string contextId)
        {

            var parameters = new Dictionary<string, string> { { "contextId", contextId } };
            return _api.CallApi("authentication", "view", "getLoggedOutIndicator", parameters);
        }

        /// <summary>
        ///Sets the authentication method for the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetAuthenticationMethod(string contextId, string authMethodName, string authMethodConfigParams)
        {

            var parameters = new Dictionary<string, string>
            {
                {"contextId", contextId},
                {"authMethodName", authMethodName},
                {"authMethodConfigParams", authMethodConfigParams}
            };
            return _api.CallApi("authentication", "action", "setAuthenticationMethod", parameters);
        }

        /// <summary>
        ///Sets the logged in indicator for the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetLoggedInIndicator(string contextId, string loggedInIndicatorRegex)
        {

            var parameters = new Dictionary<string, string>
            {
                {"contextId", contextId}, {"loggedInIndicatorRegex", loggedInIndicatorRegex}
            };
            return _api.CallApi("authentication", "action", "setLoggedInIndicator", parameters);
        }

        /// <summary>
        ///Sets the logged out indicator for the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetLoggedOutIndicator(string contextId, string loggedOutIndicatorRegex)
        {

            var parameters = new Dictionary<string, string>
            {
                {"contextId", contextId}, {"loggedOutIndicatorRegex", loggedOutIndicatorRegex}
            };
            return _api.CallApi("authentication", "action", "setLoggedOutIndicator", parameters);
        }

    }
}
