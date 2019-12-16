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
    /// PtsV2PaymentsPost201ResponsePointOfSaleInformationEmv
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponsePointOfSaleInformationEmv :  IEquatable<PtsV2PaymentsPost201ResponsePointOfSaleInformationEmv>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponsePointOfSaleInformationEmv" /> class.
        /// </summary>
        /// <param name="Tags">EMV data that is transmitted from the chip card to the issuer, and from the issuer to the chip card. The EMV data is in the tag-length-value format and includes chip card tags, terminal tags, and transaction detail tags.  For details, see the &#x60;emv_request_combined_tags&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  **Note** The information about EMV applies to credit card processing and PIN debit processing. All other information in this guide applies only to credit card processing. PIN debit processing is available only on FDC Nashville Global.  **Note** For information about the individual tags, see the “Application Specification” section in the EMV 4.3 Specifications: http://emvco.com  **Important** The following tags contain sensitive information and **must not** be included in this field:   - **56**: Track 1 equivalent data  - **57**: Track 2 equivalent data  - **5A**: Application PAN  - **5F20**: Cardholder name  - **5F24**: Application expiration date (This sensitivity has been relaxed for cmcic, amexdirect, fdiglobal, opdfde, and six)  - **99**: Transaction PIN  - **9F0B**: Cardholder name (extended)  - **9F1F**: Track 1 discretionary data  - **9F20**: Track 2 discretionary data  For captures, this field is required for contact EMV transactions. Otherwise, it is optional.  For credits, this field is required for contact EMV stand-alone credits and contactless EMV stand-alone credits. Otherwise, it is optional.  **Important** For contact EMV captures, contact EMV stand-alone credits, and contactless EMV stand-alone credits, you must include the following tags in this field. For all other types of EMV transactions, the following tags are optional.   - **95**: Terminal verification results  - **9F10**: Issuer application data  - **9F26**: Application cryptogram .</param>
        /// <param name="ChipValidationType">Entity or service that provided the validation results returned in &#x60;chipValidationResult&#x60;.  Possible values:  - &#x60;02&#x60;: MasterCard on-behalf pre-validation service (The MasterCard authorization platform validated the M/Chip cryptogram before the authorization request reached the issuer.)  - &#x60;03&#x60;: MasterCard on-behalf stand-in service (The MasterCard authorization platform validated the M/Chip cryptogram because the issuer was not available.)  - &#x60;50&#x60;: Issuer  - &#x60;90&#x60;: Chip fall-back transaction downgrade process (The chip could not be read.)  This field is returned only for NFC payment network tokenization transactions with MasterCard.  **Note** No CyberSource through VisaNet acquirers support EMV at this time. .</param>
        /// <param name="ChipValidationResult">Cryptogram validation results returned by the entity or service specified in &#x60;chipValidationType&#x60;.  Possible values: - &#x60;A&#x60;: Application cryptogram is valid, but the application transaction counter (ATC) is outside allowed range. (A large jump in ATC values may indicate data copying or other fraud.) - &#x60;C&#x60;: Chip validation was completed successfully. - &#x60;E&#x60;: Application cryptogram is valid but the ATC indicates possible replay fraud. - &#x60;F&#x60;: Format error in the chip data. - &#x60;G&#x60;: Application cryptogram is valid but is not a valid authorization request cryptogram (ARQC). - &#x60;I&#x60;: Application cryptogram is invalid. - &#x60;T&#x60;: Application cryptogram is valid but terminal verification results (TVR) or card verification results (CVR) are invalid. - &#x60;U&#x60;: Application cryptogram could not be validated because of a technical error.  This field is returned only for NFC payment network tokenization transactions with MasterCard.  **Note** No CyberSource through VisaNet acquirers support EMV at this time. .</param>
        public PtsV2PaymentsPost201ResponsePointOfSaleInformationEmv(string Tags = default(string), string ChipValidationType = default(string), string ChipValidationResult = default(string))
        {
            this.Tags = Tags;
            this.ChipValidationType = ChipValidationType;
            this.ChipValidationResult = ChipValidationResult;
        }
        
        /// <summary>
        /// EMV data that is transmitted from the chip card to the issuer, and from the issuer to the chip card. The EMV data is in the tag-length-value format and includes chip card tags, terminal tags, and transaction detail tags.  For details, see the &#x60;emv_request_combined_tags&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  **Note** The information about EMV applies to credit card processing and PIN debit processing. All other information in this guide applies only to credit card processing. PIN debit processing is available only on FDC Nashville Global.  **Note** For information about the individual tags, see the “Application Specification” section in the EMV 4.3 Specifications: http://emvco.com  **Important** The following tags contain sensitive information and **must not** be included in this field:   - **56**: Track 1 equivalent data  - **57**: Track 2 equivalent data  - **5A**: Application PAN  - **5F20**: Cardholder name  - **5F24**: Application expiration date (This sensitivity has been relaxed for cmcic, amexdirect, fdiglobal, opdfde, and six)  - **99**: Transaction PIN  - **9F0B**: Cardholder name (extended)  - **9F1F**: Track 1 discretionary data  - **9F20**: Track 2 discretionary data  For captures, this field is required for contact EMV transactions. Otherwise, it is optional.  For credits, this field is required for contact EMV stand-alone credits and contactless EMV stand-alone credits. Otherwise, it is optional.  **Important** For contact EMV captures, contact EMV stand-alone credits, and contactless EMV stand-alone credits, you must include the following tags in this field. For all other types of EMV transactions, the following tags are optional.   - **95**: Terminal verification results  - **9F10**: Issuer application data  - **9F26**: Application cryptogram 
        /// </summary>
        /// <value>EMV data that is transmitted from the chip card to the issuer, and from the issuer to the chip card. The EMV data is in the tag-length-value format and includes chip card tags, terminal tags, and transaction detail tags.  For details, see the &#x60;emv_request_combined_tags&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  **Note** The information about EMV applies to credit card processing and PIN debit processing. All other information in this guide applies only to credit card processing. PIN debit processing is available only on FDC Nashville Global.  **Note** For information about the individual tags, see the “Application Specification” section in the EMV 4.3 Specifications: http://emvco.com  **Important** The following tags contain sensitive information and **must not** be included in this field:   - **56**: Track 1 equivalent data  - **57**: Track 2 equivalent data  - **5A**: Application PAN  - **5F20**: Cardholder name  - **5F24**: Application expiration date (This sensitivity has been relaxed for cmcic, amexdirect, fdiglobal, opdfde, and six)  - **99**: Transaction PIN  - **9F0B**: Cardholder name (extended)  - **9F1F**: Track 1 discretionary data  - **9F20**: Track 2 discretionary data  For captures, this field is required for contact EMV transactions. Otherwise, it is optional.  For credits, this field is required for contact EMV stand-alone credits and contactless EMV stand-alone credits. Otherwise, it is optional.  **Important** For contact EMV captures, contact EMV stand-alone credits, and contactless EMV stand-alone credits, you must include the following tags in this field. For all other types of EMV transactions, the following tags are optional.   - **95**: Terminal verification results  - **9F10**: Issuer application data  - **9F26**: Application cryptogram </value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public string Tags { get; set; }

        /// <summary>
        /// Entity or service that provided the validation results returned in &#x60;chipValidationResult&#x60;.  Possible values:  - &#x60;02&#x60;: MasterCard on-behalf pre-validation service (The MasterCard authorization platform validated the M/Chip cryptogram before the authorization request reached the issuer.)  - &#x60;03&#x60;: MasterCard on-behalf stand-in service (The MasterCard authorization platform validated the M/Chip cryptogram because the issuer was not available.)  - &#x60;50&#x60;: Issuer  - &#x60;90&#x60;: Chip fall-back transaction downgrade process (The chip could not be read.)  This field is returned only for NFC payment network tokenization transactions with MasterCard.  **Note** No CyberSource through VisaNet acquirers support EMV at this time. 
        /// </summary>
        /// <value>Entity or service that provided the validation results returned in &#x60;chipValidationResult&#x60;.  Possible values:  - &#x60;02&#x60;: MasterCard on-behalf pre-validation service (The MasterCard authorization platform validated the M/Chip cryptogram before the authorization request reached the issuer.)  - &#x60;03&#x60;: MasterCard on-behalf stand-in service (The MasterCard authorization platform validated the M/Chip cryptogram because the issuer was not available.)  - &#x60;50&#x60;: Issuer  - &#x60;90&#x60;: Chip fall-back transaction downgrade process (The chip could not be read.)  This field is returned only for NFC payment network tokenization transactions with MasterCard.  **Note** No CyberSource through VisaNet acquirers support EMV at this time. </value>
        [DataMember(Name="chipValidationType", EmitDefaultValue=false)]
        public string ChipValidationType { get; set; }

        /// <summary>
        /// Cryptogram validation results returned by the entity or service specified in &#x60;chipValidationType&#x60;.  Possible values: - &#x60;A&#x60;: Application cryptogram is valid, but the application transaction counter (ATC) is outside allowed range. (A large jump in ATC values may indicate data copying or other fraud.) - &#x60;C&#x60;: Chip validation was completed successfully. - &#x60;E&#x60;: Application cryptogram is valid but the ATC indicates possible replay fraud. - &#x60;F&#x60;: Format error in the chip data. - &#x60;G&#x60;: Application cryptogram is valid but is not a valid authorization request cryptogram (ARQC). - &#x60;I&#x60;: Application cryptogram is invalid. - &#x60;T&#x60;: Application cryptogram is valid but terminal verification results (TVR) or card verification results (CVR) are invalid. - &#x60;U&#x60;: Application cryptogram could not be validated because of a technical error.  This field is returned only for NFC payment network tokenization transactions with MasterCard.  **Note** No CyberSource through VisaNet acquirers support EMV at this time. 
        /// </summary>
        /// <value>Cryptogram validation results returned by the entity or service specified in &#x60;chipValidationType&#x60;.  Possible values: - &#x60;A&#x60;: Application cryptogram is valid, but the application transaction counter (ATC) is outside allowed range. (A large jump in ATC values may indicate data copying or other fraud.) - &#x60;C&#x60;: Chip validation was completed successfully. - &#x60;E&#x60;: Application cryptogram is valid but the ATC indicates possible replay fraud. - &#x60;F&#x60;: Format error in the chip data. - &#x60;G&#x60;: Application cryptogram is valid but is not a valid authorization request cryptogram (ARQC). - &#x60;I&#x60;: Application cryptogram is invalid. - &#x60;T&#x60;: Application cryptogram is valid but terminal verification results (TVR) or card verification results (CVR) are invalid. - &#x60;U&#x60;: Application cryptogram could not be validated because of a technical error.  This field is returned only for NFC payment network tokenization transactions with MasterCard.  **Note** No CyberSource through VisaNet acquirers support EMV at this time. </value>
        [DataMember(Name="chipValidationResult", EmitDefaultValue=false)]
        public string ChipValidationResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponsePointOfSaleInformationEmv {\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ChipValidationType: ").Append(ChipValidationType).Append("\n");
            sb.Append("  ChipValidationResult: ").Append(ChipValidationResult).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponsePointOfSaleInformationEmv);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponsePointOfSaleInformationEmv instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponsePointOfSaleInformationEmv to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponsePointOfSaleInformationEmv other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
                ) && 
                (
                    this.ChipValidationType == other.ChipValidationType ||
                    this.ChipValidationType != null &&
                    this.ChipValidationType.Equals(other.ChipValidationType)
                ) && 
                (
                    this.ChipValidationResult == other.ChipValidationResult ||
                    this.ChipValidationResult != null &&
                    this.ChipValidationResult.Equals(other.ChipValidationResult)
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
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.ChipValidationType != null)
                    hash = hash * 59 + this.ChipValidationType.GetHashCode();
                if (this.ChipValidationResult != null)
                    hash = hash * 59 + this.ChipValidationResult.GetHashCode();
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
            // Tags (string) maxLength
            if(this.Tags != null && this.Tags.Length >= 1998)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Tags, length must be less than or equal to 1998.", new [] { "Tags" });
            }

            // ChipValidationType (string) maxLength
            if(this.ChipValidationType != null && this.ChipValidationType.Length >= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ChipValidationType, length must be less than or equal to 2.", new [] { "ChipValidationType" });
            }

            // ChipValidationResult (string) maxLength
            if(this.ChipValidationResult != null && this.ChipValidationResult.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ChipValidationResult, length must be less than or equal to 1.", new [] { "ChipValidationResult" });
            }

            yield break;
        }
    }

}
