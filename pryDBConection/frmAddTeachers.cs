using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDBConection
{
    public partial class frmAddTeachers : Form
    {
        public frmAddTeachers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsTeachers teacher = new clsTeachers();
            teacher.TableName = "PROFESORES";

            if (!teacher.Exist(txtCode.Text))
            {
                teacher.CodTeacher = txtCode.Text;
                teacher.Name = txtName.Text;
                teacher.Surname = txtSurname.Text;
                teacher.Category = txtCategory.Text;
                teacher.Dedication = txtDedication.Text;
                teacher.Obs = txtObservations.Text;

                teacher.AddTeacher();
                MessageBox.Show("Profesor agregado con exito");


            }
            else
            {
                MessageBox.Show("Ya existe un profesor con el mismo codigo");
            }

            
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            frmConsultTeachers consultTeachers = new frmConsultTeachers();
            consultTeachers.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
