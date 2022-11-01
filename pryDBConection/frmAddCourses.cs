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
    public partial class frmAddCourses : Form
    {
        public frmAddCourses()
        {
            InitializeComponent();
        }

        clsCourses course = new clsCourses();


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string varCode = txtCode.Text;
            course.TableName = "CURSO";

            course.CodCourse = txtCode.Text;

            if (!course.Exist(varCode))
            {
                course.CodCourse = varCode;
                course.NameCourse = txtName.Text;
                course.Duration = Int32.Parse(txtDuration.Text);
                course.Date = dtpDate.Value.Date;
                course.CodTeacher = lstCodTeacher.SelectedValue.ToString();

                course.AddCourse();
                MessageBox.Show("Curso agregado correctamente");
            }
            else
            {
                MessageBox.Show("Se produjo un error");
            }
            


            

        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            frmConsultCourses consulta = new frmConsultCourses();
            consulta.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddCourses_Load(object sender, EventArgs e)
        {
            clsTeachers teacher = new clsTeachers();
            teacher.TableName = "PROFESORES";

            teacher.ShowInList(lstCodTeacher, "NOMBRE", "COD_PROFESOR");
        }
    }
}
