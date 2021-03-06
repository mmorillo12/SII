using System;

namespace racional
{
    public class Racional{     
        private double variables1, variables2; 
        double suma, resta, opuesto,opuesto2, inverso1, inverso2;       
        
        public Racional(double v1, double v2){
            variables1 = v1;
            variables2 = v2;
            suma = v1 + v2;
            resta = v1 - v2;
            opuesto = -(v1);
            opuesto2 = -(v2);
            inverso1 = variables1 + (-variables1);
            inverso2 = variables2 + (-variables2);
        }
        public void MostrarEstado(){
            Console.WriteLine("La suma total de los numeros {0} y {1} es de: {2}",variables1, variables2, suma);
            Console.WriteLine("La resta total de los numeros {0} y {1} es de: {2}", variables1, variables2,resta);
            Console.WriteLine("El opuesto del numero {0} es: {1} y el oputesto de {2} es {3}",variables1, opuesto,variables2,opuesto2);
            Console.WriteLine("El inverso aditivo de {0} es de {1}", variables1, inverso1);
            Console.WriteLine("El inverso aditivo de {0} es de {1}", variables2, inverso2);
            Console.WriteLine("Los valores tomados fueron {0} y {1}", variables1, variables2);
        }
        }
    class Program
    {
        static void Main(string[] args)
        /*Elaborar una clase RACIONAL que modele los números racionales implementando
        al menos las operaciones de suma, resta, opuesto e inverso de un número 
        racional a imitación de la suma o resta de los números reales o enteros.*/
        {
            Racional r = new Racional(200,100);
            r.MostrarEstado();
        }
    }
}
