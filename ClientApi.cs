/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright the ZAP development team
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


using OWASPZAPDotNetAPI.Generated;
using OWASPZAPDotNetAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace OWASPZAPDotNetAPI
{
    public sealed class ClientApi : IDisposable
    {
        private readonly IWebClient _webClient;

        private const string ApiDomain = "zap";
        private const int ApiPort = 80;

        private readonly string _apiKey;
        private const string Format = "xml";
        private const string OtherFormat = "other";
        private const string ZapApiKeyHeaderName = "X-ZAP-API-Key";
        private static readonly string ZapApiKeyParameterName = "apiKey";

        //New API needs to be added here, preferably in alphabetical order
        public Acsrf Acsrf;
        public AjaxSpider AjaxSpider;
        public Generated.Alert Alert;
        public AlertFilter AlertFilter;
        public Ascan Ascan;
        public Authentication Authentication;
        public Authorization Authorization;
        public AutoUpdate AutoUpdate;
        public Break Brk;
        public Context Context;
        public Core Core;
        public ForcedUser ForcedUser;
        public HttpSessions HttpSessions;
        public ImportLogFiles ImportLogFiles;
        public ImportUrls ImportUrls;
        public LocalProxies LocalProxies;
        public OpenApi OpenApi;
        public Params Parameters;
        public Pnh Pnh;
        public PScan PScan;
        public Replacer Replacer;
        public Reveal Reveal;
        public RuleConfig RuleConfig;
        public Script Script;
        public Search Search;
        public Selenium Selenium;
        public SessionManagement SessionManagement;
        public Soap Soap;
        public Spider Spider;
        public Stats Stats;
        public Users Users;
        public Websocket Websocket;

        public ClientApi(string zapAddress, int zapPort, string apiKey)
        {
            _apiKey = apiKey;

            _webClient = new SystemWebClient(zapAddress, zapPort);

            InitializeApiObjects();
        }

        private void InitializeApiObjects()
        {
            //New API needs to be instantiated here, in the same alphabetical order as above
            Acsrf = new Acsrf(this);
            AjaxSpider = new AjaxSpider(this);
            Alert = new Generated.Alert(this);
            AlertFilter = new AlertFilter(this);
            Ascan = new Ascan(this);
            Authentication = new Authentication(this);
            Authorization = new Authorization(this);
            AutoUpdate = new AutoUpdate(this);
            Brk = new Break(this);
            Context = new Context(this);
            Core = new Core(this);
            ForcedUser = new ForcedUser(this);
            HttpSessions = new HttpSessions(this);
            ImportLogFiles = new ImportLogFiles(this);
            ImportUrls = new ImportUrls(this);
            LocalProxies = new LocalProxies(this);
            OpenApi = new OpenApi(this);
            Parameters = new Params(this);
            Pnh = new Pnh(this);
            PScan = new PScan(this);
            Replacer = new Replacer(this);
            Reveal = new Reveal(this);
            RuleConfig = new RuleConfig(this);
            Script = new Script(this);
            Search = new Search(this);
            Selenium = new Selenium(this);
            SessionManagement = new SessionManagement(this);
            Soap = new Soap(this);
            Spider = new Spider(this);
            Stats = new Stats(this);
            Users = new Users(this);
            Websocket = new Websocket(this);
        }

        public void AccessUrl(string url)
        {
            _webClient.DownloadString(url);
        }

        [Obsolete("Obsolete")]
        public List<Alert> GetAlerts(string baseUrl, int start, int count, string riskId)
        {
            var alerts = new List<Alert>();
            var response = Core.Alerts(baseUrl, Convert.ToString(start), Convert.ToString(count), riskId);
            if (response is not ApiResponseList apiResponseList) return alerts;
            alerts.AddRange(from ApiResponseSet apiResponseSet in apiResponseList.List select GetNewAlertFromAResponseSet(apiResponseSet));
            return alerts;
        }

        private static Alert GetNewAlertFromAResponseSet(ApiResponseSet apiResponseSet)
        {
            return new(apiResponseSet.Dictionary.TryGetDictionaryString("alert"), apiResponseSet.Dictionary.TryGetDictionaryString("url"))
            {
                Attack = apiResponseSet.Dictionary.TryGetDictionaryString("attack"),
                Confidence = string.IsNullOrWhiteSpace(apiResponseSet.Dictionary.TryGetDictionaryString("confidence")) ?
                    OWASPZAPDotNetAPI.Alert.ConfidenceLevel.Low :
                    (Alert.ConfidenceLevel)Enum.Parse(typeof(Alert.ConfidenceLevel), apiResponseSet.Dictionary.TryGetDictionaryString("confidence")),
                CweId = int.Parse(apiResponseSet.Dictionary.TryGetDictionaryString("cweid")),
                Description = apiResponseSet.Dictionary.TryGetDictionaryString("description"),
                Evidence = apiResponseSet.Dictionary.TryGetDictionaryString("evidence"),
                Other = apiResponseSet.Dictionary.TryGetDictionaryString("other"),
                Parameter = apiResponseSet.Dictionary.TryGetDictionaryString("param"),
                Reference = apiResponseSet.Dictionary.TryGetDictionaryString("reference"),
                Risk = string.IsNullOrWhiteSpace(apiResponseSet.Dictionary.TryGetDictionaryString("risk")) ?
                    OWASPZAPDotNetAPI.Alert.RiskLevel.Low :
                    (Alert.RiskLevel)Enum.Parse(typeof(Alert.RiskLevel), apiResponseSet.Dictionary.TryGetDictionaryString("risk")),
                Solution = apiResponseSet.Dictionary.TryGetDictionaryString("solution"),
                WascId = int.Parse(apiResponseSet.Dictionary.TryGetDictionaryString("wascid"))
            };

        }

        public IApiResponse CallApi(string component, string operationType, string operationName, Dictionary<string, string> parameters)
        {
            var xmlDocument = CallApiRaw(component, operationType, operationName, parameters);
            return ApiResponseFactory.GetResponse(xmlDocument.ChildNodes[1]);
        }

        private XmlDocument CallApiRaw(string component, string operationType, string operationName, Dictionary<string, string> parameters)
        {
            var requestUrl = PrepareZapRequest(Format, component, operationType, operationName, parameters);
            var responseString = _webClient.DownloadString(requestUrl);
            var responseXmlDocument = new XmlDocument();
            responseXmlDocument.LoadXml(responseString);
            return responseXmlDocument;
        }

        public byte[] CallApiOther(string component, string operationType, string operationName, Dictionary<string, string> parameters)
        {
            var requestUrl = PrepareZapRequest(OtherFormat, component, operationType, operationName, parameters);
            var response = _webClient.DownloadData(requestUrl);
            return response;
        }

        private Uri PrepareZapRequest(string format, string component, string operationType, string operationName, Dictionary<string, string> parameters)
        {
            var requestUrl = BuildZapRequestUrl(_apiKey, format, component, operationType, operationName, parameters);
            var apiKeyValueFromRequestHeader = _webClient.GetRequestHeaderValue(ZapApiKeyHeaderName);
            if (string.IsNullOrWhiteSpace(apiKeyValueFromRequestHeader))
            {
                _webClient.AddRequestHeader(ZapApiKeyHeaderName, _apiKey);
            }
            return requestUrl;
        }

        private static Uri BuildZapRequestUrl(string apiKey, string format, string component, string operationType, string operationName, Dictionary<string, string> parameters)
        {
            var uriBuilder = new UriBuilder
            {
                Scheme = "http",
                Host = ApiDomain,
                Port = ApiPort,
                Path = $"{format}/{component}/{operationType}/{operationName}"
            };



            var query = new StringBuilder();
            if (parameters != null)
            {
                foreach (var (key, value) in parameters)
                {
                    query.Append($"{Uri.EscapeDataString(key)}={Uri.EscapeDataString(value)}&");
                }
            }

            if (!string.IsNullOrWhiteSpace(apiKey))
            {
                query.Append($"{Uri.EscapeDataString(ZapApiKeyParameterName)}={Uri.EscapeDataString(apiKey)}&");
            }


            uriBuilder.Query = query.ToString();
            return uriBuilder.Uri;
        }

        void IDisposable.Dispose()
        {
            ((IDisposable)_webClient).Dispose();
        }
    }
}
