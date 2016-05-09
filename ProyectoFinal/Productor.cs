using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProyectoFinal
{
    class Productor : absWorker
    {
        public static Semaphore producir;
        public static int size = 0;
        public Productor(int id, int total, Command cmd) : base(id, total, cmd)
        {
        }

        public override void work()
        {
            while (used < total)
            {
                working = false;
                while (TheadPool.comando.Count != 0 && TheadPool.getInstance().consumidores.Count != 0) ;
                while (used < total && size < TheadPool.maxSize)
                {
                    TheadPool.semaforo.WaitOne();
                    producir.WaitOne();
                    working = true;
                    TheadPool.comando.Add(cmd);
                    Thread.Sleep(100);
                    producir.Release();
                    TheadPool.semaforo.Release();

                    used++;
                    size++;
                }
                int aux = TheadPool.comando.Count;
                for (int i = 0; i < aux; i++)
                {
                    absWorker consumer = new Consumidor(TheadPool.getInstance().consumidores.Count + TheadPool.getInstance().productores.Count);
                    TheadPool.getInstance().consumidores.Add(consumer);
                }
            }
            TheadPool.getInstance().productores.Remove(this);
        }
    }
}
