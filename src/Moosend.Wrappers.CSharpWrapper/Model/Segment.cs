/* 
 * Moosend API
 *
 * TODO: Add a description
 *
 * OpenAPI spec version: 1.0
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
using SwaggerDateConverter = Moosend.Wrappers.CSharpWrapper.Client.SwaggerDateConverter;

namespace Moosend.Wrappers.CSharpWrapper.Model
{
    /// <summary>
    /// Segment
    /// </summary>
    [DataContract]
    public partial class Segment :  IEquatable<Segment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Segment" /> class.
        /// </summary>
        /// <param name="CreatedBy">.</param>
        /// <param name="CreatedOn">.</param>
        /// <param name="Criteria">.</param>
        /// <param name="Description">.</param>
        /// <param name="FetchType">.</param>
        /// <param name="FetchValue">.</param>
        /// <param name="ID">.</param>
        /// <param name="MatchType">.</param>
        /// <param name="Name">.</param>
        /// <param name="UpdatedBy">.</param>
        /// <param name="UpdatedOn">.</param>
        public Segment(string CreatedBy = default(string), string CreatedOn = default(string), List<Criterion> Criteria = default(List<Criterion>), string Description = default(string), double? FetchType = default(double?), double? FetchValue = default(double?), double? ID = default(double?), double? MatchType = default(double?), string Name = default(string), string UpdatedBy = default(string), string UpdatedOn = default(string))
        {
            this.CreatedBy = CreatedBy;
            this.CreatedOn = CreatedOn;
            this.Criteria = Criteria;
            this.Description = Description;
            this.FetchType = FetchType;
            this.FetchValue = FetchValue;
            this.ID = ID;
            this.MatchType = MatchType;
            this.Name = Name;
            this.UpdatedBy = UpdatedBy;
            this.UpdatedOn = UpdatedOn;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="CreatedBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="CreatedOn", EmitDefaultValue=false)]
        public string CreatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Criteria", EmitDefaultValue=false)]
        public List<Criterion> Criteria { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="FetchType", EmitDefaultValue=false)]
        public double? FetchType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="FetchValue", EmitDefaultValue=false)]
        public double? FetchValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public double? ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="MatchType", EmitDefaultValue=false)]
        public double? MatchType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="UpdatedBy", EmitDefaultValue=false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="UpdatedOn", EmitDefaultValue=false)]
        public string UpdatedOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Segment {\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FetchType: ").Append(FetchType).Append("\n");
            sb.Append("  FetchValue: ").Append(FetchValue).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
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
            return this.Equals(obj as Segment);
        }

        /// <summary>
        /// Returns true if Segment instances are equal
        /// </summary>
        /// <param name="other">Instance of Segment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Segment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.Criteria == other.Criteria ||
                    this.Criteria != null &&
                    this.Criteria.SequenceEqual(other.Criteria)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.FetchType == other.FetchType ||
                    this.FetchType != null &&
                    this.FetchType.Equals(other.FetchType)
                ) && 
                (
                    this.FetchValue == other.FetchValue ||
                    this.FetchValue != null &&
                    this.FetchValue.Equals(other.FetchValue)
                ) && 
                (
                    this.ID == other.ID ||
                    this.ID != null &&
                    this.ID.Equals(other.ID)
                ) && 
                (
                    this.MatchType == other.MatchType ||
                    this.MatchType != null &&
                    this.MatchType.Equals(other.MatchType)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.UpdatedBy == other.UpdatedBy ||
                    this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(other.UpdatedBy)
                ) && 
                (
                    this.UpdatedOn == other.UpdatedOn ||
                    this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(other.UpdatedOn)
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
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.Criteria != null)
                    hash = hash * 59 + this.Criteria.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.FetchType != null)
                    hash = hash * 59 + this.FetchType.GetHashCode();
                if (this.FetchValue != null)
                    hash = hash * 59 + this.FetchValue.GetHashCode();
                if (this.ID != null)
                    hash = hash * 59 + this.ID.GetHashCode();
                if (this.MatchType != null)
                    hash = hash * 59 + this.MatchType.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.UpdatedBy != null)
                    hash = hash * 59 + this.UpdatedBy.GetHashCode();
                if (this.UpdatedOn != null)
                    hash = hash * 59 + this.UpdatedOn.GetHashCode();
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
