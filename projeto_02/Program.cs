using System;

namespace projeto_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Double imc, peso, altura;

            Console.WriteLine("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
                Console.WriteLine("Seu imc é: " + imc + "Você está classificado como Desnutrido");
            else if (imc < 25)
                Console.WriteLine("Seu imc é: " + imc + "Você está classificado como Adequado");
            else if (imc < 30)
                Console.WriteLine("Seu imc é: " + imc + "Você está classificado como Pré-Obeso");
            else if (imc < 35)
                Console.WriteLine("Seu imc é: " + imc + "Você está classificado como Obesidade Nível I");
            else
                Console.WriteLine("Seu imc é: " + imc + "Você está classificado como Obesidade Nível II");
        }
    }
}
