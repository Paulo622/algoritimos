using System;


namespace _04_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variável
            // Sintaxe: tipo nomeVariável =valor
            string nome = "Fulano de Tal";

            //Reatribuição de valor em uma variável
            nome = "Beltrano";
            Console.WriteLine(nome);

            //Declaração de vetores
            //Sintaxe: tipo[] nomeVariavel = {valor1, valor2, valor3}
            string[] nomes = { "Fulano de tal", "Beltrano", "Sicrano", "João", "Paulo", "Maria"};
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);

            //Loop FOR
            // Sintaxe: for(indice; controle; incremento)
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("{0}° Nome: {1}",i+1, nomes[i]);
            }

            //Impressão dos 100 primeiros números pares
            for (int i = 0; i <= 100; i+=2)
            {
                Console.WriteLine("Número: {0}", i);
            }

            // Loop foreach
            // Sintaxe: foreach( variavel in vetor )
            foreach (string varNome in nomes)
            {
                Console.WriteLine("Mome: {0}", varNome);
            }
        }
    }
}
