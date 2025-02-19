// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Validators;
using Elements.Serialization.JSON;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Hypar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace People
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public  class PeopleInputs : S3Args
    
    {
        [Newtonsoft.Json.JsonConstructor]
        
        public PeopleInputs(double @peoplePerFloor, bool @includeSeatedPeople, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey):
        base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<PeopleInputs>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @peoplePerFloor, @includeSeatedPeople});
            }
        
            this.PeoplePerFloor = @peoplePerFloor;
            this.IncludeSeatedPeople = @includeSeatedPeople;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>The number of people to be distributed around each floor.</summary>
        [Newtonsoft.Json.JsonProperty("People per floor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0D, 500D)]
        public double PeoplePerFloor { get; set; } = 50D;
    
        /// <summary>Should seated people be included?</summary>
        [Newtonsoft.Json.JsonProperty("Include Seated People", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IncludeSeatedPeople { get; set; } = false;
    
    }
}