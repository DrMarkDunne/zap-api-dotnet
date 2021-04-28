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
    public class Ascan
    {
        private readonly ClientApi _api;

        public Ascan(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse Status(string scanId)
        {
            var parameters = new Dictionary<string, string>
            {
                { "scanId", scanId }
            };
            return _api.CallApi("ascan", "view", "status", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse ScanProgress(string scanId)
        {
            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("ascan", "view", "scanProgress", parameters);
        }

        /// <summary>
        ///Gets the IDs of the messages sent during the scan with the given ID. A message can be obtained with 'message' core view.
        /// </summary>
        /// <returns></returns>
        public IApiResponse MessagesIds(string scanId)
        {
            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("ascan", "view", "messagesIds", parameters);
        }

        /// <summary>
        ///Gets the IDs of the alerts raised during the scan with the given ID. An alert can be obtained with 'alert' core view.
        /// </summary>
        /// <returns></returns>
        public IApiResponse AlertsIds(string scanId)
        {
            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("ascan", "view", "alertsIds", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse Scans()
        {
            return _api.CallApi("ascan", "view", "scans", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse ScanPolicyNames()
        {
            return _api.CallApi("ascan", "view", "scanPolicyNames", null);
        }

        /// <summary>
        ///Gets the regexes of URLs excluded from the active scans.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ExcludedFromScan()
        {
            return _api.CallApi("ascan", "view", "excludedFromScan", null);
        }

        /// <summary>
        ///Gets the scanners, optionally, of the given scan policy and/or scanner policy/category ID.
        /// </summary>
        /// <returns></returns>
        public IApiResponse Scanners(string scanPolicyName, string policyId)
        {
            var parameters = new Dictionary<string, string>
            {
                {"scanPolicyName", scanPolicyName}, {"policyId", policyId}
            };
            return _api.CallApi("ascan", "view", "scanners", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse Policies(string scanPolicyName, string policyId)
        {
            var parameters = new Dictionary<string, string>
            {
                {"scanPolicyName", scanPolicyName}, {"policyId", policyId}
            };
            return _api.CallApi("ascan", "view", "policies", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse AttackModeQueue()
        {
            return _api.CallApi("ascan", "view", "attackModeQueue", null);
        }

        /// <summary>
        ///Gets all the parameters that are excluded. For each parameter the following are shown: the name, the URL, and the parameter type.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ExcludedParams()
        {
            return _api.CallApi("ascan", "view", "excludedParams", null);
        }

        /// <summary>
        ///Use view excludedParams instead.
        /// [Obsolete]
        /// </summary>
        /// <returns></returns>
        [Obsolete("Obsolete")]
        public IApiResponse OptionExcludedParamList()
        {
            return _api.CallApi("ascan", "view", "optionExcludedParamList", null);
        }

        /// <summary>
        ///Gets all the types of excluded parameters. For each type the following are shown: the ID and the name.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ExcludedParamTypes()
        {
            return _api.CallApi("ascan", "view", "excludedParamTypes", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionAttackPolicy()
        {
            return _api.CallApi("ascan", "view", "optionAttackPolicy", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionDefaultPolicy()
        {
            return _api.CallApi("ascan", "view", "optionDefaultPolicy", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionDelayInMs()
        {
            return _api.CallApi("ascan", "view", "optionDelayInMs", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionHandleAntiCsrfTokens()
        {
            return _api.CallApi("ascan", "view", "optionHandleAntiCSRFTokens", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionHostPerScan()
        {
            return _api.CallApi("ascan", "view", "optionHostPerScan", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMaxChartTimeInMins()
        {
            return _api.CallApi("ascan", "view", "optionMaxChartTimeInMins", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMaxResultsToList()
        {
            return _api.CallApi("ascan", "view", "optionMaxResultsToList", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMaxRuleDurationInMins()
        {
            return _api.CallApi("ascan", "view", "optionMaxRuleDurationInMins", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMaxScanDurationInMins()
        {
            return _api.CallApi("ascan", "view", "optionMaxScanDurationInMins", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMaxScansInUi()
        {
            return _api.CallApi("ascan", "view", "optionMaxScansInUI", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionTargetParamsEnabledRpc()
        {
            return _api.CallApi("ascan", "view", "optionTargetParamsEnabledRPC", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionTargetParamsInjectable()
        {
            return _api.CallApi("ascan", "view", "optionTargetParamsInjectable", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionThreadPerHost()
        {
            return _api.CallApi("ascan", "view", "optionThreadPerHost", null);
        }

        /// <summary>
        ///Tells whether or not the active scanner should add a query parameter to GET request that don't have parameters to start with.
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionAddQueryParam()
        {
            return _api.CallApi("ascan", "view", "optionAddQueryParam", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionAllowAttackOnStart()
        {
            return _api.CallApi("ascan", "view", "optionAllowAttackOnStart", null);
        }

        /// <summary>
        ///Tells whether or not the active scanner should inject the HTTP request header X-ZAP-Scan-ID, with the ID of the scanner that's sending the requests.
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionInjectPluginIdInHeader()
        {
            return _api.CallApi("ascan", "view", "optionInjectPluginIdInHeader", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionPromptInAttackMode()
        {
            return _api.CallApi("ascan", "view", "optionPromptInAttackMode", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionPromptToClearFinishedScans()
        {
            return _api.CallApi("ascan", "view", "optionPromptToClearFinishedScans", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionRescanInAttackMode()
        {
            return _api.CallApi("ascan", "view", "optionRescanInAttackMode", null);
        }

        /// <summary>
        ///Tells whether or not the HTTP Headers of all requests should be scanned. Not just requests that send parameters, through the query or request body.
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionScanHeadersAllRequests()
        {
            return _api.CallApi("ascan", "view", "optionScanHeadersAllRequests", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionShowAdvancedDialog()
        {
            return _api.CallApi("ascan", "view", "optionShowAdvancedDialog", null);
        }

        /// <summary>
        ///Runs the active scanner against the given URL and/or Context. Optionally, the 'recurse' parameter can be used to scan URLs under the given URL, the parameter 'inScopeOnly' can be used to constrain the scan to URLs that are in scope (ignored if a Context is specified), the parameter 'scanPolicyName' allows to specify the scan policy (if none is given it uses the default scan policy), the parameters 'method' and 'postData' allow to select a given request in conjunction with the given URL.
        /// </summary>
        /// <returns></returns>
        public IApiResponse Scan(string url, string recurse, string inScopeOnly, string scanPolicyName, string method, string postData, string contextId)
        {
            var parameters = new Dictionary<string, string>
            {
                {"url", url},
                {"recurse", recurse},
                {"inScopeOnly", inScopeOnly},
                {"scanPolicyName", scanPolicyName},
                {"method", method},
                {"postData", postData},
                {"contextId", contextId}
            };
            return _api.CallApi("ascan", "action", "scan", parameters);
        }

        /// <summary>
        ///Active Scans from the perspective of a User, obtained using the given Context ID and User ID. See 'scan' action for more details.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ScanAsUser(string url, string contextId, string userid, string recurse, string scanPolicyName, string method, string postData)
        {
            var parameters = new Dictionary<string, string>
            {
                {"url", url},
                {"contextId", contextId},
                {"userId", userid},
                {"recurse", recurse},
                {"scanPolicyName", scanPolicyName},
                {"method", method},
                {"postData", postData}
            };
            return _api.CallApi("ascan", "action", "scanAsUser", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse Pause(string scanId)
        {
            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("ascan", "action", "pause", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse Resume(string scanId)
        {
            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("ascan", "action", "resume", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse Stop(string scanId)
        {
            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("ascan", "action", "stop", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveScan(string scanId)
        {
            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("ascan", "action", "removeScan", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse PauseAllScans()
        {
            return _api.CallApi("ascan", "action", "pauseAllScans", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse ResumeAllScans()
        {
            return _api.CallApi("ascan", "action", "resumeAllScans", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse StopAllScans()
        {
            return _api.CallApi("ascan", "action", "stopAllScans", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveAllScans()
        {
            return _api.CallApi("ascan", "action", "removeAllScans", null);
        }

        /// <summary>
        ///Clears the regexes of URLs excluded from the active scans.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ClearExcludedFromScan()
        {
            return _api.CallApi("ascan", "action", "clearExcludedFromScan", null);
        }

        /// <summary>
        ///Adds a regex of URLs that should be excluded from the active scans.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ExcludeFromScan(string regex)
        {
            var parameters = new Dictionary<string, string> { { "regex", regex } };
            return _api.CallApi("ascan", "action", "excludeFromScan", parameters);
        }

        /// <summary>
        ///Enables all scanners of the scan policy with the given name, or the default if none given.
        /// </summary>
        /// <returns></returns>
        public IApiResponse EnableAllScanners(string scanPolicyName)
        {
            var parameters = new Dictionary<string, string> { { "scanPolicyName", scanPolicyName } };
            return _api.CallApi("ascan", "action", "enableAllScanners", parameters);
        }

        /// <summary>
        ///Disables all scanners of the scan policy with the given name, or the default if none given.
        /// </summary>
        /// <returns></returns>
        public IApiResponse DisableAllScanners(string scanPolicyName)
        {
            var parameters = new Dictionary<string, string> { { "scanPolicyName", scanPolicyName } };
            return _api.CallApi("ascan", "action", "disableAllScanners", parameters);
        }

        /// <summary>
        ///Enables the scanners with the given IDs (comma separated list of IDs) of the scan policy with the given name, or the default if none given.
        /// </summary>
        /// <returns></returns>
        public IApiResponse EnableScanners(string ids, string scanPolicyName)
        {
            var parameters = new Dictionary<string, string> { { "ids", ids }, { "scanPolicyName", scanPolicyName } };
            return _api.CallApi("ascan", "action", "enableScanners", parameters);
        }

        /// <summary>
        ///Disables the scanners with the given IDs (comma separated list of IDs) of the scan policy with the given name, or the default if none given.
        /// </summary>
        /// <returns></returns>
        public IApiResponse DisableScanners(string ids, string scanPolicyName)
        {
            var parameters = new Dictionary<string, string> { { "ids", ids }, { "scanPolicyName", scanPolicyName } };
            return _api.CallApi("ascan", "action", "disableScanners", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetEnabledPolicies(string ids, string scanPolicyName)
        {
            var parameters = new Dictionary<string, string> { { "ids", ids }, { "scanPolicyName", scanPolicyName } };
            return _api.CallApi("ascan", "action", "setEnabledPolicies", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetPolicyAttackStrength(string id, string attackStrength, string scanPolicyName)
        {
            var parameters = new Dictionary<string, string>
            {
                {"id", id}, {"attackStrength", attackStrength}, {"scanPolicyName", scanPolicyName}
            };
            return _api.CallApi("ascan", "action", "setPolicyAttackStrength", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetPolicyAlertThreshold(string id, string alertThreshold, string scanPolicyName)
        {
            var parameters = new Dictionary<string, string>
            {
                {"id", id}, {"alertThreshold", alertThreshold}, {"scanPolicyName", scanPolicyName}
            };
            return _api.CallApi("ascan", "action", "setPolicyAlertThreshold", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetScannerAttackStrength(string id, string attackStrength, string scanPolicyName)
        {
            var parameters = new Dictionary<string, string>
            {
                {"id", id}, {"attackStrength", attackStrength}, {"scanPolicyName", scanPolicyName}
            };
            return _api.CallApi("ascan", "action", "setScannerAttackStrength", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetScannerAlertThreshold(string id, string alertThreshold, string scanPolicyName)
        {
            var parameters = new Dictionary<string, string>
            {
                {"id", id}, {"alertThreshold", alertThreshold}, {"scanPolicyName", scanPolicyName}
            };
            return _api.CallApi("ascan", "action", "setScannerAlertThreshold", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse AddScanPolicy(string scanPolicyName, string alertThreshold, string attackStrength)
        {
            var parameters = new Dictionary<string, string>
            {
                {"scanPolicyName", scanPolicyName},
                {"alertThreshold", alertThreshold},
                {"attackStrength", attackStrength}
            };
            return _api.CallApi("ascan", "action", "addScanPolicy", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveScanPolicy(string scanPolicyName)
        {
            var parameters = new Dictionary<string, string> { { "scanPolicyName", scanPolicyName } };
            return _api.CallApi("ascan", "action", "removeScanPolicy", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse UpdateScanPolicy(string scanPolicyName, string alertThreshold, string attackStrength)
        {
            var parameters = new Dictionary<string, string>
            {
                {"scanPolicyName", scanPolicyName},
                {"alertThreshold", alertThreshold},
                {"attackStrength", attackStrength}
            };
            return _api.CallApi("ascan", "action", "updateScanPolicy", parameters);
        }

        /// <summary>
        ///Imports a Scan Policy using the given file system path.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ImportScanPolicy(string path)
        {
            var parameters = new Dictionary<string, string> { { "path", path } };
            return _api.CallApi("ascan", "action", "importScanPolicy", parameters);
        }

        /// <summary>
        ///Adds a new parameter excluded from the scan, using the specified name. Optionally sets if the new entry applies to a specific URL (default, all URLs) and sets the ID of the type of the parameter (default, ID of any type). The type IDs can be obtained with the view excludedParamTypes. 
        /// </summary>
        /// <returns></returns>
        public IApiResponse AddExcludedParam(string name, string type, string url)
        {
            var parameters = new Dictionary<string, string> { { "name", name }, { "type", type }, { "url", url } };
            return _api.CallApi("ascan", "action", "addExcludedParam", parameters);
        }

        /// <summary>
        ///Modifies a parameter excluded from the scan. Allows to modify the name, the URL and the type of parameter. The parameter is selected with its index, which can be obtained with the view excludedParams.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ModifyExcludedParam(string idx, string name, string type, string url)
        {
            var parameters = new Dictionary<string, string>
            {
                {"idx", idx}, {"name", name}, {"type", type}, {"url", url}
            };
            return _api.CallApi("ascan", "action", "modifyExcludedParam", parameters);
        }

        /// <summary>
        ///Removes a parameter excluded from the scan, with the given index. The index can be obtained with the view excludedParams.
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveExcludedParam(string idx)
        {
            var parameters = new Dictionary<string, string> { { "idx", idx } };
            return _api.CallApi("ascan", "action", "removeExcludedParam", parameters);
        }

        /// <summary>
        ///Skips the scanner using the given IDs of the scan and the scanner.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SkipScanner(string scanId, string scannerId)
        {
            var parameters = new Dictionary<string, string> { { "scanId", scanId }, { "scannerId", scannerId } };
            return _api.CallApi("ascan", "action", "skipScanner", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionAttackPolicy(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("ascan", "action", "setOptionAttackPolicy", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionDefaultPolicy(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("ascan", "action", "setOptionDefaultPolicy", parameters);
        }

        /// <summary>
        ///Sets whether or not the active scanner should add a query param to GET requests which do not have parameters to start with.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionAddQueryParam(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("ascan", "action", "setOptionAddQueryParam", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionAllowAttackOnStart(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("ascan", "action", "setOptionAllowAttackOnStart", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionDelayInMs(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ascan", "action", "setOptionDelayInMs", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionHandleAntiCsrfTokens(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("ascan", "action", "setOptionHandleAntiCSRFTokens", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionHostPerScan(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ascan", "action", "setOptionHostPerScan", parameters);
        }

        /// <summary>
        ///Sets whether or not the active scanner should inject the HTTP request header X-ZAP-Scan-ID, with the ID of the scanner that's sending the requests.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionInjectPluginIdInHeader(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("ascan", "action", "setOptionInjectPluginIdInHeader", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMaxChartTimeInMins(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ascan", "action", "setOptionMaxChartTimeInMins", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMaxResultsToList(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ascan", "action", "setOptionMaxResultsToList", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMaxRuleDurationInMins(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ascan", "action", "setOptionMaxRuleDurationInMins", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMaxScanDurationInMins(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ascan", "action", "setOptionMaxScanDurationInMins", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMaxScansInUi(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ascan", "action", "setOptionMaxScansInUI", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionPromptInAttackMode(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("ascan", "action", "setOptionPromptInAttackMode", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionPromptToClearFinishedScans(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("ascan", "action", "setOptionPromptToClearFinishedScans", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionRescanInAttackMode(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("ascan", "action", "setOptionRescanInAttackMode", parameters);
        }

        /// <summary>
        ///Sets whether or not the HTTP Headers of all requests should be scanned. Not just requests that send parameters, through the query or request body.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionScanHeadersAllRequests(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("ascan", "action", "setOptionScanHeadersAllRequests", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionShowAdvancedDialog(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("ascan", "action", "setOptionShowAdvancedDialog", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionTargetParamsEnabledRpc(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ascan", "action", "setOptionTargetParamsEnabledRPC", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionTargetParamsInjectable(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ascan", "action", "setOptionTargetParamsInjectable", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionThreadPerHost(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("ascan", "action", "setOptionThreadPerHost", parameters);
        }
    }
}
