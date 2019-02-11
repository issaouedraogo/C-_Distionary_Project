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
    public partial class AdvancedSearch : Form
    {
        public AdvancedSearch()
        {
            InitializeComponent();
        }

        private void AdvancedSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fOLDOCDataSet.FOLDOC' table. You can move, or remove it, as needed.
            this.fOLDOCTableAdapter.Fill(this.fOLDOCDataSet.FOLDOC);

        }

        private void btnPword_Click(object sender, EventArgs e)
        {
           
            var query = from word in fOLDOCDataSet.FOLDOC
                        where word.Headword.ToUpper().Contains(txtSearch.Text.ToUpper())
                        select word;
            fOLDOCBindingSource.DataSource= query.AsDataView();
        }

        private void btnBeginWithS_Click(object sender, EventArgs e)
        {
            var query = from word in fOLDOCDataSet.FOLDOC
                        where word.Headword.ToUpper().StartsWith(txtSearch.Text.ToUpper())
                        select word;
            fOLDOCBindingSource.DataSource = query.AsDataView();
        }

        private void btnEndWithS_Click(object sender, EventArgs e)
        {
            var query = from word in fOLDOCDataSet.FOLDOC
                        where word.Headword.ToUpper().EndsWith(txtSearch.Text.ToUpper())
                        select word;
            fOLDOCBindingSource.DataSource = query.AsDataView();
        }

        private void btnAllFieldS_Click(object sender, EventArgs e)
        {
            var query = from word in fOLDOCDataSet.FOLDOC
                        where word.Headword.ToUpper().Contains(
                        txtSearch.Text.ToUpper()) || 
                        word.Definition.ToUpper().Contains(
                        txtSearch.Text.ToUpper())
                        select word;
            fOLDOCBindingSource.DataSource = query.AsDataView();
        }

        private void AdvancedSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fOLDOCBindingSource.Current != null)

            {
                Form1.currentHeadWord = lstHeadword.SelectedValue.ToString();

            }
            else
            {
                Form1.currentHeadWord = "";
            }
        }
    }
}
