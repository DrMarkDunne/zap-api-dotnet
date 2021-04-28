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
    public class Websocket
    {
        private readonly ClientApi _api;

        public Websocket(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Returns all of the registered web socket channels
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse Channels()
        {
            return _api.CallApi("websocket", "view", "channels", null);
        }

        /// <summary>
        ///Returns full details of the message specified by the channelId and messageId
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse Message(string channelId, string messageId)
        {
            var parameters = new Dictionary<string, string> { { "channelId", channelId }, { "messageId", messageId } };
            return _api.CallApi("websocket", "view", "message", parameters);
        }

        /// <summary>
        ///Returns a list of all of the messages that meet the given criteria (all optional), where channelId is a channel identifier, start is the offset to start returning messages from (starting from 0), count is the number of messages to return (default no limit) and payloadPreviewLength is the maximum number bytes to return for the payload contents
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse Messages(string channelId, string start, string count, string payloadPreviewLength)
        {
            var parameters = new Dictionary<string, string>
            {
                {"channelId", channelId},
                {"start", start},
                {"count", count},
                {"payloadPreviewLength", payloadPreviewLength}
            };
            return _api.CallApi("websocket", "view", "messages", parameters);
        }

        /// <summary>
        ///Returns a text representation of an intercepted websockets message
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse BreakTextMessage()
        {
            return _api.CallApi("websocket", "view", "breakTextMessage", null);
        }

        /// <summary>
        ///Sends the specified message on the channel specified by channelId, if outgoing is 'True' then the message will be sent to the server and if it is 'False' then it will be sent to the client
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SendTextMessage(string channelId, string outgoing, string message)
        {
            var parameters = new Dictionary<string, string>
            {
                { "channelId", channelId },
                { "outgoing", outgoing },
                { "message", message }
            };
            return _api.CallApi("websocket", "action", "sendTextMessage", parameters);
        }

        /// <summary>
        ///Sets the text message for an intercepted websockets message
        ///This component is optional and therefore the API will only work if it is installed
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetBreakTextMessage(string message, string outgoing)
        {
            var parameters = new Dictionary<string, string> { { "message", message }, { "outgoing", outgoing } };
            return _api.CallApi("websocket", "action", "setBreakTextMessage", parameters);
        }
    }
}
