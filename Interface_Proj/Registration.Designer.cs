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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // INameTB1
            // 
            INameTB1.BackColor = Color.White;
            INameTB1.BorderStyle = BorderStyle.None;
            INameTB1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            INameTB1.ForeColor = Color.Black;
            INameTB1.Location = new Point(335, 126);
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
            IPasswordTB1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            IPasswordTB1.Location = new Point(335, 241);
            IPasswordTB1.Multiline = true;
            IPasswordTB1.Name = "IPasswordTB1";
            IPasswordTB1.Size = new Size(242, 35);
            IPasswordTB1.TabIndex = 1;
            IPasswordTB1.Text = "Password";
            IPasswordTB1.Click += IPasswordTB1_Click;
            // 
            // IComeInBut1
            // 
            IComeInBut1.BackColor = Color.AntiqueWhite;
            IComeInBut1.FlatAppearance.BorderSize = 0;
            IComeInBut1.FlatAppearance.MouseDownBackColor = Color.SandyBrown;
            IComeInBut1.FlatAppearance.MouseOverBackColor = Color.NavajoWhite;
            IComeInBut1.FlatStyle = FlatStyle.Flat;
            IComeInBut1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
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
            pictureBox2.Location = new Point(294, 232);
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
            // IRegistrationForm2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 544);
            Controls.Add(panelP);
            Controls.Add(panelN);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(IComeInBut1);
            Controls.Add(IPasswordTB1);
            Controls.Add(INameTB1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IRegistrationForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visit Control";
            FormClosing += IRegistrationForm2_FormClosing;
            FormClosed += IRegistrationForm2_FormClosed;
            Load += IRegistrationForm2_Load;
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
    }
}