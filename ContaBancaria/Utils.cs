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
            int Menu = 7;
            while (Menu != 6)
            {
                try
                {
                    Menu = 6;
                    Console.WriteLine("Banco Itaú");
                    Console.WriteLine("O que deseja fazer?");
                    Console.WriteLine("1 - abrir conta, 2 - fechar conta, 3 - consultar conta, 4 - sacar , 5 - depositar 6- Sair");
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
                            Console.WriteLine("Conta criada com sucesso !!\n");
                            Console.WriteLine(conta.ToString());
                            Console.Beep();
                            Thread.Sleep(3000);
                            Console.Clear();
                            break;
                        }
                    case 2:
                        Conta fconta = new Conta();
                        fconta.FecharConta(lista);
                        // código 2
                        break;
                    case 3:
                        Conta cconta = new Conta();
                        Console.WriteLine("Digite o Numero da conta para fazer a consulta : ");
                        int numer = Convert.ToInt32(Console.ReadLine());

                        cconta = cconta.ConsultaConta(lista, numer);
                        Boolean Exis;
                        Exis = Utils.VerificarNumero(numer, lista);
                        if (Exis)
                        {
                            Console.WriteLine(cconta.ToString());
                            Console.Beep();
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        break;
                    case 4:
                        Conta sconta = new Conta();
                        Console.WriteLine("Digite o Numero da conta para fazer o saque : ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        sconta = sconta.ConsultaConta(lista, num);
                        Boolean verify = Utils.VerificarNumero(num, lista);
                        if (verify)
                        {
                            
                            if (sconta.Saldo1 > 0)
                            {
                                sconta.Sacar(sconta);
                                lista.Remove(lista[sconta.Id1]);
                                lista.Add(sconta);
                            }
                            else
                            {
                                Console.WriteLine("Saldo insulficiente !!!");
                                Console.Beep();
                                Thread.Sleep(3000);
                            }
                        }
                        Console.Clear();
                        break;
                    case 5:
                        Conta dconta = new Conta();
                        Console.WriteLine("Digite o Numero da conta para fazer o depósito : ");
                        int nu = Convert.ToInt32(Console.ReadLine());
                        dconta = dconta.ConsultaConta(lista, nu);
                        Boolean verificar = Utils.VerificarNumero(nu, lista);
                        if (verificar)
                        {

                            if (dconta.Saldo1 > 0)
                            {
                                dconta.Depositar(dconta);
                                lista.Remove(lista[dconta.Id1]);
                                lista.Add(dconta);
                            }
                            else
                            {
                                
                            }
                        }
                        Console.Clear();
                        break;
                       
                        

                }
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
