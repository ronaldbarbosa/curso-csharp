using System.Globalization;

using Exercicio_resolvido.Entities;
using Exercicio_resolvido.Entities.Enums;

namespace Exercicio_resolvido
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());
            List<Shape> shapesList = new List<Shape>();

            for (int i = 1; i <= numberOfShapes; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or circle (r/c)? ");
                char shape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                switch (shape)
                {
                    case 'r':
                        Console.Write("Width: ");
                        double width = double.Parse(Console.ReadLine());
                        System.Console.Write("Height: ");
                        double height = double.Parse(Console.ReadLine());
                        shapesList.Add(new Rectangle(color, width, height));
                        break;
                    case 'c':
                        Console.Write("Radius: ");
                        double radius = double.Parse(Console.ReadLine());
                        shapesList.Add(new Circle(color, radius));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in shapesList)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}