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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IProfessorForm1));
            ISubjCB = new ComboBox();
            IProfDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)IProfDGV).BeginInit();
            SuspendLayout();
            // 
            // ISubjCB
            // 
            ISubjCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ISubjCB.FormattingEnabled = true;
            ISubjCB.Location = new Point(2, 2);
            ISubjCB.Name = "ISubjCB";
            ISubjCB.Size = new Size(211, 33);
            ISubjCB.TabIndex = 1;
            // 
            // IProfDGV
            // 
            IProfDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IProfDGV.Location = new Point(7, 43);
            IProfDGV.Name = "IProfDGV";
            IProfDGV.RowHeadersWidth = 62;
            IProfDGV.RowTemplate.Height = 33;
            IProfDGV.Size = new Size(864, 496);
            IProfDGV.TabIndex = 2;
            // 
            // IProfessorForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(IProfDGV);
            Controls.Add(ISubjCB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IProfessorForm1";
            Text = "Professor";
            FormClosing += IProfessorForm1_FormClosing;
            FormClosed += IProfessorForm1_FormClosed;
            Load += IProfessorForm1_Load;
            ((System.ComponentModel.ISupportInitialize)IProfDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox ISubjCB;
        private DataGridView IProfDGV;
    }
}