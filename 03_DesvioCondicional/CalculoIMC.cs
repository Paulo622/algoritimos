using System;

class CalculoIMC
{
	static void Main()
	{
		double peso, altura, imc;
		
		Console.WriteLine("Digite seu peso (kg):");
		//Console.ReadLine() é equivalente ao Leia do Portugol
		peso = Double.Parse( Console.ReadLine() );
		
		Console.WriteLine("Digite sua altura (m):");
		//Double.parse = converte o texto em número decimal
		altura = Double.Parse( Console.ReadLine() );
		
		imc = peso / (altura *altura);
		
		Console.WriteLine("Seu IMC é {0:F3}", imc);
		
		if(imc < 18.5)
		{
			Console.WriteLine("Classificação: abaixo do peso");
		}else if(imc < 25)
		{
			Console.WriteLine("Classificação: peso normal");
		}else
		{
			Console.WriteLine("Classificação: acima do peso");
		}
	}
}