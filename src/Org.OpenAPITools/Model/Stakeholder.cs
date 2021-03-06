/* 
 * PharmaTrace Supply Chain Information Network API
 *
 * The PharmaTrace SCIN API provides network members a resource and process oriented access to the blockchain backed market and inventory information. It represents a layer of abstraction above the Hyperledger network to facilitate a business focused development of clients and integration systems without the need to directly connect to Hyperledger nodes.
 *
 * OpenAPI spec version: 0.0.1
 * Contact: api@pharmatrace.io
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Stakeholder
    /// </summary>
    [DataContract]
    public partial class Stakeholder :  IEquatable<Stakeholder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stakeholder" /> class.
        /// </summary>
        /// <param name="tradeId">unique official register entry, e.g. Handelsregistereintrag, court number, ....</param>
        /// <param name="tradeIdType">type of the official register that has issued the trade id.</param>
        /// <param name="displayName">display name visible to other network members.</param>
        /// <param name="stakeholderRole">one of Manufacturer, Distributor, Pharmacy, Regulator, Hospital, MedicalPractice, CareProvider, DisposalFirm, Insurance, Patient, LawEnforcement.</param>
        /// <param name="walletId">id of the main wallet, which the stakeholder uses for PT token transactions with other stakeholders.</param>
        public Stakeholder(string tradeId = default(string), string tradeIdType = default(string), string displayName = default(string), string stakeholderRole = default(string), string walletId = default(string))
        {
            this.TradeId = tradeId;
            this.TradeIdType = tradeIdType;
            this.DisplayName = displayName;
            this.StakeholderRole = stakeholderRole;
            this.WalletId = walletId;
        }
        
        /// <summary>
        /// unique official register entry, e.g. Handelsregistereintrag, court number, ...
        /// </summary>
        /// <value>unique official register entry, e.g. Handelsregistereintrag, court number, ...</value>
        [DataMember(Name="trade_id", EmitDefaultValue=false)]
        public string TradeId { get; set; }

        /// <summary>
        /// type of the official register that has issued the trade id
        /// </summary>
        /// <value>type of the official register that has issued the trade id</value>
        [DataMember(Name="trade_id_type", EmitDefaultValue=false)]
        public string TradeIdType { get; set; }

        /// <summary>
        /// display name visible to other network members
        /// </summary>
        /// <value>display name visible to other network members</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// one of Manufacturer, Distributor, Pharmacy, Regulator, Hospital, MedicalPractice, CareProvider, DisposalFirm, Insurance, Patient, LawEnforcement
        /// </summary>
        /// <value>one of Manufacturer, Distributor, Pharmacy, Regulator, Hospital, MedicalPractice, CareProvider, DisposalFirm, Insurance, Patient, LawEnforcement</value>
        [DataMember(Name="stakeholder_role", EmitDefaultValue=false)]
        public string StakeholderRole { get; set; }

        /// <summary>
        /// id of the main wallet, which the stakeholder uses for PT token transactions with other stakeholders
        /// </summary>
        /// <value>id of the main wallet, which the stakeholder uses for PT token transactions with other stakeholders</value>
        [DataMember(Name="wallet_id", EmitDefaultValue=false)]
        public string WalletId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Stakeholder {\n");
            sb.Append("  TradeId: ").Append(TradeId).Append("\n");
            sb.Append("  TradeIdType: ").Append(TradeIdType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  StakeholderRole: ").Append(StakeholderRole).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
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
            return this.Equals(input as Stakeholder);
        }

        /// <summary>
        /// Returns true if Stakeholder instances are equal
        /// </summary>
        /// <param name="input">Instance of Stakeholder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Stakeholder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TradeId == input.TradeId ||
                    (this.TradeId != null &&
                    this.TradeId.Equals(input.TradeId))
                ) && 
                (
                    this.TradeIdType == input.TradeIdType ||
                    (this.TradeIdType != null &&
                    this.TradeIdType.Equals(input.TradeIdType))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.StakeholderRole == input.StakeholderRole ||
                    (this.StakeholderRole != null &&
                    this.StakeholderRole.Equals(input.StakeholderRole))
                ) && 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
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
                if (this.TradeId != null)
                    hashCode = hashCode * 59 + this.TradeId.GetHashCode();
                if (this.TradeIdType != null)
                    hashCode = hashCode * 59 + this.TradeIdType.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.StakeholderRole != null)
                    hashCode = hashCode * 59 + this.StakeholderRole.GetHashCode();
                if (this.WalletId != null)
                    hashCode = hashCode * 59 + this.WalletId.GetHashCode();
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
