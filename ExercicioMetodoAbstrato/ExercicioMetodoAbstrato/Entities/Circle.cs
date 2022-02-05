using System;
using System.Collections.Generic;
using ExercicioMetodoAbstrato.Entities.Enums;
using System.Threading.Tasks;

namespace ExercicioMetodoAbstrato.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }


        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

    }
}
