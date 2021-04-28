/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright the ZAP development team
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
using System.Xml;

namespace OWASPZAPDotNetAPI
{
    public class ApiResponseSet : IApiResponse
    {
        string IApiResponse.Name { get; set; }

        public Dictionary<string, string> Dictionary { get; }
        //private string[] attributes; // attributes field is present at org.zaproxy.clientapi.core, but I couldn't track the usage in the java api client, hence ignoring it in the dot net api

        public ApiResponseSet(string name)
        {
            ((IApiResponse)this).Name = name;
        }

        public ApiResponseSet(string name, Dictionary<string, string> dictionary)
        {
            ((IApiResponse)this).Name = name;
            Dictionary = dictionary;
        }

        public ApiResponseSet(XmlNode node)
        {
            ((IApiResponse)this).Name = node.Name;
            var childNode = node.FirstChild;
            Dictionary = new Dictionary<string, string>();
            while (childNode != null)
            {
                var apiResponseElement = (ApiResponseElement)ApiResponseFactory.GetResponse(childNode);
                Dictionary.Add(((IApiResponse)apiResponseElement).Name, apiResponseElement.Value);
                childNode = childNode.NextSibling;
            }
        }
    }
}
