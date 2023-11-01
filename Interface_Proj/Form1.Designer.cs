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
            IUserBut1.Location = new Point(264, 108);
            IUserBut1.Name = "IUserBut1";
            IUserBut1.Size = new Size(338, 87);
            IUserBut1.TabIndex = 1;
            IUserBut1.Text = "Викладач";
            IUserBut1.UseVisualStyleBackColor = true;
            IUserBut1.Click += IProfessorBut1_Click;
            // 
            // IAdministranortBut1
            // 
            IAdministranortBut1.Location = new Point(264, 291);
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
            Controls.Add(IUserBut1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IRegistrationForm1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Вхід";
            FormClosing += IRegistrationForm1_FormClosing;
            ResumeLayout(false);
        }

        #endregion
        private Button IUserBut1;
        private Button IAdministranortBut1;
    }
}