using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class FormPeople : Form
    {
        public FormPeople()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void RefreshData()
        {
            dgvListPeople.DataSource = clsPeopleBusiness.GetAllPersons();
            lblRecordsTotal.Text = clsPeopleBusiness.GetTotalNumberOfPersons().ToString();
        }
        private void FormPeople_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            FormAddEditPerson frm = new FormAddEditPerson(-1);
            frm.ShowDialog();
        }

        private void toolstripEdit_Click(object sender, EventArgs e)
        {
            FormAddEditPerson frm = new FormAddEditPerson((int)dgvListPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
           
        }
    }
}
