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
    /// TssV2TransactionsGet200ResponseProcessorInformationElectronicVerificationResults
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponseProcessorInformationElectronicVerificationResults :  IEquatable<TssV2TransactionsGet200ResponseProcessorInformationElectronicVerificationResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponseProcessorInformationElectronicVerificationResults" /> class.
        /// </summary>
        /// <param name="Email">Mapped Electronic Verification response code for the customer’s email address.  For details, see &#x60;auth_ev_email&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) .</param>
        /// <param name="EmailRaw">Raw Electronic Verification response code from the processor for the customer’s email address..</param>
        /// <param name="Name">The description for this field is not available. .</param>
        /// <param name="NameRaw">The description for this field is not available..</param>
        /// <param name="PhoneNumber">Mapped Electronic Verification response code for the customer’s phone number.  For details, see &#x60;auth_ev_phone_number&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) .</param>
        /// <param name="PhoneNumberRaw">Raw Electronic Verification response code from the processor for the customer’s phone number..</param>
        /// <param name="Street">Mapped Electronic Verification response code for the customer’s street address.  For details, see &#x60;auth_ev_street&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) .</param>
        /// <param name="StreetRaw">Raw Electronic Verification response code from the processor for the customer’s street address..</param>
        /// <param name="PostalCode">Mapped Electronic Verification response code for the customer’s postal code.  For details, see &#x60;auth_ev_postal_code&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) .</param>
        /// <param name="PostalCodeRaw">Raw Electronic Verification response code from the processor for the customer’s postal code..</param>
        public TssV2TransactionsGet200ResponseProcessorInformationElectronicVerificationResults(string Email = default(string), string EmailRaw = default(string), string Name = default(string), string NameRaw = default(string), string PhoneNumber = default(string), string PhoneNumberRaw = default(string), string Street = default(string), string StreetRaw = default(string), string PostalCode = default(string), string PostalCodeRaw = default(string))
        {
            this.Email = Email;
            this.EmailRaw = EmailRaw;
            this.Name = Name;
            this.NameRaw = NameRaw;
            this.PhoneNumber = PhoneNumber;
            this.PhoneNumberRaw = PhoneNumberRaw;
            this.Street = Street;
            this.StreetRaw = StreetRaw;
            this.PostalCode = PostalCode;
            this.PostalCodeRaw = PostalCodeRaw;
        }
        
        /// <summary>
        /// Mapped Electronic Verification response code for the customer’s email address.  For details, see &#x60;auth_ev_email&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) 
        /// </summary>
        /// <value>Mapped Electronic Verification response code for the customer’s email address.  For details, see &#x60;auth_ev_email&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) </value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Raw Electronic Verification response code from the processor for the customer’s email address.
        /// </summary>
        /// <value>Raw Electronic Verification response code from the processor for the customer’s email address.</value>
        [DataMember(Name="emailRaw", EmitDefaultValue=false)]
        public string EmailRaw { get; set; }

        /// <summary>
        /// The description for this field is not available. 
        /// </summary>
        /// <value>The description for this field is not available. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="nameRaw", EmitDefaultValue=false)]
        public string NameRaw { get; set; }

        /// <summary>
        /// Mapped Electronic Verification response code for the customer’s phone number.  For details, see &#x60;auth_ev_phone_number&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) 
        /// </summary>
        /// <value>Mapped Electronic Verification response code for the customer’s phone number.  For details, see &#x60;auth_ev_phone_number&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) </value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Raw Electronic Verification response code from the processor for the customer’s phone number.
        /// </summary>
        /// <value>Raw Electronic Verification response code from the processor for the customer’s phone number.</value>
        [DataMember(Name="phoneNumberRaw", EmitDefaultValue=false)]
        public string PhoneNumberRaw { get; set; }

        /// <summary>
        /// Mapped Electronic Verification response code for the customer’s street address.  For details, see &#x60;auth_ev_street&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) 
        /// </summary>
        /// <value>Mapped Electronic Verification response code for the customer’s street address.  For details, see &#x60;auth_ev_street&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) </value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }

        /// <summary>
        /// Raw Electronic Verification response code from the processor for the customer’s street address.
        /// </summary>
        /// <value>Raw Electronic Verification response code from the processor for the customer’s street address.</value>
        [DataMember(Name="streetRaw", EmitDefaultValue=false)]
        public string StreetRaw { get; set; }

        /// <summary>
        /// Mapped Electronic Verification response code for the customer’s postal code.  For details, see &#x60;auth_ev_postal_code&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) 
        /// </summary>
        /// <value>Mapped Electronic Verification response code for the customer’s postal code.  For details, see &#x60;auth_ev_postal_code&#x60; field description in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) </value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Raw Electronic Verification response code from the processor for the customer’s postal code.
        /// </summary>
        /// <value>Raw Electronic Verification response code from the processor for the customer’s postal code.</value>
        [DataMember(Name="postalCodeRaw", EmitDefaultValue=false)]
        public string PostalCodeRaw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponseProcessorInformationElectronicVerificationResults {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailRaw: ").Append(EmailRaw).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameRaw: ").Append(NameRaw).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PhoneNumberRaw: ").Append(PhoneNumberRaw).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  StreetRaw: ").Append(StreetRaw).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  PostalCodeRaw: ").Append(PostalCodeRaw).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponseProcessorInformationElectronicVerificationResults);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponseProcessorInformationElectronicVerificationResults instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponseProcessorInformationElectronicVerificationResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponseProcessorInformationElectronicVerificationResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.EmailRaw == other.EmailRaw ||
                    this.EmailRaw != null &&
                    this.EmailRaw.Equals(other.EmailRaw)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NameRaw == other.NameRaw ||
                    this.NameRaw != null &&
                    this.NameRaw.Equals(other.NameRaw)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.PhoneNumberRaw == other.PhoneNumberRaw ||
                    this.PhoneNumberRaw != null &&
                    this.PhoneNumberRaw.Equals(other.PhoneNumberRaw)
                ) && 
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
                ) && 
                (
                    this.StreetRaw == other.StreetRaw ||
                    this.StreetRaw != null &&
                    this.StreetRaw.Equals(other.StreetRaw)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.PostalCodeRaw == other.PostalCodeRaw ||
                    this.PostalCodeRaw != null &&
                    this.PostalCodeRaw.Equals(other.PostalCodeRaw)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.EmailRaw != null)
                    hash = hash * 59 + this.EmailRaw.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.NameRaw != null)
                    hash = hash * 59 + this.NameRaw.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.PhoneNumberRaw != null)
                    hash = hash * 59 + this.PhoneNumberRaw.GetHashCode();
                if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();
                if (this.StreetRaw != null)
                    hash = hash * 59 + this.StreetRaw.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.PostalCodeRaw != null)
                    hash = hash * 59 + this.PostalCodeRaw.GetHashCode();
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
            // Email (string) maxLength
            if(this.Email != null && this.Email.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than or equal to 1.", new [] { "Email" });
            }

            // EmailRaw (string) maxLength
            if(this.EmailRaw != null && this.EmailRaw.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailRaw, length must be less than or equal to 1.", new [] { "EmailRaw" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length >= 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than or equal to 30.", new [] { "Name" });
            }

            // NameRaw (string) maxLength
            if(this.NameRaw != null && this.NameRaw.Length >= 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NameRaw, length must be less than or equal to 30.", new [] { "NameRaw" });
            }

            // PhoneNumber (string) maxLength
            if(this.PhoneNumber != null && this.PhoneNumber.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneNumber, length must be less than or equal to 1.", new [] { "PhoneNumber" });
            }

            // PhoneNumberRaw (string) maxLength
            if(this.PhoneNumberRaw != null && this.PhoneNumberRaw.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneNumberRaw, length must be less than or equal to 1.", new [] { "PhoneNumberRaw" });
            }

            // Street (string) maxLength
            if(this.Street != null && this.Street.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Street, length must be less than or equal to 1.", new [] { "Street" });
            }

            // StreetRaw (string) maxLength
            if(this.StreetRaw != null && this.StreetRaw.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreetRaw, length must be less than or equal to 1.", new [] { "StreetRaw" });
            }

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than or equal to 1.", new [] { "PostalCode" });
            }

            // PostalCodeRaw (string) maxLength
            if(this.PostalCodeRaw != null && this.PostalCodeRaw.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCodeRaw, length must be less than or equal to 1.", new [] { "PostalCodeRaw" });
            }

            yield break;
        }
    }

}
