using System;

namespace CalculadoraEmCSharp
{
    class Program
    {
        static void Main(string[] args)
        {         

            Console.WriteLine("-=-=-=Calculadora=-=-=-");
            Console.WriteLine("-=-=-=-Versão 1.0=-=-=-");

            Menu();

            Console.Clear();

            Console.ReadKey();
        }

        static void Menu()
        {
            //Console.Clear();
            Console.Beep();

            int opcao;

            Console.WriteLine("-=-Digite uma Opção=-=-");
            Console.WriteLine("Soma................[1]");
            Console.WriteLine("Subtrção............[2]");
            Console.WriteLine("Multiplicação.......[3]");
            Console.WriteLine("Divisão.............[4]");
            Console.WriteLine("Radiciação..........[5]");
            Console.WriteLine("Potenciação.........[6]");
            Console.WriteLine("Sair................[0]");

            opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado Por Usar Nossa Calculadora. Até Mais!");
                        break;
                    case 1:
                        Soma();      
                        Menu();
                        break;
                    case 2:
                        Subtracao();
                        Menu();
                        break;
                    case 3:
                        Multiplicacao();
                        Menu();
                        break;
                    case 4:
                        Divisao();
                        Menu();
                        break;
                    case 5:
                        Radiciacao();
                        Menu();
                        break;
                    case 6:
                        Pontenciacao();
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Digite um valor Valido!");
                        Menu();
                        break;
                }            
        }

        static void Soma()
        {
            double primeiroValor, segundoValor, resultado;

            Console.WriteLine("Digite o Primeiro Valor:");
            primeiroValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Valor:");
            segundoValor = double.Parse(Console.ReadLine());

            resultado = primeiroValor + segundoValor;

            Console.WriteLine("A Soma do numero {0} mais {1} é igual a {2}", primeiroValor, segundoValor, resultado);

        }

        static void Subtracao()
        {

            double primeiroValor, segundoValor, resultado;

            Console.WriteLine("Digite o Primeiro Valor:");
            primeiroValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Valor:");
            segundoValor = double.Parse(Console.ReadLine());

            resultado = primeiroValor - segundoValor;

            Console.WriteLine("A Subtração do numero {0} pelo {1} é igual a {2}", primeiroValor, segundoValor, resultado);

        }

        static void Multiplicacao()
        {

            double primeiroValor, segundoValor, resultado;

            Console.WriteLine("Digite o Primeiro Valor:");
            primeiroValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Valor:");
            segundoValor = double.Parse(Console.ReadLine());

            resultado = primeiroValor * segundoValor;

            Console.WriteLine("O Produto do numero {0} pelo {1} é igual a {2}", primeiroValor, segundoValor, resultado);
        }

        static void Divisao()
        {

            double primeiroValor, segundoValor, resultado;

            Console.WriteLine("Digite o Primeiro Valor:");
            primeiroValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Valor:");
            segundoValor = double.Parse(Console.ReadLine());

            resultado = primeiroValor / segundoValor;
            //double exibir = Math.Round(resultado, 2);

            Console.WriteLine("A Divisão do numero {0} por {1} é igual a {2}", primeiroValor, segundoValor, Math.Round(resultado, 2));
        }

        static void Radiciacao()
        {

            double primeiroValor, segundoValor, resultado;

            Console.WriteLine("Digite um valor para saber sua Raiz Quadrada:");
            primeiroValor = double.Parse(Console.ReadLine());


            resultado = Math.Sqrt(primeiroValor);

            Console.WriteLine("A Raiz Quadrada de {0} é {1}", primeiroValor, Math.Round(resultado, 2));
        }

        static void Pontenciacao()
        {

            double primeiroValor, segundoValor, resultado;

            Console.WriteLine("Digite o Primeiro Valor para Base:");
            primeiroValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Valor para o Expoente:");
            segundoValor = double.Parse(Console.ReadLine());

            resultado = Math.Pow(primeiroValor, segundoValor);

            Console.WriteLine("O numero {0} elevado a {1}ª ponencia é {2}", primeiroValor, segundoValor, resultado);
        }
    }
}