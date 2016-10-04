using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saati
{
    public partial class CriterionsForm : Form
    {
        Form parentForm;
        List<String> AlternativesList;

        public CriterionsForm(Form parentForm, List<String> AlternativesList)
        {
            InitializeComponent();

            this.AlternativesList = AlternativesList;
            this.parentForm = parentForm;
        }

        private void AddCriterionBTN_Click(object sender, EventArgs e)
        {
            if (AddCriterionTB.Text != "")
            {
                CriterionsListLSTBX.Items.Add(AddCriterionTB.Text);
            }
            else
            {
                MessageBox.Show("Ну хоть что-то напишите, пожалуйста");
            }
        }

        private void CriterionsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void DelteCriterionBTN_Click(object sender, EventArgs e)
        {
            if (CriterionsListLSTBX.SelectedItems.Count > 0)
            {
                CriterionsListLSTBX.Items.RemoveAt(CriterionsListLSTBX.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Чтобы что-то удалить, надо сначало это выделить, а чтобы было что выделять, надо сначала это добавить.");
            }
        }

        private void CriterionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parentForm.Close();
        }

        private void NextStepBTN_Click(object sender, EventArgs e)
        {
            if (CriterionsListLSTBX.Items.Count > 1)
            {
                List<string> CriterionsList = new List<string>();
                bool[] CriterionsTypes = new bool[CriterionsListLSTBX.Items.Count];
                for (int i = 0; i < CriterionsListLSTBX.Items.Count; i++)
                {
                    CriterionsList.Add(CriterionsListLSTBX.Items[i].ToString());
                    for (int j = 0; j < CriterionsListLSTBX.CheckedIndices.Count; j++)
                    {
                        if (CriterionsListLSTBX.CheckedIndices[j] == i) CriterionsTypes[i] = true;
                    }
                }
                PrioritiesForm prioritiesForm = new PrioritiesForm(this, AlternativesList, CriterionsList, CriterionsTypes);
                prioritiesForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ну хотя бы два критерия, ну пожалуйста...");
            }
        }
    }
}
