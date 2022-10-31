using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDBConection
{
    internal class clsCourses : clsBaseDatos
    {
        private string codCourse;
        private string name;
        private string duration;
        private DateTime date;
        private string codTeacher;

        public string CodCourse { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string CodTeacher { get; set; }


        //public void ShowInList(ComboBox list)
        //{
        //    try
        //    {
        //        DbConnection = new OleDbConnection(StringConection);
        //        DbConnection.Open();

        //        DbCommand = new OleDbCommand(TableName, DbConnection);
        //        DbCommand.CommandType = CommandType.TableDirect;
        //        DbCommand.CommandText = TableName;

        //        DbAdapter = new OleDbDataAdapter(DbCommand);
        //        DataBase = new DataSet();

        //        DbAdapter.Fill(DataBase, TableName);

        //        list.DataSource = DataBase.Tables[TableName];
        //        list.DisplayMember = "CURSO";
        //        list.ValueMember = "COD_CURSO";

        //        DbConnection.Close();
        //        DbAdapter.Dispose();
        //    }
        //    catch (Exception err)
        //    {
        //        MessageBox.Show("Error", err.Message);
        //    }
        //}

    }

}
