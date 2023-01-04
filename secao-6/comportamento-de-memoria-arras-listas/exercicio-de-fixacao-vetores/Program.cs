using System;

namespace exercicio_de_fixacao_vetores
{
    public class Vetores
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("How many rooms will be rented? ");
            int numberOfRooms = int.Parse(Console.ReadLine());
            Student[] rentedRooms = new Student[10];

            Console.WriteLine();

            for (int i = 1; i <= numberOfRooms; i++)
            {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Student student = new Student(name, email);
                rentedRooms[room] = student;
                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms:");

            for(int i = 0; i < 10; i++)
            {
                if(rentedRooms[i] != null)
                {
                    Console.WriteLine($"{i}: {rentedRooms[i]}");
                }
            }
        }
    }
}