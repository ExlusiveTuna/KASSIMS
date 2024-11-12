namespace KASSIMS
{
    partial class DeleteReminder
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
            this.btnConfirmDelete = new System.Windows.Forms.Button();
            this.txtDeleteID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmDelete
            // 
            this.btnConfirmDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmDelete.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnConfirmDelete.Location = new System.Drawing.Point(301, 158);
            this.btnConfirmDelete.Name = "btnConfirmDelete";
            this.btnConfirmDelete.Size = new System.Drawing.Size(201, 56);
            this.btnConfirmDelete.TabIndex = 5;
            this.btnConfirmDelete.Text = "Delete?";
            this.btnConfirmDelete.UseVisualStyleBackColor = true;
            this.btnConfirmDelete.Click += new System.EventHandler(this.btnConfirmDelete_Click);
            // 
            // txtDeleteID
            // 
            this.txtDeleteID.Location = new System.Drawing.Point(216, 85);
            this.txtDeleteID.Name = "txtDeleteID";
            this.txtDeleteID.Size = new System.Drawing.Size(376, 20);
            this.txtDeleteID.TabIndex = 4;
            this.txtDeleteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeleteID.TextChanged += new System.EventHandler(this.txtDeleteID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 20F);
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter The ID Of The Reminder You Wish To Delete";
            // 
            // DeleteReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmDelete);
            this.Controls.Add(this.txtDeleteID);
            this.Controls.Add(this.label1);
            this.Name = "DeleteReminder";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmDelete;
        private System.Windows.Forms.TextBox txtDeleteID;
        private System.Windows.Forms.Label label1;
    }
}