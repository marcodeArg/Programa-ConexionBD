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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddStudents addStudents = new frmAddStudents();
            addStudents.ShowDialog();
        }

        private void elimnarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteStudents delStudents = new frmDeleteStudents();
            delStudents.ShowDialog();
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUpdateStudents updateStudents = new frmUpdateStudents();
            updateStudents.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultStudents consultStudents = new frmConsultStudents();
            consultStudents.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddTeachers addTeachers = new frmAddTeachers();
            addTeachers.ShowDialog();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDeleteTeachers deleteTeachers = new frmDeleteTeachers();
            deleteTeachers.ShowDialog();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTeachers updateTeachers = new frmUpdateTeachers();
            updateTeachers.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultTeachers consultTeachers = new frmConsultTeachers();
            consultTeachers.ShowDialog();
        }

        private void añadirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddCourses addCourses = new frmAddCourses();
            addCourses.ShowDialog();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDeleteCourses deleteCourses = new frmDeleteCourses();
            deleteCourses.ShowDialog();
        }

        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUpdateCourses updateCourses = new frmUpdateCourses();
            updateCourses.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultCourses consultCourses = new frmConsultCourses();
            consultCourses.ShowDialog();
        }
    }
}
