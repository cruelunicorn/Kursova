using Microsoft.VisualBasic;
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
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace Interface_Proj
{
    public partial class IAdministratorForm1 : Form
    {
        public IAdministratorForm1()
        {
            InitializeComponent();
        }

        const string csvFilePathInfo = @"C:\Kursova\Interface_Proj\bin\Debug\net6.0-windows\students.csv";
        const string csvFilePathSched = @"C:\Kursova\Interface_Proj\bin\Debug\net6.0-windows\schedule.csv";
        const string jsonFilePathProf = @"C:\Kursova\Interface_Proj\bin\Debug\net6.0-windows\professors.json";

        private void IAdminInfoAddBut_Click(object sender, EventArgs e)
        {
            string text = "";
            if (IAdminInfoStudTB.Text != "" && IAdminInfoStudGenTB.Text != "")
            {
                text = IAdminInfoStudTB.Text + " " + IAdminInfoStudGenTB.Text;
                string[] fields = text.Split(new[] { ' ' }); //StringSplitOptions.RemoveEmptyEntries);
                if (fields.Length == 7)
                {
                    string firstName = fields[0];
                    string lastName = fields[1];
                    string email = fields[2];
                    string group = fields[3];
                    string studentType = fields[4];
                    string login = fields[5];
                    string password = fields[6];
                    Methods.AddStudent(new Student { FirstName = firstName, LastName = lastName, Email = email, Group = group, StudentType = studentType }, new LoginInfo { Login = login, Password = password });
                    //MicrosoftStorageHandler handler = new() handler.UploadFile("students.csv", "StudentsFolder");
                    /*MicrosoftStorageHandler handler = new MicrosoftStorageHandler();
                    await handler.UploadFile("students.csv", "StudentsFolder");*/
                    IAdminInfoStudLB.Items.Add(text);
                    IAdminInfoStudTB.Text = string.Empty;
                    IAdminInfoStudGenTB.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Ви повинні заповнити всі поля інформації про студента");
                }
                IAdminInfoStudLB.Items.Clear();
                List<string> lines = File.ReadAllLines(csvFilePathInfo).ToList();
                foreach (string line in lines)
                {
                    IAdminInfoStudLB.Items.Add(line);
                }
            }
        }

        private void IAdminInfoDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists(csvFilePathInfo))
            {
                string text = IAdminInfoStudTB.Text;
                string[] words = text.Split(new[] { ' ' });

                if (words.Length == 2)
                {
                    string firstWord = words[0];
                    string secondWord = words[1];

                    Methods.RemoveStudent(firstWord, secondWord);
                    IAdminInfoStudTB.Text = string.Empty;
                    // Обновление данных в ListBox 
                    IAdminInfoStudLB.Items.Clear();
                    List<string> lines = File.ReadAllLines(csvFilePathInfo).ToList();
                    foreach (string line in lines)
                    {
                        IAdminInfoStudLB.Items.Add(line);
                    }
                }
                else
                {
                    MessageBox.Show("Введіть ім'я та прізвище студента в текстовому полі!");
                }
            }
            else
            {
                MessageBox.Show("Файл students.csv не знайдено.");
            }
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
            /* if (IAdminInfoStudLB.SelectedItem != null)
             {
                 string selectedText = IAdminInfoStudLB.SelectedItem.ToString();
                 string[] words = selectedText.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                 if (words.Length >= 2)
                 {
                     string firstWord = words[0];
                     string secondWord = words[1];

                     Methods.RemoveStudent(firstWord, secondWord);
                 }
             }
             else
             {
                 MessageBox.Show("Ви не обрали студента, якого хочете видалити!");
             }*/
        }

        private void cleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            string password = HashTable.GeneratePasswordForStudents();
            string nickname = HashTable.GenerateUsername();
            IAdminInfoStudGenTB.Text = $"{nickname} {password}";
        }

        private void IAdminInfoStudLB_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void IAdministratorForm1_Load(object sender, EventArgs e)
        {
            List<string> lines = File.ReadAllLines(csvFilePathInfo).ToList();
            foreach (string line in lines)
            {
                IAdminInfoStudLB.Items.Add(line);
            }
            List<string> lines1 = File.ReadAllLines(csvFilePathSched).ToList();
            foreach (string line in lines1)
            {
                IAdminSchedLB.Items.Add(line);
            }
            List<string> lines2 = File.ReadAllLines(jsonFilePathProf).ToList();
            foreach (string line in lines2)
            {
                IAdminProfLB.Items.Add(line);
            }
        }

        private void methodsBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void IAdminAddSchedBut_Click(object sender, EventArgs e)
        {
            string text = IAdminSchedTB.Text;
            if (text != "")
            {
                string[] fields = text.Split(new[] { ' ' }); //StringSplitOptions.RemoveEmptyEntries);

                if (fields.Length == 5)
                {
                    string day = fields[0];
                    string id = fields[1];
                    string name = fields[2];
                    string type = fields[3];
                    string link = fields[4];
                    Methods.AddSubject(new Schedule { Day = day, ID = id, Name = name, Type = type, Link = link });
                    IAdminSchedLB.Items.Add(text);
                    IAdminSchedTB.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Ви повинні заповнити всі поля розкладу");
                }
                IAdminSchedLB.Items.Clear();
                List<string> lines = File.ReadAllLines(csvFilePathSched).ToList();
                foreach (string line in lines)
                {
                    IAdminSchedLB.Items.Add(line);
                }
            }
        }

        private void IAdminDeleteSchedBut_Click(object sender, EventArgs e)
        {
            if (File.Exists(csvFilePathSched))
            {
                string text = IAdminSchedTB.Text;
                string[] words = text.Split(new[] { ' ' });

                if (words.Length == 4)
                {
                    string day = words[0];
                    string id = words[1];
                    string subject = words[2];
                    string type = words[3];
                    Methods.RemoveSubject(day, id, subject, type);
                    // Обновление данных в ListBox
                    IAdminSchedTB.Text = string.Empty;
                    IAdminSchedLB.Items.Clear();
                    List<string> lines = File.ReadAllLines(csvFilePathSched).ToList();
                    foreach (string line in lines)
                    {
                        IAdminSchedLB.Items.Add(line);
                    }
                }
                else
                {
                    MessageBox.Show("Введіть день та предмет в текстовому полі!");
                }
            }
            else
            {
                MessageBox.Show("Файл schedule.csv не знайдено.");
            }
        }

        private void IAdminProfGenBut_Click(object sender, EventArgs e)
        {
            string password = HashTable.GeneratePasswordForProfessors();
            string nickname = HashTable.GenerateUsername();
            IAdminProfTB.Text = $"{nickname} {password}";
        }

        private void IAdminProfAddBut_Click(object sender, EventArgs e)
        {
            string str = IAdminProfTB.Text;
            if (str != "")
            {
                string[] words = str.Split(new[] { ' ' });

                if (words.Length == 2)
                {
                    string firstWord = words[0];
                    string secondWord = words[1];
                    Methods.AddProfessor(new LoginInfoProfessors { Login = firstWord, Password = secondWord });

                    IAdminProfLB.Items.Add(str);
                    IAdminProfTB.Text = string.Empty;
                }

                IAdminProfLB.Items.Clear();
                List<string> lines = File.ReadAllLines(jsonFilePathProf).ToList();
                foreach (string line in lines)
                {
                    IAdminProfLB.Items.Add(line);
                }
            }
        }

        private void IAdminProfDeleteBut_Click(object sender, EventArgs e)
        {
            string firstWord = IAdminProfTB.Text;
            Methods.RemoveProfessor(firstWord);
            IAdminProfTB.Text = string.Empty;
            IAdminProfLB.Items.Clear();
            List<string> lines = File.ReadAllLines(jsonFilePathProf).ToList();
            foreach (string line in lines)
            {
                IAdminProfLB.Items.Add(line);
            }

        }

        private void IAdministratorForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
