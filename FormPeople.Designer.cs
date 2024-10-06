namespace DVLD
{
    partial class FormPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPeople));
            this.dgvListPeople = new System.Windows.Forms.DataGridView();
            this.contextMenuEditDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolstripEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordsTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).BeginInit();
            this.contextMenuEditDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListPeople
            // 
            this.dgvListPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPeople.ContextMenuStrip = this.contextMenuEditDelete;
            this.dgvListPeople.Location = new System.Drawing.Point(12, 229);
            this.dgvListPeople.Name = "dgvListPeople";
            this.dgvListPeople.RowHeadersWidth = 62;
            this.dgvListPeople.RowTemplate.Height = 28;
            this.dgvListPeople.Size = new System.Drawing.Size(1822, 373);
            this.dgvListPeople.TabIndex = 0;
            // 
            // contextMenuEditDelete
            // 
            this.contextMenuEditDelete.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuEditDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripEdit,
            this.toolstripDelete});
            this.contextMenuEditDelete.Name = "contextMenuEditDelete";
            this.contextMenuEditDelete.Size = new System.Drawing.Size(135, 68);
            // 
            // toolstripEdit
            // 
            this.toolstripEdit.Name = "toolstripEdit";
            this.toolstripEdit.Size = new System.Drawing.Size(134, 32);
            this.toolstripEdit.Text = "Edit";
            this.toolstripEdit.Click += new System.EventHandler(this.toolstripEdit_Click);
            // 
            // toolstripDelete
            // 
            this.toolstripDelete.Name = "toolstripDelete";
            this.toolstripDelete.Size = new System.Drawing.Size(134, 32);
            this.toolstripDelete.Text = "Delete";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(782, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage People";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "# Records:";
            // 
            // lblRecordsTotal
            // 
            this.lblRecordsTotal.AutoSize = true;
            this.lblRecordsTotal.Location = new System.Drawing.Point(111, 608);
            this.lblRecordsTotal.Name = "lblRecordsTotal";
            this.lblRecordsTotal.Size = new System.Drawing.Size(36, 20);
            this.lblRecordsTotal.TabIndex = 5;
            this.lblRecordsTotal.Text = "???";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(807, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::DVLD.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(1755, 608);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 80);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackgroundImage = global::DVLD.Properties.Resources.addperson;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPerson.Location = new System.Drawing.Point(1755, 143);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(79, 80);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // FormPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1851, 684);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRecordsTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListPeople);
            this.Name = "FormPeople";
            this.Text = "FormPeople";
            this.Load += new System.EventHandler(this.FormPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).EndInit();
            this.contextMenuEditDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordsTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuEditDelete;
        private System.Windows.Forms.ToolStripMenuItem toolstripEdit;
        private System.Windows.Forms.ToolStripMenuItem toolstripDelete;
    }
}