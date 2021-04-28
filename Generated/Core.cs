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
    public class Core
    {
        private readonly ClientApi _api;

        public Core(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Gets the name of the hosts accessed through/by ZAP
        /// </summary>
        /// <returns></returns>
        public IApiResponse Hosts()
        {
            return _api.CallApi("core", "view", "hosts", null);
        }

        /// <summary>
        ///Gets the sites accessed through/by ZAP (scheme and domain)
        /// </summary>
        /// <returns></returns>
        public IApiResponse Sites()
        {
            return _api.CallApi("core", "view", "sites", null);
        }

        /// <summary>
        ///Gets the URLs accessed through/by ZAP, optionally filtering by (base) URL.
        /// </summary>
        /// <returns></returns>
        public IApiResponse Urls(string baseUrl)
        {
            var parameters = new Dictionary<string, string> { { "baseUrl", baseUrl } };
            return _api.CallApi("core", "view", "urls", parameters);
        }

        /// <summary>
        ///Gets the child nodes underneath the specified URL in the Sites tree
        /// </summary>
        /// <returns></returns>
        public IApiResponse ChildNodes(string url)
        {
            var parameters = new Dictionary<string, string> { { "url", url } };
            return _api.CallApi("core", "view", "childNodes", parameters);
        }

        /// <summary>
        ///Gets the HTTP message with the given ID. Returns the ID, request/response headers and bodies, cookies, note, type, RTT, and timestamp.
        /// </summary>
        /// <returns></returns>
        public IApiResponse Message(string id)
        {
            var parameters = new Dictionary<string, string> { { "id", id } };
            return _api.CallApi("core", "view", "message", parameters);
        }

        /// <summary>
        ///Gets the HTTP messages sent by ZAP, request and response, optionally filtered by URL and paginated with 'start' position and 'count' of messages
        /// </summary>
        /// <returns></returns>
        public IApiResponse Messages(string baseUrl, string start, string count)
        {
            var parameters = new Dictionary<string, string> { { "baseUrl", baseUrl }, { "start", start }, { "count", count } };
            return _api.CallApi("core", "view", "messages", parameters);
        }

        /// <summary>
        ///Gets the HTTP messages with the given IDs.
        /// </summary>
        /// <returns></returns>
        public IApiResponse MessagesById(string ids)
        {
            var parameters = new Dictionary<string, string> { { "ids", ids } };
            return _api.CallApi("core", "view", "messagesById", parameters);
        }

        /// <summary>
        ///Gets the number of messages, optionally filtering by URL
        /// </summary>
        /// <returns></returns>
        public IApiResponse NumberOfMessages(string baseUrl)
        {
            var parameters = new Dictionary<string, string> { { "baseUrl", baseUrl } };
            return _api.CallApi("core", "view", "numberOfMessages", parameters);
        }

        /// <summary>
        ///Gets the mode
        /// </summary>
        /// <returns></returns>
        public IApiResponse Mode()
        {
            return _api.CallApi("core", "view", "mode", null);
        }

        /// <summary>
        ///Gets ZAP version
        /// </summary>
        /// <returns></returns>
        public IApiResponse Version()
        {
            return _api.CallApi("core", "view", "version", null);
        }

        /// <summary>
        ///Gets the regular expressions, applied to URLs, to exclude from the local proxies.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ExcludedFromProxy()
        {
            return _api.CallApi("core", "view", "excludedFromProxy", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse HomeDirectory()
        {
            return _api.CallApi("core", "view", "homeDirectory", null);
        }

        /// <summary>
        ///Gets the location of the current session file
        /// </summary>
        /// <returns></returns>
        public IApiResponse SessionLocation()
        {
            return _api.CallApi("core", "view", "sessionLocation", null);
        }

        /// <summary>
        ///Gets all the domains that are excluded from the outgoing proxy. For each domain the following are shown: the index, the value (domain), if enabled, and if specified as a regex.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ProxyChainExcludedDomains()
        {
            return _api.CallApi("core", "view", "proxyChainExcludedDomains", null);
        }

        /// <summary>
        ///Use view proxyChainExcludedDomains instead.
        /// [Obsolete]
        /// </summary>
        /// <returns></returns>
        [Obsolete("Obsolete")]
        public IApiResponse OptionProxyChainSkipName()
        {
            return _api.CallApi("core", "view", "optionProxyChainSkipName", null);
        }

        /// <summary>
        ///Use view proxyChainExcludedDomains instead.
        /// [Obsolete]
        /// </summary>
        /// <returns></returns>
        [Obsolete("Obsolete")]
        public IApiResponse OptionProxyExcludedDomains()
        {
            return _api.CallApi("core", "view", "optionProxyExcludedDomains", null);
        }

        /// <summary>
        ///Use view proxyChainExcludedDomains instead.
        /// [Obsolete]
        /// </summary>
        /// <returns></returns>
        [Obsolete("Obsolete")]
        public IApiResponse OptionProxyExcludedDomainsEnabled()
        {
            return _api.CallApi("core", "view", "optionProxyExcludedDomainsEnabled", null);
        }

        /// <summary>
        ///Gets the path to ZAP's home directory.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ZapHomePath()
        {
            return _api.CallApi("core", "view", "zapHomePath", null);
        }

        /// <summary>
        ///Gets the maximum number of alert instances to include in a report.
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMaximumAlertInstances()
        {
            return _api.CallApi("core", "view", "optionMaximumAlertInstances", null);
        }

        /// <summary>
        ///Gets whether or not related alerts will be merged in any reports generated.
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionMergeRelatedAlerts()
        {
            return _api.CallApi("core", "view", "optionMergeRelatedAlerts", null);
        }

        /// <summary>
        ///Gets the path to the file with alert overrides.
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionAlertOverridesFilePath()
        {
            return _api.CallApi("core", "view", "optionAlertOverridesFilePath", null);
        }

        /// <summary>
        ///Gets the alert with the given ID, the corresponding HTTP message can be obtained with the 'messageId' field and 'message' API method
        /// [Obsolete] Use the API endpoint with the same name in the 'alert' component instead.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Use the API endpoint with the same name in the 'alert' component instead.")]
        public IApiResponse Alert(string id)
        {
            var parameters = new Dictionary<string, string> { { "id", id } };
            return _api.CallApi("core", "view", "alert", parameters);
        }

        /// <summary>
        ///Gets the alerts raised by ZAP, optionally filtering by URL or riskId, and paginating with 'start' position and 'count' of alerts
        /// [Obsolete] Use the API endpoint with the same name in the 'alert' component instead.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Use the API endpoint with the same name in the 'alert' component instead.")]
        public IApiResponse Alerts(string baseUrl, string start, string count, string riskId)
        {
            var parameters = new Dictionary<string, string>
            {
                {"baseUrl", baseUrl}, {"start", start}, {"count", count}, {"riskId", riskId}
            };
            return _api.CallApi("core", "view", "alerts", parameters);
        }

        /// <summary>
        ///Gets number of alerts grouped by each risk level, optionally filtering by URL
        /// [Obsolete] Use the API endpoint with the same name in the 'alert' component instead.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Use the API endpoint with the same name in the 'alert' component instead.")]
        public IApiResponse AlertsSummary(string baseUrl)
        {
            var parameters = new Dictionary<string, string> { { "baseUrl", baseUrl } };
            return _api.CallApi("core", "view", "alertsSummary", parameters);
        }

        /// <summary>
        ///Gets the number of alerts, optionally filtering by URL or riskId
        /// [Obsolete] Use the API endpoint with the same name in the 'alert' component instead.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Use the API endpoint with the same name in the 'alert' component instead.")]
        public IApiResponse NumberOfAlerts(string baseUrl, string riskId)
        {
            var parameters = new Dictionary<string, string> { { "baseUrl", baseUrl }, { "riskId", riskId } };
            return _api.CallApi("core", "view", "numberOfAlerts", parameters);
        }

        /// <summary>
        ///Gets the user agent that ZAP should use when creating HTTP messages (for example, spider messages or CONNECT requests to outgoing proxy).
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionDefaultUserAgent()
        {
            return _api.CallApi("core", "view", "optionDefaultUserAgent", null);
        }

        /// <summary>
        ///Gets the TTL (in seconds) of successful DNS queries.
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionDnsTtlSuccessfulQueries()
        {
            return _api.CallApi("core", "view", "optionDnsTtlSuccessfulQueries", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionHttpState()
        {
            return _api.CallApi("core", "view", "optionHttpState", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionProxyChainName()
        {
            return _api.CallApi("core", "view", "optionProxyChainName", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionProxyChainPassword()
        {
            return _api.CallApi("core", "view", "optionProxyChainPassword", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionProxyChainPort()
        {
            return _api.CallApi("core", "view", "optionProxyChainPort", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionProxyChainRealm()
        {
            return _api.CallApi("core", "view", "optionProxyChainRealm", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionProxyChainUserName()
        {
            return _api.CallApi("core", "view", "optionProxyChainUserName", null);
        }

        /// <summary>
        ///Gets the connection time out, in seconds.
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionTimeoutInSecs()
        {
            return _api.CallApi("core", "view", "optionTimeoutInSecs", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionHttpStateEnabled()
        {
            return _api.CallApi("core", "view", "optionHttpStateEnabled", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionProxyChainPrompt()
        {
            return _api.CallApi("core", "view", "optionProxyChainPrompt", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionSingleCookieRequestHeader()
        {
            return _api.CallApi("core", "view", "optionSingleCookieRequestHeader", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionUseProxyChain()
        {
            return _api.CallApi("core", "view", "optionUseProxyChain", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionUseProxyChainAuth()
        {
            return _api.CallApi("core", "view", "optionUseProxyChainAuth", null);
        }

        /// <summary>
        ///Convenient and simple action to access a URL, optionally following redirections. Returns the request sent and response received and followed redirections, if any. Other actions are available which offer more control on what is sent, like, 'sendRequest' or 'sendHarRequest'.
        /// </summary>
        /// <returns></returns>
        public IApiResponse AccessUrl(string url, string followRedirects)
        {
            var parameters = new Dictionary<string, string> { { "url", url }, { "followRedirects", followRedirects } };
            return _api.CallApi("core", "action", "accessUrl", parameters);
        }

        /// <summary>
        ///Shuts down ZAP
        /// </summary>
        /// <returns></returns>
        public IApiResponse Shutdown()
        {
            return _api.CallApi("core", "action", "shutdown", null);
        }

        /// <summary>
        ///Creates a new session, optionally overwriting existing files. If a relative path is specified it will be resolved against the "session" directory in ZAP "home" dir.
        /// </summary>
        /// <returns></returns>
        public IApiResponse NewSession(string name, string overwrite)
        {
            var parameters = new Dictionary<string, string> { { "name", name }, { "overwrite", overwrite } };
            return _api.CallApi("core", "action", "newSession", parameters);
        }

        /// <summary>
        ///Loads the session with the given name. If a relative path is specified it will be resolved against the "session" directory in ZAP "home" dir.
        /// </summary>
        /// <returns></returns>
        public IApiResponse LoadSession(string name)
        {
            var parameters = new Dictionary<string, string> { { "name", name } };
            return _api.CallApi("core", "action", "loadSession", parameters);
        }

        /// <summary>
        ///Saves the session with the name supplied, optionally overwriting existing files. If a relative path is specified it will be resolved against the "session" directory in ZAP "home" dir.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SaveSession(string name, string overwrite)
        {
            var parameters = new Dictionary<string, string> { { "name", name }, { "overwrite", overwrite } };
            return _api.CallApi("core", "action", "saveSession", parameters);
        }

        /// <summary>
        ///Snapshots the session, optionally with the given name, and overwriting existing files. If no name is specified the name of the current session with a timestamp appended is used. If a relative path is specified it will be resolved against the "session" directory in ZAP "home" dir.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SnapshotSession(string name, string overwrite)
        {
            var parameters = new Dictionary<string, string> { { "name", name }, { "overwrite", overwrite } };
            return _api.CallApi("core", "action", "snapshotSession", parameters);
        }

        /// <summary>
        ///Clears the regexes of URLs excluded from the local proxies.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ClearExcludedFromProxy()
        {
            return _api.CallApi("core", "action", "clearExcludedFromProxy", null);
        }

        /// <summary>
        ///Adds a regex of URLs that should be excluded from the local proxies.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ExcludeFromProxy(string regex)
        {
            var parameters = new Dictionary<string, string> { { "regex", regex } };
            return _api.CallApi("core", "action", "excludeFromProxy", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetHomeDirectory(string dir)
        {
            var parameters = new Dictionary<string, string> { { "dir", dir } };
            return _api.CallApi("core", "action", "setHomeDirectory", parameters);
        }

        /// <summary>
        ///Sets the mode, which may be one of [safe, protect, standard, attack]
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetMode(string mode)
        {
            var parameters = new Dictionary<string, string> { { "mode", mode } };
            return _api.CallApi("core", "action", "setMode", parameters);
        }

        /// <summary>
        ///Generates a new Root CA certificate for the local proxies.
        /// </summary>
        /// <returns></returns>
        public IApiResponse GenerateRootCa()
        {
            return _api.CallApi("core", "action", "generateRootCA", null);
        }

        /// <summary>
        ///Sends the HTTP request, optionally following redirections. Returns the request sent and response received and followed redirections, if any. The Mode is enforced when sending the request (and following redirections), custom manual requests are not allowed in 'Safe' mode nor in 'Protected' mode if out of scope.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SendRequest(string request, string followRedirects)
        {
            var parameters = new Dictionary<string, string>
            {
                {"request", request}, {"followRedirects", followRedirects}
            };
            return _api.CallApi("core", "action", "sendRequest", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse RunGarbageCollection()
        {
            return _api.CallApi("core", "action", "runGarbageCollection", null);
        }

        /// <summary>
        ///Deletes the site node found in the Sites Tree on the basis of the URL, HTTP method, and post data (if applicable and specified). 
        /// </summary>
        /// <returns></returns>
        public IApiResponse DeleteSiteNode(string url, string method, string postData)
        {
            var parameters = new Dictionary<string, string> { { "url", url }, { "method", method }, { "postData", postData } };
            return _api.CallApi("core", "action", "deleteSiteNode", parameters);
        }

        /// <summary>
        ///Adds a domain to be excluded from the outgoing proxy, using the specified value. Optionally sets if the new entry is enabled (default, true) and whether or not the new value is specified as a regex (default, false).
        /// </summary>
        /// <returns></returns>
        public IApiResponse AddProxyChainExcludedDomain(string value, string isRegex, string isEnabled)
        {
            var parameters = new Dictionary<string, string>
            {
                {"value", value}, {"isRegex", isRegex}, {"isEnabled", isEnabled}
            };
            return _api.CallApi("core", "action", "addProxyChainExcludedDomain", parameters);
        }

        /// <summary>
        ///Modifies a domain excluded from the outgoing proxy. Allows to modify the value, if enabled or if a regex. The domain is selected with its index, which can be obtained with the view proxyChainExcludedDomains.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ModifyProxyChainExcludedDomain(string idx, string value, string isRegex, string isEnabled)
        {
            var parameters = new Dictionary<string, string>
            {
                {"idx", idx}, {"value", value}, {"isRegex", isRegex}, {"isEnabled", isEnabled}
            };
            return _api.CallApi("core", "action", "modifyProxyChainExcludedDomain", parameters);
        }

        /// <summary>
        ///Removes a domain excluded from the outgoing proxy, with the given index. The index can be obtained with the view proxyChainExcludedDomains.
        /// </summary>
        /// <returns></returns>
        public IApiResponse RemoveProxyChainExcludedDomain(string idx)
        {
            var parameters = new Dictionary<string, string> { { "idx", idx } };
            return _api.CallApi("core", "action", "removeProxyChainExcludedDomain", parameters);
        }

        /// <summary>
        ///Enables all domains excluded from the outgoing proxy.
        /// </summary>
        /// <returns></returns>
        public IApiResponse EnableAllProxyChainExcludedDomains()
        {
            return _api.CallApi("core", "action", "enableAllProxyChainExcludedDomains", null);
        }

        /// <summary>
        ///Disables all domains excluded from the outgoing proxy.
        /// </summary>
        /// <returns></returns>
        public IApiResponse DisableAllProxyChainExcludedDomains()
        {
            return _api.CallApi("core", "action", "disableAllProxyChainExcludedDomains", null);
        }

        /// <summary>
        ///Sets the maximum number of alert instances to include in a report. A value of zero is treated as unlimited.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMaximumAlertInstances(string numberOfInstances)
        {
            var parameters = new Dictionary<string, string> { { "numberOfInstances", numberOfInstances } };
            return _api.CallApi("core", "action", "setOptionMaximumAlertInstances", parameters);
        }

        /// <summary>
        ///Sets whether or not related alerts will be merged in any reports generated.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionMergeRelatedAlerts(string enabled)
        {
            var parameters = new Dictionary<string, string> { { "enabled", enabled } };
            return _api.CallApi("core", "action", "setOptionMergeRelatedAlerts", parameters);
        }

        /// <summary>
        ///Sets (or clears, if empty) the path to the file with alert overrides.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionAlertOverridesFilePath(string filepath)
        {
            var parameters = new Dictionary<string, string> { { "filePath", filepath } };
            return _api.CallApi("core", "action", "setOptionAlertOverridesFilePath", parameters);
        }

        /// <summary>
        ///Enables use of a PKCS12 client certificate for the certificate with the given file system path, password, and optional index.
        /// </summary>
        /// <returns></returns>
        public IApiResponse EnablePkcs12ClientCertificate(string filepath, string password, string index)
        {
            var parameters = new Dictionary<string, string>
            {
                {"filePath", filepath}, {"password", password}, {"index", index}
            };
            return _api.CallApi("core", "action", "enablePKCS12ClientCertificate", parameters);
        }

        /// <summary>
        ///Disables the option for use of client certificates.
        /// </summary>
        /// <returns></returns>
        public IApiResponse DisableClientCertificate()
        {
            return _api.CallApi("core", "action", "disableClientCertificate", null);
        }

        /// <summary>
        ///Deletes all alerts of the current session.
        /// [Obsolete] Use the API endpoint with the same name in the 'alert' component instead.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Use the API endpoint with the same name in the 'alert' component instead.")]
        public IApiResponse DeleteAllAlerts()
        {
            return _api.CallApi("core", "action", "deleteAllAlerts", null);
        }

        /// <summary>
        ///Deletes the alert with the given ID. 
        /// [Obsolete] Use the API endpoint with the same name in the 'alert' component instead.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Use the API endpoint with the same name in the 'alert' component instead.")]
        public IApiResponse DeleteAlert(string id)
        {
            var parameters = new Dictionary<string, string> { { "id", id } };
            return _api.CallApi("core", "action", "deleteAlert", parameters);
        }

        /// <summary>
        ///Sets the user agent that ZAP should use when creating HTTP messages (for example, spider messages or CONNECT requests to outgoing proxy).
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionDefaultUserAgent(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("core", "action", "setOptionDefaultUserAgent", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionProxyChainName(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("core", "action", "setOptionProxyChainName", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionProxyChainPassword(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("core", "action", "setOptionProxyChainPassword", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionProxyChainRealm(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("core", "action", "setOptionProxyChainRealm", parameters);
        }

        /// <summary>
        ///Use actions [add|modify|remove]ProxyChainExcludedDomain instead.
        /// [Obsolete] Option no longer in effective use.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Option no longer in effective use.")]
        public IApiResponse SetOptionProxyChainSkipName(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("core", "action", "setOptionProxyChainSkipName", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionProxyChainUserName(string str)
        {
            var parameters = new Dictionary<string, string> { { "String", str } };
            return _api.CallApi("core", "action", "setOptionProxyChainUserName", parameters);
        }

        /// <summary>
        ///Sets the TTL (in seconds) of successful DNS queries (applies after ZAP restart).
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionDnsTtlSuccessfulQueries(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("core", "action", "setOptionDnsTtlSuccessfulQueries", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionHttpStateEnabled(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("core", "action", "setOptionHttpStateEnabled", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionProxyChainPort(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("core", "action", "setOptionProxyChainPort", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionProxyChainPrompt(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("core", "action", "setOptionProxyChainPrompt", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionSingleCookieRequestHeader(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("core", "action", "setOptionSingleCookieRequestHeader", parameters);
        }

        /// <summary>
        ///Sets the connection time out, in seconds.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionTimeoutInSecs(int i)
        {
            var parameters = new Dictionary<string, string> { { "Integer", Convert.ToString(i) } };
            return _api.CallApi("core", "action", "setOptionTimeoutInSecs", parameters);
        }

        /// <summary>
        ///Sets whether or not the outgoing proxy should be used. The address/hostname of the outgoing proxy must be set to enable this option.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionUseProxyChain(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("core", "action", "setOptionUseProxyChain", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionUseProxyChainAuth(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("core", "action", "setOptionUseProxyChainAuth", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public byte[] ProxyPac()
        {
            return _api.CallApiOther("core", "other", "proxy.pac", null);
        }

        /// <summary>
        ///Gets the Root CA certificate used by the local proxies.
        /// </summary>
        /// <returns></returns>
        public byte[] RootCert()
        {
            return _api.CallApiOther("core", "other", "rootcert", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public byte[] SetProxy(string proxy)
        {
            var parameters = new Dictionary<string, string> { { "proxy", proxy } };
            return _api.CallApiOther("core", "other", "setproxy", parameters);
        }

        /// <summary>
        ///Generates a report in XML format
        /// </summary>
        /// <returns></returns>
        public byte[] XmlReport()
        {
            return _api.CallApiOther("core", "other", "xmlreport", null);
        }

        /// <summary>
        ///Generates a report in HTML format
        /// </summary>
        /// <returns></returns>
        public byte[] HtmlReport()
        {
            return _api.CallApiOther("core", "other", "htmlreport", null);
        }

        /// <summary>
        ///Generates a report in JSON format
        /// </summary>
        /// <returns></returns>
        public byte[] JsonReport()
        {
            return _api.CallApiOther("core", "other", "jsonreport", null);
        }

        /// <summary>
        ///Generates a report in Markdown format
        /// </summary>
        /// <returns></returns>
        public byte[] MdReport()
        {
            return _api.CallApiOther("core", "other", "mdreport", null);
        }

        /// <summary>
        ///Gets the message with the given ID in HAR format
        /// </summary>
        /// <returns></returns>
        public byte[] MessageHar(string id)
        {
            var parameters = new Dictionary<string, string> { { "id", id } };
            return _api.CallApiOther("core", "other", "messageHar", parameters);
        }

        /// <summary>
        ///Gets the HTTP messages sent through/by ZAP, in HAR format, optionally filtered by URL and paginated with 'start' position and 'count' of messages
        /// </summary>
        /// <returns></returns>
        public byte[] MessagesHar(string baseUrl, string start, string count)
        {
            var parameters = new Dictionary<string, string> { { "baseUrl", baseUrl }, { "start", start }, { "count", count } };
            return _api.CallApiOther("core", "other", "messagesHar", parameters);
        }

        /// <summary>
        ///Gets the HTTP messages with the given IDs, in HAR format.
        /// </summary>
        /// <returns></returns>
        public byte[] MessagesHarById(string ids)
        {
            var parameters = new Dictionary<string, string> { { "ids", ids } };
            return _api.CallApiOther("core", "other", "messagesHarById", parameters);
        }

        /// <summary>
        ///Sends the first HAR request entry, optionally following redirections. Returns, in HAR format, the request sent and response received and followed redirections, if any. The Mode is enforced when sending the request (and following redirections), custom manual requests are not allowed in 'Safe' mode nor in 'Protected' mode if out of scope.
        /// </summary>
        /// <returns></returns>
        public byte[] SendHarRequest(string request, string followRedirects)
        {
            var parameters = new Dictionary<string, string>
            {
                {"request", request}, {"followRedirects", followRedirects}
            };
            return _api.CallApiOther("core", "other", "sendHarRequest", parameters);
        }

    }
}
