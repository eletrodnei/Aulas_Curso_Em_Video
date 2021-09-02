using System;
using System.Collections.Generic;
using System.Threading;

namespace ContaBancaria
{

    class Program
    {
        static List<Conta> lista = new List<Conta>();


        public static void Main(string[] args)
        {
            Utils.Menu(lista);

            

        }
        
    }
}
