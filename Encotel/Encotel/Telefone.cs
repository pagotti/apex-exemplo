using System;
using System.Collections.Generic;
using System.Text;

namespace Encotel
{
    class Telefone
    {
        private string[] mapa;

        public Telefone()
        {
            this.mapa = new string[10];
            this.mapa[0] = "0";
            this.mapa[1] = "1";
            this.mapa[2] = "ABC";
            this.mapa[3] = "DEF";
            this.mapa[4] = "GHI";
            this.mapa[5] = "JKL";
            this.mapa[6] = "MNO";
            this.mapa[7] = "PQRS";
            this.mapa[8] = "TUV";
            this.mapa[9] = "WXYZ";

        }

        /// <summary>
        /// Busca o número que corresponde ao caractere informado usando o array do mapa
        /// </summary>
        /// <param name="caractere">número 0, 1, hífen ou letra de A a Z</param>
        /// <returns></returns>
        private char TraduzirCaractere(char caractere)
        {
            if (caractere == '-')
            {
                return caractere;
            }

            for (int i = 0; i < this.mapa.Length; i++)
            {
                if (this.mapa[i].Contains(caractere))
                {
                    return Convert.ToString(i)[0];
                }
            }

            throw new ArgumentException("Caractere inválido", "caractere");
        }

        public string Traduzir(string letras)
        {
            string resultado = "";

            // usa o ToUpper para o caso do usuário fornecer
            // o telefone com letras minúsculas
            foreach(char caractere in letras.ToUpper())
            {
                resultado += TraduzirCaractere(caractere);
            }

            return resultado;
        }
    }
}
