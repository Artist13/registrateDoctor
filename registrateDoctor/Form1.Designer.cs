namespace registrateDoctor
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
            this.SecondName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.ThirdName = new System.Windows.Forms.TextBox();
            this.LabelSecondName = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelThirdName = new System.Windows.Forms.Label();
            this.BorningDate = new System.Windows.Forms.DateTimePicker();
            this.LabelBorningDate = new System.Windows.Forms.Label();
            this.LabelSNILS = new System.Windows.Forms.Label();
            this.LabelPolis = new System.Windows.Forms.Label();
            this.SNILS = new System.Windows.Forms.TextBox();
            this.Polis = new System.Windows.Forms.TextBox();
            this.LabelAdress = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.TextBox();
            this.LabelDoctor = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Doctor = new System.Windows.Forms.ComboBox();
            this.Time = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(90, 30);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(178, 20);
            this.SecondName.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(90, 56);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(178, 20);
            this.FirstName.TabIndex = 1;
            // 
            // ThirdName
            // 
            this.ThirdName.Location = new System.Drawing.Point(90, 82);
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.Size = new System.Drawing.Size(178, 20);
            this.ThirdName.TabIndex = 2;
            // 
            // LabelSecondName
            // 
            this.LabelSecondName.AutoSize = true;
            this.LabelSecondName.Location = new System.Drawing.Point(28, 33);
            this.LabelSecondName.Name = "LabelSecondName";
            this.LabelSecondName.Size = new System.Drawing.Size(56, 13);
            this.LabelSecondName.TabIndex = 3;
            this.LabelSecondName.Text = "Фамилия";
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(55, 56);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(29, 13);
            this.LabelFirstName.TabIndex = 4;
            this.LabelFirstName.Text = "Имя";
            // 
            // LabelThirdName
            // 
            this.LabelThirdName.AutoSize = true;
            this.LabelThirdName.Location = new System.Drawing.Point(33, 85);
            this.LabelThirdName.Name = "LabelThirdName";
            this.LabelThirdName.Size = new System.Drawing.Size(54, 13);
            this.LabelThirdName.TabIndex = 5;
            this.LabelThirdName.Text = "Отчество";
            // 
            // BorningDate
            // 
            this.BorningDate.Location = new System.Drawing.Point(424, 30);
            this.BorningDate.Name = "BorningDate";
            this.BorningDate.Size = new System.Drawing.Size(200, 20);
            this.BorningDate.TabIndex = 3;
            this.BorningDate.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // LabelBorningDate
            // 
            this.LabelBorningDate.AutoSize = true;
            this.LabelBorningDate.Location = new System.Drawing.Point(304, 33);
            this.LabelBorningDate.Name = "LabelBorningDate";
            this.LabelBorningDate.Size = new System.Drawing.Size(86, 13);
            this.LabelBorningDate.TabIndex = 7;
            this.LabelBorningDate.Text = "Дата рождения";
            // 
            // LabelSNILS
            // 
            this.LabelSNILS.AutoSize = true;
            this.LabelSNILS.Location = new System.Drawing.Point(359, 59);
            this.LabelSNILS.Name = "LabelSNILS";
            this.LabelSNILS.Size = new System.Drawing.Size(45, 13);
            this.LabelSNILS.TabIndex = 8;
            this.LabelSNILS.Text = "СНИЛС";
            // 
            // LabelPolis
            // 
            this.LabelPolis.AutoSize = true;
            this.LabelPolis.Location = new System.Drawing.Point(345, 85);
            this.LabelPolis.Name = "LabelPolis";
            this.LabelPolis.Size = new System.Drawing.Size(59, 13);
            this.LabelPolis.TabIndex = 9;
            this.LabelPolis.Text = "№ Полиса";
            // 
            // SNILS
            // 
            this.SNILS.Location = new System.Drawing.Point(424, 56);
            this.SNILS.Name = "SNILS";
            this.SNILS.Size = new System.Drawing.Size(200, 20);
            this.SNILS.TabIndex = 4;
            // 
            // Polis
            // 
            this.Polis.Location = new System.Drawing.Point(424, 82);
            this.Polis.Name = "Polis";
            this.Polis.Size = new System.Drawing.Size(200, 20);
            this.Polis.TabIndex = 5;
            // 
            // LabelAdress
            // 
            this.LabelAdress.AutoSize = true;
            this.LabelAdress.Location = new System.Drawing.Point(46, 133);
            this.LabelAdress.Name = "LabelAdress";
            this.LabelAdress.Size = new System.Drawing.Size(38, 13);
            this.LabelAdress.TabIndex = 12;
            this.LabelAdress.Text = "Адрес";
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(90, 130);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(534, 20);
            this.Adress.TabIndex = 6;
            // 
            // LabelDoctor
            // 
            this.LabelDoctor.AutoSize = true;
            this.LabelDoctor.Location = new System.Drawing.Point(104, 211);
            this.LabelDoctor.Name = "LabelDoctor";
            this.LabelDoctor.Size = new System.Drawing.Size(67, 13);
            this.LabelDoctor.TabIndex = 14;
            this.LabelDoctor.Text = "ФИО Врача";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(46, 186);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(125, 13);
            this.LabelType.TabIndex = 15;
            this.LabelType.Text = "Выберите специалиста";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(90, 264);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(81, 13);
            this.LabelTime.TabIndex = 16;
            this.LabelTime.Text = "Время приема";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(97, 238);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(74, 13);
            this.LabelDate.TabIndex = 17;
            this.LabelDate.Text = "Дата приема";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(183, 232);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(441, 20);
            this.Date.TabIndex = 9;
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Терапевт",
            "Хирург",
            "Акушер-гинеколог"});
            this.Type.Location = new System.Drawing.Point(183, 183);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(441, 21);
            this.Type.TabIndex = 7;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(362, 351);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(167, 23);
            this.Submit.TabIndex = 11;
            this.Submit.Text = "Принять";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(549, 351);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Doctor
            // 
            this.Doctor.FormattingEnabled = true;
            this.Doctor.Location = new System.Drawing.Point(183, 208);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(441, 21);
            this.Doctor.TabIndex = 8;
            this.Doctor.SelectedIndexChanged += new System.EventHandler(this.Doctor_SelectedIndexChanged);
            // 
            // Time
            // 
            this.Time.FormattingEnabled = true;
            this.Time.Location = new System.Drawing.Point(183, 256);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(441, 21);
            this.Time.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 391);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.LabelDoctor);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.LabelAdress);
            this.Controls.Add(this.Polis);
            this.Controls.Add(this.SNILS);
            this.Controls.Add(this.LabelPolis);
            this.Controls.Add(this.LabelSNILS);
            this.Controls.Add(this.LabelBorningDate);
            this.Controls.Add(this.BorningDate);
            this.Controls.Add(this.LabelThirdName);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.LabelSecondName);
            this.Controls.Add(this.ThirdName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.SecondName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox ThirdName;
        private System.Windows.Forms.Label LabelSecondName;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelThirdName;
        private System.Windows.Forms.DateTimePicker BorningDate;
        private System.Windows.Forms.Label LabelBorningDate;
        private System.Windows.Forms.Label LabelSNILS;
        private System.Windows.Forms.Label LabelPolis;
        private System.Windows.Forms.TextBox SNILS;
        private System.Windows.Forms.TextBox Polis;
        private System.Windows.Forms.Label LabelAdress;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Label LabelDoctor;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ComboBox Doctor;
        private System.Windows.Forms.ComboBox Time;
    }
}

