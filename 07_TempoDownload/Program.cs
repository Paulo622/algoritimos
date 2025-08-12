using System;
using System.Diagnostics.Eventing.Reader;

namespace _07_TempoDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
         double tamanhoMB = 0;
         double velocidadeMbps = 0;
         double tempoSegundos, tempoMinutos;

            while (true)
            {
                Console.Write("Informe o tamanho do arquivo(MB): ");
                if (double.TryParse(Console.ReadLine(), out tamanhoMB) && tamanhoMB > 0)


                        break;
                else
                
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");


            }

            
            while (true)
            {
                Console.Write("Informe a velocidade da sua conexão (Mbps): ");
                if (double.TryParse(Console.ReadLine(), out velocidadeMbps) && velocidadeMbps > 0)
                
                        break;     
                else
                
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
            }

            tempoSegundos = (tamanhoMB * 8) / velocidadeMbps;
            tempoMinutos = tempoSegundos / 60;
             Console.WriteLine($"Tempo aproximado de download :{tempoMinutos: F2} minutos ");
        
        }
    }
}
