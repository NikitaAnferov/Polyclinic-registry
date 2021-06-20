namespace Polyclinic_registry
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxPoliclinicInformation = new System.Windows.Forms.GroupBox();
            this.labelPoliclinicInformation = new System.Windows.Forms.Label();
            this.buttonAddTreatment = new System.Windows.Forms.Button();
            this.buttonRemoveTreatment = new System.Windows.Forms.Button();
            this.buttonAddPatirent = new System.Windows.Forms.Button();
            this.buttonRemovePatient = new System.Windows.Forms.Button();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.buttonComplitePacient = new System.Windows.Forms.Button();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonGenderJ = new System.Windows.Forms.RadioButton();
            this.radioButtonGenderM = new System.Windows.Forms.RadioButton();
            this.groupBoxBloodType = new System.Windows.Forms.GroupBox();
            this.radioButtonGBIV = new System.Windows.Forms.RadioButton();
            this.radioButtonGBIII = new System.Windows.Forms.RadioButton();
            this.radioButtonGBII = new System.Windows.Forms.RadioButton();
            this.radioButtonGBI = new System.Windows.Forms.RadioButton();
            this.textBoxNumPolis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDateBd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.groupBoxTreatment = new System.Windows.Forms.GroupBox();
            this.buttonComoliteTreatment = new System.Windows.Forms.Button();
            this.textBoxdiagnostic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxResTests = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTreatment = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewPoliclinicData = new System.Windows.Forms.DataGridView();
            this.dataGridViewMedics = new System.Windows.Forms.DataGridView();
            this.ColumnSpecialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfCommencement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCountTreatments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTreatmens = new System.Windows.Forms.DataGridView();
            this.ColumnDateOfTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFIOPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnfioMedic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTestResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiagnostic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonViewAllTreatments = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnbirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBloodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPoliclinicInformation.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxBloodType.SuspendLayout();
            this.groupBoxTreatment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoliclinicData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedics)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatmens)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPoliclinicInformation
            // 
            this.groupBoxPoliclinicInformation.Controls.Add(this.labelPoliclinicInformation);
            this.groupBoxPoliclinicInformation.Location = new System.Drawing.Point(9, 8);
            this.groupBoxPoliclinicInformation.Name = "groupBoxPoliclinicInformation";
            this.groupBoxPoliclinicInformation.Size = new System.Drawing.Size(326, 117);
            this.groupBoxPoliclinicInformation.TabIndex = 0;
            this.groupBoxPoliclinicInformation.TabStop = false;
            this.groupBoxPoliclinicInformation.Text = "Информация о поликлинике";
            // 
            // labelPoliclinicInformation
            // 
            this.labelPoliclinicInformation.AutoSize = true;
            this.labelPoliclinicInformation.Location = new System.Drawing.Point(6, 16);
            this.labelPoliclinicInformation.Name = "labelPoliclinicInformation";
            this.labelPoliclinicInformation.Size = new System.Drawing.Size(59, 13);
            this.labelPoliclinicInformation.TabIndex = 0;
            this.labelPoliclinicInformation.Text = "Information";
            // 
            // buttonAddTreatment
            // 
            this.buttonAddTreatment.Location = new System.Drawing.Point(301, 271);
            this.buttonAddTreatment.Name = "buttonAddTreatment";
            this.buttonAddTreatment.Size = new System.Drawing.Size(80, 50);
            this.buttonAddTreatment.TabIndex = 3;
            this.buttonAddTreatment.Text = "Добавить обращение";
            this.buttonAddTreatment.UseVisualStyleBackColor = true;
            this.buttonAddTreatment.Click += new System.EventHandler(this.buttonAddTreatment_Click);
            // 
            // buttonRemoveTreatment
            // 
            this.buttonRemoveTreatment.Location = new System.Drawing.Point(387, 271);
            this.buttonRemoveTreatment.Name = "buttonRemoveTreatment";
            this.buttonRemoveTreatment.Size = new System.Drawing.Size(80, 50);
            this.buttonRemoveTreatment.TabIndex = 4;
            this.buttonRemoveTreatment.Text = "Удалить обращение";
            this.buttonRemoveTreatment.UseVisualStyleBackColor = true;
            this.buttonRemoveTreatment.Click += new System.EventHandler(this.buttonRemoveTreatment_Click);
            // 
            // buttonAddPatirent
            // 
            this.buttonAddPatirent.Location = new System.Drawing.Point(9, 271);
            this.buttonAddPatirent.Name = "buttonAddPatirent";
            this.buttonAddPatirent.Size = new System.Drawing.Size(80, 50);
            this.buttonAddPatirent.TabIndex = 5;
            this.buttonAddPatirent.Text = "Добавить пациента";
            this.buttonAddPatirent.UseVisualStyleBackColor = true;
            this.buttonAddPatirent.Click += new System.EventHandler(this.buttonAddPatirent_Click);
            // 
            // buttonRemovePatient
            // 
            this.buttonRemovePatient.Location = new System.Drawing.Point(95, 271);
            this.buttonRemovePatient.Name = "buttonRemovePatient";
            this.buttonRemovePatient.Size = new System.Drawing.Size(80, 50);
            this.buttonRemovePatient.TabIndex = 6;
            this.buttonRemovePatient.Text = "Удалить пациента";
            this.buttonRemovePatient.UseVisualStyleBackColor = true;
            this.buttonRemovePatient.Click += new System.EventHandler(this.buttonRemovePatient_Click);
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.buttonComplitePacient);
            this.groupBoxPatient.Controls.Add(this.groupBoxGender);
            this.groupBoxPatient.Controls.Add(this.groupBoxBloodType);
            this.groupBoxPatient.Controls.Add(this.textBoxNumPolis);
            this.groupBoxPatient.Controls.Add(this.label4);
            this.groupBoxPatient.Controls.Add(this.label3);
            this.groupBoxPatient.Controls.Add(this.dateTimePickerDateBd);
            this.groupBoxPatient.Controls.Add(this.label1);
            this.groupBoxPatient.Controls.Add(this.textBoxFio);
            this.groupBoxPatient.Location = new System.Drawing.Point(9, 327);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(458, 293);
            this.groupBoxPatient.TabIndex = 7;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Ввод данных о пациенте";
            this.groupBoxPatient.Visible = false;
            // 
            // buttonComplitePacient
            // 
            this.buttonComplitePacient.Location = new System.Drawing.Point(326, 237);
            this.buttonComplitePacient.Name = "buttonComplitePacient";
            this.buttonComplitePacient.Size = new System.Drawing.Size(126, 50);
            this.buttonComplitePacient.TabIndex = 11;
            this.buttonComplitePacient.Text = "Добавить";
            this.buttonComplitePacient.UseVisualStyleBackColor = true;
            this.buttonComplitePacient.Click += new System.EventHandler(this.buttonComplitePacient_Click);
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonGenderJ);
            this.groupBoxGender.Controls.Add(this.radioButtonGenderM);
            this.groupBoxGender.Location = new System.Drawing.Point(9, 67);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(200, 45);
            this.groupBoxGender.TabIndex = 10;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Пол";
            // 
            // radioButtonGenderJ
            // 
            this.radioButtonGenderJ.AutoSize = true;
            this.radioButtonGenderJ.Location = new System.Drawing.Point(122, 19);
            this.radioButtonGenderJ.Name = "radioButtonGenderJ";
            this.radioButtonGenderJ.Size = new System.Drawing.Size(72, 17);
            this.radioButtonGenderJ.TabIndex = 3;
            this.radioButtonGenderJ.TabStop = true;
            this.radioButtonGenderJ.Text = "Женский";
            this.radioButtonGenderJ.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenderM
            // 
            this.radioButtonGenderM.AutoSize = true;
            this.radioButtonGenderM.Location = new System.Drawing.Point(6, 19);
            this.radioButtonGenderM.Name = "radioButtonGenderM";
            this.radioButtonGenderM.Size = new System.Drawing.Size(71, 17);
            this.radioButtonGenderM.TabIndex = 2;
            this.radioButtonGenderM.TabStop = true;
            this.radioButtonGenderM.Text = "Мужской";
            this.radioButtonGenderM.UseVisualStyleBackColor = true;
            // 
            // groupBoxBloodType
            // 
            this.groupBoxBloodType.Controls.Add(this.radioButtonGBIV);
            this.groupBoxBloodType.Controls.Add(this.radioButtonGBIII);
            this.groupBoxBloodType.Controls.Add(this.radioButtonGBII);
            this.groupBoxBloodType.Controls.Add(this.radioButtonGBI);
            this.groupBoxBloodType.Location = new System.Drawing.Point(231, 67);
            this.groupBoxBloodType.Name = "groupBoxBloodType";
            this.groupBoxBloodType.Size = new System.Drawing.Size(95, 121);
            this.groupBoxBloodType.TabIndex = 9;
            this.groupBoxBloodType.TabStop = false;
            this.groupBoxBloodType.Text = "Группа крови";
            // 
            // radioButtonGBIV
            // 
            this.radioButtonGBIV.AutoSize = true;
            this.radioButtonGBIV.Location = new System.Drawing.Point(6, 88);
            this.radioButtonGBIV.Name = "radioButtonGBIV";
            this.radioButtonGBIV.Size = new System.Drawing.Size(35, 17);
            this.radioButtonGBIV.TabIndex = 3;
            this.radioButtonGBIV.TabStop = true;
            this.radioButtonGBIV.Text = "IV";
            this.radioButtonGBIV.UseVisualStyleBackColor = true;
            // 
            // radioButtonGBIII
            // 
            this.radioButtonGBIII.AutoSize = true;
            this.radioButtonGBIII.Location = new System.Drawing.Point(6, 65);
            this.radioButtonGBIII.Name = "radioButtonGBIII";
            this.radioButtonGBIII.Size = new System.Drawing.Size(34, 17);
            this.radioButtonGBIII.TabIndex = 2;
            this.radioButtonGBIII.TabStop = true;
            this.radioButtonGBIII.Text = "III";
            this.radioButtonGBIII.UseVisualStyleBackColor = true;
            // 
            // radioButtonGBII
            // 
            this.radioButtonGBII.AutoSize = true;
            this.radioButtonGBII.Location = new System.Drawing.Point(6, 42);
            this.radioButtonGBII.Name = "radioButtonGBII";
            this.radioButtonGBII.Size = new System.Drawing.Size(31, 17);
            this.radioButtonGBII.TabIndex = 1;
            this.radioButtonGBII.TabStop = true;
            this.radioButtonGBII.Text = "II";
            this.radioButtonGBII.UseVisualStyleBackColor = true;
            // 
            // radioButtonGBI
            // 
            this.radioButtonGBI.AutoSize = true;
            this.radioButtonGBI.Location = new System.Drawing.Point(6, 19);
            this.radioButtonGBI.Name = "radioButtonGBI";
            this.radioButtonGBI.Size = new System.Drawing.Size(28, 17);
            this.radioButtonGBI.TabIndex = 0;
            this.radioButtonGBI.TabStop = true;
            this.radioButtonGBI.Text = "I";
            this.radioButtonGBI.UseVisualStyleBackColor = true;
            // 
            // textBoxNumPolis
            // 
            this.textBoxNumPolis.Location = new System.Drawing.Point(9, 208);
            this.textBoxNumPolis.Name = "textBoxNumPolis";
            this.textBoxNumPolis.Size = new System.Drawing.Size(165, 20);
            this.textBoxNumPolis.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер страхового полиса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата рождения";
            // 
            // dateTimePickerDateBd
            // 
            this.dateTimePickerDateBd.Location = new System.Drawing.Point(9, 153);
            this.dateTimePickerDateBd.Name = "dateTimePickerDateBd";
            this.dateTimePickerDateBd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateBd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фио";
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(9, 41);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(434, 20);
            this.textBoxFio.TabIndex = 0;
            // 
            // groupBoxTreatment
            // 
            this.groupBoxTreatment.Controls.Add(this.buttonComoliteTreatment);
            this.groupBoxTreatment.Controls.Add(this.textBoxdiagnostic);
            this.groupBoxTreatment.Controls.Add(this.label7);
            this.groupBoxTreatment.Controls.Add(this.textBoxResTests);
            this.groupBoxTreatment.Controls.Add(this.label6);
            this.groupBoxTreatment.Controls.Add(this.label2);
            this.groupBoxTreatment.Controls.Add(this.dateTimePickerTreatment);
            this.groupBoxTreatment.Location = new System.Drawing.Point(9, 626);
            this.groupBoxTreatment.Name = "groupBoxTreatment";
            this.groupBoxTreatment.Size = new System.Drawing.Size(458, 237);
            this.groupBoxTreatment.TabIndex = 8;
            this.groupBoxTreatment.TabStop = false;
            this.groupBoxTreatment.Text = "Ввод данных для обращения";
            this.groupBoxTreatment.Visible = false;
            // 
            // buttonComoliteTreatment
            // 
            this.buttonComoliteTreatment.Location = new System.Drawing.Point(329, 180);
            this.buttonComoliteTreatment.Name = "buttonComoliteTreatment";
            this.buttonComoliteTreatment.Size = new System.Drawing.Size(126, 50);
            this.buttonComoliteTreatment.TabIndex = 14;
            this.buttonComoliteTreatment.Text = "Добавить";
            this.buttonComoliteTreatment.UseVisualStyleBackColor = true;
            this.buttonComoliteTreatment.Click += new System.EventHandler(this.buttonComoliteTreatment_Click);
            // 
            // textBoxdiagnostic
            // 
            this.textBoxdiagnostic.Location = new System.Drawing.Point(9, 131);
            this.textBoxdiagnostic.Name = "textBoxdiagnostic";
            this.textBoxdiagnostic.Size = new System.Drawing.Size(434, 20);
            this.textBoxdiagnostic.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Диагноз";
            // 
            // textBoxResTests
            // 
            this.textBoxResTests.Location = new System.Drawing.Point(9, 81);
            this.textBoxResTests.Name = "textBoxResTests";
            this.textBoxResTests.Size = new System.Drawing.Size(434, 20);
            this.textBoxResTests.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Результаты анализов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата обращения";
            // 
            // dateTimePickerTreatment
            // 
            this.dateTimePickerTreatment.Location = new System.Drawing.Point(9, 39);
            this.dateTimePickerTreatment.Name = "dateTimePickerTreatment";
            this.dateTimePickerTreatment.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTreatment.TabIndex = 6;
            // 
            // dataGridViewPoliclinicData
            // 
            this.dataGridViewPoliclinicData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoliclinicData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Columnbirthdate,
            this.ColumnGen,
            this.ColumnBloodt});
            this.dataGridViewPoliclinicData.Location = new System.Drawing.Point(0, 16);
            this.dataGridViewPoliclinicData.Name = "dataGridViewPoliclinicData";
            this.dataGridViewPoliclinicData.ReadOnly = true;
            this.dataGridViewPoliclinicData.RowHeadersVisible = false;
            this.dataGridViewPoliclinicData.Size = new System.Drawing.Size(206, 241);
            this.dataGridViewPoliclinicData.TabIndex = 9;
            this.dataGridViewPoliclinicData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPoliclinicData_MouseUp);
            // 
            // dataGridViewMedics
            // 
            this.dataGridViewMedics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSpecialty,
            this.ColumnFIO,
            this.ColumnPosition,
            this.ColumnDateOfCommencement,
            this.ColumnCountTreatments});
            this.dataGridViewMedics.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewMedics.Name = "dataGridViewMedics";
            this.dataGridViewMedics.ReadOnly = true;
            this.dataGridViewMedics.RowHeadersVisible = false;
            this.dataGridViewMedics.Size = new System.Drawing.Size(455, 115);
            this.dataGridViewMedics.TabIndex = 11;
            this.dataGridViewMedics.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridViewMedics_MouseUp);
            // 
            // ColumnSpecialty
            // 
            this.ColumnSpecialty.HeaderText = "Специальность";
            this.ColumnSpecialty.Name = "ColumnSpecialty";
            this.ColumnSpecialty.ReadOnly = true;
            // 
            // ColumnFIO
            // 
            this.ColumnFIO.HeaderText = "ФИО";
            this.ColumnFIO.Name = "ColumnFIO";
            this.ColumnFIO.ReadOnly = true;
            // 
            // ColumnPosition
            // 
            this.ColumnPosition.HeaderText = "Должность";
            this.ColumnPosition.Name = "ColumnPosition";
            this.ColumnPosition.ReadOnly = true;
            // 
            // ColumnDateOfCommencement
            // 
            this.ColumnDateOfCommencement.HeaderText = "Дата трудоустройства";
            this.ColumnDateOfCommencement.Name = "ColumnDateOfCommencement";
            this.ColumnDateOfCommencement.ReadOnly = true;
            // 
            // ColumnCountTreatments
            // 
            this.ColumnCountTreatments.HeaderText = "Количество обращений";
            this.ColumnCountTreatments.Name = "ColumnCountTreatments";
            this.ColumnCountTreatments.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewMedics);
            this.groupBox1.Location = new System.Drawing.Point(9, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Медицинский состав";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewPoliclinicData);
            this.groupBox2.Location = new System.Drawing.Point(473, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 257);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пациенты";
            // 
            // dataGridViewTreatmens
            // 
            this.dataGridViewTreatmens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTreatmens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDateOfTreatment,
            this.ColumnFIOPatient,
            this.ColumnfioMedic,
            this.ColumnTestResult,
            this.ColumnDiagnostic});
            this.dataGridViewTreatmens.Location = new System.Drawing.Point(0, 16);
            this.dataGridViewTreatmens.Name = "dataGridViewTreatmens";
            this.dataGridViewTreatmens.ReadOnly = true;
            this.dataGridViewTreatmens.RowHeadersVisible = false;
            this.dataGridViewTreatmens.Size = new System.Drawing.Size(312, 241);
            this.dataGridViewTreatmens.TabIndex = 9;
            this.dataGridViewTreatmens.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridViewTreatmens_MouseUp);
            // 
            // ColumnDateOfTreatment
            // 
            this.ColumnDateOfTreatment.HeaderText = "Дата обращения";
            this.ColumnDateOfTreatment.Name = "ColumnDateOfTreatment";
            this.ColumnDateOfTreatment.ReadOnly = true;
            // 
            // ColumnFIOPatient
            // 
            this.ColumnFIOPatient.HeaderText = "ФИО пациента";
            this.ColumnFIOPatient.Name = "ColumnFIOPatient";
            this.ColumnFIOPatient.ReadOnly = true;
            // 
            // ColumnfioMedic
            // 
            this.ColumnfioMedic.HeaderText = "ФИО врача";
            this.ColumnfioMedic.Name = "ColumnfioMedic";
            this.ColumnfioMedic.ReadOnly = true;
            // 
            // ColumnTestResult
            // 
            this.ColumnTestResult.HeaderText = "Результаты анализа";
            this.ColumnTestResult.Name = "ColumnTestResult";
            this.ColumnTestResult.ReadOnly = true;
            // 
            // ColumnDiagnostic
            // 
            this.ColumnDiagnostic.HeaderText = "Диагноз";
            this.ColumnDiagnostic.Name = "ColumnDiagnostic";
            this.ColumnDiagnostic.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewTreatmens);
            this.groupBox3.Location = new System.Drawing.Point(692, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 257);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Обращения";
            // 
            // buttonViewAllTreatments
            // 
            this.buttonViewAllTreatments.Location = new System.Drawing.Point(181, 271);
            this.buttonViewAllTreatments.Name = "buttonViewAllTreatments";
            this.buttonViewAllTreatments.Size = new System.Drawing.Size(114, 50);
            this.buttonViewAllTreatments.TabIndex = 14;
            this.buttonViewAllTreatments.Text = "Показать все обращения";
            this.buttonViewAllTreatments.UseVisualStyleBackColor = true;
            this.buttonViewAllTreatments.Click += new System.EventHandler(this.buttonViewAllTreatments_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ФИО пациента";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номер страховаго полиса";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Columnbirthdate
            // 
            this.Columnbirthdate.HeaderText = "Дата Рождения";
            this.Columnbirthdate.Name = "Columnbirthdate";
            this.Columnbirthdate.ReadOnly = true;
            // 
            // ColumnGen
            // 
            this.ColumnGen.HeaderText = "Пол";
            this.ColumnGen.Name = "ColumnGen";
            this.ColumnGen.ReadOnly = true;
            // 
            // ColumnBloodt
            // 
            this.ColumnBloodt.HeaderText = "Группа крови";
            this.ColumnBloodt.Name = "ColumnBloodt";
            this.ColumnBloodt.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 870);
            this.Controls.Add(this.buttonViewAllTreatments);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTreatment);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.buttonRemovePatient);
            this.Controls.Add(this.buttonAddPatirent);
            this.Controls.Add(this.buttonRemoveTreatment);
            this.Controls.Add(this.buttonAddTreatment);
            this.Controls.Add(this.groupBoxPoliclinicInformation);
            this.Name = "Form1";
            this.Text = "Реестр поликлиники";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPoliclinicInformation.ResumeLayout(false);
            this.groupBoxPoliclinicInformation.PerformLayout();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxBloodType.ResumeLayout(false);
            this.groupBoxBloodType.PerformLayout();
            this.groupBoxTreatment.ResumeLayout(false);
            this.groupBoxTreatment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoliclinicData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedics)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatmens)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPoliclinicInformation;
        private System.Windows.Forms.Label labelPoliclinicInformation;
        private System.Windows.Forms.Button buttonAddTreatment;
        private System.Windows.Forms.Button buttonRemoveTreatment;
        private System.Windows.Forms.Button buttonAddPatirent;
        private System.Windows.Forms.Button buttonRemovePatient;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.GroupBox groupBoxTreatment;
        private System.Windows.Forms.DataGridView dataGridViewPoliclinicData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateBd;
        private System.Windows.Forms.RadioButton radioButtonGenderJ;
        private System.Windows.Forms.RadioButton radioButtonGenderM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.GroupBox groupBoxBloodType;
        private System.Windows.Forms.RadioButton radioButtonGBIV;
        private System.Windows.Forms.RadioButton radioButtonGBIII;
        private System.Windows.Forms.RadioButton radioButtonGBII;
        private System.Windows.Forms.RadioButton radioButtonGBI;
        private System.Windows.Forms.TextBox textBoxNumPolis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonComplitePacient;
        private System.Windows.Forms.TextBox textBoxdiagnostic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxResTests;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTreatment;
        private System.Windows.Forms.Button buttonComoliteTreatment;
        private System.Windows.Forms.DataGridView dataGridViewMedics;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpecialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOfCommencement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCountTreatments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewTreatmens;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOfTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFIOPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnfioMedic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTestResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiagnostic;
        private System.Windows.Forms.Button buttonViewAllTreatments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnbirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBloodt;
    }
}

