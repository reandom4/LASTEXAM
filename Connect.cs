using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSAGO
{
    internal class Connect
    {
        public string connectionString = "host='localhost';database='osago';uid='root';pwd='';charset=utf8;";

        public string constr()
        {
            return connectionString;
        }
        public DataTable LoadData(string str)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query1 = "SELECT * FROM " + str + ";";
                MySqlCommand command1 = new MySqlCommand(query1, connection);
                MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(command1);
                DataTable table1 = new DataTable();
                dataAdapter1.Fill(table1);
                connection.Close();
                return table1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable LoadDate(string str)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query1 = str;    
                MySqlCommand command1 = new MySqlCommand(query1, connection);
                MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(command1);
                DataTable table1 = new DataTable();
                dataAdapter1.Fill(table1);
                connection.Close();
                return table1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void AddData(string strcmd)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(strcmd, con);
                int res = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void DelData1(string strCmd)
        {
            using (MySqlConnection con = new MySqlConnection())
            {
                try
                {
                    con.ConnectionString = connectionString;
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(strCmd, con);
                    DialogResult dr = MessageBox.Show("Удалить запись ?", "Внимание!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        int res = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        public void ChangeData(string strCmd)
        {
            using (MySqlConnection con = new MySqlConnection())
            {
                try
                {
                    con.ConnectionString = connectionString;
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(strCmd, con);
                    int res = cmd.ExecuteNonQuery();
                    MessageBox.Show("Отредактированно " + res.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
