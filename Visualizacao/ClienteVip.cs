using System;
using System.Collections.Generic;
using System.Text;

namespace Visualizacao
{
    class ClienteVip : ClienteJuridico
    {
        private int token;

        public int Token { get => token; set => token = value; }
    }

}
