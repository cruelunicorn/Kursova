namespace Interface_Proj
{
    partial class IAdminRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IAdminRegistrationForm));
            IAdminRegistrationPassTB = new TextBox();
            panel = new Panel();
            pictureBox2 = new PictureBox();
            IAdminComeInBut = new Button();
            IRegistrationHelpBut = new Button();
            IAdminRegHelpTT = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // IAdminRegistrationPassTB
            // 
            IAdminRegistrationPassTB.BackColor = Color.White;
            IAdminRegistrationPassTB.BorderStyle = BorderStyle.None;
            IAdminRegistrationPassTB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IAdminRegistrationPassTB.ForeColor = Color.Black;
            IAdminRegistrationPassTB.Location = new Point(322, 164);
            IAdminRegistrationPassTB.Multiline = true;
            IAdminRegistrationPassTB.Name = "IAdminRegistrationPassTB";
            IAdminRegistrationPassTB.Size = new Size(242, 37);
            IAdminRegistrationPassTB.TabIndex = 0;
            IAdminRegistrationPassTB.Text = "Password";
            IAdminRegistrationPassTB.Click += IAdminRegistrationPassTB_Click;
            // 
            // panel
            // 
            panel.BackColor = Color.Black;
            panel.ForeColor = Color.Black;
            panel.Location = new Point(284, 200);
            panel.Name = "panel";
            panel.Size = new Size(283, 2);
            panel.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.pass;
            pictureBox2.Location = new Point(284, 156);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // IAdminComeInBut
            // 
            IAdminComeInBut.BackColor = Color.DodgerBlue;
            IAdminComeInBut.FlatAppearance.BorderColor = Color.Black;
            IAdminComeInBut.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            IAdminComeInBut.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            IAdminComeInBut.FlatStyle = FlatStyle.Flat;
            IAdminComeInBut.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IAdminComeInBut.Location = new Point(306, 325);
            IAdminComeInBut.Name = "IAdminComeInBut";
            IAdminComeInBut.Size = new Size(238, 75);
            IAdminComeInBut.TabIndex = 11;
            IAdminComeInBut.Text = "Увійти";
            IAdminComeInBut.UseVisualStyleBackColor = false;
            IAdminComeInBut.Click += IAdminComeInBut_Click;
            // 
            // IRegistrationHelpBut
            // 
            IRegistrationHelpBut.FlatAppearance.BorderColor = Color.White;
            IRegistrationHelpBut.FlatAppearance.BorderSize = 0;
            IRegistrationHelpBut.FlatAppearance.MouseDownBackColor = Color.White;
            IRegistrationHelpBut.FlatAppearance.MouseOverBackColor = Color.White;
            IRegistrationHelpBut.FlatStyle = FlatStyle.Flat;
            IRegistrationHelpBut.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            IRegistrationHelpBut.Location = new Point(12, 12);
            IRegistrationHelpBut.Name = "IRegistrationHelpBut";
            IRegistrationHelpBut.Size = new Size(35, 42);
            IRegistrationHelpBut.TabIndex = 12;
            IRegistrationHelpBut.Text = "?";
            IRegistrationHelpBut.UseVisualStyleBackColor = true;
            // 
            // IAdminRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 544);
            Controls.Add(IRegistrationHelpBut);
            Controls.Add(IAdminComeInBut);
            Controls.Add(pictureBox2);
            Controls.Add(panel);
            Controls.Add(IAdminRegistrationPassTB);
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IAdminRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visit Control";
            FormClosed += IAdminRegistrationForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IAdminRegistrationPassTB;
        private Panel panel;
        private PictureBox pictureBox2;
        private Button IAdminComeInBut;
        private Button IRegistrationHelpBut;
        private ToolTip IAdminRegHelpTT;
    }
}