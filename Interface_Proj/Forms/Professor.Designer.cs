namespace Interface_Proj
{
    partial class IProfessorForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IProfessorForm1));
            ISubjCB = new ComboBox();
            IProfDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)IProfDGV).BeginInit();
            SuspendLayout();
            // 
            // ISubjCB
            // 
            ISubjCB.BackColor = Color.AliceBlue;
            ISubjCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ISubjCB.Font = new Font("Kievit Offc Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ISubjCB.FormattingEnabled = true;
            ISubjCB.Location = new Point(2, 2);
            ISubjCB.Name = "ISubjCB";
            ISubjCB.Size = new Size(211, 32);
            ISubjCB.TabIndex = 1;
            // 
            // IProfDGV
            // 
            IProfDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Kievit Offc Pro", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            IProfDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            IProfDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IProfDGV.Location = new Point(7, 38);
            IProfDGV.Name = "IProfDGV";
            IProfDGV.RowHeadersWidth = 62;
            IProfDGV.RowTemplate.Height = 33;
            IProfDGV.Size = new Size(864, 500);
            IProfDGV.TabIndex = 2;
            // 
            // IProfessorForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 544);
            Controls.Add(IProfDGV);
            Controls.Add(ISubjCB);
            Font = new Font("Kievit Offc Pro", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IProfessorForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visit Control";
            FormClosing += IProfessorForm1_FormClosing;
            Load += IProfessorForm1_Load;
            ((System.ComponentModel.ISupportInitialize)IProfDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox ISubjCB;
        private DataGridView IProfDGV;
    }
}