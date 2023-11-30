namespace Interface_Proj
{
    partial class IStudentForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IStudentForm1));
            IStudLV = new ListView();
            SuspendLayout();
            // 
            // IStudLV
            // 
            IStudLV.BackColor = Color.White;
            IStudLV.Dock = DockStyle.Fill;
            IStudLV.ForeColor = Color.Black;
            IStudLV.Location = new Point(0, 0);
            IStudLV.Margin = new Padding(2, 2, 2, 2);
            IStudLV.Name = "IStudLV";
            IStudLV.Size = new Size(702, 435);
            IStudLV.TabIndex = 0;
            IStudLV.UseCompatibleStateImageBehavior = false;
            // 
            // IStudentForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(702, 435);
            Controls.Add(IStudLV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "IStudentForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visit Control";
            FormClosing += IStudentForm1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private ListView IStudLV;
    }
}