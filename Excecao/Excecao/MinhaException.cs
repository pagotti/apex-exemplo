using System;
using System.Collections.Generic;
using System.Text;

namespace Excecao
{
    class MinhaException: Exception
    {
        public MinhaException() : base() { }
        public MinhaException(string mensagem) : base(mensagem) { }

    }
}
