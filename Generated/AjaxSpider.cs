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
    public class AjaxSpider
    {
        private readonly ClientApi _api;

        public AjaxSpider(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse Status()
        {
            return _api.CallApi("ajaxSpider", "view", "status", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse Results(string start, string count)
        {
            var parameters = new Dictionary<string, string> { { "start", start }, { "count", count } };
            return _api.CallApi("ajaxSpider", "view", "results", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse NumberOfResults()
        {
            return _api.CallApi("ajaxSpider", "view", "numberOfResults", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse FullResults()
        {
            return _api.CallApi("ajaxSpider", "view", "fullResults", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionBrowserId()
        {
            return _api.CallApi("ajaxSpider", "view", "optionBrowserId", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionEventWait()
        {
            return _api.CallApi("ajaxSpider", "view", "optionEventWait", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMaxCrawlDepth()
        {
            return _api.CallApi("ajaxSpider", "view", "optionMaxCrawlDepth", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMaxCrawlStates()
        {
            return _api.CallApi("ajaxSpider", "view", "optionMaxCrawlStates", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMaxDuration()
        {
            return _api.CallApi("ajaxSpider", "view", "optionMaxDuration", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionNumberOfBrowsers()
        {
            return _api.CallApi("ajaxSpider", "view", "optionNumberOfBrowsers", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionReloadWait()
        {
            return _api.CallApi("ajaxSpider", "view", "optionReloadWait", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionClickDefaultElems()
        {
            return _api.CallApi("ajaxSpider", "view", "optionClickDefaultElems", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionClickElemsOnce()
        {
            return _api.CallApi("ajaxSpider", "view", "optionClickElemsOnce", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionRandomInputs()
        {
            return _api.CallApi("ajaxSpider", "view", "optionRandomInputs", null);
        }

        /// <summary>
        ///Runs the spider against the given URL and/or context, optionally, spidering everything in scope. The parameter 'contextName' can be used to constrain the scan to a Context, the option 'in scope' is ignored if a context was also specified. The parameter 'subtreeOnly' allows to restrict the spider under a site's subtree (using the specified 'url').
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse Scan(string url, string inScope, string contextName, string subtreeOnly)
        {
            var parameters = new Dictionary<string, string>
            {
                {"url", url}, {"inScope", inScope}, {"contextName", contextName}, {"subtreeOnly", subtreeOnly}
            };
            return _api.CallApi("ajaxSpider", "action", "scan", parameters);
        }

        /// <summary>
        ///Runs the spider from the perspective of a User, obtained using the given context name and user name. The parameter 'url' allows to specify the starting point for the spider, otherwise it's used an existing URL from the context (if any). The parameter 'subtreeOnly' allows to restrict the spider under a site's subtree (using the specified 'url').
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse ScanAsUser(string contextName, string username, string url, string subtreeOnly)
        {
            var parameters = new Dictionary<string, string>
            {
                {"contextName", contextName}, {"userName", username}, {"url", url}, {"subtreeOnly", subtreeOnly}
            };
            return _api.CallApi("ajaxSpider", "action", "scanAsUser", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse Stop()
        {
            return _api.CallApi("ajaxSpider", "action", "stop", null);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionBrowserId(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("ajaxSpider", "action", "setOptionBrowserId", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionClickDefaultElems(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("ajaxSpider", "action", "setOptionClickDefaultElems", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionClickElemsOnce(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("ajaxSpider", "action", "setOptionClickElemsOnce", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionEventWait(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ajaxSpider", "action", "setOptionEventWait", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMaxCrawlDepth(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ajaxSpider", "action", "setOptionMaxCrawlDepth", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMaxCrawlStates(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ajaxSpider", "action", "setOptionMaxCrawlStates", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMaxDuration(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ajaxSpider", "action", "setOptionMaxDuration", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionNumberOfBrowsers(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ajaxSpider", "action", "setOptionNumberOfBrowsers", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionRandomInputs(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("ajaxSpider", "action", "setOptionRandomInputs", parameters);
        }

        /// <summary>
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionReloadWait(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ajaxSpider", "action", "setOptionReloadWait", parameters);
        }

    }
}
