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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddExpenseBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DateE = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountE = new System.Windows.Forms.TextBox();
            this.expenseGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eAount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurBal = new System.Windows.Forms.Label();
            this.AmountDE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateDE = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DepBtn = new System.Windows.Forms.Button();
            this.EditItemPanel = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CancelEditBtn = new System.Windows.Forms.Button();
            this.SaveEditBtn = new System.Windows.Forms.Button();
            this.ID_E = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DescriptionE = new System.Windows.Forms.TextBox();
            this.AddDepositPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.DescriptionDE = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGrid)).BeginInit();
            this.EditItemPanel.SuspendLayout();
            this.AddDepositPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
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
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
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
            this.AddExpenseBut.Location = new System.Drawing.Point(139, 145);
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
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edit Item";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DateE
            // 
            this.DateE.Location = new System.Drawing.Point(61, 136);
            this.DateE.Name = "DateE";
            this.DateE.Size = new System.Drawing.Size(200, 20);
            this.DateE.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(3, 143);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(30, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            // 
            // AmountE
            // 
            this.AmountE.Location = new System.Drawing.Point(61, 110);
            this.AmountE.Name = "AmountE";
            this.AmountE.Size = new System.Drawing.Size(200, 20);
            this.AmountE.TabIndex = 0;
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
            this.expenseGrid.Location = new System.Drawing.Point(12, 55);
            this.expenseGrid.Name = "expenseGrid";
            this.expenseGrid.ReadOnly = true;
            this.expenseGrid.RowHeadersVisible = false;
            this.expenseGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.expenseGrid.Size = new System.Drawing.Size(536, 523);
            this.expenseGrid.TabIndex = 11;
            this.expenseGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expenseGrid_CellDoubleClick);
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
            // CurBal
            // 
            this.CurBal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurBal.AutoSize = true;
            this.CurBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurBal.Location = new System.Drawing.Point(570, 64);
            this.CurBal.Name = "CurBal";
            this.CurBal.Size = new System.Drawing.Size(213, 25);
            this.CurBal.TabIndex = 12;
            this.CurBal.Text = "Current Balance: $0.00";
            // 
            // AmountDE
            // 
            this.AmountDE.Location = new System.Drawing.Point(61, 83);
            this.AmountDE.Name = "AmountDE";
            this.AmountDE.Size = new System.Drawing.Size(200, 20);
            this.AmountDE.TabIndex = 18;
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
            // DateDE
            // 
            this.DateDE.Location = new System.Drawing.Point(61, 106);
            this.DateDE.Name = "DateDE";
            this.DateDE.Size = new System.Drawing.Size(200, 20);
            this.DateDE.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Add Item";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DepBtn
            // 
            this.DepBtn.Location = new System.Drawing.Point(20, 145);
            this.DepBtn.Name = "DepBtn";
            this.DepBtn.Size = new System.Drawing.Size(118, 23);
            this.DepBtn.TabIndex = 23;
            this.DepBtn.Text = "Add Deposit";
            this.DepBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DepBtn.UseVisualStyleBackColor = true;
            this.DepBtn.Click += new System.EventHandler(this.DepositBtn);
            // 
            // EditItemPanel
            // 
            this.EditItemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditItemPanel.Controls.Add(this.DeleteBtn);
            this.EditItemPanel.Controls.Add(this.CancelEditBtn);
            this.EditItemPanel.Controls.Add(this.SaveEditBtn);
            this.EditItemPanel.Controls.Add(this.ID_E);
            this.EditItemPanel.Controls.Add(this.label9);
            this.EditItemPanel.Controls.Add(this.label8);
            this.EditItemPanel.Controls.Add(this.DescriptionE);
            this.EditItemPanel.Controls.Add(this.label3);
            this.EditItemPanel.Controls.Add(this.DateE);
            this.EditItemPanel.Controls.Add(this.Label2);
            this.EditItemPanel.Controls.Add(this.label1);
            this.EditItemPanel.Controls.Add(this.AmountE);
            this.EditItemPanel.Location = new System.Drawing.Point(554, 298);
            this.EditItemPanel.Name = "EditItemPanel";
            this.EditItemPanel.Size = new System.Drawing.Size(268, 207);
            this.EditItemPanel.TabIndex = 2;
            this.EditItemPanel.Visible = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(182, 179);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 31;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CancelEditBtn
            // 
            this.CancelEditBtn.Location = new System.Drawing.Point(101, 179);
            this.CancelEditBtn.Name = "CancelEditBtn";
            this.CancelEditBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelEditBtn.TabIndex = 30;
            this.CancelEditBtn.Text = "Cancel";
            this.CancelEditBtn.UseVisualStyleBackColor = true;
            this.CancelEditBtn.Click += new System.EventHandler(this.CancelEditBtn_Click);
            // 
            // SaveEditBtn
            // 
            this.SaveEditBtn.Location = new System.Drawing.Point(20, 179);
            this.SaveEditBtn.Name = "SaveEditBtn";
            this.SaveEditBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveEditBtn.TabIndex = 29;
            this.SaveEditBtn.Text = "Save";
            this.SaveEditBtn.UseVisualStyleBackColor = true;
            this.SaveEditBtn.Click += new System.EventHandler(this.SaveEditBtn_Click);
            // 
            // ID_E
            // 
            this.ID_E.Location = new System.Drawing.Point(61, 51);
            this.ID_E.Name = "ID_E";
            this.ID_E.ReadOnly = true;
            this.ID_E.Size = new System.Drawing.Size(200, 20);
            this.ID_E.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Description";
            // 
            // DescriptionE
            // 
            this.DescriptionE.Location = new System.Drawing.Point(63, 84);
            this.DescriptionE.Name = "DescriptionE";
            this.DescriptionE.Size = new System.Drawing.Size(200, 20);
            this.DescriptionE.TabIndex = 25;
            // 
            // AddDepositPanel
            // 
            this.AddDepositPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddDepositPanel.Controls.Add(this.label7);
            this.AddDepositPanel.Controls.Add(this.DescriptionDE);
            this.AddDepositPanel.Controls.Add(this.AddExpenseBut);
            this.AddDepositPanel.Controls.Add(this.DepBtn);
            this.AddDepositPanel.Controls.Add(this.label4);
            this.AddDepositPanel.Controls.Add(this.DateDE);
            this.AddDepositPanel.Controls.Add(this.label5);
            this.AddDepositPanel.Controls.Add(this.label6);
            this.AddDepositPanel.Controls.Add(this.AmountDE);
            this.AddDepositPanel.Location = new System.Drawing.Point(554, 92);
            this.AddDepositPanel.Name = "AddDepositPanel";
            this.AddDepositPanel.Size = new System.Drawing.Size(268, 183);
            this.AddDepositPanel.TabIndex = 10;
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
            // DescriptionDE
            // 
            this.DescriptionDE.Location = new System.Drawing.Point(61, 57);
            this.DescriptionDE.Name = "DescriptionDE";
            this.DescriptionDE.Size = new System.Drawing.Size(200, 20);
            this.DescriptionDE.TabIndex = 24;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(834, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "New";
            this.toolStripButton2.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Open";
            this.toolStripButton1.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Save";
            this.toolStripButton3.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtersToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filtersToolStripMenuItem.Text = "Filters";
            this.filtersToolStripMenuItem.Click += new System.EventHandler(this.filtersToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 590);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.CurBal);
            this.Controls.Add(this.expenseGrid);
            this.Controls.Add(this.AddDepositPanel);
            this.Controls.Add(this.EditItemPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Account Manager by Collins Morley";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGrid)).EndInit();
            this.EditItemPanel.ResumeLayout(false);
            this.EditItemPanel.PerformLayout();
            this.AddDepositPanel.ResumeLayout(false);
            this.AddDepositPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker DateE;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AmountE;
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
        private System.Windows.Forms.DateTimePicker DateDE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AmountDE;
        private System.Windows.Forms.Panel EditItemPanel;
        private System.Windows.Forms.Panel AddDepositPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn eType;
        private System.Windows.Forms.DataGridViewTextBoxColumn eAount;
        private System.Windows.Forms.TextBox DescriptionE;
        private System.Windows.Forms.TextBox DescriptionDE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ID_E;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SaveEditBtn;
        private System.Windows.Forms.Button CancelEditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
    }
}

