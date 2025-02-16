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
    /// KeyResponseEntry
    /// </summary>
    [DataContract]
    public partial class InlineResponse20011Keys :  IEquatable<InlineResponse20011Keys>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20011Keys" /> class.
        /// </summary>
        /// <param name="OrganizationId">Merchant Id.</param>
        /// <param name="MerchantName">Merchant Name.</param>
        /// <param name="KeyId">Key Id.</param>
        /// <param name="KeyType">Key Type.</param>
        /// <param name="Status">Status can be active/inactive.</param>
        /// <param name="ExpirationDate">Expiry Date. example - 2028-07-15 22:11:56 UTC.</param>
        /// <param name="DateAdded">Date Addded. example - 2018-04-25 22:11:56 UTC.</param>
        /// <param name="AddedBy">Added By.</param>
        /// <param name="DateModified">Modified Date..</param>
        /// <param name="ModifiedBy">Modified By.</param>
        /// <param name="Version">Version.</param>
        /// <param name="SerialNumber">Serial Number.</param>
        /// <param name="IssuerName">Issuer Name.</param>
        public InlineResponse20011Keys(string OrganizationId = default(string), string MerchantName = default(string), string KeyId = default(string), string KeyType = default(string), string Status = default(string), DateTime? ExpirationDate = default(DateTime?), DateTime? DateAdded = default(DateTime?), string AddedBy = default(string), DateTime? DateModified = default(DateTime?), string ModifiedBy = default(string), string Version = default(string), string SerialNumber = default(string), string IssuerName = default(string))
        {
            this.OrganizationId = OrganizationId;
            this.MerchantName = MerchantName;
            this.KeyId = KeyId;
            this.KeyType = KeyType;
            this.Status = Status;
            this.ExpirationDate = ExpirationDate;
            this.DateAdded = DateAdded;
            this.AddedBy = AddedBy;
            this.DateModified = DateModified;
            this.ModifiedBy = ModifiedBy;
            this.Version = Version;
            this.SerialNumber = SerialNumber;
            this.IssuerName = IssuerName;
        }
        
        /// <summary>
        /// Merchant Id
        /// </summary>
        /// <value>Merchant Id</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Merchant Name
        /// </summary>
        /// <value>Merchant Name</value>
        [DataMember(Name="merchantName", EmitDefaultValue=false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// Key Id
        /// </summary>
        /// <value>Key Id</value>
        [DataMember(Name="keyId", EmitDefaultValue=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// Key Type
        /// </summary>
        /// <value>Key Type</value>
        [DataMember(Name="keyType", EmitDefaultValue=false)]
        public string KeyType { get; set; }

        /// <summary>
        /// Status can be active/inactive
        /// </summary>
        /// <value>Status can be active/inactive</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Expiry Date. example - 2028-07-15 22:11:56 UTC
        /// </summary>
        /// <value>Expiry Date. example - 2028-07-15 22:11:56 UTC</value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Date Addded. example - 2018-04-25 22:11:56 UTC
        /// </summary>
        /// <value>Date Addded. example - 2018-04-25 22:11:56 UTC</value>
        [DataMember(Name="dateAdded", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateAdded { get; set; }

        /// <summary>
        /// Added By
        /// </summary>
        /// <value>Added By</value>
        [DataMember(Name="addedBy", EmitDefaultValue=false)]
        public string AddedBy { get; set; }

        /// <summary>
        /// Modified Date.
        /// </summary>
        /// <value>Modified Date.</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Modified By
        /// </summary>
        /// <value>Modified By</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        /// <value>Version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Serial Number
        /// </summary>
        /// <value>Serial Number</value>
        [DataMember(Name="serialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Issuer Name
        /// </summary>
        /// <value>Issuer Name</value>
        [DataMember(Name="issuerName", EmitDefaultValue=false)]
        public string IssuerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20011Keys {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  KeyType: ").Append(KeyType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  DateAdded: ").Append(DateAdded).Append("\n");
            sb.Append("  AddedBy: ").Append(AddedBy).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
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
            return this.Equals(obj as InlineResponse20011Keys);
        }

        /// <summary>
        /// Returns true if InlineResponse20011Keys instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20011Keys to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20011Keys other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    this.MerchantName == other.MerchantName ||
                    this.MerchantName != null &&
                    this.MerchantName.Equals(other.MerchantName)
                ) && 
                (
                    this.KeyId == other.KeyId ||
                    this.KeyId != null &&
                    this.KeyId.Equals(other.KeyId)
                ) && 
                (
                    this.KeyType == other.KeyType ||
                    this.KeyType != null &&
                    this.KeyType.Equals(other.KeyType)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.DateAdded == other.DateAdded ||
                    this.DateAdded != null &&
                    this.DateAdded.Equals(other.DateAdded)
                ) && 
                (
                    this.AddedBy == other.AddedBy ||
                    this.AddedBy != null &&
                    this.AddedBy.Equals(other.AddedBy)
                ) && 
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) && 
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.SerialNumber == other.SerialNumber ||
                    this.SerialNumber != null &&
                    this.SerialNumber.Equals(other.SerialNumber)
                ) && 
                (
                    this.IssuerName == other.IssuerName ||
                    this.IssuerName != null &&
                    this.IssuerName.Equals(other.IssuerName)
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
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                if (this.MerchantName != null)
                    hash = hash * 59 + this.MerchantName.GetHashCode();
                if (this.KeyId != null)
                    hash = hash * 59 + this.KeyId.GetHashCode();
                if (this.KeyType != null)
                    hash = hash * 59 + this.KeyType.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                if (this.DateAdded != null)
                    hash = hash * 59 + this.DateAdded.GetHashCode();
                if (this.AddedBy != null)
                    hash = hash * 59 + this.AddedBy.GetHashCode();
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.SerialNumber != null)
                    hash = hash * 59 + this.SerialNumber.GetHashCode();
                if (this.IssuerName != null)
                    hash = hash * 59 + this.IssuerName.GetHashCode();
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
            yield break;
        }
    }

}
