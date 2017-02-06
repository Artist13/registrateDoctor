namespace registrateDoctor
{
    partial class Sucess
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
            this.LabelSuccess = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelSuccess
            // 
            this.LabelSuccess.AutoSize = true;
            this.LabelSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LabelSuccess.Location = new System.Drawing.Point(27, 20);
            this.LabelSuccess.Name = "LabelSuccess";
            this.LabelSuccess.Size = new System.Drawing.Size(193, 20);
            this.LabelSuccess.TabIndex = 0;
            this.LabelSuccess.Text = "Регистрация успешна";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(325, 261);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Sucess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 296);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.LabelSuccess);
            this.Name = "Sucess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSuccess;
        private System.Windows.Forms.Button Exit;
    }
}