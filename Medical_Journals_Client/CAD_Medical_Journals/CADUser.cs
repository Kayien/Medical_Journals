using CAD_Medical_Journals.DS_Medical_JournalsTableAdapters;
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

        public static bool ValidaUser(string UserName, string PasswordHash)
        {
          if(adaptador.ValidaUser(UserName, PasswordHash) == null)
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

