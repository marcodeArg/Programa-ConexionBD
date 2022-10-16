using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDBConection
{
    public partial class frmConsultCourses : Form
    {
        public frmConsultCourses()
        {
            InitializeComponent();
        }

        private void frmConsultCourses_Load(object sender, EventArgs e)
        {

            string path = "./INSTITUTO-DE-INFORMATICA.accdb";
            string sentenceSQL = "SELECT * FROM CURSO";

            OleDbConnection dbConnection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + path);
            OleDbCommand dbCommand;


            try
            {
                dbConnection.Open();
                dbCommand = new OleDbCommand(sentenceSQL, dbConnection);

                //El data adapter sirve como un puente entre la base de datos y el data set / data table.
                //hay que pasarle como parametro que quiero que agarre de la base de datos.
                OleDbDataAdapter dbAdapter = new OleDbDataAdapter(sentenceSQL, dbConnection);
            

                //Data table sirve para crear una tabla de datos en memoria
                DataTable dbTable = new DataTable();

                //Guardo en la data table lo que agarro el data adapter
                dbAdapter.Fill(dbTable);

                dgvCourses.DataSource = dbTable;
            }
            catch (Exception err)
            {
                MessageBox.Show("Se produjo un error al intentar establecer la conexion con la base de datos: " + err.Message);
            }
        }
    }
}
