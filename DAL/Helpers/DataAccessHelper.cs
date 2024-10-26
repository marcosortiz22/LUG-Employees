using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Helpers;

public class DataAccessHelper
{
    private string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

    public DataTable GetDataTable(string commandText, Dictionary<string, object> parameters = null)
    {
        DataTable dataTable = new DataTable();

        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(GetCommand(commandText, connection, parameters));
            adapter.Fill(dataTable);
        }

        return dataTable;
    }

    public int ExecuteNonQuery(string commandText, Dictionary<string, object> parameters = null)
    {
        using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
        {
            connection.Open();
            using (SqlCommand command = GetCommand(commandText, connection, parameters))
            {
                return command.ExecuteNonQuery();
            }
        }
    }

    public DataSet GetDataSet(string query)
    {
        DataSet dataSet = new DataSet();

        using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dataSet);
        }

        return dataSet;
    }

    public object ExecuteScalar(string commandText, Dictionary<string, object> parameters = null)
    {
        object result;

        using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
        {
            connection.Open();
            using (SqlCommand command = GetCommand(commandText, connection, parameters))
            {
                result = command.ExecuteScalar();
            }
        }

        return result;
    }

    public SqlConnection GetConnection()
    {
        var connection = new SqlConnection(CONNECTION_STRING);
        return connection;
    }

    public SqlCommand GetCommand(string query, SqlConnection connection, Dictionary<string, object> parameters = null)
    {
        SqlCommand command = new SqlCommand(query, connection);

        if (parameters != null)
        {
            SqlParameter[] sqlParameters = GetSqlParameters(parameters);
            command.Parameters.AddRange(sqlParameters);
        }

        return command;
    }

    public SqlDataReader GetDataReader(SqlCommand command)
    {
        return command.ExecuteReader();
    }

    private SqlParameter[] GetSqlParameters(Dictionary<string, object> parameters)
    {
        var sqlParameters = new List<SqlParameter>();
        foreach (var parameter in parameters)
        {
            var sqlParameter = new SqlParameter(parameter.Key, parameter.Value);
            sqlParameters.Add(sqlParameter);
        }
        return sqlParameters.ToArray();
    }
}
