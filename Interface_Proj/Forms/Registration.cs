﻿using Interface_Proj.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface_Proj
{
    public partial class IRegistrationForm2 : Form
    {
        private readonly MicrosoftStorageHandler handler = new();
        public IRegistrationForm2()
        {
            InitializeComponent();

            IRegistrationHelpTT.SetToolTip(IRegistrationHelpBut, "Вам необхідно ввести Ваш логін та пароль для входу");
        }

        private async void IComeInBut1_Click(object sender, EventArgs e)
        {
            CleanErrorMessage();
            
            string name = INameTB1.Text;
            string password = IPasswordTB1.Text;

            if (CheckNameAndPassword(name, password))
            {
                try
                {
                    string authorizationResult = await handler.CheckAuthorization(name, password);
                    switch (authorizationResult)
                    {
                        case "student authorized":
                            await handler.DownloadFile("schedule.csv", "ScheduleFolder");
                            IStudentForm1 student = new(await handler.GetNameAndLastName(name));
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
                catch (WrongLoginException)
                {
                    errorProvider1.SetError(INameTB1, "Неправильний логін!");
                }
                catch (ProfessorPasswordException)
                {
                    errorProvider1.SetError(IPasswordTB1, "Неправильний пароль!");
                }
                catch (StudentPasswordException)
                {
                    errorProvider1.SetError(IPasswordTB1, "Неправильний пароль!");
                }
                catch (InternetConectionException ex)
                {
                    MessageBox.Show($"Ooops, problem with Inet: {ex.Message}");
                    return;
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

        private void IRegistrationForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void INameTB1_Click(object sender, EventArgs e)
        {
            INameTB1.Clear();
            pictureBox1.BackgroundImage = Properties.Resources.user2;
            panelN.BackColor = Color.DodgerBlue;
            INameTB1.Font = new Font("Kievit Offc Pro", 12, FontStyle.Regular);

            pictureBox2.BackgroundImage = Properties.Resources.pass;
            panelP.BackColor = Color.Black;
        }

        private void IPasswordTB1_Click(object sender, EventArgs e)
        {
            IPasswordTB1.Clear();
            IPasswordTB1.PasswordChar = '*';
            pictureBox2.BackgroundImage = Properties.Resources.pass2;
            panelP.BackColor = Color.DodgerBlue;
            IPasswordTB1.Font = new Font("Kievit Offc Pro", 12, FontStyle.Regular);

            pictureBox1.BackgroundImage = Properties.Resources.user;
            panelN.BackColor = Color.Black;
        }
    }
}
