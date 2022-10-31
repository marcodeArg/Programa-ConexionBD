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
            //...

            MessageBox.Show("Profesor agregado con exito");
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
