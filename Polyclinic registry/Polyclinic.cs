using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic_registry
{
    public class Polyclinic : IOperate
    {
        public int numberPolyclinic { get; set; }
        public string adressPolyclinic { get; set; }
        public string telephoneNumberPolyclinic { get; set; }
        public List<Patient> patients { get; set; }

        public Polyclinic()
        {
            numberPolyclinic = 0;
            adressPolyclinic = "Uncnown";
            telephoneNumberPolyclinic = "Uncnown";
            patients = new List<Patient>();
        }
        public Polyclinic(int num, string ap, string tel, List<Patient> patients)
        {
            numberPolyclinic = num;
            adressPolyclinic = ap;
            telephoneNumberPolyclinic = tel;
            this.patients = patients;

        }

        public virtual string Info()
        {
            return String.Format("- Поликлиника №{0}\n" +
                                 "- Адресс: {1}\n" +
                                 "- Телефонный номер: {2}\n",
                                 numberPolyclinic, adressPolyclinic, telephoneNumberPolyclinic);
        }

        public void AddPatient(Patient pa)
        {
            patients.Add(pa);
        }
        public void RemovePatient(int ind)
        {
            patients.RemoveAt(ind);
        }
    }
}
