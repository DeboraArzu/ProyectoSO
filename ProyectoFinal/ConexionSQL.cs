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
using System.Threading;


namespace ProyectoFinal
{
    class ConexionSQL
    {

        MySqlConnection connection = null;

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        public bool SetConnection()
        {
            builder.Server = "127.0.0.1";
            builder.UserID = "root";
            builder.Password = "summerparadise21";
            builder.Database = "so";
            try
            {
                connection = new MySqlConnection(builder.ToString());
                MySqlCommand cmd = connection.CreateCommand();
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        public bool insert(string origen, string destino)
        {
            try
            {
                if (SetConnection())
                {
                    MySqlConnection conn = new MySqlConnection(builder.ToString());
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO listatrans (id,origen,destino) values (0,'" + origen + "', '" + destino + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("EXITO EN LA CONEXION");
                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                return false;
            }

        }

        public bool delete(string origen, string destino)
        {
            try
            {
                if (SetConnection())
                {
                    MySqlConnection conn = new MySqlConnection(builder.ToString());
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM listatrans where origen =" + origen + "and destino = " + destino;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("EXITO EN LA CONEXION");
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                return false;
            }
        }

    }

    public interface Comandos
    {
        void execute();
    }

    public abstract class absComando : Comandos
    {
        int id;
        public string origen, destino;

        public absComando(string from, string to)
        {
            this.origen = from;
            this.destino = to;
        }

        public abstract void execute();
    }

    public class Insertar : absComando
    {
        MySqlConnection connection = null;
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        public bool SetConnection()
        {
            builder.Server = "127.0.0.1";
            builder.UserID = "root";
            builder.Password = "summerparadise21";
            builder.Database = "so";
            try
            {
                connection = new MySqlConnection(builder.ToString());
                MySqlCommand cmd = connection.CreateCommand();
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
        public Insertar(string origen, string destino) : base(origen, destino)
        {

            try
            {
                if (SetConnection())
                {
                    MySqlConnection conn = new MySqlConnection(builder.ToString());
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO listatrans (id,origen,destino) values (0,'" + origen + "', '" + destino + "')";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("EXITO EN LA CONEXION");
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                connection.Close();
            }
        }
        public override void execute()
        {
        }
    }

    public class Eliminar : absComando
    {
        MySqlConnection connection = null;
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        public bool SetConnection()
        {
            builder.Server = "127.0.0.1";
            builder.UserID = "root";
            builder.Password = "summerparadise21";
            builder.Database = "so";
            try
            {
                connection = new MySqlConnection(builder.ToString());
                MySqlCommand cmd = connection.CreateCommand();
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
        public Eliminar(string origen, string destino) : base(origen, destino)
        {
            try
            {
                if (SetConnection())
                {
                    MySqlConnection conn = new MySqlConnection(builder.ToString());
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM listatrans where origen =" + base.origen + "and destino = " + base.destino;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("EXITO EN LA CONEXION");
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                connection.Close();
            }
        }
        public override void execute()
        {
        }
    }
}
