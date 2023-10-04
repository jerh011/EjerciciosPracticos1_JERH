using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos1_JERH
{
    internal class Impreciones
    {

        public void ImPreciones(int[]numeros ) {
            for(int X=0;X<5;X++ )
            Console.WriteLine(numeros[X]);
        }
        public void Multiplos(int[] numeros,int multiplo)
       {
        
            int[] num=new int[numeros.Length+1];
            num=numeros;
           int  multiplo2 = multiplo;
            for (int X = 1; X < numeros.Length+1; X++)
                num[X] = (multiplo2*(X));
            ImprecionMultiplicacion(num);

        }
        public void ImprecionMultiplicacion(int[] numeros)
        {
            for (int X = 0; X < numeros.Length; X++)
                Console.WriteLine(numeros[X]);
            
        }



    }


}
