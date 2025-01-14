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
    public class Soap
    {
        private readonly ClientApi _api;

        public Soap(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Import a WSDL definition from local file.
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse ImportFile(string file)
        {
            var parameters = new Dictionary<string, string>
            {
                { "file", file }
            };
            return _api.CallApi("soap", "action", "importFile", parameters);
        }

        /// <summary>
        ///Import a WSDL definition from a URL.
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse ImportUrl(string url)
        {
            var parameters = new Dictionary<string, string> { { "url", url } };
            return _api.CallApi("soap", "action", "importUrl", parameters);
        }

    }
}
