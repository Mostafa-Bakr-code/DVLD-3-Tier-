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
    public partial class FormAddEditPerson : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _personID;
        clsPeopleBusiness _Person;
        public FormAddEditPerson(int personID)
        {
            InitializeComponent();

            _personID = personID;

            if (_personID == -1)
            {

                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }


        private void _FillCategoriesInCountryComoboBox()
        {
            DataTable dtCountries = clsPeopleBusiness.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {

                cbCountries.Items.Add(row["CountryName"]);

            }

        }

        private void LoadData()
        {

            _FillCategoriesInCountryComoboBox();
            cbCountries.SelectedIndex = 0;

            // Add Mode
            if (_Mode == enMode.AddNew)
            {
                lbAddEditPerson.Text = "Add Person";
                _Person = new clsPeopleBusiness();
                return;
            }


            // Update Mode
            else
            {

                lbAddEditPerson.Text = $"Update Person {_personID}";

                _Person = clsPeopleBusiness.Find(_personID);

                if (_Person == null)
                {
                    MessageBox.Show("This form will be closed because No Person with ID = " + _personID);
                    this.Close();

                    return;
                }

                lbPersonID.Text = _Person.PersonID.ToString();
                txtFirstName.Text = _Person.FirstName;  
                txtSecondName.Text = _Person.SecondName;
                txtThirdName.Text = _Person.ThirdName;
                txtLastName.Text = _Person.LastName;
                txtPhone.Text = _Person.Phone;
                txtMail.Text = _Person.Email;
                txtNationalnumber.Text = _Person.NationalNo;
                dtpDateofBirth.Value = _Person.DateOfBirth;
                txtAddress.Text = _Person.Address;

                if (_Person.Gender == 0)
                {
                    rbMale.Checked = true;
                    rbFemale.Checked = false;
                }
                else if (_Person.Gender == 1)
                {
                    rbMale.Checked = false;
                    rbFemale.Checked = true;
                }


                //cbCountries.SelectedIndex = cbCountries.FindString(clsPeopleBusiness.Find(_Person.NationalityCountryID).);


            }

        }

        private void FormAddEditPerson_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtNationalnumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalnumber.Text))
            {

                e.Cancel = true;
                txtNationalnumber.Focus();
                errorProvider1.SetError(txtNationalnumber, "National number should have a value");

            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalnumber, "");
            }
        }
    }
}
