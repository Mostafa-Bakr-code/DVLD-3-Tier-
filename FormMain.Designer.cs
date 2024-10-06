namespace DVLD
{
    partial class FormMain
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
            this.btnApplications = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccountSettings = new System.Windows.Forms.Label();
            this.btnAccountSettings = new System.Windows.Forms.Button();
            this.lblUsers = new System.Windows.Forms.Label();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.lblPeople = new System.Windows.Forms.Label();
            this.lblDrivers = new System.Windows.Forms.Label();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApplications
            // 
            this.btnApplications.BackgroundImage = global::DVLD.Properties.Resources.app;
            this.btnApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApplications.Location = new System.Drawing.Point(44, 117);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(57, 44);
            this.btnApplications.TabIndex = 0;
            this.btnApplications.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(107, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Applications";
            // 
            // lblAccountSettings
            // 
            this.lblAccountSettings.AutoSize = true;
            this.lblAccountSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAccountSettings.Location = new System.Drawing.Point(107, 329);
            this.lblAccountSettings.Name = "lblAccountSettings";
            this.lblAccountSettings.Size = new System.Drawing.Size(147, 20);
            this.lblAccountSettings.TabIndex = 2;
            this.lblAccountSettings.Text = "Account Settings";
            // 
            // btnAccountSettings
            // 
            this.btnAccountSettings.BackgroundImage = global::DVLD.Properties.Resources.settings;
            this.btnAccountSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccountSettings.Location = new System.Drawing.Point(44, 317);
            this.btnAccountSettings.Name = "btnAccountSettings";
            this.btnAccountSettings.Size = new System.Drawing.Size(57, 44);
            this.btnAccountSettings.TabIndex = 0;
            this.btnAccountSettings.UseVisualStyleBackColor = true;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsers.Location = new System.Drawing.Point(107, 279);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(56, 20);
            this.lblUsers.TabIndex = 2;
            this.lblUsers.Text = "Users";
            // 
            // btnPeople
            // 
            this.btnPeople.BackgroundImage = global::DVLD.Properties.Resources.people;
            this.btnPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPeople.Location = new System.Drawing.Point(44, 167);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(57, 44);
            this.btnPeople.TabIndex = 0;
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackgroundImage = global::DVLD.Properties.Resources.users;
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsers.Location = new System.Drawing.Point(44, 267);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(57, 44);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPeople.Location = new System.Drawing.Point(107, 179);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(64, 20);
            this.lblPeople.TabIndex = 2;
            this.lblPeople.Text = "People";
            // 
            // lblDrivers
            // 
            this.lblDrivers.AutoSize = true;
            this.lblDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDrivers.Location = new System.Drawing.Point(107, 229);
            this.lblDrivers.Name = "lblDrivers";
            this.lblDrivers.Size = new System.Drawing.Size(65, 20);
            this.lblDrivers.TabIndex = 2;
            this.lblDrivers.Text = "Drivers";
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackgroundImage = global::DVLD.Properties.Resources.drivers;
            this.btnDrivers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrivers.Location = new System.Drawing.Point(44, 217);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(57, 44);
            this.btnDrivers.TabIndex = 0;
            this.btnDrivers.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::DVLD.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1570, 703);
            this.Controls.Add(this.lblAccountSettings);
            this.Controls.Add(this.btnAccountSettings);
            this.Controls.Add(this.btnApplications);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnPeople);
            this.Controls.Add(this.lblDrivers);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.btnDrivers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApplications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Label lblDrivers;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Button btnAccountSettings;
        private System.Windows.Forms.Label lblAccountSettings;
    }
}

