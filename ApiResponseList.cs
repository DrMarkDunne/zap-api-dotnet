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
using System.Linq;
using System.Xml;

namespace OWASPZAPDotNetAPI
{
    public class ApiResponseList : IApiResponse
    {
        string IApiResponse.Name { get; set; }

        public List<IApiResponse> List { get; }

        public ApiResponseList(string name)
        {
            ((IApiResponse)this).Name = name;
            List = new List<IApiResponse>();
        }

        public ApiResponseList(string name, List<IApiResponse> apiResponse)
        {
            ((IApiResponse)this).Name = name;
            List = apiResponse;
        }

        public ApiResponseList(string name, IEnumerable<IApiResponse> apiResponse)
            :
            this(name, apiResponse.ToList())
        {
        }

        public ApiResponseList(XmlNode node)
            :
            this(node.Name)
        {
            var childNode = node.FirstChild;
            while (childNode != null)
            {
                List.Add(ApiResponseFactory.GetResponse(childNode));
                childNode = childNode.NextSibling;
            }
        }
    }
}
