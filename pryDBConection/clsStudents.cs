using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;
using System.Data.Odbc;


namespace pryDBConection
{
    internal class clsStudents : clsBaseDatos
    {


        private OleDbDataReader dbReader;

        private string codStudent;
        private string name;
        private string surname;
        private string codCourse;

        public string CodStudent { get { return codStudent; } set { codStudent = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string CodCourse { get { return codCourse; } set { codCourse = value; } }




        public void AddStudent()
        {
            string sql = "";
            sql = "INSERT INTO ALUMNOS (COD_ALUMNO, NOMBRE, APELLIDO, COD_CURSO) VALUES (@codStudent,@name,@surname,@codCourse)";

            DbConnection = new OleDbConnection(StringConection);


            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(sql, DbConnection);
                DbCommand.Parameters.AddWithValue("@codStudent", codStudent);
                DbCommand.Parameters.AddWithValue("@name", name);
                DbCommand.Parameters.AddWithValue("@surname", surname);
                DbCommand.Parameters.AddWithValue("@codCourse", codCourse);

                DbCommand.CommandText = sql;
                DbCommand.ExecuteNonQuery();

                DbConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);
                
            }

            // PARA UPDATE LO MISMO SOLAMENTE CAMBIANDO SQL

            


        }

        public void ShowInList(ComboBox list, string campo, string id)
        {
            try
            {
                DbConnection = new OleDbConnection(StringConection);
                DbConnection.Open();

                DbCommand = new OleDbCommand(TableName, DbConnection);
                DbCommand.CommandType = CommandType.TableDirect;
                DbCommand.CommandText = TableName;

                DbAdapter = new OleDbDataAdapter(DbCommand);
                DataBase = new DataSet();

                DbAdapter.Fill(DataBase, TableName);

                list.DataSource = DataBase.Tables[TableName];
                list.DisplayMember = campo;
                list.ValueMember = id;

                DbConnection.Close();
                DbAdapter.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error", err.Message);
            }
        }

    }
}
