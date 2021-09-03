//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Elements.Validators;
using Elements.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>An element wrapper for Grid2d</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Grid2dElement : GeometricElement
    {
        [Newtonsoft.Json.JsonConstructor]
        public Grid2dElement(Grid2d @grid, IList<GridNode> @gridNodes, Transform @transform = null, Material @material = null, Representation @representation = null, bool @isElementDefinition = false, System.Guid @id = default, string @name = null)
            : base(transform, material, representation, isElementDefinition, id, name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Grid2dElement>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @grid, @gridNodes, @transform, @material, @representation, @isElementDefinition, @id, @name});
            }
        
            this.Grid = @grid;
            this.GridNodes = @gridNodes;
            
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>Contains a Grid2d in absolute space (is not intended to be modified by the transform)</summary>
        [Newtonsoft.Json.JsonProperty("Grid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Grid2d Grid { get; set; }
    
        /// <summary>A list of grid intersections that fall within the grid boundaries, in absolute space (is not intended to be modified by the transform)</summary>
        [Newtonsoft.Json.JsonProperty("GridNodes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<GridNode> GridNodes { get; set; }
    
    
    }
}