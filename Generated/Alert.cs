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
    public class Alert
    {
        private readonly ClientApi _api;

        public Alert(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Gets the alert with the given ID, the corresponding HTTP message can be obtained with the 'messageId' field and 'message' API method
        /// </summary>
        /// <returns></returns>
        public IApiResponse GetAlert(string id)
        {
            var parameters = new Dictionary<string, string> { { "id", id } };
            return _api.CallApi("alert", "view", "alert", parameters);
        }

        /// <summary>
        ///Gets the alerts raised by ZAP, optionally filtering by URL or riskId, and paginating with 'start' position and 'count' of alerts
        /// </summary>
        /// <returns></returns>
        public IApiResponse Alerts(string baseUrl, string start, string count, string riskId)
        {
            var parameters = new Dictionary<string, string>
            {
                {"baseUrl", baseUrl}, {"start", start}, {"count", count}, {"riskId", riskId}
            };
            return _api.CallApi("alert", "view", "alerts", parameters);
        }

        /// <summary>
        ///Gets number of alerts grouped by each risk level, optionally filtering by URL
        /// </summary>
        /// <returns></returns>
        public IApiResponse AlertsSummary(string baseUrl)
        {
            var parameters = new Dictionary<string, string> { { "baseUrl", baseUrl } };
            return _api.CallApi("alert", "view", "alertsSummary", parameters);
        }

        /// <summary>
        ///Gets the number of alerts, optionally filtering by URL or riskId
        /// </summary>
        /// <returns></returns>
        public IApiResponse NumberOfAlerts(string baseUrl, string riskId)
        {
            var parameters = new Dictionary<string, string>
            {
                { "baseUrl", baseUrl },
                { "riskId", riskId }
            };
            return _api.CallApi("alert", "view", "numberOfAlerts", parameters);
        }

        /// <summary>
        ///Gets a summary of the alerts, optionally filtered by a 'url'. If 'recurse' is true then all alerts that apply to urls that start with the specified 'url' will be returned, otherwise only those on exactly the same 'url' (ignoring url parameters)
        /// </summary>
        /// <returns></returns>
        public IApiResponse AlertsByRisk(string url, string recurse)
        {
            var parameters = new Dictionary<string, string> { { "url", url }, { "recurse", recurse } };
            return _api.CallApi("alert", "view", "alertsByRisk", parameters);
        }

        /// <summary>
        ///Gets a count of the alerts, optionally filtered as per alertsPerRisk
        /// </summary>
        /// <returns></returns>
        public IApiResponse AlertCountsByRisk(string url, string recurse)
        {
            var parameters = new Dictionary<string, string>
            {
                { "url", url },
                { "recurse", recurse }
            };
            return _api.CallApi("alert", "view", "alertCountsByRisk", parameters);
        }

        /// <summary>
        ///Deletes all alerts of the current session.
        /// </summary>
        /// <returns></returns>
        public IApiResponse DeleteAllAlerts()
        {
            return _api.CallApi("alert", "action", "deleteAllAlerts", null);
        }

        /// <summary>
        ///Deletes the alert with the given ID. 
        /// </summary>
        /// <returns></returns>
        public IApiResponse DeleteAlert(string id)
        {
            var parameters = new Dictionary<string, string>
            {
                { "id", id }
            };
            return _api.CallApi("alert", "action", "deleteAlert", parameters);
        }

    }
}
