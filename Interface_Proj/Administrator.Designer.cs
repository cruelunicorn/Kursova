namespace Interface_Proj
{
    partial class IAdministratorForm1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            IAdminInfoTB = new TextBox();
            IAdminInfoAddBut = new Button();
            IAdminInfoDelete = new Button();
            IAdminInfoLB = new ListBox();
            tabPage3 = new TabPage();
            IAdminInfoCMS = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            cleanToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel2 = new TableLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            IAdminInfoCMS.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(880, 543);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(872, 505);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(872, 505);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 339F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            tableLayoutPanel1.Controls.Add(IAdminInfoTB, 0, 0);
            tableLayoutPanel1.Controls.Add(IAdminInfoAddBut, 3, 0);
            tableLayoutPanel1.Controls.Add(IAdminInfoDelete, 3, 1);
            tableLayoutPanel1.Controls.Add(IAdminInfoLB, 0, 2);
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 249F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tableLayoutPanel1.Size = new Size(866, 501);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // IAdminInfoTB
            // 
            tableLayoutPanel1.SetColumnSpan(IAdminInfoTB, 3);
            IAdminInfoTB.Dock = DockStyle.Fill;
            IAdminInfoTB.Location = new Point(3, 3);
            IAdminInfoTB.Multiline = true;
            IAdminInfoTB.Name = "IAdminInfoTB";
            IAdminInfoTB.Size = new Size(729, 43);
            IAdminInfoTB.TabIndex = 0;
            IAdminInfoTB.KeyUp += IAdminInfoTB_KeyUp;
            // 
            // IAdminInfoAddBut
            // 
            IAdminInfoAddBut.Dock = DockStyle.Fill;
            IAdminInfoAddBut.Location = new Point(738, 3);
            IAdminInfoAddBut.Name = "IAdminInfoAddBut";
            IAdminInfoAddBut.Size = new Size(125, 43);
            IAdminInfoAddBut.TabIndex = 1;
            IAdminInfoAddBut.Text = "Додати";
            IAdminInfoAddBut.UseVisualStyleBackColor = true;
            IAdminInfoAddBut.Click += IAdminInfoAddBut_Click;
            // 
            // IAdminInfoDelete
            // 
            IAdminInfoDelete.Dock = DockStyle.Fill;
            IAdminInfoDelete.Location = new Point(738, 52);
            IAdminInfoDelete.Name = "IAdminInfoDelete";
            IAdminInfoDelete.Size = new Size(125, 43);
            IAdminInfoDelete.TabIndex = 2;
            IAdminInfoDelete.Text = "Видалити";
            IAdminInfoDelete.UseVisualStyleBackColor = true;
            IAdminInfoDelete.Click += IAdminInfoDelete_Click;
            // 
            // IAdminInfoLB
            // 
            tableLayoutPanel1.SetColumnSpan(IAdminInfoLB, 4);
            IAdminInfoLB.Dock = DockStyle.Fill;
            IAdminInfoLB.FormattingEnabled = true;
            IAdminInfoLB.ItemHeight = 25;
            IAdminInfoLB.Location = new Point(3, 101);
            IAdminInfoLB.Name = "IAdminInfoLB";
            tableLayoutPanel1.SetRowSpan(IAdminInfoLB, 3);
            IAdminInfoLB.Size = new Size(860, 397);
            IAdminInfoLB.TabIndex = 3;
            IAdminInfoLB.MouseUp += IAdminInfoLB_MouseUp;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(872, 505);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // IAdminInfoCMS
            // 
            IAdminInfoCMS.ImageScalingSize = new Size(24, 24);
            IAdminInfoCMS.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, cleanToolStripMenuItem });
            IAdminInfoCMS.Name = "IAdminInfoCMS";
            IAdminInfoCMS.Size = new Size(135, 68);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(134, 32);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // cleanToolStripMenuItem
            // 
            cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            cleanToolStripMenuItem.Size = new Size(134, 32);
            cleanToolStripMenuItem.Text = "Clean";
            cleanToolStripMenuItem.Click += cleanToolStripMenuItem_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 172F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 168F));
            tableLayoutPanel2.Location = new Point(4, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel2.Size = new Size(866, 498);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // IAdministratorForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(tabControl1);
            Name = "IAdministratorForm1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Адміністратор";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            IAdminInfoCMS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox IAdminInfoTB;
        private Button IAdminInfoAddBut;
        private Button IAdminInfoDelete;
        private ListBox IAdminInfoLB;
        private ContextMenuStrip IAdminInfoCMS;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem cleanToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel2;
    }
}