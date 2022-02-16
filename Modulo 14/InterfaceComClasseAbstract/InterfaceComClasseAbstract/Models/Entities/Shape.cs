using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceComClasseAbstract.Models.Enums;
namespace InterfaceComClasseAbstract.Models.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
