﻿/* Zed Attack Proxy (ZAP) and its related class files.
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
using System;
using System.Xml;

namespace OWASPZAPDotNetAPI
{
    internal static class ApiResponseFactory
    {
        public static IApiResponse GetResponse(XmlNode node)
        {
            if (node == null || node.Attributes!.Count < 0)
                throw new ArgumentException(null, nameof(node));

            var typeNode = node.Attributes.GetNamedItem("type");

            if (typeNode == null) return new ApiResponseElement(node);
            var type = typeNode.Value;

            switch (type)
            {
                case "list":
                    return new ApiResponseList(node);
                case "set":
                    return new ApiResponseSet(node);
                case "exception":
                    var exceptionString = GetExceptionString(node);
                    throw new Exception(exceptionString);
            }

            return new ApiResponseElement(node);
        }

        private static string GetExceptionString(XmlNode node)
        {
            var attributes = node.Attributes;
            var code = attributes?.GetNamedItem("code") != null ? attributes.GetNamedItem("code")?.Value : "0";
            var detail = attributes?.GetNamedItem("detail") != null ? attributes.GetNamedItem("detail")?.Value : string.Empty;
            var text = node.Value ?? node.InnerText;
            return code + Environment.NewLine + detail + Environment.NewLine + text;
        }
    }
}
