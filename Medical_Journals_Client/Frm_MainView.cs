using CAD_Medical_Journals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Journals_Client
{
 
    public partial class Frm_MainView : MetroFramework.Forms.MetroForm
    {

        private CADUser usuarioLog;

        public Frm_MainView()
        {
            InitializeComponent();
        }

        public CADUser UsuarioLog
        {
            get{return usuarioLog;}
            set{usuarioLog = value;}
        }

        // Cerrar la aplicación
        private void btnLogout_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Frm_MainView_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSMedical_Journals.Categories' Puede moverla o quitarla según sea necesario.
            this.categoriesTableAdapter.Fill(this.dSMedical_Journals.Categories);
            // TODO: esta línea de código carga datos en la tabla 'dSMedical_Journals.Editorials' Puede moverla o quitarla según sea necesario.
            this.editorialsTableAdapter.Fill(this.dSMedical_Journals.Editorials);
            // TODO: esta línea de código carga datos en la tabla 'dSMedical_Journals.Users' Puede moverla o quitarla según sea necesario.
            this.usersTableAdapter.Fill(this.dSMedical_Journals.Users);
            // TODO: esta línea de código carga datos en la tabla 'dSMedical_Journals.Journals' Puede moverla o quitarla según sea necesario.
            this.journalsTableAdapter.Fill(this.dSMedical_Journals.Journals);
            metroLabel1.Text = "Welcome: " + usuarioLog.UserName;

            string strConn = @"Data Source = (LocalDb)\MSSQLLocalDB; Initial Catalog = HSMedicalJournalsDB; Integrated Security = True";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                string query = "select j.*,c.Name as Category, e.Name as Editorial, u.FirstName, u.LastName " +
                    "from Journals as j Left Join Subscriptions as s on j.Id = s.Journal_Id " +
                    "Left Join Users as u on s.User_Id = u.Id " +
                    "Left join Categories as c on j.Category_Id = c.Id " +
                    "Left join Editorials as e on j.Editorial_Id = e.Id " +
                    "Where s.User_Id = @1";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@1", usuarioLog.Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if(ds.Tables[0].Rows.Count > 0)
                {
                    for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DataRow row = ds.Tables[0].Rows[i];

                        dgvDatos.Rows.Add();
                        dgvDatos.Rows[i].Cells["dgv_Name"].Value = row["Name"];
                        dgvDatos.Rows[i].Cells["dgv_Description"].Value = row["Description"];
                        dgvDatos.Rows[i].Cells["dgv_Price"].Value = row["Price"];
                        dgvDatos.Rows[i].Cells["dgv_Editor"].Value = row["Editor"];
                        dgvDatos.Rows[i].Cells["dgv_Language"].Value = row["Language"];
                        dgvDatos.Rows[i].Cells["dgv_Category"].Value = row["Category"];
                        dgvDatos.Rows[i].Cells["dgv_Editorial"].Value = row["Editorial"];
                        dgvDatos.Rows[i].Cells["dgv_Publisher"].Value = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                        dgvDatos.Rows[i].Cells["dgv_FilePath"].Value = row["FilePath"];
                        dgvDatos.Rows[i].Cells["dgv_PublicationDate"].Value = row["PublicationDate"];
                        dgvDatos.Rows[i].Cells["dgv_Id"].Value = row["Id"];
                    }
                }
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var file = dgvDatos.Rows[e.RowIndex].Cells["dgv_FilePath"].Value.ToString();
            Frm_Viewer myView = new Frm_Viewer();
            string path1 = Environment.CurrentDirectory;
            string path2 = Path.GetFullPath(Path.Combine(path1, @"..\..\..\"));
            path2 += @"HSMedicalJournalsDB\Files\";
             myView.axAcroPDF.src = path2 + file + ".pdf#toolbar=0"; 
            myView.ShowDialog();
        }

        private void dgvDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar( Keys.PrintScreen))
            {
                Clipboard.Clear();
            }
        }
    }
}
