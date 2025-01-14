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
    public class Params
    {
        private readonly ClientApi _api;

        public Params(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Shows the parameters for the specified site, or for all sites if the site is not specified
        /// </summary>
        /// <returns></returns>
        public IApiResponse Parameters(string site)
        {
            var parameters = new Dictionary<string, string> { { "site", site } };
            return _api.CallApi("params", "view", "params", parameters);
        }

    }
}
