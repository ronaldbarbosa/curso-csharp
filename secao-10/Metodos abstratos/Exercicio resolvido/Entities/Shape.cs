using Exercicio_resolvido.Entities.Enums;

namespace Exercicio_resolvido.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}