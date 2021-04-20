using CalculadoraOrientadaObjeto.Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOrientadaObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora.Calculadora conta = new Calculadora.Calculadora();

            string opcaoOperacao = "";
            double primeiroNumero = 0;
            double segundoNumero = 0;
            string opcaoMenu = "";
            int contador = 0;


            

            while (opcaoMenu != "S")
            {
                opcaoMenu = Menu();

                EhOpcaoSair(opcaoMenu);

                switch (opcaoMenu)
                {

                    case "1":
                        {
                            PegaNumero(out primeiroNumero, out segundoNumero);
                            Console.WriteLine(conta.RealizaCalculo(primeiroNumero, segundoNumero, opcaoMenu));
                            Console.ReadLine();
                            
                            conta.AdcionarVetor(contador);
                            contador++;
                            
                            Console.Clear();
                            break;

                        }


                    case "2":
                        {
                            PegaNumero(out primeiroNumero, out segundoNumero);
                            Console.WriteLine(conta.RealizaCalculo(primeiroNumero, segundoNumero, opcaoMenu));
                            Console.ReadLine();

                            conta.AdcionarVetor(contador);
                            contador++;

                            Console.Clear();
                            break;
                        }
                    case "3":
                        {
                            PegaNumero(out primeiroNumero, out segundoNumero);
                            Console.WriteLine(conta.RealizaCalculo(primeiroNumero, segundoNumero, opcaoMenu));
                            Console.ReadLine();

                            conta.AdcionarVetor(contador);
                            contador++;
                            
                            Console.Clear();
                            break;
                        }
                    case "4":
                        {
                            PegaNumero(out primeiroNumero, out segundoNumero);

                            if(conta.ValidaSegundoNumero(segundoNumero) == false)
                            {
                                Console.WriteLine("Numero invalido, tente novamente");
                                Console.ReadLine();
                                Console.Clear();
                                continue;
                            }

                            
                            Console.WriteLine(conta.RealizaCalculo(primeiroNumero, segundoNumero, opcaoMenu));
                            Console.ReadLine();
                            
                            conta.AdcionarVetor(contador);
                            contador++;
                            
                            Console.Clear();
                            break;
                        }
                    case "5":
                        {
                            conta.ListarVetor(contador);
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                    case "S":
                        {
                            break;
                        }
                }
            }

        }

        private static string Menu()
        {
            string opcaoMenu;
            Console.WriteLine("1 - para somar");
            Console.WriteLine("2 - para subtrair");
            Console.WriteLine("3 - para multiplicar");
            Console.WriteLine("4 - para dividir");
            Console.WriteLine("5 - para listar");
            Console.WriteLine("S - para sair");
            opcaoMenu = Console.ReadLine();
            return opcaoMenu;
        }

        private static void PegaNumero(out double primeiroNumero, out double segundoNumero)
        {
            Console.WriteLine("Informe o primeiro numero");
            primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero");
            segundoNumero = Convert.ToDouble(Console.ReadLine());
        }

        private static bool EhOpcaoSair(string opcao)
        {
            return opcao.Equals("s", StringComparison.OrdinalIgnoreCase);
        }

    }
}

