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
            IStudLV.Dock = DockStyle.Fill;
            IStudLV.Location = new Point(0, 0);
            IStudLV.Name = "IStudLV";
            IStudLV.Size = new Size(878, 544);
            IStudLV.TabIndex = 0;
            IStudLV.UseCompatibleStateImageBehavior = false;
            IStudLV.ItemActivate += listView1_ItemActivate;
            IStudLV.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // IStudentForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(IStudLV);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IStudentForm1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Студент";
            FormClosing += IStudentForm1_FormClosing;
            Load += IStudentForm1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView IStudLV;
    }
}