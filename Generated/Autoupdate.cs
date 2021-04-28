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
    public class AutoUpdate
    {
        private readonly ClientApi _api;

        public AutoUpdate(ClientApi api)
        {
            _api = api;
        }

        /// <summary>
        ///Returns the latest version number
        /// </summary>
        /// <returns></returns>
        public IApiResponse LatestVersionNumber()
        {
            return _api.CallApi("autoupdate", "view", "latestVersionNumber", null);
        }

        /// <summary>
        ///Returns 'true' if ZAP is on the latest version
        /// </summary>
        /// <returns></returns>
        public IApiResponse IsLatestVersion()
        {
            return _api.CallApi("autoupdate", "view", "isLatestVersion", null);
        }

        /// <summary>
        ///Return a list of all of the installed add-ons
        /// </summary>
        /// <returns></returns>
        public IApiResponse InstalledAddons()
        {
            return _api.CallApi("autoupdate", "view", "installedAddons", null);
        }

        /// <summary>
        ///Returns a list with all local add-ons, installed or not.
        /// </summary>
        /// <returns></returns>
        public IApiResponse LocalAddons()
        {
            return _api.CallApi("autoupdate", "view", "localAddons", null);
        }

        /// <summary>
        ///Return a list of any add-ons that have been added to the Marketplace since the last check for updates
        /// </summary>
        /// <returns></returns>
        public IApiResponse NewAddons()
        {
            return _api.CallApi("autoupdate", "view", "newAddons", null);
        }

        /// <summary>
        ///Return a list of any add-ons that have been changed in the Marketplace since the last check for updates
        /// </summary>
        /// <returns></returns>
        public IApiResponse UpdatedAddons()
        {
            return _api.CallApi("autoupdate", "view", "updatedAddons", null);
        }

        /// <summary>
        ///Return a list of all of the add-ons on the ZAP Marketplace (this information is read once and then cached)
        /// </summary>
        /// <returns></returns>
        public IApiResponse MarketplaceAddons()
        {
            return _api.CallApi("autoupdate", "view", "marketplaceAddons", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionAddonDirectories()
        {
            return _api.CallApi("autoupdate", "view", "optionAddonDirectories", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionDayLastChecked()
        {
            return _api.CallApi("autoupdate", "view", "optionDayLastChecked", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionDayLastInstallWarned()
        {
            return _api.CallApi("autoupdate", "view", "optionDayLastInstallWarned", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionDayLastUpdateWarned()
        {
            return _api.CallApi("autoupdate", "view", "optionDayLastUpdateWarned", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionDownloadDirectory()
        {
            return _api.CallApi("autoupdate", "view", "optionDownloadDirectory", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionCheckAddonUpdates()
        {
            return _api.CallApi("autoupdate", "view", "optionCheckAddonUpdates", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionCheckOnStart()
        {
            return _api.CallApi("autoupdate", "view", "optionCheckOnStart", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionDownloadNewRelease()
        {
            return _api.CallApi("autoupdate", "view", "optionDownloadNewRelease", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionInstallAddonUpdates()
        {
            return _api.CallApi("autoupdate", "view", "optionInstallAddonUpdates", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionInstallScannerRules()
        {
            return _api.CallApi("autoupdate", "view", "optionInstallScannerRules", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionReportAlphaAddons()
        {
            return _api.CallApi("autoupdate", "view", "optionReportAlphaAddons", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionReportBetaAddons()
        {
            return _api.CallApi("autoupdate", "view", "optionReportBetaAddons", null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse OptionReportReleaseAddons()
        {
            return _api.CallApi("autoupdate", "view", "optionReportReleaseAddons", null);
        }

        /// <summary>
        ///Downloads the latest release, if any 
        /// </summary>
        /// <returns></returns>
        public IApiResponse DownloadLatestRelease()
        {
            return _api.CallApi("autoupdate", "action", "downloadLatestRelease", null);
        }

        /// <summary>
        ///Installs or updates the specified add-on, returning when complete (ie not asynchronously)
        /// </summary>
        /// <returns></returns>
        public IApiResponse InstallAddon(string id)
        {
            var parameters = new Dictionary<string, string> { { "id", id } };
            return _api.CallApi("autoupdate", "action", "installAddon", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse InstallLocalAddon(string file)
        {
            var parameters = new Dictionary<string, string> { { "file", file } };
            return _api.CallApi("autoupdate", "action", "installLocalAddon", parameters);
        }

        /// <summary>
        ///Uninstalls the specified add-on 
        /// </summary>
        /// <returns></returns>
        public IApiResponse UninstallAddon(string id)
        {
            var parameters = new Dictionary<string, string> { { "id", id } };
            return _api.CallApi("autoupdate", "action", "uninstallAddon", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionCheckAddonUpdates(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("autoupdate", "action", "setOptionCheckAddonUpdates", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionCheckOnStart(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("autoupdate", "action", "setOptionCheckOnStart", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionDownloadNewRelease(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("autoupdate", "action", "setOptionDownloadNewRelease", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionInstallAddonUpdates(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("autoupdate", "action", "setOptionInstallAddonUpdates", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionInstallScannerRules(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("autoupdate", "action", "setOptionInstallScannerRules", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionReportAlphaAddons(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("autoupdate", "action", "setOptionReportAlphaAddons", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionReportBetaAddons(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("autoupdate", "action", "setOptionReportBetaAddons", parameters);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public IApiResponse SetOptionReportReleaseAddons(bool boolean)
        {
            var parameters = new Dictionary<string, string> { { "Boolean", Convert.ToString(boolean) } };
            return _api.CallApi("autoupdate", "action", "setOptionReportReleaseAddons", parameters);
        }

    }
}
