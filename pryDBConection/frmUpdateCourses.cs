using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace pryDBConection
{
    public partial class frmUpdateCourses : Form
    {
        public frmUpdateCourses()
        {
            InitializeComponent();
        }
        clsCourses course = new clsCourses(); 

        private void frmUpdateCourses_Load(object sender, EventArgs e)
        {
            //cargo la lista con los codigos de los cursos
            course.TableName = "CURSO";
            course.ShowInList(lstCode, "COD_CURSO");

            //cargo la lista con los nombre de los profesores
            clsTeachers teacher = new clsTeachers();
            teacher.TableName = "PROFESORES";
            teacher.ShowInList(lstCodeTeacher, "NOMBRE", "COD_PROFESOR");

            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            course.TableName = "CURSO";
            course.NameCourse = txtName.Text;
            course.Duration = Convert.ToInt32(txtDuration.Text);
            course.Date = dtpDate.Value.Date;
            course.CodTeacher = lstCodeTeacher.Text;

            course.UpdateCourse(lstCode.Text);

            MessageBox.Show("Se modificó correctamente");

            //limpiar los campos
            txtName.Text = "";
            txtDuration.Text = "";
            dtpDate.Value = DateTime.Now;

        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            frmConsultCourses consultCourses = new frmConsultCourses();
            consultCourses.ShowDialog()
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDuration.Text != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDuration.Text != "")
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
