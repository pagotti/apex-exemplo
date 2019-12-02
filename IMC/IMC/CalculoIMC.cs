using System;

namespace IMC
{
    internal class CalculoIMC
    {
        internal static decimal ValorIMC(decimal peso, decimal altura)
        {
            return peso / (altura * altura);
        }
    }
}