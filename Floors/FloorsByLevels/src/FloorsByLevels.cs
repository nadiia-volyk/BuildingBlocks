using Elements;
using Elements.Geometry;
using System;
using System.Linq;
using System.Collections.Generic;

namespace FloorsByLevels
{
    public static class FloorsByLevels
    {
        /// <summary>
        /// Generates Floors for each LevelPerimeter in the model configured ith slab thickness and setback..
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A FloorsByLevelsOutputs instance containing computed results and the model with any new elements.</returns>
        public static FloorsByLevelsOutputs Execute(Dictionary<string, Model> inputModels, FloorsByLevelsInputs input)
        {
            // Exract level perimeters from model
            var levels = new List<LevelPerimeter>();
            inputModels.TryGetValue("Levels", out var model);
            //model.Elements.Values.ToList().ForEach(element => Console.WriteLine(element.GetType().ToString()));
            if (model == null || model.AllElementsOfType<LevelPerimeter>().Count() == 0)
            {
                throw new ArgumentException("No LevelPerimeters found.");
            }

            var floorMaterial = new Material("Concrete", new Color(0.34, 0.34, 0.34, 1.0), 0.3, 0.3);

            Console.WriteLine(levels.Count);

            levels.AddRange(model.AllElementsOfType<LevelPerimeter>());

            // Extract any core voids in model if they exist
            var voidProfiles = new List<Polygon>();
            inputModels.TryGetValue("Core", out var coreModel);
            if (coreModel != null)
            {
                var voidMasses = coreModel.AllElementsOfType<Mass>().Where(mass => mass.Name.ToLower().Contains("void"));
                voidProfiles.AddRange(voidMasses.Select(mass => mass.Profile.Perimeter.Project(new Plane(Vector3.Origin, Vector3.ZAxis))));
            }

            // Begin generating cores
            var floors = new List<Floor>();
            var floorArea = 0.0;
            foreach (var level in levels)
            {
                var floorOffsets = level.Perimeter.Offset(input.FloorSetback * -1);
                var floorProfile = new Profile(floorOffsets.FirstOrDefault() ?? level.Perimeter, voidProfiles, Guid.NewGuid(), "Level Profile");
                var floorThickness = input.FloorThickness;
                var floorBasis = new Transform(0.0, 0.0, level.Elevation - input.FloorThickness);

                var floor = new Floor(floorProfile, floorThickness, floorBasis, floorMaterial, null, false, Guid.NewGuid(), null);

                floors.Add(floor);
                floorArea += floor.Area();
            }
            floors = floors.OrderBy(f => f.Elevation).ToList();
            floors.First().Transform.Move(new Vector3(0.0, 0.0, input.FloorThickness));
            var output = new FloorsByLevelsOutputs(floorArea, floors.Count());
            output.Model.AddElements(floors);
            return output;
        }
    }
}