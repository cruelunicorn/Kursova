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
    public partial class IProfessorForm1 : Form
    {
        public IProfessorForm1()
        {
            InitializeComponent();
        }

        private void IProfessorForm1_Load(object sender, EventArgs e)
        {

        }

        private void IProfessorForm1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void IProfessorForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
