// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace Location
{
    public class LocationOutputs: ResultsBase
    {
		/// <summary>
		/// The latitude of the origin.
		/// </summary>
		[JsonProperty("Latitude")]
		public double Latitude {get;}

		/// <summary>
		/// The longitude of the origin.
		/// </summary>
		[JsonProperty("Longitude")]
		public double Longitude {get;}

		/// <summary>
		/// The elevation of the origin as it intersects with the topography.
		/// </summary>
		[JsonProperty("Elevation")]
		public double Elevation {get;}


        
        /// <summary>
        /// Construct a LocationOutputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public LocationOutputs() : base()
        {

        }


        /// <summary>
        /// Construct a LocationOutputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public LocationOutputs(double latitude, double longitude, double elevation): base()
        {
			this.Latitude = latitude;
			this.Longitude = longitude;
			this.Elevation = elevation;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}