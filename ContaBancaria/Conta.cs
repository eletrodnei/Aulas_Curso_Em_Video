using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Conta
    {
        private int NumConta;
        private string Tipo;
        private string Dono;
        private decimal Saldo;
        private Boolean Status;

        public int NumConta1 { get => NumConta; set => NumConta = value; }
        protected string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Dono1 { get => Dono; set => Dono = value; }
        public decimal Saldo1 { get => Saldo; set => Saldo = value; }
        public Boolean Status1 { get => Status; set => Status = value; }

        

        public void AbrirConta(string dono,string tipo,List<Conta> lista)
        {
            this.Saldo1 = 0;
            this.Status1 = true;
            this.Tipo1 = tipo;
            this.Dono1 = dono;
            


            Random number = new Random();
            int Numero = number.Next(5)+1;
            Boolean Existe = true;
            Conta nova = new Conta();
            lista.Add(nova);
            for (int c = 0; c < lista.Count; c++)
            {
                if (Numero != lista[c].NumConta1)
                {
                    Existe = false;
                }
                else
                {
                    Existe = true;
                    break;
                }
            }
            if (!Existe)
            {
                if (tipo == "CP")
                {
                    Saldo = 20;
                }
                else
                {
                    Saldo = 10;
                }
                nova.NumConta = Numero;
                nova.Dono = this.Dono;
                nova.Tipo = this.Tipo;
                nova.Saldo = this.Saldo;
                nova.Status = this.Status;
            }
            else
            {
                Console.WriteLine("Essa conta já existe !!");
                lista.Remove(nova);
                Console.Beep(); Console.Beep(); Console.Beep();
            }
        }
        

        public void FecharConta()
        {
            this.NumConta1 = 123232;
            if (this.Saldo != 0)
            {

            }
        }
        public void Depositar(decimal deposito)
        {
            this.Saldo1 += deposito;
        }
        public void Sacar(decimal saque)
        {
            this.Saldo1 -= saque;
        }
        public void PagarMensal()
        {
            this.Saldo1 -= 20;
        }
    }
}
