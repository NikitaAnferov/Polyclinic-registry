using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryHuman;

namespace Polyclinic_registry
{
    public class Patient : Human
    {
        public string policyNumber { get; set; }
        public BloodType bloodt { get; set; }
        public enum BloodType { I, II, III, IV};

        public Patient() : base()
        {
            policyNumber = "Uncnown";
            bloodt = BloodType.I;
        }

        public Patient(string fio, Gender g, DateTime bd, string policynum, BloodType bt) 
            : base(fio, g, bd)
        {
            policyNumber = policynum;
            bloodt = bt;
        }

        public override string GetInfo()
        {
            return string.Format("- {0}\n" +
                                 "- Пол: {1}\n" +
                                 "- Дата рождения: {2}\n" +
                                 "- Номер полиса: {3}\n" +
                                 "- Группа крови: {4}\n",
                                 fio, Gender.мужской, birthdate, policyNumber, bloodt);
        }
    }
}
