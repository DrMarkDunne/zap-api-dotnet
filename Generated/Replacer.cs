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
    public class Replacer
    {
        private readonly ClientApi _api;

        public Replacer(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Returns full details of all of the rules
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse Rules()
        {
            return _api.CallApi("replacer", "view", "rules", null);
        }

        /// <summary>
        ///Adds a replacer rule. For the parameters: desc is a user friendly description, enabled is true or false, matchType is one of [REQ_HEADER, REQ_HEADER_STR, REQ_BODY_STR, RESP_HEADER, RESP_HEADER_STR, RESP_BODY_STR], matchRegex should be true if the matchString should be treated as a regex otherwise false, matchString is the string that will be matched against, replacement is the replacement string, initiators may be blank (for all initiators) or a comma separated list of integers as defined in <a href="https://github.com/zaproxy/zaproxy/blob/develop/zap/src/main/java/org/parosproxy/paros/network/HttpSender.java">HttpSender</a>  
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse AddRule(string description, string enabled, string matchType, string matchRegex, string matchString, string replacement, string initiators)
        {
            var parameters = new Dictionary<string, string>
            {
                {"description", description},
                {"enabled", enabled},
                {"matchType", matchType},
                {"matchRegex", matchRegex},
                {"matchString", matchString},
                {"replacement", replacement},
                {"initiators", initiators}
            };
            return _api.CallApi("replacer", "action", "addRule", parameters);
        }

        /// <summary>
        ///Removes the rule with the given description
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveRule(string description)
        {
            var parameters = new Dictionary<string, string> { { "description", description } };
            return _api.CallApi("replacer", "action", "removeRule", parameters);
        }

        /// <summary>
        ///Enables or disables the rule with the given description based on the bool parameter  
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetEnabled(string description, string boolean)
        {
            var parameters = new Dictionary<string, string> { { "description", description }, { "bool", boolean } };
            return _api.CallApi("replacer", "action", "setEnabled", parameters);
        }
    }
}
