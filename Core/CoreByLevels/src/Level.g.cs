//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.0.27.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Properties;
using Elements.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>A horizontal planer datum.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.27.0 (Newtonsoft.Json v12.0.0.0)")]
    [UserElement]
	public partial class Level : Element
    {
        [Newtonsoft.Json.JsonConstructor]
        public Level(Vector3 @origin, Vector3 @normal, double @elevation, Polygon @perimeter, System.Guid @id, string @name)
            : base(id, name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Level>();
            if(validator != null)
            {
                validator.Validate(new object[]{ @origin, @normal, @elevation, @perimeter, @id, @name});
            }
        
            this.Origin = @origin;
            this.Normal = @normal;
            this.Elevation = @elevation;
            this.Perimeter = @perimeter;
        }
    
        /// <summary>The origin of the level.</summary>
        [Newtonsoft.Json.JsonProperty("Origin", Required = Newtonsoft.Json.Required.AllowNull)]
        public Vector3 Origin { get; internal set; }
    
        /// <summary>The normal of the level.</summary>
        [Newtonsoft.Json.JsonProperty("Normal", Required = Newtonsoft.Json.Required.AllowNull)]
        public Vector3 Normal { get; internal set; }
    
        /// <summary>The elevation of the level.</summary>
        [Newtonsoft.Json.JsonProperty("Elevation", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public double Elevation { get; internal set; }
    
        /// <summary>The perimeter of the level.</summary>
        [Newtonsoft.Json.JsonProperty("Perimeter", Required = Newtonsoft.Json.Required.AllowNull)]
        public Polygon Perimeter { get; internal set; }
    
    
    }
}