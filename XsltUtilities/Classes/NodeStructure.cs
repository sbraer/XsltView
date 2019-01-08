using System.Linq;
using System.Collections.Generic;

namespace XsltUtilities.Classes
{
    internal class NodeStructure
    {
        private NodeStructure() { }
        internal NodeStructure(string nodeName, int depth, NodeStructure parent)
        {
            NodeName = nodeName;
            Depth = depth;
            Items = new List<NodeStructure>();
            Parent = parent;
            Attributes = new MySortedDictionary();
        }
        internal string NodeName { get; set; }
        internal List<NodeStructure> Items { get; set; }
        internal int Depth { get; set; }
        internal int? LineNumberStart { get; set; }
        internal int? LineNumberEnd { get; set; }
        internal int? PositionStart { get; set; }
        internal int? PositionEnd { get; set; }
        internal NodeStructure Parent { get; set; }
        internal MySortedDictionary Attributes { get; set; }
        internal string XPath { get; set; }
        internal string Prefix { get; set; }
        internal string Namespace { get; set; }
        internal int? HashFromAttribute
        {
            get
            {
                return Attributes.HashKeyAttributesKeysAndValues;
            }
        }
    }
}
