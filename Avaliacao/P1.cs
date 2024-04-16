using System;

namespace Avaliacao
{
    public class P1 
    {
        static int totalCarrosAte2000 = 0;
        static int totalGeral = 0;

        static void CalcularDesconto()
        {
            Console.Write("Digite o ano do veículo: ");
            int anoVeiculo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do veículo: ");
            double valorCarro = Convert.ToDouble(Console.ReadLine());

            double valorDesconto;
            if (anoVeiculo <= 2000)
            {
                valorDesconto = valorCarro * 0.12;
                totalCarrosAte2000++;
            }
            else
            {
                valorDesconto = valorCarro * 0.07;
            }

            double valorFinal = valorCarro - valorDesconto;

            Console.WriteLine($"Valor do desconto: {valorDesconto:F2}");
            Console.WriteLine($"Valor a ser pago pelo cliente: {valorFinal:F2}");

            totalGeral++;

            Console.Write("Deseja continuar calculando desconto? (S/N): ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                CalcularDesconto();
            }
            else
            {
                Console.WriteLine($"Total de carros com ano até 2000: {totalCarrosAte2000}");
                Console.WriteLine($"Total geral de carros: {totalGeral}");
            }
        }

        //static void Main(string[] args)
        //{
        //    CalcularDesconto();
        //}
    }
}
