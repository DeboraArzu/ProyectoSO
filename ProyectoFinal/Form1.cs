using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        TheadPool pool;
        ConexionSQL c = new ConexionSQL();
        int tamaño, cantidad, consumidor, productor = 0;
        string origen, destino = "";

        private void bteliminar_Click(object sender, EventArgs e)
        {
            //c.delete(consumidor);
            pool.removeRegister(origen, destino, cantidad);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            showPCWorker(dgvProductor, pool.productores);
            showPCWorker(dgvConsumidor, pool.consumidores);
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            //c.insert(origen, destino);
            pool.addRegister(origen, destino, cantidad);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btiniciar_Click(object sender, EventArgs e)
        {
            btagregar.Enabled = true;
            bteliminar.Enabled = true;

            tamaño = Convert.ToInt32(intcola.Text);
            cantidad = Convert.ToInt32(intprocesos.Text);
            consumidor = Convert.ToInt32(intconsumidor.Text);
            productor = Convert.ToInt32(intproductor.Text);

            origen = txtorigen.Text;
            destino = txtdestino.Text;

            pool = TheadPool.getInstance(productor, consumidor, tamaño);
            timer1.Start();
        }

        private void showPCWorker(DataGridView dgv, List<absWorker> list)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                var v = list[i];
                dgv.Rows.Add(v.getId(), v.getWorking(), v.getStatus(), v.used + " de " + v.total);
            }
        }
    }
}
