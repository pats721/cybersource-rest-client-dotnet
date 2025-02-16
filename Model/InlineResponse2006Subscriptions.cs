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
    /// Subscription list
    /// </summary>
    [DataContract]
    public partial class InlineResponse2006Subscriptions :  IEquatable<InlineResponse2006Subscriptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2006Subscriptions" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="Id">An unique identification number generated by Cybersource to identify the submitted request. Returned by all services. It is also appended to the endpoint of the resource. On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. .</param>
        /// <param name="PlanInformation">PlanInformation.</param>
        /// <param name="SubscriptionInformation">SubscriptionInformation.</param>
        /// <param name="PaymentInformation">PaymentInformation.</param>
        /// <param name="OrderInformation">OrderInformation.</param>
        public InlineResponse2006Subscriptions(InlineResponse2006Links Links = default(InlineResponse2006Links), string Id = default(string), InlineResponse2006PlanInformation PlanInformation = default(InlineResponse2006PlanInformation), InlineResponse2006SubscriptionInformation SubscriptionInformation = default(InlineResponse2006SubscriptionInformation), InlineResponse2006PaymentInformation PaymentInformation = default(InlineResponse2006PaymentInformation), InlineResponse2006OrderInformation OrderInformation = default(InlineResponse2006OrderInformation))
        {
            this.Links = Links;
            this.Id = Id;
            this.PlanInformation = PlanInformation;
            this.SubscriptionInformation = SubscriptionInformation;
            this.PaymentInformation = PaymentInformation;
            this.OrderInformation = OrderInformation;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public InlineResponse2006Links Links { get; set; }

        /// <summary>
        /// An unique identification number generated by Cybersource to identify the submitted request. Returned by all services. It is also appended to the endpoint of the resource. On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. 
        /// </summary>
        /// <value>An unique identification number generated by Cybersource to identify the submitted request. Returned by all services. It is also appended to the endpoint of the resource. On incremental authorizations, this value with be the same as the identification number returned in the original authorization response. </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets PlanInformation
        /// </summary>
        [DataMember(Name="planInformation", EmitDefaultValue=false)]
        public InlineResponse2006PlanInformation PlanInformation { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionInformation
        /// </summary>
        [DataMember(Name="subscriptionInformation", EmitDefaultValue=false)]
        public InlineResponse2006SubscriptionInformation SubscriptionInformation { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInformation
        /// </summary>
        [DataMember(Name="paymentInformation", EmitDefaultValue=false)]
        public InlineResponse2006PaymentInformation PaymentInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public InlineResponse2006OrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2006Subscriptions {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PlanInformation: ").Append(PlanInformation).Append("\n");
            sb.Append("  SubscriptionInformation: ").Append(SubscriptionInformation).Append("\n");
            sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
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
            return this.Equals(obj as InlineResponse2006Subscriptions);
        }

        /// <summary>
        /// Returns true if InlineResponse2006Subscriptions instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2006Subscriptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2006Subscriptions other)
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
                    this.PlanInformation == other.PlanInformation ||
                    this.PlanInformation != null &&
                    this.PlanInformation.Equals(other.PlanInformation)
                ) && 
                (
                    this.SubscriptionInformation == other.SubscriptionInformation ||
                    this.SubscriptionInformation != null &&
                    this.SubscriptionInformation.Equals(other.SubscriptionInformation)
                ) && 
                (
                    this.PaymentInformation == other.PaymentInformation ||
                    this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(other.PaymentInformation)
                ) && 
                (
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
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
                if (this.PlanInformation != null)
                    hash = hash * 59 + this.PlanInformation.GetHashCode();
                if (this.SubscriptionInformation != null)
                    hash = hash * 59 + this.SubscriptionInformation.GetHashCode();
                if (this.PaymentInformation != null)
                    hash = hash * 59 + this.PaymentInformation.GetHashCode();
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
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
