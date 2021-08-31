using Caelum.Stella.CSharp.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Visualizacao
{
    class Cliente : ClienteVip 
    {
        
        private string Nome;
        private string Cpf;
        private DateTime Nascimento;

        public string Nome1 { get => Nome; set => Nome = value; }
        public string Cpf1 { get => Cpf; set => Cpf = value; }
        public DateTime Nascimento1 { get => Nascimento; set => Nascimento = value; }

        
        public string ValidarCpf(string cpf)
        {
            new CPFValidator().AssertValid(cpf);
            return cpf;
        }

        public void Status()
        {
            Console.WriteLine("O Cliente " + this.Nome);
            Console.WriteLine("tem CPF " + this.Cpf);
            Console.WriteLine("Token " + this.Token);
            Console.WriteLine("Data de aniversário " + this.Nascimento);
            Console.WriteLine("CNPJ " + this.Cnpj1);
        }
    }
}

