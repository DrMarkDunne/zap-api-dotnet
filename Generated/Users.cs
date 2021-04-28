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
    public class Users
    {
        private readonly ClientApi _api;

        public Users(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Gets a list of users that belong to the context with the given ID, or all users if none provided.
        /// </summary>
        /// <returns></returns>
        public IApiResponse UsersList(string contextId)
        {
            var parameters = new Dictionary<string, string>
            {
                { "contextId", contextId }
            };
            return _api.CallApi("users", "view", "usersList", parameters);
        }

        /// <summary>
        ///Gets the data of the user with the given ID that belongs to the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse GetUserById(string contextId, string userid)
        {
            var parameters = new Dictionary<string, string>
            {
                { "contextId", contextId },
                { "userId", userid }
            };
            return _api.CallApi("users", "view", "getUserById", parameters);
        }

        /// <summary>
        ///Gets the configuration parameters for the credentials of the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse GetAuthenticationCredentialsConfigParams(string contextId)
        {
            var parameters = new Dictionary<string, string>
            {
                { "contextId", contextId }
            };
            return _api.CallApi("users", "view", "getAuthenticationCredentialsConfigParams", parameters);
        }

        /// <summary>
        ///Gets the authentication credentials of the user with given ID that belongs to the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse GetAuthenticationCredentials(string contextId, string userid)
        {
            var parameters = new Dictionary<string, string>
            {
                { "contextId", contextId },
                { "userId", userid }
            };
            return _api.CallApi("users", "view", "getAuthenticationCredentials", parameters);
        }

        /// <summary>
        ///Creates a new user with the given name for the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse NewUser(string contextId, string name)
        {
            var parameters = new Dictionary<string, string>
            {
                { "contextId", contextId },
                { "name", name }
            };
            return _api.CallApi("users", "action", "newUser", parameters);
        }

        /// <summary>
        ///Removes the user with the given ID that belongs to the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveUser(string contextId, string userid)
        {
            var parameters = new Dictionary<string, string> { { "contextId", contextId }, { "userId", userid } };
            return _api.CallApi("users", "action", "removeUser", parameters);
        }

        /// <summary>
        ///Sets whether or not the user, with the given ID that belongs to the context with the given ID, should be enabled.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetUserEnabled(string contextId, string userid, string enabled)
        {
            var parameters = new Dictionary<string, string>
            {
                { "contextId", contextId },
                { "userId", userid },
                { "enabled", enabled }
            };
            return _api.CallApi("users", "action", "setUserEnabled", parameters);
        }

        /// <summary>
        ///Renames the user with the given ID that belongs to the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetUserName(string contextId, string userid, string name)
        {
            var parameters = new Dictionary<string, string> { { "contextId", contextId }, { "userId", userid }, { "name", name } };
            return _api.CallApi("users", "action", "setUserName", parameters);
        }

        /// <summary>
        ///Sets the authentication credentials for the user with the given ID that belongs to the context with the given ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetAuthenticationCredentials(string contextId, string userid, string authCredentialsConfigParams)
        {
            var parameters = new Dictionary<string, string>
            {
                {"contextId", contextId},
                {"userId", userid},
                {"authCredentialsConfigParams", authCredentialsConfigParams}
            };
            return _api.CallApi("users", "action", "setAuthenticationCredentials", parameters);
        }

    }
}
