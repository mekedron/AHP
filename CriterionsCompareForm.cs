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
    public partial class CriterionsCompareForm : Form
    {
        Form parentForm;
        List<String> AlternativesList;
        List<String> CriterionsList;
        bool[] CriterionsTypes;
        decimal[] CriterionsWeights;
        decimal[,] CompareWeights;

        int citeration = 0;
        int  iteration = 0;
        int jiteration = 0;
        decimal[,,] CompareAll;

        public CriterionsCompareForm(Form parentForm, List<String> AlternativesList, List<String> CriterionsList, bool[] CriterionsTypes, decimal[] CriterionsWeights)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            this.AlternativesList = AlternativesList;
            this.CriterionsList = CriterionsList;
            this.CriterionsTypes = CriterionsTypes;
            this.CriterionsWeights = CriterionsWeights;

            drawEmptyTable();

            this.CompareAll = new decimal[CriterionsList.Count, this.AlternativesList.Count, this.AlternativesList.Count];
            this.CompareWeights = new decimal[CriterionsList.Count, this.AlternativesList.Count];
        }
        private void drawEmptyTable ()
        {
            PrioritiesTableDGV.Rows.Clear();
            PrioritiesTableDGV.Columns.Clear();
            for (int i = 0; i < AlternativesList.Count; i++)
            {
                PrioritiesTableDGV.Columns.Add("column" + i.ToString(), AlternativesList[i]);
                PrioritiesTableDGV.Rows.Add();
                PrioritiesTableDGV.Rows[i].HeaderCell.Value = AlternativesList[i];
            }
        }

        private void nextCompare()
        {
            HowMuchLBL.Text = "Критерий "+CriterionsList[citeration]+" для " + AlternativesList[iteration] + " и "+ AlternativesList[jiteration] + "?";
        }

        private void nextCiteration()
        {
            citeration++;
            iteration = 0;
            jiteration = 1;
            drawEmptyTable();
        }

        private void CriterionsCompareForm_Load(object sender, EventArgs e)
        {
            jiteration++;
            nextCompare();
        }

        private void HowMuchBTN_Click(object sender, EventArgs e)
        {
            this.CompareAll[citeration, iteration, jiteration] = HowMuchNUD.Value;
            this.CompareAll[citeration, jiteration, iteration] = 1 / HowMuchNUD.Value;
            jiteration++;
            if (jiteration == this.AlternativesList.Count) { iteration++; jiteration = iteration + 1; }
            if (iteration != this.AlternativesList.Count && jiteration < this.AlternativesList.Count)
            {
                nextCompare();
            }
            else
            {
                HowMuchBTN.Enabled = HowMuchNUD.Enabled = false;
                NextStepBTN.Enabled = true;
                HowMuchLBL.Text = "Сравнения для критерия "+ CriterionsList[citeration]+" произведены:";
                if (jiteration == this.AlternativesList.Count) { iteration++; jiteration = iteration; }
                for (int i = 0; i < this.AlternativesList.Count; i++)
                {
                    this.CompareAll[citeration, i, i] = 1;
                }
                for (int i = 0; i < this.AlternativesList.Count; i++)
                {
                    for (int j = 0; j < this.AlternativesList.Count; j++)
                    {
                        PrioritiesTableDGV[j, i].Value = this.CompareAll[citeration, i, j].ToString();
                    }
                }
                PrioritiesTableDGV.Columns.Add("sumstr", "Вес");
                PrioritiesTableDGV.Rows.Add();
                PrioritiesTableDGV.Rows[PrioritiesTableDGV.Rows.Count - 1].Cells[PrioritiesTableDGV.Columns.Count - 2].Value = "Сумма";
                PrioritiesTableDGV.Rows[PrioritiesTableDGV.Rows.Count - 1].Cells[PrioritiesTableDGV.Columns.Count - 1].Value = "0";
                for (int i = 0; i < this.AlternativesList.Count; i++)
                {
                    PrioritiesTableDGV.Rows[i].Cells["sumstr"].Value = "0";
                    for (int j = 0; j < this.AlternativesList.Count; j++)
                    {
                        PrioritiesTableDGV.Rows[i].Cells["sumstr"].Value = (Convert.ToDecimal(PrioritiesTableDGV.Rows[i].Cells["sumstr"].Value.ToString()) + Convert.ToDecimal(PrioritiesTableDGV[j, i].Value.ToString())).ToString();
                    }
                    PrioritiesTableDGV.Rows[PrioritiesTableDGV.Rows.Count - 1].Cells[PrioritiesTableDGV.Columns.Count - 1].Value = (Convert.ToDecimal(PrioritiesTableDGV.Rows[PrioritiesTableDGV.Rows.Count - 1].Cells[PrioritiesTableDGV.Columns.Count - 1].Value.ToString()) + Convert.ToDecimal(PrioritiesTableDGV.Rows[i].Cells["sumstr"].Value.ToString())).ToString();
                }
                decimal sum = Convert.ToDecimal(PrioritiesTableDGV.Rows[PrioritiesTableDGV.Rows.Count - 1].Cells[PrioritiesTableDGV.Columns.Count - 1].Value.ToString());
                for (int i = 0; i < this.AlternativesList.Count; i++)
                {
                    this.CompareWeights[citeration, i] = Convert.ToDecimal(PrioritiesTableDGV.Rows[i].Cells["sumstr"].Value.ToString()) / sum;
                    PrioritiesTableDGV.Rows[i].Cells["sumstr"].Value = this.CompareWeights[citeration, i].ToString();
                }
                PrioritiesTableDGV.Rows[PrioritiesTableDGV.Rows.Count - 1].Cells[PrioritiesTableDGV.Columns.Count - 1].Value = "1";
            }
        }
        
        private void CriterionsCompareForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parentForm.Close();
        }

        private void NextStepBTN_Click(object sender, EventArgs e)
        {
            HowMuchBTN.Enabled = HowMuchNUD.Enabled = true;
            NextStepBTN.Enabled = false;
            nextCiteration();
            if (citeration == CriterionsList.Count)
            {
                HowMuchBTN.Enabled = HowMuchNUD.Enabled = NextStepBTN.Enabled = false;
                ResultForm resultForm = new ResultForm(this, AlternativesList, CriterionsList, CriterionsTypes, CriterionsWeights, CompareWeights);
                resultForm.Show();
                this.Hide();
            }
            else
            {
                nextCompare();
            }
        }
    }
}
