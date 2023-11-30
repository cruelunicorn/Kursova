namespace Interface_Proj
{
    partial class IAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IAdminForm));
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
            IAdminHelpBut = new Button();
            IAdminHelpTT = new ToolTip(components);
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
            tabControl1.Font = new Font("Kievit Offc Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 2);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(966, 520);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Location = new Point(4, 33);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(958, 483);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Розклад";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 233F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            tableLayoutPanel2.Controls.Add(IAdminSchedLB, 0, 2);
            tableLayoutPanel2.Controls.Add(IAdminSchedTB, 0, 0);
            tableLayoutPanel2.Controls.Add(IAdminAddSchedBut, 3, 0);
            tableLayoutPanel2.Controls.Add(IAdminDeleteSchedBut, 3, 1);
            tableLayoutPanel2.Location = new Point(4, 4);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 206F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel2.Size = new Size(953, 481);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // IAdminSchedLB
            // 
            IAdminSchedLB.BackColor = Color.AliceBlue;
            tableLayoutPanel2.SetColumnSpan(IAdminSchedLB, 4);
            IAdminSchedLB.Dock = DockStyle.Fill;
            IAdminSchedLB.Font = new Font("Kievit Offc Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IAdminSchedLB.ForeColor = Color.Black;
            IAdminSchedLB.FormattingEnabled = true;
            IAdminSchedLB.ItemHeight = 24;
            IAdminSchedLB.Location = new Point(2, 102);
            IAdminSchedLB.Margin = new Padding(2);
            IAdminSchedLB.Name = "IAdminSchedLB";
            tableLayoutPanel2.SetRowSpan(IAdminSchedLB, 3);
            IAdminSchedLB.Size = new Size(949, 377);
            IAdminSchedLB.TabIndex = 0;
            // 
            // IAdminSchedTB
            // 
            IAdminSchedTB.BackColor = Color.AliceBlue;
            tableLayoutPanel2.SetColumnSpan(IAdminSchedTB, 3);
            IAdminSchedTB.Dock = DockStyle.Fill;
            IAdminSchedTB.Font = new Font("Kievit Offc Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IAdminSchedTB.ForeColor = Color.Black;
            IAdminSchedTB.Location = new Point(2, 2);
            IAdminSchedTB.Margin = new Padding(2);
            IAdminSchedTB.Multiline = true;
            IAdminSchedTB.Name = "IAdminSchedTB";
            IAdminSchedTB.Size = new Size(803, 46);
            IAdminSchedTB.TabIndex = 1;
            // 
            // IAdminAddSchedBut
            // 
            IAdminAddSchedBut.BackColor = Color.DodgerBlue;
            IAdminAddSchedBut.Dock = DockStyle.Fill;
            IAdminAddSchedBut.FlatAppearance.BorderColor = Color.Black;
            IAdminAddSchedBut.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            IAdminAddSchedBut.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            IAdminAddSchedBut.FlatStyle = FlatStyle.Flat;
            IAdminAddSchedBut.Font = new Font("Kievit Offc Pro", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            IAdminAddSchedBut.ForeColor = Color.WhiteSmoke;
            IAdminAddSchedBut.Location = new Point(809, 2);
            IAdminAddSchedBut.Margin = new Padding(2);
            IAdminAddSchedBut.Name = "IAdminAddSchedBut";
            IAdminAddSchedBut.Size = new Size(142, 46);
            IAdminAddSchedBut.TabIndex = 2;
            IAdminAddSchedBut.Text = "Додати";
            IAdminAddSchedBut.UseVisualStyleBackColor = false;
            IAdminAddSchedBut.Click += IAdminAddSchedBut_Click;
            // 
            // IAdminDeleteSchedBut
            // 
            IAdminDeleteSchedBut.BackColor = Color.DodgerBlue;
            IAdminDeleteSchedBut.Dock = DockStyle.Fill;
            IAdminDeleteSchedBut.FlatAppearance.BorderColor = Color.Black;
            IAdminDeleteSchedBut.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            IAdminDeleteSchedBut.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            IAdminDeleteSchedBut.FlatStyle = FlatStyle.Flat;
            IAdminDeleteSchedBut.Font = new Font("Kievit Offc Pro", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            IAdminDeleteSchedBut.ForeColor = Color.WhiteSmoke;
            IAdminDeleteSchedBut.Location = new Point(809, 52);
            IAdminDeleteSchedBut.Margin = new Padding(2);
            IAdminDeleteSchedBut.Name = "IAdminDeleteSchedBut";
            IAdminDeleteSchedBut.Size = new Size(142, 46);
            IAdminDeleteSchedBut.TabIndex = 3;
            IAdminDeleteSchedBut.Text = "Видалити";
            IAdminDeleteSchedBut.UseVisualStyleBackColor = false;
            IAdminDeleteSchedBut.Click += IAdminDeleteSchedBut_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(IAdminInfoStudTLP);
            tabPage2.Location = new Point(4, 33);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(958, 483);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Студенти";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // IAdminInfoStudTLP
            // 
            IAdminInfoStudTLP.BackColor = Color.White;
            IAdminInfoStudTLP.ColumnCount = 4;
            IAdminInfoStudTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            IAdminInfoStudTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            IAdminInfoStudTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 368F));
            IAdminInfoStudTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            IAdminInfoStudTLP.Controls.Add(IAdminInfoAddStudBut, 3, 1);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoStudTB, 0, 1);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoStudGenTB, 0, 0);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoGenerateStudBut, 3, 0);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoDeleteStudBut, 3, 2);
            IAdminInfoStudTLP.Controls.Add(IAdminInfoStudLB, 0, 3);
            IAdminInfoStudTLP.Location = new Point(2, 2);
            IAdminInfoStudTLP.Margin = new Padding(2);
            IAdminInfoStudTLP.Name = "IAdminInfoStudTLP";
            IAdminInfoStudTLP.RowCount = 6;
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 127F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 173F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            IAdminInfoStudTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            IAdminInfoStudTLP.Size = new Size(953, 481);
            IAdminInfoStudTLP.TabIndex = 0;
            // 
            // IAdminInfoAddStudBut
            // 
            IAdminInfoAddStudBut.BackColor = Color.DodgerBlue;
            IAdminInfoAddStudBut.Dock = DockStyle.Fill;
            IAdminInfoAddStudBut.FlatAppearance.BorderColor = Color.Black;
            IAdminInfoAddStudBut.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            IAdminInfoAddStudBut.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            IAdminInfoAddStudBut.FlatStyle = FlatStyle.Flat;
            IAdminInfoAddStudBut.Font = new Font("Kievit Offc Pro", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            IAdminInfoAddStudBut.ForeColor = Color.WhiteSmoke;
            IAdminInfoAddStudBut.Location = new Point(804, 52);
            IAdminInfoAddStudBut.Margin = new Padding(2);
            IAdminInfoAddStudBut.Name = "IAdminInfoAddStudBut";
            IAdminInfoAddStudBut.Size = new Size(147, 46);
            IAdminInfoAddStudBut.TabIndex = 1;
            IAdminInfoAddStudBut.Text = "Додати";
            IAdminInfoAddStudBut.UseVisualStyleBackColor = false;
            IAdminInfoAddStudBut.Click += IAdminInfoAddBut_Click;
            // 
            // IAdminInfoStudTB
            // 
            IAdminInfoStudTB.BackColor = Color.AliceBlue;
            IAdminInfoStudTLP.SetColumnSpan(IAdminInfoStudTB, 3);
            IAdminInfoStudTB.Dock = DockStyle.Fill;
            IAdminInfoStudTB.Font = new Font("Kievit Offc Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IAdminInfoStudTB.ForeColor = Color.Black;
            IAdminInfoStudTB.Location = new Point(2, 52);
            IAdminInfoStudTB.Margin = new Padding(2);
            IAdminInfoStudTB.Multiline = true;
            IAdminInfoStudTB.Name = "IAdminInfoStudTB";
            IAdminInfoStudTB.Size = new Size(798, 46);
            IAdminInfoStudTB.TabIndex = 0;
            // 
            // IAdminInfoStudGenTB
            // 
            IAdminInfoStudGenTB.BackColor = Color.AliceBlue;
            IAdminInfoStudTLP.SetColumnSpan(IAdminInfoStudGenTB, 3);
            IAdminInfoStudGenTB.Dock = DockStyle.Fill;
            IAdminInfoStudGenTB.Font = new Font("Kievit Offc Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IAdminInfoStudGenTB.ForeColor = Color.Black;
            IAdminInfoStudGenTB.Location = new Point(2, 2);
            IAdminInfoStudGenTB.Margin = new Padding(2);
            IAdminInfoStudGenTB.Multiline = true;
            IAdminInfoStudGenTB.Name = "IAdminInfoStudGenTB";
            IAdminInfoStudGenTB.Size = new Size(798, 46);
            IAdminInfoStudGenTB.TabIndex = 5;
            // 
            // IAdminInfoGenerateStudBut
            // 
            IAdminInfoGenerateStudBut.BackColor = Color.DodgerBlue;
            IAdminInfoGenerateStudBut.Dock = DockStyle.Fill;
            IAdminInfoGenerateStudBut.FlatAppearance.BorderColor = Color.Black;
            IAdminInfoGenerateStudBut.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            IAdminInfoGenerateStudBut.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            IAdminInfoGenerateStudBut.FlatStyle = FlatStyle.Flat;
            IAdminInfoGenerateStudBut.Font = new Font("Kievit Offc Pro", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            IAdminInfoGenerateStudBut.ForeColor = Color.WhiteSmoke;
            IAdminInfoGenerateStudBut.Location = new Point(804, 2);
            IAdminInfoGenerateStudBut.Margin = new Padding(2);
            IAdminInfoGenerateStudBut.Name = "IAdminInfoGenerateStudBut";
            IAdminInfoGenerateStudBut.Size = new Size(147, 46);
            IAdminInfoGenerateStudBut.TabIndex = 4;
            IAdminInfoGenerateStudBut.Text = "Сгенерувати";
            IAdminInfoGenerateStudBut.UseVisualStyleBackColor = false;
            IAdminInfoGenerateStudBut.Click += IAdminInfoGenerateStudBut_Click;
            // 
            // IAdminInfoDeleteStudBut
            // 
            IAdminInfoDeleteStudBut.BackColor = Color.DodgerBlue;
            IAdminInfoDeleteStudBut.Dock = DockStyle.Fill;
            IAdminInfoDeleteStudBut.FlatAppearance.BorderColor = Color.Black;
            IAdminInfoDeleteStudBut.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            IAdminInfoDeleteStudBut.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            IAdminInfoDeleteStudBut.FlatStyle = FlatStyle.Flat;
            IAdminInfoDeleteStudBut.Font = new Font("Kievit Offc Pro", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            IAdminInfoDeleteStudBut.ForeColor = Color.WhiteSmoke;
            IAdminInfoDeleteStudBut.Location = new Point(804, 102);
            IAdminInfoDeleteStudBut.Margin = new Padding(2);
            IAdminInfoDeleteStudBut.Name = "IAdminInfoDeleteStudBut";
            IAdminInfoDeleteStudBut.Size = new Size(147, 46);
            IAdminInfoDeleteStudBut.TabIndex = 2;
            IAdminInfoDeleteStudBut.Text = "Видалити";
            IAdminInfoDeleteStudBut.UseVisualStyleBackColor = false;
            IAdminInfoDeleteStudBut.Click += IAdminInfoDelete_Click;
            // 
            // IAdminInfoStudLB
            // 
            IAdminInfoStudLB.BackColor = Color.AliceBlue;
            IAdminInfoStudTLP.SetColumnSpan(IAdminInfoStudLB, 4);
            IAdminInfoStudLB.Dock = DockStyle.Fill;
            IAdminInfoStudLB.Font = new Font("Kievit Offc Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IAdminInfoStudLB.ForeColor = Color.Black;
            IAdminInfoStudLB.FormattingEnabled = true;
            IAdminInfoStudLB.ItemHeight = 24;
            IAdminInfoStudLB.Location = new Point(2, 152);
            IAdminInfoStudLB.Margin = new Padding(2);
            IAdminInfoStudLB.Name = "IAdminInfoStudLB";
            IAdminInfoStudTLP.SetRowSpan(IAdminInfoStudLB, 3);
            IAdminInfoStudLB.Size = new Size(949, 327);
            IAdminInfoStudLB.TabIndex = 3;
            IAdminInfoStudLB.SelectedIndexChanged += IAdminInfoStudLB_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel1);
            tabPage3.Location = new Point(4, 33);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2);
            tabPage3.Size = new Size(958, 483);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Викладачі";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.42475F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.57525F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 148F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(IAdminProfLB, 0, 0);
            tableLayoutPanel1.Controls.Add(IAdminProfTB, 1, 0);
            tableLayoutPanel1.Controls.Add(IAdminProfGenBut, 1, 1);
            tableLayoutPanel1.Controls.Add(IAdminProfAddBut, 2, 1);
            tableLayoutPanel1.Controls.Add(IAdminProfDeleteBut, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Font = new Font("Kievit Offc Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.0392151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.9607849F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 383F));
            tableLayoutPanel1.Size = new Size(954, 481);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // IAdminProfLB
            // 
            IAdminProfLB.BackColor = Color.AliceBlue;
            IAdminProfLB.Dock = DockStyle.Fill;
            IAdminProfLB.Font = new Font("Kievit Offc Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IAdminProfLB.ForeColor = Color.Black;
            IAdminProfLB.FormattingEnabled = true;
            IAdminProfLB.ItemHeight = 24;
            IAdminProfLB.Location = new Point(2, 2);
            IAdminProfLB.Margin = new Padding(2);
            IAdminProfLB.Name = "IAdminProfLB";
            tableLayoutPanel1.SetRowSpan(IAdminProfLB, 3);
            IAdminProfLB.Size = new Size(503, 477);
            IAdminProfLB.TabIndex = 0;
            // 
            // IAdminProfTB
            // 
            IAdminProfTB.BackColor = Color.AliceBlue;
            tableLayoutPanel1.SetColumnSpan(IAdminProfTB, 3);
            IAdminProfTB.Dock = DockStyle.Fill;
            IAdminProfTB.Font = new Font("Kievit Offc Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IAdminProfTB.ForeColor = Color.Black;
            IAdminProfTB.Location = new Point(509, 2);
            IAdminProfTB.Margin = new Padding(2);
            IAdminProfTB.Multiline = true;
            IAdminProfTB.Name = "IAdminProfTB";
            IAdminProfTB.Size = new Size(443, 43);
            IAdminProfTB.TabIndex = 1;
            // 
            // IAdminProfGenBut
            // 
            IAdminProfGenBut.BackColor = Color.DodgerBlue;
            IAdminProfGenBut.Dock = DockStyle.Fill;
            IAdminProfGenBut.FlatAppearance.BorderColor = Color.Black;
            IAdminProfGenBut.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            IAdminProfGenBut.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            IAdminProfGenBut.FlatStyle = FlatStyle.Flat;
            IAdminProfGenBut.Font = new Font("Kievit Offc Pro", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            IAdminProfGenBut.ForeColor = Color.WhiteSmoke;
            IAdminProfGenBut.Location = new Point(509, 49);
            IAdminProfGenBut.Margin = new Padding(2);
            IAdminProfGenBut.Name = "IAdminProfGenBut";
            IAdminProfGenBut.Size = new Size(144, 46);
            IAdminProfGenBut.TabIndex = 2;
            IAdminProfGenBut.Text = "Сгенерувати";
            IAdminProfGenBut.UseVisualStyleBackColor = false;
            IAdminProfGenBut.Click += IAdminProfGenBut_Click;
            // 
            // IAdminProfAddBut
            // 
            IAdminProfAddBut.BackColor = Color.DodgerBlue;
            IAdminProfAddBut.Dock = DockStyle.Fill;
            IAdminProfAddBut.FlatAppearance.BorderColor = Color.Black;
            IAdminProfAddBut.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            IAdminProfAddBut.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            IAdminProfAddBut.FlatStyle = FlatStyle.Flat;
            IAdminProfAddBut.Font = new Font("Kievit Offc Pro", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            IAdminProfAddBut.ForeColor = Color.WhiteSmoke;
            IAdminProfAddBut.Location = new Point(657, 49);
            IAdminProfAddBut.Margin = new Padding(2);
            IAdminProfAddBut.Name = "IAdminProfAddBut";
            IAdminProfAddBut.Size = new Size(144, 46);
            IAdminProfAddBut.TabIndex = 3;
            IAdminProfAddBut.Text = "Додати";
            IAdminProfAddBut.UseVisualStyleBackColor = false;
            IAdminProfAddBut.Click += IAdminProfAddBut_Click;
            // 
            // IAdminProfDeleteBut
            // 
            IAdminProfDeleteBut.BackColor = Color.DodgerBlue;
            IAdminProfDeleteBut.Dock = DockStyle.Fill;
            IAdminProfDeleteBut.FlatAppearance.BorderColor = Color.Black;
            IAdminProfDeleteBut.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            IAdminProfDeleteBut.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            IAdminProfDeleteBut.FlatStyle = FlatStyle.Flat;
            IAdminProfDeleteBut.Font = new Font("Kievit Offc Pro", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            IAdminProfDeleteBut.ForeColor = Color.WhiteSmoke;
            IAdminProfDeleteBut.Location = new Point(805, 49);
            IAdminProfDeleteBut.Margin = new Padding(2);
            IAdminProfDeleteBut.Name = "IAdminProfDeleteBut";
            IAdminProfDeleteBut.Size = new Size(147, 46);
            IAdminProfDeleteBut.TabIndex = 4;
            IAdminProfDeleteBut.Text = "Видалити";
            IAdminProfDeleteBut.UseVisualStyleBackColor = false;
            IAdminProfDeleteBut.Click += IAdminProfDeleteBut_Click;
            // 
            // IAdminInfoCMS
            // 
            IAdminInfoCMS.ImageScalingSize = new Size(24, 24);
            IAdminInfoCMS.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            IAdminInfoCMS.Name = "IAdminInfoCMS";
            IAdminInfoCMS.Size = new Size(135, 36);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(134, 32);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // IAdminHelpBut
            // 
            IAdminHelpBut.FlatAppearance.BorderSize = 0;
            IAdminHelpBut.FlatAppearance.MouseDownBackColor = Color.White;
            IAdminHelpBut.FlatAppearance.MouseOverBackColor = Color.White;
            IAdminHelpBut.FlatStyle = FlatStyle.Flat;
            IAdminHelpBut.Font = new Font("Kievit Offc Pro", 11F, FontStyle.Regular, GraphicsUnit.Point);
            IAdminHelpBut.Location = new Point(280, 2);
            IAdminHelpBut.Name = "IAdminHelpBut";
            IAdminHelpBut.Size = new Size(32, 28);
            IAdminHelpBut.TabIndex = 1;
            IAdminHelpBut.Text = "?";
            IAdminHelpBut.UseVisualStyleBackColor = true;
            // 
            // IAdminForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(966, 522);
            Controls.Add(IAdminHelpBut);
            Controls.Add(tabControl1);
            Font = new Font("Kievit Offc Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "IAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visit Control";
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
        private Button IAdminHelpBut;
        private ToolTip IAdminHelpTT;
    }
}