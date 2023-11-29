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
    public partial class ICreatorsForm : Form
    {
        public ICreatorsForm()
        {
            InitializeComponent();

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;

            textBox1.TabStop = false;
            textBox2.TabStop = false;
            textBox3.TabStop = false;
            textBox4.TabStop = false;
            textBox5.TabStop = false;
            textBox6.TabStop = false;
            textBox7.TabStop = false;
            textBox8.TabStop = false;
            textBox9.TabStop = false;
            textBox10.TabStop = false;
        }

        private void ICreatorsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IRegistrationForm1 form1 = new IRegistrationForm1();
            this.Hide();
            form1.Show();
        }
    }
}
