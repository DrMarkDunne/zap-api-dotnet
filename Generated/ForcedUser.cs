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
using System;
using System.Collections.Generic;


/*
 * This file was automatically generated.
 */
namespace OWASPZAPDotNetAPI.Generated
{
    public class ForcedUser
    {
        private readonly ClientApi _api;

        public ForcedUser(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Returns 'true' if 'forced user' mode is enabled, 'false' otherwise
        /// </summary>
        /// <returns></returns>
        public IApiResponse IsForcedUserModeEnabled()
        {
            return _api.CallApi("forcedUser", "view", "isForcedUserModeEnabled", null);
        }

        /// <summary>
        ///Gets the user (ID) set as 'forced user' for the given context (ID)
        /// </summary>
        /// <returns></returns>
        public IApiResponse GetForcedUser(string contextId)
        {
            var parameters = new Dictionary<string, string> { { "contextId", contextId } };
            return _api.CallApi("forcedUser", "view", "getForcedUser", parameters);
        }

        /// <summary>
        ///Sets the user (ID) that should be used in 'forced user' mode for the given context (ID)
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetForcedUser(string contextId, string userid)
        {
            var parameters = new Dictionary<string, string> { { "contextId", contextId }, { "userId", userid } };
            return _api.CallApi("forcedUser", "action", "setForcedUser", parameters);
        }

        /// <summary>
        ///Sets if 'forced user' mode should be enabled or not
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetForcedUserModeEnabled(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "boolean", Convert.ToString(boolean) } };
            return _api.CallApi("forcedUser", "action", "setForcedUserModeEnabled", parameters);
        }
    }
}
