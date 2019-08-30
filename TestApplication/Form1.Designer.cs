namespace TestApplication
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabSeq = new System.Windows.Forms.TabPage();
            this.seqBtn = new System.Windows.Forms.Button();
            this.seqTboxRes = new System.Windows.Forms.TextBox();
            this.seqTboxSrc = new System.Windows.Forms.TextBox();
            this.tabFact = new System.Windows.Forms.TabPage();
            this.factLbl = new System.Windows.Forms.Label();
            this.factLblRes = new System.Windows.Forms.Label();
            this.factBtn = new System.Windows.Forms.Button();
            this.factNumUd = new System.Windows.Forms.NumericUpDown();
            this.tabStrSrch = new System.Windows.Forms.TabPage();
            this.strBtn = new System.Windows.Forms.Button();
            this.strTboxRes = new System.Windows.Forms.TextBox();
            this.strTboxSource = new System.Windows.Forms.TextBox();
            this.tabSort = new System.Windows.Forms.TabPage();
            this.srcBtn = new System.Windows.Forms.Button();
            this.srcResLbl = new System.Windows.Forms.Label();
            this.srcLbl = new System.Windows.Forms.Label();
            this.srcNumUd = new System.Windows.Forms.NumericUpDown();
            this.sortLbl2 = new System.Windows.Forms.Label();
            this.sortLbl1 = new System.Windows.Forms.Label();
            this.sortBtn = new System.Windows.Forms.Button();
            this.tBoxOut = new System.Windows.Forms.TextBox();
            this.tBoxIn = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSeq.SuspendLayout();
            this.tabFact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factNumUd)).BeginInit();
            this.tabStrSrch.SuspendLayout();
            this.tabSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcNumUd)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSeq
            // 
            this.tabSeq.Controls.Add(this.label1);
            this.tabSeq.Controls.Add(this.seqBtn);
            this.tabSeq.Controls.Add(this.seqTboxRes);
            this.tabSeq.Controls.Add(this.seqTboxSrc);
            this.tabSeq.Location = new System.Drawing.Point(4, 22);
            this.tabSeq.Name = "tabSeq";
            this.tabSeq.Size = new System.Drawing.Size(448, 304);
            this.tabSeq.TabIndex = 4;
            this.tabSeq.Text = "Sequence";
            this.tabSeq.UseVisualStyleBackColor = true;
            // 
            // seqBtn
            // 
            this.seqBtn.Location = new System.Drawing.Point(193, 181);
            this.seqBtn.Name = "seqBtn";
            this.seqBtn.Size = new System.Drawing.Size(75, 23);
            this.seqBtn.TabIndex = 2;
            this.seqBtn.Text = "Check";
            this.seqBtn.UseVisualStyleBackColor = true;
            this.seqBtn.Click += new System.EventHandler(this.seqBtn_Click);
            // 
            // seqTboxRes
            // 
            this.seqTboxRes.Location = new System.Drawing.Point(137, 142);
            this.seqTboxRes.Name = "seqTboxRes";
            this.seqTboxRes.Size = new System.Drawing.Size(183, 20);
            this.seqTboxRes.TabIndex = 1;
            // 
            // seqTboxSrc
            // 
            this.seqTboxSrc.Location = new System.Drawing.Point(62, 86);
            this.seqTboxSrc.Name = "seqTboxSrc";
            this.seqTboxSrc.Size = new System.Drawing.Size(325, 20);
            this.seqTboxSrc.TabIndex = 0;
            // 
            // tabFact
            // 
            this.tabFact.Controls.Add(this.factLbl);
            this.tabFact.Controls.Add(this.factLblRes);
            this.tabFact.Controls.Add(this.factBtn);
            this.tabFact.Controls.Add(this.factNumUd);
            this.tabFact.Location = new System.Drawing.Point(4, 22);
            this.tabFact.Name = "tabFact";
            this.tabFact.Size = new System.Drawing.Size(448, 304);
            this.tabFact.TabIndex = 3;
            this.tabFact.Text = "Factorial";
            this.tabFact.UseVisualStyleBackColor = true;
            // 
            // factLbl
            // 
            this.factLbl.AutoSize = true;
            this.factLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factLbl.Location = new System.Drawing.Point(177, 65);
            this.factLbl.Name = "factLbl";
            this.factLbl.Size = new System.Drawing.Size(94, 17);
            this.factLbl.TabIndex = 3;
            this.factLbl.Text = "Enter number";
            // 
            // factLblRes
            // 
            this.factLblRes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.factLblRes.AutoSize = true;
            this.factLblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factLblRes.Location = new System.Drawing.Point(200, 167);
            this.factLblRes.MinimumSize = new System.Drawing.Size(50, 0);
            this.factLblRes.Name = "factLblRes";
            this.factLblRes.Size = new System.Drawing.Size(50, 17);
            this.factLblRes.TabIndex = 2;
            this.factLblRes.Text = "0";
            // 
            // factBtn
            // 
            this.factBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factBtn.Location = new System.Drawing.Point(187, 216);
            this.factBtn.Name = "factBtn";
            this.factBtn.Size = new System.Drawing.Size(75, 23);
            this.factBtn.TabIndex = 1;
            this.factBtn.Text = "Count";
            this.factBtn.UseVisualStyleBackColor = true;
            this.factBtn.Click += new System.EventHandler(this.factBtn_Click);
            // 
            // factNumUd
            // 
            this.factNumUd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factNumUd.Location = new System.Drawing.Point(164, 113);
            this.factNumUd.Name = "factNumUd";
            this.factNumUd.Size = new System.Drawing.Size(120, 23);
            this.factNumUd.TabIndex = 0;
            // 
            // tabStrSrch
            // 
            this.tabStrSrch.Controls.Add(this.strBtn);
            this.tabStrSrch.Controls.Add(this.strTboxRes);
            this.tabStrSrch.Controls.Add(this.strTboxSource);
            this.tabStrSrch.Location = new System.Drawing.Point(4, 22);
            this.tabStrSrch.Name = "tabStrSrch";
            this.tabStrSrch.Size = new System.Drawing.Size(448, 304);
            this.tabStrSrch.TabIndex = 2;
            this.tabStrSrch.Text = "String Search";
            this.tabStrSrch.UseVisualStyleBackColor = true;
            // 
            // strBtn
            // 
            this.strBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strBtn.Location = new System.Drawing.Point(180, 260);
            this.strBtn.Name = "strBtn";
            this.strBtn.Size = new System.Drawing.Size(75, 23);
            this.strBtn.TabIndex = 2;
            this.strBtn.Text = "Search";
            this.strBtn.UseVisualStyleBackColor = true;
            this.strBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // strTboxRes
            // 
            this.strTboxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strTboxRes.Location = new System.Drawing.Point(33, 136);
            this.strTboxRes.Multiline = true;
            this.strTboxRes.Name = "strTboxRes";
            this.strTboxRes.Size = new System.Drawing.Size(383, 99);
            this.strTboxRes.TabIndex = 1;
            // 
            // strTboxSource
            // 
            this.strTboxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strTboxSource.Location = new System.Drawing.Point(33, 21);
            this.strTboxSource.Multiline = true;
            this.strTboxSource.Name = "strTboxSource";
            this.strTboxSource.Size = new System.Drawing.Size(383, 93);
            this.strTboxSource.TabIndex = 0;
            // 
            // tabSort
            // 
            this.tabSort.Controls.Add(this.srcBtn);
            this.tabSort.Controls.Add(this.srcResLbl);
            this.tabSort.Controls.Add(this.srcLbl);
            this.tabSort.Controls.Add(this.srcNumUd);
            this.tabSort.Controls.Add(this.sortLbl2);
            this.tabSort.Controls.Add(this.sortLbl1);
            this.tabSort.Controls.Add(this.sortBtn);
            this.tabSort.Controls.Add(this.tBoxOut);
            this.tabSort.Controls.Add(this.tBoxIn);
            this.tabSort.Location = new System.Drawing.Point(4, 22);
            this.tabSort.Name = "tabSort";
            this.tabSort.Padding = new System.Windows.Forms.Padding(3);
            this.tabSort.Size = new System.Drawing.Size(448, 304);
            this.tabSort.TabIndex = 0;
            this.tabSort.Text = "Sort";
            this.tabSort.UseVisualStyleBackColor = true;
            // 
            // srcBtn
            // 
            this.srcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srcBtn.Location = new System.Drawing.Point(365, 235);
            this.srcBtn.Name = "srcBtn";
            this.srcBtn.Size = new System.Drawing.Size(75, 23);
            this.srcBtn.TabIndex = 8;
            this.srcBtn.Text = "Search";
            this.srcBtn.UseVisualStyleBackColor = true;
            this.srcBtn.Click += new System.EventHandler(this.srcBtn_Click);
            // 
            // srcResLbl
            // 
            this.srcResLbl.AutoSize = true;
            this.srcResLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srcResLbl.Location = new System.Drawing.Point(19, 273);
            this.srcResLbl.Name = "srcResLbl";
            this.srcResLbl.Size = new System.Drawing.Size(64, 17);
            this.srcResLbl.TabIndex = 7;
            this.srcResLbl.Text = "Stand by";
            // 
            // srcLbl
            // 
            this.srcLbl.AutoSize = true;
            this.srcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srcLbl.Location = new System.Drawing.Point(19, 215);
            this.srcLbl.Name = "srcLbl";
            this.srcLbl.Size = new System.Drawing.Size(94, 17);
            this.srcLbl.TabIndex = 6;
            this.srcLbl.Text = "Enter number";
            // 
            // srcNumUd
            // 
            this.srcNumUd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srcNumUd.Location = new System.Drawing.Point(22, 235);
            this.srcNumUd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.srcNumUd.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.srcNumUd.Name = "srcNumUd";
            this.srcNumUd.Size = new System.Drawing.Size(304, 23);
            this.srcNumUd.TabIndex = 5;
            // 
            // sortLbl2
            // 
            this.sortLbl2.AutoSize = true;
            this.sortLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortLbl2.Location = new System.Drawing.Point(19, 120);
            this.sortLbl2.Name = "sortLbl2";
            this.sortLbl2.Size = new System.Drawing.Size(48, 17);
            this.sortLbl2.TabIndex = 4;
            this.sortLbl2.Text = "Result";
            // 
            // sortLbl1
            // 
            this.sortLbl1.AutoSize = true;
            this.sortLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortLbl1.Location = new System.Drawing.Point(19, 23);
            this.sortLbl1.Name = "sortLbl1";
            this.sortLbl1.Size = new System.Drawing.Size(214, 17);
            this.sortLbl1.TabIndex = 3;
            this.sortLbl1.Text = "Input numbers with space splitter";
            // 
            // sortBtn
            // 
            this.sortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBtn.Location = new System.Drawing.Point(365, 43);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 2;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // tBoxOut
            // 
            this.tBoxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxOut.Location = new System.Drawing.Point(19, 140);
            this.tBoxOut.Multiline = true;
            this.tBoxOut.Name = "tBoxOut";
            this.tBoxOut.Size = new System.Drawing.Size(307, 67);
            this.tBoxOut.TabIndex = 1;
            // 
            // tBoxIn
            // 
            this.tBoxIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxIn.Location = new System.Drawing.Point(19, 43);
            this.tBoxIn.Multiline = true;
            this.tBoxIn.Name = "tBoxIn";
            this.tBoxIn.Size = new System.Drawing.Size(307, 69);
            this.tBoxIn.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSort);
            this.tabControl1.Controls.Add(this.tabStrSrch);
            this.tabControl1.Controls.Add(this.tabFact);
            this.tabControl1.Controls.Add(this.tabSeq);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 330);
            this.tabControl1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(172, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter sequence";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 330);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Test Application";
            this.tabSeq.ResumeLayout(false);
            this.tabSeq.PerformLayout();
            this.tabFact.ResumeLayout(false);
            this.tabFact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factNumUd)).EndInit();
            this.tabStrSrch.ResumeLayout(false);
            this.tabStrSrch.PerformLayout();
            this.tabSort.ResumeLayout(false);
            this.tabSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcNumUd)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabSeq;
        private System.Windows.Forms.TabPage tabFact;
        private System.Windows.Forms.TabPage tabStrSrch;
        private System.Windows.Forms.TabPage tabSort;
        private System.Windows.Forms.Button srcBtn;
        private System.Windows.Forms.Label srcResLbl;
        private System.Windows.Forms.Label srcLbl;
        private System.Windows.Forms.NumericUpDown srcNumUd;
        private System.Windows.Forms.Label sortLbl2;
        private System.Windows.Forms.Label sortLbl1;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.TextBox tBoxOut;
        private System.Windows.Forms.TextBox tBoxIn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label factLbl;
        private System.Windows.Forms.Label factLblRes;
        private System.Windows.Forms.Button factBtn;
        private System.Windows.Forms.NumericUpDown factNumUd;
        private System.Windows.Forms.Button strBtn;
        private System.Windows.Forms.TextBox strTboxRes;
        private System.Windows.Forms.TextBox strTboxSource;
        private System.Windows.Forms.Button seqBtn;
        private System.Windows.Forms.TextBox seqTboxRes;
        private System.Windows.Forms.TextBox seqTboxSrc;
        private System.Windows.Forms.Label label1;


    }
}

