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
        // public MySqlConnection sqlcon;
        //string myConnectionString = "server=127.0.0.1;uid=root;" + "pwd=summerparadise21;database=so;";

        MySqlConnection connection = null;
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();


        public List<absWorker> productores;
        public List<absWorker> consumidores;

        public static int maxSize;
        public static List<Comandos> comando;
        public static Semaphore semaforo;

        private static TheadPool _instance = null;

        private TheadPool(int producerParam, int consumerParam, int commandsSize)
        {
            comando = new List<Comandos>();
            semaforo = new Semaphore(producerParam + consumerParam, producerParam + consumerParam);

            this.productores = new List<absWorker>();
            this.consumidores = new List<absWorker>();

            Productor.producir = new Semaphore(producerParam, producerParam);
            Consumidor.consume = new Semaphore(consumerParam, consumerParam);

            maxSize = commandsSize;

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

        public void addRegister(string origen, string destino, int cantidad)
        {
            //SQL INSERT
            ConexionSQL c = new ConexionSQL();
            absWorker producer = new Productor(productores.Count + consumidores.Count, cantidad, new Insertar(origen, destino));
            c.insert(origen, destino);
            productores.Add(producer);
        }

        public void removeRegister(string origen, string destino, int cantidad)
        {
            //SQL DELETE
            absWorker consumer = new Productor(productores.Count + consumidores.Count, cantidad, new Eliminar(origen, destino));
            productores.Add(consumer);
        }
    }
}
