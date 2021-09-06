using System;
using System.Collections.Generic;
using System.Threading;

namespace ContaBancaria
{
    public class Conta
    {
        private int NumConta;
        private string Tipo;
        private string Dono;
        private decimal Saldo;
        private Boolean Status;
        private int Id;

        public int NumConta1 { get => NumConta; set => NumConta = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Dono1 { get => Dono; set => Dono = value; }
        public decimal Saldo1 { get => Saldo; set => Saldo = value; }
        public Boolean Status1 { get => Status; set => Status = value; }
        public int Id1 { get => Id; set => Id = value; }

        public void AbrirConta(int numero, string dono, string tipo)
        {
            this.Saldo1 = 0;
            this.Status1 = true;
            this.NumConta1 = numero;
            this.Dono1 = dono;
            this.Tipo1 = tipo;
            if (tipo == "CP")
            {
                Saldo = 150;
            }
            else
            {
                Saldo = 50;
            }

        }

        public Conta ConsultaConta(List<Conta> lista, int numero)
        {
            Conta conta = new Conta();

            for (int c = 0; c < lista.Count; c++)
            {
                if (numero != lista[c].NumConta1)
                {
                    
                }
                else
                {
                    conta.NumConta1 = lista[c].NumConta;
                    conta.Dono1 = lista[c].Dono;
                    conta.Saldo1 = lista[c].Saldo;
                    conta.Tipo1 = lista[c].Tipo;
                    conta.Id1 = c;
                    break;
                }
            }
            return conta;
        }



        public void FecharConta(List<Conta> lista)
        {
            
            Console.WriteLine("Digite o Numero da conta a ser excluida : ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Conta fconta = ConsultaConta(lista, numero);
            Boolean verify = Utils.VerificarNumero(numero, lista);
            if (verify)
            {
                if (fconta.Saldo > 0 || fconta.Saldo < 0)
                {
                    while (fconta.Saldo > 0 || fconta.Saldo < 0)
                    {
                        Console.WriteLine("Para prosseguir o fechamento da conta deve sacar todo o saldo da conta !!!");
                        Console.Beep();
                        Thread.Sleep(3000);
                        Sacar(fconta);
                    }
                    lista.Remove(lista[fconta.Id]);
                }
                else
                {
                    lista.Remove(lista[fconta.Id]);
                }
            }
        }

        public void Depositar(decimal deposito)
        {
            this.Saldo1 += deposito;
        }

        public Conta Sacar(Conta conta)
        {
            Console.WriteLine("Seu saldo é : " + conta.Saldo + "\n");
            Console.WriteLine("Qual o valor do saque? : ");
            decimal sacado = Convert.ToDecimal(Console.ReadLine());
            conta.Saldo1 -= sacado;
            return conta;
        }

        public Conta Depositar(Conta conta)
        {
            Console.WriteLine("Seu saldo é : " + conta.Saldo + "\n");
            Console.WriteLine("Qual o valor do deposito? : ");
            decimal Adepositar = Convert.ToDecimal(Console.ReadLine());
            conta.Saldo1 += Adepositar;
            return conta;
        }


        public override string ToString()
        {
            return "ID : " + this.Id + "\nNome : " +
                this.Dono + "\nNumero da Conta : " + this.NumConta + 
                "\nSaldo : " + this.Saldo + "\nTipo : " + this.Tipo;
        }

        public void PagarMensal()
        {
            this.Saldo1 -= 20;
        }

    }
}
