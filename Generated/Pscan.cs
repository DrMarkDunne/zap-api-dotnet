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
    public class PScan
    {
        private readonly ClientApi _api;

        public PScan(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Tells whether or not the passive scan should be performed only on messages that are in scope.
        /// </summary>
        /// <returns></returns>
        public IApiResponse ScanOnlyInScope()
        {
            return _api.CallApi("pscan", "view", "scanOnlyInScope", null);
        }

        /// <summary>
        ///The number of records the passive scanner still has to scan
        /// </summary>
        /// <returns></returns>
        public IApiResponse RecordsToScan()
        {
            return _api.CallApi("pscan", "view", "recordsToScan", null);
        }

        /// <summary>
        ///Lists all passive scanners with its ID, name, enabled state and alert threshold.
        /// </summary>
        /// <returns></returns>
        public IApiResponse Scanners()
        {
            return _api.CallApi("pscan", "view", "scanners", null);
        }

        /// <summary>
        ///Show information about the passive scan rule currently being run (if any).
        /// </summary>
        /// <returns></returns>
        public IApiResponse CurrentRule()
        {
            return _api.CallApi("pscan", "view", "currentRule", null);
        }

        /// <summary>
        ///Gets the maximum number of alerts a passive scan rule should raise.
        /// </summary>
        /// <returns></returns>
        public IApiResponse MaxAlertsPerRule()
        {
            return _api.CallApi("pscan", "view", "maxAlertsPerRule", null);
        }

        /// <summary>
        ///Sets whether or not the passive scanning is enabled (Note: the enabled state is not persisted).
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetEnabled(string enabled)
        {
            var parameters = new Dictionary<string, string> { { "enabled", enabled } };
            return _api.CallApi("pscan", "action", "setEnabled", parameters);
        }

        /// <summary>
        ///Sets whether or not the passive scan should be performed only on messages that are in scope.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetScanOnlyInScope(string onlyInScope)
        {
            var parameters = new Dictionary<string, string> { { "onlyInScope", onlyInScope } };
            return _api.CallApi("pscan", "action", "setScanOnlyInScope", parameters);
        }

        /// <summary>
        ///Enables all passive scanners
        /// </summary>
        /// <returns></returns>
        public IApiResponse EnableAllScanners()
        {
            return _api.CallApi("pscan", "action", "enableAllScanners", null);
        }

        /// <summary>
        ///Disables all passive scanners
        /// </summary>
        /// <returns></returns>
        public IApiResponse DisableAllScanners()
        {
            return _api.CallApi("pscan", "action", "disableAllScanners", null);
        }

        /// <summary>
        ///Enables all passive scanners with the given IDs (comma separated list of IDs)
        /// </summary>
        /// <returns></returns>
        public IApiResponse EnableScanners(string ids)
        {
            var parameters = new Dictionary<string, string> { { "ids", ids } };
            return _api.CallApi("pscan", "action", "enableScanners", parameters);
        }

        /// <summary>
        ///Disables all passive scanners with the given IDs (comma separated list of IDs)
        /// </summary>
        /// <returns></returns>
        public IApiResponse DisableScanners(string ids)
        {
            var parameters = new Dictionary<string, string> { { "ids", ids } };
            return _api.CallApi("pscan", "action", "disableScanners", parameters);
        }

        /// <summary>
        ///Sets the alert threshold of the passive scanner with the given ID, accepted values for alert threshold: OFF, DEFAULT, LOW, MEDIUM and HIGH
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetScannerAlertThreshold(string id, string alertThreshold)
        {
            var parameters = new Dictionary<string, string> { { "id", id }, { "alertThreshold", alertThreshold } };
            return _api.CallApi("pscan", "action", "setScannerAlertThreshold", parameters);
        }

        /// <summary>
        ///Sets the maximum number of alerts a passive scan rule should raise.
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetMaxAlertsPerRule(string maxAlerts)
        {
            var parameters = new Dictionary<string, string> { { "maxAlerts", maxAlerts } };
            return _api.CallApi("pscan", "action", "setMaxAlertsPerRule", parameters);
        }
    }
}
