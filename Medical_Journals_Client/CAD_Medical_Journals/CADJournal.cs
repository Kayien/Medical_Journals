using CAD_Medical_Journals.DS_Medical_JournalsTableAdapters;
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

        public static DS_Medical_Journals.JournalsDataTable GetData()
        {
            return adaptador.GetData();
        }
    }
}
