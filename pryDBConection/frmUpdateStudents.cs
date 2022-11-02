using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace pryDBConection
{
    public partial class frmUpdateStudents : Form
    {
        public frmUpdateStudents()
        {
            InitializeComponent();
        }

        clsStudents student = new clsStudents();

        private void frmUpdateStudents_Load(object sender, EventArgs e)
        {

            student.TableName = "ALUMNOS";
            student.ShowInList(lstCode, "COD_ALUMNO");

            clsCourses course = new clsCourses();
            course.TableName = "CURSO";
            course.ShowInList(lstCodeCourse, "CURSO", "COD_CURSO");

            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            student.TableName = "ALUMNOS";
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.CodCourse = lstCodeCourse.SelectedValue.ToString();
            student.UpdateStudent(lstCode.Text);

            MessageBox.Show("Se modificó correctamente");

        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            frmConsultStudents consultStudents = new frmConsultStudents();
            consultStudents.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSurname.Text != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSurname.Text != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }
    }
}
