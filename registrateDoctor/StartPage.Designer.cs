namespace registrateDoctor
{
    partial class StartPage
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
            this.Regisration = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Regisration
            // 
            this.Regisration.Location = new System.Drawing.Point(50, 48);
            this.Regisration.Name = "Regisration";
            this.Regisration.Size = new System.Drawing.Size(137, 56);
            this.Regisration.TabIndex = 0;
            this.Regisration.Text = "Регистрация";
            this.Regisration.UseVisualStyleBackColor = true;
            this.Regisration.Click += new System.EventHandler(this.Regisration_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(338, 50);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(137, 54);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Редактирование";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 152);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Regisration);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Regisration;
        private System.Windows.Forms.Button Edit;
    }
}