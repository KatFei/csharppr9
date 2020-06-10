namespace CSharpLab9_Parallel
{
    partial class PrimeSearch
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIntervalStart = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.lblIntervalEnd = new System.Windows.Forms.Label();
            this.lblThreads = new System.Windows.Forms.Label();
            this.numUpDThreads = new System.Windows.Forms.NumericUpDown();
            this.butSearch = new System.Windows.Forms.Button();
            this.tbPrimes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(15, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Interval to search prime numbers:";
            // 
            // lblIntervalStart
            // 
            this.lblIntervalStart.AutoSize = true;
            this.lblIntervalStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIntervalStart.Location = new System.Drawing.Point(15, 42);
            this.lblIntervalStart.Name = "lblIntervalStart";
            this.lblIntervalStart.Size = new System.Drawing.Size(43, 18);
            this.lblIntervalStart.TabIndex = 1;
            this.lblIntervalStart.Text = "Start:";
            // 
            // tbStart
            // 
            this.tbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStart.Location = new System.Drawing.Point(101, 39);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(27, 24);
            this.tbStart.TabIndex = 2;
            this.tbStart.Text = "0";
            this.tbStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbEnd
            // 
            this.tbEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEnd.Location = new System.Drawing.Point(251, 39);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(27, 24);
            this.tbEnd.TabIndex = 4;
            this.tbEnd.Text = "0";
            this.tbEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIntervalEnd
            // 
            this.lblIntervalEnd.AutoSize = true;
            this.lblIntervalEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIntervalEnd.Location = new System.Drawing.Point(185, 42);
            this.lblIntervalEnd.Name = "lblIntervalEnd";
            this.lblIntervalEnd.Size = new System.Drawing.Size(38, 18);
            this.lblIntervalEnd.TabIndex = 3;
            this.lblIntervalEnd.Text = "End:";
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblThreads.Location = new System.Drawing.Point(15, 77);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(66, 18);
            this.lblThreads.TabIndex = 5;
            this.lblThreads.Text = "Threads:";
            // 
            // numUpDThreads
            // 
            this.numUpDThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDThreads.Location = new System.Drawing.Point(101, 75);
            this.numUpDThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDThreads.Name = "numUpDThreads";
            this.numUpDThreads.Size = new System.Drawing.Size(44, 24);
            this.numUpDThreads.TabIndex = 6;
            this.numUpDThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // butSearch
            // 
            this.butSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSearch.Location = new System.Drawing.Point(111, 119);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 31);
            this.butSearch.TabIndex = 7;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // tbPrimes
            // 
            this.tbPrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPrimes.Location = new System.Drawing.Point(18, 156);
            this.tbPrimes.Multiline = true;
            this.tbPrimes.Name = "tbPrimes";
            this.tbPrimes.ReadOnly = true;
            this.tbPrimes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPrimes.Size = new System.Drawing.Size(260, 64);
            this.tbPrimes.TabIndex = 8;
            this.tbPrimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PrimeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 232);
            this.Controls.Add(this.tbPrimes);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.numUpDThreads);
            this.Controls.Add(this.lblThreads);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.lblIntervalEnd);
            this.Controls.Add(this.tbStart);
            this.Controls.Add(this.lblIntervalStart);
            this.Controls.Add(this.lblTitle);
            this.Name = "PrimeSearch";
            this.Text = "Prime Search";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIntervalStart;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.Label lblIntervalEnd;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.NumericUpDown numUpDThreads;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.TextBox tbPrimes;
    }
}

