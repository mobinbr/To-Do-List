/*
 * web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ListApiCli.Client.OpenAPIDateConverter;

namespace ListApiCli.Model
{
    /// <summary>
    /// ToDoItems
    /// </summary>
    [DataContract(Name = "ToDoItems")]
    public partial class ToDoItems : IEquatable<ToDoItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToDoItems" /> class.
        /// </summary>
        /// <param name="toDoItemsId">toDoItemsId.</param>
        /// <param name="details">details.</param>
        /// <param name="dueTime">dueTime.</param>
        public ToDoItems(string toDoItemsId = default(string), string details = default(string), DateTime dueTime = default(DateTime))
        {
            this.ToDoItemsId = toDoItemsId;
            this.Details = details;
            this.DueTime = dueTime;
        }

        /// <summary>
        /// Gets or Sets ToDoItemsId
        /// </summary>
        [DataMember(Name = "toDoItemsId", EmitDefaultValue = true)]
        public string ToDoItemsId { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = true)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets DueTime
        /// </summary>
        [DataMember(Name = "dueTime", EmitDefaultValue = false)]
        public DateTime DueTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ToDoItems {\n");
            sb.Append("  ToDoItemsId: ").Append(ToDoItemsId).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  DueTime: ").Append(DueTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ToDoItems);
        }

        /// <summary>
        /// Returns true if ToDoItems instances are equal
        /// </summary>
        /// <param name="input">Instance of ToDoItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ToDoItems input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ToDoItemsId == input.ToDoItemsId ||
                    (this.ToDoItemsId != null &&
                    this.ToDoItemsId.Equals(input.ToDoItemsId))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.DueTime == input.DueTime ||
                    (this.DueTime != null &&
                    this.DueTime.Equals(input.DueTime))
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
                if (this.ToDoItemsId != null)
                {
                    hashCode = (hashCode * 59) + this.ToDoItemsId.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                if (this.DueTime != null)
                {
                    hashCode = (hashCode * 59) + this.DueTime.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
