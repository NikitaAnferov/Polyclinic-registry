using ClassLibraryHuman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyclinic_registry
{
    public struct Treatment
    {
        static int count;
        public DateTime dateOfTreatment { get; set; }
        public string fioPatient { get; set; }//как тебя получит падла?
        public string fioMedic { get; set; }
        public string testResults { get; set; }
        public string diagnostic { get; set; }
        //string fiop;
        
        public Treatment(DateTime dt, string fp, string fm, string tr, string diag)
        {
            count++;
            dateOfTreatment = dt;
            fioPatient = fp;
            fioMedic = fm;
            testResults = tr;
            diagnostic = diag;
        }


        public string Info()
        {
            return string.Format("- Код обращения: {0}\n" +
                                 "- ФИО пациента: {1}\n" +
                                 "- Результаты анализов: {2}\n" +
                                 "- Диагноз: {3}\n",
                                 count, dateOfTreatment, fioPatient, testResults, diagnostic);
        }
    }
}
