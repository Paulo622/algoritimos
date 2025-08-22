using System;
using System.Text.RegularExpressions;

namespace _08_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu CPF:");
            string cpf = Console.ReadLine();

            string cpfLimpo = Regex.Replace(cpf, "[^0-9]", "");

            if (cpfLimpo.Length != 11)
            {
                Console.WriteLine("Cpf digitado : " + cpf);
                Console.WriteLine("Somente números: " + cpfLimpo);
            }

            else
            {
                Console.WriteLine("Cpf Inválido! o campo deve conter 11 dígitos.");
            }

            if (cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" ||
                cpf == "44444444444" || cpf == "55555555555" || cpf == "66666666666" ||
                cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999"
            )
            {
                Console.WriteLine("Cpf Inválido! Números repetidos não são permitidos");
                return;
            }

            int soma = 0;
            char[] cpfVetor = cpf.ToCharArray();

            for ( int i = 0; i < 9; i++) 
            {
                soma += int.Parse(cpfVetor[1].ToString()) * (10 - i);
            }

            int resto = soma % 11;

            int digX = 0;
            if (resto >= 0)
            {
                digX = 11 - resto;
            }

            resto = soma % 11;

            int digY = 0;
            if (resto >= 2)
            {
                digY = 11 - resto;
            }

            if(
                int.Parse(cpf[9].ToString()) == digX && 
                int.Parse(cpf[10].ToString()) == digY
                )
            {
                Console.WriteLine("CPF Válido! ");
            }
            else
            {
                Console.WriteLine("CPF Inválido!");
            }



        }
    }
}
