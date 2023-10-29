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
            if (IAdminInfoStudTB.Text != "" & IAdminInfoStudGenTB != "")
            {
                newtext = IAdminInfoStudTB.Text + IAdminInfoStudGenTB;
            }
            Methods.AddStudent();

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
            //HashTable passwordGenerator = new HashTable();

            //string username = GenerateUsername();
            //string password = GeneratePassword();

            // Вивести результат в TextBox
            //IAdminInfoStudGenTB.Text = $"{username}; {password}";
        }

        private void IAdminInfoStudLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IAdministratorForm1_Load(object sender, EventArgs e)
        {
            //bindingSource1.DataSource = 
        }
    }
}
