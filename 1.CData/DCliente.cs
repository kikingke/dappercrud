using CEntities;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace CDatos
{
    public class DCliente
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["CRUDAPPER"].ToString();

        public List<Cliente> GetClientes()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                return sqlConnection.Query<Cliente>("sp_select_Clientes", commandType: CommandType.StoredProcedure).Reverse().ToList();
            }

        }
        public List<Cliente> GetClientesActivos()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                 return sqlConnection.Query<Cliente>("sp_select_Clientes_Actives", commandType: CommandType.StoredProcedure).Reverse().ToList();
            }
            
        }

        public List<Cliente> GetClientesInactivos()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                return sqlConnection.Query<Cliente>("sp_select_Clientes_Inactives", commandType: CommandType.StoredProcedure).Reverse().ToList();
            }

        }

        public int GetTotalCount()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                const string query = @"SELECT count(*) FROM CLIENTE";
                return sqlConnection.ExecuteScalar<int>(query, CommandType.Text);
            }

        }


        public int AddCliente(Cliente objCliente) {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    var parameters = new DynamicParameters();
                    //parameters.Add("Cliente_ID", objCliente.Cliente_ID, DbType.Int32);
                    parameters.Add("@Cliente_Codigo", objCliente.Cliente_Codigo, DbType.String);
                    parameters.Add("@Cliente_Nombre", objCliente.Cliente_Nombre, DbType.String);
                    parameters.Add("@Cliente_Apellido", objCliente.Cliente_Apellido, DbType.String);
                    parameters.Add("@Cliente_Telefono", objCliente.Cliente_Telefono, DbType.String);
                    parameters.Add("@Cliente_Direccion", objCliente.Cliente_Direccion, DbType.String);
                    parameters.Add("@Cliente_Status", objCliente.Cliente_Status, DbType.Boolean);
                    int response = sqlConnection.Execute("sp_insert_Cliente", parameters, commandType: CommandType.StoredProcedure);
                    return response;
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }

        public int UpdateCliente(Cliente objCliente)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("Cliente_ID", objCliente.Cliente_ID, DbType.Int32);
                parameters.Add("@Cliente_Codigo", objCliente.Cliente_Codigo, DbType.String);
                parameters.Add("@Cliente_Nombre", objCliente.Cliente_Nombre, DbType.String);
                parameters.Add("@Cliente_Apellido", objCliente.Cliente_Apellido, DbType.String);
                parameters.Add("@Cliente_Telefono", objCliente.Cliente_Telefono, DbType.String);
                parameters.Add("@Cliente_Direccion", objCliente.Cliente_Direccion, DbType.String);
                parameters.Add("@Cliente_Status", objCliente.Cliente_Status, DbType.Boolean);
                int response = sqlConnection.Execute("sp_update_Cliente", parameters, commandType: CommandType.StoredProcedure);
                return response;
            }
        }

        public int DeleteCliente(Cliente objCliente)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("Cliente_ID", objCliente.Cliente_ID, DbType.Int32);
                return sqlConnection.Execute("sp_delete_Cliente", parameters, commandType: CommandType.StoredProcedure);
            }
        }


    }
}
