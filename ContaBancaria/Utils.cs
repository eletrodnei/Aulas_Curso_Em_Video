using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ContaBancaria
{
    public class Utils
    {
        public static int GerarNumero()
        {
            Random numero = new Random();
            int resultado = numero.Next(5) + 1;
            return resultado;
        }

        public static Boolean VerificarNumero(int numero, List<Conta> lista)
        {
            Boolean Exist = false;
            
            
            for (int c = 0; c < lista.Count; c++)
            {
                if (numero != lista[c].NumConta1)
                {
                    Exist = false;
                    
                }
                else
                {
                    Exist = true;
                    
                    break;
                }

            }
            return Exist;
        }
        public static void Menu(List<Conta> lista)
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
                    Thread.Sleep(3000);
                    Console.Clear();
                }


                switch (Menu)
                {
                    case 1:
                        int MaximoDeContas = 4;
                        if (lista.Count >= MaximoDeContas)
                        {
                            Console.WriteLine("Numero maximo de contas atingido !!!");
                            Console.Beep();
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Conta conta = new Conta();
                            lista.Add(conta);
                            int numero = 0;
                            Boolean Existe = true;
                            for (Boolean c = true; c == Existe; c = true)
                            {
                                numero = Utils.GerarNumero();
                                Existe = Utils.VerificarNumero(numero, lista);

                            }
                            string[] data = Inicio();
                            conta.AbrirConta(numero, data[0], data[1]);
                            Console.WriteLine("Conta criada com sucesso !!");
                            Console.Beep();
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }

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
                Console.Clear();
            }
        }
        private static string[] Inicio()
        {
            string Nome;
            string Tipo = "";

            Console.WriteLine("Bem vindo ao Sistema");
            Console.Write("Digite seu primeiro nome : ");
            Nome = Console.ReadLine();
            Console.Write("Digite o tipo de conta CC - conta corrente / CP - conta poupança : ");
            while (Tipo != "casdc334ddfs")
            {


                switch (Tipo = Console.ReadLine())

                {

                    case "cc":
                        Tipo = "CC";
                        string[] retorno = { Nome, Tipo };
                        return retorno;
                        
                    case "cp":
                        Tipo = "CP";
                        string[] ret = { Nome, Tipo };
                        return ret;
                    default:
                        Console.Write("Opção Inválida !!!");
                        Console.Beep();
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.Write("Digite o tipo de conta CC - conta corrente / CP - conta poupança : ");
                        break;
                }

            }
            string[] retor = { Nome, Tipo };
            return retor;
            
            

        }

    }
}
