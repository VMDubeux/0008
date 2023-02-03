using System;
using System.Globalization;

namespace Exercicio
{
    class OitavoProjeto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descubra o valor do seu Imposto de Renda. Por favor, informe o seu salário:");
            double salario = double.Parse(Console.ReadLine());

            double impRend_Perc = 0.00;
            double impRend_Val = 0.00;

            if (salario <= 2000.00) {
                impRend_Perc = 0.00;
                impRend_Val = 0.00;
            }
            else if (salario > 2000.00 && salario <= 3000) {
                impRend_Perc = 0.08;
                impRend_Val = (salario - 2000) * impRend_Perc;
            }
            else if (salario > 3000.00 && salario <= 4500.00) {
                impRend_Perc = 0.18;
                impRend_Val = (999.99 * 0.08) + ((salario - 3000) * impRend_Perc);
            }
            else {
                impRend_Perc = 0.28;
                impRend_Val = (999.99 * 0.08) + (1499.99 * 0.18) + ((salario - 4500) * impRend_Perc);
            }
            Console.WriteLine($"O valor a ser pago a título de Imposto de Renda é: R${impRend_Val.ToString("F2", CultureInfo.InvariantCulture)}!");
        
            Console.ReadKey();
        }
    }
}