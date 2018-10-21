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
    /// V2paymentsidcapturesOrderInformationInvoiceDetails
    /// </summary>
    [DataContract]
    public partial class V2paymentsidcapturesOrderInformationInvoiceDetails :  IEquatable<V2paymentsidcapturesOrderInformationInvoiceDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2paymentsidcapturesOrderInformationInvoiceDetails" /> class.
        /// </summary>
        /// <param name="PurchaseOrderNumber">Value used by your customer to identify the order. This value is typically a purchase order number. CyberSource recommends that you do not populate the field with all zeros or nines.  For processor-specific information, see the user_po field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="PurchaseOrderDate">Date the order was processed. &#x60;Format: YYYY-MM-DD&#x60;.  For processor-specific information, see the purchaser_order_date field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="PurchaseContactName">The name of the individual or the company contacted for company authorized purchases.  For processor-specific information, see the authorized_contact_name field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="Taxable">Flag that indicates whether an order is taxable. This value must be true if the sum of all _lineItems[].taxAmount_ values &gt; 0.  If you do not include any _lineItems[].taxAmount_ values in your request, CyberSource does not include _invoiceDetails.taxable_ in the data it sends to the processor.  For processor-specific information, see the tax_indicator field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="VatInvoiceReferenceNumber">VAT invoice number associated with the transaction.  For processor-specific information, see the vat_invoice_ref_number field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="CommodityCode">International description code of the overall orderâ€™s goods or services or the Categorizes purchases for VAT reporting. Contact your acquirer for a list of codes.  For processor-specific information, see the summary_commodity_code field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="TransactionAdviceAddendum">TransactionAdviceAddendum.</param>
        public V2paymentsidcapturesOrderInformationInvoiceDetails(string PurchaseOrderNumber = default(string), string PurchaseOrderDate = default(string), string PurchaseContactName = default(string), bool? Taxable = default(bool?), string VatInvoiceReferenceNumber = default(string), string CommodityCode = default(string), List<V2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum> TransactionAdviceAddendum = default(List<V2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum>))
        {
            this.PurchaseOrderNumber = PurchaseOrderNumber;
            this.PurchaseOrderDate = PurchaseOrderDate;
            this.PurchaseContactName = PurchaseContactName;
            this.Taxable = Taxable;
            this.VatInvoiceReferenceNumber = VatInvoiceReferenceNumber;
            this.CommodityCode = CommodityCode;
            this.TransactionAdviceAddendum = TransactionAdviceAddendum;
        }
        
        /// <summary>
        /// Value used by your customer to identify the order. This value is typically a purchase order number. CyberSource recommends that you do not populate the field with all zeros or nines.  For processor-specific information, see the user_po field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Value used by your customer to identify the order. This value is typically a purchase order number. CyberSource recommends that you do not populate the field with all zeros or nines.  For processor-specific information, see the user_po field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Date the order was processed. &#x60;Format: YYYY-MM-DD&#x60;.  For processor-specific information, see the purchaser_order_date field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Date the order was processed. &#x60;Format: YYYY-MM-DD&#x60;.  For processor-specific information, see the purchaser_order_date field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="purchaseOrderDate", EmitDefaultValue=false)]
        public string PurchaseOrderDate { get; set; }

        /// <summary>
        /// The name of the individual or the company contacted for company authorized purchases.  For processor-specific information, see the authorized_contact_name field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>The name of the individual or the company contacted for company authorized purchases.  For processor-specific information, see the authorized_contact_name field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="purchaseContactName", EmitDefaultValue=false)]
        public string PurchaseContactName { get; set; }

        /// <summary>
        /// Flag that indicates whether an order is taxable. This value must be true if the sum of all _lineItems[].taxAmount_ values &gt; 0.  If you do not include any _lineItems[].taxAmount_ values in your request, CyberSource does not include _invoiceDetails.taxable_ in the data it sends to the processor.  For processor-specific information, see the tax_indicator field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Flag that indicates whether an order is taxable. This value must be true if the sum of all _lineItems[].taxAmount_ values &gt; 0.  If you do not include any _lineItems[].taxAmount_ values in your request, CyberSource does not include _invoiceDetails.taxable_ in the data it sends to the processor.  For processor-specific information, see the tax_indicator field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="taxable", EmitDefaultValue=false)]
        public bool? Taxable { get; set; }

        /// <summary>
        /// VAT invoice number associated with the transaction.  For processor-specific information, see the vat_invoice_ref_number field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>VAT invoice number associated with the transaction.  For processor-specific information, see the vat_invoice_ref_number field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="vatInvoiceReferenceNumber", EmitDefaultValue=false)]
        public string VatInvoiceReferenceNumber { get; set; }

        /// <summary>
        /// International description code of the overall orderâ€™s goods or services or the Categorizes purchases for VAT reporting. Contact your acquirer for a list of codes.  For processor-specific information, see the summary_commodity_code field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>International description code of the overall orderâ€™s goods or services or the Categorizes purchases for VAT reporting. Contact your acquirer for a list of codes.  For processor-specific information, see the summary_commodity_code field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="commodityCode", EmitDefaultValue=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// Gets or Sets TransactionAdviceAddendum
        /// </summary>
        [DataMember(Name="transactionAdviceAddendum", EmitDefaultValue=false)]
        public List<V2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum> TransactionAdviceAddendum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2paymentsidcapturesOrderInformationInvoiceDetails {\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  PurchaseOrderDate: ").Append(PurchaseOrderDate).Append("\n");
            sb.Append("  PurchaseContactName: ").Append(PurchaseContactName).Append("\n");
            sb.Append("  Taxable: ").Append(Taxable).Append("\n");
            sb.Append("  VatInvoiceReferenceNumber: ").Append(VatInvoiceReferenceNumber).Append("\n");
            sb.Append("  CommodityCode: ").Append(CommodityCode).Append("\n");
            sb.Append("  TransactionAdviceAddendum: ").Append(TransactionAdviceAddendum).Append("\n");
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
            return this.Equals(obj as V2paymentsidcapturesOrderInformationInvoiceDetails);
        }

        /// <summary>
        /// Returns true if V2paymentsidcapturesOrderInformationInvoiceDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of V2paymentsidcapturesOrderInformationInvoiceDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2paymentsidcapturesOrderInformationInvoiceDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PurchaseOrderNumber == other.PurchaseOrderNumber ||
                    this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(other.PurchaseOrderNumber)
                ) && 
                (
                    this.PurchaseOrderDate == other.PurchaseOrderDate ||
                    this.PurchaseOrderDate != null &&
                    this.PurchaseOrderDate.Equals(other.PurchaseOrderDate)
                ) && 
                (
                    this.PurchaseContactName == other.PurchaseContactName ||
                    this.PurchaseContactName != null &&
                    this.PurchaseContactName.Equals(other.PurchaseContactName)
                ) && 
                (
                    this.Taxable == other.Taxable ||
                    this.Taxable != null &&
                    this.Taxable.Equals(other.Taxable)
                ) && 
                (
                    this.VatInvoiceReferenceNumber == other.VatInvoiceReferenceNumber ||
                    this.VatInvoiceReferenceNumber != null &&
                    this.VatInvoiceReferenceNumber.Equals(other.VatInvoiceReferenceNumber)
                ) && 
                (
                    this.CommodityCode == other.CommodityCode ||
                    this.CommodityCode != null &&
                    this.CommodityCode.Equals(other.CommodityCode)
                ) && 
                (
                    this.TransactionAdviceAddendum == other.TransactionAdviceAddendum ||
                    this.TransactionAdviceAddendum != null &&
                    this.TransactionAdviceAddendum.SequenceEqual(other.TransactionAdviceAddendum)
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
                if (this.PurchaseOrderNumber != null)
                    hash = hash * 59 + this.PurchaseOrderNumber.GetHashCode();
                if (this.PurchaseOrderDate != null)
                    hash = hash * 59 + this.PurchaseOrderDate.GetHashCode();
                if (this.PurchaseContactName != null)
                    hash = hash * 59 + this.PurchaseContactName.GetHashCode();
                if (this.Taxable != null)
                    hash = hash * 59 + this.Taxable.GetHashCode();
                if (this.VatInvoiceReferenceNumber != null)
                    hash = hash * 59 + this.VatInvoiceReferenceNumber.GetHashCode();
                if (this.CommodityCode != null)
                    hash = hash * 59 + this.CommodityCode.GetHashCode();
                if (this.TransactionAdviceAddendum != null)
                    hash = hash * 59 + this.TransactionAdviceAddendum.GetHashCode();
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
            // PurchaseOrderNumber (string) maxLength
            if(this.PurchaseOrderNumber != null && this.PurchaseOrderNumber.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PurchaseOrderNumber, length must be less than 25.", new [] { "PurchaseOrderNumber" });
            }

            // PurchaseOrderDate (string) maxLength
            if(this.PurchaseOrderDate != null && this.PurchaseOrderDate.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PurchaseOrderDate, length must be less than 10.", new [] { "PurchaseOrderDate" });
            }

            // PurchaseContactName (string) maxLength
            if(this.PurchaseContactName != null && this.PurchaseContactName.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PurchaseContactName, length must be less than 36.", new [] { "PurchaseContactName" });
            }

            // VatInvoiceReferenceNumber (string) maxLength
            if(this.VatInvoiceReferenceNumber != null && this.VatInvoiceReferenceNumber.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VatInvoiceReferenceNumber, length must be less than 15.", new [] { "VatInvoiceReferenceNumber" });
            }

            // CommodityCode (string) maxLength
            if(this.CommodityCode != null && this.CommodityCode.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CommodityCode, length must be less than 4.", new [] { "CommodityCode" });
            }

            yield break;
        }
    }

}
