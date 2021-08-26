/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// RiskV1ExportComplianceInquiriesPost201Response
    /// </summary>
    [DataContract]
    public partial class RiskV1ExportComplianceInquiriesPost201Response :  IEquatable<RiskV1ExportComplianceInquiriesPost201Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskV1ExportComplianceInquiriesPost201Response" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="Id">An unique identification number generated by Cybersource to identify the submitted request. Returned by all services. It is also appended to the endpoint of the resource. On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. .</param>
        /// <param name="SubmitTimeUtc">Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services. .</param>
        /// <param name="SubmitTimeLocal">Time that the transaction was submitted in local time. Generated by Cybersource..</param>
        /// <param name="Status">The status for the call can be: - COMPLETED - INVALID_REQUEST - DECLINED .</param>
        /// <param name="Message">The message describing the reason of the status. Value can be   - The customer matched the Denied Parties List   - The Export bill_country/ship_country  match   - Export email_country match   - Export hostname_country/ip_country match .</param>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="ExportComplianceInformation">ExportComplianceInformation.</param>
        /// <param name="ErrorInformation">ErrorInformation.</param>
        public RiskV1ExportComplianceInquiriesPost201Response(PtsV2IncrementalAuthorizationPatch201ResponseLinks Links = default(PtsV2IncrementalAuthorizationPatch201ResponseLinks), string Id = default(string), string SubmitTimeUtc = default(string), string SubmitTimeLocal = default(string), string Status = default(string), string Message = default(string), RiskV1DecisionsPost201ResponseClientReferenceInformation ClientReferenceInformation = default(RiskV1DecisionsPost201ResponseClientReferenceInformation), RiskV1ExportComplianceInquiriesPost201ResponseExportComplianceInformation ExportComplianceInformation = default(RiskV1ExportComplianceInquiriesPost201ResponseExportComplianceInformation), RiskV1ExportComplianceInquiriesPost201ResponseErrorInformation ErrorInformation = default(RiskV1ExportComplianceInquiriesPost201ResponseErrorInformation))
        {
            this.Links = Links;
            this.Id = Id;
            this.SubmitTimeUtc = SubmitTimeUtc;
            this.SubmitTimeLocal = SubmitTimeLocal;
            this.Status = Status;
            this.Message = Message;
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.ExportComplianceInformation = ExportComplianceInformation;
            this.ErrorInformation = ErrorInformation;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public PtsV2IncrementalAuthorizationPatch201ResponseLinks Links { get; set; }

        /// <summary>
        /// An unique identification number generated by Cybersource to identify the submitted request. Returned by all services. It is also appended to the endpoint of the resource. On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. 
        /// </summary>
        /// <value>An unique identification number generated by Cybersource to identify the submitted request. Returned by all services. It is also appended to the endpoint of the resource. On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services. 
        /// </summary>
        /// <value>Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services. </value>
        [DataMember(Name="submitTimeUtc", EmitDefaultValue=false)]
        public string SubmitTimeUtc { get; set; }

        /// <summary>
        /// Time that the transaction was submitted in local time. Generated by Cybersource.
        /// </summary>
        /// <value>Time that the transaction was submitted in local time. Generated by Cybersource.</value>
        [DataMember(Name="submitTimeLocal", EmitDefaultValue=false)]
        public string SubmitTimeLocal { get; set; }

        /// <summary>
        /// The status for the call can be: - COMPLETED - INVALID_REQUEST - DECLINED 
        /// </summary>
        /// <value>The status for the call can be: - COMPLETED - INVALID_REQUEST - DECLINED </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The message describing the reason of the status. Value can be   - The customer matched the Denied Parties List   - The Export bill_country/ship_country  match   - Export email_country match   - Export hostname_country/ip_country match 
        /// </summary>
        /// <value>The message describing the reason of the status. Value can be   - The customer matched the Denied Parties List   - The Export bill_country/ship_country  match   - Export email_country match   - Export hostname_country/ip_country match </value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public RiskV1DecisionsPost201ResponseClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets ExportComplianceInformation
        /// </summary>
        [DataMember(Name="exportComplianceInformation", EmitDefaultValue=false)]
        public RiskV1ExportComplianceInquiriesPost201ResponseExportComplianceInformation ExportComplianceInformation { get; set; }

        /// <summary>
        /// Gets or Sets ErrorInformation
        /// </summary>
        [DataMember(Name="errorInformation", EmitDefaultValue=false)]
        public RiskV1ExportComplianceInquiriesPost201ResponseErrorInformation ErrorInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskV1ExportComplianceInquiriesPost201Response {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SubmitTimeUtc: ").Append(SubmitTimeUtc).Append("\n");
            sb.Append("  SubmitTimeLocal: ").Append(SubmitTimeLocal).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  ExportComplianceInformation: ").Append(ExportComplianceInformation).Append("\n");
            sb.Append("  ErrorInformation: ").Append(ErrorInformation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RiskV1ExportComplianceInquiriesPost201Response);
        }

        /// <summary>
        /// Returns true if RiskV1ExportComplianceInquiriesPost201Response instances are equal
        /// </summary>
        /// <param name="other">Instance of RiskV1ExportComplianceInquiriesPost201Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskV1ExportComplianceInquiriesPost201Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.SubmitTimeUtc == other.SubmitTimeUtc ||
                    this.SubmitTimeUtc != null &&
                    this.SubmitTimeUtc.Equals(other.SubmitTimeUtc)
                ) && 
                (
                    this.SubmitTimeLocal == other.SubmitTimeLocal ||
                    this.SubmitTimeLocal != null &&
                    this.SubmitTimeLocal.Equals(other.SubmitTimeLocal)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.ExportComplianceInformation == other.ExportComplianceInformation ||
                    this.ExportComplianceInformation != null &&
                    this.ExportComplianceInformation.Equals(other.ExportComplianceInformation)
                ) && 
                (
                    this.ErrorInformation == other.ErrorInformation ||
                    this.ErrorInformation != null &&
                    this.ErrorInformation.Equals(other.ErrorInformation)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.SubmitTimeUtc != null)
                    hash = hash * 59 + this.SubmitTimeUtc.GetHashCode();
                if (this.SubmitTimeLocal != null)
                    hash = hash * 59 + this.SubmitTimeLocal.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.ExportComplianceInformation != null)
                    hash = hash * 59 + this.ExportComplianceInformation.GetHashCode();
                if (this.ErrorInformation != null)
                    hash = hash * 59 + this.ErrorInformation.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length >= 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than or equal to 26.", new [] { "Id" });
            }

            yield break;
        }
    }

}
