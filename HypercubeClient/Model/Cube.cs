using Microsoft.AnalysisServices.AdomdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using AdomdDimension = Microsoft.AnalysisServices.AdomdClient.Dimension;
using AdomdMeasure   = Microsoft.AnalysisServices.AdomdClient.Measure;

namespace Hypercube.Client.Model
{
    public class Cube
        : IMetaModel
    {
        private readonly CubeDef cube;
        private readonly List<Dimension> dimensions;
        private readonly List<Measure>   measures;

        public Cube(CubeDef cube)
        {
            this.cube = cube ?? throw new ArgumentNullException(nameof(cube));
            dimensions = cube.Dimensions.OfType<AdomdDimension>()
                              .Where(dim => dim.DimensionType != DimensionTypeEnum.Measure)
                              .Select(dim => new Dimension(dim))
                              .ToList();

            measures = cube.Measures
                           .OfType<AdomdMeasure>()
                           .Select(m => new Measure(m)).ToList();
        }

        public CubeDef CubeDef => cube;
        public List<Dimension> Dimensions => dimensions;
        public List<Measure> Measures => measures;
        public string FriendlyName => cube.Caption;
        public string UniqueName => $"[{cube.Name}]";

        public override string ToString() => cube.ToString();
    }
}
