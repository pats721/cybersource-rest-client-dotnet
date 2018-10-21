/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
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
    /// InlineResponse201ProcessorInformationAvs
    /// </summary>
    [DataContract]
    public partial class InlineResponse201ProcessorInformationAvs :  IEquatable<InlineResponse201ProcessorInformationAvs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse201ProcessorInformationAvs" /> class.
        /// </summary>
        /// <param name="Code">AVS result code. .</param>
        /// <param name="CodeRaw">AVS result code sent directly from the processor. Returned only when the processor returns this value. Important Do not use this field to evaluate the result of AVS. Use for debugging purposes only. .</param>
        public InlineResponse201ProcessorInformationAvs(string Code = default(string), string CodeRaw = default(string))
        {
            this.Code = Code;
            this.CodeRaw = CodeRaw;
        }
        
        /// <summary>
        /// AVS result code. 
        /// </summary>
        /// <value>AVS result code. </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// AVS result code sent directly from the processor. Returned only when the processor returns this value. Important Do not use this field to evaluate the result of AVS. Use for debugging purposes only. 
        /// </summary>
        /// <value>AVS result code sent directly from the processor. Returned only when the processor returns this value. Important Do not use this field to evaluate the result of AVS. Use for debugging purposes only. </value>
        [DataMember(Name="codeRaw", EmitDefaultValue=false)]
        public string CodeRaw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse201ProcessorInformationAvs {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CodeRaw: ").Append(CodeRaw).Append("\n");
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
            return this.Equals(obj as InlineResponse201ProcessorInformationAvs);
        }

        /// <summary>
        /// Returns true if InlineResponse201ProcessorInformationAvs instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse201ProcessorInformationAvs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse201ProcessorInformationAvs other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.CodeRaw == other.CodeRaw ||
                    this.CodeRaw != null &&
                    this.CodeRaw.Equals(other.CodeRaw)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.CodeRaw != null)
                    hash = hash * 59 + this.CodeRaw.GetHashCode();
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
            // Code (string) maxLength
            if(this.Code != null && this.Code.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 1.", new [] { "Code" });
            }

            // CodeRaw (string) maxLength
            if(this.CodeRaw != null && this.CodeRaw.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CodeRaw, length must be less than 10.", new [] { "CodeRaw" });
            }

            yield break;
        }
    }

}
