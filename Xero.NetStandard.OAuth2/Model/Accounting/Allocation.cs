/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.3.3
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// Allocation
    /// </summary>
    [DataContract]
    public partial class Allocation :  IEquatable<Allocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Allocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Allocation() 
        {  
          ValidationErrors = new List<ValidationError>(); 
        }
        
        /// <summary>
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name="Invoice", EmitDefaultValue=false)]
        public Invoice Invoice { get; set; }

        /// <summary>
        /// Gets or Sets Overpayment
        /// </summary>
        [DataMember(Name="Overpayment", EmitDefaultValue=false)]
        public Overpayment Overpayment { get; set; }

        /// <summary>
        /// Gets or Sets Prepayment
        /// </summary>
        [DataMember(Name="Prepayment", EmitDefaultValue=false)]
        public Prepayment Prepayment { get; set; }

        /// <summary>
        /// Gets or Sets CreditNote
        /// </summary>
        [DataMember(Name="CreditNote", EmitDefaultValue=false)]
        public CreditNote CreditNote { get; set; }

        /// <summary>
        /// the amount being applied to the invoice
        /// </summary>
        /// <value>the amount being applied to the invoice</value>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// the date the allocation is applied YYYY-MM-DD.
        /// </summary>
        /// <value>the date the allocation is applied YYYY-MM-DD.</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// A string to indicate if a invoice status
        /// </summary>
        /// <value>A string to indicate if a invoice status</value>
        [DataMember(Name="StatusAttributeString", EmitDefaultValue=false)]
        public string StatusAttributeString { get; set; }

        /// <summary>
        /// Displays array of validation error messages from the API
        /// </summary>
        /// <value>Displays array of validation error messages from the API</value>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public List<ValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Allocation {\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  Overpayment: ").Append(Overpayment).Append("\n");
            sb.Append("  Prepayment: ").Append(Prepayment).Append("\n");
            sb.Append("  CreditNote: ").Append(CreditNote).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  StatusAttributeString: ").Append(StatusAttributeString).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Allocation);
        }

        /// <summary>
        /// Returns true if Allocation instances are equal
        /// </summary>
        /// <param name="input">Instance of Allocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Allocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Invoice == input.Invoice ||
                    (this.Invoice != null &&
                    this.Invoice.Equals(input.Invoice))
                ) && 
                (
                    this.Overpayment == input.Overpayment ||
                    (this.Overpayment != null &&
                    this.Overpayment.Equals(input.Overpayment))
                ) && 
                (
                    this.Prepayment == input.Prepayment ||
                    (this.Prepayment != null &&
                    this.Prepayment.Equals(input.Prepayment))
                ) && 
                (
                    this.CreditNote == input.CreditNote ||
                    (this.CreditNote != null &&
                    this.CreditNote.Equals(input.CreditNote))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.StatusAttributeString == input.StatusAttributeString ||
                    (this.StatusAttributeString != null &&
                    this.StatusAttributeString.Equals(input.StatusAttributeString))
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Invoice != null)
                    hashCode = hashCode * 59 + this.Invoice.GetHashCode();
                if (this.Overpayment != null)
                    hashCode = hashCode * 59 + this.Overpayment.GetHashCode();
                if (this.Prepayment != null)
                    hashCode = hashCode * 59 + this.Prepayment.GetHashCode();
                if (this.CreditNote != null)
                    hashCode = hashCode * 59 + this.CreditNote.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.StatusAttributeString != null)
                    hashCode = hashCode * 59 + this.StatusAttributeString.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
                return hashCode;
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
