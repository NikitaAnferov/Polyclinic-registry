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
            this.listBoxMedic = new System.Windows.Forms.ListBox();
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
            this.textBoxChekPolis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTreatment = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewPoliclinicData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDopInfo = new System.Windows.Forms.GroupBox();
            this.labelInformationPatient = new System.Windows.Forms.Label();
            this.labelInformationTreatment = new System.Windows.Forms.Label();
            this.labelInformationMedic = new System.Windows.Forms.Label();
            this.groupBoxPoliclinicInformation.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxBloodType.SuspendLayout();
            this.groupBoxTreatment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoliclinicData)).BeginInit();
            this.groupBoxDopInfo.SuspendLayout();
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
            // listBoxMedic
            // 
            this.listBoxMedic.FormattingEnabled = true;
            this.listBoxMedic.Location = new System.Drawing.Point(9, 131);
            this.listBoxMedic.Name = "listBoxMedic";
            this.listBoxMedic.Size = new System.Drawing.Size(326, 134);
            this.listBoxMedic.TabIndex = 1;
            // 
            // buttonAddTreatment
            // 
            this.buttonAddTreatment.Location = new System.Drawing.Point(341, 131);
            this.buttonAddTreatment.Name = "buttonAddTreatment";
            this.buttonAddTreatment.Size = new System.Drawing.Size(126, 50);
            this.buttonAddTreatment.TabIndex = 3;
            this.buttonAddTreatment.Text = "Добавить обращение";
            this.buttonAddTreatment.UseVisualStyleBackColor = true;
            this.buttonAddTreatment.Click += new System.EventHandler(this.buttonAddTreatment_Click);
            // 
            // buttonRemoveTreatment
            // 
            this.buttonRemoveTreatment.Location = new System.Drawing.Point(341, 215);
            this.buttonRemoveTreatment.Name = "buttonRemoveTreatment";
            this.buttonRemoveTreatment.Size = new System.Drawing.Size(126, 50);
            this.buttonRemoveTreatment.TabIndex = 4;
            this.buttonRemoveTreatment.Text = "Удалить обращение";
            this.buttonRemoveTreatment.UseVisualStyleBackColor = true;
            // 
            // buttonAddPatirent
            // 
            this.buttonAddPatirent.Location = new System.Drawing.Point(9, 271);
            this.buttonAddPatirent.Name = "buttonAddPatirent";
            this.buttonAddPatirent.Size = new System.Drawing.Size(126, 50);
            this.buttonAddPatirent.TabIndex = 5;
            this.buttonAddPatirent.Text = "Добавить пациента";
            this.buttonAddPatirent.UseVisualStyleBackColor = true;
            this.buttonAddPatirent.Click += new System.EventHandler(this.buttonAddPatirent_Click);
            // 
            // buttonRemovePatient
            // 
            this.buttonRemovePatient.Location = new System.Drawing.Point(209, 271);
            this.buttonRemovePatient.Name = "buttonRemovePatient";
            this.buttonRemovePatient.Size = new System.Drawing.Size(126, 50);
            this.buttonRemovePatient.TabIndex = 6;
            this.buttonRemovePatient.Text = "Удалить пациента";
            this.buttonRemovePatient.UseVisualStyleBackColor = true;
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
            this.groupBoxTreatment.Controls.Add(this.textBoxChekPolis);
            this.groupBoxTreatment.Controls.Add(this.label5);
            this.groupBoxTreatment.Controls.Add(this.label2);
            this.groupBoxTreatment.Controls.Add(this.dateTimePickerTreatment);
            this.groupBoxTreatment.Location = new System.Drawing.Point(9, 626);
            this.groupBoxTreatment.Name = "groupBoxTreatment";
            this.groupBoxTreatment.Size = new System.Drawing.Size(458, 288);
            this.groupBoxTreatment.TabIndex = 8;
            this.groupBoxTreatment.TabStop = false;
            this.groupBoxTreatment.Text = "Ввод данных для обращения";
            this.groupBoxTreatment.Visible = false;
            // 
            // buttonComoliteTreatment
            // 
            this.buttonComoliteTreatment.Location = new System.Drawing.Point(326, 232);
            this.buttonComoliteTreatment.Name = "buttonComoliteTreatment";
            this.buttonComoliteTreatment.Size = new System.Drawing.Size(126, 50);
            this.buttonComoliteTreatment.TabIndex = 14;
            this.buttonComoliteTreatment.Text = "Добавить";
            this.buttonComoliteTreatment.UseVisualStyleBackColor = true;
            this.buttonComoliteTreatment.Click += new System.EventHandler(this.buttonComoliteTreatment_Click);
            // 
            // textBoxdiagnostic
            // 
            this.textBoxdiagnostic.Location = new System.Drawing.Point(6, 183);
            this.textBoxdiagnostic.Name = "textBoxdiagnostic";
            this.textBoxdiagnostic.Size = new System.Drawing.Size(434, 20);
            this.textBoxdiagnostic.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Диагноз";
            // 
            // textBoxResTests
            // 
            this.textBoxResTests.Location = new System.Drawing.Point(6, 133);
            this.textBoxResTests.Name = "textBoxResTests";
            this.textBoxResTests.Size = new System.Drawing.Size(434, 20);
            this.textBoxResTests.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Результаты анализов";
            // 
            // textBoxChekPolis
            // 
            this.textBoxChekPolis.Location = new System.Drawing.Point(6, 85);
            this.textBoxChekPolis.Name = "textBoxChekPolis";
            this.textBoxChekPolis.Size = new System.Drawing.Size(165, 20);
            this.textBoxChekPolis.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Страховой полис пациента";
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
            this.Column4,
            this.Column3});
            this.dataGridViewPoliclinicData.Location = new System.Drawing.Point(473, 8);
            this.dataGridViewPoliclinicData.Name = "dataGridViewPoliclinicData";
            this.dataGridViewPoliclinicData.Size = new System.Drawing.Size(531, 397);
            this.dataGridViewPoliclinicData.TabIndex = 9;
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
            // Column4
            // 
            this.Column4.HeaderText = "Результаты анализов";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Диагноз";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupBoxDopInfo
            // 
            this.groupBoxDopInfo.Controls.Add(this.labelInformationPatient);
            this.groupBoxDopInfo.Controls.Add(this.labelInformationTreatment);
            this.groupBoxDopInfo.Controls.Add(this.labelInformationMedic);
            this.groupBoxDopInfo.Location = new System.Drawing.Point(473, 415);
            this.groupBoxDopInfo.Name = "groupBoxDopInfo";
            this.groupBoxDopInfo.Size = new System.Drawing.Size(531, 199);
            this.groupBoxDopInfo.TabIndex = 10;
            this.groupBoxDopInfo.TabStop = false;
            this.groupBoxDopInfo.Text = "Дополнительная информация";
            // 
            // labelInformationPatient
            // 
            this.labelInformationPatient.AutoSize = true;
            this.labelInformationPatient.Location = new System.Drawing.Point(433, 25);
            this.labelInformationPatient.Name = "labelInformationPatient";
            this.labelInformationPatient.Size = new System.Drawing.Size(92, 13);
            this.labelInformationPatient.TabIndex = 2;
            this.labelInformationPatient.Text = "InformationPatient";
            // 
            // labelInformationTreatment
            // 
            this.labelInformationTreatment.AutoSize = true;
            this.labelInformationTreatment.Location = new System.Drawing.Point(216, 25);
            this.labelInformationTreatment.Name = "labelInformationTreatment";
            this.labelInformationTreatment.Size = new System.Drawing.Size(107, 13);
            this.labelInformationTreatment.TabIndex = 1;
            this.labelInformationTreatment.Text = "InformationTreatment";
            // 
            // labelInformationMedic
            // 
            this.labelInformationMedic.AutoSize = true;
            this.labelInformationMedic.Location = new System.Drawing.Point(6, 25);
            this.labelInformationMedic.Name = "labelInformationMedic";
            this.labelInformationMedic.Size = new System.Drawing.Size(88, 13);
            this.labelInformationMedic.TabIndex = 0;
            this.labelInformationMedic.Text = "InformationMedic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 916);
            this.Controls.Add(this.groupBoxDopInfo);
            this.Controls.Add(this.dataGridViewPoliclinicData);
            this.Controls.Add(this.groupBoxTreatment);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.buttonRemovePatient);
            this.Controls.Add(this.buttonAddPatirent);
            this.Controls.Add(this.buttonRemoveTreatment);
            this.Controls.Add(this.buttonAddTreatment);
            this.Controls.Add(this.listBoxMedic);
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
            this.groupBoxDopInfo.ResumeLayout(false);
            this.groupBoxDopInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPoliclinicInformation;
        private System.Windows.Forms.Label labelPoliclinicInformation;
        private System.Windows.Forms.ListBox listBoxMedic;
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
        private System.Windows.Forms.TextBox textBoxChekPolis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button buttonComoliteTreatment;
        private System.Windows.Forms.GroupBox groupBoxDopInfo;
        private System.Windows.Forms.Label labelInformationMedic;
        private System.Windows.Forms.Label labelInformationPatient;
        private System.Windows.Forms.Label labelInformationTreatment;
    }
}

