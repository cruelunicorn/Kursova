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

        /*      private bool LoginExit()
              {
                  bool status = true;

                  if (!Methods.StudentLoginExist(INameTB1.Text))
                  {
                      status = false;
                      errorProvider1.SetError(INameTB1, "Ваш логін не знайдено!");
                  }
                  else if (!Methods.ProfessorLoginExist(INameTB1.Text))
                  {
                      status = false;
                      errorProvider1.SetError(INameTB1, "Ваш логін не знайдено!");
                  }
                  return status;
              }

              private bool PasswordExit()
              {
                  bool status = true;

                  if (!Methods.StudentPasswordExist(INameTB1.Text))
                  {
                      status = false;
                      errorProvider1.SetError(IPasswordTB1, "Введіть правильний пароль!");
                  }
                  else if(!Methods.ProfessorPasswordExist(IPasswordTB1.Text))
                  {
                      status = false;
                      errorProvider1.SetError(IPasswordTB1, "Введіть правильний пароль!");
                  }

                  return status;
              }

              private bool CheckNameAndPassword()
              {
                  bool status = true;

                  if (INameTB1.Text == "")
                  {
                      status = false;
                      errorProvider1.SetError(INameTB1, "Будь ласка введіть Ваше ім'я!");
                  }
                  else if (IPasswordTB1.Text == "")
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
              }*/


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

            if (!LoginExist(name))
            {
                status = false;
                errorProvider1.SetError(INameTB1, "Ваш логін не знайдено!");
            }

            if (!PasswordExist(name, password))
            {
                status = false;
                errorProvider1.SetError(IPasswordTB1, "Введіть правильний пароль!");
            }

            return status;
        }

        private bool LoginExist(string name)
        {
            return Methods.StudentLoginExist(name) || Methods.ProfessorLoginExist(name);
        }

        private bool PasswordExist(string name, string password)
        {
            return Methods.StudentPasswordExist(name) || Methods.ProfessorPasswordExist(password);
        }

        private void CleanErrorMessage()
        {
            errorProvider1.SetError(INameTB1, "");
            errorProvider1.SetError(IPasswordTB1, "");
        }
    }
}
