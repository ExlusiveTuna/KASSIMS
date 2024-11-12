namespace KASSIMS
{
    partial class Reminders
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminders));
            this.labelReminders = new System.Windows.Forms.Label();
            this.titleSoftwareName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textRemID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCreateReminder = new System.Windows.Forms.Button();
            this.textDate = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textTime = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textReminder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reminderDataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonReminders = new System.Windows.Forms.Button();
            this.pictureFurniture = new System.Windows.Forms.PictureBox();
            this.buttonFurniture = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonGraphs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reminderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFurniture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReminders
            // 
            this.labelReminders.AutoSize = true;
            this.labelReminders.Font = new System.Drawing.Font("Ebrima", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReminders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(194)))), ((int)(((byte)(68)))));
            this.labelReminders.Location = new System.Drawing.Point(295, 38);
            this.labelReminders.Name = "labelReminders";
            this.labelReminders.Size = new System.Drawing.Size(195, 50);
            this.labelReminders.TabIndex = 68;
            this.labelReminders.Text = "Reminders";
            // 
            // titleSoftwareName
            // 
            this.titleSoftwareName.AutoSize = true;
            this.titleSoftwareName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(194)))), ((int)(((byte)(68)))));
            this.titleSoftwareName.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSoftwareName.ForeColor = System.Drawing.Color.White;
            this.titleSoftwareName.Location = new System.Drawing.Point(45, 10);
            this.titleSoftwareName.Name = "titleSoftwareName";
            this.titleSoftwareName.Size = new System.Drawing.Size(105, 30);
            this.titleSoftwareName.TabIndex = 59;
            this.titleSoftwareName.Text = "KASSIMS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textRemID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonCreateReminder);
            this.panel1.Controls.Add(this.textDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textReminder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1273, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 684);
            this.panel1.TabIndex = 69;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(187)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete Reminder";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textRemID
            // 
            this.textRemID.Font = new System.Drawing.Font("Ebrima", 10F);
            this.textRemID.Location = new System.Drawing.Point(23, 141);
            this.textRemID.Name = "textRemID";
            this.textRemID.Size = new System.Drawing.Size(434, 26);
            this.textRemID.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 10F);
            this.label5.Location = new System.Drawing.Point(19, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID:";
            // 
            // buttonCreateReminder
            // 
            this.buttonCreateReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(187)))));
            this.buttonCreateReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateReminder.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateReminder.ForeColor = System.Drawing.Color.White;
            this.buttonCreateReminder.Location = new System.Drawing.Point(23, 507);
            this.buttonCreateReminder.Name = "buttonCreateReminder";
            this.buttonCreateReminder.Size = new System.Drawing.Size(137, 41);
            this.buttonCreateReminder.TabIndex = 11;
            this.buttonCreateReminder.Text = "Create Reminder";
            this.buttonCreateReminder.UseVisualStyleBackColor = false;
            this.buttonCreateReminder.Click += new System.EventHandler(this.buttonCreateReminder_Click);
            // 
            // textDate
            // 
            this.textDate.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDate.Location = new System.Drawing.Point(23, 423);
            this.textDate.Mask = "00/00/0000";
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(55, 25);
            this.textDate.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 10F);
            this.label6.Location = new System.Drawing.Point(19, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date:";
            // 
            // textTime
            // 
            this.textTime.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTime.Location = new System.Drawing.Point(23, 325);
            this.textTime.Mask = "00:00:00";
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(44, 25);
            this.textTime.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 10F);
            this.label3.Location = new System.Drawing.Point(19, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time:";
            // 
            // textReminder
            // 
            this.textReminder.Font = new System.Drawing.Font("Ebrima", 10F);
            this.textReminder.Location = new System.Drawing.Point(23, 228);
            this.textReminder.Name = "textReminder";
            this.textReminder.Size = new System.Drawing.Size(434, 26);
            this.textReminder.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 10F);
            this.label2.Location = new System.Drawing.Point(19, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reminder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set New Reminder:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notificationReminder";
            this.notifyIcon1.Visible = true;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(986, 345);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(96, 37);
            this.labelTime.TabIndex = 70;
            this.labelTime.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(788, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 37);
            this.label4.TabIndex = 71;
            this.label4.Text = "Current Time:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.reminderDataGridView);
            this.panel2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(224, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 836);
            this.panel2.TabIndex = 72;
            // 
            // reminderDataGridView
            // 
            this.reminderDataGridView.AllowUserToAddRows = false;
            this.reminderDataGridView.AllowUserToDeleteRows = false;
            this.reminderDataGridView.AllowUserToResizeColumns = false;
            this.reminderDataGridView.AllowUserToResizeRows = false;
            this.reminderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.reminderDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.reminderDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.reminderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reminderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reminderDataGridView.Location = new System.Drawing.Point(0, 0);
            this.reminderDataGridView.Name = "reminderDataGridView";
            this.reminderDataGridView.ReadOnly = true;
            this.reminderDataGridView.Size = new System.Drawing.Size(439, 836);
            this.reminderDataGridView.TabIndex = 0;
            this.reminderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reminderDataGridView_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(788, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 37);
            this.label7.TabIndex = 73;
            this.label7.Text = "Current Date:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(986, 296);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(96, 37);
            this.labelDate.TabIndex = 74;
            this.labelDate.Text = "label4";
            // 
            // buttonReminders
            // 
            this.buttonReminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(32)))));
            this.buttonReminders.FlatAppearance.BorderSize = 0;
            this.buttonReminders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReminders.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReminders.ForeColor = System.Drawing.Color.White;
            this.buttonReminders.Image = ((System.Drawing.Image)(resources.GetObject("buttonReminders.Image")));
            this.buttonReminders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReminders.Location = new System.Drawing.Point(32, 332);
            this.buttonReminders.Name = "buttonReminders";
            this.buttonReminders.Size = new System.Drawing.Size(156, 43);
            this.buttonReminders.TabIndex = 64;
            this.buttonReminders.Text = "Reminders";
            this.buttonReminders.UseVisualStyleBackColor = false;
            this.buttonReminders.Click += new System.EventHandler(this.buttonReminders_Click);
            // 
            // pictureFurniture
            // 
            this.pictureFurniture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureFurniture.BackgroundImage")));
            this.pictureFurniture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureFurniture.Location = new System.Drawing.Point(232, 35);
            this.pictureFurniture.Name = "pictureFurniture";
            this.pictureFurniture.Size = new System.Drawing.Size(57, 53);
            this.pictureFurniture.TabIndex = 67;
            this.pictureFurniture.TabStop = false;
            // 
            // buttonFurniture
            // 
            this.buttonFurniture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(194)))), ((int)(((byte)(68)))));
            this.buttonFurniture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFurniture.FlatAppearance.BorderSize = 0;
            this.buttonFurniture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFurniture.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFurniture.ForeColor = System.Drawing.Color.White;
            this.buttonFurniture.Image = ((System.Drawing.Image)(resources.GetObject("buttonFurniture.Image")));
            this.buttonFurniture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFurniture.Location = new System.Drawing.Point(35, 186);
            this.buttonFurniture.Name = "buttonFurniture";
            this.buttonFurniture.Size = new System.Drawing.Size(146, 43);
            this.buttonFurniture.TabIndex = 62;
            this.buttonFurniture.Text = "Furniture";
            this.buttonFurniture.UseVisualStyleBackColor = false;
            this.buttonFurniture.Click += new System.EventHandler(this.buttonFurniture_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1802, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(194)))), ((int)(((byte)(68)))));
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(35, 113);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(124, 43);
            this.buttonHome.TabIndex = 60;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(32)))));
            this.pictureBox4.Location = new System.Drawing.Point(-1, 330);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(195, 46);
            this.pictureBox4.TabIndex = 65;
            this.pictureBox4.TabStop = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(194)))), ((int)(((byte)(68)))));
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(35, 405);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(124, 43);
            this.buttonSettings.TabIndex = 63;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonGraphs
            // 
            this.buttonGraphs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(194)))), ((int)(((byte)(68)))));
            this.buttonGraphs.FlatAppearance.BorderSize = 0;
            this.buttonGraphs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraphs.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGraphs.ForeColor = System.Drawing.Color.White;
            this.buttonGraphs.Image = ((System.Drawing.Image)(resources.GetObject("buttonGraphs.Image")));
            this.buttonGraphs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGraphs.Location = new System.Drawing.Point(35, 259);
            this.buttonGraphs.Name = "buttonGraphs";
            this.buttonGraphs.Size = new System.Drawing.Size(124, 43);
            this.buttonGraphs.TabIndex = 61;
            this.buttonGraphs.Text = "Graphs";
            this.buttonGraphs.UseVisualStyleBackColor = false;
            this.buttonGraphs.Click += new System.EventHandler(this.buttonGraphs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(194)))), ((int)(((byte)(68)))));
            this.pictureBox1.Location = new System.Drawing.Point(-19, -9);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 1058);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(187)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::KASSIMS.Properties.Resources.icons8_repeat_24;
            this.btnRefresh.Location = new System.Drawing.Point(679, 193);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(37, 38);
            this.btnRefresh.TabIndex = 75;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Reminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.buttonReminders);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelReminders);
            this.Controls.Add(this.pictureFurniture);
            this.Controls.Add(this.buttonFurniture);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonGraphs);
            this.Controls.Add(this.titleSoftwareName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Reminders";
            this.Text = "Reminders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reminders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reminderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFurniture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelReminders;
        private System.Windows.Forms.PictureBox pictureFurniture;
        private System.Windows.Forms.Button buttonFurniture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttonReminders;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonGraphs;
        private System.Windows.Forms.Label titleSoftwareName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textReminder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox textTime;
        private System.Windows.Forms.Button buttonCreateReminder;
        private System.Windows.Forms.MaskedTextBox textDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DataGridView reminderDataGridView;
        private System.Windows.Forms.TextBox textRemID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefresh;
    }
}