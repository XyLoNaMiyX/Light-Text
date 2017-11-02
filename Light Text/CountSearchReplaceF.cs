using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Light_Text.Properties;

namespace Light_Text
{
    public partial class CountSearchReplaceF : Form
    {
        public CountSearchReplaceF()
        {
            InitializeComponent();
            SetText();
        }
        
        void SetText() {
			multilineCB.Text = "Búsqueda multilínea";
			countB.Text = "Contar";
			searchB.Text = "Buscar";
			replaceAllB.Text = "Reemplazar";
			ignoreCapital.Text = "Ignorar mayúsculas";
			Text = "Contar, buscar y reemplazar";
		}

        #region Variables

        MainF f = (MainF)Application.OpenForms["MainF"];

        #endregion

        #region Count

        void countB_Click(object sender, EventArgs e)
        {
            string text = f.textEditorRTB.Text;
            int found = TU.Count(toSearchTB.Text, text, ignoreCapital.Checked);

            if (found == 0)
                MessageBox.Show(Resources.notfound, Resources.notfoundt,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (found == 1)
                MessageBox.Show(Resources.foundonce, Resources.foundt,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Resources.foundmulti1 + " " + found + " " + Resources.foundmulti2, Resources.foundt,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Search

        int currentEntry = 0;
        List<int> entriesIndicies = new List<int>();

        bool freshsearch = false;

        void searchB_Click(object sender, EventArgs e)
        {
            Search();
        }

        void toSearchTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (!multilineCB.Checked)
                {
                    Search();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
        }

        void Search()
        {
            string text = f.textEditorRTB.Text;

            if (freshsearch)
            {
                entriesIndicies = TU.Search(toSearchTB.Text, text, ignoreCapital.Checked);
                freshsearch = false;
            }

            if (entriesIndicies.Count == 0)
                entriesIndicies = TU.Search(toSearchTB.Text, text, ignoreCapital.Checked);
            if (entriesIndicies.Count == 0)
                return;

            f.Focus();
            f.textEditorRTB.Select(entriesIndicies[currentEntry], toSearchTB.Text.Length);

            currentEntry++;
            if (currentEntry >= entriesIndicies.Count)
                currentEntry = 0;
        }

        #endregion

        #region Replace

        void replaceAllB_Click(object sender, EventArgs e)
        {
            ReplaceAll();
        }

        void replaceWithTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (!multilineCB.Checked)
                {
                    ReplaceAll();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
        }

        void ReplaceAll() {
            string text = f.textEditorRTB.Text;

            if (TU.Count(toSearchTB.Text, text, ignoreCapital.Checked) == 0)
            {
                MessageBox.Show("El texto introducido no se ha encontrado", "Texto no encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            f.textEditorRTB.Text = text.Replace(toSearchTB.Text, replaceWithTB.Text);
        }

        #endregion

        #region Another handlers

        void toSearchTB_TextChanged(object sender, EventArgs e)
        {
            freshsearch = true;
        }

        void ignoreCapital_CheckedChanged(object sender, EventArgs e)
        {
            freshsearch = true;
        }

        void multilineCB_CheckedChanged(object sender, EventArgs e)
        {
            toSearchTB.Multiline = multilineCB.Checked;
            replaceWithTB.Multiline = multilineCB.Checked;
        }

        #endregion
    }
}
