using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo
{
    public class Triangle : Polygon
    {
        public int Height { get; set; }
        public override int Area()
        {
            return (Width * Height) / 2;
        }
    }
}