namespace registrateDoctor
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Time = new System.Windows.Forms.ComboBox();
            this.Doctor = new System.Windows.Forms.ComboBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelDoctor = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.TextBox();
            this.LabelAdress = new System.Windows.Forms.Label();
            this.Polis = new System.Windows.Forms.TextBox();
            this.SNILS = new System.Windows.Forms.TextBox();
            this.LabelPolis = new System.Windows.Forms.Label();
            this.LabelSNILS = new System.Windows.Forms.Label();
            this.LabelBorningDate = new System.Windows.Forms.Label();
            this.BorningDate = new System.Windows.Forms.DateTimePicker();
            this.LabelThirdName = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelSecondName = new System.Windows.Forms.Label();
            this.ThirdName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.FormattingEnabled = true;
            this.Time.Location = new System.Drawing.Point(183, 249);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(441, 21);
            this.Time.TabIndex = 48;
            // 
            // Doctor
            // 
            this.Doctor.FormattingEnabled = true;
            this.Doctor.Location = new System.Drawing.Point(183, 201);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(441, 21);
            this.Doctor.TabIndex = 47;
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Терапевт",
            "Хирург",
            "Акушер-гинеколог"});
            this.Type.Location = new System.Drawing.Point(183, 176);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(441, 21);
            this.Type.TabIndex = 46;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(183, 225);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(441, 20);
            this.Date.TabIndex = 45;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(97, 231);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(74, 13);
            this.LabelDate.TabIndex = 44;
            this.LabelDate.Text = "Дата приема";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(90, 257);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(81, 13);
            this.LabelTime.TabIndex = 43;
            this.LabelTime.Text = "Время приема";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(46, 179);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(125, 13);
            this.LabelType.TabIndex = 42;
            this.LabelType.Text = "Выберите специалиста";
            // 
            // LabelDoctor
            // 
            this.LabelDoctor.AutoSize = true;
            this.LabelDoctor.Location = new System.Drawing.Point(104, 204);
            this.LabelDoctor.Name = "LabelDoctor";
            this.LabelDoctor.Size = new System.Drawing.Size(67, 13);
            this.LabelDoctor.TabIndex = 41;
            this.LabelDoctor.Text = "ФИО Врача";
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(90, 123);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(534, 20);
            this.Adress.TabIndex = 40;
            // 
            // LabelAdress
            // 
            this.LabelAdress.AutoSize = true;
            this.LabelAdress.Location = new System.Drawing.Point(46, 126);
            this.LabelAdress.Name = "LabelAdress";
            this.LabelAdress.Size = new System.Drawing.Size(38, 13);
            this.LabelAdress.TabIndex = 39;
            this.LabelAdress.Text = "Адрес";
            // 
            // Polis
            // 
            this.Polis.Location = new System.Drawing.Point(424, 75);
            this.Polis.Name = "Polis";
            this.Polis.Size = new System.Drawing.Size(200, 20);
            this.Polis.TabIndex = 38;
            // 
            // SNILS
            // 
            this.SNILS.Location = new System.Drawing.Point(424, 49);
            this.SNILS.Name = "SNILS";
            this.SNILS.Size = new System.Drawing.Size(200, 20);
            this.SNILS.TabIndex = 37;
            // 
            // LabelPolis
            // 
            this.LabelPolis.AutoSize = true;
            this.LabelPolis.Location = new System.Drawing.Point(345, 78);
            this.LabelPolis.Name = "LabelPolis";
            this.LabelPolis.Size = new System.Drawing.Size(59, 13);
            this.LabelPolis.TabIndex = 36;
            this.LabelPolis.Text = "№ Полиса";
            // 
            // LabelSNILS
            // 
            this.LabelSNILS.AutoSize = true;
            this.LabelSNILS.Location = new System.Drawing.Point(359, 52);
            this.LabelSNILS.Name = "LabelSNILS";
            this.LabelSNILS.Size = new System.Drawing.Size(45, 13);
            this.LabelSNILS.TabIndex = 35;
            this.LabelSNILS.Text = "СНИЛС";
            // 
            // LabelBorningDate
            // 
            this.LabelBorningDate.AutoSize = true;
            this.LabelBorningDate.Location = new System.Drawing.Point(318, 26);
            this.LabelBorningDate.Name = "LabelBorningDate";
            this.LabelBorningDate.Size = new System.Drawing.Size(86, 13);
            this.LabelBorningDate.TabIndex = 34;
            this.LabelBorningDate.Text = "Дата рождения";
            // 
            // BorningDate
            // 
            this.BorningDate.Location = new System.Drawing.Point(424, 23);
            this.BorningDate.Name = "BorningDate";
            this.BorningDate.Size = new System.Drawing.Size(200, 20);
            this.BorningDate.TabIndex = 33;
            this.BorningDate.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // LabelThirdName
            // 
            this.LabelThirdName.AutoSize = true;
            this.LabelThirdName.Location = new System.Drawing.Point(33, 78);
            this.LabelThirdName.Name = "LabelThirdName";
            this.LabelThirdName.Size = new System.Drawing.Size(54, 13);
            this.LabelThirdName.TabIndex = 32;
            this.LabelThirdName.Text = "Отчество";
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(55, 49);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(29, 13);
            this.LabelFirstName.TabIndex = 31;
            this.LabelFirstName.Text = "Имя";
            // 
            // LabelSecondName
            // 
            this.LabelSecondName.AutoSize = true;
            this.LabelSecondName.Location = new System.Drawing.Point(28, 26);
            this.LabelSecondName.Name = "LabelSecondName";
            this.LabelSecondName.Size = new System.Drawing.Size(56, 13);
            this.LabelSecondName.TabIndex = 30;
            this.LabelSecondName.Text = "Фамилия";
            // 
            // ThirdName
            // 
            this.ThirdName.Location = new System.Drawing.Point(90, 75);
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.Size = new System.Drawing.Size(178, 20);
            this.ThirdName.TabIndex = 29;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(90, 49);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(178, 20);
            this.FirstName.TabIndex = 28;
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(90, 23);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(178, 20);
            this.SecondName.TabIndex = 27;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 360);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Doctor);
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
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Time;
        private System.Windows.Forms.ComboBox Doctor;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelDoctor;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Label LabelAdress;
        private System.Windows.Forms.TextBox Polis;
        private System.Windows.Forms.TextBox SNILS;
        private System.Windows.Forms.Label LabelPolis;
        private System.Windows.Forms.Label LabelSNILS;
        private System.Windows.Forms.Label LabelBorningDate;
        private System.Windows.Forms.DateTimePicker BorningDate;
        private System.Windows.Forms.Label LabelThirdName;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelSecondName;
        private System.Windows.Forms.TextBox ThirdName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox SecondName;
    }
}