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
    public class Stats
    {
        private readonly ClientApi _api;

        public Stats(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Statistics
        /// </summary>
        /// <returns></returns>
        public IApiResponse ReturnStats(string keyPrefix)
        {
            var parameters = new Dictionary<string, string> { { "keyPrefix", keyPrefix } };
            return _api.CallApi("stats", "view", "stats", parameters);
        }

        /// <summary>
        ///Gets all of the site based statistics, optionally filtered by a key prefix
        /// </summary>
        /// <returns></returns>
        public IApiResponse AllSitesStats(string keyPrefix)
        {
            var parameters = new Dictionary<string, string> { { "keyPrefix", keyPrefix } };
            return _api.CallApi("stats", "view", "allSitesStats", parameters);
        }

        /// <summary>
        ///Gets all of the global statistics, optionally filtered by a key prefix
        /// </summary>
        /// <returns></returns>
        public IApiResponse SiteStats(string site, string keyPrefix)
        {
            var parameters = new Dictionary<string, string> { { "site", site }, { "keyPrefix", keyPrefix } };
            return _api.CallApi("stats", "view", "siteStats", parameters);
        }

        /// <summary>
        ///Gets the Stated service hostname
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionStatedHost()
        {
            return _api.CallApi("stats", "view", "optionStatedHost", null);
        }

        /// <summary>
        ///Gets the Stated service port
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionStatedPort()
        {
            return _api.CallApi("stats", "view", "optionStatedPort", null);
        }

        /// <summary>
        ///Gets the prefix to be applied to all stats sent to the configured Stated service
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionStatedPrefix()
        {
            return _api.CallApi("stats", "view", "optionStatedPrefix", null);
        }

        /// <summary>
        ///Returns 'true' if in memory statistics are enabled, otherwise returns 'false'
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionInMemoryEnabled()
        {
            return _api.CallApi("stats", "view", "optionInMemoryEnabled", null);
        }

        /// <summary>
        ///Returns 'true' if a Stated server has been correctly configured, otherwise returns 'false'
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionStatedEnabled()
        {
            return _api.CallApi("stats", "view", "optionStatedEnabled", null);
        }

        /// <summary>
        ///Clears all of the statistics
        /// </summary>
        /// <returns></returns>
        public IApiResponse ClearStats(string keyPrefix)
        {
            var parameters = new Dictionary<string, string> { { "keyPrefix", keyPrefix } };
            return _api.CallApi("stats", "action", "clearStats", parameters: parameters);
        }

        /// <summary>
        ///Sets the Stated service hostname, supply an empty string to stop using a Stated service
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionStatedHost(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("stats", "action", "setOptionStatedHost", parameters: parameters);
        }

        /// <summary>
        ///Sets the prefix to be applied to all stats sent to the configured Stated service
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionStatedPrefix(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("stats", "action", "setOptionStatedPrefix", parameters: parameters);
        }

        /// <summary>
        ///Sets whether in memory statistics are enabled
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionInMemoryEnabled(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("stats", "action", "setOptionInMemoryEnabled", parameters: parameters);
        }

        /// <summary>
        ///Sets the Stated service port
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionStatedPort(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("stats", "action", "setOptionStatedPort", parameters: parameters);
        }

    }
}
