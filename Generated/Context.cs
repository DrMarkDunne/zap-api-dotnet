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
    public class Context
    {
        private readonly ClientApi _api;

        public Context(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///List context names of current session
        /// </summary>
        /// <returns></returns>
        public IApiResponse ContextList()
        {
            return _api.CallApi("context", "view", "contextList", null);
        }

        /// <summary>
        ///List excluded regexs for context
        /// </summary>
        /// <returns></returns>
        public IApiResponse ExcludeRegexs(string contextName)
        {
            var parameters = new Dictionary<string, string> { { "contextName", contextName } };
            return _api.CallApi("context", "view", "excludeRegexs", parameters);
        }

        /// <summary>
        ///List included regexs for context
        /// </summary>
        /// <returns></returns>
        public IApiResponse IncludeRegexs(string contextName)
        {
            var parameters = new Dictionary<string, string> { { "contextName", contextName } };
            return _api.CallApi("context", "view", "includeRegexs", parameters);
        }

        /// <summary>
        ///List the information about the named context
        /// </summary>
        /// <returns></returns>
        public IApiResponse ContextList(string contextName)
        {
            var parameters = new Dictionary<string, string> { { "contextName", contextName } };
            return _api.CallApi("context", "view", "context", parameters);
        }

        /// <summary>
        ///Lists the names of all built in technologies
        /// </summary>
        /// <returns></returns>
        public IApiResponse TechnologyList()
        {
            return _api.CallApi("context", "view", "technologyList", null);
        }

        /// <summary>
        ///Lists the names of all technologies included in a context
        /// </summary>
        /// <returns></returns>
        public IApiResponse IncludedTechnologyList(string contextName)
        {
            var parameters = new Dictionary<string, string> { { "contextName", contextName } };
            return _api.CallApi("context", "view", "includedTechnologyList", parameters);
        }

        /// <summary>
        ///Lists the names of all technologies excluded from a context
        /// </summary>
        /// <returns></returns>
        public IApiResponse ExcludedTechnologyList(string contextName)
        {
            var parameters = new Dictionary<string, string> { { "contextName", contextName } };
            return _api.CallApi("context", "view", "excludedTechnologyList", parameters);
        }

        /// <summary>
        ///Lists the URLs accessed through/by ZAP, that belong to the context with the given name.
        /// </summary>
        /// <returns></returns>
        public IApiResponse Urls(string contextName)
        {
            var parameters = new Dictionary<string, string> { { "contextName", contextName } };
            return _api.CallApi("context", "view", "urls", parameters);
        }

        /// <summary>
        ///Add exclude regex to context
        /// </summary>
        /// <returns></returns>
        public IApiResponse ExcludeFromContext(string contextName, string regex)
        {
            var parameters = new Dictionary<string, string> { { "contextName", contextName }, { "regex", regex } };
            return _api.CallApi("context", "action", "excludeFromContext", parameters);
        }

        /// <summary>
        ///Add include regex to context
        /// </summary>
        /// <returns></returns>
        public IApiResponse IncludeInContext(string contextName, string regex)
        {
            var parameters = new Dictionary<string, string> { { "contextName", contextName }, { "regex", regex } };
            return _api.CallApi("context", "action", "includeInContext", parameters);
        }

        /// <summary>
        ///Set the regexs to include and exclude for a context, both supplied as JSON string arrays
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetContextRegexs(string contextName, string incRegexs, string excRegexs)
        {
            var parameters = new Dictionary<string, string>
            {
                {"contextName", contextName}, {"incRegexs", incRegexs}, {"excRegexs", excRegexs}
            };
            return _api.CallApi("context", "action", "setContextRegexs", parameters);
        }

        /// <summary>
        ///Creates a new context with the given name in the current session
        /// </summary>
        /// <returns></returns>
        public IApiResponse NewContext(string contextName)
        {
            var parameters = new Dictionary<string, string> { { "contextName", contextName } };
            return _api.CallApi("context", "action", "newContext", parameters);
        }

        /// <summary>
        ///Removes a context in the current session
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveContext(string contextName)
        {
            var parameters = new Dictionary<string, string> { { "contextName", contextName } };
            return _api.CallApi("context", "action", "removeContext", parameters);
        }

        /// <summary>
        ///Exports the context with the given name to a file. If a relative file path is specified it will be resolved against the "contexts" directory in ZAP "home" dir.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ExportContext(string contextName, string contextFile)
        {
            var parameters = new Dictionary<string, string>
            {
                {"contextName", contextName}, {"contextFile", contextFile}
            };
            return _api.CallApi("context", "action", "exportContext", parameters);
        }

        /// <summary>
        ///Imports a context from a file. If a relative file path is specified it will be resolved against the "contexts" directory in ZAP "home" dir.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ImportContext(string contextFile)
        {
            var parameters = new Dictionary<string, string> { { "contextFile", contextFile } };
            return _api.CallApi("context", "action", "importContext", parameters);
        }

        /// <summary>
        ///Includes technologies with the given names, separated by a comma, to a context
        /// </summary>
        /// <returns></returns>
        public IApiResponse IncludeContextTechnologies(string contextName, string technologyNames)
        {
            var parameters = new Dictionary<string, string>
            {
                {"contextName", contextName}, {"technologyNames", technologyNames}
            };
            return _api.CallApi("context", "action", "includeContextTechnologies", parameters);
        }

        /// <summary>
        ///Includes all built in technologies in to a context
        /// </summary>
        /// <returns></returns>
        public IApiResponse IncludeAllContextTechnologies(string contextName)
        {
            var parameters = new Dictionary<string, string> { { "contextName", contextName } };
            return _api.CallApi("context", "action", "includeAllContextTechnologies", parameters);
        }

        /// <summary>
        ///Excludes technologies with the given names, separated by a comma, from a context
        /// </summary>
        /// <returns></returns>
        public IApiResponse ExcludeContextTechnologies(string contextName, string technologyNames)
        {
            var parameters = new Dictionary<string, string>
            {
                {"contextName", contextName}, {"technologyNames", technologyNames}
            };
            return _api.CallApi("context", "action", "excludeContextTechnologies", parameters);
        }

        /// <summary>
        ///Excludes all built in technologies from a context
        /// </summary>
        /// <returns></returns>
        public IApiResponse ExcludeAllContextTechnologies(string contextName)
        {
            var parameters = new Dictionary<string, string> { { "contextName", contextName } };
            return _api.CallApi("context", "action", "excludeAllContextTechnologies", parameters);
        }

        /// <summary>
        ///Sets a context to in scope (contexts are in scope by default)
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetContextInScope(string contextName, string booleanInScope)
        {
            var parameters = new Dictionary<string, string>
            {
                {"contextName", contextName}, {"booleanInScope", booleanInScope}
            };
            return _api.CallApi("context", "action", "setContextInScope", parameters);
        }
    }
}
