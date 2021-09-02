using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    public class Conta
    {
        private int NumConta;
        private string Tipo;
        private string Dono;
        private decimal Saldo;
        private Boolean Status;

        public int NumConta1 { get => NumConta; set => NumConta = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Dono1 { get => Dono; set => Dono = value; }
        public decimal Saldo1 { get => Saldo; set => Saldo = value; }
        public Boolean Status1 { get => Status; set => Status = value; }

        

        public void AbrirConta(int numero,string dono,string tipo)
        {
            this.Saldo1 = 0;
            this.Status1 = true;
            this.NumConta1 = numero;
            this.Dono1 = dono;
            this.Tipo1 = tipo;
            
            
            
            //random number = new random();
            //int numero = number.next(5) + 1;
            //boolean existe = true;
            //conta nova = new conta();
            //lista.add(nova);
            //for (int c = 0; c < lista.count; c++)
            //{
            //    if (numero != lista[c].numconta1)
            //    {
            //        existe = false;
            //    }
            //    else
            //    {
            //        existe = true;
            //        break;
            //    }
            //}
            //int numero=Utils.GerarNumero();
            //Boolean Existe = Utils.VerificarNumero(numero, lista);


            if (tipo == "CP")
                {
                    Saldo = 20;
                }
                else
                {
                    Saldo = 10;
                }
                
                //lista[0].NumConta = numero;
                //lista[0].Dono = this.Dono;
                //lista[0].Tipo = this.Tipo;
                //lista[0].Saldo = this.Saldo;
                //lista[0].Status = this.Status;
                //nova.NumConta = Numero;
                //nova.Dono = this.Dono;
                //nova.Tipo = this.Tipo;
                //nova.Saldo = this.Saldo;
                //nova.Status = this.Status;
            //}
            //else
            //{
            //    Console.WriteLine("Essa conta já existe !!");
            //    //lista.Remove(nova);
            //    Console.Beep(); Console.Beep(); Console.Beep();
            //}
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
