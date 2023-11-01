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
            /* CleanErrorMessage();
             if (CheckNameAndPassword() && LoginExit() && PasswordExit() && IPasswordTB1.TextLength == 8)
             {
                 IStudentForm1 student = new IStudentForm1();
                 this.Hide();
                 student.Show();
             }
             else if(CheckNameAndPassword() && LoginExit() && PasswordExit() && IPasswordTB1.TextLength == 9)
             {
                 IProfessorForm1 professor = new IProfessorForm1();
                 this.Hide();
                 professor.Show();
             }*/

            CleanErrorMessage();

            string name = INameTB1.Text;
            string password = IPasswordTB1.Text;

            if (CheckNameAndPassword(name, password))
            {
                if (password.Length == 8)
                {
                    IStudentForm1 student = new IStudentForm1();
                    this.Hide();
                    student.Show();
                }
                else if (password.Length == 9)
                {
                    IProfessorForm1 professor = new IProfessorForm1();
                    this.Hide();
                    professor.Show();
                }
            }

        }

        private bool CheckNameAndPassword(string name, string password)
        {
            bool status = true;

            if (string.IsNullOrWhiteSpace(name))
            {
                status = false;
                errorProvider1.SetError(INameTB1, "Будь ласка, введіть Ваше ім'я!");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                status = false;
                errorProvider1.SetError(IPasswordTB1, "Будь ласка, введіть Ваш пароль!");
            }

            return status;
        }

        private void CleanErrorMessage()
        {
            errorProvider1.SetError(INameTB1, "");
            errorProvider1.SetError(IPasswordTB1, "");
        }

        private void IRegistrationForm2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void IRegistrationForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
