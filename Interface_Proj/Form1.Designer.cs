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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IRegistrationForm1));
            IUserBut1 = new Button();
            IAdministranortBut1 = new Button();
            SuspendLayout();
            // 
            // IUserBut1
            // 
            IUserBut1.BackColor = Color.AntiqueWhite;
            IUserBut1.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            IUserBut1.FlatAppearance.BorderSize = 0;
            IUserBut1.FlatAppearance.MouseDownBackColor = Color.SandyBrown;
            IUserBut1.FlatAppearance.MouseOverBackColor = Color.NavajoWhite;
            IUserBut1.FlatStyle = FlatStyle.Flat;
            IUserBut1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            IUserBut1.ForeColor = Color.Black;
            IUserBut1.Location = new Point(258, 141);
            IUserBut1.Name = "IUserBut1";
            IUserBut1.Size = new Size(340, 80);
            IUserBut1.TabIndex = 1;
            IUserBut1.Text = "Викладач";
            IUserBut1.UseVisualStyleBackColor = false;
            IUserBut1.Click += IProfessorBut1_Click;
            // 
            // IAdministranortBut1
            // 
            IAdministranortBut1.BackColor = Color.AntiqueWhite;
            IAdministranortBut1.FlatAppearance.BorderSize = 0;
            IAdministranortBut1.FlatAppearance.MouseDownBackColor = Color.SandyBrown;
            IAdministranortBut1.FlatAppearance.MouseOverBackColor = Color.NavajoWhite;
            IAdministranortBut1.FlatStyle = FlatStyle.Flat;
            IAdministranortBut1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            IAdministranortBut1.ForeColor = Color.Black;
            IAdministranortBut1.Location = new Point(258, 301);
            IAdministranortBut1.Name = "IAdministranortBut1";
            IAdministranortBut1.Size = new Size(340, 80);
            IAdministranortBut1.TabIndex = 2;
            IAdministranortBut1.Text = "Адміністратор";
            IAdministranortBut1.UseVisualStyleBackColor = false;
            IAdministranortBut1.Click += button3_Click;
            // 
            // IRegistrationForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 544);
            Controls.Add(IUserBut1);
            Controls.Add(IAdministranortBut1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IRegistrationForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visit Control";
            FormClosing += IRegistrationForm1_FormClosing;
            ResumeLayout(false);
        }

        #endregion
        private Button IUserBut1;
        private Button IAdministranortBut1;
    }
}