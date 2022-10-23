using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_IDZ
{
    internal class Прямоугольник : Четырехугольник
    {
        public Прямоугольник(bool pIs3D, string pName, float pSt1, float pSt2, float pSt3, float pSt4) : base(pIs3D, pName, pSt1, pSt2, pSt3, pSt4)
        {

        }
        public override void GetPerimeter()
        {
            Console.WriteLine($"Периметр прямоугольнка = {st1 + st2 + st3 + st4}");
        }
    }
}
