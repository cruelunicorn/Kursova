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
    public partial class IAdminRegistrationForm : Form
    {
        public IAdminRegistrationForm()
        {
            InitializeComponent();

            IAdminRegHelpTT.SetToolTip(IRegistrationHelpBut, "Вам необхідно ввести Ваш пароль для входу");
        }

        private void IAdminRegistrationPassTB_Click(object sender, EventArgs e)
        {
            IAdminRegistrationPassTB.Clear();
            IAdminRegistrationPassTB.PasswordChar = '*';
            pictureBox2.BackgroundImage = Properties.Resources.pass2;
            panel.BackColor = Color.DodgerBlue;
            IAdminRegistrationPassTB.Font = new Font("Kievit Offc Pro", 12, FontStyle.Regular);
        }

        private void IAdminComeInBut_Click(object sender, EventArgs e)
        {
            if (IAdminRegistrationPassTB.Text == $"Admin{DateTime.Now:dd.MM}")
            {
                IAdminForm adminForm = new();
                Hide();
                adminForm.Show();
            }
            else
            {
                Close();
            }
        }

        private void IAdminRegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
