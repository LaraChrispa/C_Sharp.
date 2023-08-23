namespace Calculadora{    internal class Program    {        static void Main(string[] args)        {            float numero1, numero2;

            Console.WriteLine("Digite o Primeiro Número:");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o Primeiro Número:");
            numero2 = Convert.ToSingle(Console.ReadLine());

            divisao = numero1 / numero2; 

            Console.WriteLine($"{numero1} + {numero2} = " + (numero1 + numero2));
            Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + (numero1 * numero2));
            Console.WriteLine("{0:F3} / {1:F} = {2:F2}", numero1, numero2, divisao);
            Console.WriteLine(Math.Round(divisao, 2));
            Console.WriteLine($"{numero1} ^ {numero2} = " + Math.Pow(numero2, numero2)); 
            Console.WriteLine($"Raiz Quadrada de {numero} = " + Math.S)
        }    }}