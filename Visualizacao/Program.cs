using Caelum.Stella.CSharp.Validation;
using System;


namespace Visualizacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf1 = "86288366757";
            string cpf2 = "98745366797";
            string cpf3 = "22222222222";

            ClienteVip teste1 = new ClienteVip();
            



            Cliente teste = new Cliente(); 
            teste.ValidarCpf(cpf1);
            teste.Cnpj1 = "12312333";
            teste.Cpf1 = cpf1;
            teste.Token = 213;
            teste.Nascimento1=new DateTime(2021, 08, 26);
            teste.Nome1 ="Rodnei";

            teste.Status();

        }
        
    }
}
