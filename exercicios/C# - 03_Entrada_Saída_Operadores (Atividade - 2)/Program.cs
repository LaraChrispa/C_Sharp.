using System;

namespace C____03_Entrada_Saída_Operadores__Atividades___2__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1;
            float nota2;
            float nota3;
            float nota4;
            float media;

            Console.WriteLine("Digite a Nota - 1:");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a Nota - 2:");
            nota2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a Nota - 3:");
            nota3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a Nota - 4:");
            nota4 = Convert.ToSingle(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("A Média de Notas será:");

            Console.WriteLine(media);

        }
    }
}