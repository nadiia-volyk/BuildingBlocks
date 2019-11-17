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

    /// <summary>Represents a single room.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.27.0 (Newtonsoft.Json v12.0.0.0)")]
    [UserElement]
	public partial class Room : GeometricElement
    {
        [Newtonsoft.Json.JsonConstructor]
        public Room(Polygon @perimeter, Vector3 @direction, double @rotation, double @elevation, double @height, double @area, string @number, Transform @transform, Material @material, Representation @representation, System.Guid @id, string @name)
            : base(transform, material, representation, id, name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Room>();
            if(validator != null)
            {
                validator.Validate(new object[]{ @perimeter, @direction, @rotation, @elevation, @height, @area, @number, @transform, @material, @representation, @id, @name});
            }
        
            this.Perimeter = @perimeter;
            this.Direction = @direction;
            this.Rotation = @rotation;
            this.Elevation = @elevation;
            this.Height = @height;
            this.Area = @area;
            this.Number = @number;
        }
    
        /// <summary>The id of the polygon to extrude.</summary>
        [Newtonsoft.Json.JsonProperty("Perimeter", Required = Newtonsoft.Json.Required.AllowNull)]
        public Polygon Perimeter { get; internal set; }
    
        /// <summary>The direction in which to extrude.</summary>
        [Newtonsoft.Json.JsonProperty("Direction", Required = Newtonsoft.Json.Required.AllowNull)]
        public Vector3 Direction { get; internal set; }
    
        /// <summary>The rotation in degrees of the room.</summary>
        [Newtonsoft.Json.JsonProperty("Rotation", Required = Newtonsoft.Json.Required.Always)]
        public double Rotation { get; internal set; }
    
        /// <summary>The elevation of the room.</summary>
        [Newtonsoft.Json.JsonProperty("Elevation", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public double Elevation { get; internal set; }
    
        /// <summary>The height of the room.</summary>
        [Newtonsoft.Json.JsonProperty("Height", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public double Height { get; internal set; }
    
        /// <summary>The area of the room.</summary>
        [Newtonsoft.Json.JsonProperty("Area", Required = Newtonsoft.Json.Required.Always)]
        public double Area { get; internal set; }
    
        /// <summary>The number of the room.</summary>
        [Newtonsoft.Json.JsonProperty("Number", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Number { get; internal set; }
    
    
    }
}