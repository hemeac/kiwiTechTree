using System.Linq;

namespace KiwiTechTree
{
    [KSPAddon(KSPAddon.Startup.SpaceCentre, false)]
    public class PluginHelper
    {
        private bool _techNodesConfigured;

        public void Update()
        {
            AddMissingTechNodes();
        }

        private void AddMissingTechNodes()
        {
            if (_techNodesConfigured) return;

            if (ResearchAndDevelopment.Instance == null) return;

            _techNodesConfigured = true;
            AssetBase.RnDTechTree.ReLoad();
            var rdNodes = AssetBase.RnDTechTree.GetTreeNodes().ToList();

            if (!(rdNodes[0].FindNodeByID("start", rdNodes) is ProtoRDNode startNode)) return;

            foreach (var childNode in startNode.children)
            {
                UnlockChildrenRecursively(childNode);
            }
        }

        private void UnlockChildrenRecursively(ProtoRDNode parent)
        {
            foreach (var childNode in parent.children)
            {
                UnlockChildrenRecursively(childNode);
            }

            UnlockParent(parent);
        }

        private void UnlockParent(ProtoRDNode childNode)
        {
            if (childNode.tech.state == RDTech.State.Unavailable) return;

            foreach (ProtoRDNode parentNode in childNode.parents)
            {
                if (parentNode.tech.state == RDTech.State.Available) continue;

                parentNode.tech.state = RDTech.State.Available;
                ResearchAndDevelopment.Instance.SetTechState(parentNode.tech.techID, parentNode.tech);
                ResearchAndDevelopment.Instance.UnlockProtoTechNode(parentNode.tech);
            }
        }
    }
}