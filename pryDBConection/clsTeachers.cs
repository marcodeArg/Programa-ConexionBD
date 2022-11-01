using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryDBConection
{
    internal class clsTeachers : clsBaseDatos
    {
        private string codTeacher;
        private string name;
        private string surname;
        private string category;
        private string dedication;
        private string obs;

        public string CodTeacher { get { return codTeacher; } set { codTeacher = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Category { get { return category; } set { category = value; } }
        public string Dedication { get { return dedication; } set { dedication = value; } }
        public string Obs { get { return obs; } set { obs = value; } }

        public void AddTeacher()
        {
            string sql;
            sql = "INSERT INTO PROFESORES (COD_PROFESOR, NOMBRE, APELLIDO, CATEGORIA, DEDICACION, OBSERVACIONES) VALUES " +
                "(@codTeacher,@name,@surname,@category,@dedication,@obs)";

            DbConnection = new OleDbConnection(StringConection);

            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(sql, DbConnection);
                DbCommand.Parameters.AddWithValue("@codTeacher", codTeacher);
                DbCommand.Parameters.AddWithValue("@name", name);
                DbCommand.Parameters.AddWithValue("@surname", surname);
                DbCommand.Parameters.AddWithValue("@category", category);
                DbCommand.Parameters.AddWithValue("@dedication", dedication);
                DbCommand.Parameters.AddWithValue("@obs", obs);

                DbCommand.CommandText = sql;
                DbCommand.ExecuteNonQuery();

                DbCommand.Dispose();
                DbConnection.Close();
            }
            catch (Exception err)
            {

                MessageBox.Show("Error al agregar un nuevo profesor: " + err.Message);
            }
        }


    }
}
