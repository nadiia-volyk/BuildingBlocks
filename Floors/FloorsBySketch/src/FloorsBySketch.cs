using Elements;
using Elements.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace FloorsBySketch
{
    public static class FloorsBySketch
    {
        /// <summary>
        /// Create floors by drawing them manually.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A FloorsBySketchOutputs instance containing computed results and the model with any new elements.</returns>
        public static FloorsBySketchOutputs Execute(Dictionary<string, Model> inputModels, FloorsBySketchInputs input)
        {
            var floors = new List<Floor>();
            var areaSum = 0.0;
            foreach (var floorInput in input.Floors)
            {
                var f = new Floor(floorInput.Boundary, floorInput.Thickness, new Transform(0, 0, floorInput.Elevation), BuiltInMaterials.Concrete);
                floors.Add(f);
                areaSum += floorInput.Boundary.Area();
            }
            var output = new FloorsBySketchOutputs(areaSum);
            var count = 1;
            foreach (var floorGrp in floors.OrderBy(f => f.Elevation).GroupBy(f => f.Elevation))
            {
                var letter = 'A';
                if (floorGrp.Count() == 1)
                {
                    floorGrp.First().Name = $"Level {count++}";
                }
                else
                {
                    foreach (var floor in floorGrp)
                    {
                        floor.Name = $"Level {count}{letter++}";
                    }
                    count++;
                }
            }

            output.Model.AddElements(floors);

            return output;
        }
    }
}