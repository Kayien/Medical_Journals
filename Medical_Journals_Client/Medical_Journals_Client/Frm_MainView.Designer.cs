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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.buscarToolStrip = new System.Windows.Forms.ToolStrip();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.category_IdToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.buscarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMedical_Journals = new Medical_Journals_Client.DSMedical_Journals();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.editorialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.journalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalsTableAdapter = new Medical_Journals_Client.DSMedical_JournalsTableAdapters.JournalsTableAdapter();
            this.categoriesTableAdapter = new Medical_Journals_Client.DSMedical_JournalsTableAdapters.CategoriesTableAdapter();
            this.editorialsTableAdapter = new Medical_Journals_Client.DSMedical_JournalsTableAdapters.EditorialsTableAdapter();
            this.subscriptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subscriptionsTableAdapter = new Medical_Journals_Client.DSMedical_JournalsTableAdapters.SubscriptionsTableAdapter();
            this.category_IdToolStripTextBox = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.buscarToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMedical_Journals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.languageDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.filePathDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.journalsBindingSource;
            this.dgvDatos.Location = new System.Drawing.Point(23, 112);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(842, 401);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentDoubleClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(721, 77);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 29);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // buscarToolStrip
            // 
            this.buscarToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripLabel,
            this.nameToolStripTextBox,
            this.category_IdToolStripLabel,
            this.category_IdToolStripTextBox,
            this.buscarToolStripButton});
            this.buscarToolStrip.Location = new System.Drawing.Point(20, 60);
            this.buscarToolStrip.Name = "buscarToolStrip";
            this.buscarToolStrip.Size = new System.Drawing.Size(848, 25);
            this.buscarToolStrip.TabIndex = 6;
            this.buscarToolStrip.Text = "buscarToolStrip";
            // 
            // nameToolStripLabel
            // 
            this.nameToolStripLabel.Name = "nameToolStripLabel";
            this.nameToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.nameToolStripLabel.Text = "Name:";
            // 
            // nameToolStripTextBox
            // 
            this.nameToolStripTextBox.Name = "nameToolStripTextBox";
            this.nameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // category_IdToolStripLabel
            // 
            this.category_IdToolStripLabel.Name = "category_IdToolStripLabel";
            this.category_IdToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.category_IdToolStripLabel.Text = "Category:";
            // 
            // buscarToolStripButton
            // 
            this.buscarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buscarToolStripButton.Name = "buscarToolStripButton";
            this.buscarToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.buscarToolStripButton.Text = "Buscar";
            this.buscarToolStripButton.Click += new System.EventHandler(this.buscarToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn7.HeaderText = "Price";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Editor";
            this.dataGridViewTextBoxColumn8.HeaderText = "Editor";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            this.languageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Category_Id";
            this.dataGridViewTextBoxColumn9.DataSource = this.categoriesBindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Category_Id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "Id";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.dSMedical_Journals;
            // 
            // dSMedical_Journals
            // 
            this.dSMedical_Journals.DataSetName = "DSMedical_Journals";
            this.dSMedical_Journals.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Editorial_Id";
            this.dataGridViewTextBoxColumn10.DataSource = this.editorialsBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Editorial_Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "Id";
            // 
            // editorialsBindingSource
            // 
            this.editorialsBindingSource.DataMember = "Editorials";
            this.editorialsBindingSource.DataSource = this.dSMedical_Journals;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Publisher_Id";
            this.dataGridViewTextBoxColumn11.HeaderText = "Publisher_Id";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            this.filePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath";
            this.filePathDataGridViewTextBoxColumn.HeaderText = "FilePath";
            this.filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            this.filePathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // journalsBindingSource
            // 
            this.journalsBindingSource.DataMember = "Journals";
            this.journalsBindingSource.DataSource = this.dSMedical_Journals;
            // 
            // journalsTableAdapter
            // 
            this.journalsTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // editorialsTableAdapter
            // 
            this.editorialsTableAdapter.ClearBeforeFill = true;
            // 
            // subscriptionsBindingSource
            // 
            this.subscriptionsBindingSource.DataMember = "Subscriptions";
            this.subscriptionsBindingSource.DataSource = this.dSMedical_Journals;
            // 
            // subscriptionsTableAdapter
            // 
            this.subscriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // category_IdToolStripTextBox
            // 
            this.category_IdToolStripTextBox.Name = "category_IdToolStripTextBox";
            this.category_IdToolStripTextBox.Size = new System.Drawing.Size(121, 25);
            // 
            // Frm_MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 536);
            this.Controls.Add(this.buscarToolStrip);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_MainView";
            this.Resizable = false;
            this.Text = " Publication\'s";
            this.Load += new System.EventHandler(this.Frm_MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.buscarToolStrip.ResumeLayout(false);
            this.buscarToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMedical_Journals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn editorialIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryIdDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnLogout;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.DataGridView dgvDatos;
        private DSMedical_Journals dSMedical_Journals;
        private System.Windows.Forms.BindingSource journalsBindingSource;
        private DSMedical_JournalsTableAdapters.JournalsTableAdapter journalsTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private DSMedical_JournalsTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource editorialsBindingSource;
        private DSMedical_JournalsTableAdapters.EditorialsTableAdapter editorialsTableAdapter;
        private System.Windows.Forms.BindingSource subscriptionsBindingSource;
        private DSMedical_JournalsTableAdapters.SubscriptionsTableAdapter subscriptionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip buscarToolStrip;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel category_IdToolStripLabel;
        private System.Windows.Forms.ToolStripButton buscarToolStripButton;
        private System.Windows.Forms.ToolStripComboBox category_IdToolStripTextBox;
    }
}