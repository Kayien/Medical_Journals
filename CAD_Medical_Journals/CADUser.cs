using CAD_Medical_Journals.DSMedical_JournalsTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_Medical_Journals
{
    public class CADUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        private static UsersTableAdapter adaptador = new UsersTableAdapter();

        public static bool ValidaUser(string UserName, string Password)
        {
          if(adaptador.ValidarUser(UserName, Password) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static CADUser GetUser(string UserName)
        {
            CADUser miUser = null;
            DSMedical_Journals.UsersDataTable miTabla = adaptador.GetUser(UserName);
            if (miTabla.Rows.Count == 0) return miUser;
            DSMedical_Journals.UsersRow miRegistro = (DSMedical_Journals.UsersRow)miTabla.Rows[0];
            miUser = new CADUser();
            miUser.Id = miRegistro.Id;
            miUser.UserName = miRegistro.UserName;
            return miUser;
        }
    }
}

