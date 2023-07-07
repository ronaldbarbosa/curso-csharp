using InterfaceVsHeranca.Model.Enums;

namespace InterfaceVsHeranca.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
