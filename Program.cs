using System;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, situacao = "";
            double peso, altura, imc;
            string continua = "n";

            for (int x = 0; x < 5; x++){
                Console.WriteLine(x);
            }

            do
            {
                Console.Clear();

                Console.WriteLine("Digite o seu nome:");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o seu peso:");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o seu altura:");
                altura = Convert.ToDouble(Console.ReadLine());

                Console.Clear();

                imc = peso / (altura * altura);

                Console.WriteLine(nome + " Seu IMC é " + imc);

                if (imc <= 20)
                {
                    situacao = " abaixo do peso.";
                }
                else
                {
                    if (imc > 20 && imc < 25)
                    {
                        situacao = " peso normal.";
                    }
                    else
                    {
                        if (imc >= 25)
                        {
                            situacao = " acima do peso";
                        }
                    }
                }
                Console.WriteLine(nome + " a sua situação é " + situacao);
                Console.WriteLine("Quer continuar? (s/n)");
                continua = Console.ReadLine();

            } while (continua == "s");
        }
    }
}
