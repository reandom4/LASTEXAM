using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace OSAGO
{
    public partial class OSAGO_registration3 : Form
    {
        Dictionary<string, string> items = new Dictionary<string, string>();
        Connect connect = new Connect();
        CostForOSAGO costForOSAGO = new CostForOSAGO();
        public OSAGO_registration3(Dictionary<string, string> item1)
        {
            items = item1;
            InitializeComponent();
        }


        private void driverlicense_TextChanged(object sender, EventArgs e)
        {
            OwnerPassport.Text = OwnerPassport.Text.ToUpper();
            OwnerPassport.SelectionStart = OwnerPassport.Text.Length;
        }

        private void surname1_TextChanged(object sender, EventArgs e)
        {
            if (OwnerSurname.Text.Length == 1)
            {
                OwnerSurname.Text = char.ToUpper(OwnerSurname.Text[0]) + "";
                OwnerSurname.SelectionStart = OwnerSurname.Text.Length;
            }
            else if (OwnerSurname.Text.Length > 1)
            {
                OwnerSurname.Text = char.ToUpper(OwnerSurname.Text[0]) + (OwnerSurname.Text.Substring(1, OwnerSurname.Text.Length - 1)).ToLower();
                OwnerSurname.SelectionStart = OwnerSurname.Text.Length;
            }
        }

        private void Name1_TextChanged(object sender, EventArgs e)
        {
            if (OwnerName.Text.Length == 1)
            {
                OwnerName.Text = char.ToUpper(OwnerName.Text[0]) + "";
                OwnerName.SelectionStart = OwnerName.Text.Length;
            }
            else if (OwnerName.Text.Length > 1)
            {
                OwnerName.Text = char.ToUpper(OwnerName.Text[0]) + (OwnerName.Text.Substring(1, OwnerName.Text.Length - 1)).ToLower();
                OwnerName.SelectionStart = OwnerName.Text.Length;
            }
        }

        private void patronymic1_TextChanged(object sender, EventArgs e)
        {
            if (OwnerPatronymic.Text.Length == 1)
            {
                OwnerPatronymic.Text = char.ToUpper(OwnerPatronymic.Text[0]) + "";
                OwnerPatronymic.SelectionStart = OwnerPatronymic.Text.Length;
            }
            else if (OwnerPatronymic.Text.Length > 1)
            {
                OwnerPatronymic.Text = char.ToUpper(OwnerPatronymic.Text[0]) + (OwnerPatronymic.Text.Substring(1, OwnerPatronymic.Text.Length - 1)).ToLower();
                OwnerPatronymic.SelectionStart = OwnerPatronymic.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (OwnerSurname.Text != "" || OwnerName.Text != "" || OwnerPatronymic.Text != "" || OwnerDateofbirth.Text.Length == 10 || OwnerPassport.Text.Length == 10 || OwnerPassportDate.Text.Length == 10 || OwnerRegistrationAddress.Text != "")
                {
                    items["OwnerName"] = OwnerName.Text;
                    items["OwnerSurname"] = OwnerSurname.Text;
                    items["OwnerPatronymic"] = OwnerPatronymic.Text;
                    items["OwnerDateofbirth"] = OwnerDateofbirth.Text;
                    items["OwnerPassport"] = OwnerPassport.Text;
                    items["OwnerPassportDate"] = OwnerPassportDate.Text;
                    items["OwnerRegistrationAddress"] = OwnerSurname.Text;

                    items["PolicyholderName"] = OwnerName.Text;
                    items["PolicyholderSurname"] = OwnerSurname.Text;
                    items["PolicyholderPatronymic"] = OwnerPatronymic.Text;
                    items["PolicyholderDateofbirth"] = OwnerDateofbirth.Text;
                    items["PolicyholderPassport"] = OwnerPassport.Text;
                    items["PolicyholderPassportDate"] = OwnerPassportDate.Text;
                    items["PolicyholderRegistrationAddress"] = OwnerSurname.Text;


                    if (Same.Checked)
                    {

                        connect.AddData("INSERT INTO clientscar (`CarNumber`, `CarBrand`, `CarModel`, `CarDate`, `CarHorsePower`, `CarIdentifier`, `CarIdentifierNumber`, `CarDocument`, `CarDocumentNumber`, `CarDocumentDate`) VALUES ('" + items["Number"] + "', '" + items["Brand"] + "', '" + items["Model"] + "', '" + items["ProductionDate"] + "', '" + items["HorsePower"] + "', '" + items["Identifier"] + "', '" + items["IdentifierNumber"] + "' , '" + items["Document"] + "' , '" + items["DocumentNumber"] + "' , '" + items["DocumentDate"] + "')");
                        connect.AddData("INSERT INTO driver (`name`, `surname`, `patronymic`, `drivingexp`, `acidentnumb`, `driverlicense`, `Dateofbirth`) VALUES ('" + items["Driver1Name"] + "', '" + items["Driver1Surname"] + "', '" + items["Driver1patronymic"] + "', '" + items["Driver1exp"] + "', '0', '" + items["Driver1licence"] + "', '" + items["Driver1BirthDate"] + "');");
                        connect.AddData("INSERT INTO owner (`OwnerSurname`, `OwnerName`, `OwnerPatronymic`, `OwnerDateofbirth`, `OwnerPassport`, `OwnerPassportDate`, `OwnerRegistrationAddress`) VALUES ('" + items["OwnerName"] + "', '" + items["OwnerSurname"] + "', '" + items["OwnerPatronymic"] + "', '" + items["OwnerDateofbirth"] + "', '" + items["OwnerPassport"] + "', '" + items["OwnerPassportDate"] + "', '" + items["OwnerRegistrationAddress"] + "');");
                        connect.AddData("INSERT INTO policyholder (`PolicyholderName`, `PolicyholderSurname`, `PolicyholderPatronymic`, `PolicyholderDateofbirth`, `PolicyholderPassport`, `PolicyholderPassportDate`,`PolicyholderRegAddres`) VALUES ('" + items["PolicyholderName"] + "', '" + items["PolicyholderSurname"] + "', '" + items["PolicyholderPatronymic"] + "', '" + items["PolicyholderDateofbirth"] + "', '" + items["PolicyholderPassport"] + "', '" + items["PolicyholderPassportDate"] + "', '" + items["PolicyholderRegistrationAddress"] + "');");

                        int horsepowr = Convert.ToInt32(items["HorsePower"]);
                        costForOSAGO.Km(horsepowr);

                        int Driver1exp = Convert.ToInt32(items["Driver1exp"]);
                        costForOSAGO.Kbm(Driver1exp);

                        int years = 2023 - Convert.ToInt32(items["ProductionDate"]);
                        costForOSAGO.Kbc(years);

                        double cost = costForOSAGO.price();
                        connect.AddData("INSERT INTO orders (`OrderCarId`, `OrderDriverId`, `OrderOwnerId`, `OrderPolicyholderId`, `Cost`, `Prem`) VALUES ((Select idClientsCar from clientscar where CarIdentifierNumber = " + items["IdentifierNumber"] + "), (Select idDriver from driver where driverlicense = " + items["Driver1licence"] + "), (Select idOwner from owner where OwnerPassport = " + items["OwnerPassport"] + "), (Select idpolicyholder from policyholder where PolicyholderPassport = " + items["PolicyholderPassport"] + "), '" + cost + "', '450000');");
                        DialogResult dr = MessageBox.Show("Оформить ОСАГО?\nЦена:" + cost +"руб", "OSAGO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            var helper = new WordHelper("osago.doc");
                            DateTime date1 = DateTime.Now;
                            string[] dat = date1.ToShortDateString().Split('.');
                            var wwrd = new Dictionary<string, string>
                            {
                                { "{tb}" , costForOSAGO.tb.ToString()},
                                { "{kc}" , costForOSAGO.kc.ToString()},
                                { "{kt}" , costForOSAGO.kt.ToString()},
                                { "{kbm}" , costForOSAGO.kbm.ToString()},
                                { "{kbc}" , costForOSAGO.kbc.ToString()},
                                { "{ko}" , costForOSAGO.ko.ToString()},
                                { "{km}" , costForOSAGO.km.ToString()},
                                { "{kn}" , costForOSAGO.kn.ToString()},
                                { "{cost}" , cost.ToString()},
                                { "PName" ,items["PolicyholderName"]},
                                { "PSurname" , items["PolicyholderSurname"]},
                                { "PPatronymic" , items["PolicyholderPatronymic"]},
                                { "OName" , items["OwnerName"]},
                                { "OSurname" , items["OwnerSurname"]},
                                { "OPatronymic" , items["OwnerPatronymic"]},
                                { "IdentifierNumber" , items["IdentifierNumber"]},
                                { "Number" , items["Number"]},
                                { "DocumentNumber" , items["DocumentNumber"]},
                                { "D1Name" ,items["Driver1Name"]},
                                { "D1Surname" , items["Driver1Surname"]},
                                { "D1Patronymic" , items["Driver1patronymic"]},
                                { "DriverLicence" , items["Driver1licence"]},
                                { "DD" , dat[0]},
                                { "MM" , dat[1]},
                                { "YY" , dat[2]},
                                { "YL" , (Convert.ToInt32(dat[2]) + 1).ToString()},
                            };

                            helper.Process(wwrd);
                        }
                    }
                    else
                    {
                        OSAGO_registration4 OSAGO_registration4 = new OSAGO_registration4(items);
                        this.Hide();
                        OSAGO_registration4.ShowDialog();
                        this.Show();
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void OwnerSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 1040 || e.KeyChar >= 1103) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
