using AdomdHierarchy = Microsoft.AnalysisServices.AdomdClient.Hierarchy;

namespace Hypercube.Client.Model
{
    public class AttributeHierarchy
        : Hierarchy
    {
        public AttributeHierarchy(AdomdHierarchy hierarchy)
            : base(hierarchy)
        { }
    }
}
