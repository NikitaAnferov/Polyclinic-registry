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

        public Form1()
        {
            InitializeComponent();
            polyclinic = new Polyclinic(6, "ул. Мимолетная 7", "8-800-555-35-35", new List<Patient>(), new List<Medic>());

            Add_Medic("Игнатова Екатерина Григольевна", Human.Gender.женский, new DateTime(1987, 03, 12), "Стоматолог", "Старший врач стоматолог", new DateTime(2005, 01, 30), new List<Treatment>());

            Add_Medic("Шмаков Игорь Валентинович", Human.Gender.мужской, new DateTime(2000, 03, 06), "Массажист", "Стажер", new DateTime(2005, 01, 30), new List<Treatment>());

            Add_Medic("Шмакова Ирина Валентиновна", Human.Gender.женский, new DateTime(2000, 03, 06), "Гинеколог", "Стажер", new DateTime(2005, 01, 30), new List<Treatment>());

            Add_Patient("Задорнов Алексей Игоревич", Human.Gender.мужской, new DateTime(1990, 07, 16), "29367456", Patient.BloodType.II);
            AddNew_Treatment(new DateTime(2021, 05, 04), polyclinic.patients.Last().fio, polyclinic.medics[0].fio, "отрицательные", "здоров");

            Add_Patient("Александров Василий Петрович", Human.Gender.мужской, new DateTime(2001, 11, 03), "58793468", Patient.BloodType.IV);
            AddNew_Treatment(new DateTime(2021, 05, 04), polyclinic.patients.Last().fio, polyclinic.medics[1].fio, "положительные", "отравление");

            Add_Patient("Андреева Евгения Игоревна", Human.Gender.женский, new DateTime(1999, 01, 12), "45983879", Patient.BloodType.I);
            AddNew_Treatment(new DateTime(2021, 05, 04), polyclinic.patients.Last().fio, polyclinic.medics[2].fio, "положительные", "гастрит");
        }

        public void RefreshPatients() //вот как эту херь правильно написать?!

        {
            dataGridViewPoliclinicData.Rows.Clear();
            if (polyclinic.patients.Count == 0)
                return;
            dataGridViewPoliclinicData.RowCount = polyclinic.patients.Count;
            int i = 0;
            foreach (Patient p in polyclinic.patients)
            {
                dataGridViewPoliclinicData[0, i].Value = p.fio;
                dataGridViewPoliclinicData[1, i].Value = p.policyNumber;
                dataGridViewPoliclinicData[2, i].Value = p.birthdate;
                dataGridViewPoliclinicData[3, i].Value = p.gen;
                dataGridViewPoliclinicData[4, i].Value = p.bloodt;
                dataGridViewPoliclinicData[5, i].Value = CountTreatmentsPatient(p.fio);
                i++;
            }
            
            
        }
        //=====================================

        public void RefreshMedics() 
        {
            dataGridViewMedics.Rows.Clear();
            if (polyclinic.medics.Count == 0)
                return;
            dataGridViewMedics.RowCount = polyclinic.medics.Count;
            int i = 0;
            foreach (Medic m in polyclinic.medics)
            {
                dataGridViewMedics[0, i].Value = m.specialty;
                dataGridViewMedics[1, i].Value = m.fio;
                dataGridViewMedics[2, i].Value = m.position;
                dataGridViewMedics[3, i].Value = m.dateOfCommencement;
                dataGridViewMedics[4, i].Value = m.treatments.Count;
                i++;
            }
        }

        public void RefreshTreatment()
        {
            dataGridViewTreatmens.Rows.Clear();
            if (Treatments.treatments.Count == 0)
                return;
            dataGridViewTreatmens.RowCount = Treatments.treatments.Count;
            int i = 0;
            foreach (Treatment t in Treatments.treatments)
            {
                dataGridViewTreatmens[0, i].Value = t.dateOfTreatment;
                dataGridViewTreatmens[1, i].Value = t.fioPatient;
                dataGridViewTreatmens[2, i].Value = t.fioMedic;
                dataGridViewTreatmens[3, i].Value = t.testResults;
                dataGridViewTreatmens[4, i].Value = t.diagnostic;
                i++;
            }

            groupBox3.Text = "Все обращения";
        }

        public void RefreshTreatmentM(string fioMedic)

        {
            Medic medic = new Medic();
            foreach (Medic m in polyclinic.medics)
            {
                if (m.fio == fioMedic)
                {
                    medic = m;
                    break;
                }
            }

            dataGridViewTreatmens.Rows.Clear();
            if (medic.treatments.Count == 0)
                return;
            dataGridViewTreatmens.RowCount = medic.treatments.Count;
            int i = 0;
            foreach (Treatment t in medic.treatments)
            {
                dataGridViewTreatmens[0, i].Value = t.dateOfTreatment;
                dataGridViewTreatmens[1, i].Value = t.fioPatient;
                dataGridViewTreatmens[2, i].Value = t.fioMedic;
                dataGridViewTreatmens[3, i].Value = t.testResults;
                dataGridViewTreatmens[4, i].Value = t.diagnostic;
                i++;
            }

            groupBox3.Text = String.Format("Обращения к врачу {0}", medic.fio);
        }

        public void RefreshTreatmentP(string fioPatient)

        {
            Patient patient = new Patient();
            foreach (Patient p in polyclinic.patients)
            {
                if (p.fio == fioPatient)
                {
                    patient = p;
                    break;
                }
            }

            dataGridViewTreatmens.Rows.Clear();
            int count = CountTreatmentsPatient(fioPatient);
            if (count == 0)
                return;
            dataGridViewTreatmens.RowCount = count;
            int i = 0;
            foreach (Medic m in polyclinic.medics)
            {
                foreach (Treatment t in m.treatments)
                {
                    if (t.fioPatient == fioPatient)
                    {
                        dataGridViewTreatmens[0, i].Value = t.dateOfTreatment;
                        dataGridViewTreatmens[1, i].Value = t.fioPatient;
                        dataGridViewTreatmens[2, i].Value = t.fioMedic;
                        dataGridViewTreatmens[3, i].Value = t.testResults;
                        dataGridViewTreatmens[4, i].Value = t.diagnostic;
                        i++;
                    }
                }
            }

            groupBox3.Text = String.Format("Обращения пациента {0}", patient.fio);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPoliclinicInformation.Text = polyclinic.Info();
            buttonViewAllTreatments_Click(sender,  e);
        }

        public void Add_Patient(string fio, Human.Gender gender, DateTime bd, string nump, Patient.BloodType bloodType)
        {
            polyclinic.AddPatient(new Patient(fio, gender, bd,nump, bloodType));
        }

        public void Add_Medic(string fio, Human.Gender gender, DateTime bd, string spec, string pos, DateTime dcom, List<Treatment> treatments)
        {
            polyclinic.AddMedic(new Medic(fio, gender, bd, spec, pos, dcom, treatments));
        }

         public void AddNew_Treatment(DateTime dt, string fp, string fm, string tr, string diag)
        {
            Treatments.AddNewTreatment(new Treatment(dt, fp, fm, tr, diag));
            Medic medic = new Medic();
            foreach (Medic m in polyclinic.medics)
            {
                if (m.fio == fm)
                {
                    medic = m;
                    break;
                }
            }
            medic.AddTreatment(Treatments.treatments.Last());
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
            textBoxNumPolis.Clear();
            textBoxFio.Clear();
            RefreshAll();
        }

        private void buttonComoliteTreatment_Click(object sender, EventArgs e)
        {
            if (dataGridViewPoliclinicData.CurrentCell != null
                && dataGridViewMedics.CurrentCell != null
                && polyclinic.patients.Count != 0)
            {
                string fioPatient = dataGridViewPoliclinicData.Rows[dataGridViewPoliclinicData.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string fioMedic = dataGridViewMedics.Rows[dataGridViewMedics.CurrentCell.RowIndex].Cells[1].Value.ToString();
                AddNew_Treatment(dateTimePickerTreatment.Value, fioPatient, fioMedic, textBoxResTests.Text, textBoxdiagnostic.Text);

                groupBoxTreatment.Visible = false;
                RefreshAll();
            }
        }

        private void buttonViewAllTreatments_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void dataGridViewMedics_MouseUp(object sender, MouseEventArgs e)
        {
            if(SelectedRows(dataGridViewMedics) &&
                dataGridViewMedics.Rows[dataGridViewMedics.CurrentCell.RowIndex].Cells[1].Value != null)
            RefreshTreatmentM(dataGridViewMedics.Rows[dataGridViewMedics.CurrentCell.RowIndex].Cells[1].Value.ToString());
        }
        private void dataGridViewPoliclinicData_MouseUp(object sender, MouseEventArgs e)
        {
            if(SelectedRows(dataGridViewPoliclinicData) &&
                dataGridViewPoliclinicData.Rows[dataGridViewPoliclinicData.CurrentCell.RowIndex].Cells[0].Value != null)
            RefreshTreatmentP(dataGridViewPoliclinicData.Rows[dataGridViewPoliclinicData.CurrentCell.RowIndex].Cells[0].Value.ToString());
        }

        private void dataGridViewTreatmens_MouseUp(object sender, MouseEventArgs e)
        {
            SelectedRows(dataGridViewTreatmens);
        }

        private bool SelectedRows(DataGridView dataGridView)
        {
            if (dataGridView.CurrentCell != null)
            {
                int cellRow = dataGridView.CurrentCell.RowIndex;
                dataGridView.Rows[cellRow].Selected = true;
                return true;
            }
            return false;
        }


        private void RefreshAll()
        {
            RefreshMedics();
            RefreshPatients();
            RefreshTreatment();
        }

        private void buttonRemovePatient_Click(object sender, EventArgs e)
        {
            if (dataGridViewPoliclinicData.CurrentCell != null &&
                polyclinic.patients.Count != 0)
            {
                String fioPatient = dataGridViewPoliclinicData.Rows[dataGridViewPoliclinicData.CurrentCell.RowIndex].Cells[0].Value.ToString();

                Patient patient = new Patient();

                foreach (Patient p in polyclinic.patients)
                {
                    if (p.fio == fioPatient)
                    {
                        patient = p;
                        break;
                    }
                }
                polyclinic.patients.Remove(patient);
                RefreshAll();
            }
        }

        private void buttonRemoveTreatment_Click(object sender, EventArgs e)
        {
            if (dataGridViewTreatmens.CurrentCell != null &&
                dataGridViewTreatmens.CurrentCell != null &&
                dataGridViewTreatmens.CurrentCell != null &&
                Treatments.treatments.Count != 0)
            {
                String dateOfTreatment = dataGridViewTreatmens.Rows[dataGridViewTreatmens.CurrentCell.RowIndex].Cells[0].Value.ToString();
                String fioPatient = dataGridViewTreatmens.Rows[dataGridViewTreatmens.CurrentCell.RowIndex].Cells[1].Value.ToString();
                String fioMedic = dataGridViewTreatmens.Rows[dataGridViewTreatmens.CurrentCell.RowIndex].Cells[2].Value.ToString();

                Treatment treatment = new Treatment();
                Medic medic = new Medic();

                foreach (Treatment t in Treatments.treatments)
                {
                    if (t.dateOfTreatment.ToString() == dateOfTreatment
                        && t.fioPatient == fioPatient
                        && t.fioMedic == fioMedic)
                    {
                        treatment = t;
                        break;
                    }
                }
                Treatments.treatments.Remove(treatment);

                foreach (Medic m in polyclinic.medics)
                {
                    if (m.fio == fioMedic)
                    {
                        medic = m;
                        break;
                    }
                }
                medic.treatments.Remove(treatment);

                RefreshAll();
            }

        }

        private int CountTreatmentsPatient(String fioPatient)
        {
            int count = 0;
            foreach (Medic m in polyclinic.medics)
            {
                foreach (Treatment t in m.treatments)
                {
                    if (t.fioPatient == fioPatient)
                        count++;
                }
            }

            return count;
        }

    }
}

