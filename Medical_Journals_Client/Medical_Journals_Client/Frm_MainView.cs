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
            // TODO: esta línea de código carga datos en la tabla 'dS_Medical_Journals.Journals' Puede moverla o quitarla según sea necesario.
            this.journalsTableAdapter.Fill(this.dS_Medical_Journals.Journals);
        }

        // Cerrar la aplicación
        private void btnLogout_Click(object sender, EventArgs e)
        {

           Application.Exit();        }

        //Evento 2 click para abrir el documento en el viewer PDF
        private void dgvDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          var ruta = dgvDatos.CurrentRow.Cells[5].Value.ToString();
            Frm_Viewer myView = new Frm_Viewer();
            myView.axAcroPDF.src = ruta + "#toolbar=0";
            myView.ShowDialog();



        }

        
    }
}
