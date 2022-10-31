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

        


        private void btnAdd_Click(object sender, EventArgs e)
        {

            
            


            MessageBox.Show("Curso agregado correctamente");

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
    }
}
