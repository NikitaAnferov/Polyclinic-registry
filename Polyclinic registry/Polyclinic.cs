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
        public List<Medic> medics { get; set; }

        public Polyclinic()
        {
            numberPolyclinic = 0;
            adressPolyclinic = "Uncnown";
            telephoneNumberPolyclinic = "Uncnown";
            patients = new List<Patient>();
            medics = new List<Medic>();
        }
        public Polyclinic(int num, string ap, string tel, List<Patient> patients, List<Medic> medics)
        {
            numberPolyclinic = num;
            adressPolyclinic = ap;
            telephoneNumberPolyclinic = tel;
            this.patients = patients;
            this.medics = medics;

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
        public void AddMedic(Medic me)
        {
            medics.Add(me);
        }

        public void RemovePatient(int ind)
        {
            patients.RemoveAt(ind);
        }
    }
}
