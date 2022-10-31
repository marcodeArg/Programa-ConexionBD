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
    internal class clsBaseDatos
    {
        //PROPIEDADES ----
        private string tableName;
        string stringConection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:INSTITUTO-DE-INFORMATICA.mdb";
        
        private OleDbConnection dbConnection;
        private OleDbCommand dbCommand;
        private OleDbDataReader dbReader;
        private OleDbDataAdapter dbAdapter;
        private DataSet dataBase;
        

        public string TableName { get { return tableName; } set { tableName = value; } }
        public string StringConection { get { return stringConection; } }


        public OleDbConnection DbConnection { get; set; }
        public OleDbCommand DbCommand { get;  set; }
        public OleDbDataReader DbReader { get; set; }
        public OleDbDataAdapter DbAdapter { get; set; }
        public DataSet DataBase { get; set; }


        //METODOS ----
        public void ShowInGrid(DataGridView grid)
        {
            try
            {
                dbConnection = new OleDbConnection(stringConection);
                dbConnection.Open();

                dbCommand = new OleDbCommand(tableName, dbConnection);
                dbCommand.CommandType = CommandType.TableDirect;
                dbCommand.CommandText = tableName;

                dbAdapter = new OleDbDataAdapter(dbCommand);
                dataBase = new DataSet();

                dbAdapter.Fill(dataBase, tableName);

                grid.DataSource = dataBase.Tables[tableName];

                dbConnection.Close();
                dbAdapter.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error", err.Message);
                
            }
           
        }

        public void ShowInList(ComboBox list, string column, string id)
        {
            try
            {
                dbConnection = new OleDbConnection(stringConection);
                dbConnection.Open();

                dbCommand = new OleDbCommand(tableName, dbConnection);
                dbCommand.CommandType = CommandType.TableDirect;
                dbCommand.CommandText = tableName;

                dbAdapter = new OleDbDataAdapter(dbCommand);
                dataBase = new DataSet();

                dbAdapter.Fill(dataBase, tableName);

                list.DataSource = dataBase.Tables[tableName];
                list.DisplayMember = column;
                list.ValueMember = id;

                dbConnection.Close();
                dbAdapter.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error", err.Message);
            }
        }

        public bool Exist(string cod)
        {
            dbConnection = new OleDbConnection(StringConection);

            try
            {
                dbConnection.Open();

                dbCommand = new OleDbCommand(tableName, dbConnection);
                dbCommand.CommandType = CommandType.TableDirect;

                dbReader = dbCommand.ExecuteReader();

                if (dbReader.HasRows)
                {
                    while (dbReader.Read())
                    {
                        if (dbReader.GetString(0) == cod)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

                dbReader.Close();
                DbConnection.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);
            }

            //Suponiendo que no tiene filas
            return true;

        }

    }
}
