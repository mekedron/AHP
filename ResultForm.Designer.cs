namespace Saati
{
    partial class ResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CompareResultsDGV = new System.Windows.Forms.DataGridView();
            this.FinalResultDGV = new System.Windows.Forms.DataGridView();
            this.RecomendationLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CompareResultsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalResultDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Веса критериев (чтобы память освежить)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Взвешенная средняя арифметическая сумма (то бишь с учётом весов критериев)";
            // 
            // CompareResultsDGV
            // 
            this.CompareResultsDGV.AllowUserToAddRows = false;
            this.CompareResultsDGV.AllowUserToDeleteRows = false;
            this.CompareResultsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompareResultsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompareResultsDGV.Location = new System.Drawing.Point(12, 25);
            this.CompareResultsDGV.MultiSelect = false;
            this.CompareResultsDGV.Name = "CompareResultsDGV";
            this.CompareResultsDGV.ReadOnly = true;
            this.CompareResultsDGV.Size = new System.Drawing.Size(493, 226);
            this.CompareResultsDGV.TabIndex = 13;
            // 
            // FinalResultDGV
            // 
            this.FinalResultDGV.AllowUserToAddRows = false;
            this.FinalResultDGV.AllowUserToDeleteRows = false;
            this.FinalResultDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FinalResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FinalResultDGV.Location = new System.Drawing.Point(12, 270);
            this.FinalResultDGV.MultiSelect = false;
            this.FinalResultDGV.Name = "FinalResultDGV";
            this.FinalResultDGV.ReadOnly = true;
            this.FinalResultDGV.Size = new System.Drawing.Size(493, 214);
            this.FinalResultDGV.TabIndex = 14;
            // 
            // RecomendationLBL
            // 
            this.RecomendationLBL.AutoSize = true;
            this.RecomendationLBL.Location = new System.Drawing.Point(12, 487);
            this.RecomendationLBL.Name = "RecomendationLBL";
            this.RecomendationLBL.Size = new System.Drawing.Size(105, 13);
            this.RecomendationLBL.TabIndex = 15;
            this.RecomendationLBL.Text = "Рекомендация - %1";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 509);
            this.Controls.Add(this.RecomendationLBL);
            this.Controls.Add(this.FinalResultDGV);
            this.Controls.Add(this.CompareResultsDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результат";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultForm_FormClosing);
            this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompareResultsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalResultDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CompareResultsDGV;
        private System.Windows.Forms.DataGridView FinalResultDGV;
        private System.Windows.Forms.Label RecomendationLBL;
    }
}