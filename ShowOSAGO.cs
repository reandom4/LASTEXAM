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

namespace OSAGO
{
    public partial class ShowOSAGO : Form
    {
        Connect connect = new Connect();
        public ShowOSAGO()
        {
            InitializeComponent();
            dataGridView1.DataSource = connect.LoadDate("SELECT OrderId,CarNumber, concat(driver.surname, name, patronymic), concat(OwnerSurname, OwnerName, OwnerPatronymic), concat(PolicyholderSurname, PolicyholderName, PolicyholderPatronymic), Cost, Prem  FROM osago.orders join driver on OrderDriverId = idDriver join clientscar on OrderCarId = idClientsCar join `owner` on OrderOwnerId = idOwner join policyholder on OrderPolicyholderId = idpolicyholder;");
            dataGridView1.Columns[0].HeaderText = "";
            dataGridView1.Columns[1].HeaderText = "Номер авто";
            dataGridView1.Columns[2].HeaderText = "ФИО водителя";
            dataGridView1.Columns[3].HeaderText = "ФИО владельца";
            dataGridView1.Columns[4].HeaderText = "ФИО страхователя";
            dataGridView1.Columns[5].HeaderText = "Цена";
            dataGridView1.Columns[6].HeaderText = "Премиальные";
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

            try
            {
                string connectionString = connect.constr();
                id = dataGridView1.Rows[rowIndex].Cells["OrderId"].Value.ToString();

                aboutOSAGO aboutOSAGO = new aboutOSAGO(id);
                aboutOSAGO.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
