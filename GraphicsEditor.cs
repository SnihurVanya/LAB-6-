using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LAB_6
{
    public class GraphicsEditor
    {
        private List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();

        public void AddPrimitive(GraphicPrimitive primitive)
        {
            primitives.Add(primitive);
        }

        public void DrawAll()
        {
            foreach (var primitive in primitives)
            {
                primitive.Draw();
            }
        }

        public void ScaleAll(float factor)
        {
            foreach (var primitive in primitives)
            {
                primitive.Scale(factor);
            }
        }

        public void GroupPrimitives(Group group, GraphicPrimitive[] children)
        {
            foreach (var child in children)
            {
                group.AddChild(child);
                primitives.Remove(child);
            }
            primitives.Add(group);
        }
    }
}
