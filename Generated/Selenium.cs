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
    public class Selenium
    {
        private readonly ClientApi _api;

        public Selenium(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Returns the current path to ChromeDriver
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionChromeDriverPath()
        {
            return _api.CallApi("selenium", "view", "optionChromeDriverPath", null);
        }

        /// <summary>
        ///Returns the current path to Firefox binary
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionFirefoxBinaryPath()
        {
            return _api.CallApi("selenium", "view", "optionFirefoxBinaryPath", null);
        }

        /// <summary>
        ///Returns the current path to Firefox driver (geckodriver)
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionFirefoxDriverPath()
        {
            return _api.CallApi("selenium", "view", "optionFirefoxDriverPath", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        [Obsolete("Obsolete")]
        public IApiResponse OptionIeDriverPath()
        {
            return _api.CallApi("selenium", "view", "optionIeDriverPath", null);
        }

        /// <summary>
        ///Returns the current path to PhantomJS binary
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionPhantomJsBinaryPath()
        {
            return _api.CallApi("selenium", "view", "optionPhantomJsBinaryPath", null);
        }

        /// <summary>
        ///Sets the current path to ChromeDriver
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionChromeDriverPath(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("selenium", "action", "setOptionChromeDriverPath", parameters);
        }

        /// <summary>
        ///Sets the current path to Firefox binary
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionFirefoxBinaryPath(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("selenium", "action", "setOptionFirefoxBinaryPath", parameters);
        }

        /// <summary>
        ///Sets the current path to Firefox driver (geckodriver)
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionFirefoxDriverPath(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("selenium", "action", "setOptionFirefoxDriverPath", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        [Obsolete("Obsolete")]
        public IApiResponse SetOptionIeDriverPath(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("selenium", "action", "setOptionIeDriverPath", parameters);
        }

        /// <summary>
        ///Sets the current path to PhantomJS binary
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionPhantomJsBinaryPath(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("selenium", "action", "setOptionPhantomJsBinaryPath", parameters);
        }

    }
}
