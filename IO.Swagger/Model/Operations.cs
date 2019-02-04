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
    /// Operations
    /// </summary>
    [DataContract]
    public partial class Operations :  IEquatable<Operations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Operations" /> class.
        /// </summary>
        /// <param name="Nomoperation">Nomoperation.</param>
        /// <param name="Montant">Montant.</param>
        /// <param name="Dateoperation">Dateoperation.</param>
        /// <param name="Numerocompte">Numerocompte.</param>
        /// <param name="Idcomptejoueur">Idcomptejoueur.</param>
        public Operations(string Nomoperation = default(string), decimal? Montant = default(decimal?), DateTime? Dateoperation = default(DateTime?), string Numerocompte = default(string), string Idcomptejoueur = default(string))
        {
            this.Nomoperation = Nomoperation;
            this.Montant = Montant;
            this.Dateoperation = Dateoperation;
            this.Numerocompte = Numerocompte;
            this.Idcomptejoueur = Idcomptejoueur;
        }
        
        /// <summary>
        /// Gets or Sets Idoperation
        /// </summary>
        [DataMember(Name="idoperation", EmitDefaultValue=false)]
        public int? Idoperation { get; private set; }

        /// <summary>
        /// Gets or Sets Nomoperation
        /// </summary>
        [DataMember(Name="nomoperation", EmitDefaultValue=false)]
        public string Nomoperation { get; set; }

        /// <summary>
        /// Gets or Sets Montant
        /// </summary>
        [DataMember(Name="montant", EmitDefaultValue=false)]
        public decimal? Montant { get; set; }

        /// <summary>
        /// Gets or Sets Dateoperation
        /// </summary>
        [DataMember(Name="dateoperation", EmitDefaultValue=false)]
        public DateTime? Dateoperation { get; set; }

        /// <summary>
        /// Gets or Sets Numerocompte
        /// </summary>
        [DataMember(Name="numerocompte", EmitDefaultValue=false)]
        public string Numerocompte { get; set; }

        /// <summary>
        /// Gets or Sets Idcomptejoueur
        /// </summary>
        [DataMember(Name="idcomptejoueur", EmitDefaultValue=false)]
        public string Idcomptejoueur { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Operations {\n");
            sb.Append("  Idoperation: ").Append(Idoperation).Append("\n");
            sb.Append("  Nomoperation: ").Append(Nomoperation).Append("\n");
            sb.Append("  Montant: ").Append(Montant).Append("\n");
            sb.Append("  Dateoperation: ").Append(Dateoperation).Append("\n");
            sb.Append("  Numerocompte: ").Append(Numerocompte).Append("\n");
            sb.Append("  Idcomptejoueur: ").Append(Idcomptejoueur).Append("\n");
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
            return this.Equals(input as Operations);
        }

        /// <summary>
        /// Returns true if Operations instances are equal
        /// </summary>
        /// <param name="input">Instance of Operations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Operations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Idoperation == input.Idoperation ||
                    (this.Idoperation != null &&
                    this.Idoperation.Equals(input.Idoperation))
                ) && 
                (
                    this.Nomoperation == input.Nomoperation ||
                    (this.Nomoperation != null &&
                    this.Nomoperation.Equals(input.Nomoperation))
                ) && 
                (
                    this.Montant == input.Montant ||
                    (this.Montant != null &&
                    this.Montant.Equals(input.Montant))
                ) && 
                (
                    this.Dateoperation == input.Dateoperation ||
                    (this.Dateoperation != null &&
                    this.Dateoperation.Equals(input.Dateoperation))
                ) && 
                (
                    this.Numerocompte == input.Numerocompte ||
                    (this.Numerocompte != null &&
                    this.Numerocompte.Equals(input.Numerocompte))
                ) && 
                (
                    this.Idcomptejoueur == input.Idcomptejoueur ||
                    (this.Idcomptejoueur != null &&
                    this.Idcomptejoueur.Equals(input.Idcomptejoueur))
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
                if (this.Idoperation != null)
                    hashCode = hashCode * 59 + this.Idoperation.GetHashCode();
                if (this.Nomoperation != null)
                    hashCode = hashCode * 59 + this.Nomoperation.GetHashCode();
                if (this.Montant != null)
                    hashCode = hashCode * 59 + this.Montant.GetHashCode();
                if (this.Dateoperation != null)
                    hashCode = hashCode * 59 + this.Dateoperation.GetHashCode();
                if (this.Numerocompte != null)
                    hashCode = hashCode * 59 + this.Numerocompte.GetHashCode();
                if (this.Idcomptejoueur != null)
                    hashCode = hashCode * 59 + this.Idcomptejoueur.GetHashCode();
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
