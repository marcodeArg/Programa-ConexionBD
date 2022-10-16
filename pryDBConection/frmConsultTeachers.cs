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

        string path = "./INSTITUTO-DE-INFORMATICA.accdb";
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


                int c = 0;

                //Agregar el valor correspondiente a cada celda
                addData(c);

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

        private void addData(int row)
        {
            while (dbReader.Read())
            {
                dgvTeachers.Rows.Add();

                //Agrego cada valor a la celda correspondiente
                dgvTeachers.Rows[row].Cells[0].Value = dbReader.GetValue(0);
                dgvTeachers.Rows[row].Cells[1].Value = dbReader.GetValue(1);
                dgvTeachers.Rows[row].Cells[2].Value = dbReader.GetValue(2);
                dgvTeachers.Rows[row].Cells[3].Value = dbReader.GetValue(3);
                dgvTeachers.Rows[row].Cells[4].Value = dbReader.GetValue(4);
                dgvTeachers.Rows[row].Cells[5].Value = dbReader.GetValue(5);

                row++;
            }
        }
    }
}
