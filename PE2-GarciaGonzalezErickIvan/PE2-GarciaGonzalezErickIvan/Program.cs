using System;

namespace PE2GarciaGonzalezErickIvan
{
    public class Recursivo
    {


        public int p1(int[] suce, int indiceInf, int indiceSup)
		{
			if (indiceInf == indiceSup)
				return suce[indiceSup];
			if (suce[indiceInf] > suce[indiceSup])
				return p1(suce, indiceInf + 1, indiceSup);
			else return p1(suce, indiceInf, indiceSup - 1);


		}
        public int  p2(int[] suce, int indiceInf, int indiceSup)
        {
			if (indiceInf == indiceSup)
				return suce[indiceSup];
			if (suce[indiceInf] < suce[indiceSup])
				return p2(suce, indiceInf + 1, indiceSup);
			else return p2(suce, indiceInf, indiceSup - 1);   
        }

        public int p3(int [] suce, int indiceSup)
        {
            if (indiceSup >= 0)
            {
                Console.WriteLine(suce[indiceSup]);
                return (p3(suce, indiceSup - 1));

            }
            else
                return 1;

        }

       
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Inserta el tamaño de la sucesion: ");
			int tam = int.Parse(Console.ReadLine());
			int[] suce = new int[tam];

			for (int i= 0; i < suce.Length; i++)
			{
				Console.Write("Inserta los valores de la sucecion: ");
				suce[i] = int.Parse(Console.ReadLine());

			}
         
			Console.WriteLine("\n\t1.- Encontrar el elemento menor de la sucesion ");
            Console.WriteLine("\n\t2.- Encontrar el elemento mayor en una sucesion ");
            Console.WriteLine("\n\t3.- Invertir la sucesion introducida"); 
            int opc = int.Parse(Console.ReadLine());

            Recursivo obj = new Recursivo();

            int indiceInf = 0;
            int indiceSup = tam - 1;


            switch(opc)
            {
                case 1:
                    Console.Write("El valor menor de la sucesion introducida es: " + obj.p1(suce, indiceInf, indiceSup));
                    break;

                case 2:
					Console.Write("El valor mayor de la sucesion introducida es: " + obj.p2(suce, indiceInf, indiceSup));
                    break;

                case 3:
                    Console.WriteLine("El orden invertido de la sucesion es: " + obj.p3(suce,indiceSup));
                    break;

                default:
                    Console.WriteLine("Opcion Invalida");
                    break;
            }
			Console.ReadKey();
           
        }
    }
}
