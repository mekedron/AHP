namespace Saati
{
    partial class AlternativesForm
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
            this.AddAlternativeTB = new System.Windows.Forms.TextBox();
            this.AddAlternativeBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AlternativesListLSTBX = new System.Windows.Forms.ListBox();
            this.NextStepBTN = new System.Windows.Forms.Button();
            this.DelteAlternatuveBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавьте альтернативы:";
            // 
            // AddAlternativeTB
            // 
            this.AddAlternativeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAlternativeTB.Location = new System.Drawing.Point(12, 25);
            this.AddAlternativeTB.Name = "AddAlternativeTB";
            this.AddAlternativeTB.Size = new System.Drawing.Size(223, 20);
            this.AddAlternativeTB.TabIndex = 1;
            // 
            // AddAlternativeBTN
            // 
            this.AddAlternativeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAlternativeBTN.Location = new System.Drawing.Point(241, 23);
            this.AddAlternativeBTN.Name = "AddAlternativeBTN";
            this.AddAlternativeBTN.Size = new System.Drawing.Size(75, 23);
            this.AddAlternativeBTN.TabIndex = 2;
            this.AddAlternativeBTN.Text = "Добавить";
            this.AddAlternativeBTN.UseVisualStyleBackColor = true;
            this.AddAlternativeBTN.Click += new System.EventHandler(this.AddAlternativeBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Добавленные альтерантивы:";
            // 
            // AlternativesListLSTBX
            // 
            this.AlternativesListLSTBX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlternativesListLSTBX.FormattingEnabled = true;
            this.AlternativesListLSTBX.Items.AddRange(new object[] {
            "Жигули",
            "Москвич",
            "Иж",
            "Волга"});
            this.AlternativesListLSTBX.Location = new System.Drawing.Point(12, 64);
            this.AlternativesListLSTBX.Name = "AlternativesListLSTBX";
            this.AlternativesListLSTBX.Size = new System.Drawing.Size(223, 108);
            this.AlternativesListLSTBX.TabIndex = 4;
            // 
            // NextStepBTN
            // 
            this.NextStepBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextStepBTN.Location = new System.Drawing.Point(241, 150);
            this.NextStepBTN.Name = "NextStepBTN";
            this.NextStepBTN.Size = new System.Drawing.Size(75, 23);
            this.NextStepBTN.TabIndex = 6;
            this.NextStepBTN.Text = "Далее";
            this.NextStepBTN.UseVisualStyleBackColor = true;
            this.NextStepBTN.Click += new System.EventHandler(this.NextStepBTN_Click);
            // 
            // DelteAlternatuveBTN
            // 
            this.DelteAlternatuveBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelteAlternatuveBTN.Location = new System.Drawing.Point(241, 64);
            this.DelteAlternatuveBTN.Name = "DelteAlternatuveBTN";
            this.DelteAlternatuveBTN.Size = new System.Drawing.Size(75, 23);
            this.DelteAlternatuveBTN.TabIndex = 7;
            this.DelteAlternatuveBTN.Text = "Удалить";
            this.DelteAlternatuveBTN.UseVisualStyleBackColor = true;
            this.DelteAlternatuveBTN.Click += new System.EventHandler(this.DelteAlternatuveBTN_Click);
            // 
            // AlternativesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 185);
            this.Controls.Add(this.DelteAlternatuveBTN);
            this.Controls.Add(this.NextStepBTN);
            this.Controls.Add(this.AlternativesListLSTBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddAlternativeBTN);
            this.Controls.Add(this.AddAlternativeTB);
            this.Controls.Add(this.label1);
            this.Name = "AlternativesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Альтернативы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddAlternativeTB;
        private System.Windows.Forms.Button AddAlternativeBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox AlternativesListLSTBX;
        private System.Windows.Forms.Button NextStepBTN;
        private System.Windows.Forms.Button DelteAlternatuveBTN;
    }
}

