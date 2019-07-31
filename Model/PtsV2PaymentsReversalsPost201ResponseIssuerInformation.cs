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
    /// PtsV2PaymentsReversalsPost201ResponseIssuerInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsReversalsPost201ResponseIssuerInformation :  IEquatable<PtsV2PaymentsReversalsPost201ResponseIssuerInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsReversalsPost201ResponseIssuerInformation" /> class.
        /// </summary>
        /// <param name="ResponseCode">Additional authorization code that must be printed on the receipt when returned by the processor.  This value is generated by the processor and is returned only for a successful transaction.  This field is supported only on FDC Nashville Global and SIX. .</param>
        public PtsV2PaymentsReversalsPost201ResponseIssuerInformation(string ResponseCode = default(string))
        {
            this.ResponseCode = ResponseCode;
        }
        
        /// <summary>
        /// Additional authorization code that must be printed on the receipt when returned by the processor.  This value is generated by the processor and is returned only for a successful transaction.  This field is supported only on FDC Nashville Global and SIX. 
        /// </summary>
        /// <value>Additional authorization code that must be printed on the receipt when returned by the processor.  This value is generated by the processor and is returned only for a successful transaction.  This field is supported only on FDC Nashville Global and SIX. </value>
        [DataMember(Name="responseCode", EmitDefaultValue=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsReversalsPost201ResponseIssuerInformation {\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsReversalsPost201ResponseIssuerInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsReversalsPost201ResponseIssuerInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsReversalsPost201ResponseIssuerInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsReversalsPost201ResponseIssuerInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ResponseCode == other.ResponseCode ||
                    this.ResponseCode != null &&
                    this.ResponseCode.Equals(other.ResponseCode)
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
                if (this.ResponseCode != null)
                    hash = hash * 59 + this.ResponseCode.GetHashCode();
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
            // ResponseCode (string) maxLength
            if(this.ResponseCode != null && this.ResponseCode.Length >= 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResponseCode, length must be less than or equal to 6.", new [] { "ResponseCode" });
            }

            yield break;
        }
    }

}
