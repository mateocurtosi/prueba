namespace Clases1
{
    public class Validador
    {
       public static bool Validar (int valor, int min, int max)
        {
            //min = int.MaxValue;
            //max = int.MinValue;
            if (valor <= max && valor >= min)


                return true;
            else
                return false;
        }
 
    }
}
