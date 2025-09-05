using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DeclaracaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado obj1 = new Quadrado();
            obj1.Lado = 5;
            obj1.ImprimeArea();

            obj1.Lado = 15;
            obj1.ImprimeArea();

            Quadrado obj2 = new Quadrado();
            obj2.Lado = 25;
            obj2.ImprimeArea();

            Retangulo obj3 = new Retangulo();
            obj3.Base = 10;
            obj3.Altura = 5;
            obj3.ImprimeArea();

            Circulo obj4 = new Circulo();
            obj4.Raio = 14;
            obj4.ImprimeArea();

            Triangulo obj5 = new Triangulo();
            obj5.Base = 8;
            obj5.Altura = 6;
            obj5.ImprimeArea();

            Conta minhaConta = new Conta(001, "1234-5", "67890-1", 1000.00m, 500.00m);
            Console.WriteLine($"Saldo inicial: {minhaConta.ConsultarSaldo():C}");
            minhaConta.Depositar(250.00m);

            Decimal valorSaque = 300.00m;
            minhaConta.Sacar(valorSaque);
            Console.WriteLine($"Saldo final: {minhaConta.ConsultarSaldo():C}");

            Decimal valorSaque2 = 2000.00m;
            minhaConta.Sacar(valorSaque2);

            Aluno aluno1 = new Aluno();
            aluno1.código = 1;
            aluno1.nome = "João Silva";

            aluno1.LancarNota();
            Console.WriteLine($"Aluno {aluno1.nome} está {aluno1.Menção()}");
            aluno1.notas[0] = 4.0;

            aluno1.LancarNota();
            Console.WriteLine($"Aluno {aluno1.nome} está {aluno1.Menção()}");
            aluno1.notas[1] = 5.0;

            aluno1.LancarNota();
            Console.WriteLine($"Aluno {aluno1.nome} está {aluno1.Menção()}");
            aluno1.notas[2] = 6.0;

            aluno1.LancarNota();
            Console.WriteLine($"Aluno {aluno1.nome} está {aluno1.Menção()}");
            aluno1.notas[3] = 7.0;
            Console.ReadKey();

        }
    }

    public class Quadrado
    {
        public int Lado;

        public int CalcularArea()
        {
            int area = Lado * Lado;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Quadrado com lado de {Lado} possui uma área de {CalcularArea()}");
        }
    }

    public class Retangulo
    {
        public int Base;
        public int Altura;

        public int CalcularArea()
        {
            int area = Base * Altura;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Retângulo com base de {Base} e altura de {Altura} possui uma área de {CalcularArea()}");
        }
    }

    public class Circulo
    {
        public double Raio;
        public double CalcularArea()
        {
            double area = Math.PI * Raio * Raio;
            return area;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Círculo com raio de {Raio} possui uma área de {CalcularArea()}");
        }
    }

    public class Triangulo
    {
        public double Base;
        public double Altura;
        public double CalcularArea()
        {
            double area = (Base * Altura) / 2;
            return area;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Triângulo com base de {Base} e altura de {Altura} possui uma área de {CalcularArea()}");
        }


    }

    public class Conta
    {
        public int Banco;
        public string Agencia;
        public string Numero;

        public decimal Saldo;
        public decimal Limite;

        public Conta(int banco, string agencia, string numero, decimal saldo, decimal limite)
        {
            Banco = banco;
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
            Limite = limite;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public decimal ConsultarSaldo()
        {
            return Saldo;
        }
    }

    public class Aluno 
    {
        public int código;

        public string nome;

        public double[] notas = { 9.6, 8.0, 9.5, 10.0 }; // Declara e inicializa com 4 valores = new double [4];

        public double CalcularMedia()
        {
            double soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }
            return soma / notas.Length;
        }

        public void LancarNota()
        {
            Console.WriteLine($"Aluno {nome} possui média {CalcularMedia()}");
        }

        public string Menção()
        {
            double media = CalcularMedia();
            if (media >= 5)
            {
                return "Aprovado";
            }
            else if (media >= 5)
            {
                return "Recuperação";
            }
            else
            {
                return "Reprovado";
            }

            
        }
    }
}
