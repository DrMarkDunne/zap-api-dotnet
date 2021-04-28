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
    public class Break
    {
        private readonly ClientApi _api;

        public Break(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Returns True if ZAP will break on both requests and responses
        /// </summary>
        /// <returns></returns>
        public IApiResponse IsBreakAll()
        {
            return _api.CallApi("break", "view", "isBreakAll", null);
        }

        /// <summary>
        ///Returns True if ZAP will break on requests
        /// </summary>
        /// <returns></returns>
        public IApiResponse IsBreakRequest()
        {
            return _api.CallApi("break", "view", "isBreakRequest", null);
        }

        /// <summary>
        ///Returns True if ZAP will break on responses
        /// </summary>
        /// <returns></returns>
        public IApiResponse IsBreakResponse()
        {
            return _api.CallApi("break", "view", "isBreakResponse", null);
        }

        /// <summary>
        ///Returns the HTTP message currently intercepted (if any)
        /// </summary>
        /// <returns></returns>
        public IApiResponse HttpMessage()
        {
            return _api.CallApi("break", "view", "httpMessage", null);
        }

        /// <summary>
        ///Controls the global break functionality. The type may be one of: http-all, http-request or http-response. The state may be true (for turning break on for the specified type) or false (for turning break off). Scope is not currently used.
        /// </summary>
        /// <returns></returns>
        public IApiResponse Brk(string type, string state, string scope)
        {
            var parameters = new Dictionary<string, string> { { "type", type }, { "state", state }, { "scope", scope } };
            return _api.CallApi("break", "action", "break", parameters);
        }

        /// <summary>
        ///Overwrites the currently intercepted message with the data provided
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetHttpMessage(string httpHeader, string httpBody)
        {
            var parameters = new Dictionary<string, string> { { "httpHeader", httpHeader }, { "httpBody", httpBody } };
            return _api.CallApi("break", "action", "setHttpMessage", parameters);
        }

        /// <summary>
        ///Submits the currently intercepted message and unsets the global request/response break points
        /// </summary>
        /// <returns></returns>
        public IApiResponse Cont()
        {
            return _api.CallApi("break", "action", "continue", null);
        }

        /// <summary>
        ///Submits the currently intercepted message, the next request or response will automatically be intercepted
        /// </summary>
        /// <returns></returns>
        public IApiResponse Step()
        {
            return _api.CallApi("break", "action", "step", null);
        }

        /// <summary>
        ///Drops the currently intercepted message
        /// </summary>
        /// <returns></returns>
        public IApiResponse Drop()
        {
            return _api.CallApi("break", "action", "drop", null);
        }

        /// <summary>
        ///Adds a custom HTTP breakpoint. The string is the string to match. Location may be one of: url, request_header, request_body, response_header or response_body. Match may be: contains or regex. Inverse (match) may be true or false. Lastly, ignorecase (when matching the string) may be true or false.  
        /// </summary>
        /// <returns></returns>
        public IApiResponse AddHttpBreakpoint(string str, string location, string match, string inverse, string ignorecase)
        {
            var parameters = new Dictionary<string, string>
            {
                {"string", str},
                {"location", location},
                {"match", match},
                {"inverse", inverse},
                {"ignorecase", ignorecase}
            };
            return _api.CallApi("break", "action", "addHttpBreakpoint", parameters);
        }

        /// <summary>
        ///Removes the specified break point
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveHttpBreakpoint(string str, string location, string match, string inverse, string ignorecase)
        {
            var parameters = new Dictionary<string, string>
            {
                { "string", str },
                { "location", location },
                { "match", match },
                { "inverse", inverse },
                { "ignorecase", ignorecase }
            };
            return _api.CallApi("break", "action", "removeHttpBreakpoint", parameters);
        }
    }
}
