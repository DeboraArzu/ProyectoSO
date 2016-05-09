using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProyectoFinal
{
    interface Worker
    {
        void work();
    }

    public abstract class absWorker : Worker
    {
        protected int id;
        protected bool working;
        protected Thread thread;
        protected Command cmd;
        public int total, used;

        public absWorker(int id, int total, Command comando)
        {
            this.id = id;
            this.cmd = comando;
            this.total = total;
            this.used = 0;
            this.thread = new Thread(this.work);
            this.thread.Name = "Thread " + this.id;
            this.thread.Start();
        }

        public int getId()
        {
            return id;
        }

        public bool getWorking()
        {
            return working;
        }

        public string getStatus()
        {
            return thread.ThreadState.ToString();
        }

        public abstract void work();

        public void remove()
        {
            this.thread.Abort();
        }
    }
}
