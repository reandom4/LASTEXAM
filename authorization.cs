using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSAGO
{
    public partial class authorization : Form
    {
        Connect connect = new Connect();
        public authorization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static string GetMD5Hash(string text)
        {
            using (var hashAlg = MD5.Create())
            {
                byte[] hash = hashAlg.ComputeHash(Encoding.UTF8.GetBytes(text));
                var builder = new StringBuilder(hash.Length * 2);
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("X2"));
                }
                return builder.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string LoginUser = LoginBox.Text;
            string PassUser = GetMD5Hash(LoginBox.Text);
            string connectionString = connect.constr();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = "select idUsers, name, surname, patronymic, login, password, privileges from users where login = '"+LoginUser+"' and password = '"+PassUser+"';";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command1 = new MySqlCommand(querystring, connection);
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(command1);
            DataTable table1 = new DataTable();
            dataAdapter1.Fill(table1);

            if (table1.Rows.Count != 1)
            {
                MessageBox.Show("Неверное имя пользователя или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (table1.Rows.Count == 1)
            {
                string qwe = table1.Rows[0].ItemArray.GetValue(6).ToString();
                string names = table1.Rows[0].ItemArray.GetValue(2).ToString() +" "+ table1.Rows[0].ItemArray.GetValue(1).ToString() +" "+ table1.Rows[0].ItemArray.GetValue(3).ToString() ;
                if (qwe == "admin")
                {
                    mainform mainform = new mainform(qwe, names);
                    this.Hide();
                    mainform.ShowDialog();
                    this.Close();
                }
                if (qwe == "user")
                {
                    mainform mainform = new mainform(qwe, names);
                    this.Hide();
                    mainform.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
