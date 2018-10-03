using System;

namespace PostPruebasUnitarias
{
    public static class ProcesadorMatematico
    {
        public static double Sumar(double primerNumero, double segundoNumero)
        {
            return primerNumero + segundoNumero;
        }
        public static double Resta(double primerNumero, double segundoNumero)
        {
            return primerNumero - segundoNumero;
        }
        public static double Multiplicacion(double primerNumero, double segundoNumero)
        {
            return primerNumero * segundoNumero;
        }
        public static double Division(double dividendo, double divisor)
        {
            return dividendo / divisor;
        }
        public static double Potencia(double numeroBase, double exponente)
        {
            return Math.Pow(numeroBase, exponente);
        }
        public static double Raiz(double numeroBase, double exponente)
        {
            return Math.Pow(numeroBase, 1 / exponente);
        }
    }
}
