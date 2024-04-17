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
    public partial class aboutOSAGO : Form
    {
        Connect connect = new Connect();
        string Id;
        string driverid;
        public aboutOSAGO(string id)
        {
            InitializeComponent();
            Id = id;
            init();
        }

        private void init()
        {
            DataTable dt = connect.LoadData(" orders where OrderId = " + Id);
            string carid = dt.Rows[0][1].ToString();
            driverid = dt.Rows[0][2].ToString();
            string ownerid = dt.Rows[0][3].ToString();
            string policyholderid = dt.Rows[0][4].ToString();

            DataTable car = connect.LoadData(" clientscar where idClientsCar = " + carid);
            carnumber.Text = car.Rows[0][1].ToString();
            BrandModelYear.Text = car.Rows[0][2].ToString() +" " + car.Rows[0][3].ToString() + " " + car.Rows[0][4].ToString();
            hp.Text = car.Rows[0][5].ToString();
            CarIdentifier.Text = car.Rows[0][6].ToString() + ":";
            CarIndentifierNumber.Text = car.Rows[0][7].ToString();
            CarDocument.Text = car.Rows[0][8].ToString() + ":";
            CarDocumentNumber.Text = car.Rows[0][9].ToString();

            DataTable driver = connect.LoadData(" driver where idDriver = " + driverid);
            DriverFIO.Text = driver.Rows[0][2].ToString() + " " + driver.Rows[0][1].ToString() + " " + driver.Rows[0][3].ToString();
            DriverDateOfBirth.Text = driver.Rows[0][7].ToString();
            Driverlicencse.Text = driver.Rows[0][6].ToString();
            Driverexp.Text = driver.Rows[0][4].ToString();

            DataTable Owner = connect.LoadData(" owner where idOwner = " + ownerid);
            OwnerFIO.Text = Owner.Rows[0][1].ToString() + " " + Owner.Rows[0][2].ToString() + " " + Owner.Rows[0][3].ToString();
            OwnerDateOfBirth.Text = Owner.Rows[0][4].ToString();
            OwnerPassport.Text = Owner.Rows[0][5].ToString();

            DataTable policyholder = connect.LoadData(" policyholder where idpolicyholder = " + policyholderid);
            policyholderFIO.Text = policyholder.Rows[0][1].ToString() + " " + policyholder.Rows[0][2].ToString() + " " + policyholder.Rows[0][3].ToString();
            policyholderDateOfBirth.Text = policyholder.Rows[0][4].ToString();
            policyholderPassport.Text = policyholder.Rows[0][5].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Оформить ДТП?", "OSAGO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                connect.AddData("update driver set `acidentnumb` = `acidentnumb` + 1 where idDriver = " + driverid);
                MessageBox.Show("ДТП Оформленно", "OSAGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }
    }
}
