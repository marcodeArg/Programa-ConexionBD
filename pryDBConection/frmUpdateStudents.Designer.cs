namespace pryDBConection
{
    partial class frmUpdateStudents
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
            this.lstCode = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblCodeCourse = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lstCodeCourse = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(22, 76);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(59, 20);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Código";
            // 
            // lstCode
            // 
            this.lstCode.FormattingEnabled = true;
            this.lstCode.Location = new System.Drawing.Point(168, 73);
            this.lstCode.Name = "lstCode";
            this.lstCode.Size = new System.Drawing.Size(106, 28);
            this.lstCode.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(22, 164);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 20);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Apellido";
            // 
            // lblCodeCourse
            // 
            this.lblCodeCourse.AutoSize = true;
            this.lblCodeCourse.Location = new System.Drawing.Point(22, 207);
            this.lblCodeCourse.Name = "lblCodeCourse";
            this.lblCodeCourse.Size = new System.Drawing.Size(130, 20);
            this.lblCodeCourse.TabIndex = 4;
            this.lblCodeCourse.Text = "Nombre de curso";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 26);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(168, 161);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(191, 26);
            this.txtSurname.TabIndex = 6;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // lstCodeCourse
            // 
            this.lstCodeCourse.FormattingEnabled = true;
            this.lstCodeCourse.Location = new System.Drawing.Point(168, 204);
            this.lstCodeCourse.Name = "lstCodeCourse";
            this.lstCodeCourse.Size = new System.Drawing.Size(191, 28);
            this.lstCodeCourse.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(65, 254);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 31);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnConsult
            // 
            this.btnConsult.Location = new System.Drawing.Point(168, 254);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(88, 31);
            this.btnConsult.TabIndex = 9;
            this.btnConsult.Text = "Consultar";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(271, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(386, 64);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Modificar estudiante";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmUpdateStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 304);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lstCode);
            this.Controls.Add(this.lstCodeCourse);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCodeCourse);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUpdateStudents";
            this.Text = "Modificar - Estudiantes";
            this.Load += new System.EventHandler(this.frmUpdateStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox lstCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblCodeCourse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ComboBox lstCodeCourse;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
    }
}