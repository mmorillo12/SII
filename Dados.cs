using System;

namespace dados
{
    public class dados{
        int lados;

    public void Mlados(){
        Random azar = new Random();
        int num = azar.Next(1,7);
        Console.WriteLine("El primer valor es {0}",num);

        Random azar1 = new Random();
        int num1 = azar1.Next(1,7);
        Console.WriteLine("EL sengundo valor es {0}", num1);

        Random azar2 = new Random();
        int num2 = azar2.Next(1,7);
        Console.WriteLine("El tercer valor es {0}",num2);

        if((num == num1)&&(num1 == num2)){
            Console.WriteLine("Haz Ganado");
        }
        else{
         Console.WriteLine("Haz perdido");
        }
    }
    }
    class Program
    {
        /*Crear una nueva solución de tipo Consola que permita jugar a los dados.
        Las reglas de juego son: se tiran tres(3) dados silostres salen con el 
        mismo valor mostrar un mensaje que "gano", sino "perdió".*/

        static void Main(string[] args)
        {
            dados d = new dados();
            d.Mlados();
        }
    }
}
