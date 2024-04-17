using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace OSAGO
{
    public partial class Osagocost : Form
    {
        Connect connect = new Connect();
        CostForOSAGO costForOSAGO = new CostForOSAGO();
        public Osagocost()
        {
            InitializeComponent();
        }


        private void brand_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                string connectionString = connect.constr();
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "SELECT brand FROM car group by brand;";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    brand.Items.AddRange(new string[] { reader[0].ToString() });
                }
                reader.Close();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void model_MouseEnter(object sender, EventArgs e)
        {
            string connectionString = connect.constr();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT model FROM car where brand = '" + brand.Text + "';";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                model.Items.AddRange(new string[] { reader[0].ToString() });
            }
            reader.Close();
            connection.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HorsePower_Leave(object sender, EventArgs e)
        {
            if (HorsePower.Text == "")
                return;
            int ls = 0;
            try
            {
                ls = Convert.ToInt32(HorsePower.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(ls < 50)
            {
                costForOSAGO.km = 0.6;
            }
            if (ls > 50 && ls < 71)
            {
                costForOSAGO.km = 1.0;
            }
            if (ls > 70 && ls < 100)
            {
                costForOSAGO.km = 1.1;
            }
            if (ls > 100 && ls < 121)
            {
                costForOSAGO.km = 1.2;
            }
            if (ls > 120 && ls < 150)
            {
                costForOSAGO.km = 1.4;
            }
            if (ls > 150)
            {
                costForOSAGO.km = 1.6;
            }
            
            label24.Text = costForOSAGO.price().ToString() + "р";
        }

        private void ReleaseDate_Leave(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            try
            {
                dateTime = Convert.ToDateTime(ReleaseDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double years = (DateTime.Today - dateTime).TotalDays / 365;
        }

        private void textBox14_Leave(object sender, EventArgs e)
        {
            int staj = 0;
            try
            {
                staj = Convert.ToInt32(textBox14.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (staj)
            {
                case 0:
                    costForOSAGO.kbm =2.45;
                    break;
                case 1:
                    costForOSAGO.kbm = 2.3;
                    break;
                case 2:
                    costForOSAGO.kbm = 1.55;
                    break;
                case 3:
                    costForOSAGO.kbm = 1.4;
                    break;
                case 4:
                    costForOSAGO.kbm = 1;
                    break;
                case 5:
                    costForOSAGO.kbm = 0.95;
                    break;
                case 6:
                    costForOSAGO.kbm = 0.9;
                    break;
                case 7:
                    costForOSAGO.kbm = 0.85;
                    break;
                case 8:
                    costForOSAGO.kbm = 0.8;
                    break;
                case 9:
                    costForOSAGO.kbm = 0.75;
                    break;
                case 10:
                    costForOSAGO.kbm = 0.7;
                    break;
                case 11:
                    costForOSAGO.kbm = 0.65;
                    break;
                case 12:
                    costForOSAGO.kbm = 0.60;
                    break;
                case 13:
                    costForOSAGO.kbm = 0.55;
                    break;
                default:
                    costForOSAGO.kbm = 0.5;
                    break;

            }
            label24.Text = costForOSAGO.price().ToString() + "р";

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                costForOSAGO.ko = 1.94;
            }
            if (!checkBox5.Checked)
            {
                costForOSAGO.ko = 1.0;
            }
            label24.Text = costForOSAGO.price().ToString() + "р";
        }

        private void PeriodOfUse_MouseLeave(object sender, EventArgs e)
        {
            int sez = 0;
            if (PeriodOfUse.Text == "")
                return;
            try
            {
                sez = Convert.ToInt32(PeriodOfUse.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (sez)
            {
                case 0:
                    costForOSAGO.kc = 0.5;
                    break;
                case 1:
                    costForOSAGO.kbm = 0.5;
                    break;
                case 2:
                    costForOSAGO.kbm = 0.5;
                    break;
                case 3:
                    costForOSAGO.kbm = 0.5;
                    break;
                case 4:
                    costForOSAGO.kbm = 0.6;
                    break;
                case 5:
                    costForOSAGO.kbm = 0.65;
                    break;
                case 6:
                    costForOSAGO.kbm = 0.7;
                    break;
                case 7:
                    costForOSAGO.kbm = 0.8;
                    break;
                case 8:
                    costForOSAGO.kbm = 0.9;
                    break;
                case 9:
                    costForOSAGO.kbm = 1.0;
                    break;
                default:
                    {
                        costForOSAGO.kbm = 1.0;
                        break;
                    }
            }
            label24.Text = costForOSAGO.price().ToString() + "р";
        }

        private void dateTimePicker2_MouseLeave(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            try
            {
                dateTime = Convert.ToDateTime(dateTimePicker2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int years = Convert.ToInt32((DateTime.Today - dateTime).TotalDays / 365);

            if(years < 21)
            {
                costForOSAGO.kbc = 1.62;
            }
            if (years > 21 && years < 25)
            {
                costForOSAGO.kbc = 1.10;
            }
            if (years > 25 && years < 30)
            {
                costForOSAGO.kbc = 1.02;
            }
            if (years > 30 && years < 35)
            {
                costForOSAGO.kbc = 0.95;
            }
            if (years > 35 && years < 40)
            {
                costForOSAGO.kbc = 0.93;
            }
            if (years > 40 && years < 45)
            {
                costForOSAGO.kbc = 0.92;
            }
            if (years > 45 && years < 50)
            {
                costForOSAGO.kbc = 0.91;
            }
            if (years > 50 && years < 59)
            {
                costForOSAGO.kbc = 0.86;
            }
            if (years > 59)
            {
                costForOSAGO.kbc = 0.83;
            }

            label24.Text = costForOSAGO.price().ToString() + "р";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var helper = new WordHelper("osago.doc");

            var items = new Dictionary<string, string>
            {
                { "{tb}" , costForOSAGO.tb.ToString()},
                { "{kc}" , costForOSAGO.kc.ToString()},
                { "{kt}" , costForOSAGO.kt.ToString()},
                { "{kbm}" , costForOSAGO.kbm.ToString()},
                { "{kbc}" , costForOSAGO.kbc.ToString()},
                { "{ko}" , costForOSAGO.ko.ToString()},
                { "{km}" , costForOSAGO.km.ToString()},
                { "{kn}" , costForOSAGO.kn.ToString()},
                { "{cost}" , label24.Text}

            };

            helper.Process(items);
        }

    }
}
