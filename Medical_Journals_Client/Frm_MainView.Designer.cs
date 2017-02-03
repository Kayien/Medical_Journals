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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainView));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.dgv_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Editor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_PublicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMedical_Journals = new Medical_Journals_Client.DSMedical_Journals();
            this.editorialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMedicalJournalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.journalsTableAdapter = new Medical_Journals_Client.DSMedical_JournalsTableAdapters.JournalsTableAdapter();
            this.usersTableAdapter = new Medical_Journals_Client.DSMedical_JournalsTableAdapters.UsersTableAdapter();
            this.editorialsTableAdapter = new Medical_Journals_Client.DSMedical_JournalsTableAdapters.EditorialsTableAdapter();
            this.categoriesTableAdapter = new Medical_Journals_Client.DSMedical_JournalsTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMedical_Journals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMedicalJournalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_Name,
            this.dgv_Description,
            this.dgv_Price,
            this.dgv_Editor,
            this.dgv_Language,
            this.dgv_Category,
            this.dgv_Editorial,
            this.dgv_Publisher,
            this.dgv_FilePath,
            this.dgv_PublicationDate,
            this.dgv_Id});
            this.dgvDatos.Location = new System.Drawing.Point(23, 112);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(842, 401);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            this.dgvDatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDatos_KeyPress);
            // 
            // dgv_Name
            // 
            this.dgv_Name.HeaderText = "Name";
            this.dgv_Name.Name = "dgv_Name";
            this.dgv_Name.ReadOnly = true;
            // 
            // dgv_Description
            // 
            this.dgv_Description.HeaderText = "Description";
            this.dgv_Description.Name = "dgv_Description";
            this.dgv_Description.ReadOnly = true;
            // 
            // dgv_Price
            // 
            this.dgv_Price.HeaderText = "Price";
            this.dgv_Price.Name = "dgv_Price";
            this.dgv_Price.ReadOnly = true;
            // 
            // dgv_Editor
            // 
            this.dgv_Editor.HeaderText = "Editor";
            this.dgv_Editor.Name = "dgv_Editor";
            this.dgv_Editor.ReadOnly = true;
            // 
            // dgv_Language
            // 
            this.dgv_Language.HeaderText = "Language";
            this.dgv_Language.Name = "dgv_Language";
            this.dgv_Language.ReadOnly = true;
            // 
            // dgv_Category
            // 
            this.dgv_Category.HeaderText = "Category";
            this.dgv_Category.Name = "dgv_Category";
            this.dgv_Category.ReadOnly = true;
            // 
            // dgv_Editorial
            // 
            this.dgv_Editorial.HeaderText = "Editorial";
            this.dgv_Editorial.Name = "dgv_Editorial";
            this.dgv_Editorial.ReadOnly = true;
            // 
            // dgv_Publisher
            // 
            this.dgv_Publisher.HeaderText = "Publisher";
            this.dgv_Publisher.Name = "dgv_Publisher";
            this.dgv_Publisher.ReadOnly = true;
            // 
            // dgv_FilePath
            // 
            this.dgv_FilePath.HeaderText = "FilePath";
            this.dgv_FilePath.Name = "dgv_FilePath";
            this.dgv_FilePath.ReadOnly = true;
            this.dgv_FilePath.Visible = false;
            // 
            // dgv_PublicationDate
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dgv_PublicationDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PublicationDate.HeaderText = "PublicationDate";
            this.dgv_PublicationDate.Name = "dgv_PublicationDate";
            this.dgv_PublicationDate.ReadOnly = true;
            // 
            // dgv_Id
            // 
            this.dgv_Id.HeaderText = "Id";
            this.dgv_Id.Name = "dgv_Id";
            this.dgv_Id.ReadOnly = true;
            this.dgv_Id.Visible = false;
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
            // editorialsBindingSource
            // 
            this.editorialsBindingSource.DataMember = "Editorials";
            this.editorialsBindingSource.DataSource = this.dSMedicalJournalsBindingSource;
            // 
            // dSMedicalJournalsBindingSource
            // 
            this.dSMedicalJournalsBindingSource.DataSource = this.dSMedical_Journals;
            this.dSMedicalJournalsBindingSource.Position = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dSMedical_Journals;
            // 
            // journalsBindingSource
            // 
            this.journalsBindingSource.DataMember = "Journals";
            this.journalsBindingSource.DataSource = this.dSMedical_Journals;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Location = new System.Drawing.Point(724, 75);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(141, 25);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 6;
            // 
            // journalsTableAdapter
            // 
            this.journalsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // editorialsTableAdapter
            // 
            this.editorialsTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 536);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_MainView";
            this.Resizable = false;
            this.Text = " Publication\'s";
            this.Load += new System.EventHandler(this.Frm_MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMedical_Journals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMedicalJournalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnLogout;
        public System.Windows.Forms.DataGridView dgvDatos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private DSMedical_Journals dSMedical_Journals;
        private System.Windows.Forms.BindingSource journalsBindingSource;
        private DSMedical_JournalsTableAdapters.JournalsTableAdapter journalsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DSMedical_JournalsTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource dSMedicalJournalsBindingSource;
        private System.Windows.Forms.BindingSource editorialsBindingSource;
        private DSMedical_JournalsTableAdapters.EditorialsTableAdapter editorialsTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private DSMedical_JournalsTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Editor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_PublicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Id;
    }
}