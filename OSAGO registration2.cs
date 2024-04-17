using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OSAGO
{
    public partial class OSAGO_registration2 : Form
    {
        Dictionary<string, string> items = new Dictionary<string, string>();
        public OSAGO_registration2(Dictionary<string, string> items1)
        {
            InitializeComponent();
            items = items1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void surname1_TextChanged(object sender, EventArgs e)
        {
            if (surname1.Text.Length == 1)
            {
                surname1.Text = char.ToUpper(surname1.Text[0]) + "";
                surname1.SelectionStart = surname1.Text.Length;
            }
            else if (surname1.Text.Length > 1)
            {
                surname1.Text = char.ToUpper(surname1.Text[0]) + (surname1.Text.Substring(1, surname1.Text.Length - 1)).ToLower();
                surname1.SelectionStart = surname1.Text.Length;
            }         
        }

        private void Name1_TextChanged(object sender, EventArgs e)
        {
            if (Name1.Text.Length == 1)
            {
                Name1.Text = char.ToUpper(Name1.Text[0]) + "";
                Name1.SelectionStart = Name1.Text.Length;
            }
            else if (Name1.Text.Length > 1)
            {
                Name1.Text = char.ToUpper(Name1.Text[0]) + Name1.Text.Substring(1, Name1.Text.Length - 1).ToLower();
                Name1.SelectionStart = Name1.Text.Length;
            }
        }

        private void patronymic1_TextChanged(object sender, EventArgs e)
        {
            if (patronymic1.Text.Length == 1)
            {
                patronymic1.Text = char.ToUpper(patronymic1.Text[0]) + "";
                patronymic1.SelectionStart = patronymic1.Text.Length;
            }
            else if (patronymic1.Text.Length > 1)
            {
                patronymic1.Text = char.ToUpper(patronymic1.Text[0]) + patronymic1.Text.Substring(1, patronymic1.Text.Length - 1).ToLower();
                patronymic1.SelectionStart = patronymic1.Text.Length;
            }
        }

        private void Dateofbirth_Click(object sender, EventArgs e)
        {
            if (Dateofbirth.Text.Replace(" ", "").Length < 4)
                Dateofbirth.Select(Dateofbirth.Text.Replace(" ", "").Length - 2, 0);
            if (Dateofbirth.Text.Replace(" ", "").Length >= 4 && (Dateofbirth.Text.Replace(" ", "").Length < 6))
                Dateofbirth.Select(Dateofbirth.Text.Replace(" ", "").Length - 1, 0);
            if (Dateofbirth.Text.Replace(" ", "").Length >= 6)
                Dateofbirth.Select(Dateofbirth.Text.Replace(" ", "").Length, 0);
        }

        private void Drivingexp_Click(object sender, EventArgs e)
        {
            if (Drivingexp.Text.Replace(" ", "").Length < 4)
                Drivingexp.Select(Drivingexp.Text.Replace(" ", "").Length - 2, 0);
            if (Drivingexp.Text.Replace(" ", "").Length >= 4 && (Drivingexp.Text.Replace(" ", "").Length < 6))
                Drivingexp.Select(Drivingexp.Text.Replace(" ", "").Length - 1, 0);
            if (Drivingexp.Text.Replace(" ", "").Length >= 6)
                Drivingexp.Select(Drivingexp.Text.Replace(" ", "").Length, 0);
        }

        private void driverlicense_TextChanged(object sender, EventArgs e)
        {
            driverlicense.Text = driverlicense.Text.ToUpper();
            driverlicense.SelectionStart = driverlicense.Text.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(surname1.Text != "" || Name1.Text != "" || patronymic1.Text != "" || Dateofbirth.Text.Length == 10 || driverlicense.Text.Length == 10 || Drivingexp.Text.Length == 10)
            {
                items["Driver1Name"] = Name1.Text;
                items["Driver1Surname"] = surname1.Text;
                items["Driver1patronymic"] = patronymic1.Text;
                items["Driver1BirthDate"] = Dateofbirth.Text;
                items["Driver1licence"] = driverlicense.Text;
                
                try
                {
                    DateTime dateTime = DateTime.ParseExact(Drivingexp.Text, "dd:MM:yyyy", CultureInfo.InvariantCulture);
                    string test = dateTime.ToString("dd:MM:yyyy");
                    System.TimeSpan diff1 = (DateTime.Now - dateTime);
                    double days = diff1.TotalDays;
                    items["Driver1exp"] = ((int)days / 365).ToString();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                OSAGO_registration3 OSAGO_registration3 = new OSAGO_registration3(items);
                this.Hide();
                OSAGO_registration3.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Проверте правильносать заполнения полей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dateofbirth_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = DateTime.ParseExact(Dateofbirth.Text, "dd:MM:yyyy", CultureInfo.InvariantCulture);
                string test = dateTime.ToString("dd:MM:yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверный формат даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dateofbirth.Text = "";
                return;
            }
        }

        private void Drivingexp_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = DateTime.ParseExact(Drivingexp.Text, "dd:MM:yyyy", CultureInfo.InvariantCulture);
                string test = dateTime.ToString("dd:MM:yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверный формат даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Drivingexp.Text = "";
                return;
            }
        }

        private void surname1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 1039 || e.KeyChar >= 1104) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
