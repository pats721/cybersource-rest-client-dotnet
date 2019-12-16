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
    /// Riskv1authenticationsTravelInformation
    /// </summary>
    [DataContract]
    public partial class Riskv1authenticationsTravelInformation :  IEquatable<Riskv1authenticationsTravelInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationsTravelInformation" /> class.
        /// </summary>
        /// <param name="Legs">Legs.</param>
        /// <param name="NumberOfPassengers">Number of passengers for whom the ticket was issued. If you do not include this field in your request, CyberSource uses a default value of 1. Required for American Express SafeKey (U.S.) for travel-related requests. .</param>
        /// <param name="Passengers">Passengers.</param>
        public Riskv1authenticationsTravelInformation(List<Riskv1authenticationsTravelInformationLegs> Legs = default(List<Riskv1authenticationsTravelInformationLegs>), int? NumberOfPassengers = default(int?), List<Riskv1authenticationsTravelInformationPassengers> Passengers = default(List<Riskv1authenticationsTravelInformationPassengers>))
        {
            this.Legs = Legs;
            this.NumberOfPassengers = NumberOfPassengers;
            this.Passengers = Passengers;
        }
        
        /// <summary>
        /// Gets or Sets Legs
        /// </summary>
        [DataMember(Name="legs", EmitDefaultValue=false)]
        public List<Riskv1authenticationsTravelInformationLegs> Legs { get; set; }

        /// <summary>
        /// Number of passengers for whom the ticket was issued. If you do not include this field in your request, CyberSource uses a default value of 1. Required for American Express SafeKey (U.S.) for travel-related requests. 
        /// </summary>
        /// <value>Number of passengers for whom the ticket was issued. If you do not include this field in your request, CyberSource uses a default value of 1. Required for American Express SafeKey (U.S.) for travel-related requests. </value>
        [DataMember(Name="numberOfPassengers", EmitDefaultValue=false)]
        public int? NumberOfPassengers { get; set; }

        /// <summary>
        /// Gets or Sets Passengers
        /// </summary>
        [DataMember(Name="passengers", EmitDefaultValue=false)]
        public List<Riskv1authenticationsTravelInformationPassengers> Passengers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1authenticationsTravelInformation {\n");
            sb.Append("  Legs: ").Append(Legs).Append("\n");
            sb.Append("  NumberOfPassengers: ").Append(NumberOfPassengers).Append("\n");
            sb.Append("  Passengers: ").Append(Passengers).Append("\n");
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
            return this.Equals(obj as Riskv1authenticationsTravelInformation);
        }

        /// <summary>
        /// Returns true if Riskv1authenticationsTravelInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1authenticationsTravelInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1authenticationsTravelInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Legs == other.Legs ||
                    this.Legs != null &&
                    this.Legs.SequenceEqual(other.Legs)
                ) && 
                (
                    this.NumberOfPassengers == other.NumberOfPassengers ||
                    this.NumberOfPassengers != null &&
                    this.NumberOfPassengers.Equals(other.NumberOfPassengers)
                ) && 
                (
                    this.Passengers == other.Passengers ||
                    this.Passengers != null &&
                    this.Passengers.SequenceEqual(other.Passengers)
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
                if (this.Legs != null)
                    hash = hash * 59 + this.Legs.GetHashCode();
                if (this.NumberOfPassengers != null)
                    hash = hash * 59 + this.NumberOfPassengers.GetHashCode();
                if (this.Passengers != null)
                    hash = hash * 59 + this.Passengers.GetHashCode();
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
