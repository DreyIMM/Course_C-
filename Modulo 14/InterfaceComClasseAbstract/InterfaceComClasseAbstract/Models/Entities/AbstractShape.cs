
using InterfaceComClasseAbstract.Models.Enums;
namespace InterfaceComClasseAbstract.Models.Entities
{
    abstract class AbstractShape: IShape
    {
        public Color Color { get; set; }

        public abstract double Area();

    }
}
