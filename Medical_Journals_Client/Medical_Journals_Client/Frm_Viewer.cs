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
    public partial class Frm_Viewer : MetroFramework.Forms.MetroForm
    {
        
        public Frm_Viewer()
        {
            InitializeComponent();
        }

        private void axAcroPDF_Enter(object sender, EventArgs e)
        {
            axAcroPDF.setShowToolbar(false);
        }
    }
}
