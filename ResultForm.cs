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
    public partial class ResultForm : Form
    {
        Form parentForm;
        List<String> AlternativesList;
        List<String> CriterionsList;
        bool[] CriterionsTypes;
        decimal[] CriterionsWeights;
        decimal[,] CompareWeights;

        public ResultForm(Form parentForm, List<String> AlternativesList, List<String> CriterionsList, bool[] CriterionsTypes, decimal[] CriterionsWeights, decimal[,] CompareWeights)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            this.AlternativesList = AlternativesList;
            this.CriterionsList = CriterionsList;
            this.CriterionsTypes = CriterionsTypes;
            this.CriterionsWeights = CriterionsWeights;
            this.CompareWeights = CompareWeights;

            CompareResultsDGV.Columns.Add("weight", "Вес критерия");
            for (int i = 0; i < CriterionsList.Count; i++)
            {
                CompareResultsDGV.Rows.Add(CriterionsWeights[i]);
                CompareResultsDGV.Rows[i].HeaderCell.Value = CriterionsList[i];
            }


            for (int i = 0; i < CriterionsList.Count; i++)
            {
                FinalResultDGV.Columns.Add("column" + i.ToString(), CriterionsList[i]);
            }
            for (int i = 0; i < AlternativesList.Count; i++)
            {
                FinalResultDGV.Rows.Add();
                FinalResultDGV.Rows[i].HeaderCell.Value = AlternativesList[i];
            }
            for (int i = 0; i < CriterionsList.Count; i++)
            {
                for (int j = 0; j < AlternativesList.Count; j++)
                {
                    FinalResultDGV[i, j].Value = CompareWeights[i, j].ToString();
                }
            }

            FinalResultDGV.Columns.Add("sumstr", "Вес");
            FinalResultDGV.Rows.Add();
            FinalResultDGV.Rows[FinalResultDGV.Rows.Count - 1].Cells[FinalResultDGV.Columns.Count - 2].Value = "Сумма";
            FinalResultDGV.Rows[FinalResultDGV.Rows.Count - 1].Cells[FinalResultDGV.Columns.Count - 1].Value = "0";

            decimal sr = 0;
            
            for (int i = 0; i < this.CriterionsWeights.Length; i++)
            {
                sr += CriterionsWeights[i];
            }

            decimal maxRes = 0;
            int maxI = 0;
            for (int i = 0; i < this.AlternativesList.Count; i++)
            {
                FinalResultDGV.Rows[i].Cells["sumstr"].Value = "0";
                decimal wsum = 0;
                for (int j = 0; j < this.CriterionsList.Count; j++)
                {
                    wsum += Convert.ToDecimal(FinalResultDGV[j, i].Value.ToString()) * CriterionsWeights[j];
                    FinalResultDGV.Rows[i].Cells["sumstr"].Value = (Convert.ToDecimal(FinalResultDGV.Rows[i].Cells["sumstr"].Value.ToString()) + Convert.ToDecimal(FinalResultDGV[j, i].Value.ToString())).ToString();
                }
                if (i == 0)
                {
                    maxRes = wsum;
                }
                else
                {
                    wsum = wsum / sr;
                    if (wsum > maxRes) { maxRes = wsum; maxI = i; }
                }
                FinalResultDGV.Rows[i].Cells["sumstr"].Value = (wsum).ToString();
                FinalResultDGV.Rows[FinalResultDGV.Rows.Count - 1].Cells[FinalResultDGV.Columns.Count - 1].Value = (Convert.ToDecimal(FinalResultDGV.Rows[FinalResultDGV.Rows.Count - 1].Cells[FinalResultDGV.Columns.Count - 1].Value.ToString()) + Convert.ToDecimal(FinalResultDGV.Rows[i].Cells["sumstr"].Value.ToString())).ToString();
            }
            decimal sum = Convert.ToDecimal(FinalResultDGV.Rows[FinalResultDGV.Rows.Count - 1].Cells[FinalResultDGV.Columns.Count - 1].Value.ToString());
            for (int i = 0; i < this.AlternativesList.Count; i++)
            {
                FinalResultDGV.Rows[i].Cells["sumstr"].Value = (Convert.ToDecimal(FinalResultDGV.Rows[i].Cells["sumstr"].Value.ToString()) / sum).ToString();
            }
            FinalResultDGV.Rows[FinalResultDGV.Rows.Count - 1].Cells[FinalResultDGV.Columns.Count - 1].Value = "1";
            RecomendationLBL.Text = "Рекомендация - " +FinalResultDGV.Rows[maxI].HeaderCell.Value.ToString();
        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Close();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
