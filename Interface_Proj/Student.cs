﻿using System;
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
    public partial class IStudentForm1 : Form
    {
        public IStudentForm1()
        {
            InitializeComponent();
        }

        private void IStudentForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IStudentForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
