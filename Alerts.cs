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


using System;

namespace OWASPZAPDotNetAPI
{
    public class Alert
    {
        public enum RiskLevel { Informational, Low, Medium, High }
        [Obsolete("Use of ReliabilityLevel has been deprecated from 2.4.0 in favor of using ConfidenceLevel.")]
        public enum ReliabilityLevel { Suspicious, Warning }
        public enum ConfidenceLevel { Low, Medium, High, Confirmed }
        public string AlertMessage { get; }
        public RiskLevel Risk { get; set; }

        [Obsolete("Use of Reliability has been deprecated from 2.4.0 in favor of using Confidence.")]
        public ReliabilityLevel Reliability { get; set; }
        public ConfidenceLevel Confidence { get; set; }
        public string Url { get; }
        public string Other { get; set; }
        public string Parameter { get; set; }
        public string Attack { get; set; }
        public string Evidence { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public string Solution { get; set; }
        public int CweId { get; set; }
        public int WascId { get; set; }

        public Alert(string alert, string url)
        {
            AlertMessage = alert;
            Url = url;
        }

        public Alert(string alert, string url, RiskLevel risk, ConfidenceLevel confidence)
            :
            this(alert, url)
        {
            Risk = risk;
            Confidence = confidence;
        }

        public Alert(string alert, string url, RiskLevel risk, ConfidenceLevel confidence, string parameter, string other)
            :
            this(alert, url, risk, confidence)
        {
            Other = other;
            Parameter = parameter;
        }

        public Alert(string alert, string url, RiskLevel risk, ConfidenceLevel confidence,
            string parameter, string other, string attack, string description, string reference, string solution,
            string evidence, int cweId, int wascId)
            :
            this(alert, url, risk, confidence, parameter, other)
        {
            Attack = attack;
            Description = description;
            Reference = reference;
            Solution = solution;
            Evidence = evidence;
            CweId = cweId;
            WascId = wascId;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var alertToComplete = (Alert)obj;

            if (AlertMessage == null)
            {
                if (alertToComplete.AlertMessage != null)
                {
                    return false;
                }
            }
            else if (!AlertMessage.Equals(alertToComplete.AlertMessage))
            {
                return false;
            }

            if (!Risk.Equals(alertToComplete.Risk))
            {
                return false;
            }

            if (!Confidence.Equals(alertToComplete.Confidence))
            {
                return false;
            }

            if (Url == null)
            {
                if (alertToComplete.Url != null)
                {
                    return false;
                }
            }
            else if (!Url.Equals(alertToComplete.Url))
            {
                return false;
            }

            if (Other == null)
            {
                if (alertToComplete.Other != null)
                {
                    return false;
                }
            }
            else if (!Other.Equals(alertToComplete.Other))
            {
                return false;
            }

            if (Parameter == null)
            {
                if (alertToComplete.Parameter != null)
                {
                    return false;
                }
            }
            else if (!Parameter.Equals(alertToComplete.Parameter))
            {
                return false;
            }

            if (Attack == null)
            {
                if (alertToComplete.Attack != null)
                {
                    return false;
                }
            }
            else if (!Attack.Equals(alertToComplete.Attack))
            {
                return false;
            }

            if (Evidence == null)
            {
                if (alertToComplete.Evidence != null)
                {
                    return false;
                }
            }
            else if (!Evidence.Equals(alertToComplete.Evidence))
            {
                return false;
            }

            if (Description == null)
            {
                if (alertToComplete.Description != null)
                {
                    return false;
                }
            }
            else if (!Description.Equals(alertToComplete.Description))
            {
                return false;
            }

            if (Reference == null)
            {
                if (alertToComplete.Reference != null)
                {
                    return false;
                }
            }
            else if (!Reference.Equals(alertToComplete.Reference))
            {
                return false;
            }

            if (Solution == null)
            {
                if (alertToComplete.Solution != null)
                {
                    return false;
                }
            }
            else if (!Solution.Equals(alertToComplete.Solution))
            {
                return false;
            }

            if (CweId != alertToComplete.CweId)
            {
                return false;
            }

            if (WascId != alertToComplete.WascId)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(AlertMessage);
            hash.Add(Risk);
            hash.Add(Confidence);
            hash.Add(Url);
            hash.Add(Other);
            hash.Add(Parameter);
            hash.Add(Attack);
            hash.Add(Evidence);
            hash.Add(Description);
            hash.Add(Reference);
            hash.Add(Solution);
            hash.Add(CweId);
            hash.Add(WascId);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
