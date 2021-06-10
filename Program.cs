using System;
using System.Collections.Generic;

namespace P7Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue fila = new Queue();
            
            cliente cliente1 = new cliente("Sonia", "Leche");
            cliente cliente2 = new cliente ("Arnoldo" , "Cerveza");
            cliente cliente3 = new cliente ("Sebastian" , "Papitas");

            fila.Enqueue(cliente1);
            fila.Enqueue(cliente2);
            fila.Enqueue(cliente3);

            string opcion = " ";
            while (opcion != "6")
            {
                Console.WriteLine("Escoja una opcion del menu, por favor");
                Console.WriteLine("1) Formar un cliente");
                Console.WriteLine("2) Atender un cliente");
                Console.WriteLine("3) Mostar producto de un cliente");
                Console.WriteLine("4) siguiente cliente por despachar");
                Console.WriteLine("5) numero cliente he despachado ya");
                Console.WriteLine("6) salir");
                opcion = Console.ReadLine();

                if (opcion != "1" && opcion != "2" && opcion != "6")
                {
                    Console.WriteLine("La opcion seleccionada no es correcta");

                }

            }
            if (opcion == "1")
            {
                Console.WriteLine("Nombre del cleinte en la fila");
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Siguiente cliente");
                string nombre = Console.ReadLine();
                Console.WriteLine (nombre);
            }
            else if (opcion == "3")
            {
                Console.WriteLine("El cliente lleva");
                fila.MostrarProducto();
            }
            else if (opcion =="4")
            {
                fila.SiguienteCliente();    
            }
            else if (opcion == "5")
            {
                fila.ContarDespachados();
            }
            else if (opcion =="6")
            {
                Console.WriteLine("Gracias por tu participacion");
            }
            else
            {
                
            }
        }
       
    }
}       
    

    