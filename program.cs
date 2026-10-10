using System;

namespace AMinhaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string calc; 

            do
            {
                Console.Clear(); 
                Console.WriteLine("--- A MINHA CALCULADORA ---");

                Console.WriteLine("Digite o primeiro número:");
                double numero1;
                while (!double.TryParse(Console.ReadLine(), out numero1))
                {
                    Console.WriteLine("Erro! Por favor, digite apenas números:");
                }

                Console.WriteLine("Escolha a operação (+, -, *, /):");
                string operacao = Console.ReadLine() ??"";
                while (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
                {
                    Console.WriteLine("Erro! Digite apenas os símbolos permitidos (+, -, *, /):");
                    operacao = Console.ReadLine() ?? "";
                }

                Console.WriteLine("Digite o segundo número:");
                double numero2;
                while (!double.TryParse(Console.ReadLine(), out numero2))
                {
                    Console.WriteLine("Erro! Por favor, digite apenas números:");
                }

                double resultado = 0;
                bool erro = false;

                if (operacao == "+") {
                    resultado = numero1 + numero2;
                }
                else if (operacao == "-") {
                    resultado = numero1 - numero2;
                }
                else if (operacao == "*") {
                    resultado = numero1 * numero2;
                }
                else if (operacao == "/") {
                    if (numero2 == 0) {
                        Console.WriteLine("Erro: Não é possível dividir por zero!");
                        erro = true;
                    }
                    else {
                        resultado = numero1 / numero2;
                    }
                }

                if (erro == false)
                {
                    Console.WriteLine($"O resultado é: {resultado}");
                }

                Console.WriteLine(); 
                Console.WriteLine("Efetuar outro calculo? (Sim/Nao):");
                calc = (Console.ReadLine() ?? "").ToUpper();

                while (calc != "SIM" && calc != "NAO")
                {
                    Console.WriteLine("Erro! Responda apenas com 'Sim' ou 'Nao':");
                    calc = (Console.ReadLine() ?? "").ToUpper();
                }

            } while (calc == "SIM"); 
        }
    }
}