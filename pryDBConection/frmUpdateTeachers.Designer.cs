namespace pryDBConection
{
    partial class frmUpdateTeachers
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
            this.lblObservations = new System.Windows.Forms.Label();
            this.lstCode = new System.Windows.Forms.ComboBox();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.txtDedication = new System.Windows.Forms.TextBox();
            this.lblDedication = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Location = new System.Drawing.Point(22, 281);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(114, 20);
            this.lblObservations.TabIndex = 5;
            this.lblObservations.Text = "Observaciones";
            // 
            // lstCode
            // 
            this.lstCode.FormattingEnabled = true;
            this.lstCode.Location = new System.Drawing.Point(161, 83);
            this.lstCode.Name = "lstCode";
            this.lstCode.Size = new System.Drawing.Size(121, 28);
            this.lstCode.TabIndex = 6;
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(161, 278);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(191, 64);
            this.txtObservations.TabIndex = 11;
            // 
            // txtDedication
            // 
            this.txtDedication.Location = new System.Drawing.Point(161, 235);
            this.txtDedication.Name = "txtDedication";
            this.txtDedication.Size = new System.Drawing.Size(191, 26);
            this.txtDedication.TabIndex = 38;
            // 
            // lblDedication
            // 
            this.lblDedication.AutoSize = true;
            this.lblDedication.Location = new System.Drawing.Point(22, 238);
            this.lblDedication.Name = "lblDedication";
            this.lblDedication.Size = new System.Drawing.Size(88, 20);
            this.lblDedication.TabIndex = 37;
            this.lblDedication.Text = "Dedicacion";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(161, 197);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(191, 26);
            this.txtCategory.TabIndex = 36;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(161, 159);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(191, 26);
            this.txtSurname.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 26);
            this.txtName.TabIndex = 34;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(22, 200);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(78, 20);
            this.lblCategory.TabIndex = 32;
            this.lblCategory.Text = "Categoria";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(22, 162);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 20);
            this.lblSurname.TabIndex = 31;
            this.lblSurname.Text = "Apellido";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 20);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Nombre";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(22, 86);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(59, 20);
            this.lblCode.TabIndex = 29;
            this.lblCode.Text = "Codigo";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(376, 64);
            this.lblTitle.TabIndex = 39;
            this.lblTitle.Text = "Modificar profesor";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(264, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 31);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConsult
            // 
            this.btnConsult.Location = new System.Drawing.Point(161, 360);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(88, 31);
            this.btnConsult.TabIndex = 41;
            this.btnConsult.Text = "Consultar";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(58, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 31);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdateTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 411);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDedication);
            this.Controls.Add(this.lblDedication);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtObservations);
            this.Controls.Add(this.lstCode);
            this.Controls.Add(this.lblObservations);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUpdateTeachers";
            this.Text = "Modificar - Profesores";
            this.Load += new System.EventHandler(this.frmUpdateTeachers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.ComboBox lstCode;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.TextBox txtDedication;
        private System.Windows.Forms.Label lblDedication;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Button btnUpdate;
    }
}