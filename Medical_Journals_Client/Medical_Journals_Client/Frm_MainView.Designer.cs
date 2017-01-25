namespace Medical_Journals_Client
{
    partial class Frm_MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainView));
            this.dS_Medical_Journals = new Medical_Journals_Client.DS_Medical_Journals();
            this.journalCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalCategoriesTableAdapter = new Medical_Journals_Client.DS_Medical_JournalsTableAdapters.JournalCategoriesTableAdapter();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.journalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalsTableAdapter = new Medical_Journals_Client.DS_Medical_JournalsTableAdapters.JournalsTableAdapter();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            this.editorialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editorialsTableAdapter = new Medical_Journals_Client.DS_Medical_JournalsTableAdapters.EditorialsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Medical_Journals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dS_Medical_Journals
            // 
            this.dS_Medical_Journals.DataSetName = "DS_Medical_Journals";
            this.dS_Medical_Journals.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journalCategoriesBindingSource
            // 
            this.journalCategoriesBindingSource.DataMember = "JournalCategories";
            this.journalCategoriesBindingSource.DataSource = this.dS_Medical_Journals;
            // 
            // journalCategoriesTableAdapter
            // 
            this.journalCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.publisherIdDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.editorDataGridViewTextBoxColumn,
            this.editorialIdDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.journalsBindingSource;
            this.dgvDatos.Location = new System.Drawing.Point(23, 112);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(842, 401);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // journalsBindingSource
            // 
            this.journalsBindingSource.DataMember = "Journals";
            this.journalsBindingSource.DataSource = this.dS_Medical_Journals;
            // 
            // journalsTableAdapter
            // 
            this.journalsTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.CustomBackground = true;
            this.txtSearch.Location = new System.Drawing.Point(205, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PromptText = "Keywords";
            this.txtSearch.Size = new System.Drawing.Size(474, 29);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroComboBox1.DataSource = this.journalCategoriesBindingSource;
            this.metroComboBox1.DisplayMember = "Name";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(23, 77);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(176, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.ValueMember = "Id";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(685, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search...";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.TileImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.TileImage")));
            this.btnSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // editorialsBindingSource
            // 
            this.editorialsBindingSource.DataMember = "Editorials";
            this.editorialsBindingSource.DataSource = this.dS_Medical_Journals;
            // 
            // editorialsTableAdapter
            // 
            this.editorialsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherIdDataGridViewTextBoxColumn
            // 
            this.publisherIdDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherIdDataGridViewTextBoxColumn.HeaderText = "PublisherId";
            this.publisherIdDataGridViewTextBoxColumn.Name = "publisherIdDataGridViewTextBoxColumn";
            this.publisherIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.publisherIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editorDataGridViewTextBoxColumn
            // 
            this.editorDataGridViewTextBoxColumn.DataPropertyName = "Editor";
            this.editorDataGridViewTextBoxColumn.HeaderText = "Editor";
            this.editorDataGridViewTextBoxColumn.Name = "editorDataGridViewTextBoxColumn";
            this.editorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editorialIdDataGridViewTextBoxColumn
            // 
            this.editorialIdDataGridViewTextBoxColumn.DataPropertyName = "Editorial";
            this.editorialIdDataGridViewTextBoxColumn.DataSource = this.editorialsBindingSource;
            this.editorialIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.editorialIdDataGridViewTextBoxColumn.HeaderText = "EditorialId";
            this.editorialIdDataGridViewTextBoxColumn.Name = "editorialIdDataGridViewTextBoxColumn";
            this.editorialIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.editorialIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editorialIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editorialIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryIdDataGridViewTextBoxColumn.DataSource = this.journalCategoriesBindingSource;
            this.categoryIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(378, 40);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Frm_MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 536);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_MainView";
            this.Resizable = false;
            this.Text = " Publication\'s";
            this.Load += new System.EventHandler(this.Frm_MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Medical_Journals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DS_Medical_Journals dS_Medical_Journals;
        private System.Windows.Forms.BindingSource journalCategoriesBindingSource;
        private DS_Medical_JournalsTableAdapters.JournalCategoriesTableAdapter journalCategoriesTableAdapter;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.BindingSource journalsBindingSource;
        private DS_Medical_JournalsTableAdapters.JournalsTableAdapter journalsTableAdapter;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTile btnSearch;
        private System.Windows.Forms.BindingSource editorialsBindingSource;
        private DS_Medical_JournalsTableAdapters.EditorialsTableAdapter editorialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn editorialIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryIdDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}