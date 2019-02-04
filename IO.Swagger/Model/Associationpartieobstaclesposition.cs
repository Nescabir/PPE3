/* 
 * API Escape Game
 *
 * Service web pour gérer les informations de EGC
 *
 * OpenAPI spec version: beta 1.0.0
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Associationpartieobstaclesposition
    /// </summary>
    [DataContract]
    public partial class Associationpartieobstaclesposition :  IEquatable<Associationpartieobstaclesposition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Associationpartieobstaclesposition" /> class.
        /// </summary>
        /// <param name="Idposition">Idposition.</param>
        /// <param name="Idpartie">Idpartie.</param>
        /// <param name="Idobstacle">Idobstacle.</param>
        public Associationpartieobstaclesposition(int? Idposition = default(int?), string Idpartie = default(string), string Idobstacle = default(string))
        {
            this.Idposition = Idposition;
            this.Idpartie = Idpartie;
            this.Idobstacle = Idobstacle;
        }
        
        /// <summary>
        /// Gets or Sets Idposition
        /// </summary>
        [DataMember(Name="idposition", EmitDefaultValue=false)]
        public int? Idposition { get; set; }

        /// <summary>
        /// Gets or Sets Idpartie
        /// </summary>
        [DataMember(Name="idpartie", EmitDefaultValue=false)]
        public string Idpartie { get; set; }

        /// <summary>
        /// Gets or Sets Idobstacle
        /// </summary>
        [DataMember(Name="idobstacle", EmitDefaultValue=false)]
        public string Idobstacle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Associationpartieobstaclesposition {\n");
            sb.Append("  Idposition: ").Append(Idposition).Append("\n");
            sb.Append("  Idpartie: ").Append(Idpartie).Append("\n");
            sb.Append("  Idobstacle: ").Append(Idobstacle).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Associationpartieobstaclesposition);
        }

        /// <summary>
        /// Returns true if Associationpartieobstaclesposition instances are equal
        /// </summary>
        /// <param name="input">Instance of Associationpartieobstaclesposition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Associationpartieobstaclesposition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Idposition == input.Idposition ||
                    (this.Idposition != null &&
                    this.Idposition.Equals(input.Idposition))
                ) && 
                (
                    this.Idpartie == input.Idpartie ||
                    (this.Idpartie != null &&
                    this.Idpartie.Equals(input.Idpartie))
                ) && 
                (
                    this.Idobstacle == input.Idobstacle ||
                    (this.Idobstacle != null &&
                    this.Idobstacle.Equals(input.Idobstacle))
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
                if (this.Idposition != null)
                    hashCode = hashCode * 59 + this.Idposition.GetHashCode();
                if (this.Idpartie != null)
                    hashCode = hashCode * 59 + this.Idpartie.GetHashCode();
                if (this.Idobstacle != null)
                    hashCode = hashCode * 59 + this.Idobstacle.GetHashCode();
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
