using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using static Interface_Proj.Classes.InternetConectionException;
using static Interface_Proj.Classes.ProfessorPasswordException;
using static Interface_Proj.Classes.StudentPasswordException;
using static Interface_Proj.Classes.WrongLoginException;
using static Interface_Proj.Classes.HashPasswordNotFound;
using static Interface_Proj.Classes.FailedToDownloadFile;
using static Interface_Proj.Classes.StudentsNotUpLoaded;
using static Interface_Proj.Classes.CharacterConversion;
using static Interface_Proj.Classes.RemovingException;
using Interface_Proj.Classes;

namespace Interface_Proj
{
    public partial class IAdminForm : Form
    {
        public IAdminForm()
        {
            InitializeComponent();

            IAdminHelpTT.SetToolTip(IAdminHelpBut, "Вам необхідно вибрати вкладку з якою Ви хочете працювати та слідкувати за підказками у разі помилок");
        }

        private readonly string csvFilePathInfo = Path.Combine(Directory.GetCurrentDirectory(), "students.csv");
        private readonly string csvFilePathSched = Path.Combine(Directory.GetCurrentDirectory(), "schedule.csv");
        private readonly string jsonFilePathProf = Path.Combine(Directory.GetCurrentDirectory(), "professors.json");
        private readonly MicrosoftStorageHandler handler = new();

        private async void IAdminInfoAddBut_Click(object sender, EventArgs e)
        {
            string text;
            if (IAdminInfoStudTB.Text != "" && IAdminInfoStudGenTB.Text != "")
            {
                text = IAdminInfoStudTB.Text + " " + IAdminInfoStudGenTB.Text;
                string[] fields = text.Split(new[] { ' ' });
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

                    //server students upload
                    try
                    {
                        await handler.UploadFile("students.csv", "StudentsFolder");
                        await handler.UploadFile(login, "students", "", $"password:{password}", $"name:{firstName}", $"lastname:{lastName}");
                    }
                    catch (StudentsNotUpLoaded ex)
                    {
                        MessageBox.Show($"Students not uploaded: {ex.Message}");
                        return;
                    }
                    catch (InternetConectionException ex)
                    {
                        MessageBox.Show($"Ooops, problem with Inet: {ex.Message}");
                        return;
                    }


                    IAdminInfoStudLB.Items.Add(text);
                    IAdminInfoStudTB.Text = string.Empty;
                    IAdminInfoStudGenTB.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Ви повинні заповнити всі поля інформації про студента");
                }
                IAdminInfoStudLB.Items.Clear();

                try
                {
                    List<string> lines = File.ReadAllLines(csvFilePathInfo).ToList();
                    foreach (string line in lines)
                    {
                        IAdminInfoStudLB.Items.Add(line);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"List<string> lines не знайдений: {ex.Message}");
                    return;
                }
            }
        }

        private async void IAdminInfoDelete_Click(object sender, EventArgs e)
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

                    handler.DeleteStudent(firstWord, secondWord);

                    //to server students upload
                    await handler.UploadFile("students.csv", "StudentsFolder");

                    IAdminInfoStudTB.Text = string.Empty;
                    // Обновление данных в ListBox
                    IAdminInfoStudLB.Items.Clear();

