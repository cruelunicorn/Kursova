namespace Interface_Proj
{
    partial class IRegistrationForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IStudentBut1 = new Button();
            IProfessorBut1 = new Button();
            IAdministranortBut1 = new Button();
            SuspendLayout();
            // 
            // IStudentBut1
            // 
            IStudentBut1.Location = new Point(284, 76);
            IStudentBut1.Name = "IStudentBut1";
            IStudentBut1.Size = new Size(338, 87);
            IStudentBut1.TabIndex = 0;
            IStudentBut1.Text = "Студент";
            IStudentBut1.UseVisualStyleBackColor = true;
            IStudentBut1.Click += IStudentBut1_Click;
            // 
            // IProfessorBut1
            // 
            IProfessorBut1.Location = new Point(284, 231);
            IProfessorBut1.Name = "IProfessorBut1";
            IProfessorBut1.Size = new Size(338, 87);
            IProfessorBut1.TabIndex = 1;
            IProfessorBut1.Text = "Викладач";
            IProfessorBut1.UseVisualStyleBackColor = true;
            IProfessorBut1.Click += IProfessorBut1_Click;
            // 
            // IAdministranortBut1
            // 
            IAdministranortBut1.Location = new Point(284, 384);
            IAdministranortBut1.Name = "IAdministranortBut1";
            IAdministranortBut1.Size = new Size(338, 87);
            IAdministranortBut1.TabIndex = 2;
            IAdministranortBut1.Text = "Адміністратор";
            IAdministranortBut1.UseVisualStyleBackColor = true;
            IAdministranortBut1.Click += button3_Click;
            // 
            // IRegistrationForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(IAdministranortBut1);
            Controls.Add(IProfessorBut1);
            Controls.Add(IStudentBut1);
            Name = "IRegistrationForm1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Вхід";
            ResumeLayout(false);
        }

        #endregion

        private Button IStudentBut1;
        private Button IProfessorBut1;
        private Button IAdministranortBut1;
    }
}