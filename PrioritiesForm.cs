using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Saati
{
    public partial class PrioritiesForm : Form
    {
        Form parentForm;
        List<String> AlternativesList;
        List<String> CriterionsList;
        bool[] CriterionsTypes;

        int  iteration = 0;
        int jiteration = 0;
        decimal[,] priorities;

        decimal[] CriterionsWeights;

        public PrioritiesForm(Form parentForm, List<String> AlternativesList, List<String> CriterionsList, bool[] CriterionsTypes)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            this.AlternativesList = AlternativesList;
            this.CriterionsList = CriterionsList;
            this.CriterionsTypes = CriterionsTypes;
            this.priorities = new decimal[CriterionsList.Count, CriterionsList.Count];
            this.CriterionsWeights = new decimal[CriterionsList.Count];
            for (int i = 0; i < CriterionsList.Count; i++)
            {
                PrioritiesTableDGV.Columns.Add("column" + i.ToString(), CriterionsList[i]);
                PrioritiesTableDGV.Rows.Add();
                PrioritiesTableDGV.Rows[i].HeaderCell.Value = CriterionsList[i];
            }
        }

        private void nextCompare()
        {
            HowMuchLBL.Text = "Во сколько раз критерий " + CriterionsList[iteration] + " важнее "+ CriterionsList[jiteration]+"?";
        }

        private void PrioritiesForm_Load(object sender, EventArgs e)
        {
            jiteration++;
            nextCompare();
        }

        private void HowMuchBTN_Click(object sender, EventArgs e)
        {
            this.priorities[iteration, jiteration] = HowMuchNUD.Value;
            this.priorities[jiteration, iteration] = 1 / HowMuchNUD.Value;
            jiteration++;
            if (jiteration == this.CriterionsList.Count) { iteration++; jiteration = iteration + 1; }
            if (iteration != this.CriterionsList.Count && jiteration < this.CriterionsList.Count)
            {
                nextCompare();
            } else
            {
                HowMuchBTN.Enabled = HowMuchNUD.Enabled = false;
                NextStepBTN.Enabled = true;
                HowMuchLBL.Text = "Приоритеты для всех критериев введены.";
                if (jiteration == this.CriterionsList.Count) { iteration++; jiteration = iteration; }
                for (int i = 0; i < this.CriterionsList.Count; i++)
                {
                    this.priorities[i, i] = 1;
                }
                for (int i = 0; i < this.CriterionsList.Count; i++)
                {
                    for (int j = 0; j < this.CriterionsList.Count; j++)
                    {
                        PrioritiesTableDGV[j, i].Value = this.priorities[i, j].ToString();
                    }
                }
                PrioritiesTableDGV.Columns.Add("sumstr", "Вес");
                PrioritiesTableDGV.Rows.Add();
                PrioritiesTableDGV.Rows[PrioritiesTableDGV.Rows.Count-1].Cells[PrioritiesTableDGV.Columns.Count - 2].Value = "Сумма";
                PrioritiesTableDGV.Rows[PrioritiesTableDGV.Rows.Count-1].Cells[PrioritiesTableDGV.Columns.Count - 1].Value = "0";
                for (int i = 0; i < this.CriterionsList.Count; i++)
                {
                    PrioritiesTableDGV.Rows[i].Cells["sumstr"].Value = "0";
                    for (int j = 0; j < this.CriterionsList.Count; j++)
                    {
                       PrioritiesTableDGV.Rows[i].Cells["sumstr"].Value = (Convert.ToDecimal(PrioritiesTableDGV.Rows[i].Cells["sumstr"].Value.ToString()) + Convert.ToDecimal(PrioritiesTableDGV[j, i].Value.ToString())).ToString();
                    }
                    PrioritiesTableDGV.Rows[PrioritiesTableDGV.Rows.Count - 1].Cells[PrioritiesTableDGV.Columns.Count - 1].Value = (Convert.ToDecimal(PrioritiesTableDGV.Rows[PrioritiesTableDGV.Rows.Count - 1].Cells[PrioritiesTableDGV.Columns.Count - 1].Value.ToString()) + Convert.ToDecimal(PrioritiesTableDGV.Rows[i].Cells["sumstr"].Value.ToString())).ToString();
                }
                decimal sum = Convert.ToDecimal(PrioritiesTableDGV.Rows[PrioritiesTableDGV.Rows.Count - 1].Cells[PrioritiesTableDGV.Columns.Count - 1].Value.ToString());
                for (int i = 0; i < this.CriterionsList.Count; i++)
                {
                    this.CriterionsWeights[i] = Convert.ToDecimal(PrioritiesTableDGV.Rows[i].Cells["sumstr"].Value.ToString()) / sum;
                    PrioritiesTableDGV.Rows[i].Cells["sumstr"].Value = this.CriterionsWeights[i].ToString();
                }
                PrioritiesTableDGV.Rows[PrioritiesTableDGV.Rows.Count - 1].Cells[PrioritiesTableDGV.Columns.Count - 1].Value = "1";
            }
        }

        private void PrioritiesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parentForm.Close();
        }

        private void NextStepBTN_Click(object sender, EventArgs e)
        {
            CriterionsCompareForm criterionsCompareForm = new CriterionsCompareForm(this, AlternativesList, CriterionsList, CriterionsTypes, CriterionsWeights);
            criterionsCompareForm.Show();
            this.Hide();
        }
    }
}
