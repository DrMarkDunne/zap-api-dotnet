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
    public class Acsrf
    {
        private readonly ClientApi _api;

        public Acsrf(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Lists the names of all anti-CSRF tokens
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionTokensNames()
        {
            return _api.CallApi("acsrf", "view", "optionTokensNames", null);
        }

        /// <summary>
        ///Adds an anti-CSRF token with the given name, enabled by default
        /// </summary>
        /// <returns></returns>
        public IApiResponse AddOptionToken(string str)
        {
            var parameters = new Dictionary<string, string>
            {
                { "String", str }
            };
            return _api.CallApi("acsrf", "action", "addOptionToken", parameters);
        }

        /// <summary>
        ///Removes the anti-CSRF token with the given name
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveOptionToken(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("acsrf", "action", "removeOptionToken", parameters);
        }

        /// <summary>
        ///Generate a form for testing lack of anti-CSRF tokens - typically invoked via ZAP
        /// </summary>
        /// <returns></returns>
        public byte[] GenForm(string hrefId)
        {
            var parameters = new Dictionary<string, string> { { "hrefId", hrefId } };
            return _api.CallApiOther("acsrf", "other", "genForm", parameters);
        }

    }
}
