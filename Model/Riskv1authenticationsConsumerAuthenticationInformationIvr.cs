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
    /// Riskv1authenticationsConsumerAuthenticationInformationIvr
    /// </summary>
    [DataContract]
    public partial class Riskv1authenticationsConsumerAuthenticationInformationIvr :  IEquatable<Riskv1authenticationsConsumerAuthenticationInformationIvr>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationsConsumerAuthenticationInformationIvr" /> class.
        /// </summary>
        /// <param name="EnabledMessage">Flag to indicate if a valid IVR transaction was detected. .</param>
        /// <param name="EncryptionKey">Encryption key to be used in the event the ACS requires encryption of the credential field. .</param>
        /// <param name="EncryptionMandatory">Flag to indicate if the ACS requires the credential to be encrypted. .</param>
        /// <param name="EncryptionType">An indicator from the ACS to inform the type of encryption that should be used in the event the ACS requires encryption of the credential field. .</param>
        /// <param name="Label">An ACS Provided label that can be presented to the Consumer. Recommended use with an application. .</param>
        /// <param name="Prompt">An ACS provided string that can be presented to the Consumer. Recommended use with an application. .</param>
        /// <param name="StatusMessage">An ACS provided message that can provide additional information or details. .</param>
        public Riskv1authenticationsConsumerAuthenticationInformationIvr(bool? EnabledMessage = default(bool?), string EncryptionKey = default(string), bool? EncryptionMandatory = default(bool?), string EncryptionType = default(string), string Label = default(string), string Prompt = default(string), string StatusMessage = default(string))
        {
            this.EnabledMessage = EnabledMessage;
            this.EncryptionKey = EncryptionKey;
            this.EncryptionMandatory = EncryptionMandatory;
            this.EncryptionType = EncryptionType;
            this.Label = Label;
            this.Prompt = Prompt;
            this.StatusMessage = StatusMessage;
        }
        
        /// <summary>
        /// Flag to indicate if a valid IVR transaction was detected. 
        /// </summary>
        /// <value>Flag to indicate if a valid IVR transaction was detected. </value>
        [DataMember(Name="enabledMessage", EmitDefaultValue=false)]
        public bool? EnabledMessage { get; set; }

        /// <summary>
        /// Encryption key to be used in the event the ACS requires encryption of the credential field. 
        /// </summary>
        /// <value>Encryption key to be used in the event the ACS requires encryption of the credential field. </value>
        [DataMember(Name="encryptionKey", EmitDefaultValue=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Flag to indicate if the ACS requires the credential to be encrypted. 
        /// </summary>
        /// <value>Flag to indicate if the ACS requires the credential to be encrypted. </value>
        [DataMember(Name="encryptionMandatory", EmitDefaultValue=false)]
        public bool? EncryptionMandatory { get; set; }

        /// <summary>
        /// An indicator from the ACS to inform the type of encryption that should be used in the event the ACS requires encryption of the credential field. 
        /// </summary>
        /// <value>An indicator from the ACS to inform the type of encryption that should be used in the event the ACS requires encryption of the credential field. </value>
        [DataMember(Name="encryptionType", EmitDefaultValue=false)]
        public string EncryptionType { get; set; }

        /// <summary>
        /// An ACS Provided label that can be presented to the Consumer. Recommended use with an application. 
        /// </summary>
        /// <value>An ACS Provided label that can be presented to the Consumer. Recommended use with an application. </value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// An ACS provided string that can be presented to the Consumer. Recommended use with an application. 
        /// </summary>
        /// <value>An ACS provided string that can be presented to the Consumer. Recommended use with an application. </value>
        [DataMember(Name="prompt", EmitDefaultValue=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// An ACS provided message that can provide additional information or details. 
        /// </summary>
        /// <value>An ACS provided message that can provide additional information or details. </value>
        [DataMember(Name="statusMessage", EmitDefaultValue=false)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1authenticationsConsumerAuthenticationInformationIvr {\n");
            sb.Append("  EnabledMessage: ").Append(EnabledMessage).Append("\n");
            sb.Append("  EncryptionKey: ").Append(EncryptionKey).Append("\n");
            sb.Append("  EncryptionMandatory: ").Append(EncryptionMandatory).Append("\n");
            sb.Append("  EncryptionType: ").Append(EncryptionType).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  StatusMessage: ").Append(StatusMessage).Append("\n");
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
            return this.Equals(obj as Riskv1authenticationsConsumerAuthenticationInformationIvr);
        }

        /// <summary>
        /// Returns true if Riskv1authenticationsConsumerAuthenticationInformationIvr instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1authenticationsConsumerAuthenticationInformationIvr to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1authenticationsConsumerAuthenticationInformationIvr other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnabledMessage == other.EnabledMessage ||
                    this.EnabledMessage != null &&
                    this.EnabledMessage.Equals(other.EnabledMessage)
                ) && 
                (
                    this.EncryptionKey == other.EncryptionKey ||
                    this.EncryptionKey != null &&
                    this.EncryptionKey.Equals(other.EncryptionKey)
                ) && 
                (
                    this.EncryptionMandatory == other.EncryptionMandatory ||
                    this.EncryptionMandatory != null &&
                    this.EncryptionMandatory.Equals(other.EncryptionMandatory)
                ) && 
                (
                    this.EncryptionType == other.EncryptionType ||
                    this.EncryptionType != null &&
                    this.EncryptionType.Equals(other.EncryptionType)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Prompt == other.Prompt ||
                    this.Prompt != null &&
                    this.Prompt.Equals(other.Prompt)
                ) && 
                (
                    this.StatusMessage == other.StatusMessage ||
                    this.StatusMessage != null &&
                    this.StatusMessage.Equals(other.StatusMessage)
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
                if (this.EnabledMessage != null)
                    hash = hash * 59 + this.EnabledMessage.GetHashCode();
                if (this.EncryptionKey != null)
                    hash = hash * 59 + this.EncryptionKey.GetHashCode();
                if (this.EncryptionMandatory != null)
                    hash = hash * 59 + this.EncryptionMandatory.GetHashCode();
                if (this.EncryptionType != null)
                    hash = hash * 59 + this.EncryptionType.GetHashCode();
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.Prompt != null)
                    hash = hash * 59 + this.Prompt.GetHashCode();
                if (this.StatusMessage != null)
                    hash = hash * 59 + this.StatusMessage.GetHashCode();
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
            // EncryptionKey (string) maxLength
            if(this.EncryptionKey != null && this.EncryptionKey.Length >= 16)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EncryptionKey, length must be less than or equal to 16.", new [] { "EncryptionKey" });
            }

            // EncryptionType (string) maxLength
            if(this.EncryptionType != null && this.EncryptionType.Length >= 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EncryptionType, length must be less than or equal to 20.", new [] { "EncryptionType" });
            }

            // Label (string) maxLength
            if(this.Label != null && this.Label.Length >= 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Label, length must be less than or equal to 20.", new [] { "Label" });
            }

            // Prompt (string) maxLength
            if(this.Prompt != null && this.Prompt.Length >= 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Prompt, length must be less than or equal to 80.", new [] { "Prompt" });
            }

            // StatusMessage (string) maxLength
            if(this.StatusMessage != null && this.StatusMessage.Length >= 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StatusMessage, length must be less than or equal to 80.", new [] { "StatusMessage" });
            }

            yield break;
        }
    }

}