                    try
                    {
                        List<string> lines = File.ReadAllLines(csvFilePathInfo).ToList();
                        foreach (string line in lines)
                        {
                            IAdminInfoStudLB.Items.Add(line);
                        }
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show($"List<string> lines не знайдений: {ex.Message}");
                        return;
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

        private void IAdminInfoGenerateStudBut_Click(object sender, EventArgs e)
        {
            string password = Generation.GeneratePasswordForStudents();
            string nickname = Generation.GenerateUsernameForStudents();
            IAdminInfoStudGenTB.Text = $"{nickname} {password}";
        }

        private void IAdminInfoStudLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IAdminInfoStudLB.SelectedIndex != 0)
            {
                string name = IAdminInfoStudLB.Items[IAdminInfoStudLB.SelectedIndex].ToString()!.Split(';')[0];
                string lastname = IAdminInfoStudLB.Items[IAdminInfoStudLB.SelectedIndex].ToString()!.Split(';')[1];

                IAdminInfoStudGenTB.Text = handler.GetLoginAndPasswordByName(name, lastname);
            }
        }

        private async void IAdministratorForm1_Load(object sender, EventArgs e)
        {
            //from server files download
            await handler.DownloadFile("schedule.csv", "ScheduleFolder");
            await handler.DownloadFile("professors.json", "ProfessorsFolder");
            await handler.DownloadFile("students.csv", "StudentsFolder");

            try
            {
                List<string> lines = File.ReadAllLines(csvFilePathInfo).ToList();
                foreach (string line in lines)
                {
                    IAdminInfoStudLB.Items.Add(line);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"List<string> lines не знайдений: {ex.Message}");
                return;
            }
            try
            {
                List<string> lines1 = File.ReadAllLines(csvFilePathSched).ToList();
                foreach (string line in lines1)
                {
                    IAdminSchedLB.Items.Add(line);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"List<string> lines1 не знайдений: {ex.Message}");
                return;
            }
            try
            {
                List<string> lines2 = File.ReadAllLines(jsonFilePathProf).ToList();
                foreach (string line in lines2)
                {
                    IAdminProfLB.Items.Add(line);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"List<string> lines2 не знайдений: {ex.Message}");
                return;
            }
        }

        private async void IAdminAddSchedBut_Click(object sender, EventArgs e)
        {
            string text = IAdminSchedTB.Text;
            if (text != "")
            {
                string[] fields = text.Split(new[] { ' ' });

                if (fields.Length == 5)
                {
                    string day = fields[0];
                    string id = fields[1];
                    string name = fields[2];
                    string type = fields[3];
                    string link = fields[4];
                    Methods.AddSubject(new Schedule { Day = day, ID = id, Name = name, Type = type, Link = link });

                    //server schedule upload
                    await handler.UploadFile("schedule.csv", "ScheduleFolder");
                    _ = handler.UploadFile($"{name}.json", "AttendanceFolder", "{}");

                    IAdminSchedLB.Items.Add(text);
                    IAdminSchedTB.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Ви повинні заповнити всі поля розкладу");
                }
                IAdminSchedLB.Items.Clear();

                //from server schedule download
                try
                {
                    await handler.DownloadFile("schedule.csv", "ScheduleFolder");
                }
                catch (FailedToDownloadFile ex)
                {
                    MessageBox.Show($"Failed to download from server schedule: {ex.Message}");
                    return;
                }
                catch (InternetConectionException ex)
                {
                    MessageBox.Show($"Ooops, problem with Inet: {ex.Message}");
                    return;
                }

                try
                {
                    List<string> lines = File.ReadAllLines(csvFilePathSched).ToList();
                    foreach (string line in lines)
                    {
                        IAdminSchedLB.Items.Add(line);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"List<string> lines не знайдений: {ex.Message}");
                    return;
                }
            }
        }

        private async void IAdminDeleteSchedBut_Click(object sender, EventArgs e)
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


                    //to server schedule upload
                    await handler.UploadFile("schedule.csv", "ScheduleFolder");
                    _ = handler.DeleteFile($"{subject}.json", "AttendanceFolder");

                    // Обновление данных в ListBox
                    IAdminSchedTB.Text = string.Empty;

                        IAdminSchedLB.Items.Clear();

                    //from server schedule download
                    await handler.DownloadFile("shedule.csv", "ProfessorsFolder");

                    List<string> lines = File.ReadAllLines(csvFilePathSched).ToList();
                    foreach (string line in lines)
                    {
                        IAdminSchedLB.Items.Add(line);
                    }
                }
                else
                {
                    MessageBox.Show("Введіть день, ID, предмет і тип в текстовому полі!");
                }
            }
            else
            {
                MessageBox.Show("Файл schedule.csv не знайдено.");
            }
        }

        private void IAdminProfGenBut_Click(object sender, EventArgs e)
        {
            string password = Generation.GeneratePasswordForProfessors();
            string nickname = Generation.GenerateUsernameForProfessors();
            IAdminProfTB.Text = $"{nickname} {password}";
        }

        private async void IAdminProfAddBut_Click(object sender, EventArgs e)
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

                    await handler.UploadFile($"{firstWord}", "professors", fileText: "", $"password:{secondWord}");

                    //to server professors upload
                    await handler.UploadFile("professors.json", "ProfessorsFolder");

                    IAdminProfLB.Items.Add(str);
                    IAdminProfTB.Text = string.Empty;
                }

                IAdminProfLB.Items.Clear();

                //from server professors download
                try
                {
                    await handler.DownloadFile("professors.json", "ProfessorsFolder");
                }
                catch (InternetConectionException ex)
                {
                    MessageBox.Show($"Ooops, problem with Inet: {ex.Message}");
                    return;
                }

                try
                {
                    List<string> lines = File.ReadAllLines(jsonFilePathProf).ToList();
                    foreach (string line in lines)
                    {
                        IAdminProfLB.Items.Add(line);
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"List<string> lines не знайдений: {ex.Message}");
                    return;
                }
            }
        }

        private async void IAdminProfDeleteBut_Click(object sender, EventArgs e)
        {
            string firstWord = IAdminProfTB.Text;
            Methods.RemoveProfessor(firstWord);

            //to server professors upload
            await handler.UploadFile("professors.json", "ProfessorsFolder");
            await handler.DeleteFile($"{firstWord}", "professors");

            IAdminProfTB.Text = string.Empty;
            IAdminProfLB.Items.Clear();

            //from server professors download
            try
            {
                List<string> lines = File.ReadAllLines(jsonFilePathProf).ToList();
                foreach (string line in lines)
                {
                    IAdminProfLB.Items.Add(line);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"List<string> lines не знайдений: {ex.Message}");
                return;
            }

        }

        private void IAdministratorForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
                File.Delete("schedule.csv");
                File.Delete("professors.json");
                File.Delete("students.csv");
            System.Windows.Forms.Application.Exit();
        }
    }
}