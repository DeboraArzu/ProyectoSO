using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProyectoFinal
{
    class Consumidor : absWorker
    {
        public static Semaphore consume;

        public Consumidor(int id) : base(id, 0, null)
        {

        }
        public override void work()
        {
            working = false;

            TheadPool.semaforo.WaitOne();
            consume.WaitOne();
            working = true;
            command = TheadPool.comando.FirstOrDefault();
            TheadPool.comando.Remove(command);
            Thread.Sleep(1000);
            working = false;
            consume.Release();
            TheadPool.semaforo.Release();
            used++;
            if (command != null)
            {
                Productor.size--;
                if (command != null) command.execute();
                TheadPool.getInstance().consumidores.Clear();
            }
        }
    }
}
