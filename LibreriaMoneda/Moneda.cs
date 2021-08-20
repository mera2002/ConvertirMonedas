using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMoneda
{
    public class Moneda
    {
    

    //delaracion de metodos 
    //listas 
    public static void ListCollection()


        {
            List<int> valores = new List<int>();


           int Dolares;
              int  pesos;
                int lempira;
                {
                    Console.Write("Escriba la cantidad en dolares a convertir: ");
                    Dolares = int.Parse(Console.ReadLine());
                    pesos = Dolares * 17;
                    Console.WriteLine("{0} Dolares equivale a {1} pesos", Dolares, pesos);
                    lempira = Dolares * 24;
                    Console.WriteLine("{0} equivale a {1} lempiras", Dolares, lempira);
                {
              

                Console.WriteLine("----------------Elementos de la lista---------------");
                for (int i = 0; i < valores.Count; i++)
                {
                    Console.WriteLine("Dolares", Dolares);
                        Console.WriteLine("Dolares", pesos);
                        Console.WriteLine("Dolares", lempira);









                    }
                }
            }
        }
    }
}





