using System;

namespace Avaliacao
{
    internal class P2
    {
        static double CalcularMedia(double nota1, double nota2, double nota3)
        {
            double[] notas = { nota1, nota2, nota3 };
            Array.Sort(notas);

            double media = (4 * notas[2] + 3 * (notas[0] + notas[1])) / 10;

            return media;
        }

        //static void Main(string[] args)
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Digite o código do aluno (ou 0 para encerrar):");
        //        int codigoAluno = Convert.ToInt32(Console.ReadLine());

        //        if (codigoAluno == 0)
        //        {
        //            break;
        //        }

        //        Console.WriteLine($"Digite as 3 notas do aluno {codigoAluno}:");
        //        double nota1 = Convert.ToDouble(Console.ReadLine());
        //        double nota2 = Convert.ToDouble(Console.ReadLine());
        //        double nota3 = Convert.ToDouble(Console.ReadLine());

        //        double media = CalcularMedia(nota1, nota2, nota3);

        //        string mensagem = (media >= 6) ? "APROVADO" : "REPROVADO";

        //        Console.WriteLine($"Aluno: {codigoAluno}");
        //        Console.WriteLine($"Notas: {nota1}, {nota2}, {nota3}");
        //        Console.WriteLine($"Média: {media} {mensagem}");
        //    }
        //}
    }
}
