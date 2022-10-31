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
    public partial class frmConsultTeachers : Form
    {
        public frmConsultTeachers()
        {
            InitializeComponent();
        }

        string path = "./INSTITUTO-DE-INFORMATICA.mdb";
        string sentenceSQL = "SELECT * FROM PROFESORES";

        OleDbConnection dbConnection;

        //Sirve para ejecutar una instruccion sql en la base de datos
        OleDbCommand dbCommand;
        OleDbDataReader dbReader;


        private void frmConsultTrainer_Load(object sender, EventArgs e)
        {
            dbConnection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + path);

            try
            {
                dbConnection.Open();

                dbCommand = new OleDbCommand(sentenceSQL, dbConnection);
                dbReader = dbCommand.ExecuteReader();


                int columnsCount = dbReader.FieldCount;

                //Asignar el nombre de las columnas a la grilla
                setColumnsNames(columnsCount);

                //Agregar el valor correspondiente a cada celda
                addData();

                dbReader.Close();
                dbConnection.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("Se produjo un error al intentar establecer la conexion con la base de datos: "+ err.Message);
            }

        }


        private void setColumnsNames(int columnsCount)
        {
            string name;

            for (int i = 0; i < columnsCount; i++)
            {
                name = dbReader.GetName(i);

                dgvTeachers.Columns.Add(name, name);
            }
        }

        private void addData()
        {
            while (dbReader.Read())
            {
                dgvTeachers.Rows.Add(dbReader[0], dbReader[1], dbReader[2], dbReader[3], dbReader[4], dbReader[5]);
            }
        }
    }
}
