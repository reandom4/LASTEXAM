using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OSAGO
{
    public partial class cars : Form
    {
        Connect connect = new Connect();
        int row_amount = 18, page_now = 1, list = 0 , p = 1;
        string query;
        string MainQuery;
        public cars()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            dataGridView1.DataSource = connect.LoadData("car order by brand limit " + row_amount + " offset " + row_amount * (page_now - 1) + ";");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Бренд";
            dataGridView1.Columns[2].HeaderText = "Модели";

            query = "car ";
            MainQuery = "car";
            Count_list();
        }

        private void ClearBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string n1;
            string n2;
            try
            {
                n1 = textBox1.Text;
                n2 = textBox2.Text;
                if (n1.Length < 1 || n2.Length < 1 )
                {
                    MessageBox.Show("Некорректные входные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string strcmd = "INSERT INTO car (brand, model) VALUES('" + n1 + "','" + n2 + "')";
                connect.AddData(strcmd);
                dataGridView1.DataSource = connect.LoadData("car");
                ClearBox();
            }
            catch(Exception ex)
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
            primaryKey = dataGridView1.Rows[rowIndex].Cells["idCar"].Value.ToString();
            strCmd = "DELETE FROM car WHERE idCar ='" + primaryKey + "';";
            connect.DelData1(strCmd);
            dataGridView1.DataSource = connect.LoadData("car");
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            int rowIndex;
            string primaryKey;
            string strCmd;
            string t1;
            string t2;
            try
            {
                t1 = textBox1.Text;
                t2 = textBox2.Text;
                if (t1.Length < 1 || t2.Length < 1)
                {
                    MessageBox.Show("Некорректные входные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                rowIndex = dataGridView1.CurrentCell.RowIndex;
                primaryKey = dataGridView1.Rows[rowIndex].Cells["idCar"].Value.ToString();
                strCmd = @"UPDATE car SET brand='" + t1 + "', model ='" + t2 +  "' WHERE idCar ='" + primaryKey + "';";
                connect.ChangeData(strCmd);
                dataGridView1.DataSource = connect.LoadData("car");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        
        private void Search_TextChanged(object sender, EventArgs e)
        {
            query = MainQuery;
            query = query + " where brand Like '" + textBox4.Text + "%'";
            if (p == 1)
            {
                page_now = 1;
                Count_list();
                query = query + " order by brand  ";
                dataGridView1.DataSource = connect.LoadData(query + "limit " + row_amount + " offset " + row_amount * (page_now - 1));
                return;
            }
            if (p == 0)
            {
                page_now = 1;
                Count_list();
                query = query + " order by brand DESC ";
                dataGridView1.DataSource = connect.LoadData(query + "limit " + row_amount + " offset " + row_amount * (page_now - 1));
                return;
            }
        }


        private void filter_click(object sender, EventArgs e)
        {
            query = MainQuery;
            query = query + " where brand Like '" + textBox4.Text + "%'";
            if (p==0)
            {
                page_now = 1;
                Count_list();
                query = query + " order by brand ";
                dataGridView1.DataSource = connect.LoadData(query + "limit " + row_amount + " offset " + row_amount * (page_now - 1));
                p++;
                return;
            }
            if (p == 1)
            {
                page_now = 1;
                Count_list();
                query = query + " order by brand DESC";
                dataGridView1.DataSource = connect.LoadData(query + " limit " + row_amount + " offset " + row_amount * (page_now - 1));
                p--;
                return;
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
            string p1 = "brand", p2 = "model";
            try
            {
                string connectionString = connect.constr();
                id = dataGridView1.Rows[rowIndex].Cells["idCar"].Value.ToString();
                strCmd = "SELECT * FROM car WHERE idCar='" + id + "';";
                using (MySqlConnection con = new MySqlConnection())
                {
                    con.ConnectionString = connectionString;
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand(strCmd, con);
                    MySqlDataReader rdr = cmd.ExecuteReader(); // будем читать

                    rdr.Read();
                    textBox1.Text = rdr[p1].ToString();
                    textBox2.Text = rdr[p2].ToString();
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

            DataTable qqq = connect.LoadData(MainQuery);
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
         
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = char.ToUpper(textBox1.Text[0]) + "";
                textBox1.SelectionStart = textBox1.Text.Length;
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
    }
}
