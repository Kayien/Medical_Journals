using CAD_Medical_Journals.DSMedical_JournalsTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_Medical_Journals
{
    public class CADJournal
    {
        private static JournalsTableAdapter adaptador = new JournalsTableAdapter();

        public static DSMedical_Journals.JournalsDataTable GetData()
        {
            return adaptador.GetData();
        }
    }
}
