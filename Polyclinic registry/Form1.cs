using ClassLibraryHuman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyclinic_registry
{
    public partial class Form1 : Form
    {
        Polyclinic polyclinic;
        Medic medic;

        public Form1()
        {
            InitializeComponent();
            polyclinic = new Polyclinic(6, "ул. Мимолетная 7", "8-800-555-35-35", new List<Patient>());

            Add_Patient("Задорнов Алексей Игоревич", Human.Gender.мужской, new DateTime(1990, 07, 16), "29367456", Patient.BloodType.II);
            // AddNew_Treatment(new DateTime(2021, 05, 04), p.fio, "отрицательные", "здоров");

            Add_Patient("Александров Василий Петрович", Human.Gender.мужской, new DateTime(2001, 11, 03), "58793468", Patient.BloodType.IV);
            //AddNew_Treatment(new DateTime(2021, 05, 04), p.fio, "положительные", "отравление");

            Add_Patient("Андреева Евгения Игоревна", Human.Gender.женский, new DateTime(1999, 01, 12), "45983879", Patient.BloodType.I);
            //AddNew_Treatment(new DateTime(2021, 05, 04), p.fio, "положительные", "гастрит");

            medic = new Medic("Игнатова Екатерина Григольевна", Human.Gender.женский, new DateTime(1987, 03, 12), "Стоматолог", "Старший врач стоматолог", new DateTime(2005, 01, 30), new List<Treatment>());
            medic = new Medic("Шмаков Игорь Валентинович", Human.Gender.мужской, new DateTime(2000, 03, 06), "Массажист", "Стажер", new DateTime(2005, 01, 30), new List<Treatment>());
            medic = new Medic("Шмакова Ирина Валентиновна", Human.Gender.женский, new DateTime(2000, 03, 06), "Гинеколог", "Стажер", new DateTime(2005, 01, 30), new List<Treatment>());
            /*
            foreach (Patient p in polyclinic.patients)
            {
                AddNew_Treatment(new DateTime(2021, 05, 04), p.fio, "отрицательные", "здоров");
                AddNew_Treatment(new DateTime(2021, 05, 04), p.fio, "положительные", "отравление");
                AddNew_Treatment(new DateTime(2021, 05, 04), p.fio, "положительные", "гастрит");
            }
            */
        }

        //======================================
        public void RefreshPatients() //вот как эту херь правильно написать?!

        {
            dataGridViewPoliclinicData.Rows.Clear();
            dataGridViewPoliclinicData.RowCount = polyclinic.patients.Count;
            int i = 0;
            foreach (Patient p in polyclinic.patients)
            {
                dataGridViewPoliclinicData[0, i].Value = p.fio;
                dataGridViewPoliclinicData[1, i].Value = p.policyNumber;
                i++;
                int j = 0;
                foreach (Treatment t in medic.treatments)
                {
                    if (p.fio == t.fioPatient)
                    {
                        dataGridViewPoliclinicData[2, j].Value = t.testResults;
                        dataGridViewPoliclinicData[3, j].Value = t.diagnostic;
                        j++;
                    }
                    else
                    {
                        dataGridViewPoliclinicData[2, j].Value = "Uncnown";
                        dataGridViewPoliclinicData[3, j].Value = "Uncnown";
                        j++;
                    }
                }
            }
            
            
        }
        //=====================================

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPoliclinicInformation.Text = polyclinic.Info();
            RefreshPatients();
        }

        public void Add_Patient(string fio, Human.Gender gender, DateTime bd, string nump, Patient.BloodType bloodType)
        {
            polyclinic.AddPatient(new Patient(fio, gender, bd,nump, bloodType));
        }

        static public void AddNew_Treatment(DateTime dt, string fp, string tr, string diag)
        {
            Treatments.AddNewTreatment(new Treatment(dt, fp, tr, diag));
        }

        private void buttonAddPatirent_Click(object sender, EventArgs e)
        {
            groupBoxPatient.Visible = true;
            groupBoxTreatment.Visible = false;
        }

        private void buttonAddTreatment_Click(object sender, EventArgs e)
        {
            groupBoxTreatment.Visible = true;
            groupBoxPatient.Visible = false;
        }

        private void buttonComplitePacient_Click(object sender, EventArgs e)
        {
            Human.Gender gender;
            if (radioButtonGenderM.Checked) gender = Human.Gender.мужской;
            else gender = Human.Gender.женский;

            Patient.BloodType blood;
            if (radioButtonGBI.Checked) blood = Patient.BloodType.I;
            else if (radioButtonGBII.Checked) blood = Patient.BloodType.II;
            else if(radioButtonGBIII.Checked) blood = Patient.BloodType.III;
            else blood = Patient.BloodType.IV;

            Add_Patient(textBoxFio.Text, gender, dateTimePickerDateBd.Value, textBoxNumPolis.Text, blood);

            groupBoxPatient.Visible = false;
            textBoxChekPolis.Clear();
            textBoxNumPolis.Clear();
            textBoxFio.Clear();
            RefreshPatients();
        }

        private void buttonComoliteTreatment_Click(object sender, EventArgs e)
        {
            string fioPatient = "Unknown";
            foreach (Patient p in polyclinic.patients)
                if (textBoxChekPolis.Text == p.policyNumber) fioPatient = p.fio;
            AddNew_Treatment(dateTimePickerTreatment.Value, fioPatient, textBoxResTests.Text, textBoxdiagnostic.Text);


            groupBoxTreatment.Visible = false;
            RefreshPatients();
        }


    }
}

