using System;

namespace Avaliacao
{
    using System;
    public class P3
    {
        static bool VerificaFeriado(DateTime data)
        {
            return false;
        }

        static bool VerificaFinalDeSemana(DateTime data)
        {
            return data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday;
        }

        static double CalcularJuros(int dias)
        {
            const double jurosPorDia = 0.03;
            return jurosPorDia * dias;
        }

        static double CalcularMulta()
        {
            const double multa = 2.00;
            return multa;
        }

        static void Main(string[] args)
        {
            DateTime dataVencimento, dataPagamento;

            Console.Write("Informe a data de vencimento (DD/MM/AAAA): ");
            dataVencimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Informe a data de pagamento (DD/MM/AAAA): ");
            dataPagamento = DateTime.Parse(Console.ReadLine());

            Console.Write("Informe o valor do boleto: ");
            double valorBoleto = double.Parse(Console.ReadLine());

            TimeSpan diasAtraso = dataPagamento - dataVencimento;

            if (diasAtraso.Days > 0)
            {
                if (VerificaFeriado(dataVencimento) && !VerificaFinalDeSemana(dataPagamento))
                {
                    diasAtraso = diasAtraso.Subtract(new TimeSpan(1, 0, 0, 0)); // Desconta o feriado do cálculo dos dias de atraso
                }

                if (diasAtraso.Days > 0)
                {
                    double juros = CalcularJuros(diasAtraso.Days);
                    double multa = CalcularMulta();
                    double valorRecalculado = valorBoleto + juros + multa;

                    Console.WriteLine($"Valor do boleto recalculado: R$ {valorRecalculado:F2}");
                    Console.WriteLine($"Valor total dos juros do período: R$ {juros:F2}");
                }
                else
                {
                    Console.WriteLine("Não há cobrança de juros nem multa.");
                }
            }
            else
            {
                Console.WriteLine("Não há cobrança de juros nem multa.");
            }
        }
    }
}
