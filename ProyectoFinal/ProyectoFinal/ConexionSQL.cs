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

    public interface Command
    {
        void execute();
    }

    public abstract class DBCommand : Command
    {
        int id;
        public string from, to;

        public DBCommand(string from, string to)
        {
            this.from = from;
            this.to = to;
        }

        public abstract void execute();
    }

    public class InsertionCommand : DBCommand
    {
         MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        public InsertionCommand(string from, string to) : base(from, to)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(builder.ToString());
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO listatrans (id,origen,destino) values (0,'" + from + "', '" + to + "')";
                conn.Open();
                cmd.ExecuteNonQuery();


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
            
            }
        }

        public override void execute()
        {
          
        }
    }

    public class DeleteCommand : DBCommand
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        public DeleteCommand(string from, string to) : base(from, to)
        {
            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM lista_transaccion WHERE Origen = '" + from + "' AND Destino = '" + to + "' LIMIT 1";
            conn.Open();
            cmd.ExecuteNonQuery();

        }

        public override void execute()
        {

        }
    }
}
