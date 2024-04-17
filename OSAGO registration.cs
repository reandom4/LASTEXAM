using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OSAGO
{
    public partial class OSAGO_registration : Form
    {
        Connect connect = new Connect();
        CostForOSAGO costForOSAGO = new CostForOSAGO();
        Dictionary<string, string> items = new Dictionary<string, string>
        {
                { "Number" , ""},
                { "Brand" , ""},
                { "Model" , ""},
                { "ProductionDate" , ""},
                { "HorsePower" , ""},
                { "Identifier" , ""},
                { "IdentifierNumber" , ""},
                { "Document" , ""},
                { "DocumentNumber" , ""},
                { "DocumentDate", ""},
                { "Driver1Name", ""},
                { "Driver1Surname", ""},
                { "Driver1patronymic", ""},
                { "Driver1licence", ""},
                { "Driver1exp", ""},
                { "OwnerName", ""},
                { "OwnerSurname", ""},
                { "OwnerPatronymic", ""},
                { "OwnerDateofbirth", ""},
                { "OwnerPassport", ""},
                { "OwnerPassportDate", ""},
                { "OwnerRegistrationAddress", ""},
                { "PolicyholderName", ""},
                { "PolicyholderSurname", ""},
                { "PolicyholderPatronymic", ""},
                { "PolicyholderDateofbirth", ""},
                { "PolicyholderPassport", ""},
                { "PolicyholderPassportDate", ""},
                { "PolicyholderRegistrationAddress", ""}
        };
        
        public OSAGO_registration()
        {
            InitializeComponent();
            
        }

        private void CarNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CarNumber.Text.Length == 0 || CarNumber.Text.Length == 4 || CarNumber.Text.Length == 5)
            {
                if ((e.KeyChar < 1072 || e.KeyChar > 1103) && (e.KeyChar < 1140 || e.KeyChar > 1171) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
                }
            else if (CarNumber.Text.Length == 1 || CarNumber.Text.Length == 2 || CarNumber.Text.Length == 3 || CarNumber.Text.Length == 7 || CarNumber.Text.Length == 8 || CarNumber.Text.Length == 9)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }

        }

        private void CarNumber_TextChanged(object sender, EventArgs e)
        {
            CarNumber.Text = CarNumber.Text.ToUpperInvariant();
            CarNumber.Select(CarNumber.Text.Length, 0);

            if(CarNumber.Text.Length == 6)
            {
                CarNumber.Text = CarNumber.Text + " ";
                CarNumber.Select(CarNumber.Text.Length, 0);
            }
        }

        private void OSAGO_registration_Load(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void brand_TextChanged(object sender, EventArgs e)
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
            model.Enabled = true;
        }

        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductionDate.Enabled = true;
        }

        private void HorsePower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Identifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Identifier.SelectedIndex == 0)
            {
                NumbOfIdentifier_label.Text = "Номер VIN";
            }
            if (Identifier.SelectedIndex == 1)
            {
                NumbOfIdentifier_label.Text = "Номер Кузова";
            }
            if (Identifier.SelectedIndex == 2)
            {
                NumbOfIdentifier_label.Text = "Номер Шасси";
            }
        }

        private void Document_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Document.SelectedIndex == 0)
            {
                DocumentNumber_label.Text = "Номер ПТС";
                DocumentDate_label.Text = "Дата выдачи ПТС";
            }
            if (Document.SelectedIndex == 0)
            {
                DocumentNumber_label.Text = "Номер CТС";
                DocumentDate_label.Text = "Дата выдачи CТС";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CarNumber.Text.Length == 10 && brand.Text != "" && model.Text != "" && ProductionDate.Text != "" && HorsePower.Text != "" && (Identifier.Text == "VIN" || Identifier.Text == "Кузов" || Identifier.Text == "Шасси") && (Document.Text == "ПТС" || Document.Text == "СТС") && DocumentDate.Text.Length == 10 && DocumentNumber.Text != "")
            {

                items["Number"] = CarNumber.Text;
                items["Brand"] = brand.Text;
                items["Model"] = model.Text;
                items["ProductionDate"] = ProductionDate.Text;
                items["HorsePower"] = HorsePower.Text;
                items["Identifier"] = Identifier.Text;
                items["IdentifierNumber"] = IdentifierNumber.Text;
                items["Document"] = Document.Text;
                items["DocumentNumber"] = DocumentNumber.Text;
                items["DocumentDate"] = DocumentDate.Text;

                OSAGO_registration2 OSAGO_registration2 = new OSAGO_registration2(items);
                this.Hide();
                OSAGO_registration2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Проверте правильносать заполнения полей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DocumentDate_Click(object sender, EventArgs e)
        {
            if(DocumentDate.Text.Replace(" ", "").Length < 4)
                DocumentDate.Select(DocumentDate.Text.Replace(" ","").Length-2, 0);
            if(DocumentDate.Text.Replace(" ", "").Length >= 4 && (DocumentDate.Text.Replace(" ", "").Length < 6))
                DocumentDate.Select(DocumentDate.Text.Replace(" ", "").Length - 1, 0);
            if (DocumentDate.Text.Replace(" ", "").Length >= 6)
                DocumentDate.Select(DocumentDate.Text.Replace(" ", "").Length, 0);
        }

        private void DocumentNumber_TextChanged(object sender, EventArgs e)
        {

            DocumentNumber.Text = DocumentNumber.Text.ToUpper();
            DocumentNumber.SelectionStart = DocumentNumber.Text.Length;
        }

        private void DocumentDate_Leave(object sender, EventArgs e)
        {
            try
            {
            DateTime dateTime = DateTime.ParseExact(DocumentDate.Text, "dd:MM:yyyy", CultureInfo.InvariantCulture);
            string test = dateTime.ToString("dd:MM:yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверный формат даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DocumentDate.Text = "";
                return;
            }
        }
    }
}
