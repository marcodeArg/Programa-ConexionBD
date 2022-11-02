using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;



namespace pryDBConection
{
    internal class clsStudents : clsBaseDatos
    {

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

        public void UpdateStudent(string id)
        {
            string sql = "UPDATE ALUMNOS " +
                "SET NOMBRE=@name,APELLIDO=@surname,COD_CURSO=@codCourse " +
                "WHERE COD_ALUMNO=@id";

            DbConnection = new OleDbConnection(StringConection);

            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(sql, DbConnection);
                DbCommand.Parameters.AddWithValue("@name", name);
                DbCommand.Parameters.AddWithValue("@surname", surname);
                DbCommand.Parameters.AddWithValue("@codCourse", codCourse);
                DbCommand.Parameters.AddWithValue("@id", id);

                DbCommand.CommandText = sql;
                DbCommand.ExecuteNonQuery();

                DbCommand.Dispose();
                DbConnection.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);
            }



        }

    }
}
