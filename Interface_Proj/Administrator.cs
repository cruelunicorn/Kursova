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
            string newtext = "";
            if (IAdminInfoStudTB.Text != "" && IAdminInfoStudGenTB.Text != "")
            {
                newtext = IAdminInfoStudTB.Text + " " + IAdminInfoStudGenTB.Text;
                string[] fields = newtext.Split(new[] { ' ' }); //StringSplitOptions.RemoveEmptyEntries);
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
                    Methods.AddStudent(new Student { FirstName = firstName, LastName = lastName, Email = email, Group = group, StudentType = studentType }, new LoginInfo { Login = login, Password = password });
                    IAdminInfoStudLB.Items.Add(newtext);
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

                    // Обновление данных в ListBox (или другом контроле, в котором отображаются студенты)
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
            if (IAdminInfoStudLB.SelectedItem != null)
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
                MessageBox.Show("Ви не обрали студента, якого хочете видалити");
            }
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
            // List<string> lines = File.ReadAllLines(csvFilePathInfo).ToList();
            // foreach (string line in lines)
            // {
            //     IAdminInfoStudLB.Items.Add(line);
            // }
        }

        private void methodsBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void IAdminAddSchedBut_Click(object sender, EventArgs e)
        {
            string newtext = IAdminSchedTB.Text;
            if (newtext != "")
            {
                string[] fields = newtext.Split(new[] { ' ' }); //StringSplitOptions.RemoveEmptyEntries);
                string day = "";
                string subject = "";
                string numeratorDenominator = "";
                string link = "";

                if (fields.Length == 4)
                {
                    day = fields[0];
                    subject = fields[1];
                    numeratorDenominator = fields[2];
                    link = fields[3];
                    Methods.AddSubject(new Schedule { Day = day, Subject = subject, NumeratorDenominator = numeratorDenominator, Link = link });
                    IAdminSchedLB.Items.Add(newtext);
                    IAdminSchedTB.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Ви повинні заповнити всі поля інформації про студента");
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

                if (words.Length == 2)
                {
                    string firstWord = words[0];
                    string secondWord = words[1];

                    Methods.RemoveSubject(firstWord, secondWord);
                    // Обновление данных в ListBox (или другом контроле, в котором отображаются студенты)
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
    }
}
