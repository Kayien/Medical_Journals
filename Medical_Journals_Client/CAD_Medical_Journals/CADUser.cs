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
        private static UsersTableAdapter adaptador = new UsersTableAdapter();

        public static bool ValidaUser(string Email, string Password)
        {
          if(adaptador.ValidaUser(Email, Password) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

