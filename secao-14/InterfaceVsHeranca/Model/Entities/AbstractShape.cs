using InterfaceVsHeranca.Model.Enums;

namespace InterfaceVsHeranca.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
