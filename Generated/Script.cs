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
    public class Script
    {
        private readonly ClientApi _api;

        public Script(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Lists the script engines available
        /// </summary>
        /// <returns></returns>
        public IApiResponse ListEngines()
        {
            return _api.CallApi("script", "view", "listEngines", null);
        }

        /// <summary>
        ///Lists the script types available.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ListTypes()
        {
            return _api.CallApi("script", "view", "listTypes", null);
        }

        /// <summary>
        ///Lists the scripts available, with its engine, name, description, type and error state.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ListScripts()
        {
            return _api.CallApi("script", "view", "listScripts", null);
        }

        /// <summary>
        ///Gets the value of the global variable with the given key. Returns an API error (DOES_NOT_EXIST) if no value was previously set.
        /// </summary>
        /// <returns></returns>
        public IApiResponse GlobalVar(string varKey)
        {
            var parameters = new Dictionary<string, string> { { "varKey", varKey } };
            return _api.CallApi("script", "view", "globalVar", parameters);
        }

        /// <summary>
        ///Gets all the global variables (key/value pairs).
        /// </summary>
        /// <returns></returns>
        public IApiResponse GlobalVars()
        {
            return _api.CallApi("script", "view", "globalVars", null);
        }

        /// <summary>
        ///Gets the value of the variable with the given key for the given script. Returns an API error (DOES_NOT_EXIST) if no script with the given name exists or if no value was previously set.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ScriptVar(string scriptName, string varKey)
        {
            var parameters = new Dictionary<string, string> { { "scriptName", scriptName }, { "varKey", varKey } };
            return _api.CallApi("script", "view", "scriptVar", parameters);
        }

        /// <summary>
        ///Gets all the variables (key/value pairs) of the given script. Returns an API error (DOES_NOT_EXIST) if no script with the given name exists.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ScriptVars(string scriptName)
        {
            var parameters = new Dictionary<string, string> { { "scriptName", scriptName } };
            return _api.CallApi("script", "view", "scriptVars", parameters);
        }

        /// <summary>
        ///Enables the script with the given name
        /// </summary>
        /// <returns></returns>
        public IApiResponse Enable(string scriptName)
        {
            var parameters = new Dictionary<string, string> { { "scriptName", scriptName } };
            return _api.CallApi("script", "action", "enable", parameters);
        }

        /// <summary>
        ///Disables the script with the given name
        /// </summary>
        /// <returns></returns>
        public IApiResponse Disable(string scriptName)
        {
            var parameters = new Dictionary<string, string> { { "scriptName", scriptName } };
            return _api.CallApi("script", "action", "disable", parameters);
        }

        /// <summary>
        ///Loads a script into ZAP from the given local file, with the given name, type and engine, optionally with a description, and a charset name to read the script (the charset name is required if the script is not in UTF-8, for example, in ISO-8859-1).
        /// </summary>
        /// <returns></returns>
        public IApiResponse Load(string scriptName, string scriptType, string scriptEngine, string fileName, string scriptDescription, string charset)
        {
            var parameters = new Dictionary<string, string>
            {
                {"scriptName", scriptName},
                {"scriptType", scriptType},
                {"scriptEngine", scriptEngine},
                {"fileName", fileName},
                {"scriptDescription", scriptDescription},
                {"charset", charset}
            };
            return _api.CallApi("script", "action", "load", parameters);
        }

        /// <summary>
        ///Removes the script with the given name
        /// </summary>
        /// <returns></returns>
        public IApiResponse Remove(string scriptName)
        {
            var parameters = new Dictionary<string, string> { { "scriptName", scriptName } };
            return _api.CallApi("script", "action", "remove", parameters);
        }

        /// <summary>
        ///Runs the stand alone script with the given name
        /// </summary>
        /// <returns></returns>
        public IApiResponse RunStandAloneScript(string scriptName)
        {
            var parameters = new Dictionary<string, string> { { "scriptName", scriptName } };
            return _api.CallApi("script", "action", "runStandAloneScript", parameters);
        }

        /// <summary>
        ///Clears the global variable with the given key.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ClearGlobalVar(string varKey)
        {
            var parameters = new Dictionary<string, string> { { "varKey", varKey } };
            return _api.CallApi("script", "action", "clearGlobalVar", parameters);
        }

        /// <summary>
        ///Clears the global variables.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ClearGlobalVars()
        {
            return _api.CallApi("script", "action", "clearGlobalVars", null);
        }

        /// <summary>
        ///Clears the variable with the given key of the given script. Returns an API error (DOES_NOT_EXIST) if no script with the given name exists.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ClearScriptVar(string scriptName, string varKey)
        {
            var parameters = new Dictionary<string, string> { { "scriptName", scriptName }, { "varKey", varKey } };
            return _api.CallApi("script", "action", "clearScriptVar", parameters);
        }

        /// <summary>
        ///Clears the variables of the given script. Returns an API error (DOES_NOT_EXIST) if no script with the given name exists.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ClearScriptVars(string scriptName)
        {
            var parameters = new Dictionary<string, string> { { "scriptName", scriptName } };
            return _api.CallApi("script", "action", "clearScriptVars", parameters);
        }

        /// <summary>
        ///Sets the value of the variable with the given key of the given script. Returns an API error (DOES_NOT_EXIST) if no script with the given name exists.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetScriptVar(string scriptName, string varKey, string varValue)
        {
            var parameters = new Dictionary<string, string>
            {
                {"scriptName", scriptName}, {"varKey", varKey}, {"varValue", varValue}
            };
            return _api.CallApi("script", "action", "setScriptVar", parameters);
        }

        /// <summary>
        ///Sets the value of the global variable with the given key.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetGlobalVar(string varKey, string varValue)
        {
            var parameters = new Dictionary<string, string> { { "varKey", varKey }, { "varValue", varValue } };
            return _api.CallApi("script", "action", "setGlobalVar", parameters);
        }
    }
}
