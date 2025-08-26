using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _09_Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o mês (1..12):");
            int mes = int.Parse(Console.ReadLine());


            Console.Write("Digite o ano:");
            int ano = int.Parse(Console.ReadLine());

            //Descobre a quantidade de dias do mês 
            int diasDoMes = DateTime.DaysInMonth(ano, mes);

            //Descobre o dia da semana do primeiro dia do mês
            //  0 = Domingo - 6 = Sábado
            //Gera o primeiro dia do mês e o ano informado pelo usuário
            DateTime primeiroDiaMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;

            //Matriz de 6 semanas e 7 dias
            int[,] calendario = new int[6, 7];

            int dia = 1;

            //Preenche a matriz com os dias do mês
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (semana == 0 && diaSemana < diaSemanaInicio)
                    {
                        calendario[semana, diaSemana] = 0;
                    }
                    else if (dia <= diasDoMes)
                    {
                        calendario[semana, diaSemana] = dia;
                        dia++;
                    }
                }
            }

            Console.WriteLine($"\nCalendário de " +
            $"{primeiroDiaMes.ToString("MMMM")} de {ano}");

            Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");

            //iMPRESSÃO do calendário
            int[] diasFeriados = RetornaFeriados(mes, ano);
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (calendario[semana, diaSemana] != 0)
                    {
                        if (diasFeriados.Contains(calendario[semana, diaSemana]) || diaSemana == 0)
                            Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write(calendario[semana, diaSemana].ToString("D2") + "\t");

                        Console.ResetColor();
                    }

                    else
                    {
                        Console.Write("\t");
                    }


                }
                Console.WriteLine();
            }

            Console.Write(" \nFeriados : ");
            for (int i = 0; i < diasFeriados.Length; i++)
            {
                if (diasFeriados[1] > 0)
                {
                    Console.WriteLine($"{diasFeriados[i].ToString("D2")}\t");
                }



            }
            Console.ReadKey();
        }

        public static int[] RetornaFeriados(int mes, int ano)
        {
            int[] feriados = new int[15];

            int indice = 0;
            //feriados[indice] = 11;
            //indice = indice + 1;

            if (mes == 1) feriados[indice++] = 1;
            else if (mes == 4) feriados[indice++] = 21;
            else if (mes == 5) feriados[indice++] = 1;
            else if (mes == 7) feriados[indice++] = 9;
            else if (mes == 9) feriados[indice++] = 7;
            else if (mes == 10) feriados[indice++] = 12;
            else if (mes == 11)
            {
                feriados[indice++] = 2;
                feriados[indice++] = 15;
                feriados[indice++] = 20;
            }

            else if (mes == 12)
            {
                feriados[indice++] = 25;
            }

            DateTime domingodePascoa = DomingodePascoa(ano);
            DateTime carnaval = DomingodePascoa(ano).AddDays(-47);
            DateTime sextaFeiraSanta = DomingodePascoa(ano).AddDays(-2);
            DateTime corpusChristi = DomingodePascoa(ano).AddDays(60);


            return feriados;

        }

        private static DateTime DomingodePascoa(int ano)
        {
            throw new NotImplementedException();
        }

        public class DomingoDePascoa
        {
            public static DateTime CalcularDomingodePascoa(int ano)
            {
                int X = 0, Y = 0;

                // Ajuste de constantes X e Y conforme o século
                if (ano <= 1699) { X = 22; Y = 2; }
                else if (ano <= 1799) { X = 23; Y = 3; }
                else if (ano <= 1899) { X = 24; Y = 4; }
                else if (ano <= 2099) { X = 24; Y = 5; }
                else if (ano <= 2199) { X = 24; Y = 6; }
                else if (ano <= 2299) { X = 24; Y = 7; }

                int a = ano % 19;
                int b = ano % 4;
                int c = ano % 7;
                int d = (19 * a + X) % 30;
                int g = (2 * b + 4 * c + 6 * d + Y) % 7;

                int dia;
                int mes;

                if ((d + g) > 9)
                {
                    dia = d + g - 9;
                    mes = 4; // Abril
                }
                else
                {
                    dia = d + g + 22;
                    mes = 3; // Março
                }

                return new DateTime(ano, mes, dia);
            }



        }

       

           
        
            
        

   
    }



      
}

