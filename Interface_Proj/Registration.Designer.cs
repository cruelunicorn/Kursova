namespace Interface_Proj
{
    partial class IRegistrationForm2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IRegistrationForm2));
            INameTB1 = new TextBox();
            IPasswordTB1 = new TextBox();
            IComeInBut1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panelN = new Panel();
            panelP = new Panel();
            IRegistrationHelpBut = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // INameTB1
            // 
            INameTB1.BackColor = Color.White;
            INameTB1.BorderStyle = BorderStyle.None;
            INameTB1.Font = new Font("Kievit Offc Pro", 12F, FontStyle.Bold, GraphicsUnit.Point);
            INameTB1.ForeColor = Color.Black;
            INameTB1.Location = new Point(335, 124);
            INameTB1.Multiline = true;
            INameTB1.Name = "INameTB1";
            INameTB1.Size = new Size(242, 35);
            INameTB1.TabIndex = 0;
            INameTB1.Text = "Username";
            INameTB1.Click += INameTB1_Click;
            // 
            // IPasswordTB1
            // 
            IPasswordTB1.BackColor = Color.White;
            IPasswordTB1.BorderStyle = BorderStyle.None;
            IPasswordTB1.Font = new Font("Kievit Offc Pro", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IPasswordTB1.Location = new Point(335, 244);
            IPasswordTB1.Multiline = true;
            IPasswordTB1.Name = "IPasswordTB1";
            IPasswordTB1.Size = new Size(242, 35);
            IPasswordTB1.TabIndex = 1;
            IPasswordTB1.Text = "Password";
            IPasswordTB1.Click += IPasswordTB1_Click;
            // 
            // IComeInBut1
            // 
            IComeInBut1.BackColor = Color.DodgerBlue;
            IComeInBut1.FlatAppearance.BorderColor = Color.Black;
            IComeInBut1.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            IComeInBut1.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            IComeInBut1.FlatStyle = FlatStyle.Flat;
            IComeInBut1.Font = new Font("Kievit Offc Pro", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IComeInBut1.ForeColor = Color.Black;
            IComeInBut1.Location = new Point(320, 372);
            IComeInBut1.Name = "IComeInBut1";
            IComeInBut1.Size = new Size(238, 75);
            IComeInBut1.TabIndex = 4;
            IComeInBut1.Text = "Увійти";
            IComeInBut1.UseVisualStyleBackColor = false;
            IComeInBut1.Click += IComeInBut1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.user;
            pictureBox1.Location = new Point(294, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.pass;
            pictureBox2.Location = new Point(294, 237);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panelN
            // 
            panelN.BackColor = Color.Black;
            panelN.ForeColor = Color.Black;
            panelN.Location = new Point(294, 160);
            panelN.Name = "panelN";
            panelN.Size = new Size(283, 2);
            panelN.TabIndex = 7;
            // 
            // panelP
            // 
            panelP.BackColor = Color.Black;
            panelP.Location = new Point(294, 280);
            panelP.Name = "panelP";
            panelP.Size = new Size(283, 2);
            panelP.TabIndex = 8;
            // 
            // IRegistrationHelpBut
            // 
            IRegistrationHelpBut.FlatAppearance.BorderColor = Color.White;
            IRegistrationHelpBut.FlatAppearance.BorderSize = 0;
            IRegistrationHelpBut.FlatAppearance.MouseDownBackColor = Color.White;
            IRegistrationHelpBut.FlatAppearance.MouseOverBackColor = Color.White;
            IRegistrationHelpBut.FlatStyle = FlatStyle.Flat;
            IRegistrationHelpBut.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            IRegistrationHelpBut.Location = new Point(17, 12);
            IRegistrationHelpBut.Name = "IRegistrationHelpBut";
            IRegistrationHelpBut.Size = new Size(35, 42);
            IRegistrationHelpBut.TabIndex = 9;
            IRegistrationHelpBut.Text = "?";
            IRegistrationHelpBut.UseVisualStyleBackColor = true;
            // 
            // IRegistrationForm2
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(878, 544);
            Controls.Add(IRegistrationHelpBut);
            Controls.Add(panelP);
            Controls.Add(panelN);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(IComeInBut1);
            Controls.Add(IPasswordTB1);
            Controls.Add(INameTB1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IRegistrationForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visit Control";
            FormClosing += IRegistrationForm2_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox INameTB1;
        private TextBox IPasswordTB1;
        private Button IComeInBut1;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panelN;
        private Panel panelP;
        private Button IRegistrationHelpBut;
        private ToolTip toolTip1;
    }
}