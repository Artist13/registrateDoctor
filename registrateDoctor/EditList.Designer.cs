namespace registrateDoctor
{
    partial class EditList
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
            this.OrderList = new System.Windows.Forms.ListView();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.EditItem = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderList
            // 
            this.OrderList.FullRowSelect = true;
            this.OrderList.GridLines = true;
            this.OrderList.LabelEdit = true;
            this.OrderList.Location = new System.Drawing.Point(1, 1);
            this.OrderList.MultiSelect = false;
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(899, 395);
            this.OrderList.TabIndex = 0;
            this.OrderList.UseCompatibleStateImageBehavior = false;
            this.OrderList.View = System.Windows.Forms.View.List;
            this.OrderList.SelectedIndexChanged += new System.EventHandler(this.OrderList_SelectedIndexChanged);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Location = new System.Drawing.Point(793, 415);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(85, 23);
            this.DeleteItem.TabIndex = 1;
            this.DeleteItem.Text = "Удалить";
            this.DeleteItem.UseVisualStyleBackColor = true;
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // EditItem
            // 
            this.EditItem.Location = new System.Drawing.Point(657, 415);
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(115, 23);
            this.EditItem.TabIndex = 2;
            this.EditItem.Text = "Редактировать";
            this.EditItem.UseVisualStyleBackColor = true;
            this.EditItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 415);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(85, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(524, 415);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(115, 23);
            this.Accept.TabIndex = 4;
            this.Accept.Text = "Применить";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // EditList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.EditItem);
            this.Controls.Add(this.DeleteItem);
            this.Controls.Add(this.OrderList);
            this.Name = "EditList";
            this.Text = "EditList";
            this.Load += new System.EventHandler(this.EditList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView OrderList;
        private System.Windows.Forms.Button DeleteItem;
        private System.Windows.Forms.Button EditItem;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Accept;
    }
}