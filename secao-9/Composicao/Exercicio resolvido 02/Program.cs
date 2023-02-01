using Exercicio_resolvido_02.Entities;

namespace Exercicio_resolvido_02
{
    class Program
    {
        public static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("That's awsome");
            Post p1 = new Post(
                DateTime.Now,
                "Traveling to New Zeland",
                "I'm going to visit this wonderful country",
                12
            );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(
                DateTime.Parse("07/02/2023 23:41:12"),
                "Good night guys",
                "See you tomorrow",
                12
            );
            p2.AddComment(c3);
            p2.AddComment(c4);

            System.Console.WriteLine(p1);
            System.Console.WriteLine(p2);
        }
    }
}