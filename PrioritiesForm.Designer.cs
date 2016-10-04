namespace Saati
{
    partial class PrioritiesForm
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
            this.HowMuchLBL = new System.Windows.Forms.Label();
            this.HowMuchNUD = new System.Windows.Forms.NumericUpDown();
            this.HowMuchBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PrioritiesTableDGV = new System.Windows.Forms.DataGridView();
            this.NextStepBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HowMuchNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrioritiesTableDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сейчас надо ввести приоритеты критериев";
            // 
            // HowMuchLBL
            // 
            this.HowMuchLBL.AutoSize = true;
            this.HowMuchLBL.Location = new System.Drawing.Point(12, 31);
            this.HowMuchLBL.Name = "HowMuchLBL";
            this.HowMuchLBL.Size = new System.Drawing.Size(217, 13);
            this.HowMuchLBL.TabIndex = 1;
            this.HowMuchLBL.Text = "Во сколько раз критерий %1 важнее %2?";
            // 
            // HowMuchNUD
            // 
            this.HowMuchNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HowMuchNUD.DecimalPlaces = 2;
            this.HowMuchNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.HowMuchNUD.Location = new System.Drawing.Point(12, 50);
            this.HowMuchNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.HowMuchNUD.Name = "HowMuchNUD";
            this.HowMuchNUD.Size = new System.Drawing.Size(354, 20);
            this.HowMuchNUD.TabIndex = 2;
            this.HowMuchNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HowMuchBTN
            // 
            this.HowMuchBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HowMuchBTN.Location = new System.Drawing.Point(372, 47);
            this.HowMuchBTN.Name = "HowMuchBTN";
            this.HowMuchBTN.Size = new System.Drawing.Size(75, 23);
            this.HowMuchBTN.TabIndex = 3;
            this.HowMuchBTN.Text = "ОК";
            this.HowMuchBTN.UseVisualStyleBackColor = true;
            this.HowMuchBTN.Click += new System.EventHandler(this.HowMuchBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "После ввода приоритетов будет построена таблица:";
            // 
            // PrioritiesTableDGV
            // 
            this.PrioritiesTableDGV.AllowUserToAddRows = false;
            this.PrioritiesTableDGV.AllowUserToDeleteRows = false;
            this.PrioritiesTableDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrioritiesTableDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrioritiesTableDGV.Location = new System.Drawing.Point(12, 99);
            this.PrioritiesTableDGV.MultiSelect = false;
            this.PrioritiesTableDGV.Name = "PrioritiesTableDGV";
            this.PrioritiesTableDGV.ReadOnly = true;
            this.PrioritiesTableDGV.Size = new System.Drawing.Size(435, 226);
            this.PrioritiesTableDGV.TabIndex = 5;
            // 
            // NextStepBTN
            // 
            this.NextStepBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextStepBTN.Enabled = false;
            this.NextStepBTN.Location = new System.Drawing.Point(372, 331);
            this.NextStepBTN.Name = "NextStepBTN";
            this.NextStepBTN.Size = new System.Drawing.Size(75, 23);
            this.NextStepBTN.TabIndex = 6;
            this.NextStepBTN.Text = "Далее";
            this.NextStepBTN.UseVisualStyleBackColor = true;
            this.NextStepBTN.Click += new System.EventHandler(this.NextStepBTN_Click);
            // 
            // PrioritiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 366);
            this.Controls.Add(this.NextStepBTN);
            this.Controls.Add(this.PrioritiesTableDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HowMuchBTN);
            this.Controls.Add(this.HowMuchNUD);
            this.Controls.Add(this.HowMuchLBL);
            this.Controls.Add(this.label1);
            this.Name = "PrioritiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приоритеты критериев";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrioritiesForm_FormClosed);
            this.Load += new System.EventHandler(this.PrioritiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HowMuchNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrioritiesTableDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HowMuchLBL;
        private System.Windows.Forms.NumericUpDown HowMuchNUD;
        private System.Windows.Forms.Button HowMuchBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView PrioritiesTableDGV;
        private System.Windows.Forms.Button NextStepBTN;
    }
}