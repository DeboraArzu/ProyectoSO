using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProyectoFinal
{
    class TheadPool
    {
        //test
        public static int productor, consumidor, cola = 0;

        MySqlConnection connection = null;
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();


        public List<absWorker> productores;
        public List<absWorker> consumidores;

        public static int maxSize;
        public static List<Comandos> comando;
        public static Semaphore semaforo;

        private static TheadPool _instance = null;

        private TheadPool(int intproductor, int intconsumidor, int tamanio)
        {
            comando = new List<Comandos>();
            semaforo = new Semaphore(intproductor + intconsumidor, intproductor + intconsumidor);

            this.productores = new List<absWorker>();
            this.consumidores = new List<absWorker>();

            Productor.producir = new Semaphore(intproductor, intproductor);
            Consumidor.consume = new Semaphore(intconsumidor, intconsumidor);

            maxSize = tamanio;

            try
            {
                builder.Server = "127.0.0.1";
                builder.UserID = "root";
                builder.Password = "summerparadise21";
                builder.Database = "so";
                connection = new MySqlConnection(builder.ToString());
                connection.Open();

            }
            catch (MySqlException ex)
            {
                bool f = false;
            }
        }

        public static TheadPool getInstance(int productor, int consumidor, int cola)
        {
            if (_instance == null)
                _instance = new TheadPool(productor, consumidor, consumidor);
            return _instance;
        }
        public static TheadPool getInstance()
        {
            if (_instance == null)
                _instance = new TheadPool(3, 5, 10);
            return _instance;
        }

        public void agregar(string origen, string destino, int cantidad)
        {
            absWorker producer = new Productor(productores.Count + consumidores.Count, cantidad, new Insertar(origen, destino));
            //absWorker consumer = new Productor(productores.Count + consumidores.Count, cantidad, new Insertar(origen, destino));
            productores.Add(producer);
           // consumidores.Add(consumer);
        }

        public void eliminar(string origen, string destino, int cantidad)
        {
            absWorker consumer = new Productor(productores.Count + consumidores.Count, cantidad, new Eliminar(origen, destino));
            productores.Add(consumer);
            productores.Remove(consumer);
        }
    }
}
