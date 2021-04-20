using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOrientadaObjeto.Calculadora
{
    public class Calculadora
    {

        public double primeiroNumero = 0;
        public double segundoNumero = 0;
        public string[] vetorStrings = new string[10];
        public string adicionarNaLista,operacao = "";
        double realizaOperacao = 0;



        public double RealizaCalculo(double numero1, double numero2, string opcaoOperacao)
        {

            
            primeiroNumero = numero1;
            segundoNumero = numero2;
            



            switch (opcaoOperacao)
            {

                case "1":
                    {

                        realizaOperacao = primeiroNumero + segundoNumero;
                        operacao = "+";
                        break;
                    }
                case "2":
                    {
                        realizaOperacao = primeiroNumero - segundoNumero;
                        operacao = "-";
                        break;
                    }
                case "3":
                    {
                        realizaOperacao = primeiroNumero * segundoNumero;
                        operacao = "*";
                        break;
                    }
                case "4":
                    {
                        realizaOperacao = primeiroNumero / segundoNumero;
                        operacao = "/";
                        break;
                    }
            }

            return realizaOperacao;
        }

        public Boolean ValidaSegundoNumero(double numero2)
        {
            

            if (numero2 == 0)
            {

                
                return false;
            }

            return true;
        }
        
        public void AdcionarVetor(int contador)
        {
            for (int i = 0; i < vetorStrings.Length; i++)
            {
                vetorStrings[contador] = $"{primeiroNumero} {operacao} {segundoNumero} = {realizaOperacao}";
            }
        }

        public void ListarVetor(int contador)
        {
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(vetorStrings[i]);
            }
        }
    }
}
