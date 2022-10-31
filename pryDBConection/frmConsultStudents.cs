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
    public partial class frmConsultStudents : Form
    {
        public frmConsultStudents()
        {
            InitializeComponent();
        }


        string path = "./INSTITUTO-DE-INFORMATICA.accdb";
        string sentenceSQL = "SELECT * FROM ALUMNOS";
        OleDbConnection conectionDB;
        OleDbCommand commandDB;


        //Es mejor usar DataAdapter para almacenar datos en la cache y despues poder manipularlos
        //Es mejor usar DataReader cuando solo se necesita leer los datos
        OleDbDataAdapter adapterDB;

        //Data set sirve para crear un conjunto de tablas en memoria
        DataSet addData;


        private void frmConsultAthlete_Load(object sender, EventArgs e)
        {

            clsStudents student = new clsStudents();
            student.TableName = "ALUMNOS";
            student.ShowInGrid(dgvStudents);


            //try
            //{            
            //    conectionDB = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path);
            //    conectionDB.Open();

            //    commandDB = new OleDbCommand(sentenceSQL, conectionDB);             

            //    adapterDB = new OleDbDataAdapter(commandDB);
            //    addData = new DataSet();


            //    adapterDB.Fill(addData, "ALUMNOS");

            //    dgvStudents.DataMember = "ALUMNOS";
            //    dgvStudents.DataSource = addData;

            //    conectionDB.Close();
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show("Error: " + error.Message);  
            //}
        }
    }
}
