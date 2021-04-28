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
    public class Search
    {
        private readonly ClientApi _api;

        public Search(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Returns the URLs of the HTTP messages that match the given regular expression in the URL optionally filtered by URL and paginated with 'start' position and 'count' of messages.
        /// </summary>
        /// <returns></returns>
        public IApiResponse UrlsByUrlRegex(string regex, string baseUrl, string start, string count)
        {
            var parameters = new Dictionary<string, string>
            {
                {"regex", regex}, {"baseUrl", baseUrl}, {"start", start}, {"count", count}
            };
            return _api.CallApi("search", "view", "urlsByUrlRegex", parameters);
        }

        /// <summary>
        ///Returns the URLs of the HTTP messages that match the given regular expression in the request optionally filtered by URL and paginated with 'start' position and 'count' of messages.
        /// </summary>
        /// <returns></returns>
        public IApiResponse UrlsByRequestRegex(string regex, string baseUrl, string start, string count)
        {
            var parameters = new Dictionary<string, string>
            {
                {"regex", regex}, {"baseUrl", baseUrl}, {"start", start}, {"count", count}
            };
            return _api.CallApi("search", "view", "urlsByRequestRegex", parameters);
        }

        /// <summary>
        ///Returns the URLs of the HTTP messages that match the given regular expression in the response optionally filtered by URL and paginated with 'start' position and 'count' of messages.
        /// </summary>
        /// <returns></returns>
        public IApiResponse UrlsByResponseRegex(string regex, string baseUrl, string start, string count)
        {
            var parameters = new Dictionary<string, string>
            {
                {"regex", regex}, {"baseUrl", baseUrl}, {"start", start}, {"count", count}
            };
            return _api.CallApi("search", "view", "urlsByResponseRegex", parameters);
        }

        /// <summary>
        ///Returns the URLs of the HTTP messages that match the given regular expression in the header(s) optionally filtered by URL and paginated with 'start' position and 'count' of messages.
        /// </summary>
        /// <returns></returns>
        public IApiResponse UrlsByHeaderRegex(string regex, string baseUrl, string start, string count)
        {
            var parameters = new Dictionary<string, string>
            {
                {"regex", regex}, {"baseUrl", baseUrl}, {"start", start}, {"count", count}
            };
            return _api.CallApi("search", "view", "urlsByHeaderRegex", parameters);
        }

        /// <summary>
        ///Returns the HTTP messages that match the given regular expression in the URL optionally filtered by URL and paginated with 'start' position and 'count' of messages.
        /// </summary>
        /// <returns></returns>
        public IApiResponse MessagesByUrlRegex(string regex, string baseUrl, string start, string count)
        {
            var parameters = new Dictionary<string, string>
            {
                {"regex", regex}, {"baseUrl", baseUrl}, {"start", start}, {"count", count}
            };
            return _api.CallApi("search", "view", "messagesByUrlRegex", parameters);
        }

        /// <summary>
        ///Returns the HTTP messages that match the given regular expression in the request optionally filtered by URL and paginated with 'start' position and 'count' of messages.
        /// </summary>
        /// <returns></returns>
        public IApiResponse MessagesByRequestRegex(string regex, string baseUrl, string start, string count)
        {
            var parameters = new Dictionary<string, string>
            {
                {"regex", regex}, {"baseUrl", baseUrl}, {"start", start}, {"count", count}
            };
            return _api.CallApi("search", "view", "messagesByRequestRegex", parameters);
        }

        /// <summary>
        ///Returns the HTTP messages that match the given regular expression in the response optionally filtered by URL and paginated with 'start' position and 'count' of messages.
        /// </summary>
        /// <returns></returns>
        public IApiResponse MessagesByResponseRegex(string regex, string baseUrl, string start, string count)
        {
            var parameters = new Dictionary<string, string>
            {
                {"regex", regex}, {"baseUrl", baseUrl}, {"start", start}, {"count", count}
            };
            return _api.CallApi("search", "view", "messagesByResponseRegex", parameters);
        }

        /// <summary>
        ///Returns the HTTP messages that match the given regular expression in the header(s) optionally filtered by URL and paginated with 'start' position and 'count' of messages.
        /// </summary>
        /// <returns></returns>
        public IApiResponse MessagesByHeaderRegex(string regex, string baseUrl, string start, string count)
        {
            var parameters = new Dictionary<string, string>
            {
                {"regex", regex}, {"baseUrl", baseUrl}, {"start", start}, {"count", count}
            };
            return _api.CallApi("search", "view", "messagesByHeaderRegex", parameters);
        }

        /// <summary>
        ///Returns the HTTP messages, in HAR format, that match the given regular expression in the URL optionally filtered by URL and paginated with 'start' position and 'count' of messages.
        /// </summary>
        /// <returns></returns>
        public byte[] HarByUrlRegex(string regex, string baseUrl, string start, string count)
        {
            var parameters = new Dictionary<string, string>
            {
                {"regex", regex}, {"baseUrl", baseUrl}, {"start", start}, {"count", count}
            };
            return _api.CallApiOther("search", "other", "harByUrlRegex", parameters);
        }

        /// <summary>
        ///Returns the HTTP messages, in HAR format, that match the given regular expression in the request optionally filtered by URL and paginated with 'start' position and 'count' of messages.
        /// </summary>
        /// <returns></returns>
        public byte[] HarByRequestRegex(string regex, string baseUrl, string start, string count)
        {
            var parameters = new Dictionary<string, string>
            {
                {"regex", regex}, {"baseUrl", baseUrl}, {"start", start}, {"count", count}
            };
            return _api.CallApiOther("search", "other", "harByRequestRegex", parameters);
        }

        /// <summary>
        ///Returns the HTTP messages, in HAR format, that match the given regular expression in the response optionally filtered by URL and paginated with 'start' position and 'count' of messages.
        /// </summary>
        /// <returns></returns>
        public byte[] HarByResponseRegex(string regex, string baseUrl, string start, string count)
        {
            var parameters = new Dictionary<string, string>
            {
                {"regex", regex}, {"baseUrl", baseUrl}, {"start", start}, {"count", count}
            };
            return _api.CallApiOther("search", "other", "harByResponseRegex", parameters);
        }

        /// <summary>
        ///Returns the HTTP messages, in HAR format, that match the given regular expression in the header(s) optionally filtered by URL and paginated with 'start' position and 'count' of messages.
        /// </summary>
        /// <returns></returns>
        public byte[] HarByHeaderRegex(string regex, string baseUrl, string start, string count)
        {
            var parameters = new Dictionary<string, string>
            {
                {"regex", regex}, {"baseUrl", baseUrl}, {"start", start}, {"count", count}
            };
            return _api.CallApiOther("search", "other", "harByHeaderRegex", parameters);
        }

    }
}
