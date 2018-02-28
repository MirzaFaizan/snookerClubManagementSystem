using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using System.Web;
using System.Data.OleDb;

namespace snooker
{
    class ConnectToDB
    {


        private SqlConnection DBConnection;
        private SqlDataAdapter DataAdapter;
        private DataSet ResultSet;
        private SqlCommand QueryCommand;
        private SqlDataReader QueryResultReader;

        public ConnectToDB() { }



        public void ConnectToDataBase()
        {
            DBConnection = new SqlConnection(@"Data Source=DESKTOP-OG2785K\FAIZAN;Initial Catalog=faizan;Integrated Security=True;Pooling=False");
            DBConnection.Open();
            ResultSet = new DataSet();
        }

        public DataSet ExceuteQuerySet(String Query)
        {
            DataAdapter = new SqlDataAdapter(Query, DBConnection);
            DataAdapter.Fill(ResultSet, "players");
            DataAdapter.Dispose();
            return ResultSet;
        }

        public SqlDataReader ExceuteQuery(String Query)
        {
            QueryCommand = new SqlCommand(Query, DBConnection);
            QueryResultReader = QueryCommand.ExecuteReader();
            QueryCommand.Dispose();
            return QueryResultReader;
        }

        public int UpdateQuery(String Query)
        {
            int Result = -1;
            try
            {
                QueryCommand = new SqlCommand(Query, DBConnection);
                Result = QueryCommand.ExecuteNonQuery();
                QueryCommand.Dispose();
            }
            catch (SqlException sq)
            {
                Result = -1;
            }

            return Result;
        }

        public int UpdateQuerySet(DataSet ds, String Query)
        {
            DataAdapter = new SqlDataAdapter(Query, DBConnection);
            DataAdapter.Fill(ResultSet);
            ResultSet = ds.Copy();
            int Result = DataAdapter.Update(ResultSet);
            DataAdapter.Dispose();
            return Result;
        }

        public object SpecificQuery(String Query)
        {
            QueryCommand = new SqlCommand(Query, DBConnection);
            object Result = QueryCommand.ExecuteScalar();
            QueryCommand.Dispose();
            return Result;
        }

        public void CloseConnection()
        {
            DBConnection.Close();
        }
    }
}
