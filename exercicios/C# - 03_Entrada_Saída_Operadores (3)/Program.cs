namespace C____03_Entrada_Saída_Operadores__3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salariobruto;
            float adicionalnoturno;
            float horasextras;
            float descontos;
            float salarioliquido;

            Console.WriteLine("Informe o Valor do Salário Brtuo:");
            salariobruto = Convert.ToSingle(Console.ReadLine());    

            Console.WriteLine("Informe o Valor de Adicional Noturno:");
            adicionalnoturno = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Informe o Valor de Horas Extras:");
            horasextras = Convert.ToSingle(Console.ReadLine()); 

            Console.WriteLine("Informe o Valor de Salário Líquido:");
            descontos = Convert.ToSingle(Console.ReadLine());

            salarioliquido = salariobruto + adicionalnoturno + (horasextras * 5) - descontos;

            Console.WriteLine("O Salário Líquido Será:");
            Console.WriteLine(salarioliquido); 

        }
    }
}