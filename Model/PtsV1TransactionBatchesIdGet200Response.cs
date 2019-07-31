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
    /// PtsV1TransactionBatchesIdGet200Response
    /// </summary>
    [DataContract]
    public partial class PtsV1TransactionBatchesIdGet200Response :  IEquatable<PtsV1TransactionBatchesIdGet200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV1TransactionBatchesIdGet200Response" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier assigned to the batch file..</param>
        /// <param name="UploadDate">Date when the batch template was update..</param>
        /// <param name="CompletionDate">The date when the batch template processing completed..</param>
        /// <param name="TransactionCount">Number of transactions in the transaction..</param>
        /// <param name="AcceptedTransactionCount">Number of transactions accepted..</param>
        /// <param name="RejectedTransactionCount">Number of transactions rejected..</param>
        /// <param name="Status">The status of you batch template processing..</param>
        /// <param name="Links">Links.</param>
        public PtsV1TransactionBatchesIdGet200Response(string Id = default(string), string UploadDate = default(string), string CompletionDate = default(string), int? TransactionCount = default(int?), int? AcceptedTransactionCount = default(int?), string RejectedTransactionCount = default(string), string Status = default(string), PtsV1TransactionBatchesIdGet200ResponseLinks Links = default(PtsV1TransactionBatchesIdGet200ResponseLinks))
        {
            this.Id = Id;
            this.UploadDate = UploadDate;
            this.CompletionDate = CompletionDate;
            this.TransactionCount = TransactionCount;
            this.AcceptedTransactionCount = AcceptedTransactionCount;
            this.RejectedTransactionCount = RejectedTransactionCount;
            this.Status = Status;
            this.Links = Links;
        }
        
        /// <summary>
        /// Unique identifier assigned to the batch file.
        /// </summary>
        /// <value>Unique identifier assigned to the batch file.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Date when the batch template was update.
        /// </summary>
        /// <value>Date when the batch template was update.</value>
        [DataMember(Name="uploadDate", EmitDefaultValue=false)]
        public string UploadDate { get; set; }

        /// <summary>
        /// The date when the batch template processing completed.
        /// </summary>
        /// <value>The date when the batch template processing completed.</value>
        [DataMember(Name="completionDate", EmitDefaultValue=false)]
        public string CompletionDate { get; set; }

        /// <summary>
        /// Number of transactions in the transaction.
        /// </summary>
        /// <value>Number of transactions in the transaction.</value>
        [DataMember(Name="transactionCount", EmitDefaultValue=false)]
        public int? TransactionCount { get; set; }

        /// <summary>
        /// Number of transactions accepted.
        /// </summary>
        /// <value>Number of transactions accepted.</value>
        [DataMember(Name="acceptedTransactionCount", EmitDefaultValue=false)]
        public int? AcceptedTransactionCount { get; set; }

        /// <summary>
        /// Number of transactions rejected.
        /// </summary>
        /// <value>Number of transactions rejected.</value>
        [DataMember(Name="rejectedTransactionCount", EmitDefaultValue=false)]
        public string RejectedTransactionCount { get; set; }

        /// <summary>
        /// The status of you batch template processing.
        /// </summary>
        /// <value>The status of you batch template processing.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public PtsV1TransactionBatchesIdGet200ResponseLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV1TransactionBatchesIdGet200Response {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UploadDate: ").Append(UploadDate).Append("\n");
            sb.Append("  CompletionDate: ").Append(CompletionDate).Append("\n");
            sb.Append("  TransactionCount: ").Append(TransactionCount).Append("\n");
            sb.Append("  AcceptedTransactionCount: ").Append(AcceptedTransactionCount).Append("\n");
            sb.Append("  RejectedTransactionCount: ").Append(RejectedTransactionCount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(obj as PtsV1TransactionBatchesIdGet200Response);
        }

        /// <summary>
        /// Returns true if PtsV1TransactionBatchesIdGet200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV1TransactionBatchesIdGet200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV1TransactionBatchesIdGet200Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.UploadDate == other.UploadDate ||
                    this.UploadDate != null &&
                    this.UploadDate.Equals(other.UploadDate)
                ) && 
                (
                    this.CompletionDate == other.CompletionDate ||
                    this.CompletionDate != null &&
                    this.CompletionDate.Equals(other.CompletionDate)
                ) && 
                (
                    this.TransactionCount == other.TransactionCount ||
                    this.TransactionCount != null &&
                    this.TransactionCount.Equals(other.TransactionCount)
                ) && 
                (
                    this.AcceptedTransactionCount == other.AcceptedTransactionCount ||
                    this.AcceptedTransactionCount != null &&
                    this.AcceptedTransactionCount.Equals(other.AcceptedTransactionCount)
                ) && 
                (
                    this.RejectedTransactionCount == other.RejectedTransactionCount ||
                    this.RejectedTransactionCount != null &&
                    this.RejectedTransactionCount.Equals(other.RejectedTransactionCount)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.UploadDate != null)
                    hash = hash * 59 + this.UploadDate.GetHashCode();
                if (this.CompletionDate != null)
                    hash = hash * 59 + this.CompletionDate.GetHashCode();
                if (this.TransactionCount != null)
                    hash = hash * 59 + this.TransactionCount.GetHashCode();
                if (this.AcceptedTransactionCount != null)
                    hash = hash * 59 + this.AcceptedTransactionCount.GetHashCode();
                if (this.RejectedTransactionCount != null)
                    hash = hash * 59 + this.RejectedTransactionCount.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
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
            if(this.Id != null && this.Id.Length >= 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than or equal to 8.", new [] { "Id" });
            }

            // Id (string) minLength
            if(this.Id != null && this.Id.Length <= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than or equal to 1.", new [] { "Id" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"^[a-zA-Z0-9_+-]*$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            yield break;
        }
    }

}
