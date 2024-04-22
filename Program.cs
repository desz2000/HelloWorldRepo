namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
            Console.Write("Bora fazer conta!! \n");

            Console.Write("Digite o primeiro número: ");
            int n1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int n2 = Convert.ToInt16(Console.ReadLine());

            CalculadoraSimples.Calculadora(n1, n2);
    }
}