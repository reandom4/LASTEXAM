using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace OSAGO
{
    public partial class users : Form
    {
        Connect connect = new Connect();
        public string connectionString = "host='localhost';database='mydb';uid='root';pwd='qwerty';charset=utf8;";

        public users()
        {
            InitializeComponent();
            dataGridView1.DataSource = connect.LoadData("users");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "логин";
            dataGridView1.Columns[2].HeaderText = "Пароль";
            dataGridView1.Columns[3].HeaderText = "Привилегия";
            dataGridView1.Columns[4].HeaderText = "Имя";
            dataGridView1.Columns[5].HeaderText = "Фамилия";
            dataGridView1.Columns[6].HeaderText = "Отчество";
        }

        private void ClearBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            Passwd.Text = "";
            textBox6.Text = "";

        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            string n1;
            string n2;
            string n3;
            string n4;
            string n5;
            string n6;
            try
            {
                n1 = textBox1.Text;
                n2 = textBox2.Text;
                n3 = textBox3.Text;
                n4 = comboBox1.Text;
                n5 = Passwd.Text;
                n6 = textBox6.Text;
                if (n1.Length < 1 || n2.Length < 1 || n3.Length < 1 || n4.Length < 1 || n5.Length < 1 || n6.Length < 1)
                {
                    MessageBox.Show("Некорректные входные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string strcmd = "INSERT INTO users (login, password, privileges, name, surname, patronymic) VALUES('" + n6 + "','" + n5 + "','" + n4 + "','" + n1 + "','" + n2 + "','" + n3 + "')";
                connect.AddData(strcmd);
                dataGridView1.DataSource = connect.LoadData("users");
                ClearBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            int rowIndex;
            string primaryKey;
            string strCmd = "";
            rowIndex = dataGridView1.CurrentCell.RowIndex;
            primaryKey = dataGridView1.Rows[rowIndex].Cells["idUsers"].Value.ToString();
            strCmd = "DELETE FROM users WHERE idUsers ='" + primaryKey + "';";
            connect.DelData1(strCmd);
            dataGridView1.DataSource = connect.LoadData("users");
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            int rowIndex;
            string primaryKey;
            string strCmd;
            string n1;
            string n2;
            string n3;
            string n4;
            string n5;
            string n6;
            try
            {
                n1 = textBox1.Text;
                n2 = textBox2.Text;
                n3 = textBox3.Text;
                n4 = comboBox1.Text;
                n5 = Passwd.Text;
                n6 = textBox6.Text;

                if (n1.Length < 1 || n2.Length < 1 || n3.Length < 1 || n4.Length < 1 || n5.Length < 1 || n6.Length < 1)
                {
                    MessageBox.Show("Некорректные входные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rowIndex = dataGridView1.CurrentCell.RowIndex;
                primaryKey = dataGridView1.Rows[rowIndex].Cells["idUsers"].Value.ToString();
                strCmd = @"UPDATE users SET name='" + n1 + "', surname ='" + n2 + "', patronymic='" + n3 + "', privileges ='" + n4 + "', password ='" + n5 + "', login ='" + n6 + "' WHERE idUsers ='" + primaryKey + "';";
                connect.ChangeData(strCmd);
                dataGridView1.DataSource = connect.LoadData("users");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string iPass = "";
            string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y" };
            try
            {
                Random rnd = new Random();
                for (int i = 0; i < 15; i++)
                {
                    iPass = iPass + arr[rnd.Next(0, 57)];
                }
                Passwd.Text = iPass;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearBox();
                return;
            }
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
            string name;
            string surname;
            string patr;
            string login;
            string passwd;
            string hashpasswd;
            string status;
            string strcmd;
            try
            {
                name = textBox1.Text;
                surname = textBox2.Text;
                patr = textBox3.Text;

                login = textBox6.Text;
                passwd = Passwd.Text;
                status = comboBox1.Text;

                hashpasswd = GetMD5Hash(passwd);

                strcmd = @"INSERT INTO users (login, password, privileges, name, surname, patronymic) VALUES('" + login + "','" + hashpasswd + "','" + status + "','" + name + "','"+surname+"','"+patr+"')";
                if (name.Length < 2 || login.Length < 2 || status.Length < 2)
                {
                    MessageBox.Show("Некорректные входные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (passwd.Length < 5)
                {
                    MessageBox.Show("Слишком простой пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(strcmd, con);
                int res = cmd.ExecuteNonQuery();
                con.Close();
                connect.LoadData("users");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex;
            string primaryKey;
            string strCmd = "";
            rowIndex = dataGridView1.CurrentCell.RowIndex;
            primaryKey = dataGridView1.Rows[rowIndex].Cells["idUsers"].Value.ToString();
            strCmd = "DELETE FROM car WHERE idUsers ='" + primaryKey + "';";
            connect.DelData1(strCmd);
            dataGridView1.DataSource = connect.LoadData("users");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex;
            string primaryKey;
            string strCmd;
            string name;
            string surname;
            string patr;
            string login;
            string passwd;
            string hashpasswd;
            string status;
            try
            {
                name = textBox1.Text;
                surname = textBox2.Text;
                patr = textBox3.Text;

                login = textBox6.Text;
                passwd = Passwd.Text;
                status = comboBox1.Text;

                hashpasswd = GetMD5Hash(passwd);
                //if (n1.Length < 1 || n2.Length < 1 || n3.Length < 1 || n4.Length < 1 || n5.Length < 1 || n6.Length < 1 || n7.Length < 1 || n8.Length < 1)
                //{
                //    MessageBox.Show("Некорректные входные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                rowIndex = dataGridView1.CurrentCell.RowIndex;
                primaryKey = dataGridView1.Rows[rowIndex].Cells["idClient"].Value.ToString();
                //strCmd = @"UPDATE client SET name='" + n1 + "', surname ='" + n2 + "', patronymic='" + n3 + "'drivingexp ='" + n4 + "'acidentnumb ='" + n5 + "'passport ='" + n6 + "'driverlicense ='" + n8 + "'Dateofbirth ='" + n7 + "' WHERE idClient ='" + primaryKey + "';";
                //connect.ChangeData(strCmd);
                dataGridView1.DataSource = connect.LoadData("client");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 1)
            {
                textBox2.Text = char.ToUpper(textBox2.Text[0]) + "";
                textBox2.SelectionStart = textBox2.Text.Length;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = char.ToUpper(textBox1.Text[0]) + "";
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 1)
            {
                textBox3.Text = char.ToUpper(textBox3.Text[0]) + "";
                textBox3.SelectionStart = textBox3.Text.Length;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == -1)
            {
                return;
            }
            string id;
            string strCmd = "";
            string p1 = "name";
            string p2 = "surname";
            string p3 = "patronymic";
            string p4 = "login";
            string p5 = "password";
            string p6 = "privileges";
            try
            {
                string connectionString = connect.constr();
                id = dataGridView1.Rows[rowIndex].Cells["idUsers"].Value.ToString();
                strCmd = "SELECT * FROM users WHERE idUsers='" + id + "';";
                using (MySqlConnection con = new MySqlConnection())
                {
                    con.ConnectionString = connectionString;
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand(strCmd, con);
                    MySqlDataReader rdr = cmd.ExecuteReader(); // будем читать

                    rdr.Read();
                    textBox3.Text = rdr[p1].ToString();
                    textBox2.Text = rdr[p2].ToString();
                    textBox1.Text = rdr[p3].ToString();
                    textBox6.Text = rdr[p4].ToString();
                    Passwd.Text = rdr[p5].ToString();
                    comboBox1.Text = rdr[p6].ToString();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}