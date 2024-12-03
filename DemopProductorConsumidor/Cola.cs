using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemopProductorConsumidor
{
    public class Cola
    {
        public class Cola<T>
        {
            private int capacidadMaxima;
            private Queue<T> cola = new Queue<T>();
            private object lockojeto = new object();

            public Cola(int capacidad)

            {
                capacidadMaxima = capacidad;

            }
            public void Agregar(T item)
            {
                lock (lockojeto)
                {
                    while (cola.Count >= capacidadMaxima)
                    {
                        Monitor.Wait(lockojeto);
                    }
                    cola.Enqueue(item);
                    Monitor.Pulse(lockojeto);
                }
            }
            public T Extraer()
            {
                lock (lockojeto)
                {
                    while (cola.Count == 0)
                    {
                        Monitor.Wait(lockojeto);
                    }
                    T Item = cola.Dequeue();
                    Monitor.Pulse(lockojeto);
                    return Item;
                }
            }
        }
    }
}
