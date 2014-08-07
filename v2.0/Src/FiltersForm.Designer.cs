namespace _17._07._2014___AccountManagement
{
    partial class FiltersForm
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
            this.TYPE_I = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AMOUNT_I = new System.Windows.Forms.TextBox();
            this.LT_R = new System.Windows.Forms.RadioButton();
            this.GT_R = new System.Windows.Forms.RadioButton();
            this.ET_R = new System.Windows.Forms.RadioButton();
            this.ApplyFiltersBtn = new System.Windows.Forms.Button();
            this.ClearFiltersBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TYPE_I
            // 
            this.TYPE_I.Items.AddRange(new object[] {
            "All",
            "Deposit",
            "Expense"});
            this.TYPE_I.Location = new System.Drawing.Point(142, 42);
            this.TYPE_I.Name = "TYPE_I";
            this.TYPE_I.Size = new System.Drawing.Size(121, 21);
            this.TYPE_I.TabIndex = 0;
            this.TYPE_I.Text = "All";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // AMOUNT_I
            // 
            this.AMOUNT_I.Location = new System.Drawing.Point(154, 101);
            this.AMOUNT_I.Name = "AMOUNT_I";
            this.AMOUNT_I.Size = new System.Drawing.Size(100, 20);
            this.AMOUNT_I.TabIndex = 3;
            // 
            // LT_R
            // 
            this.LT_R.AutoSize = true;
            this.LT_R.Location = new System.Drawing.Point(154, 78);
            this.LT_R.Name = "LT_R";
            this.LT_R.Size = new System.Drawing.Size(37, 17);
            this.LT_R.TabIndex = 4;
            this.LT_R.TabStop = true;
            this.LT_R.Text = "<=";
            this.LT_R.UseVisualStyleBackColor = true;
            // 
            // GT_R
            // 
            this.GT_R.AutoSize = true;
            this.GT_R.Location = new System.Drawing.Point(228, 78);
            this.GT_R.Name = "GT_R";
            this.GT_R.Size = new System.Drawing.Size(37, 17);
            this.GT_R.TabIndex = 5;
            this.GT_R.TabStop = true;
            this.GT_R.Text = ">=";
            this.GT_R.UseVisualStyleBackColor = true;
            // 
            // ET_R
            // 
            this.ET_R.AutoSize = true;
            this.ET_R.Location = new System.Drawing.Point(191, 78);
            this.ET_R.Name = "ET_R";
            this.ET_R.Size = new System.Drawing.Size(31, 17);
            this.ET_R.TabIndex = 6;
            this.ET_R.TabStop = true;
            this.ET_R.Text = "=";
            this.ET_R.UseVisualStyleBackColor = true;
            // 
            // ApplyFiltersBtn
            // 
            this.ApplyFiltersBtn.Location = new System.Drawing.Point(80, 139);
            this.ApplyFiltersBtn.Name = "ApplyFiltersBtn";
            this.ApplyFiltersBtn.Size = new System.Drawing.Size(75, 23);
            this.ApplyFiltersBtn.TabIndex = 7;
            this.ApplyFiltersBtn.Text = "Apply Filters";
            this.ApplyFiltersBtn.UseVisualStyleBackColor = true;
            this.ApplyFiltersBtn.Click += new System.EventHandler(this.ApplyFiltersBtn_Click);
            // 
            // ClearFiltersBtn
            // 
            this.ClearFiltersBtn.Location = new System.Drawing.Point(161, 139);
            this.ClearFiltersBtn.Name = "ClearFiltersBtn";
            this.ClearFiltersBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearFiltersBtn.TabIndex = 8;
            this.ClearFiltersBtn.Text = "Clear Filters";
            this.ClearFiltersBtn.UseVisualStyleBackColor = true;
            this.ClearFiltersBtn.Click += new System.EventHandler(this.ClearFiltersBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(242, 139);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // FiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 174);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ClearFiltersBtn);
            this.Controls.Add(this.ApplyFiltersBtn);
            this.Controls.Add(this.ET_R);
            this.Controls.Add(this.GT_R);
            this.Controls.Add(this.LT_R);
            this.Controls.Add(this.AMOUNT_I);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TYPE_I);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FiltersForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Apply List Filters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TYPE_I;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AMOUNT_I;
        private System.Windows.Forms.RadioButton LT_R;
        private System.Windows.Forms.RadioButton GT_R;
        private System.Windows.Forms.RadioButton ET_R;
        private System.Windows.Forms.Button ApplyFiltersBtn;
        private System.Windows.Forms.Button ClearFiltersBtn;
        private System.Windows.Forms.Button CancelBtn;

    }
}