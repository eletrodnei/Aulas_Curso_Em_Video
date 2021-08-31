using System;
using System.Collections.Generic;
using System.Threading;

namespace ContaBancaria
{

    class Program
    {
        static readonly List<Conta> lista = new List<Conta>();


        static void Main(string[] args)
        {
            
            
            int Menu = 6;
            while (Menu != 5)
            {
                try
                {
                    Menu = 6;
                    Console.WriteLine("Banco Itaú");
                    Console.WriteLine("O que deseja fazer?");
                    Console.WriteLine("1 - abrir conta, 2 - fechar conta, 3 - depositar, 4 - sacar , 5- Sair");
                    Menu = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                catch (Exception ex)

                {
                    Console.WriteLine("Caracter inválido !!", ex.Message);
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Thread.Sleep(2000);
                    Console.Clear();
                }


                switch (Menu)
                {
                    case 1:
                        Conta conta = new Conta();
                        string[] data = Inicio();
                        conta.AbrirConta(data[0],data[1], lista);
                        Console.Beep();
                        break;
                    case 2:
                        // código 2
                        break;
                    case 3:
                        // código 2
                        break;
                    case 4:
                        // código 2
                        break;
                }
            }

        }
            public static string[] Inicio()
        {
            string Nome;
            string Tipo;
            
            Console.WriteLine("Bem vindo ao Sistema");
            Console.Write("Digite seu primeiro nome :");
            Nome = Console.ReadLine();
            Console.Write("Digite o tipo de conta CC - conta corrente / CP - conta poupança :");
            Tipo = Console.ReadLine();
            string[] retorno = {Nome,Tipo}; 
            return retorno;

        }
    }
}
