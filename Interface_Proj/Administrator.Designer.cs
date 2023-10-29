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
            tableLayoutPanel2 = new TableLayoutPanel();
            tabPage2 = new TabPage();
            IAdminInfoStudTLP = new TableLayoutPanel();
            IAdminInfoAddStudBut = new Button();
            IAdminInfoStudTB = new TextBox();
            IAdminInfoStudGenTB = new TextBox();
            IAdminInfoGenerateStudBut = new Button();
            IAdminInfoStudLB = new ListBox();
            methodsBindingSource = new BindingSource(components);
            IAdminInfoDeleteStudBut = new Button();
            tabPage3 = new TabPage();
            IAdminInfoCMS = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            cleanToolStripMenuItem = new ToolStripMenuItem();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            IAdminInfoStudTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)methodsBindingSource).BeginInit();
            IAdminInfoCMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
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
            // tabPage2
            // 
            tabPage2.Controls.Add(IAdminInfoStudTLP);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(872, 505);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // IAdminInfoStudTLP
            // 
            IAdminInfoStudTLP.ColumnCount = 6;
            IAdminInfoStudTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            IAdminInfoStudTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            IAdminInfoStudTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 339F));
            IAdminInfoStudTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            IAdminInfoStudTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            IAdminInfoStudTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            IAdminInfoStudTLP.Controls.Add(IAdminInfoAddStudBut, 3, 1);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoStudTB, 0, 1);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoStudGenTB, 0, 0);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoGenerateStudBut, 3, 0);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoStudLB, 0, 5);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoDeleteStudBut, 3, 2);
            IAdminInfoStudTLP.Location = new Point(3, 2);
            IAdminInfoStudTLP.Name = "IAdminInfoStudTLP";
            IAdminInfoStudTLP.RowCount = 6;
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 299F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            IAdminInfoStudTLP.Size = new Size(866, 501);
            IAdminInfoStudTLP.TabIndex = 0;
            // 
            // IAdminInfoAddStudBut
            // 
            IAdminInfoAddStudBut.Dock = DockStyle.Fill;
            IAdminInfoAddStudBut.Location = new Point(698, 49);
            IAdminInfoAddStudBut.Name = "IAdminInfoAddStudBut";
            IAdminInfoAddStudBut.Size = new Size(125, 40);
            IAdminInfoAddStudBut.TabIndex = 1;
            IAdminInfoAddStudBut.Text = "Додати";
            IAdminInfoAddStudBut.UseVisualStyleBackColor = true;
            IAdminInfoAddStudBut.Click += IAdminInfoAddBut_Click;
            // 
            // IAdminInfoStudTB
            // 
            IAdminInfoStudTLP.SetColumnSpan(IAdminInfoStudTB, 3);
            IAdminInfoStudTB.Dock = DockStyle.Fill;
            IAdminInfoStudTB.Location = new Point(3, 49);
            IAdminInfoStudTB.Multiline = true;
            IAdminInfoStudTB.Name = "IAdminInfoStudTB";
            IAdminInfoStudTB.Size = new Size(689, 40);
            IAdminInfoStudTB.TabIndex = 0;
            IAdminInfoStudTB.KeyUp += IAdminInfoTB_KeyUp;
            // 
            // IAdminInfoStudGenTB
            // 
            IAdminInfoStudTLP.SetColumnSpan(IAdminInfoStudGenTB, 3);
            IAdminInfoStudGenTB.Dock = DockStyle.Fill;
            IAdminInfoStudGenTB.Location = new Point(3, 3);
            IAdminInfoStudGenTB.Multiline = true;
            IAdminInfoStudGenTB.Name = "IAdminInfoStudGenTB";
            IAdminInfoStudGenTB.Size = new Size(689, 40);
            IAdminInfoStudGenTB.TabIndex = 5;
            // 
            // IAdminInfoGenerateStudBut
            // 
            IAdminInfoGenerateStudBut.Dock = DockStyle.Fill;
            IAdminInfoGenerateStudBut.Location = new Point(698, 3);
            IAdminInfoGenerateStudBut.Name = "IAdminInfoGenerateStudBut";
            IAdminInfoGenerateStudBut.Size = new Size(125, 40);
            IAdminInfoGenerateStudBut.TabIndex = 4;
            IAdminInfoGenerateStudBut.Text = "Сгенерувати";
            IAdminInfoGenerateStudBut.UseVisualStyleBackColor = true;
            IAdminInfoGenerateStudBut.Click += IAdminInfoGenerateStudBut_Click;
            // 
            // IAdminInfoStudLB
            // 
            IAdminInfoStudTLP.SetColumnSpan(IAdminInfoStudLB, 4);
            IAdminInfoStudLB.DataSource = methodsBindingSource;
            IAdminInfoStudLB.Dock = DockStyle.Fill;
            IAdminInfoStudLB.FormattingEnabled = true;
            IAdminInfoStudLB.ItemHeight = 25;
            IAdminInfoStudLB.Location = new Point(3, 162);
            IAdminInfoStudLB.Name = "IAdminInfoStudLB";
            IAdminInfoStudTLP.SetRowSpan(IAdminInfoStudLB, 3);
            IAdminInfoStudLB.Size = new Size(820, 336);
            IAdminInfoStudLB.TabIndex = 3;
            IAdminInfoStudLB.SelectedIndexChanged += IAdminInfoStudLB_SelectedIndexChanged;
            IAdminInfoStudLB.MouseUp += IAdminInfoLB_MouseUp;
            // 
            // methodsBindingSource
            // 
            methodsBindingSource.DataSource = typeof(Methods);
            // 
            // IAdminInfoDeleteStudBut
            // 
            IAdminInfoDeleteStudBut.Dock = DockStyle.Fill;
            IAdminInfoDeleteStudBut.Location = new Point(698, 95);
            IAdminInfoDeleteStudBut.Name = "IAdminInfoDeleteStudBut";
            IAdminInfoDeleteStudBut.Size = new Size(125, 42);
            IAdminInfoDeleteStudBut.TabIndex = 2;
            IAdminInfoDeleteStudBut.Text = "Видалити";
            IAdminInfoDeleteStudBut.UseVisualStyleBackColor = true;
            IAdminInfoDeleteStudBut.Click += IAdminInfoDelete_Click;
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
            // IAdministratorForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(tabControl1);
            Name = "IAdministratorForm1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Адміністратор";
            Load += IAdministratorForm1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            IAdminInfoStudTLP.ResumeLayout(false);
            IAdminInfoStudTLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)methodsBindingSource).EndInit();
            IAdminInfoCMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
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
        private ToolStripMenuItem cleanToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel2;
        private Button IAdminInfoGenerateStudBut;
        private TextBox IAdminInfoStudGenTB;
        private BindingSource methodsBindingSource;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
    }
}