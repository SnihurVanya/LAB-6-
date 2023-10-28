using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    public class Triangle : GraphicPrimitive
    {
        public override void Draw()
        {
            Console.WriteLine($"Drawing a triangle at ({X}, {Y})");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(float factor)
        {
            // Реалізація масштабування для трикутника
        }
    }
}
