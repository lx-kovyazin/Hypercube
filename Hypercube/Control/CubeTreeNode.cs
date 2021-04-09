using Hypercube.Client.Model;
using System.Windows.Forms;

namespace Hypercube.Control
{
    public class CubeTreeNode
        : TreeNode
    {
        const string KEY_POSTFIX = "Icon.png";

        internal CubeTreeNode(IMetaModel metaModel)
        {
            Text = metaModel.FriendlyName;
            Tag = metaModel;
            SelectedImageKey = ImageKey = metaModel.GetType().Name + KEY_POSTFIX;
        }
    }
}
