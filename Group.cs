using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    public class Group : GraphicPrimitive
    {
        private List<GraphicPrimitive> children = new List<GraphicPrimitive>();

        public void AddChild(GraphicPrimitive child)
        {
            children.Add(child);
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a group:");
            foreach (var child in children)
            {
                child.Draw();
            }
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
            foreach (var child in children)
            {
                child.Move(x, y);
            }
        }

        public override void Scale(float factor)
        {
            foreach (var child in children)
            {
                child.Scale(factor);
            }
        }
    }

}
