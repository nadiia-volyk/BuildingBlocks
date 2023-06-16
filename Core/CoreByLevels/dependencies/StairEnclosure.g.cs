//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Elements.Validators;
using Elements.Serialization.JSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>Represents the vertical enclosure of a fire stair.</summary>
    [JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class StairEnclosure : GeometricElement
    {
        [JsonConstructor]
        public StairEnclosure(Polygon @perimeter, Vector3 @direction, double @rotation, double @elevation, double @height, double @area, string @number, Transform @transform = null, Material @material = null, Representation @representation = null, bool @isElementDefinition = false, System.Guid @id = default, string @name = null)
            : base(transform, material, representation, isElementDefinition, id, name)
        {
            this.Perimeter = @perimeter;
            this.Direction = @direction;
            this.Rotation = @rotation;
            this.Elevation = @elevation;
            this.Height = @height;
            this.Area = @area;
            this.Number = @number;
            }
        
        // Empty constructor
        public StairEnclosure()
            : base()
        {
        }
    
        /// <summary>The id of the polygon to extrude.</summary>
        [JsonProperty("Perimeter", Required = Newtonsoft.Json.Required.AllowNull)]
        public Polygon Perimeter { get; set; }
    
        /// <summary>The direction in which to extrude.</summary>
        [JsonProperty("Direction", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Vector3 Direction { get; set; } = new Vector3();
    
        /// <summary>The rotation in degrees of the stair enclosure.</summary>
        [JsonProperty("Rotation", Required = Newtonsoft.Json.Required.Always)]
        public double Rotation { get; set; }
    
        /// <summary>The elevation of the stair enclosure</summary>
        [JsonProperty("Elevation", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double Elevation { get; set; }
    
        /// <summary>The height of the stair enclosure.</summary>
        [JsonProperty("Height", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double Height { get; set; }
    
        /// <summary>The area of the stair enclosure footprint.</summary>
        [JsonProperty("Area", Required = Newtonsoft.Json.Required.Always)]
        public double Area { get; set; }
    
        /// <summary>The number of the stair enclosure.</summary>
        [JsonProperty("Number", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Number { get; set; }
    
    
    }
}