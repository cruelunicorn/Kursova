using PasswordLoginGeneration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Interface_Proj
{
    public partial class IAdministratorForm1 : Form
    {
        public IAdministratorForm1()
        {
            InitializeComponent();
        }

        private void IAdminInfoAddBut_Click(object sender, EventArgs e)
        {
            //Перевірка на наявність тексту в IAdminInfoTB,
            //додавання його до IAdminInfoLB
            //(Trim() - щоб не було зайвих прогалин)
            //if (!string.IsNullOrEmpty(IAdminInfoStudTB.Text))
            //{
            //    IAdminInfoStudLB.Items.Add(IAdminInfoStudTB.Text.Trim());
            //   IAdminInfoStudTB.Text = string.Empty;
            //}


            string newtext = "";
            if (IAdminInfoStudTB.Text != "" && IAdminInfoStudGenTB.Text != "")
            {
                newtext = IAdminInfoStudTB.Text + " " + IAdminInfoStudGenTB.Text;
                //string[] fields = newtext.Split(new[] { ' ', ';' });
                string[] fields = newtext.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string firstName = "";
                string lastName = "";
                string email = "";
                string group = "";
                string studentType = "";
                string login = "";
                string password = "";
                if (fields.Length == 7)
                {
                    firstName = fields[0];
                    lastName = fields[1];
                    email = fields[2];
                    group = fields[3];
                    studentType = fields[4];
                    login = fields[5];
                    password = fields[6];
                    Methods.AddStudent(new Student { FirstName = firstName, LastName = lastName, Email = email, Group = group }, new LoginInfo { Login = login, Password = password });
                    IAdminInfoStudLB.Items.Add(newtext);
                    IAdminInfoStudTB.Text = string.Empty;
                    IAdminInfoStudGenTB.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Ви повинні заповнити всі поля інформації про студента");
                }
                //Methods.ReadStudentsFromCsv();
                // 
            }
        }

        private void IAdminInfoDelete_Click(object sender, EventArgs e)
        {
            string text = IAdminInfoStudLB.Text;
            // string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // +видалення підстрок
            string[] words = text.Split(new[] { ' ' });
            string firstWord = "";
            string secondWord = "";
            if (words.Length == 2)
            {
                // firstWord і secondWord містять два слова із вихідного рядка

                firstWord = words[0];
                secondWord = words[1];
            }
            Methods.RemoveStudent(firstWord, secondWord);
            //Methods.ReadStudentsFromCsv(); /////
        }

        private void IAdminInfoLB_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                IAdminInfoCMS.Show(IAdminInfoStudLB, e.Location);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IAdminInfoDelete_Click(null, null);
        }

        private void cleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IAdminInfoStudLB.Items.Clear();
        }

        private void IAdminInfoTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IAdminInfoAddBut_Click(null, null);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void IAdminInfoGenerateStudBut_Click(object sender, EventArgs e)
        {
            string password = GeneratePassword();
            string nickname = GenerateUsername();
            IAdminInfoStudGenTB.Text = $"{nickname}; {password}";
        }

        private static Random random = new Random();

        // Username generation
        static string GenerateUsername(int length = 10)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789._";
            char[] username = new char[length];
            for (int i = 0; i < length; i++)
            {
                username[i] = chars[random.Next(chars.Length)];
            }
            return new string(username);
        }
        static string GeneratePassword(int length = 8)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }
            return new string(password);
        }
        private void IAdminInfoStudLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IAdministratorForm1_Load(object sender, EventArgs e)
        {
            //bindingSource1.DataSource = List<Student>;
            //List<Student> students = Methods.ReadStudentsFromCsv();
            //bindingSource1.DataSource = students;
        }

        private void methodsBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
