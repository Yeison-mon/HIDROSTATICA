using System;
using System.Data;
using System.Threading.Tasks;
using Npgsql;

namespace MIS.Helpers
{
    public class PostgreSQLHelper
    {
        private static PostgreSQLHelper instance;
        private readonly string connectionString;
        //private readonly ApplicationDbContext _dbContext;

        private PostgreSQLHelper()
        {
            string host = "";
            string password = "";
            if (true)
            {
                FG.Url = "localhost";
                password = "integration";
            } else
            {
                FG.Url = "localhost";
                password = "INTEGRATION2021";
            }
            
            
            int port = 5432;
            string database = "hidrostatica";
            string username = "postgres";
            connectionString = $"Host={FG.Url};Port={port};Database={database};Username={username};Password={password};";
            //var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            //optionsBuilder.UseNpgsql($"UserID=postgres;Password={password};Host={FG.Url};Port={port};Database={database};Pooling=true;");
            //_dbContext = new ApplicationDbContext(optionsBuilder.Options);
        }

        public static PostgreSQLHelper GetInstance()
        {
            if (instance == null)
            {
                instance = new PostgreSQLHelper();
            }
            return instance;
        }

        public async Task<DataTable> ExecuteQueryAsync(string query)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            await Task.Run(() => adapter.Fill(dataTable));
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FG.ShowError("Error al conectarse a la base de datos: " + ex.Message, "Error");
                return null;
            }
        }
        public object ExecuteScalar(string query)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (NpgsqlCommand command = new NpgsqlCommand(query, connection, transaction))
                            {
                                object result = command.ExecuteScalar();
                                transaction.Commit(); // Confirmar la transacción si no hubo errores
                                return result;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Rollback en caso de error
                            transaction.Rollback();
                            FG.ShowError("Error al ejecutar la consulta: " + ex.Message, "Error");
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FG.ShowError("Error al conectarse a la base de datos: " + ex.Message, "Error");
                return null;
            }
        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (NpgsqlCommand command = new NpgsqlCommand(query, connection, transaction))
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                                transaction.Commit();
                                return rowsAffected;
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            FG.ShowError("Error al ejecutar la consulta: " + ex.Message, "Error");
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FG.ShowError("Error al conectarse a la base de datos: " + ex.Message, "Error");
                return 0;
            }
        }



        public async Task<object> ExecuteScalarAsync(string query)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (NpgsqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (NpgsqlCommand command = new NpgsqlCommand(query, connection, transaction))
                            {
                                // Ejecutar la consulta y devolver el primer resultado
                                object result = await command.ExecuteScalarAsync();
                                transaction.Commit();
                                return result;
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            FG.ShowError("Error al ejecutar la consulta: " + ex.Message, "Error");
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FG.ShowError("Error al conectarse a la base de datos: " + ex.Message, "Error");
                return null;
            }
        }


    }
}
