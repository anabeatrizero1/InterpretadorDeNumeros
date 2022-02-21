using System;

namespace InterpretadorDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String entrada = "     __  __      __  __  __  __  __  __ \n"
                           + "   | __| __||__||__ |__    ||__||__||  |\n"
                           + "   ||__  __|   | __||__|   ||__| __||__|"
                           + "                                        ";
            Console.WriteLine(entrada);
            Console.WriteLine("__________________________________________");
            System.IO.StringReader leitor = new System.IO.StringReader(entrada);
            string primeitaLinha = leitor.ReadLine();
            char[] charLinha1 = primeitaLinha.ToCharArray();
            string segundaLinha = leitor.ReadLine();
            char[] charLinha2 = segundaLinha.ToCharArray();
            string terceiraLinha = leitor.ReadLine();
            char[] charLinha3 = terceiraLinha.ToCharArray();

            string linha1 = "";
            string linha2 = "";
            string linha3 = "";

            int contador = 0;

            for (int i = 0; i < 40; i++)
            {
                linha1 = linha1 + charLinha1[i];
                linha2 = linha2 + charLinha2[i];
                linha3 = linha3 + charLinha3[i];

                if(linha1 == "    " && linha2 == "   |" && linha3 == "   |")
                {
                    Console.Write("1");
                }if(linha1 == " __ " && linha2 == " __|" && linha3 == "|__ ")
                {
                    Console.Write("2");
                }if(linha1 == " __ " && linha2 == " __|" && linha3 == " __|")
                {
                    Console.Write("3");
                }if(linha1 == "    " && linha2 == "|__|" && linha3 == "   |")
                {
                    Console.Write("4");
                }if(linha1 == " __ " && linha2 == "|__ " && linha3 == " __|")
                {
                    Console.Write("5");
                }if(linha1 == " __ " && linha2 == "|__ " && linha3 == "|__|")
                {
                    Console.Write("6");
                }if (linha1 == " __ " && linha2 == "   |" && linha3 == "   |")
                {
                    Console.Write("7");
                }if(linha1 == " __ " && linha2 == "|__|" && linha3 == "|__|")
                {
                    Console.Write("8");
                }if(linha1 == " __ " && linha2 == "|__|" && linha3 == "|__|")
                {
                    Console.Write("9");
                }if(linha1 == " __ " && linha2 == "|  |" && linha3 == "|__|")
                {
                    Console.Write("0");
                }

                contador = contador + 1;
                
                if(contador == 4)
                {
                    linha1 = "";
                    linha2 = "";
                    linha3 = "";
                    contador = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
