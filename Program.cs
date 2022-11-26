public class Example
{
    public static void Main(string[] args)
    {
        int timeSleep = 2500;


        for (; ; )
        {
            Console.WriteLine("Quelle opération souhaitez vous effectuer ?");
            Console.WriteLine("Addition = [+] / Soustraction = [-] / Multiplication = [*] / Division = [/] / Puissance = [²] / Racine carré = [^^]");
            string op = Console.ReadLine();

            if (op == "^^")
            {
                Console.WriteLine("Entrez un nombre");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Racine carré de " + num1 + " = " + Math.Pow(num1, 0.5));
                Thread.Sleep(timeSleep);
                Console.Clear();
            }
            else if (op == "+")
            {
                Console.WriteLine("Entrez un nombre");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Entrez un nombre");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(num1 + num2);
                Thread.Sleep(timeSleep);
                Console.Clear();
            }
            else if (op == "-")
            {
                Console.WriteLine("Entrez un nombre");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Entrez un nombre");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(num1 - num2);
                Thread.Sleep(timeSleep);
                Console.Clear();
            }
            else if (op == "/")
            {
                Console.WriteLine("Entrez un nombre");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Entrez un nombre");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(num1 / num2);
                Thread.Sleep(timeSleep);
                Console.Clear();
            }
            else if (op == "*")
            {
                Console.WriteLine("Entrez un nombre");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Entrez un nombre");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(num1 * num2);
                Thread.Sleep(timeSleep);
                Console.Clear();
            }
            else if (op == "²")
            {
                Console.WriteLine("Entrez la puissance");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Entrez un nombre");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Pow(num2, num1));
                Thread.Sleep(timeSleep);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Opérateur invalide");
                Thread.Sleep(timeSleep);
                Console.Clear();
            }
            if (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Environment.Exit(1);
            }
        }
    }
}