using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pryDBConection
{
    internal class clsCourses : clsBaseDatos
    {

        private string codCourse;
        private string nameCourse;
        private int duration;
        private DateTime date;
        private string codTeacher;

        public string CodCourse { get { return codCourse; } set { codCourse = value; } }
        public string NameCourse { get { return nameCourse; } set { nameCourse = value; } }
        public int Duration { get { return duration; } set { duration = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public string CodTeacher { get { return codTeacher; } set { codTeacher = value; } }

        
        public void AddCourse()
        {
            string sql = "";
            sql = "INSERT INTO CURSO (COD_CURSO, CURSO, DURACION, FECHA, COD_PROFESOR) VALUES (@codCourse,@course,@duration,@date,@codTeacher)";

            DbConnection = new OleDbConnection(StringConection);


            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(sql, DbConnection);

                DbCommand.Parameters.AddWithValue("@codCourse", codCourse);
                DbCommand.Parameters.AddWithValue("@course", nameCourse);
                DbCommand.Parameters.AddWithValue("@duration", duration);
                DbCommand.Parameters.AddWithValue("@date", date);
                DbCommand.Parameters.AddWithValue("@codTeacher", codTeacher);

                DbCommand.CommandText = sql;
                DbCommand.ExecuteNonQuery();

                DbConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);

            }

        }

        public void UpdateCourse(string id)
        {
            string sql = "UPDATE CURSO " +
            "SET CURSO=@name,DURACION=@duration,FECHA=@date,COD_PROFESOR=@codTeacher " +
            "WHERE COD_CURSO=@id";

            DbConnection = new OleDbConnection(StringConection);

            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(sql, DbConnection);
                DbCommand.Parameters.AddWithValue("@name", nameCourse);
                DbCommand.Parameters.AddWithValue("@duration", duration.ToString());
                DbCommand.Parameters.AddWithValue("@date", date);
                DbCommand.Parameters.AddWithValue("@codTeacher", codTeacher);
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
