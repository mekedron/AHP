namespace Saati
{
    partial class CriterionsForm
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
            this.DelteCriterionBTN = new System.Windows.Forms.Button();
            this.NextStepBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddCriterionBTN = new System.Windows.Forms.Button();
            this.AddCriterionTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CriterionsListLSTBX = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // DelteCriterionBTN
            // 
            this.DelteCriterionBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelteCriterionBTN.Location = new System.Drawing.Point(241, 64);
            this.DelteCriterionBTN.Name = "DelteCriterionBTN";
            this.DelteCriterionBTN.Size = new System.Drawing.Size(75, 23);
            this.DelteCriterionBTN.TabIndex = 14;
            this.DelteCriterionBTN.Text = "Удалить";
            this.DelteCriterionBTN.UseVisualStyleBackColor = true;
            this.DelteCriterionBTN.Click += new System.EventHandler(this.DelteCriterionBTN_Click);
            // 
            // NextStepBTN
            // 
            this.NextStepBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextStepBTN.Location = new System.Drawing.Point(241, 151);
            this.NextStepBTN.Name = "NextStepBTN";
            this.NextStepBTN.Size = new System.Drawing.Size(75, 23);
            this.NextStepBTN.TabIndex = 13;
            this.NextStepBTN.Text = "Далее";
            this.NextStepBTN.UseVisualStyleBackColor = true;
            this.NextStepBTN.Click += new System.EventHandler(this.NextStepBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Добавленные альтерантивы:";
            // 
            // AddCriterionBTN
            // 
            this.AddCriterionBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCriterionBTN.Location = new System.Drawing.Point(241, 23);
            this.AddCriterionBTN.Name = "AddCriterionBTN";
            this.AddCriterionBTN.Size = new System.Drawing.Size(75, 23);
            this.AddCriterionBTN.TabIndex = 10;
            this.AddCriterionBTN.Text = "Добавить";
            this.AddCriterionBTN.UseVisualStyleBackColor = true;
            this.AddCriterionBTN.Click += new System.EventHandler(this.AddCriterionBTN_Click);
            // 
            // AddCriterionTB
            // 
            this.AddCriterionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCriterionTB.Location = new System.Drawing.Point(12, 25);
            this.AddCriterionTB.Name = "AddCriterionTB";
            this.AddCriterionTB.Size = new System.Drawing.Size(223, 20);
            this.AddCriterionTB.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Добавьте критерии:";
            // 
            // CriterionsListLSTBX
            // 
            this.CriterionsListLSTBX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CriterionsListLSTBX.FormattingEnabled = true;
            this.CriterionsListLSTBX.Items.AddRange(new object[] {
            "Стиль",
            "Надёжность",
            "Экономичность"});
            this.CriterionsListLSTBX.Location = new System.Drawing.Point(12, 64);
            this.CriterionsListLSTBX.Name = "CriterionsListLSTBX";
            this.CriterionsListLSTBX.Size = new System.Drawing.Size(223, 109);
            this.CriterionsListLSTBX.TabIndex = 16;
            // 
            // CriterionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 185);
            this.Controls.Add(this.CriterionsListLSTBX);
            this.Controls.Add(this.DelteCriterionBTN);
            this.Controls.Add(this.NextStepBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddCriterionBTN);
            this.Controls.Add(this.AddCriterionTB);
            this.Controls.Add(this.label1);
            this.Name = "CriterionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Критерии";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CriterionsForm_FormClosed);
            this.Load += new System.EventHandler(this.CriterionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DelteCriterionBTN;
        private System.Windows.Forms.Button NextStepBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddCriterionBTN;
        private System.Windows.Forms.TextBox AddCriterionTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox CriterionsListLSTBX;
    }
}