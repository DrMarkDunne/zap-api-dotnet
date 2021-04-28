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
    public class Authorization
    {
        private readonly ClientApi _api;

        public Authorization(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Obtains all the configuration of the authorization detection method that is currently set for a context.
        /// </summary>
        /// <returns></returns>
        public IApiResponse GetAuthorizationDetectionMethod(string contextId)
        {
            var parameters = new Dictionary<string, string> { { "contextId", contextId } };
            return _api.CallApi("authorization", "view", "getAuthorizationDetectionMethod", parameters);
        }

        /// <summary>
        ///Sets the authorization detection method for a context as one that identifies un-authorized messages based on: the message's status code or a regex pattern in the response's header or body. Also, whether all conditions must match or just some can be specified via the logicalOperator parameter, which accepts two values: "AND" (default), "OR".  
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetBasicAuthorizationDetectionMethod(string contextId, string headerRegex, string bodyRegex, string statusCode, string logicalOperator)
        {
            var parameters = new Dictionary<string, string>
            {
                {"contextId", contextId},
                {"headerRegex", headerRegex},
                {"bodyRegex", bodyRegex},
                {"statusCode", statusCode},
                {"logicalOperator", logicalOperator}
            };
            return _api.CallApi("authorization", "action", "setBasicAuthorizationDetectionMethod", parameters);
        }
    }
}
