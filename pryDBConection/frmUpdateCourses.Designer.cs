namespace pryDBConection
{
    partial class frmUpdateCourses
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
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCodeTeacher = new System.Windows.Forms.Label();
            this.lstCode = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lstCodeTeacher = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(22, 89);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(59, 20);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Código";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(22, 183);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(73, 20);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duración";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(22, 231);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Fecha";
            // 
            // lblCodeTeacher
            // 
            this.lblCodeTeacher.AutoSize = true;
            this.lblCodeTeacher.Location = new System.Drawing.Point(22, 275);
            this.lblCodeTeacher.Name = "lblCodeTeacher";
            this.lblCodeTeacher.Size = new System.Drawing.Size(150, 20);
            this.lblCodeTeacher.TabIndex = 4;
            this.lblCodeTeacher.Text = "Nombre de profesor";
            // 
            // lstCode
            // 
            this.lstCode.FormattingEnabled = true;
            this.lstCode.Location = new System.Drawing.Point(182, 86);
            this.lstCode.Name = "lstCode";
            this.lstCode.Size = new System.Drawing.Size(106, 28);
            this.lstCode.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 134);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(283, 26);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(182, 180);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(106, 26);
            this.txtDuration.TabIndex = 7;
            this.txtDuration.TextChanged += new System.EventHandler(this.txtDuration_TextChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(182, 226);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(283, 26);
            this.dtpDate.TabIndex = 8;
            // 
            // lstCodeTeacher
            // 
            this.lstCodeTeacher.FormattingEnabled = true;
            this.lstCodeTeacher.Location = new System.Drawing.Point(182, 272);
            this.lstCodeTeacher.Name = "lstCodeTeacher";
            this.lstCodeTeacher.Size = new System.Drawing.Size(283, 28);
            this.lstCodeTeacher.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(496, 64);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Modificar curso";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(376, 322);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 31);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConsult
            // 
            this.btnConsult.Location = new System.Drawing.Point(273, 322);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(88, 31);
            this.btnConsult.TabIndex = 14;
            this.btnConsult.Text = "Consultar";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(170, 322);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 31);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdateCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 371);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstCodeTeacher);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstCode);
            this.Controls.Add(this.lblCodeTeacher);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUpdateCourses";
            this.Text = "Modificar - Cursos";
            this.Load += new System.EventHandler(this.frmUpdateCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCodeTeacher;
        private System.Windows.Forms.ComboBox lstCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox lstCodeTeacher;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Button btnUpdate;
    }
}