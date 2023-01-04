public class Program
{
    public static void Main(string[] args)
    {
        // Nullable: faz com que tipos que não poderiam receber null possam receber.
        double? x = null;
        double? y = 10;

        // ?? é o operador de coalescência nula: se o valor de x for nulo, 5 é atribuído a 'a'. 
        double a = x ?? 5;
        double b = y ?? 5;

        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
    }
}