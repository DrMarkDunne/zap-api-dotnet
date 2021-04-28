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
    public class Spider
    {
        private readonly ClientApi _api;

        public Spider(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse Status(string scanId)
        {
            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("spider", "view", "status", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse Results(string scanId)
        {
            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("spider", "view", "results", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse FullResults(string scanId)
        {
            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("spider", "view", "fullResults", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse Scans()
        {
            return _api.CallApi("spider", "view", "scans", null);
        }

        /// <summary>
        ///Gets the regexes of URLs excluded from the spider scans.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ExcludedFromScan()
        {
            return _api.CallApi("spider", "view", "excludedFromScan", null);
        }

        /// <summary>
        ///Returns a list of unique URLs from the history table based on HTTP messages added by the Spider.
        /// </summary>
        /// <returns></returns>
        public IApiResponse AllUrls()
        {
            return _api.CallApi("spider", "view", "allUrls", null);
        }

        /// <summary>
        ///Returns a list of the names of the nodes added to the Sites tree by the specified scan.
        /// </summary>
        /// <returns></returns>
        public IApiResponse AddedNodes(string scanId)
        {
            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("spider", "view", "addedNodes", parameters);
        }

        /// <summary>
        ///Gets all the domains that are always in scope. For each domain the following are shown: the index, the value (domain), if enabled, and if specified as a regex.
        /// </summary>
        /// <returns></returns>
        public IApiResponse DomainsAlwaysInScope()
        {
            return _api.CallApi("spider", "view", "domainsAlwaysInScope", null);
        }

        /// <summary>
        ///Use view domainsAlwaysInScope instead.
        /// [Obsolete]
        /// </summary>
        /// <returns></returns>
        [Obsolete("Obsolete")]
        public IApiResponse OptionDomainsAlwaysInScope()
        {
            return _api.CallApi("spider", "view", "optionDomainsAlwaysInScope", null);
        }

        /// <summary>
        ///Use view domainsAlwaysInScope instead.
        /// [Obsolete]
        /// </summary>
        /// <returns></returns>
        [Obsolete("Obsolete")]
        public IApiResponse OptionDomainsAlwaysInScopeEnabled()
        {
            return _api.CallApi("spider", "view", "optionDomainsAlwaysInScopeEnabled", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionHandleParameters()
        {
            return _api.CallApi("spider", "view", "optionHandleParameters", null);
        }

        /// <summary>
        ///Gets the maximum number of child nodes (per node) that can be crawled, 0 means no limit.
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMaxChildren()
        {
            return _api.CallApi("spider", "view", "optionMaxChildren", null);
        }

        /// <summary>
        ///Gets the maximum depth the spider can crawl, 0 if unlimited.
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMaxDepth()
        {
            return _api.CallApi("spider", "view", "optionMaxDepth", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMaxDuration()
        {
            return _api.CallApi("spider", "view", "optionMaxDuration", null);
        }

        /// <summary>
        ///Gets the maximum size, in bytes, that a response might have to be parsed.
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMaxParseSizeBytes()
        {
            return _api.CallApi("spider", "view", "optionMaxParseSizeBytes", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMaxScansInUi()
        {
            return _api.CallApi("spider", "view", "optionMaxScansInUI", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionRequestWaitTime()
        {
            return _api.CallApi("spider", "view", "optionRequestWaitTime", null);
        }

        /// <summary>
        ///
        /// [Obsolete] Option no longer in effective use.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Option no longer in effective use.")]
        public IApiResponse OptionScope()
        {
            return _api.CallApi("spider", "view", "optionScope", null);
        }

        /// <summary>
        ///
        /// [Obsolete] Option no longer in effective use.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Option no longer in effective use.")]
        public IApiResponse OptionScopeText()
        {
            return _api.CallApi("spider", "view", "optionScopeText", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionSkipUrlString()
        {
            return _api.CallApi("spider", "view", "optionSkipURLString", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionThreadCount()
        {
            return _api.CallApi("spider", "view", "optionThreadCount", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionUserAgent()
        {
            return _api.CallApi("spider", "view", "optionUserAgent", null);
        }

        /// <summary>
        ///Gets whether or not a spider process should accept cookies while spidering.
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionAcceptCookies()
        {
            return _api.CallApi("spider", "view", "optionAcceptCookies", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionHandleODataParametersVisited()
        {
            return _api.CallApi("spider", "view", "optionHandleODataParametersVisited", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionParseComments()
        {
            return _api.CallApi("spider", "view", "optionParseComments", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionParseGit()
        {
            return _api.CallApi("spider", "view", "optionParseGit", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionParseRobotsTxt()
        {
            return _api.CallApi("spider", "view", "optionParseRobotsTxt", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionParseSvnEntries()
        {
            return _api.CallApi("spider", "view", "optionParseSVNEntries", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionParseSiteMapXml()
        {
            return _api.CallApi("spider", "view", "optionParseSiteMapXml", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionPostForm()
        {
            return _api.CallApi("spider", "view", "optionPostForm", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionProcessForm()
        {
            return _api.CallApi("spider", "view", "optionProcessForm", null);
        }

        /// <summary>
        ///Gets whether or not the 'Referer' header should be sent while spidering.
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionSendRefererHeader()
        {
            return _api.CallApi("spider", "view", "optionSendRefererHeader", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionShowAdvancedDialog()
        {
            return _api.CallApi("spider", "view", "optionShowAdvancedDialog", null);
        }

        /// <summary>
        ///Runs the spider against the given URL (or context). Optionally, the 'maxChildren' parameter can be set to limit the number of children scanned, the 'recurse' parameter can be used to prevent the spider from seeding recursively, the parameter 'contextName' can be used to constrain the scan to a Context and the parameter 'subtreeOnly' allows to restrict the spider under a site's subtree (using the specified 'url').
        /// </summary>
        /// <returns></returns>
        public IApiResponse Scan(string url, string maxChildren, string recurse, string contextName, string subtreeOnly)
        {

            var parameters = new Dictionary<string, string>
            {
                {"url", url},
                {"maxChildren", maxChildren},
                {"recurse", recurse},
                {"contextName", contextName},
                {"subtreeOnly", subtreeOnly}
            };
            return _api.CallApi("spider", "action", "scan", parameters);
        }

        /// <summary>
        ///Runs the spider from the perspective of a User, obtained using the given Context ID and User ID. See 'scan' action for more details.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ScanAsUser(string contextId, string userid, string url, string maxChildren, string recurse, string subtreeOnly)
        {

            var parameters = new Dictionary<string, string>
            {
                {"contextId", contextId},
                {"userId", userid},
                {"url", url},
                {"maxChildren", maxChildren},
                {"recurse", recurse},
                {"subtreeOnly", subtreeOnly}
            };
            return _api.CallApi("spider", "action", "scanAsUser", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse Pause(string scanId)
        {

            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("spider", "action", "pause", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse Resume(string scanId)
        {

            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("spider", "action", "resume", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse Stop(string scanId)
        {

            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("spider", "action", "stop", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveScan(string scanId)
        {

            var parameters = new Dictionary<string, string> { { "scanId", scanId } };
            return _api.CallApi("spider", "action", "removeScan", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse PauseAllScans()
        {
            return _api.CallApi("spider", "action", "pauseAllScans", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse ResumeAllScans()
        {
            return _api.CallApi("spider", "action", "resumeAllScans", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse StopAllScans()
        {
            return _api.CallApi("spider", "action", "stopAllScans", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveAllScans()
        {
            return _api.CallApi("spider", "action", "removeAllScans", null);
        }

        /// <summary>
        ///Clears the regexes of URLs excluded from the spider scans.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ClearExcludedFromScan()
        {
            return _api.CallApi("spider", "action", "clearExcludedFromScan", null);
        }

        /// <summary>
        ///Adds a regex of URLs that should be excluded from the spider scans.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ExcludeFromScan(string regex)
        {
            var parameters = new Dictionary<string, string>
            {
                { "regex", regex }
            };
            return _api.CallApi("spider", "action", "excludeFromScan", parameters);
        }

        /// <summary>
        ///Adds a new domain that's always in scope, using the specified value. Optionally sets if the new entry is enabled (default, true) and whether or not the new value is specified as a regex (default, false).
        /// </summary>
        /// <returns></returns>
        public IApiResponse AddDomainAlwaysInScope(string value, string isRegex, string isEnabled)
        {
            var parameters = new Dictionary<string, string>
            {
                { "value", value },
                { "isRegex", isRegex },
                { "isEnabled", isEnabled }
            };
            return _api.CallApi("spider", "action", "addDomainAlwaysInScope", parameters);
        }

        /// <summary>
        ///Modifies a domain that's always in scope. Allows to modify the value, if enabled or if a regex. The domain is selected with its index, which can be obtained with the view domainsAlwaysInScope.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ModifyDomainAlwaysInScope(string idx, string value, string isRegex, string isEnabled)
        {

            var parameters = new Dictionary<string, string>
            {
                {"idx", idx}, {"value", value}, {"isRegex", isRegex}, {"isEnabled", isEnabled}
            };
            return _api.CallApi("spider", "action", "modifyDomainAlwaysInScope", parameters);
        }

        /// <summary>
        ///Removes a domain that's always in scope, with the given index. The index can be obtained with the view domainsAlwaysInScope.
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveDomainAlwaysInScope(string idx)
        {
            var parameters = new Dictionary<string, string> { { "idx", idx } };
            return _api.CallApi("spider", "action", "removeDomainAlwaysInScope", parameters);
        }

        /// <summary>
        ///Enables all domains that are always in scope.
        /// </summary>
        /// <returns></returns>
        public IApiResponse EnableAllDomainsAlwaysInScope()
        {
            return _api.CallApi("spider", "action", "enableAllDomainsAlwaysInScope", null);
        }

        /// <summary>
        ///Disables all domains that are always in scope.
        /// </summary>
        /// <returns></returns>
        public IApiResponse DisableAllDomainsAlwaysInScope()
        {

            return _api.CallApi("spider", "action", "disableAllDomainsAlwaysInScope", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionHandleParameters(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("spider", "action", "setOptionHandleParameters", parameters);
        }

        /// <summary>
        ///Use actions [add|modify|remove]DomainAlwaysInScope instead.
        /// [Obsolete] Option no longer in effective use.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Option no longer in effective use.")]
        public IApiResponse SetOptionScopeString(string str)
        {
            var parameters = new Dictionary<string, string>
            {
                { "String", str }
            };
            return _api.CallApi("spider", "action", "setOptionScopeString", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionSkipUrlString(string str)
        {
            var parameters = new Dictionary<string, string>
            {
                { "String", str }
            };
            return _api.CallApi("spider", "action", "setOptionSkipURLString", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionUserAgent(string str)
        {
            var parameters = new Dictionary<string, string>
            {
                { "String", str }
            };
            return _api.CallApi("spider", "action", "setOptionUserAgent", parameters);
        }

        /// <summary>
        ///Sets whether or not a spider process should accept cookies while spidering.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionAcceptCookies(bool boolean)
        {
            var parameters = new Dictionary<string, string>
            {
                { "Boolean", Convert.ToString(boolean) }
            };
            return _api.CallApi("spider", "action", "setOptionAcceptCookies", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionHandleODataParametersVisited(bool boolean)
        {
            var parameters = new Dictionary<string, string>
            {
                { "Boolean", Convert.ToString(boolean) }
            };
            return _api.CallApi("spider", "action", "setOptionHandleODataParametersVisited", parameters);
        }

        /// <summary>
        ///Sets the maximum number of child nodes (per node) that can be crawled, 0 means no limit.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMaxChildren(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("spider", "action", "setOptionMaxChildren", parameters);
        }

        /// <summary>
        ///Sets the maximum depth the spider can crawl, 0 for unlimited depth.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMaxDepth(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("spider", "action", "setOptionMaxDepth", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMaxDuration(int i)
        {
            var parameters = new Dictionary<string, string>
            {
                { "Integer", Convert.ToString(i) }
            };
            return _api.CallApi("spider", "action", "setOptionMaxDuration", parameters);
        }

        /// <summary>
        ///Sets the maximum size, in bytes, that a response might have to be parsed. This allows the spider to skip big responses/files.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMaxParseSizeBytes(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("spider", "action", "setOptionMaxParseSizeBytes", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMaxScansInUi(int i)
        {
            var parameters = new Dictionary<string, string>
            {
                { "Integer", Convert.ToString(i) }
            };
            return _api.CallApi("spider", "action", "setOptionMaxScansInUI", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionParseComments(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("spider", "action", "setOptionParseComments", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionParseGit(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("spider", "action", "setOptionParseGit", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionParseRobotsTxt(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("spider", "action", "setOptionParseRobotsTxt", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionParseSvnEntries(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("spider", "action", "setOptionParseSVNEntries", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionParseSiteMapXml(bool boolean)
        {
            var parameters = new Dictionary<string, string>
            {
                { "Boolean", Convert.ToString(boolean) }
            };
            return _api.CallApi("spider", "action", "setOptionParseSiteMapXml", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionPostForm(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("spider", "action", "setOptionPostForm", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionProcessForm(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("spider", "action", "setOptionProcessForm", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionRequestWaitTime(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("spider", "action", "setOptionRequestWaitTime", parameters);
        }

        /// <summary>
        ///Sets whether or not the 'Referer' header should be sent while spidering.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionSendRefererHeader(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("spider", "action", "setOptionSendRefererHeader", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionShowAdvancedDialog(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("spider", "action", "setOptionShowAdvancedDialog", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionThreadCount(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("spider", "action", "setOptionThreadCount", parameters);
        }
    }
}
