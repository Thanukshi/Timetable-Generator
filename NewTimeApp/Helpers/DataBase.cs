using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;

namespace NewTimeApp
{
    class DataBase
    {
        /*static void Main(string[] args)
        {
            SQLiteConnection connection;
            connection = CreateConnection();
            CreateTable(connection);
           // InsertData(connection);
            //ReadData(connection);
        }*/

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection connection;
            // Create a new database connection:
            connection = new SQLiteConnection("Data Source= database.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {

            }
            return connection;
        }

        static void CreateTable(SQLiteConnection connection)
        {

            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE SampleTable" +
                "(Col1 VARCHAR(20), Col2 INT)";

            string Createsql1 = "CREATE TABLE SampleTable1" +
                "(Col1 VARCHAR(20), Col2 INT)";
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();

        }
    }
}
