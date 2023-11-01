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
            INameTB1 = new TextBox();
            IPasswordTB1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            IComeInBut1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // INameTB1
            // 
            INameTB1.Location = new Point(284, 121);
            INameTB1.Multiline = true;
            INameTB1.Name = "INameTB1";
            INameTB1.Size = new Size(287, 51);
            INameTB1.TabIndex = 0;
            // 
            // IPasswordTB1
            // 
            IPasswordTB1.Location = new Point(284, 293);
            IPasswordTB1.Multiline = true;
            IPasswordTB1.Name = "IPasswordTB1";
            IPasswordTB1.Size = new Size(287, 51);
            IPasswordTB1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 81);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 2;
            label1.Text = "Ім'я";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 253);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // IComeInBut1
            // 
            IComeInBut1.Location = new Point(301, 403);
            IComeInBut1.Name = "IComeInBut1";
            IComeInBut1.Size = new Size(238, 75);
            IComeInBut1.TabIndex = 4;
            IComeInBut1.Text = "Увійти";
            IComeInBut1.UseVisualStyleBackColor = true;
            IComeInBut1.Click += IComeInBut1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // IRegistrationForm2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(IComeInBut1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(IPasswordTB1);
            Controls.Add(INameTB1);
            Name = "IRegistrationForm2";
            Text = "Вхід";
            FormClosed += IRegistrationForm2_FormClosed;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox INameTB1;
        private TextBox IPasswordTB1;
        private Label label1;
        private Label label2;
        private Button IComeInBut1;
        private ErrorProvider errorProvider1;
    }
}