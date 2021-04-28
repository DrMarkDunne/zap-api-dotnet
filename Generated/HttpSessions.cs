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
    public class HttpSessions
    {
        private readonly ClientApi _api;

        public HttpSessions(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Gets all of the sites that have sessions.
        /// </summary>
        /// <returns></returns>
        public IApiResponse Sites()
        {
            return _api.CallApi("httpSessions", "view", "sites", null);
        }

        /// <summary>
        ///Gets the sessions for the given site. Optionally returning just the session with the given name.
        /// </summary>
        /// <returns></returns>
        public IApiResponse Sessions(string site, string session)
        {
            var parameters = new Dictionary<string, string> { { "site", site }, { "session", session } };
            return _api.CallApi("httpSessions", "view", "sessions", parameters);
        }

        /// <summary>
        ///Gets the name of the active session for the given site.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ActiveSession(string site)
        {
            var parameters = new Dictionary<string, string> { { "site", site } };
            return _api.CallApi("httpSessions", "view", "activeSession", parameters);
        }

        /// <summary>
        ///Gets the names of the session tokens for the given site.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SessionTokens(string site)
        {
            var parameters = new Dictionary<string, string> { { "site", site } };
            return _api.CallApi("httpSessions", "view", "sessionTokens", parameters);
        }

        /// <summary>
        ///Gets the default session tokens.
        /// </summary>
        /// <returns></returns>
        public IApiResponse DefaultSessionTokens()
        {
            return _api.CallApi("httpSessions", "view", "defaultSessionTokens", null);
        }

        /// <summary>
        ///Creates an empty session for the given site. Optionally with the given name.
        /// </summary>
        /// <returns></returns>
        public IApiResponse CreateEmptySession(string site, string session)
        {
            var parameters = new Dictionary<string, string> { { "site", site }, { "session", session } };
            return _api.CallApi("httpSessions", "action", "createEmptySession", parameters);
        }

        /// <summary>
        ///Removes the session from the given site.
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveSession(string site, string session)
        {
            var parameters = new Dictionary<string, string> { { "site", site }, { "session", session } };
            return _api.CallApi("httpSessions", "action", "removeSession", parameters);
        }

        /// <summary>
        ///Sets the given session as active for the given site.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetActiveSession(string site, string session)
        {
            var parameters = new Dictionary<string, string> { { "site", site }, { "session", session } };
            return _api.CallApi("httpSessions", "action", "setActiveSession", parameters);
        }

        /// <summary>
        ///Unsets the active session of the given site.
        /// </summary>
        /// <returns></returns>
        public IApiResponse UnsetActiveSession(string site)
        {
            var parameters = new Dictionary<string, string> { { "site", site } };
            return _api.CallApi("httpSessions", "action", "unsetActiveSession", parameters);
        }

        /// <summary>
        ///Adds the session token to the given site.
        /// </summary>
        /// <returns></returns>
        public IApiResponse AddSessionToken(string site, string sessionToken)
        {
            var parameters = new Dictionary<string, string> { { "site", site }, { "sessionToken", sessionToken } };
            return _api.CallApi("httpSessions", "action", "addSessionToken", parameters);
        }

        /// <summary>
        ///Removes the session token from the given site.
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveSessionToken(string site, string sessionToken)
        {
            var parameters = new Dictionary<string, string> { { "site", site }, { "sessionToken", sessionToken } };
            return _api.CallApi("httpSessions", "action", "removeSessionToken", parameters);
        }

        /// <summary>
        ///Sets the value of the session token of the given session for the given site.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetSessionTokenValue(string site, string session, string sessionToken, string tokenValue)
        {
            var parameters = new Dictionary<string, string>
            {
                {"site", site}, {"session", session}, {"sessionToken", sessionToken}, {"tokenValue", tokenValue}
            };
            return _api.CallApi("httpSessions", "action", "setSessionTokenValue", parameters);
        }

        /// <summary>
        ///Renames the session of the given site.
        /// </summary>
        /// <returns></returns>
        public IApiResponse RenameSession(string site, string oldSessionName, string newSessionName)
        {
            var parameters = new Dictionary<string, string>
            {
                {"site", site}, {"oldSessionName", oldSessionName}, {"newSessionName", newSessionName}
            };
            return _api.CallApi("httpSessions", "action", "renameSession", parameters);
        }

        /// <summary>
        ///Adds a default session token with the given name and enabled state.
        /// </summary>
        /// <returns></returns>
        public IApiResponse AddDefaultSessionToken(string sessionToken, string tokenEnabled)
        {
            var parameters = new Dictionary<string, string>
            {
                {"sessionToken", sessionToken}, {"tokenEnabled", tokenEnabled}
            };
            return _api.CallApi("httpSessions", "action", "addDefaultSessionToken", parameters);
        }

        /// <summary>
        ///Sets whether or not the default session token with the given name is enabled.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetDefaultSessionTokenEnabled(string sessionToken, string tokenEnabled)
        {
            var parameters = new Dictionary<string, string>
            {
                {"sessionToken", sessionToken}, {"tokenEnabled", tokenEnabled}
            };
            return _api.CallApi("httpSessions", "action", "setDefaultSessionTokenEnabled", parameters);
        }

        /// <summary>
        ///Removes the default session token with the given name.
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveDefaultSessionToken(string sessionToken)
        {
            var parameters = new Dictionary<string, string> { { "sessionToken", sessionToken } };
            return _api.CallApi("httpSessions", "action", "removeDefaultSessionToken", parameters);
        }
    }
}
