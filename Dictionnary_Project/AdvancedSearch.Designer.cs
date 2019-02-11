namespace Dictionnary_Project
{
    partial class AdvancedSearch
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbDefinition = new System.Windows.Forms.TextBox();
            this.fOLDOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOLDOCDataSet = new Dictionnary_Project.FOLDOCDataSet();
            this.lstHeadword = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnPword = new System.Windows.Forms.Button();
            this.btnBeginWithS = new System.Windows.Forms.Button();
            this.btnAllFieldS = new System.Windows.Forms.Button();
            this.btnEndWithS = new System.Windows.Forms.Button();
            this.fOLDOCTableAdapter = new Dictionnary_Project.FOLDOCDataSetTableAdapters.FOLDOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Definiton:";
            // 
            // rtbDefinition
            // 
            this.rtbDefinition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fOLDOCBindingSource, "Definition", true));
            this.rtbDefinition.Location = new System.Drawing.Point(15, 325);
            this.rtbDefinition.Multiline = true;
            this.rtbDefinition.Name = "rtbDefinition";
            this.rtbDefinition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rtbDefinition.Size = new System.Drawing.Size(501, 231);
            this.rtbDefinition.TabIndex = 16;
            // 
            // fOLDOCBindingSource
            // 
            this.fOLDOCBindingSource.DataMember = "FOLDOC";
            this.fOLDOCBindingSource.DataSource = this.fOLDOCDataSet;
            // 
            // fOLDOCDataSet
            // 
            this.fOLDOCDataSet.DataSetName = "FOLDOCDataSet";
            this.fOLDOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lstHeadword
            // 
            this.lstHeadword.DataSource = this.fOLDOCBindingSource;
            this.lstHeadword.DisplayMember = "Headword";
            this.lstHeadword.FormattingEnabled = true;
            this.lstHeadword.Location = new System.Drawing.Point(15, 118);
            this.lstHeadword.Name = "lstHeadword";
            this.lstHeadword.ScrollAlwaysVisible = true;
            this.lstHeadword.Size = new System.Drawing.Size(502, 147);
            this.lstHeadword.TabIndex = 15;
            this.lstHeadword.UseTabStops = false;
            this.lstHeadword.ValueMember = "Headword";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 82);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(504, 30);
            this.txtSearch.TabIndex = 14;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDone.Location = new System.Drawing.Point(436, 23);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(83, 38);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "&Done";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // btnPword
            // 
            this.btnPword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPword.Location = new System.Drawing.Point(15, 23);
            this.btnPword.Name = "btnPword";
            this.btnPword.Size = new System.Drawing.Size(83, 38);
            this.btnPword.TabIndex = 12;
            this.btnPword.Text = "&Partial Word ";
            this.btnPword.UseVisualStyleBackColor = false;
            this.btnPword.Click += new System.EventHandler(this.btnPword_Click);
            // 
            // btnBeginWithS
            // 
            this.btnBeginWithS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBeginWithS.Location = new System.Drawing.Point(101, 23);
            this.btnBeginWithS.Name = "btnBeginWithS";
            this.btnBeginWithS.Size = new System.Drawing.Size(83, 38);
            this.btnBeginWithS.TabIndex = 11;
            this.btnBeginWithS.Text = "&Begin With Search ";
            this.btnBeginWithS.UseVisualStyleBackColor = false;
            this.btnBeginWithS.Click += new System.EventHandler(this.btnBeginWithS_Click);
            // 
            // btnAllFieldS
            // 
            this.btnAllFieldS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAllFieldS.Location = new System.Drawing.Point(279, 23);
            this.btnAllFieldS.Name = "btnAllFieldS";
            this.btnAllFieldS.Size = new System.Drawing.Size(83, 38);
            this.btnAllFieldS.TabIndex = 10;
            this.btnAllFieldS.Text = "&All Field Search";
            this.btnAllFieldS.UseVisualStyleBackColor = false;
            this.btnAllFieldS.Click += new System.EventHandler(this.btnAllFieldS_Click);
            // 
            // btnEndWithS
            // 
            this.btnEndWithS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEndWithS.Location = new System.Drawing.Point(190, 23);
            this.btnEndWithS.Name = "btnEndWithS";
            this.btnEndWithS.Size = new System.Drawing.Size(83, 38);
            this.btnEndWithS.TabIndex = 9;
            this.btnEndWithS.Text = "&End With Search ";
            this.btnEndWithS.UseVisualStyleBackColor = false;
            this.btnEndWithS.Click += new System.EventHandler(this.btnEndWithS_Click);
            // 
            // fOLDOCTableAdapter
            // 
            this.fOLDOCTableAdapter.ClearBeforeFill = true;
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(531, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbDefinition);
            this.Controls.Add(this.lstHeadword);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnPword);
            this.Controls.Add(this.btnBeginWithS);
            this.Controls.Add(this.btnAllFieldS);
            this.Controls.Add(this.btnEndWithS);
            this.Name = "AdvancedSearch";
            this.Text = "AdvancedSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdvancedSearch_FormClosing);
            this.Load += new System.EventHandler(this.AdvancedSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rtbDefinition;
        private System.Windows.Forms.ListBox lstHeadword;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnPword;
        private System.Windows.Forms.Button btnBeginWithS;
        private System.Windows.Forms.Button btnAllFieldS;
        private System.Windows.Forms.Button btnEndWithS;
        private FOLDOCDataSet fOLDOCDataSet;
        private System.Windows.Forms.BindingSource fOLDOCBindingSource;
        private FOLDOCDataSetTableAdapters.FOLDOCTableAdapter fOLDOCTableAdapter;
    }
}