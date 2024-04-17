using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OSAGO
{
    public partial class OSAGO_registration4 : Form
    {
        Dictionary<string, string> items = new Dictionary<string, string>();
        public OSAGO_registration4(Dictionary<string, string> item1)
        {
            items = item1;
            InitializeComponent();
        }

        private void surname1_TextChanged(object sender, EventArgs e)
        {
            if (PolicyholderSurname.Text.Length == 1)
            {
                PolicyholderSurname.Text = char.ToUpper(PolicyholderSurname.Text[0]) + "";
                PolicyholderSurname.SelectionStart = PolicyholderSurname.Text.Length;
            }
            else if (PolicyholderSurname.Text.Length > 1)
            {
                PolicyholderSurname.Text = char.ToUpper(PolicyholderSurname.Text[0]) + PolicyholderSurname.Text.Substring(1, PolicyholderSurname.Text.Length - 1).ToLower();
                PolicyholderSurname.SelectionStart = PolicyholderSurname.Text.Length;
            }
        }

        private void Name1_TextChanged(object sender, EventArgs e)
        {
            if (PolicyholderName.Text.Length == 1)
            {
                PolicyholderName.Text = char.ToUpper(PolicyholderName.Text[0]) + "";
                PolicyholderName.SelectionStart = PolicyholderName.Text.Length;
            }
            else if (PolicyholderName.Text.Length > 1)
            {
                PolicyholderName.Text = char.ToUpper(PolicyholderName.Text[0]) + PolicyholderName.Text.Substring(1, PolicyholderName.Text.Length - 1).ToLower();
                PolicyholderName.SelectionStart = PolicyholderName.Text.Length;
            }
        }

        private void patronymic1_TextChanged(object sender, EventArgs e)
        {
            if (PolicyholderPatronymic.Text.Length == 1)
            {
                PolicyholderPatronymic.Text = char.ToUpper(PolicyholderPatronymic.Text[0]) + "";
                PolicyholderPatronymic.SelectionStart = PolicyholderPatronymic.Text.Length;
            }
            else if (PolicyholderPatronymic.Text.Length > 1)
            {
                PolicyholderPatronymic.Text = char.ToUpper(PolicyholderPatronymic.Text[0]) + PolicyholderPatronymic.Text.Substring(1, PolicyholderPatronymic.Text.Length - 1).ToLower();
                PolicyholderPatronymic.SelectionStart = PolicyholderPatronymic.Text.Length;
            }
        }

        private void driverlicense_TextChanged(object sender, EventArgs e)
        {
            PolicyholderPassport.Text = PolicyholderPassport.Text.ToUpper();
            PolicyholderPassport.SelectionStart = PolicyholderPassport.Text.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PolicyholderSurname.Text != "" || PolicyholderName.Text != "" || PolicyholderPatronymic.Text != "" || PolicyholderDateofbirth.Text.Length == 10 || PolicyholderPassport.Text.Length == 10 || PolicyholderPassportDate.Text.Length == 10 || PolicyholderRegAddres.Text != "")
            {
                items.Add("OwnerName", PolicyholderName.Text);
                items.Add("OwnerSurname", PolicyholderSurname.Text);
                items.Add("OwnerPatronymic", PolicyholderPatronymic.Text);
                items.Add("OwnerDateofbirth", PolicyholderDateofbirth.Text);
                items.Add("OwnerPassport", PolicyholderPassport.Text);
                items.Add("OwnerPassportDate", PolicyholderPassportDate.Text);
                items.Add("OwnerRegistrationAddress", PolicyholderRegAddres.Text);   
                


            }
            MessageBox.Show("Вы точно хотите оформить ОСАГО?", "OSAGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void PolicyholderSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 1040 || e.KeyChar >= 1103) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
