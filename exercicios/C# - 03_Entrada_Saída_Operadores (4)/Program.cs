namespace C____03_Entrada_Saída_Operadores__Atividade___3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1; 
            float numero2;
            float numero3;  
            float numero4;
            float diferenca;

            Console.WriteLine("Informe o Número 1: "); 
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe o Número 2: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe o Número 3: ");
            numero3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe o Número 4: ");
            numero4 = Convert.ToSingle(Console.ReadLine());

            diferenca = (numero1 * numero2) - (numero3 * numero4);

            Console.WriteLine("A Diferença Entre a Multiplicação do Numero 1 e Numero 2 por Numero 3 e Numero 4 será: ");

            Console.WriteLine($"{diferenca:F2}"); 
        }
    }
}