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
    public partial class frmAddStudents : Form
    {
        public frmAddStudents()
        {
            InitializeComponent();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsStudents student = new clsStudents();
            student.TableName = "ALUMNOS";
            
            //--*-TENGO QUE VALIDAR SI EXISTE PORQUE NO ESTA EN MODO AUTONUMERACION-*--
            if (!student.Exist(txtCode.Text))
            {
                student.CodStudent = txtCode.Text;
                student.Name = txtName.Text;
                student.Surname = txtSurname.Text;
                student.CodCourse = lstCodCourse.SelectedValue.ToString();

                student.AddStudent();

                MessageBox.Show("Alumno agregado correctamente");

            }
            else
            {
                MessageBox.Show("Ya existe un alumno con el mismo codigo, ingrese otro");
            }

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

        private void frmAddStudents_Load(object sender, EventArgs e)
        {
            clsCourses course = new clsCourses();
            course.TableName = "CURSO";
            
            course.ShowInList(lstCodCourse, "CURSO", "COD_CURSO");
        }
    }
}
