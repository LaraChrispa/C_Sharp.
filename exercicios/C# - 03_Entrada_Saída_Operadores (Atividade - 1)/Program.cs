namespace C____03_Entrada_Saída_Operadores__Atividades___1__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario;
            float abono;
            float novosalario;

            Console.WriteLine("Digite o Salário:");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o Abono:");
            abono = Convert.ToSingle(Console.ReadLine());

            novosalario = salario + abono;

            Console.WriteLine("Novo Salário:");
            
            Console.WriteLine(novosalario); 
        }
    }
}    