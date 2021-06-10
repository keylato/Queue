using System;
using System.Collections.Generic;

namespace P7Queue
{
    class Queue 
    {
        Queue<cliente> fila = new Queue<cliente>();

        public int despachados= 3;

        public void FormarCliente(string nombre,string producto)
        {
            this.fila.Enqueue(new cliente(nombre, producto));
        }

        public void AtenderCliente()
        {
            fila.Dequeue();
            despachados = despachados +1;
            Console.WriteLine(despachados);
        }

        internal void Enqueue(cliente cliente1)
        {
            throw new NotImplementedException();
        }

        public void MostrarProducto()
            {
                foreach(cliente producto in fila)
                {
                    Console.WriteLine("El cliente lleva" + producto.nombre);
                }
                
            }
        public void SiguienteCliente()
        {
            if (this.fila.Count == 0)
            {
                Console.WriteLine("Todos clientes fueron despachados");
                

            }
            else 
            {
               Console.WriteLine ("Faltan" + fila.Count + "de despachar");
            }
    
        }
        public void ContarDespachados()
        {
            Console.WriteLine(despachados);
        }



    }
}
