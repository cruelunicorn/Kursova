using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Proj
{
    public partial class IRegistrationForm2 : Form
    {
        public IRegistrationForm2()
        {
            InitializeComponent();
        }

        private void IComeInBut1_Click(object sender, EventArgs e)
        {
            CleanErrorMessage();
            if (CheckNameAndPassword())
            {
                IAdministratorForm1 administrator = new IAdministratorForm1();
                this.Hide();
                administrator.Show();
            }
        }

        private bool CheckNameAndPassword()
        {
            bool status = true;

            if (INameTB1.Text == "")
            {
                status = false;
                errorProvider1.SetError(INameTB1, "Будь ласка введіть Ваше ім'я!");
            }

            if (IPasswordTB1.Text == "")
            {
                status = false;
                errorProvider1.SetError(IPasswordTB1, "Будь ласка введіть Ваш пароль!");
            }

            return status;
        }

        private void CleanErrorMessage()
        {
            errorProvider1.SetError(INameTB1, "");
            errorProvider1.SetError(IPasswordTB1, "");
        }
    }
}
