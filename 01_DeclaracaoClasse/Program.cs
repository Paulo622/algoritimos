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
        public int Banco { get; set; }
        public string Agencia { get; set; }
        public string Numero { get; set; }

        public decimal Saldo { get; private set; }
        public decimal Limite { get; set; }

        public Conta(int banco, string agencia, string numero, decimal saldoInicial = 0.00m, decimal limite = 0.00m)
        {
            Banco = banco;
            Agencia = agencia;
            Numero = numero;
            Saldo = saldoInicial;
            Limite = limite;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser maior que zero.");
                return;
            }

            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado. Novo saldo: {Saldo:C}");
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser maior que zero.");
                return;
            }

            if (Saldo + Limite >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado. Novo saldo: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }

        public decimal ConsultarSaldo()
        {
            return Saldo;
        }
    }


}
