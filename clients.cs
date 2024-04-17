using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OSAGO
{
    public partial class clients : Form
    {

        int row_amount = 18, page_now = 1, list = 0 , p = 1;
        string query;
        string MainQuery;

        Connect connect = new Connect();
        public clients()
        {
            InitializeComponent();
            init();

        }

        private void init()
        {
            dataGridView1.DataSource = connect.LoadData("driver limit " + row_amount + " offset " + row_amount * (page_now - 1) + ";");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[2].DisplayIndex = 1;
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Стаж вождения";
            dataGridView1.Columns[5].HeaderText = "Страховых случаев";
            dataGridView1.Columns[6].HeaderText = "Водительское удостоверение";
            dataGridView1.Columns[7].HeaderText = "Дата рождения";

            query = "driver ";
            MainQuery = "driver ";
            Count_list();
        }
        private void ClearBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            dateTimePicker1.Text = "";
            textBox8.Text = "";
        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            string n1;
            string n2;
            string n3;
            string n4;
            string n5;
            string n6;
            string n7;
            string n8;
            try
            {
                n1 = textBox1.Text;
                n2 = textBox2.Text;
                n3 = textBox3.Text;
                n4 = textBox4.Text;
                n5 = textBox5.Text;
                n6 = textBox6.Text;
                n7 = dateTimePicker1.Text;
                n8 = textBox8.Text;
                if (n1.Length < 1 || n2.Length < 1 || n3.Length < 1)
                {
                    MessageBox.Show("Некорректные входные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string strcmd = "INSERT INTO client (name,surname,patronymic,drivingexp,acidentnumb,passport,driverlicense,Dateofbirth) VALUES('" + n1 + "','" + n2 + "','" + n3 + "','" + n4 + "','" + n5 + "','" + n6 + "','" + n7 + "','" + n8 + "')";
                connect.AddData(strcmd);
                dataGridView1.DataSource = connect.LoadData("client");
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
            primaryKey = dataGridView1.Rows[rowIndex].Cells["idClient"].Value.ToString();
            strCmd = "DELETE FROM car WHERE idClient ='" + primaryKey + "';";
            connect.DelData1(strCmd);
            dataGridView1.DataSource = connect.LoadData("client");
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
            string n7;
            string n8;
            try
            {
                n1 = textBox1.Text;
                n2 = textBox2.Text;
                n3 = textBox3.Text;
                n4 = textBox5.Text;
                n5 = textBox4.Text;
                n6 = textBox6.Text;
                n7 = dateTimePicker1.Text;
                n8 = textBox8.Text;
                if (n1.Length < 1 || n2.Length < 1 || n3.Length < 1 || n4.Length < 1 || n5.Length < 1 || n6.Length < 1 || n7.Length < 1 || n8.Length < 1)
                {
                    MessageBox.Show("Некорректные входные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rowIndex = dataGridView1.CurrentCell.RowIndex;
                primaryKey = dataGridView1.Rows[rowIndex].Cells["idClient"].Value.ToString();
                strCmd = @"UPDATE client SET name='" + n1 + "', surname ='" + n2 + "', patronymic='" + n3 + "'drivingexp ='" + n4 + "'acidentnumb ='" + n5 + "'passport ='" + n6 + "'driverlicense ='" + n8 + "'Dateofbirth ='" + n7 + "' WHERE idClient ='" + primaryKey + "';";
                connect.ChangeData(strCmd);
                dataGridView1.DataSource = connect.LoadData("client");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public string connectionString = "host='localhost';database='mydb';uid='root';pwd='qwerty';charset=utf8;";
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            query = MainQuery;
            query = query + " where surname Like '" + textBox9.Text + "%'";
            if (checkBox1.Checked)
            {
                query = query + " AND acidentnumb = 0 ";
            }
            if (p == 1)
            {
                page_now = 1;
                Count_list();
                query = query + " order by drivingexp ";
                dataGridView1.DataSource = connect.LoadData(query + "limit " + row_amount + " offset " + row_amount * (page_now - 1));
                return;
            }
            if (p == 0)
            {
                page_now = 1;
                Count_list();
                query = query + " order by drivingexp DESC";
                dataGridView1.DataSource = connect.LoadData(query + " limit " + row_amount + " offset " + row_amount * (page_now - 1));
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            query = MainQuery;
            query = query + " where surname Like '" + textBox9.Text + "%'";
            if (checkBox1.Checked)
            {
                query = query + " AND acidentnumb = 0 ";
            }
            if (p == 1)
            {
                page_now = 1;
                Count_list();
                query = query + " order by drivingexp ";
                dataGridView1.DataSource = connect.LoadData(query + "limit " + row_amount + " offset " + row_amount * (page_now - 1));
                return;
            }
            if (p == 0)
            {
                page_now = 1;
                Count_list();
                query = query + " order by drivingexp DESC";
                dataGridView1.DataSource = connect.LoadData(query + " limit " + row_amount + " offset " + row_amount * (page_now - 1));
                return;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
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
            string strCmd;
            string p1 = "name";
            string p2 = "surname";
            string p3 = "patronymic";
            string p4 = "drivingexp";
            string p5 = "acidentnumb";
            string p6 = "passport";
            string p7 = "driverlicense";
            string p8 = "Dateofbirth";

            try
            {
                string connectionString = connect.constr();
                id = dataGridView1.Rows[rowIndex].Cells["idClient"].Value.ToString();
                strCmd = "SELECT * FROM client WHERE idClient='" + id + "';";
                using (MySqlConnection con = new MySqlConnection())
                {
                    con.ConnectionString = connectionString;
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand(strCmd, con);
                    MySqlDataReader rdr = cmd.ExecuteReader(); 

                    rdr.Read();
                    textBox1.Text = rdr[p1].ToString();
                    textBox2.Text = rdr[p2].ToString();
                    textBox3.Text = rdr[p3].ToString();
                    textBox5.Text = rdr[p4].ToString();
                    textBox4.Text = rdr[p5].ToString();
                    textBox6.Text = rdr[p6].ToString();
                    dateTimePicker1.Text = rdr[p8].ToString();
                    textBox8.Text = rdr[p7].ToString();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        void Count_list()
        {

            DataTable qqq = connect.LoadData(query);
            list = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(qqq.Rows.Count) / Convert.ToDouble(row_amount)));

            next.Enabled = true;
            pred.Enabled = true;

            label9.Text = page_now + "/" + list;
            if (page_now == 1)
            {
                pred.Enabled = false;
            }
            if (page_now == list)
            {
                next.Enabled = false;
            }

        }

        private void filter_Click(object sender, EventArgs e)
        {
            query = MainQuery;
            query = query + " where surname Like '" + textBox9.Text + "%'";
            if(checkBox1.Checked)
            {
                query = query + " AND acidentnumb = 0 ";
            }
            if (p == 0)
            {
                page_now = 1;
                Count_list();
                query = query + " order by drivingexp ";
                dataGridView1.DataSource = connect.LoadData(query + "limit " + row_amount + " offset " + row_amount * (page_now - 1));
                p++;
                return;
            }
            if (p == 1)
            {
                page_now = 1;
                Count_list();
                query = query + " order by drivingexp DESC";
                dataGridView1.DataSource = connect.LoadData(query + " limit " + row_amount + " offset " + row_amount * (page_now - 1));
                p--;
                return;
            }
            
        }


        private void next_Click(object sender, EventArgs e)
        {
            page_now++;
            Count_list();
            dataGridView1.DataSource = connect.LoadData(query + " limit " + row_amount + " offset " + row_amount * (page_now - 1));
        }

        private void pred_Click(object sender, EventArgs e)
        {
            page_now--;
            Count_list();
            dataGridView1.DataSource = connect.LoadData(query + " limit " + row_amount + " offset " + row_amount * (page_now - 1));
        }

    }
}
