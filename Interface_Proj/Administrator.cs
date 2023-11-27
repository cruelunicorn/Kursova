using Microsoft.VisualBasic;
using PasswordLoginGeneration;
using Errors;
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
using static Errors.InternetConectionException;
using static Errors.DataHasNotBeenUpdated;
using static Errors.NameTooLong;
using static Errors.PasswordTooLong;
using static Errors.HashPasswordNotFound;
using static Errors.FailedToDownloadFile;
using static Errors.StudentsNotUpLoaded;
using static Errors.CharacterConversion;
using static Errors.Removing;

namespace Interface_Proj
{
    public partial class IAdministratorForm1 : Form
    {
        public IAdministratorForm1()
        {
            InitializeComponent();
        }

        private readonly string csvFilePathInfo = Path.Combine(Directory.GetCurrentDirectory(), "students.csv");
        private readonly string csvFilePathSched = Path.Combine(Directory.GetCurrentDirectory(), "schedule.csv");
        private readonly string jsonFilePathProf = Path.Combine(Directory.GetCurrentDirectory(), "professors.json");

        private async void IAdminInfoAddBut_Click(object sender, EventArgs e)
        {
            string text = "";
            MicrosoftStorageHandler handler = new MicrosoftStorageHandler();
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

                    //server students upload
                    try
                    {
                        await handler.UploadFile("students.csv", "StudentsFolder");
                        await handler.UploadFile(login, "students", $"{firstName} {lastName}", $"password:{password}");
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

                //server students download
                try
                {
                    await handler.DownloadFile("students.csv", "StudentsFolder");
                }
                catch (FailedToDownloadFile ex)
                {
                    MessageBox.Show($"Failed to download server students: {ex.Message}");
                    return;
                }
                catch (InternetConectionException ex)
                {
                    MessageBox.Show($"Ooops, problem with Inet: {ex.Message}");
                    return;
                }

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
                MicrosoftStorageHandler handler = new MicrosoftStorageHandler();
                string text = IAdminInfoStudTB.Text;
                string[] words = text.Split(new[] { ' ' });

                if (words.Length == 2)
                {
                    string firstWord = words[0];
                    string secondWord = words[1];

                    Methods.RemoveStudent(firstWord, secondWord);

                    //to server students upload
                    await handler.UploadFile("students.csv", "StudentsFolder");

                    IAdminInfoStudTB.Text = string.Empty;
                    // Обновление данных в ListBox
                        IAdminInfoStudLB.Items.Clear();

                    //from server students download
                    try
                    {
                        await handler.DownloadFile("students.csv", "StudentsFolder");
                    }
                    catch (FailedToDownloadFile ex)
                    {
                        MessageBox.Show($"Failed to download from server students: {ex.Message}");
                        return;
                    }
                    catch (InternetConectionException ex)
                    {
                        MessageBox.Show($"Ooops, problem with Inet: {ex.Message}");
                        return;
                    }

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
            string nickname = HashTable.GenerateUsernameForStudents();
            IAdminInfoStudGenTB.Text = $"{nickname} {password}";
        }

        private void IAdminInfoStudLB_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void IAdministratorForm1_Load(object sender, EventArgs e)
        {
            //from server files download
            MicrosoftStorageHandler handler = new MicrosoftStorageHandler();
//            await handler.DownloadFile("schedule.csv", "ScheduleFolder");
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

        private void methodsBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private async void IAdminAddSchedBut_Click(object sender, EventArgs e)
        {
            MicrosoftStorageHandler handler = new MicrosoftStorageHandler();
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
                MicrosoftStorageHandler handler = new MicrosoftStorageHandler();
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
                    try
                    {
                        IAdminSchedLB.Items.Clear();
                    }
                    catch (DataHasNotBeenUpdated ex)
                    {
                        MessageBox.Show($"Данні в ListBox не оновилися: {ex.Message}");
                        return;
                    }

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
            string nickname = HashTable.GenerateUsernameForProfessors();
            IAdminProfTB.Text = $"{nickname} {password}";
        }

        private async void IAdminProfAddBut_Click(object sender, EventArgs e)
        {
            MicrosoftStorageHandler handler = new MicrosoftStorageHandler();
            string str = IAdminProfTB.Text;
            if (str != "")
            {
                string[] words = str.Split(new[] { ' ' });

                if (words.Length == 2)
                {
                    string firstWord = words[0];
                    string secondWord = words[1];
                    Methods.AddProfessor(new LoginInfoProfessors { Login = firstWord, Password = secondWord });

                    _ = handler.UploadFile($"{firstWord}.txt", "professors", fileText: "", $"password:{secondWord}");

                    //to server professors upload
                    _ = handler.UploadFile("professors.json", "ProfessorsFolder");

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

        private void IAdminProfDeleteBut_Click(object sender, EventArgs e)
        {

            MicrosoftStorageHandler handler = new MicrosoftStorageHandler();
            string firstWord = IAdminProfTB.Text;
            Methods.RemoveProfessor(firstWord);

            //to server professors upload
            _ = handler.UploadFile("professors.json", "ProfessorsFolder");
            _ = handler.DeleteFile($"{firstWord}.txt", "professors");

            IAdminProfTB.Text = string.Empty;
            IAdminProfLB.Items.Clear();

            //from server professors download
            //            await handler.DownloadFile("professors.json", "ProfessorsFolder");
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
            try
            {
                File.Delete("schedule.csv");
            }
            catch (Removing ex)
            {
                MessageBox.Show($"schedule.csv не видалевся: {ex.Message}");
                return;
            }
            try
            {
                File.Delete("professors.json");
            }
            catch (Removing ex)
            {
                MessageBox.Show($"professors.json не видалевся: {ex.Message}");
                return;
            }
            try
            {
                File.Delete("students.csv");
            }
            catch (Removing ex)
            {
                MessageBox.Show($"students.csv не видалевся: {ex.Message}");
                return;
            }
            System.Windows.Forms.Application.Exit();
        }

        private void IAdminSchedLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
