using PasswordLoginGeneration;
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
        private static string fileData = "";
        MicrosoftStorageHandler handler = new();
        public IRegistrationForm2()
        {
            InitializeComponent();
        }

        private async Task SetFileData(string login)
        {
            await handler.DownloadFile($"{login}.txt");
            using (StreamReader file = new($"{login}.txt"))
            {
                fileData = file.ReadLine()!;
            }
            File.Delete($"{login}.txt");
        }     

        private async void IComeInBut1_Click(object sender, EventArgs e)
        {           
            await handler.DownloadFile("schedule.csv", "ScheduleFolder");
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
                string authorizationResult = await handler.CheckAuthorization(name, password);
                switch (authorizationResult)
                {
                    case "student authorized":
                        await SetFileData(name);
                        IStudentForm1 student = new(fileData);
                        Hide();
                        student.Show();
                        break;
                    case "professor authorized":
                        IProfessorForm1 professor = new();
                        Hide();
                        professor.Show();
                        break;
                    default:
                        break;
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
