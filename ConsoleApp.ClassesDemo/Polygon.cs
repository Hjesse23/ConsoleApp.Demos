using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo
{
    public abstract class Polygon
    {
        public double Width { get; set; }

        public abstract double Area();
    }
}