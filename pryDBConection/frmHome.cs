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

        private void deportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultStudents fAthlete = new frmConsultStudents();
            fAthlete.ShowDialog();
        }

        private void entrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultTeachers fTrainer = new frmConsultTeachers();
            fTrainer.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultCourses fCourses = new frmConsultCourses();
            fCourses.ShowDialog();
        }
    }
}
