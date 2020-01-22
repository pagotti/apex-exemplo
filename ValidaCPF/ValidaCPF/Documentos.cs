using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaCPF
{
    class Documentos
    {
        public static bool CPFValido(string cpf)
        {
            // 1. é um numero de 11 dígitos
            // 2. os nove primeiros são o número e os 2 ultimos o digitos de verificação
            // 3. o primeiro digito é calculado com módulo 10 
            // 4. o segundo digito é calculado com módulo 11

            if (cpf.Length != 11)
            {
                return false;
            }

            string numero = cpf.Substring(0, 9);
            string digitos = cpf.Substring(9, 2);

            int resultado = 0;
            for(int i = 10; i >= 2; i--)
            {
                resultado += int.Parse(Convert.ToString(numero[(10 - i)])) * i;
            }

            int digito = (resultado * 10) % 11;
            if (digito == 10)
            {
                digito = 0;
            }

            if (int.Parse(Convert.ToString(digitos[0])) != digito)
            {
                return false;
            }

            numero = cpf.Substring(0, 10);
            resultado = 0;
            for (int i = 11; i >= 2; i--)
            {
                resultado += int.Parse(Convert.ToString(numero[(11 - i)])) * i;
            }
            
            digito = (resultado * 10) % 11;
            if (digito == 10)
            {
                digito = 0;
            }

            if (int.Parse(Convert.ToString(digitos[1])) != digito)
            {
                return false;
            }

            return true;

        }
    }
}
