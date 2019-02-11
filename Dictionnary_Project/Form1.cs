using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionnary_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ReadyTochange()
        {
            cboHeadword.DataBindings.Clear();
            cboHeadword.DataBindings.Add("Text", fOLDOCBindingSource, "Headword");
            cboHeadword.AutoCompleteMode = AutoCompleteMode.None;
            cboHeadword.AllowDrop = false;
            btnDone.Visible = true;
            btnCancel.Visible = true;
            rtbDefinition.ReadOnly = false;
        }
        private void ResumeSearch()
        {
            cboHeadword.DataBindings.Clear();
            cboHeadword.DataSource = fOLDOCBindingSource;
            cboHeadword.DisplayMember = "Headword";
            cboHeadword.ValueMember = "Key";
            cboHeadword.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboHeadword.AllowDrop = true;
            btnCancel.Visible = false;
            btnDone.Visible = false;
            rtbDefinition.ReadOnly = true;
            cboHeadword.Focus();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fOLDOCDataSet.FOLDOC' table. You can move, or remove it, as needed.
            this.fOLDOCTableAdapter.Fill(this.fOLDOCDataSet.FOLDOC);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // remenber the current position
            int currentPosition = fOLDOCBindingSource.Position;
            ReadyTochange();
            //get back to current position 
            fOLDOCBindingSource.Position = currentPosition;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            fOLDOCBindingSource.CancelEdit();
            ResumeSearch();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            fOLDOCBindingSource.EndEdit();
            fOLDOCTableAdapter.Update(fOLDOCDataSet.FOLDOC);
            fOLDOCTableAdapter.Fill(fOLDOCDataSet.FOLDOC);
            ResumeSearch();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fOLDOCBindingSource.RemoveCurrent();
                fOLDOCBindingSource.Position = 1;
                fOLDOCBindingSource.EndEdit();
                fOLDOCTableAdapter.Update(fOLDOCDataSet.FOLDOC);
                fOLDOCTableAdapter.Fill(fOLDOCDataSet.FOLDOC);
                cboHeadword.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error removing a word");
            }
        }
        public static string currentHeadWord = "";
        private void advancedSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvancedSearch frmAdvanced = new AdvancedSearch();
            DialogResult dr = frmAdvanced.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                frmAdvanced.Dispose();
                cboHeadword.Text = currentHeadWord;
                ResumeSearch();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
