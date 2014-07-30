namespace _17._07._2014___AccountManagement
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddExpenseBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.expenseGrid = new System.Windows.Forms.DataGridView();
            this.CurBal = new System.Windows.Forms.Label();
            this.AmountD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateD = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DepBtn = new System.Windows.Forms.Button();
            this.AddExpensePanel = new System.Windows.Forms.Panel();
            this.AddDepositPanel = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eAount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionD = new System.Windows.Forms.TextBox();
            this.DescriptionE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGrid)).BeginInit();
            this.AddExpensePanel.SuspendLayout();
            this.AddDepositPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AddExpenseBut
            // 
            this.AddExpenseBut.Location = new System.Drawing.Point(82, 162);
            this.AddExpenseBut.Name = "AddExpenseBut";
            this.AddExpenseBut.Size = new System.Drawing.Size(118, 23);
            this.AddExpenseBut.TabIndex = 5;
            this.AddExpenseBut.Text = "Add Expense";
            this.AddExpenseBut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AddExpenseBut.UseVisualStyleBackColor = true;
            this.AddExpenseBut.Click += new System.EventHandler(this.AddExpenseBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Expense";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(61, 126);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(3, 133);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(30, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(61, 100);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(200, 20);
            this.Amount.TabIndex = 0;
            // 
            // expenseGrid
            // 
            this.expenseGrid.AllowUserToAddRows = false;
            this.expenseGrid.AllowUserToDeleteRows = false;
            this.expenseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expenseGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.expenseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expenseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.eDate,
            this.Description,
            this.eType,
            this.eAount});
            this.expenseGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.expenseGrid.Location = new System.Drawing.Point(12, 27);
            this.expenseGrid.Name = "expenseGrid";
            this.expenseGrid.ReadOnly = true;
            this.expenseGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.expenseGrid.Size = new System.Drawing.Size(536, 523);
            this.expenseGrid.TabIndex = 11;
            // 
            // CurBal
            // 
            this.CurBal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurBal.AutoSize = true;
            this.CurBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurBal.Location = new System.Drawing.Point(554, 27);
            this.CurBal.Name = "CurBal";
            this.CurBal.Size = new System.Drawing.Size(213, 25);
            this.CurBal.TabIndex = 12;
            this.CurBal.Text = "Current Balance: $0.00";
            // 
            // AmountD
            // 
            this.AmountD.Location = new System.Drawing.Point(61, 83);
            this.AmountD.Name = "AmountD";
            this.AmountD.Size = new System.Drawing.Size(200, 20);
            this.AmountD.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date";
            // 
            // DateD
            // 
            this.DateD.Location = new System.Drawing.Point(61, 106);
            this.DateD.Name = "DateD";
            this.DateD.Size = new System.Drawing.Size(200, 20);
            this.DateD.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Add Deposit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DepBtn
            // 
            this.DepBtn.Location = new System.Drawing.Point(92, 145);
            this.DepBtn.Name = "DepBtn";
            this.DepBtn.Size = new System.Drawing.Size(118, 23);
            this.DepBtn.TabIndex = 23;
            this.DepBtn.Text = "Add Deposit";
            this.DepBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DepBtn.UseVisualStyleBackColor = true;
            this.DepBtn.Click += new System.EventHandler(this.DepositBtn);
            // 
            // AddExpensePanel
            // 
            this.AddExpensePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddExpensePanel.Controls.Add(this.label8);
            this.AddExpensePanel.Controls.Add(this.DescriptionE);
            this.AddExpensePanel.Controls.Add(this.AddExpenseBut);
            this.AddExpensePanel.Controls.Add(this.label3);
            this.AddExpensePanel.Controls.Add(this.Date);
            this.AddExpensePanel.Controls.Add(this.Label2);
            this.AddExpensePanel.Controls.Add(this.label1);
            this.AddExpensePanel.Controls.Add(this.Amount);
            this.AddExpensePanel.Location = new System.Drawing.Point(554, 302);
            this.AddExpensePanel.Name = "AddExpensePanel";
            this.AddExpensePanel.Size = new System.Drawing.Size(268, 207);
            this.AddExpensePanel.TabIndex = 2;
            // 
            // AddDepositPanel
            // 
            this.AddDepositPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddDepositPanel.Controls.Add(this.label7);
            this.AddDepositPanel.Controls.Add(this.DescriptionD);
            this.AddDepositPanel.Controls.Add(this.DepBtn);
            this.AddDepositPanel.Controls.Add(this.label4);
            this.AddDepositPanel.Controls.Add(this.DateD);
            this.AddDepositPanel.Controls.Add(this.label5);
            this.AddDepositPanel.Controls.Add(this.label6);
            this.AddDepositPanel.Controls.Add(this.AmountD);
            this.AddDepositPanel.Location = new System.Drawing.Point(554, 64);
            this.AddDepositPanel.Name = "AddDepositPanel";
            this.AddDepositPanel.Size = new System.Drawing.Size(268, 183);
            this.AddDepositPanel.TabIndex = 10;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.FillWeight = 53.4267F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // eDate
            // 
            this.eDate.FillWeight = 122.5253F;
            this.eDate.HeaderText = "Date";
            this.eDate.Name = "eDate";
            this.eDate.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // eType
            // 
            this.eType.FillWeight = 101.5229F;
            this.eType.HeaderText = "Type";
            this.eType.Name = "eType";
            this.eType.ReadOnly = true;
            // 
            // eAount
            // 
            this.eAount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.eAount.FillWeight = 122.5253F;
            this.eAount.HeaderText = "Amount";
            this.eAount.Name = "eAount";
            this.eAount.ReadOnly = true;
            this.eAount.Width = 75;
            // 
            // DescriptionD
            // 
            this.DescriptionD.Location = new System.Drawing.Point(61, 57);
            this.DescriptionD.Name = "DescriptionD";
            this.DescriptionD.Size = new System.Drawing.Size(200, 20);
            this.DescriptionD.TabIndex = 24;
            // 
            // DescriptionE
            // 
            this.DescriptionE.Location = new System.Drawing.Point(63, 74);
            this.DescriptionE.Name = "DescriptionE";
            this.DescriptionE.Size = new System.Drawing.Size(200, 20);
            this.DescriptionE.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 562);
            this.Controls.Add(this.CurBal);
            this.Controls.Add(this.expenseGrid);
            this.Controls.Add(this.AddDepositPanel);
            this.Controls.Add(this.AddExpensePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Account Manager by Collins Morley";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGrid)).EndInit();
            this.AddExpensePanel.ResumeLayout(false);
            this.AddExpensePanel.PerformLayout();
            this.AddDepositPanel.ResumeLayout(false);
            this.AddDepositPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button AddExpenseBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label CurBal;
        private System.Windows.Forms.DataGridView expenseGrid;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button DepBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AmountD;
        private System.Windows.Forms.Panel AddExpensePanel;
        private System.Windows.Forms.Panel AddDepositPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn eType;
        private System.Windows.Forms.DataGridViewTextBoxColumn eAount;
        private System.Windows.Forms.TextBox DescriptionE;
        private System.Windows.Forms.TextBox DescriptionD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

