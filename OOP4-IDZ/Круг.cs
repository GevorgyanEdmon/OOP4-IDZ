using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_IDZ
{
    internal class Круг : Геометрия
    {
        protected float diameter;
        public Круг(bool pIs3D, string pName, float pDiameter) : base(pIs3D, pName)
        {
            diameter = pDiameter;
        }
        public override void GetPerimeter()
        {
            Console.WriteLine($"Периметр круга = {diameter/2*3,14}");
        }
    }
}
