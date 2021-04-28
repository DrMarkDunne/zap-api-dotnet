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
    public class AlertFilter
    {
        private readonly ClientApi _api;

        public AlertFilter(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Lists the alert filters of the context with the given ID.
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse AlertFilterList(string contextId)
        {
            var parameters = new Dictionary<string, string> { { "contextId", contextId } };
            return _api.CallApi("alertFilter", "view", "alertFilterList", parameters);
        }

        /// <summary>
        ///Adds a new alert filter for the context with the given ID. 
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse AddAlertFilter(string contextId, string ruleId, string newLevel, string url, string urlIsRegex, string parameter, string enabled)
        {
            var parameters = new Dictionary<string, string>
            {
                {"contextId", contextId},
                {"ruleId", ruleId},
                {"newLevel", newLevel},
                {"url", url},
                {"urlIsRegex", urlIsRegex},
                {"parameter", parameter},
                {"enabled", enabled}
            };
            return _api.CallApi("alertFilter", "action", "addAlertFilter", parameters);
        }

        /// <summary>
        ///Removes an alert filter from the context with the given ID.
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveAlertFilter(string contextId, string ruleId, string newLevel, string url, string urlIsRegex, string parameter, string enabled)
        {
            var parameters = new Dictionary<string, string>
            {
                {"contextId", contextId},
                {"ruleId", ruleId},
                {"newLevel", newLevel},
                {"url", url},
                {"urlIsRegex", urlIsRegex},
                {"parameter", parameter},
                {"enabled", enabled}
            };
            return _api.CallApi("alertFilter", "action", "removeAlertFilter", parameters);
        }
    }
}
