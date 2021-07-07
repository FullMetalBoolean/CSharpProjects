namespace AccumulateTestScoreData
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnDsiplayAccess = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtInScore = new System.Windows.Forms.TextBox();
            this.txtScoreTotalOut = new System.Windows.Forms.TextBox();
            this.txtScoreCountOut = new System.Windows.Forms.TextBox();
            this.txtAverageOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(94, 40);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.AutoSize = true;
            this.lblScoreTotal.Location = new System.Drawing.Point(63, 77);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(65, 13);
            this.lblScoreTotal.TabIndex = 1;
            this.lblScoreTotal.Text = "Score Total:";
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.Location = new System.Drawing.Point(63, 116);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(69, 13);
            this.lblScoreCount.TabIndex = 2;
            this.lblScoreCount.Text = "Score Count:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(85, 147);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(50, 13);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Average:";
            // 
            // btnDsiplayAccess
            // 
            this.btnDsiplayAccess.Location = new System.Drawing.Point(97, 204);
            this.btnDsiplayAccess.Name = "btnDsiplayAccess";
            this.btnDsiplayAccess.Size = new System.Drawing.Size(99, 23);
            this.btnDsiplayAccess.TabIndex = 4;
            this.btnDsiplayAccess.Text = "Display access";
            this.btnDsiplayAccess.UseVisualStyleBackColor = true;
            this.btnDsiplayAccess.Click += new System.EventHandler(this.btnDsiplayAccess_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(257, 204);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear access";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(258, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(258, 233);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtInScore
            // 
            this.txtInScore.Location = new System.Drawing.Point(148, 40);
            this.txtInScore.Name = "txtInScore";
            this.txtInScore.Size = new System.Drawing.Size(100, 20);
            this.txtInScore.TabIndex = 8;
            // 
            // txtScoreTotalOut
            // 
            this.txtScoreTotalOut.Location = new System.Drawing.Point(148, 69);
            this.txtScoreTotalOut.Name = "txtScoreTotalOut";
            this.txtScoreTotalOut.ReadOnly = true;
            this.txtScoreTotalOut.Size = new System.Drawing.Size(100, 20);
            this.txtScoreTotalOut.TabIndex = 9;
            // 
            // txtScoreCountOut
            // 
            this.txtScoreCountOut.Location = new System.Drawing.Point(148, 109);
            this.txtScoreCountOut.Name = "txtScoreCountOut";
            this.txtScoreCountOut.ReadOnly = true;
            this.txtScoreCountOut.Size = new System.Drawing.Size(100, 20);
            this.txtScoreCountOut.TabIndex = 10;
            // 
            // txtAverageOut
            // 
            this.txtAverageOut.Location = new System.Drawing.Point(148, 144);
            this.txtAverageOut.Name = "txtAverageOut";
            this.txtAverageOut.ReadOnly = true;
            this.txtAverageOut.Size = new System.Drawing.Size(100, 20);
            this.txtAverageOut.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 299);
            this.Controls.Add(this.txtAverageOut);
            this.Controls.Add(this.txtScoreCountOut);
            this.Controls.Add(this.txtScoreTotalOut);
            this.Controls.Add(this.txtInScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDsiplayAccess);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = "Accumulated Test SCore Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnDsiplayAccess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtInScore;
        private System.Windows.Forms.TextBox txtScoreTotalOut;
        private System.Windows.Forms.TextBox txtScoreCountOut;
        private System.Windows.Forms.TextBox txtAverageOut;
    }
}

