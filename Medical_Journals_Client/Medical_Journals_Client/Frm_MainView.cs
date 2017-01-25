using CAD_Medical_Journals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Journals_Client
{
    public partial class Frm_MainView : MetroFramework.Forms.MetroForm
    {
        public Frm_MainView()
        {
            InitializeComponent();
        }

        private void Frm_MainView_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Medical_Journals.Editorials' Puede moverla o quitarla según sea necesario.
            this.editorialsTableAdapter.Fill(this.dS_Medical_Journals.Editorials);
            // TODO: esta línea de código carga datos en la tabla 'dS_Medical_Journals.Journals' Puede moverla o quitarla según sea necesario.
            this.journalsTableAdapter.Fill(this.dS_Medical_Journals.Journals);
            // TODO: esta línea de código carga datos en la tabla 'dS_Medical_Journals.JournalCategories' Puede moverla o quitarla según sea necesario.
            this.journalCategoriesTableAdapter.Fill(this.dS_Medical_Journals.JournalCategories);
            

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
