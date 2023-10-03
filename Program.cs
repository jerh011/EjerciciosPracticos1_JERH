// See https://aka.ms/new-console-template for more information
using EjerciciosPracticos1_JERH;
Impreciones impre = new Impreciones();

/*
int[] numeros = new int[5];
for (int X=0;X<numeros.Length;X++) {
    Console.WriteLine($"Ingrese el Numero {X+1}");
    numeros[X]=Convert.ToInt32(Console.ReadLine());
}
impre.ImPreciones(numeros);
*/
Console.WriteLine("================================");
Console.WriteLine("INGRESE EL TAMAÑO DEL AREGLO");
int tamaño= Convert.ToInt32(Console.ReadLine());
int[] numeros2 = new int[tamaño];

Console.WriteLine("ingrese el multiplo");
int multiplo = Convert.ToInt32(Console.ReadLine());

impre.Multiplos(numeros2, multiplo);