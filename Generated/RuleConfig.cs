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
    public class RuleConfig
    {
        private readonly ClientApi _api;

        public RuleConfig(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Show the specified rule configuration
        /// </summary>
        /// <returns></returns>
        public IApiResponse RuleConfigValue(string key)
        {
            var parameters = new Dictionary<string, string> { { "key", key } };
            return _api.CallApi("ruleConfig", "view", "ruleConfigValue", parameters);
        }

        /// <summary>
        ///Show all of the rule configurations
        /// </summary>
        /// <returns></returns>
        public IApiResponse AllRuleConfigs()
        {
            return _api.CallApi("ruleConfig", "view", "allRuleConfigs", null);
        }

        /// <summary>
        ///Reset the specified rule configuration, which must already exist
        /// </summary>
        /// <returns></returns>
        public IApiResponse ResetRuleConfigValue(string key)
        {
            var parameters = new Dictionary<string, string> { { "key", key } };
            return _api.CallApi("ruleConfig", "action", "resetRuleConfigValue", parameters);
        }

        /// <summary>
        ///Reset all of the rule configurations
        /// </summary>
        /// <returns></returns>
        public IApiResponse ResetAllRuleConfigValues()
        {
            return _api.CallApi("ruleConfig", "action", "resetAllRuleConfigValues", null);
        }

        /// <summary>
        ///Set the specified rule configuration, which must already exist
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetRuleConfigValue(string key, string value)
        {
            var parameters = new Dictionary<string, string> { { "key", key }, { "value", value } };
            return _api.CallApi("ruleConfig", "action", "setRuleConfigValue", parameters);
        }
    }
}
