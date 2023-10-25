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
            if (!string.IsNullOrEmpty(IAdminInfoTB.Text))
            {
                IAdminInfoLB.Items.Add(IAdminInfoTB.Text.Trim());
                IAdminInfoTB.Text = string.Empty;
            }
        }

        private void IAdminInfoDelete_Click(object sender, EventArgs e)
        {
            //Перевірка на наявність виділеного елемента
            //в IAdminInfoLB, видалення елемента
            if (IAdminInfoLB.SelectedItems != null)
            {
                IAdminInfoLB.Items.RemoveAt(IAdminInfoLB.SelectedIndex);
            }
        }

        private void IAdminInfoLB_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                IAdminInfoCMS.Show(IAdminInfoLB, e.Location);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IAdminInfoDelete_Click(null, null);
        }

        private void cleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IAdminInfoLB.Items.Clear();
        }

        private void IAdminInfoTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IAdminInfoAddBut_Click(null, null);
            }
        }
    }
}
