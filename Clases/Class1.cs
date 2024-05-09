namespace Clases
{
    public class Validador
    {
        public static bool Validar(int min, int max, string valor)
        {
            int dato = Int32.Parse(valor);                     
            if (dato <= max && dato >= min)
            {
             return true;
            }
            else
                return false;
        }
    }
    public class Calculadora
    {
        public static int Calcular(int operando1, int operando2, string operacion)
        {
            int resultado = 0;
            if (operacion == "+")
            {
                resultado = operando1 + operando2;
            }
            else if (operacion == "-")
            {
                resultado = operando1 - operando2;
            }
            else if (operacion == "*")
            {
                resultado = operando1 * operando2;
            }
            else if (operacion == "/")
            {
                resultado = operando1 / operando2;
                Validar(operando2);
            }
            return resultado;


        }        
        public static bool Validar(int operando)
        {
            return operando != 0;

        }

    }

    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double LongitudLado)
        {
            return LongitudLado*=LongitudLado;
        }
        public static double CalcularAreaTriangulo(double Base , double altura)
        {
            return (Base * altura) /2;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
   
}
