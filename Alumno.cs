using System;

namespace alumno
{
    public class alumno{
    string nombre;
    int edad;
    
    public alumno(){
        Console.WriteLine("Ingrese el nombre del Alumno: ");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la edad del Alumno: ");
        edad = int.Parse(Console.ReadLine());
    }
    public void Mostrar(){
        Console.WriteLine("El nombre del alumno es: {0}",nombre);
        Console.WriteLine("{0} tiene {1} años",nombre, edad);
    }
    public void MostrarEdad(){
        if(edad >=18){
        Console.WriteLine("El estudiante es mayor de edad");
        }
        else{
            Console.WriteLine("El estudiante es menor de edad");
        }
    }
}
    class Program
    {
        /*Crear una nueva solución de tipo Consola. Plantear una clase llamada Alumno y 
        definir como atributos su nombre y su edad. En el constructor realizar el ingreso de datos. Definir 
        otros dos métodos para imprimir los datos ingresados y un mensaje si es mayor o no de
         edad(edad>=18)*/
        static void Main(string[] args)
        {
            alumno a = new alumno();
            a.Mostrar();
            a.MostrarEdad();
        }
    }
}
