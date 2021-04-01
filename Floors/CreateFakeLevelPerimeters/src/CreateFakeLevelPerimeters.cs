using Elements;
using Elements.Geometry;
using Elements.Geometry.Solids;
using System;
using System.Collections.Generic;

namespace CreateFakeLevelPerimeters
{
    public static class CreateFakeLevelPerimeters
    {
        /// <summary>
        /// The CreateFakeLevelPerimeters function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A CreateFakeLevelPerimetersOutputs instance containing computed results and the model with any new elements.</returns>
        public static CreateFakeLevelPerimetersOutputs Execute(Dictionary<string, Model> inputModels, CreateFakeLevelPerimetersInputs input)
        {
            /// Your code here.
            var output = new CreateFakeLevelPerimetersOutputs();

            var polygon = new Polygon(new List<Vector3>{
                new Vector3(0, 0, 0),
                new Vector3(50, 0, 0),
                new Vector3(50, 30, 0),
                new Vector3(0, 30, 0)
            });

            for (var i = 0; i < input.Count; i++)
            {
                var levelPerimeter = new LevelPerimeter(polygon.Area(), i * 11, polygon, Guid.NewGuid(), $"Level {i}");
                output.Model.AddElement(levelPerimeter);

                var levelProfile = new Profile(polygon, null, Guid.NewGuid(), "Nothing");
                var levelRepresentation = new Representation(new List<SolidOperation> { new Extrude(levelProfile, 11, Vector3.ZAxis, false) });
                var levelVolume = new LevelVolume(polygon, 11, polygon.Area(), new Transform(0, 0, i * 11), BuiltInMaterials.Mass, levelRepresentation, false, Guid.NewGuid(), "Level");
                output.Model.AddElement(levelVolume);
            }
            return output;
        }
    }
}