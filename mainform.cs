using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSAGO
{
    public partial class mainform : Form
    {
        public mainform(string qwe,string names)
        {
            InitializeComponent();
            label2.Text = names;
            if (qwe == "user")
            {
                label1.Text = "User";
                button3.Visible= false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clients clients = new clients();
            this.Hide();
            clients.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cars cars = new cars();
            this.Hide();
            cars.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            users users = new users();
            this.Hide();
            users.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowOSAGO ShowOSAGO = new ShowOSAGO();
            this.Hide();
            ShowOSAGO.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OSAGO_registration OSAGO_registration = new OSAGO_registration();
            this.Hide();
            OSAGO_registration.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Osagocost Osagocost = new Osagocost();
            this.Hide();
            Osagocost.ShowDialog();
            this.Show();
        }

    }
}
