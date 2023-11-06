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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IAdministratorForm1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            IAdminSchedLB = new ListBox();
            IAdminSchedTB = new TextBox();
            IAdminAddSchedBut = new Button();
            IAdminDeleteSchedBut = new Button();
            tabPage2 = new TabPage();
            IAdminInfoStudTLP = new TableLayoutPanel();
            IAdminInfoAddStudBut = new Button();
            IAdminInfoStudTB = new TextBox();
            IAdminInfoStudGenTB = new TextBox();
            IAdminInfoGenerateStudBut = new Button();
            IAdminInfoDeleteStudBut = new Button();
            IAdminInfoStudLB = new ListBox();
            tabPage3 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            IAdminProfLB = new ListBox();
            IAdminProfTB = new TextBox();
            IAdminProfGenBut = new Button();
            IAdminProfAddBut = new Button();
            IAdminProfDeleteBut = new Button();
            IAdminInfoCMS = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabPage2.SuspendLayout();
            IAdminInfoStudTLP.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            IAdminInfoCMS.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 1);
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(702, 434);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(694, 401);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Розклад";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel2.Controls.Add(IAdminSchedLB, 0, 2);
            tableLayoutPanel2.Controls.Add(IAdminSchedTB, 0, 0);
            tableLayoutPanel2.Controls.Add(IAdminAddSchedBut, 3, 0);
            tableLayoutPanel2.Controls.Add(IAdminDeleteSchedBut, 3, 1);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 172F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel2.Size = new Size(693, 401);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // IAdminSchedLB
            // 
            tableLayoutPanel2.SetColumnSpan(IAdminSchedLB, 4);
            IAdminSchedLB.Dock = DockStyle.Fill;
            IAdminSchedLB.FormattingEnabled = true;
            IAdminSchedLB.ItemHeight = 20;
            IAdminSchedLB.Location = new Point(2, 86);
            IAdminSchedLB.Margin = new Padding(2, 2, 2, 2);
            IAdminSchedLB.Name = "IAdminSchedLB";
            tableLayoutPanel2.SetRowSpan(IAdminSchedLB, 3);
            IAdminSchedLB.Size = new Size(689, 313);
            IAdminSchedLB.TabIndex = 0;
            // 
            // IAdminSchedTB
            // 
            tableLayoutPanel2.SetColumnSpan(IAdminSchedTB, 3);
            IAdminSchedTB.Dock = DockStyle.Fill;
            IAdminSchedTB.Location = new Point(2, 2);
            IAdminSchedTB.Margin = new Padding(2, 2, 2, 2);
            IAdminSchedTB.Multiline = true;
            IAdminSchedTB.Name = "IAdminSchedTB";
            IAdminSchedTB.Size = new Size(584, 38);
            IAdminSchedTB.TabIndex = 1;
            // 
            // IAdminAddSchedBut
            // 
            IAdminAddSchedBut.Dock = DockStyle.Fill;
            IAdminAddSchedBut.Location = new Point(590, 2);
            IAdminAddSchedBut.Margin = new Padding(2, 2, 2, 2);
            IAdminAddSchedBut.Name = "IAdminAddSchedBut";
            IAdminAddSchedBut.Size = new Size(101, 38);
            IAdminAddSchedBut.TabIndex = 2;
            IAdminAddSchedBut.Text = "Додати";
            IAdminAddSchedBut.UseVisualStyleBackColor = true;
            IAdminAddSchedBut.Click += IAdminAddSchedBut_Click;
            // 
            // IAdminDeleteSchedBut
            // 
            IAdminDeleteSchedBut.Dock = DockStyle.Fill;
            IAdminDeleteSchedBut.Location = new Point(590, 44);
            IAdminDeleteSchedBut.Margin = new Padding(2, 2, 2, 2);
            IAdminDeleteSchedBut.Name = "IAdminDeleteSchedBut";
            IAdminDeleteSchedBut.Size = new Size(101, 38);
            IAdminDeleteSchedBut.TabIndex = 3;
            IAdminDeleteSchedBut.Text = "Видалити";
            IAdminDeleteSchedBut.UseVisualStyleBackColor = true;
            IAdminDeleteSchedBut.Click += IAdminDeleteSchedBut_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(IAdminInfoStudTLP);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(694, 401);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Студенти";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // IAdminInfoStudTLP
            // 
            IAdminInfoStudTLP.ColumnCount = 4;
            IAdminInfoStudTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            IAdminInfoStudTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            IAdminInfoStudTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 271F));
            IAdminInfoStudTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            IAdminInfoStudTLP.Controls.Add(IAdminInfoAddStudBut, 3, 1);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoStudTB, 0, 1);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoStudGenTB, 0, 0);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoGenerateStudBut, 3, 0);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoDeleteStudBut, 3, 2);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoStudLB, 0, 3);
            IAdminInfoStudTLP.Location = new Point(2, 2);
            IAdminInfoStudTLP.Margin = new Padding(2, 2, 2, 2);
            IAdminInfoStudTLP.Name = "IAdminInfoStudTLP";
            IAdminInfoStudTLP.RowCount = 6;
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 144F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            IAdminInfoStudTLP.Size = new Size(693, 401);
            IAdminInfoStudTLP.TabIndex = 0;
            // 
            // IAdminInfoAddStudBut
            // 
            IAdminInfoAddStudBut.Dock = DockStyle.Fill;
            IAdminInfoAddStudBut.Location = new Point(589, 43);
            IAdminInfoAddStudBut.Margin = new Padding(2, 2, 2, 2);
            IAdminInfoAddStudBut.Name = "IAdminInfoAddStudBut";
            IAdminInfoAddStudBut.Size = new Size(102, 37);
            IAdminInfoAddStudBut.TabIndex = 1;
            IAdminInfoAddStudBut.Text = "Додати";
            IAdminInfoAddStudBut.UseVisualStyleBackColor = true;
            IAdminInfoAddStudBut.Click += IAdminInfoAddBut_Click;
            // 
            // IAdminInfoStudTB
            // 
            IAdminInfoStudTLP.SetColumnSpan(IAdminInfoStudTB, 3);
            IAdminInfoStudTB.Dock = DockStyle.Fill;
            IAdminInfoStudTB.Location = new Point(2, 43);
            IAdminInfoStudTB.Margin = new Padding(2, 2, 2, 2);
            IAdminInfoStudTB.Multiline = true;
            IAdminInfoStudTB.Name = "IAdminInfoStudTB";
            IAdminInfoStudTB.Size = new Size(583, 37);
            IAdminInfoStudTB.TabIndex = 0;
            IAdminInfoStudTB.KeyUp += IAdminInfoTB_KeyUp;
            // 
            // IAdminInfoStudGenTB
            // 
            IAdminInfoStudTLP.SetColumnSpan(IAdminInfoStudGenTB, 3);
            IAdminInfoStudGenTB.Dock = DockStyle.Fill;
            IAdminInfoStudGenTB.Location = new Point(2, 2);
            IAdminInfoStudGenTB.Margin = new Padding(2, 2, 2, 2);
            IAdminInfoStudGenTB.Multiline = true;
            IAdminInfoStudGenTB.Name = "IAdminInfoStudGenTB";
            IAdminInfoStudGenTB.Size = new Size(583, 37);
            IAdminInfoStudGenTB.TabIndex = 5;
            // 
            // IAdminInfoGenerateStudBut
            // 
            IAdminInfoGenerateStudBut.Dock = DockStyle.Fill;
            IAdminInfoGenerateStudBut.Location = new Point(589, 2);
            IAdminInfoGenerateStudBut.Margin = new Padding(2, 2, 2, 2);
            IAdminInfoGenerateStudBut.Name = "IAdminInfoGenerateStudBut";
            IAdminInfoGenerateStudBut.Size = new Size(102, 37);
            IAdminInfoGenerateStudBut.TabIndex = 4;
            IAdminInfoGenerateStudBut.Text = "Сгенерувати";
            IAdminInfoGenerateStudBut.UseVisualStyleBackColor = true;
            IAdminInfoGenerateStudBut.Click += IAdminInfoGenerateStudBut_Click;
            // 
            // IAdminInfoDeleteStudBut
            // 
            IAdminInfoDeleteStudBut.Dock = DockStyle.Fill;
            IAdminInfoDeleteStudBut.Location = new Point(589, 84);
            IAdminInfoDeleteStudBut.Margin = new Padding(2, 2, 2, 2);
            IAdminInfoDeleteStudBut.Name = "IAdminInfoDeleteStudBut";
            IAdminInfoDeleteStudBut.Size = new Size(102, 38);
            IAdminInfoDeleteStudBut.TabIndex = 2;
            IAdminInfoDeleteStudBut.Text = "Видалити";
            IAdminInfoDeleteStudBut.UseVisualStyleBackColor = true;
            IAdminInfoDeleteStudBut.Click += IAdminInfoDelete_Click;
            // 
            // IAdminInfoStudLB
            // 
            IAdminInfoStudTLP.SetColumnSpan(IAdminInfoStudLB, 4);
            IAdminInfoStudLB.Dock = DockStyle.Fill;
            IAdminInfoStudLB.FormattingEnabled = true;
            IAdminInfoStudLB.ItemHeight = 20;
            IAdminInfoStudLB.Location = new Point(2, 126);
            IAdminInfoStudLB.Margin = new Padding(2, 2, 2, 2);
            IAdminInfoStudLB.Name = "IAdminInfoStudLB";
            IAdminInfoStudTLP.SetRowSpan(IAdminInfoStudLB, 3);
            IAdminInfoStudLB.Size = new Size(689, 273);
            IAdminInfoStudLB.TabIndex = 3;
            IAdminInfoStudLB.SelectedIndexChanged += IAdminInfoStudLB_SelectedIndexChanged;
            IAdminInfoStudLB.MouseUp += IAdminInfoLB_MouseUp;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(2, 2, 2, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2, 2, 2, 2);
            tabPage3.Size = new Size(694, 401);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Викладачі";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.42475F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.57525F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107F));
            tableLayoutPanel1.Controls.Add(IAdminProfLB, 0, 0);
            tableLayoutPanel1.Controls.Add(IAdminProfTB, 1, 0);
            tableLayoutPanel1.Controls.Add(IAdminProfGenBut, 1, 1);
            tableLayoutPanel1.Controls.Add(IAdminProfAddBut, 2, 1);
            tableLayoutPanel1.Controls.Add(IAdminProfDeleteBut, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.0392151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.9607849F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 319F));
            tableLayoutPanel1.Size = new Size(690, 401);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // IAdminProfLB
            // 
            IAdminProfLB.Dock = DockStyle.Fill;
            IAdminProfLB.FormattingEnabled = true;
            IAdminProfLB.ItemHeight = 20;
            IAdminProfLB.Location = new Point(2, 2);
            IAdminProfLB.Margin = new Padding(2, 2, 2, 2);
            IAdminProfLB.Name = "IAdminProfLB";
            tableLayoutPanel1.SetRowSpan(IAdminProfLB, 3);
            IAdminProfLB.Size = new Size(363, 397);
            IAdminProfLB.TabIndex = 0;
            // 
            // IAdminProfTB
            // 
            tableLayoutPanel1.SetColumnSpan(IAdminProfTB, 3);
            IAdminProfTB.Dock = DockStyle.Fill;
            IAdminProfTB.Location = new Point(369, 2);
            IAdminProfTB.Margin = new Padding(2, 2, 2, 2);
            IAdminProfTB.Multiline = true;
            IAdminProfTB.Name = "IAdminProfTB";
            IAdminProfTB.Size = new Size(319, 35);
            IAdminProfTB.TabIndex = 1;
            // 
            // IAdminProfGenBut
            // 
            IAdminProfGenBut.Dock = DockStyle.Fill;
            IAdminProfGenBut.Location = new Point(369, 41);
            IAdminProfGenBut.Margin = new Padding(2, 2, 2, 2);
            IAdminProfGenBut.Name = "IAdminProfGenBut";
            IAdminProfGenBut.Size = new Size(103, 38);
            IAdminProfGenBut.TabIndex = 2;
            IAdminProfGenBut.Text = "Сгенерувати";
            IAdminProfGenBut.UseVisualStyleBackColor = true;
            IAdminProfGenBut.Click += IAdminProfGenBut_Click;
            // 
            // IAdminProfAddBut
            // 
            IAdminProfAddBut.Dock = DockStyle.Fill;
            IAdminProfAddBut.Location = new Point(476, 41);
            IAdminProfAddBut.Margin = new Padding(2, 2, 2, 2);
            IAdminProfAddBut.Name = "IAdminProfAddBut";
            IAdminProfAddBut.Size = new Size(104, 38);
            IAdminProfAddBut.TabIndex = 3;
            IAdminProfAddBut.Text = "Додати";
            IAdminProfAddBut.UseVisualStyleBackColor = true;
            IAdminProfAddBut.Click += IAdminProfAddBut_Click;
            // 
            // IAdminProfDeleteBut
            // 
            IAdminProfDeleteBut.Dock = DockStyle.Fill;
            IAdminProfDeleteBut.Location = new Point(584, 41);
            IAdminProfDeleteBut.Margin = new Padding(2, 2, 2, 2);
            IAdminProfDeleteBut.Name = "IAdminProfDeleteBut";
            IAdminProfDeleteBut.Size = new Size(104, 38);
            IAdminProfDeleteBut.TabIndex = 4;
            IAdminProfDeleteBut.Text = "Видалити";
            IAdminProfDeleteBut.UseVisualStyleBackColor = true;
            IAdminProfDeleteBut.Click += IAdminProfDeleteBut_Click;
            // 
            // IAdminInfoCMS
            // 
            IAdminInfoCMS.ImageScalingSize = new Size(24, 24);
            IAdminInfoCMS.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            IAdminInfoCMS.Name = "IAdminInfoCMS";
            IAdminInfoCMS.Size = new Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // IAdministratorForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 435);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "IAdministratorForm1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Адміністратор";
            FormClosing += IAdministratorForm1_FormClosing;
            Load += IAdministratorForm1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            IAdminInfoStudTLP.ResumeLayout(false);
            IAdminInfoStudTLP.PerformLayout();
            tabPage3.ResumeLayout(false);
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
        private TableLayoutPanel IAdminInfoStudTLP;
        private TextBox IAdminInfoStudTB;
        private Button IAdminInfoAddStudBut;
        private Button IAdminInfoDeleteStudBut;
        private ListBox IAdminInfoStudLB;
        private ContextMenuStrip IAdminInfoCMS;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel2;
        private Button IAdminInfoGenerateStudBut;
        private TextBox IAdminInfoStudGenTB;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox IAdminSchedLB;
        private TextBox IAdminSchedTB;
        private Button IAdminAddSchedBut;
        private Button IAdminDeleteSchedBut;
        private ListBox IAdminProfLB;
        private TextBox IAdminProfTB;
        private Button IAdminProfGenBut;
        private Button IAdminProfAddBut;
        private Button IAdminProfDeleteBut;
    }
}